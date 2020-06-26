using System.Windows.Forms;

namespace CacheMon

{
    partial class StatusWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();

            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblPhysTotal;
            System.Windows.Forms.Label lblPhysInUse;
            System.Windows.Forms.Label lblPhysFree;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusWin));
            this.lblAppNameStatic = new System.Windows.Forms.Label();
            this.btn_toggleMonitor = new System.Windows.Forms.Button();
            this.gbWinStats = new System.Windows.Forms.GroupBox();
            this.tbPhysAvail = new System.Windows.Forms.TextBox();
            this.tbPhysInUse = new System.Windows.Forms.TextBox();
            this.tbPhysTotal = new System.Windows.Forms.TextBox();
            this.gbActStats = new System.Windows.Forms.GroupBox();
            this.lblPanel = new System.Windows.Forms.Panel();
            this.lblActTotal = new System.Windows.Forms.Label();
            this.lblActWorkingSet = new System.Windows.Forms.Label();
            this.lblModified = new System.Windows.Forms.Label();
            this.lblCompressed = new System.Windows.Forms.Label();
            this.lblStandbyCache = new System.Windows.Forms.Label();
            this.lblActFree = new System.Windows.Forms.Label();
            this.tbActFree = new System.Windows.Forms.TextBox();
            this.tbActStandbyCache = new System.Windows.Forms.TextBox();
            this.tbActCompressed = new System.Windows.Forms.TextBox();
            this.tbActModified = new System.Windows.Forms.TextBox();
            this.tbActWorkingSet = new System.Windows.Forms.TextBox();
            this.tbActPhysTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnSetApply = new System.Windows.Forms.Button();
            this.btnSetReset = new System.Windows.Forms.Button();
            this.btnSetDefaults = new System.Windows.Forms.Button();
            this.lblStandbyListMinLimit = new System.Windows.Forms.Label();
            this.tbStandbyListMinSize = new System.Windows.Forms.NumericUpDown();
            this.lblFreeMemTrigger = new System.Windows.Forms.Label();
            this.tbFreeMemTriggerLimit = new System.Windows.Forms.NumericUpDown();
            this.cbAggressiveMode = new System.Windows.Forms.CheckBox();
            this.lblSettingPollInterval = new System.Windows.Forms.Label();
            this.tbSettingPollInterval = new System.Windows.Forms.NumericUpDown();
            this.ttAggressiveMode = new System.Windows.Forms.ToolTip(this.components);
            this.lblFlushHistory = new System.Windows.Forms.Label();
            this.lblLastFlush = new System.Windows.Forms.Label();
            this.tbFlushHistory = new System.Windows.Forms.TextBox();
            this.tbLastFlush = new System.Windows.Forms.TextBox();
            this.ttPollInterval = new System.Windows.Forms.ToolTip(this.components);
            this.btn_FlushStandbyCache = new System.Windows.Forms.Button();
            this.btn_SendToTray = new System.Windows.Forms.Button();
            lblPhysTotal = new System.Windows.Forms.Label();
            lblPhysInUse = new System.Windows.Forms.Label();
            lblPhysFree = new System.Windows.Forms.Label();
            this.gbWinStats.SuspendLayout();
            this.gbActStats.SuspendLayout();
            this.lblPanel.SuspendLayout();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStandbyListMinSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFreeMemTriggerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSettingPollInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhysTotal
            // 
            lblPhysTotal.AutoSize = true;
            lblPhysTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPhysTotal.Location = new System.Drawing.Point(84, 32);
            lblPhysTotal.Name = "lblPhysTotal";
            lblPhysTotal.Size = new System.Drawing.Size(88, 17);
            lblPhysTotal.TabIndex = 0;
            lblPhysTotal.Text = "Physical Total:";
            lblPhysTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhysInUse
            // 
            lblPhysInUse.AutoSize = true;
            lblPhysInUse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPhysInUse.Location = new System.Drawing.Point(76, 64);
            lblPhysInUse.Name = "lblPhysInUse";
            lblPhysInUse.Size = new System.Drawing.Size(96, 17);
            lblPhysInUse.TabIndex = 2;
            lblPhysInUse.Text = "Physical In Use:";
            lblPhysInUse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhysFree
            // 
            lblPhysFree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblPhysFree.AutoSize = true;
            lblPhysFree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPhysFree.Location = new System.Drawing.Point(60, 96);
            lblPhysFree.Name = "lblPhysFree";
            lblPhysFree.Size = new System.Drawing.Size(112, 17);
            lblPhysFree.TabIndex = 5;
            lblPhysFree.Text = "Physical Available:";
            lblPhysFree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAppNameStatic
            // 
            this.lblAppNameStatic.AutoSize = true;
            this.lblAppNameStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppNameStatic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAppNameStatic.Location = new System.Drawing.Point(8, 12);
            this.lblAppNameStatic.Name = "lblAppNameStatic";
            this.lblAppNameStatic.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblAppNameStatic.Size = new System.Drawing.Size(3, 17);
            this.lblAppNameStatic.TabIndex = 9;
            // 
            // btn_toggleMonitor
            // 
            this.btn_toggleMonitor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_toggleMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_toggleMonitor.Location = new System.Drawing.Point(372, 8);
            this.btn_toggleMonitor.Name = "btn_toggleMonitor";
            this.btn_toggleMonitor.Size = new System.Drawing.Size(145, 30);
            this.btn_toggleMonitor.TabIndex = 0;
            this.btn_toggleMonitor.Text = "Start";
            this.btn_toggleMonitor.UseVisualStyleBackColor = false;
            this.btn_toggleMonitor.Click += new System.EventHandler(this.btn_toggleMonitor_Click);
            // 
            // gbWinStats
            // 
            this.gbWinStats.Controls.Add(this.tbPhysAvail);
            this.gbWinStats.Controls.Add(this.tbPhysInUse);
            this.gbWinStats.Controls.Add(this.tbPhysTotal);
            this.gbWinStats.Controls.Add(lblPhysInUse);
            this.gbWinStats.Controls.Add(lblPhysFree);
            this.gbWinStats.Controls.Add(lblPhysTotal);
            this.gbWinStats.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWinStats.Location = new System.Drawing.Point(8, 44);
            this.gbWinStats.Name = "gbWinStats";
            this.gbWinStats.Size = new System.Drawing.Size(396, 137);
            this.gbWinStats.TabIndex = 7;
            this.gbWinStats.TabStop = false;
            this.gbWinStats.Text = "Windows RAM Layout";
            // 
            // tbPhysAvail
            // 
            this.tbPhysAvail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPhysAvail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhysAvail.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPhysAvail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhysAvail.Location = new System.Drawing.Point(176, 92);
            this.tbPhysAvail.Name = "tbPhysAvail";
            this.tbPhysAvail.ReadOnly = true;
            this.tbPhysAvail.Size = new System.Drawing.Size(133, 25);
            this.tbPhysAvail.TabIndex = 8;
            this.tbPhysAvail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPhysInUse
            // 
            this.tbPhysInUse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPhysInUse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhysInUse.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPhysInUse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhysInUse.Location = new System.Drawing.Point(176, 60);
            this.tbPhysInUse.Name = "tbPhysInUse";
            this.tbPhysInUse.ReadOnly = true;
            this.tbPhysInUse.Size = new System.Drawing.Size(133, 25);
            this.tbPhysInUse.TabIndex = 7;
            this.tbPhysInUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPhysTotal
            // 
            this.tbPhysTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPhysTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhysTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPhysTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhysTotal.Location = new System.Drawing.Point(176, 28);
            this.tbPhysTotal.Name = "tbPhysTotal";
            this.tbPhysTotal.ReadOnly = true;
            this.tbPhysTotal.Size = new System.Drawing.Size(133, 25);
            this.tbPhysTotal.TabIndex = 6;
            this.tbPhysTotal.TabStop = false;
            this.tbPhysTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbActStats
            // 
            this.gbActStats.BackColor = System.Drawing.SystemColors.Control;
            this.gbActStats.Controls.Add(this.lblPanel);
            this.gbActStats.Controls.Add(this.tbActFree);
            this.gbActStats.Controls.Add(this.tbActStandbyCache);
            this.gbActStats.Controls.Add(this.tbActCompressed);
            this.gbActStats.Controls.Add(this.tbActModified);
            this.gbActStats.Controls.Add(this.tbActWorkingSet);
            this.gbActStats.Controls.Add(this.tbActPhysTotal);
            this.gbActStats.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActStats.Location = new System.Drawing.Point(420, 44);
            this.gbActStats.Name = "gbActStats";
            this.gbActStats.Size = new System.Drawing.Size(389, 213);
            this.gbActStats.TabIndex = 8;
            this.gbActStats.TabStop = false;
            this.gbActStats.Text = "Actual RAM Layout";
            // 
            // lblPanel
            // 
            this.lblPanel.Controls.Add(this.lblActTotal);
            this.lblPanel.Controls.Add(this.lblActWorkingSet);
            this.lblPanel.Controls.Add(this.lblModified);
            this.lblPanel.Controls.Add(this.lblCompressed);
            this.lblPanel.Controls.Add(this.lblStandbyCache);
            this.lblPanel.Controls.Add(this.lblActFree);
            this.lblPanel.Location = new System.Drawing.Point(40, 24);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(128, 172);
            this.lblPanel.TabIndex = 10;
            // 
            // lblActTotal
            // 
            this.lblActTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblActTotal.AutoSize = true;
            this.lblActTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActTotal.Location = new System.Drawing.Point(53, 6);
            this.lblActTotal.Margin = new System.Windows.Forms.Padding(3);
            this.lblActTotal.Name = "lblActTotal";
            this.lblActTotal.Size = new System.Drawing.Size(71, 17);
            this.lblActTotal.TabIndex = 4;
            this.lblActTotal.Text = "Total RAM:";
            this.lblActTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActWorkingSet
            // 
            this.lblActWorkingSet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblActWorkingSet.AutoSize = true;
            this.lblActWorkingSet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActWorkingSet.Location = new System.Drawing.Point(16, 34);
            this.lblActWorkingSet.Margin = new System.Windows.Forms.Padding(3);
            this.lblActWorkingSet.Name = "lblActWorkingSet";
            this.lblActWorkingSet.Size = new System.Drawing.Size(106, 17);
            this.lblActWorkingSet.TabIndex = 0;
            this.lblActWorkingSet.Text = "Prv. Working Set:";
            this.lblActWorkingSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblModified
            // 
            this.lblModified.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModified.AutoSize = true;
            this.lblModified.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModified.Location = new System.Drawing.Point(61, 62);
            this.lblModified.Margin = new System.Windows.Forms.Padding(3);
            this.lblModified.Name = "lblModified";
            this.lblModified.Size = new System.Drawing.Size(64, 17);
            this.lblModified.TabIndex = 2;
            this.lblModified.Text = "Modified:";
            this.lblModified.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompressed
            // 
            this.lblCompressed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCompressed.AutoSize = true;
            this.lblCompressed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompressed.Location = new System.Drawing.Point(40, 90);
            this.lblCompressed.Margin = new System.Windows.Forms.Padding(3);
            this.lblCompressed.Name = "lblCompressed";
            this.lblCompressed.Size = new System.Drawing.Size(85, 17);
            this.lblCompressed.TabIndex = 3;
            this.lblCompressed.Text = "Compressed:";
            this.lblCompressed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStandbyCache
            // 
            this.lblStandbyCache.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStandbyCache.AutoSize = true;
            this.lblStandbyCache.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandbyCache.Location = new System.Drawing.Point(25, 118);
            this.lblStandbyCache.Margin = new System.Windows.Forms.Padding(3);
            this.lblStandbyCache.Name = "lblStandbyCache";
            this.lblStandbyCache.Size = new System.Drawing.Size(97, 17);
            this.lblStandbyCache.TabIndex = 5;
            this.lblStandbyCache.Text = "Standby Cache:";
            this.lblStandbyCache.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActFree
            // 
            this.lblActFree.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblActFree.AutoSize = true;
            this.lblActFree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActFree.Location = new System.Drawing.Point(39, 146);
            this.lblActFree.Margin = new System.Windows.Forms.Padding(3);
            this.lblActFree.Name = "lblActFree";
            this.lblActFree.Size = new System.Drawing.Size(85, 17);
            this.lblActFree.TabIndex = 6;
            this.lblActFree.Text = "Free/Unused:";
            this.lblActFree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbActFree
            // 
            this.tbActFree.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbActFree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbActFree.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbActFree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActFree.Location = new System.Drawing.Point(172, 168);
            this.tbActFree.Name = "tbActFree";
            this.tbActFree.ReadOnly = true;
            this.tbActFree.Size = new System.Drawing.Size(100, 25);
            this.tbActFree.TabIndex = 13;
            this.tbActFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbActStandbyCache
            // 
            this.tbActStandbyCache.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbActStandbyCache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbActStandbyCache.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbActStandbyCache.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActStandbyCache.Location = new System.Drawing.Point(172, 140);
            this.tbActStandbyCache.Name = "tbActStandbyCache";
            this.tbActStandbyCache.ReadOnly = true;
            this.tbActStandbyCache.Size = new System.Drawing.Size(100, 25);
            this.tbActStandbyCache.TabIndex = 12;
            this.tbActStandbyCache.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbActCompressed
            // 
            this.tbActCompressed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbActCompressed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbActCompressed.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbActCompressed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActCompressed.Location = new System.Drawing.Point(172, 112);
            this.tbActCompressed.Name = "tbActCompressed";
            this.tbActCompressed.ReadOnly = true;
            this.tbActCompressed.Size = new System.Drawing.Size(100, 25);
            this.tbActCompressed.TabIndex = 11;
            this.tbActCompressed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbActModified
            // 
            this.tbActModified.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbActModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbActModified.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbActModified.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActModified.Location = new System.Drawing.Point(172, 84);
            this.tbActModified.Name = "tbActModified";
            this.tbActModified.ReadOnly = true;
            this.tbActModified.Size = new System.Drawing.Size(100, 25);
            this.tbActModified.TabIndex = 10;
            this.tbActModified.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbActWorkingSet
            // 
            this.tbActWorkingSet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbActWorkingSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbActWorkingSet.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbActWorkingSet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActWorkingSet.Location = new System.Drawing.Point(172, 56);
            this.tbActWorkingSet.Name = "tbActWorkingSet";
            this.tbActWorkingSet.ReadOnly = true;
            this.tbActWorkingSet.Size = new System.Drawing.Size(100, 25);
            this.tbActWorkingSet.TabIndex = 8;
            this.tbActWorkingSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbActPhysTotal
            // 
            this.tbActPhysTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbActPhysTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbActPhysTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbActPhysTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActPhysTotal.Location = new System.Drawing.Point(172, 28);
            this.tbActPhysTotal.Name = "tbActPhysTotal";
            this.tbActPhysTotal.ReadOnly = true;
            this.tbActPhysTotal.Size = new System.Drawing.Size(100, 25);
            this.tbActPhysTotal.TabIndex = 7;
            this.tbActPhysTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(524, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.btnSetApply);
            this.gbSettings.Controls.Add(this.btnSetReset);
            this.gbSettings.Controls.Add(this.btnSetDefaults);
            this.gbSettings.Controls.Add(this.lblStandbyListMinLimit);
            this.gbSettings.Controls.Add(this.tbStandbyListMinSize);
            this.gbSettings.Controls.Add(this.lblFreeMemTrigger);
            this.gbSettings.Controls.Add(this.tbFreeMemTriggerLimit);
            this.gbSettings.Controls.Add(this.cbAggressiveMode);
            this.gbSettings.Controls.Add(this.lblSettingPollInterval);
            this.gbSettings.Controls.Add(this.tbSettingPollInterval);
            this.gbSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSettings.Location = new System.Drawing.Point(8, 188);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(396, 164);
            this.gbSettings.TabIndex = 10;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // btnSetApply
            // 
            this.btnSetApply.Location = new System.Drawing.Point(312, 132);
            this.btnSetApply.Name = "btnSetApply";
            this.btnSetApply.Size = new System.Drawing.Size(75, 23);
            this.btnSetApply.TabIndex = 9;
            this.btnSetApply.Text = "Apply";
            this.btnSetApply.UseVisualStyleBackColor = true;
            this.btnSetApply.Click += new System.EventHandler(this.btnSetApply_Click);
            // 
            // btnSetReset
            // 
            this.btnSetReset.Location = new System.Drawing.Point(232, 132);
            this.btnSetReset.Name = "btnSetReset";
            this.btnSetReset.Size = new System.Drawing.Size(75, 23);
            this.btnSetReset.TabIndex = 8;
            this.btnSetReset.Text = "Reset";
            this.btnSetReset.UseVisualStyleBackColor = true;
            this.btnSetReset.Click += new System.EventHandler(this.btnSetReset_Click);
            // 
            // btnSetDefaults
            // 
            this.btnSetDefaults.Location = new System.Drawing.Point(152, 132);
            this.btnSetDefaults.Name = "btnSetDefaults";
            this.btnSetDefaults.Size = new System.Drawing.Size(75, 23);
            this.btnSetDefaults.TabIndex = 7;
            this.btnSetDefaults.Text = "Defaults";
            this.btnSetDefaults.UseVisualStyleBackColor = true;
            this.btnSetDefaults.Click += new System.EventHandler(this.btnSetDefaults_Click);
            // 
            // lblStandbyListMinLimit
            // 
            this.lblStandbyListMinLimit.AutoSize = true;
            this.lblStandbyListMinLimit.Location = new System.Drawing.Point(29, 104);
            this.lblStandbyListMinLimit.Name = "lblStandbyListMinLimit";
            this.lblStandbyListMinLimit.Size = new System.Drawing.Size(146, 13);
            this.lblStandbyListMinLimit.TabIndex = 6;
            this.lblStandbyListMinLimit.Text = "Standby List Minimum Size:";
            // 
            // tbStandbyListMinSize
            // 
            this.tbStandbyListMinSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStandbyListMinSize.Increment = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.tbStandbyListMinSize.Location = new System.Drawing.Point(176, 100);
            this.tbStandbyListMinSize.Maximum = new decimal(new int[] {
            2147483520,
            0,
            0,
            0});
            this.tbStandbyListMinSize.Minimum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.tbStandbyListMinSize.Name = "tbStandbyListMinSize";
            this.tbStandbyListMinSize.Size = new System.Drawing.Size(120, 22);
            this.tbStandbyListMinSize.TabIndex = 5;
            this.tbStandbyListMinSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbStandbyListMinSize.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.tbStandbyListMinSize.ValueChanged += new System.EventHandler(this.EnableSettingsBtns);
            // 
            // lblFreeMemTrigger
            // 
            this.lblFreeMemTrigger.AutoSize = true;
            this.lblFreeMemTrigger.Location = new System.Drawing.Point(53, 76);
            this.lblFreeMemTrigger.Name = "lblFreeMemTrigger";
            this.lblFreeMemTrigger.Size = new System.Drawing.Size(122, 13);
            this.lblFreeMemTrigger.TabIndex = 4;
            this.lblFreeMemTrigger.Text = "Low Free RAM Trigger:";
            // 
            // tbFreeMemTriggerLimit
            // 
            this.tbFreeMemTriggerLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFreeMemTriggerLimit.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.tbFreeMemTriggerLimit.Location = new System.Drawing.Point(176, 72);
            this.tbFreeMemTriggerLimit.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.tbFreeMemTriggerLimit.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.tbFreeMemTriggerLimit.Name = "tbFreeMemTriggerLimit";
            this.tbFreeMemTriggerLimit.Size = new System.Drawing.Size(120, 22);
            this.tbFreeMemTriggerLimit.TabIndex = 3;
            this.tbFreeMemTriggerLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbFreeMemTriggerLimit.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.tbFreeMemTriggerLimit.ValueChanged += new System.EventHandler(this.EnableSettingsBtns);
            // 
            // cbAggressiveMode
            // 
            this.cbAggressiveMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAggressiveMode.AutoSize = true;
            this.cbAggressiveMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAggressiveMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAggressiveMode.Location = new System.Drawing.Point(70, 48);
            this.cbAggressiveMode.Name = "cbAggressiveMode";
            this.cbAggressiveMode.Size = new System.Drawing.Size(117, 17);
            this.cbAggressiveMode.TabIndex = 2;
            this.cbAggressiveMode.Text = "Aggressive Mode: ";
            this.ttAggressiveMode.SetToolTip(this.cbAggressiveMode, "Trims Working Sets as well as Standby Lists when purging.");
            this.cbAggressiveMode.UseVisualStyleBackColor = true;
            this.cbAggressiveMode.CheckedChanged += new System.EventHandler(this.EnableSettingsBtns);
            // 
            // lblSettingPollInterval
            // 
            this.lblSettingPollInterval.AutoSize = true;
            this.lblSettingPollInterval.Location = new System.Drawing.Point(105, 28);
            this.lblSettingPollInterval.Name = "lblSettingPollInterval";
            this.lblSettingPollInterval.Size = new System.Drawing.Size(70, 13);
            this.lblSettingPollInterval.TabIndex = 1;
            this.lblSettingPollInterval.Text = "Poll Interval:";
            // 
            // tbSettingPollInterval
            // 
            this.tbSettingPollInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSettingPollInterval.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbSettingPollInterval.Location = new System.Drawing.Point(176, 24);
            this.tbSettingPollInterval.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.tbSettingPollInterval.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.tbSettingPollInterval.Name = "tbSettingPollInterval";
            this.tbSettingPollInterval.Size = new System.Drawing.Size(120, 22);
            this.tbSettingPollInterval.TabIndex = 0;
            this.tbSettingPollInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttPollInterval.SetToolTip(this.tbSettingPollInterval, "Polling Rate (in ms)");
            this.tbSettingPollInterval.Value = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.tbSettingPollInterval.ValueChanged += new System.EventHandler(this.EnableSettingsBtns);
            // 
            // lblFlushHistory
            // 
            this.lblFlushHistory.AutoSize = true;
            this.lblFlushHistory.Location = new System.Drawing.Point(460, 272);
            this.lblFlushHistory.Name = "lblFlushHistory";
            this.lblFlushHistory.Size = new System.Drawing.Size(123, 17);
            this.lblFlushHistory.TabIndex = 11;
            this.lblFlushHistory.Text = "Flush Count History:";
            // 
            // lblLastFlush
            // 
            this.lblLastFlush.AutoSize = true;
            this.lblLastFlush.Location = new System.Drawing.Point(516, 296);
            this.lblLastFlush.Name = "lblLastFlush";
            this.lblLastFlush.Size = new System.Drawing.Size(67, 17);
            this.lblLastFlush.TabIndex = 12;
            this.lblLastFlush.Text = "Last Flush:";
            // 
            // tbFlushHistory
            // 
            this.tbFlushHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFlushHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlushHistory.Location = new System.Drawing.Point(588, 272);
            this.tbFlushHistory.Name = "tbFlushHistory";
            this.tbFlushHistory.ReadOnly = true;
            this.tbFlushHistory.ShortcutsEnabled = false;
            this.tbFlushHistory.Size = new System.Drawing.Size(212, 18);
            this.tbFlushHistory.TabIndex = 13;
            this.tbFlushHistory.TabStop = false;
            // 
            // tbLastFlush
            // 
            this.tbLastFlush.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastFlush.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastFlush.Location = new System.Drawing.Point(588, 296);
            this.tbLastFlush.Name = "tbLastFlush";
            this.tbLastFlush.ReadOnly = true;
            this.tbLastFlush.ShortcutsEnabled = false;
            this.tbLastFlush.Size = new System.Drawing.Size(212, 18);
            this.tbLastFlush.TabIndex = 14;
            this.tbLastFlush.TabStop = false;
            // 
            // btn_FlushStandbyCache
            // 
            this.btn_FlushStandbyCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FlushStandbyCache.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FlushStandbyCache.Location = new System.Drawing.Point(676, 324);
            this.btn_FlushStandbyCache.Name = "btn_FlushStandbyCache";
            this.btn_FlushStandbyCache.Size = new System.Drawing.Size(131, 23);
            this.btn_FlushStandbyCache.TabIndex = 15;
            this.btn_FlushStandbyCache.Text = "Flush Standby Cache";
            this.btn_FlushStandbyCache.UseVisualStyleBackColor = true;
            this.btn_FlushStandbyCache.Click += new System.EventHandler(this.btn_FlushStandbyCache_Click);
            // 
            // btn_SendToTray
            // 
            this.btn_SendToTray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SendToTray.Location = new System.Drawing.Point(676, 8);
            this.btn_SendToTray.Name = "btn_SendToTray";
            this.btn_SendToTray.Size = new System.Drawing.Size(132, 30);
            this.btn_SendToTray.TabIndex = 1;
            this.btn_SendToTray.Text = "Send to Tray";
            this.btn_SendToTray.UseVisualStyleBackColor = true;
            this.btn_SendToTray.Click += new System.EventHandler(this.btn_SendToTray_Click);
            // 
            // StatusWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 357);
            this.ControlBox = false;
            this.Controls.Add(this.btn_SendToTray);
            this.Controls.Add(this.btn_FlushStandbyCache);
            this.Controls.Add(this.tbLastFlush);
            this.Controls.Add(this.tbFlushHistory);
            this.Controls.Add(this.lblLastFlush);
            this.Controls.Add(this.lblFlushHistory);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.lblAppNameStatic);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbActStats);
            this.Controls.Add(this.gbWinStats);
            this.Controls.Add(this.btn_toggleMonitor);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 400);
            this.Name = "StatusWin";
            this.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowInTaskbar = false;
            this.Text = "CacheMon Status";
            this.gbWinStats.ResumeLayout(false);
            this.gbWinStats.PerformLayout();
            this.gbActStats.ResumeLayout(false);
            this.gbActStats.PerformLayout();
            this.lblPanel.ResumeLayout(false);
            this.lblPanel.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStandbyListMinSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFreeMemTriggerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSettingPollInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_toggleMonitor;
        private System.Windows.Forms.GroupBox gbWinStats;
        private System.Windows.Forms.GroupBox gbActStats;
        public System.Windows.Forms.TextBox tbPhysAvail;
        public System.Windows.Forms.TextBox tbPhysInUse;
        public System.Windows.Forms.TextBox tbPhysTotal;
        private System.Windows.Forms.Button btnExit;
        private Label lblAppNameStatic;
        private Label lblActFree;
        private Label lblStandbyCache;
        private Label lblActTotal;
        private Label lblCompressed;
        private Label lblModified;
        private Label lblActWorkingSet;
        private TextBox tbActFree;
        private TextBox tbActStandbyCache;
        private TextBox tbActCompressed;
        private TextBox tbActModified;
        private TextBox tbActWorkingSet;
        private TextBox tbActPhysTotal;
        private Panel lblPanel;
        private GroupBox gbSettings;
        private NumericUpDown tbSettingPollInterval;
        private Label lblSettingPollInterval;
        private CheckBox cbAggressiveMode;
        private ToolTip ttAggressiveMode;
        private Label lblFreeMemTrigger;
        private Label lblStandbyListMinLimit;
        private Label lblFlushHistory;
        private Label lblLastFlush;
        public TextBox tbFlushHistory;
        public TextBox tbLastFlush;
        private Button btnSetApply;
        private Button btnSetReset;
        private Button btnSetDefaults;
        public NumericUpDown tbFreeMemTriggerLimit;
        public NumericUpDown tbStandbyListMinSize;
        private ToolTip ttPollInterval;
        private Button btn_FlushStandbyCache;
        private Button btn_SendToTray;
    }
}