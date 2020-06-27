using System;
using System.Runtime.InteropServices;

namespace CacheMon
{
	public static class Enums
	{

		public enum NTSTATUS : uint
		{
			STATUS_SUCCESS = 0x00000000,
			STATUS_SE_PRIVILEGE_ENABLED = 0x00000002,
			STATUS_NOT_ALL_ASSIGNED = 0x00000106,
			ERROR_NOT_ALL_ASSIGNED = 0x00000514,
			STATUS_INVALID_PARAMETER = 0xc000000d,
			STATUS_PRIVILEGE_NOT_HELD = 0xc0000061


		}

		public enum SE_PRIVILEGE : uint
		{
			SE_CREATE_TOKEN_PRIVILEGE = 0x00000001,
			SE_ASSIGN_PRIMARY_TOKEN_PRIVILEGE = 0x00000002,
			SE_LOCK_MEMORY_PRIVILEGE = 0x00000003,
			SE_INCREASE_QUOTA_PRIVILEGE = 0x00000004,
			SE_UNSOLICITED_INPUT_PRIVILEGE = 0x00000005,
			SE_MACHINE_ACCOUNT_PRIVILEGE = 0x00000006,
			SE_MACHINE_TCB_PRIVILEGE = 0x00000007,
			SE_SECURITY_PRIVILEGE = 0x00000008,
			SE_TAKE_OWNERSHIP_PRIVILEGE = 0x00000009,
			SE_LOAD_DRIVER_PRIVILEGE = 0x0000000a,
			SE_SYSTEM_PROFILE_PRIVILEGE = 0x0000000b,
			SE_SYSTEM_TIME_PRIVILEGE = 0x0000000c,
			SE_PROFILE_SINGLE_PROCESS_PRIVILEGE = 0x0000000d,
			SE_INCREASE_BASE_PRIORITY_PRIVILEGE = 0x0000000e,
			SE_CREATE_PAGEFILE_PRIVILEGE = 0x0000000f,
			SE_CREATE_PERMANENT_PRIVILEGE = 0x00000010,
			SE_BACKUP_PRIVILEGE = 0x00000011,
			SE_RESTORE_PRIVILEGE = 0x00000012,
			SE_SHUTDOWN_PRIVILEGE = 0x00000013,
			SE_DEBUG_PRIVILEGE = 0x00000014,
			SE_AUDIT_PRIVILEGE = 0x00000015,
			SE_SYSTEM_ENVIRONMENT_PRIVILEGE = 0x00000016,
			SE_CHANGE_NOTIFY_PRIVILEGE = 0x00000017,
			SE_REMOTE_SHUTDOWN_PRIVILEGE = 0x00000018,
			SE_UNLOCK_PRIVILEGE = 0x00000019,
			SE_SYNC_AGENT_PRIVILEGE = 0x0000001a,
			SE_ENABLE_DELEGATION_PRIVILEGE = 0x0000001b,
			SE_MANAGE_VOLUME_PRIVILEGE = 0x0000001c,
			SE_IMPERSONATE_PRIVILEGE = 0x0000001d,
			SE_CREATE_GLOBAL_PRIVILEGE = 0x0000001e,
			SE_TRUSTED_CRED_MAN_ACCESS_PRIVILEGE = 0x0000001f,
			SE_RELABEL_PRIVILEGE = 0x00000020,
			SE_INCREASE_WORKING_SET_PRIVILEGE = 0x00000021,
			SE_TIME_ZONE_PRIVILEGE = 0x00000022,
			SE_CREATE_SYMBOLIC_LINK_PRIVILEGE = 0x00000023,
			

		}

