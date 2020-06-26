using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CacheMon
{

    public static partial class Runtime
    {

		public static System.Threading.Timer dataThread;
		public static Timer uiThread = new Timer();


		public static Container SystrayIconContainer = new Container();
		public static NotifyIcon SystrayIcon = new NotifyIcon(SystrayIconContainer)
		{
			Icon = new Icon(CacheMon.Resources.app_white, SystemInformation.SmallIconSize),
			Text = Program.AppName,
			ContextMenuStrip = new ContextMenuStrip()
		};

		public static void SystrayMenu_RightClick(object sender, CancelEventArgs e)
        {
			e.Cancel = false;
			SystrayIcon.ContextMenuStrip.Items.Clear();
			
			if (uiThread.Enabled)
            {
				SystrayIcon.ContextMenuStrip.Items.Add("&Stop Monitoring", null, ToggleMonitoringHandler);
            }
			else
            {
				SystrayIcon.ContextMenuStrip.Items.Add("&Start Monitoring", null, ToggleMonitoringHandler);
			}

			SystrayIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
			SystrayIcon.ContextMenuStrip.Items.Add("&Restore", null, Program.ShowWin);
			SystrayIcon.ContextMenuStrip.Items.Add("&Exit", null, Program.ExitHandler);
			
        }


		public static double MemCalc(string memItem)
		{
			double _result = 0;

			switch (memItem)
			{
				case "PhysTotal":
					_result = (Var.PhysTotalMem * Var.SystemPageSize);
					break;

				case "PhysFree":
					_result = (Var.PhysFreeMem * Var.SystemPageSize);
					break;

				case "PhysInUse":
					_result = (Var.PhysInUseMem * Var.SystemPageSize);
					break;

				case "PhysUnused":
					_result = (Var.PhysUnusedMem * Var.SystemPageSize);
					break;

				case "SystemCache":
					_result = (Var.SystemCacheMem * Var.SystemPageSize);
					break;

				case "KernelTotal":
					_result = (Var.KernelTotalMem * Var.SystemPageSize);
					break;

				case "KernelPhys":
					_result = (Var.KernelPhysMem * Var.SystemPageSize);
					break;

				case "KernelVirt":
					_result = (Var.KernelVirtMem * Var.SystemPageSize);
					break;

				case "CompressedInUse":
					_result = (Var.SystemCompressed);
					break;

				case "ModifiedInUse":
					_result = (Var.ModifiedInUse * Var.SystemPageSize);
					break;


				default:
					break;

			}

			return Math.Round((_result / 1048576),1);
		}

		public static void UpdateCounters()
		{

			Enums.PERFORMANCE_INFORMATION ProcInfo = WinNT.GetPerfInfo();
			Enums.SYSTEM_MEMORY_LIST_INFORMATION MemInfo = WinNT.GetMemListInfo();
			Enums.COMPRESSION_INFO CompInfo = WinNT.GetCompressionInfo();

			Var.SystemCompressed = (ulong)CompInfo.CompressionWorkingSetSize;

			double _standbyPages = 0;
			for (int i = 0; i < MemInfo.PageCountByPriority.Length; i++ )
            {
				_standbyPages += MemInfo.PageCountByPriority[i];
            }
			Var.SystemCacheMem = _standbyPages;


			Var.SystemPageSize = ProcInfo.PageSize.ToUInt64();
			
			Var.PhysTotalMem = ProcInfo.PhysicalTotal.ToUInt64();			
			Var.PhysUnusedMem = ProcInfo.PhysicalAvailable.ToUInt64();

			Var.PhysInUseMem = (Var.PhysTotalMem - Var.PhysUnusedMem);

			Var.CommitTotal = ProcInfo.CommitTotal.ToUInt64();

			Var.ModifiedCached = MemInfo.ModifiedPageCountPageFile;
			Var.ModifiedInUse = MemInfo.ModifiedPageCount + MemInfo.ModifiedNoWritePageCount;

			Var.KernelTotalMem = ProcInfo.KernelTotal.ToUInt64();
			Var.KernelVirtMem = ProcInfo.KernelPaged.ToUInt64();
			Var.KernelPhysMem = ProcInfo.KernelNonpaged.ToUInt64();

			Var.PhysFreeMem = MemInfo.ZeroPageCount;

		}

		public static void UpdateCountersHandler(object stateData) 
		{
			UpdateCounters();

			if (Var.IsFlushing)
            {
				Var.IsFlushing = false;
            } 
			else
            {
				if ((MemCalc("PhysFree") < Settings.FreeMemTriggerLimit) && (MemCalc("SystemCache") > Settings.StandbyListMinLimit))
                {
					Var.IsFlushing = true;
					FlushCache();
				}


			}
			

        }

		public static void FlushCache()
        {

			// purge working sets if set
			if (Settings.AggressiveMode)
            {


				foreach (Process pProcess in Process.GetProcesses())
                {
					
					WinNT.EmptyWorkingSet(pProcess);
					
				}

				

            }


			// purge standby cache lists
			bool _success = WinNT.MemoryPurgeStandbyLists();

			if (_success)
            {
				Var.FlushHistory++;
				Var.LastFlush = DateTime.Now;
            }

        }


		private static void ToggleMonitoringHandler(object sender, EventArgs e)
        {
			Program.CacheMonWin.btn_toggleMonitor_Click(sender, e);
        
        }


	}

	

}
