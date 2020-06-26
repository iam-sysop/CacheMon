using System;
using System.Windows.Forms;


namespace CacheMon
{
    public partial class StatusWin : Form
    {
        public StatusWin()
        {
            InitializeComponent();

            LoadSettings();

            Runtime.uiThread.Tick += new EventHandler(UpdateStats);
            Runtime.uiThread.Interval = Runtime.Settings.PollInterval;
            Runtime.uiThread.Enabled = true;

            this.btn_toggleMonitor.Text = "Stop";
            this.lblAppNameStatic.Text = string.Concat(Program.AppName, " v", Program.AppVersion);
            Runtime.SystrayIcon.Text = string.Concat(Program.AppName, " ", (Runtime.uiThread.Enabled ? "Running" : "Stopped"));

        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        public void btn_toggleMonitor_Click(object sender, EventArgs e)
        {
            if (!Runtime.uiThread.Enabled)
            {
                Runtime.uiThread.Enabled = true;
                this.btn_toggleMonitor.Text = "Stop";



            }
            else
            {
                Runtime.uiThread.Enabled = false;
                this.btn_toggleMonitor.Text = "Start";
                EmptyStats();

            }

        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private void btnExit_Click(object sender, EventArgs e)
        {

            Program.ExitHandler(sender,e);

        }

        private void btn_FlushStandbyCache_Click(object sender, EventArgs e)
        {
            Runtime.FlushCache();
        }

        #region StatsUI

        private void UpdateStats(object _object, EventArgs _eventArgs)
        {

            if (Runtime.Var.LastFlush.Ticks > 0) this.tbLastFlush.Text = Runtime.Var.LastFlush.ToString();
            this.tbFlushHistory.Text = Runtime.Var.FlushHistory.ToString();

            tbPhysTotal.Text = Runtime.MemCalc("PhysTotal").ToString("F1") + " ";
            tbPhysInUse.Text = Runtime.MemCalc("PhysInUse").ToString("F1") + " ";
            tbPhysAvail.Text = Runtime.MemCalc("PhysUnused").ToString("F1") + " ";

            tbActPhysTotal.Text = Runtime.MemCalc("PhysTotal").ToString("F1") + " ";
            tbActWorkingSet.Text = (Runtime.MemCalc("PhysInUse") - Runtime.MemCalc("ModifiedInUse")).ToString("F1") + " ";

            
            tbActModified.Text = Runtime.MemCalc("ModifiedInUse").ToString("F1") + " ";
            tbActCompressed.Text = Runtime.MemCalc("CompressedInUse").ToString("F1") + " ";
            tbActStandbyCache.Text = Runtime.MemCalc("SystemCache").ToString("F1") + " ";
            tbActFree.Text = Runtime.MemCalc("PhysFree").ToString("F1") + " ";

            
        }

        private void EmptyStats()
        {

            tbPhysTotal.Text = null;
            tbPhysInUse.Text = null;
            tbPhysAvail.Text = null;
            tbActPhysTotal.Text = null;
            tbActWorkingSet.Text = null;
            tbActModified.Text = null;
            tbActCompressed.Text = null;
            tbActStandbyCache.Text = null;
            tbActFree.Text = null;

        }

        #endregion

        #region SettingsUI

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private void btnSetDefaults_Click(object sender, EventArgs e)
        {
            tbSettingPollInterval.Value = 2000;
            cbAggressiveMode.Checked = false;
            tbFreeMemTriggerLimit.Value = 1024;
            tbStandbyListMinSize.Value = 3072;
            SaveSettings();
            
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private void btnSetApply_Click(object sender, EventArgs e)
        {
            SaveSettings();

        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Internal Function Declaration")]
        private void btnSetReset_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void SaveSettings()
        {
            if (cbAggressiveMode.Checked)
            {
                Runtime.Settings.AggressiveMode = true;
            }
            else
            {
                Runtime.Settings.AggressiveMode = false;
            }

            Runtime.Settings.PollInterval = (int)tbSettingPollInterval.Value;
            Runtime.Settings.FreeMemTriggerLimit = (int)tbFreeMemTriggerLimit.Value;
            Runtime.Settings.StandbyListMinLimit = (int)tbStandbyListMinSize.Value;

            Runtime.uiThread.Interval = Runtime.Settings.PollInterval;
            Runtime.dataThread.Change(0, Runtime.Settings.PollInterval);

            DisableSettingsBtns();
        }

        private void LoadSettings()
        {
            tbSettingPollInterval.Value = Runtime.Settings.PollInterval;
            cbAggressiveMode.Checked = Runtime.Settings.AggressiveMode;
            tbStandbyListMinSize.Value = Runtime.Settings.StandbyListMinLimit;
            tbFreeMemTriggerLimit.Value = Runtime.Settings.FreeMemTriggerLimit;
            DisableSettingsBtns();
        }

        private void EnableSettingsBtns(object sender, EventArgs e)
        {
            btnSetReset.Enabled = true;
            btnSetApply.Enabled = true;
        }

        private void DisableSettingsBtns()
        {
            btnSetReset.Enabled = false;
            btnSetApply.Enabled = false;
        }



        #endregion

        private void btn_SendToTray_Click(object sender, EventArgs e)
        {
            Program.HideWin(sender, e);
        }
    }
}