		public static string SE_PRIVILEGE_STR(SE_PRIVILEGE sPrivilege) 
		{
			switch (sPrivilege) {
				case SE_PRIVILEGE.SE_CREATE_TOKEN_PRIVILEGE:
					return "SeCreateTokenPrivilege";
				case SE_PRIVILEGE.SE_ASSIGN_PRIMARY_TOKEN_PRIVILEGE:
					return "SeAssignPrimaryTokenPrivilege";
				case SE_PRIVILEGE.SE_LOCK_MEMORY_PRIVILEGE:
					return "SeLockMemoryPrivilege";
				case SE_PRIVILEGE.SE_INCREASE_QUOTA_PRIVILEGE:
					return "SeIncreaseQuotaPrivilege";
				case SE_PRIVILEGE.SE_UNSOLICITED_INPUT_PRIVILEGE:
					return "SeUnsolicitedInputPrivilege";
				case SE_PRIVILEGE.SE_MACHINE_ACCOUNT_PRIVILEGE:
					return "SeMachineAccountPrivilege";
				case SE_PRIVILEGE.SE_MACHINE_TCB_PRIVILEGE:
					return "SeMachineTcbPrivilege";
				case SE_PRIVILEGE.SE_SECURITY_PRIVILEGE:
					return "SeSecurityPrivilege";
				case SE_PRIVILEGE.SE_TAKE_OWNERSHIP_PRIVILEGE:
					return "SeTakeOwnershipPrivilege";
				case SE_PRIVILEGE.SE_LOAD_DRIVER_PRIVILEGE:
					return "SeLoadDriverPrivilege";
				case SE_PRIVILEGE.SE_SYSTEM_PROFILE_PRIVILEGE:
					return "SeSystemProfilePrivilege";
				case SE_PRIVILEGE.SE_SYSTEM_TIME_PRIVILEGE:
					return "SeSystemTimePrivelege";
				case SE_PRIVILEGE.SE_PROFILE_SINGLE_PROCESS_PRIVILEGE:
					return "SeProfileSingleProcessPrivilege";
				case SE_PRIVILEGE.SE_INCREASE_BASE_PRIORITY_PRIVILEGE:
					return "SeIncreaseBasePriorityPrivilege";
				case SE_PRIVILEGE.SE_CREATE_PAGEFILE_PRIVILEGE:
					return "SeCreatePagefilePrivilege";
				case SE_PRIVILEGE.SE_CREATE_PERMANENT_PRIVILEGE:
					return "SeCreatePermanentPrivilege";
				case SE_PRIVILEGE.SE_BACKUP_PRIVILEGE:
					return "SeBackupPrivilege";
				case SE_PRIVILEGE.SE_RESTORE_PRIVILEGE:
					return "SeRestorePrivilege";
				case SE_PRIVILEGE.SE_SHUTDOWN_PRIVILEGE:
					return "SeShutdownPrivilege";
				case SE_PRIVILEGE.SE_DEBUG_PRIVILEGE:
					return "SeDebugPrivilege";
				case SE_PRIVILEGE.SE_AUDIT_PRIVILEGE:
					return "SeAuditPrivilege";
				case SE_PRIVILEGE.SE_SYSTEM_ENVIRONMENT_PRIVILEGE:
					return "SeSystemEnvironmentPrivilege";
				case SE_PRIVILEGE.SE_CHANGE_NOTIFY_PRIVILEGE:
					return "SeChangeNotifyPrivilege";
				case SE_PRIVILEGE.SE_REMOTE_SHUTDOWN_PRIVILEGE:
					return "SeRemoteShutdownPrivilege";
				case SE_PRIVILEGE.SE_UNLOCK_PRIVILEGE:
					return "SeUnlockPrivilege";
				case SE_PRIVILEGE.SE_SYNC_AGENT_PRIVILEGE:
					return "SeSyncAgentPrivilege";
				case SE_PRIVILEGE.SE_ENABLE_DELEGATION_PRIVILEGE:
					return "SeEnableDelegationPrivilege";
				case SE_PRIVILEGE.SE_MANAGE_VOLUME_PRIVILEGE:
					return "SeManageVolumePrivilege";
				case SE_PRIVILEGE.SE_IMPERSONATE_PRIVILEGE:
					return "SeImpersonatePrivilege";
				case SE_PRIVILEGE.SE_CREATE_GLOBAL_PRIVILEGE:
					return "SeCreateGlobalPrivilege";
				case SE_PRIVILEGE.SE_TRUSTED_CRED_MAN_ACCESS_PRIVILEGE:
					return "SeTrustedCredManAccessPrivilege";
				case SE_PRIVILEGE.SE_RELABEL_PRIVILEGE:
					return "SeRelabelPrivilege";
				case SE_PRIVILEGE.SE_INCREASE_WORKING_SET_PRIVILEGE:
					return "SeIncreaseWorkingSetPrivilege";
				case SE_PRIVILEGE.SE_TIME_ZONE_PRIVILEGE:
					return "SeTimeZonePrivilege";
				case SE_PRIVILEGE.SE_CREATE_SYMBOLIC_LINK_PRIVILEGE:
					return "SeCreateSymbolicLinkPrivilege";
				default:
					return "";


			}
		}

