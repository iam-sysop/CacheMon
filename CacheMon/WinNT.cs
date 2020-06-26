using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Security.Principal;
using static CacheMon.Enums;


namespace CacheMon
{
    public class WinNT
    {
        #region NTPermissions

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, EntryPoint = "LookupPrivilegeValue", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private static extern bool _LookupPrivilegeValue(string lpSystemName, string lpName, ref SYSTEM_LUID lpLuid);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, EntryPoint = "AdjustTokenPrivileges", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private static extern bool _AdjustTokenPrivileges(IntPtr hToken, bool bDisable, ref TOKEN_PRIVILEGES currentState, int lastStateLength, IntPtr hLastState, IntPtr currentStateLength);

        #endregion


        #region NTSystemInfo

        [DllImport("psapi.dll", CharSet = CharSet.Auto, EntryPoint = "GetPerformanceInfo", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private static extern bool _GetPerformanceInfo(ref PERFORMANCE_INFORMATION pPerformanceInformation, uint cb);

        [DllImport("ntdll.dll", CharSet = CharSet.Auto, EntryPoint = "NtQuerySystemInformation", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private static extern uint _NtQuerySystemInformation(SYSTEM_INFORMATION_CLASS NtSystemInformationClass, [In, Out] IntPtr hBuffer, ulong hBufferSizeIn, [Out] out ulong hBufferSizeOut);

        #endregion


        #region NTMemControl

        [DllImport("ntdll.dll", CharSet = CharSet.Auto, EntryPoint = "NtSetSystemInformation", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private static extern uint _NtSetSystemInformation(SYSTEM_INFORMATION_CLASS NtSystemInformationClass, [In, Out] int[] hParameters, ulong hBufferSizeIn);

        [DllImport("psapi.dll", CharSet = CharSet.Auto, EntryPoint = "EmptyWorkingSet", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private static extern bool _EmptyWorkingSet(IntPtr hHandle);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "OpenProcess", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private static extern IntPtr _OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        #endregion

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CloseProcess", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private static extern bool _ReleaseProcess(IntPtr hProcess);


        public static PERFORMANCE_INFORMATION GetPerfInfo()
        {
            PERFORMANCE_INFORMATION _memData = new PERFORMANCE_INFORMATION();

            _memData.cb = (uint)Marshal.SizeOf(_memData);


            if (!_GetPerformanceInfo(ref _memData, _memData.cb))
            {
                string errorMessage = new Win32Exception(Marshal.GetLastWin32Error()).Message;
                if (Marshal.GetLastWin32Error() != 0) Console.WriteLine("MARSHAL ERROR: " + errorMessage);
            }

            return _memData;

        }


        public static COMPRESSION_INFO GetCompressionInfo()
        {
            COMPRESSION_INFO _compInfo = new COMPRESSION_INFO();

            Process[] _procList = Process.GetProcessesByName("Memory Compression");

            if (_procList.Length == 1)
            {

                _compInfo.Version = 3;
                _compInfo.CompressionWorkingSetSize = _procList[0].WorkingSet64;
                _compInfo.CompressionPid = _procList[0].Id;

            }


            return _compInfo;

        }


        public static SYSTEM_MEMORY_LIST_INFORMATION GetMemListInfo()
        {

            int _memListLengthIn = sizeof(long) * 22;
            IntPtr _hMemListData = Marshal.AllocHGlobal(_memListLengthIn);

            uint _status = _NtQuerySystemInformation(SYSTEM_INFORMATION_CLASS.SystemMemoryListInformation, _hMemListData, (ulong)_memListLengthIn, out ulong _memListLengthOut);

            if (_status != 0)
            {
                string errorMessage = new Win32Exception(Marshal.GetLastWin32Error()).Message;
                if (Marshal.GetLastWin32Error() != 0) Console.WriteLine("MARSHAL ERROR: " + errorMessage);
                Marshal.FreeHGlobal(_hMemListData);
                return new SYSTEM_MEMORY_LIST_INFORMATION();
            }


            SYSTEM_MEMORY_LIST_INFORMATION _memListData = (SYSTEM_MEMORY_LIST_INFORMATION)Marshal.PtrToStructure(_hMemListData, typeof(SYSTEM_MEMORY_LIST_INFORMATION));

            // copy to new struct and return that to avoid some weird 
            // memory corruption issue with pInvoke when freeing handle later.
            SYSTEM_MEMORY_LIST_INFORMATION _memListCopy = _memListData;

            Marshal.FreeHGlobal(_hMemListData);
            return _memListCopy;


        }


        public static bool GetLuidInfo(SE_PRIVILEGE _requestedPrivilege, out SYSTEM_LUID _luid)
        {
            SYSTEM_LUID _luidInternal = new SYSTEM_LUID();
            string _sePrivilege = SE_PRIVILEGE_STR(_requestedPrivilege);

            try
            {
                if (_sePrivilege.Length == 0)
                {
                    throw new InvalidEnumArgumentException("SE_PRIVILEGE INVALID");
                }

                if (_LookupPrivilegeValue(null, _sePrivilege, ref _luidInternal))
                {
                    _luid = _luidInternal;
                    return true;
                }

                else
                {
                    var win32Exception = new Win32Exception();
                    var exceptionMessage = string.Format("GetLuidInfo failed. REQUESTED: {0}", _sePrivilege);
                    throw new InvalidOperationException(exceptionMessage, win32Exception);
                }
            }
            catch (Exception e)
            {
                var exceptionMessage = string.Format("Internal Exception: ERROR REQUESTING: {0}", _sePrivilege);
                throw new InvalidOperationException(exceptionMessage, e);
            }


        }


        public static bool UpdateChangePermissions([In, Out] WindowsIdentity _context, bool _disable, [In, Out] TOKEN_PRIVILEGES _tokenPrivileges)
        {
            IntPtr _returnSize = IntPtr.Zero;

            if (_AdjustTokenPrivileges(_context.Token, _disable, ref _tokenPrivileges, 1024, IntPtr.Zero, _returnSize))
            {
                var lastError = (uint)Marshal.GetLastWin32Error();
                if (lastError == (uint)NTSTATUS.ERROR_NOT_ALL_ASSIGNED)
                {
                    var win32Exception = new Win32Exception();
                    throw new InvalidOperationException("AdjustTokenPrivileges failed.", win32Exception);
                }
                else
                {

                    return true;
                }
            }
            else
            {
                var win32Exception = new Win32Exception();
                throw new InvalidOperationException("AdjustTokenPrivileges failed.", win32Exception);
            }

        }


        public static bool EmptyWorkingSet(Process _process)
        {

            IntPtr _pHandle = _OpenProcess((uint)(PROCESS_ACCESS_RIGHTS.PROCESS_QUERY_INFORMATION | PROCESS_ACCESS_RIGHTS.PROCESS_SET_INFORMATION), false, _process.Id);            

            bool _emptyStatus = _EmptyWorkingSet(_pHandle);

            _ReleaseProcess(_pHandle);

            return _emptyStatus;
        }


        public static bool MemoryPurgeStandbyLists()
        {
            int[] _purgeMemLists = new int[] { (int)SYSTEM_MEMORY_LIST_COMMAND.MemoryPurgeStandbyList };
            int _purgeMemListsLength = (sizeof(int) * _purgeMemLists.Length);

            uint _status = _NtSetSystemInformation(SYSTEM_INFORMATION_CLASS.SystemMemoryListInformation, _purgeMemLists, (uint)_purgeMemListsLength);
            
            if (_status != 0)
            {

                return false;
                /*
                
                Win32Exception errorMessage = new Win32Exception(Marshal.GetLastWin32Error());
                if (Marshal.GetLastWin32Error() != 0)
                {
                    throw new InvalidOperationException("MemoryPurgeStandbyListsFailed.", errorMessage);
                }

                */

            }

            return true;

        }

        /*
        [DllImport("kernel32.dll")]
        public static extern bool SetSystemFileCacheSize(IntPtr MinimumFileCacheSize, IntPtr MaximumFileCacheSize, int Flags);

        */









    }
}