		public enum SYSTEM_INFORMATION_CLASS
		{
			SystemBasicInformation = 0x0000,
			SystemProcessorInformation = 0x0001,
			SystemPerformanceInformation = 0x0002,
			SystemTimeOfDayInformation = 0x0003,
			SystemPathInformation = 0x0004,
			SystemProcessInformation = 0x0005,
			SystemCallCountInformation = 0x0006,
			SystemDeviceInformation = 0x0007,
			SystemProcessorPerformanceInformation = 0x0008,
			SystemFlagsInformation = 0x0009,
			SystemCallTimeInformation = 0x000a,
			SystemModuleInformation = 0x000b,
			SystemLocksInformation = 0x000c,
			SystemStackTraceInformation = 0x000d,
			SystemPagedPoolInformation = 0x000e,
			SystemNonPagedPoolInformation = 0x000f,
			SystemHandleInformation = 0x0010,
			SystemObjectInformation = 0x0011,
			SystemPageFileInformation = 0x0012,
			SystemVdmInstemulInformation = 0x0013,
			SystemVdmBopInformation = 0x0014,
			SystemFileCacheInformation = 0x0015,
			SystemPoolTagInformation = 0x0016,
			SystemInterruptInformation = 0x0017,
			SystemDpcBehaviorInformation = 0x0018,
			SystemFullMemoryInformation = 0x0019,
			SystemLoadGdiDriverInformation = 0x001a,
			SystemUnloadGdiDriverInformation = 0x001b,
			SystemTimeAdjustmentInformation = 0x001c,
			SystemSummaryMemoryInformation = 0x001d,
			SystemMirrorMemoryInformation = 0x001e,
			SystemPerformanceTraceInformation = 0x001f,
			SystemCrashDumpInformation = 0x0020,
			SystemExceptionInformation = 0x0021,
			SystemCrashDumpStateInformation = 0x0022,
			SystemKernelDebuggerInformation = 0x0023,
			SystemContextSwitchInformation = 0x0024,
			SystemRegistryQuotaInformation = 0x0025,
			SystemExtendServiceTableInformation = 0x0026,
			SystemPrioritySeperation = 0x0027,
			SystemVerifierAddDriverInformation = 0x0028,
			SystemVerifierRemoveDriverInformation = 0x0029,
			SystemProcessorIdleInformation = 0x002a,
			SystemLegacyDriverInformation = 0x002b,
			SystemCurrentTimeZoneInformation = 0x002c,
			SystemLookasideInformation = 0x002d,
			SystemTimeSlipNotification = 0x002e,
			SystemSessionCreate = 0x002f,
			SystemSessionDetach = 0x0030,
			SystemSessionInformation = 0x0031,
			SystemRangeStartInformation = 0x0032,
			SystemVerifierInformation = 0x0033,
			SystemVerifierThunkExtend = 0x0034,
			SystemSessionProcessInformation = 0x0035,
			SystemLoadGdiDriverInSystemSpace = 0x0036,
			SystemNumaProcessorMap = 0x0037,
			SystemPrefetcherInformation = 0x0038,
			SystemExtendedProcessInformation = 0x0039,
			SystemRecommendedSharedDataAlignment = 0x003a,
			SystemComPlusPackage = 0x003b,
			SystemNumaAvailableMemory = 0x003c,
			SystemProcessorPowerInformation = 0x003d,
			SystemEmulationBasicInformation = 0x003e,
			SystemEmulationProcessorInformation = 0x003f,
			SystemExtendedHandleInformation = 0x0040,
			SystemLostDelayedWriteInformation = 0x0041,
			SystemBigPoolInformation = 0x0042,
			SystemSessionPoolTagInformation = 0x0043,
			SystemSessionMappedViewInformation = 0x0044,
			SystemHotpatchInformation = 0x0045,
			SystemObjectSecurityMode = 0x0046,
			SystemWatchdogTimerHandler = 0x0047,
			SystemWatchdogTimerInformation = 0x0048,
			SystemLogicalProcessorInformation = 0x0049,
			SystemWow64SharedInformationObsolete = 0x004a,
			SystemRegisterFirmwareTableInformationHandler = 0x004b,
			SystemFirmwareTableInformation = 0x004c,
			SystemModuleInformationEx = 0x004d,
			SystemVerifierTriageInformation = 0x004e,
			SystemSuperfetchInformation = 0x004f,
			SystemMemoryListInformation = 0x0050,
			SystemFileCacheInformationEx = 0x0051,
			SystemThreadPriorityClientIdInformation = 0x0052,
			SystemProcessorIdleCycleTimeInformation = 0x0053,
			SystemVerifierCancellationInformation = 0x0054,
			SystemProcessorPowerInformationEx = 0x0055,
			SystemRefTraceInformation = 0x0056,
			SystemSpecialPoolInformation = 0x0057,
			SystemProcessIdInformation = 0x0058,
			SystemErrorPortInformation = 0x0059,
			SystemBootEnvironmentInformation = 0x005a,
			SystemHypervisorInformation = 0x005b,
			SystemVerifierInformationEx = 0x005c,
			SystemTimeZoneInformation = 0x005d,
			SystemImageFileExecutionOptionsInformation = 0x005e,
			SystemCoverageInformation = 0x005f,
			SystemPrefetchPatchInformation = 0x0060,
			SystemVerifierFaultsInformation = 0x0061,
			SystemSystemPartitionInformation = 0x0062,
			SystemSystemDiskInformation = 0x0063,
			SystemProcessorPerformanceDistribution = 0x0064,
			SystemNumaProximityNodeInformation = 0x0065,
			SystemDynamicTimeZoneInformation = 0x0066,
			SystemCodeIntegrityInformation = 0x0067,
			SystemProcessorMicrocodeUpdateInformation = 0x0068,
			SystemProcessorBrandString = 0x0069,
			SystemVirtualAddressInformation = 0x006a,
			SystemLogicalProcessorAndGroupInformation = 0x006b,
			SystemProcessorCycleTimeInformation = 0x006c,
			SystemStoreInformation = 0x006d,
			SystemRegistryAppendString = 0x006e,
			SystemAitSamplingValue = 0x006f,
			SystemVhdBootInformation = 0x0070,
			SystemCpuQuotaInformation = 0x0071,
			SystemNativeBasicInformation = 0x0072,
			SystemErrorPortTimeouts = 0x0073,
			SystemLowPriorityIoInformation = 0x0074,
			SystemBootEntropyInformation = 0x0075,
			SystemVerifierCountersInformation = 0x0076,
			SystemPagedPoolInformationEx = 0x0077,
			SystemSystemPtesInformationEx = 0x0078,
			SystemNodeDistanceInformation = 0x0079,
			SystemAcpiAuditInformation = 0x007a,
			SystemBasicPerformanceInformation = 0x007b,
			SystemQueryPerformanceCounterInformation = 0x007c,
			SystemSessionBigPoolInformation = 0x007d,
			SystemBootGraphicsInformation = 0x007e,
			SystemScrubPhysicalMemoryInformation = 0x007f,
			SystemBadPageInformation = 0x0080,
			SystemProcessorProfileControlArea = 0x0081,
			SystemCombinePhysicalMemoryInformation = 0x0082,
			SystemEntropyInterruptTimingInformation = 0x0083,
			SystemConsoleInformation = 0x0084,
			SystemPlatformBinaryInformation = 0x0085,
			SystemThrottleNotificationInformation = 0x0086,
			SystemHypervisorProcessorCountInformation = 0x0087,
			SystemDeviceDataInformation = 0x0088,
			SystemDeviceDataEnumerationInformation = 0x0089,
			SystemMemoryTopologyInformation = 0x008a,
			SystemMemoryChannelInformation = 0x008b,
			SystemBootLogoInformation = 0x008c,
			SystemProcessorPerformanceInformationEx = 0x008d,
			SystemSpare0 = 0x008e,
			SystemSecureBootPolicyInformation = 0x008f,
			SystemPageFileInformationEx = 0x0090,
			SystemSecureBootInformation = 0x0091,
			SystemEntropyInterruptTimingRawInformation = 0x0092,
			SystemPortableWorkspaceEfiLauncherInformation = 0x0093,
			SystemFullProcessInformation = 0x0094,
			MaxSystemInfoClass = 0x0095
		}

		public enum SYSTEM_MEMORY_LIST_COMMAND
		{
			MemoryCaptureAccessedBits = 0x0000,
			MemoryCaptureAndResetAccessedBits = 0x0001,
			MemoryEmptyWorkingSets = 0x0002,
			MemoryFlushModifiedList = 0x0003,
			MemoryPurgeStandbyList = 0x0004,
			MemoryPurgeLowPriorityStandbyList = 0x0005,
			MemoryCommandMax = 0x0006
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct SYSTEM_LUID
		{
			public UInt32 LowPart;
			public UInt32 HighPart;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct SYSTEM_LUID_AND_ATTRIBUTES
		{
			public SYSTEM_LUID Luid;
			public UInt32 Attributes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct SYSTEM_LUID_INFO
		{
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpSystemName;
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpName;
			
			public SYSTEM_LUID lpLuid;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct SYSTEM_PURGE_MEMORY_LISTS
        {
			public int[] SystemMemoryListCommand;
        }

		[System.FlagsAttribute]
		public enum PROCESS_ACCESS_RIGHTS : uint
        {
			PROCESS_TERMINATE = 0x0001,
			PROCESS_CREATE_THREAD = 0x0002, 
			PROCESS_VM_OPERATION = 0x0008,
			PROCESS_VM_READ = 0x0010,
			PROCESS_VM_WRITE = 0x0020,
			PROCESS_DUP_HANDLE = 0x0040,
			PROCESS_CREATE_PROCESS = 0x0080,
			PROCESS_SET_INFORMATION = 0x0200,
			PROCESS_QUERY_INFORMATION = 0x0400,
			PROCESS_SUSPEND_RESUME = 0x0800,
			PROCESS_QUERY_LIMITED_INFORMATION = 0x1000,
			PROCESS_SET_LIMITED_INFORMATION = 0x2000,			
			PROCESS_ALL_ACCESS = (
				ACCESS_RIGHTS.STANDARD_RIGHTS_REQUIRED | 
				ACCESS_RIGHTS.SYNCHRONIZE | 
				ACCESS_RIGHTS.SPECIFIC_RIGHTS_ALL
			)


		}

		[System.FlagsAttribute]
		public enum ACCESS_RIGHTS : uint
		{
			GENERIC_READ = 0x80000000,
			GENERIC_WRITE =	0x40000000,
			GENERIC_EXECUTE = 0x20000000,
			GENERIC_ALL = 0x10000000,
			DELETE = 0x00010000,
			READ_CONTROL = 0x00020000,
			WRITE_DAC =	0x00040000,
			WRITE_OWNER = 0x00080000,
			SYNCHRONIZE = 0x00100000,
			STANDARD_RIGHTS_REQUIRED = 0x000F0000,
			STANDARD_RIGHTS_READ = READ_CONTROL,
			STANDARD_RIGHTS_WRITE = READ_CONTROL,
			STANDARD_RIGHTS_EXECUTE = READ_CONTROL,
			STANDARD_RIGHTS_ALL = 0x001F0000,
			SPECIFIC_RIGHTS_ALL = 0x0000FFFF
		}

		[System.FlagsAttribute]
		public enum TOKEN_RIGHTS : uint
		{

			TOKEN_ASSIGN_PRIMARY = 0x0001,
			TOKEN_DUPLICATE = 0x0002,
			TOKEN_IMPERSONATE = 0x0004,
			TOKEN_QUERY = 0x0008,
			TOKEN_QUERY_SOURCE = 0x0010,
			TOKEN_ADJUST_PRIVILEGES = 0x0020,
			TOKEN_ADJUST_GROUPS = 0x0040,
			TOKEN_ADJUST_DEFAULT = 0x0080,
			TOKEN_ADJUST_SESSIONID = 0x0100,
			TOKEN_READ = TOKEN_QUERY,
			TOKEN_ALL_ACCESS = (
				ACCESS_RIGHTS.STANDARD_RIGHTS_REQUIRED |
				TOKEN_ASSIGN_PRIMARY |
				TOKEN_DUPLICATE |
				TOKEN_IMPERSONATE |
				TOKEN_QUERY |
				TOKEN_QUERY_SOURCE |
				TOKEN_ADJUST_PRIVILEGES |
				TOKEN_ADJUST_GROUPS |
				TOKEN_ADJUST_DEFAULT |
				TOKEN_ADJUST_SESSIONID
				)
		}

		public enum ADJUST_PRIVILIGE_CMD : uint
		{
			SE_PRIVILEGE_ENABLED_BY_DEFAULT = 0x00000001,
			SE_PRIVILEGE_ENABLED = 0x00000002,
			SE_PRIVILEGE_REMOVED = 0x00000004,
			SE_PRIVILEGE_USED_FOR_ACCESS = 0x80000000,
			SE_PRIVILEGE_VALID_ATTRIBUTES = (
				SE_PRIVILEGE_ENABLED_BY_DEFAULT |
				SE_PRIVILEGE_ENABLED |
				SE_PRIVILEGE_REMOVED |
				SE_PRIVILEGE_USED_FOR_ACCESS
				)
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct TOKEN_PRIVILEGES
		{
			public UInt32 PrivilegeCount;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
			public SYSTEM_LUID_AND_ATTRIBUTES[] Priviliges;
			
		}

		public struct COMPRESSION_INFO
		{
			
			public int Version;			
			public int CompressionPid;
			public long CompressionWorkingSetSize;
			public long CompressSize;
			public long CompressedSize;
			public long NonCompressedSize;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct SYSTEM_MEMORY_LIST_INFORMATION
		{

			public ulong ZeroPageCount;
			public ulong FreePageCount;
			public ulong ModifiedPageCount;
			public ulong ModifiedNoWritePageCount;
			public ulong BadPageCount;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public ulong[] PageCountByPriority;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			public ulong[] RepurposedPagesByPriority;

			public ulong ModifiedPageCountPageFile;

		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PERFORMANCE_INFORMATION
		{
			public uint cb;

			public UIntPtr CommitTotal;
			public UIntPtr CommitLimit;
			public UIntPtr CommitPeak;
			public UIntPtr PhysicalTotal;
			public UIntPtr PhysicalAvailable;
			public UIntPtr SystemCache;
			public UIntPtr KernelTotal;
			public UIntPtr KernelPaged;
			public UIntPtr KernelNonpaged;
			public UIntPtr PageSize;

			public uint HandleCount;
			public uint ProcessCount;
			public uint ThreadCount;

		}

		

	}
}
