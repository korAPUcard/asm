
namespace AdvancedStatusMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStrip_ProgramStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_CPUUsage = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_Separator1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_RAMUsage = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_Separator2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_GPUUsage = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_Separator3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_StorageUsage = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_Separator4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_NetworkSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuStrip_App = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_App_Preferences = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_App_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStrip_App_ProgramRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_App_ProgramShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Advanced = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Advanced_AIDiagnosis = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.ManuStrip_Help_Manual = new System.Windows.Forms.ToolStripMenuItem();
            this.ManuStrip_Help_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStrip_Help_CheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.debugConsoleOutputBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.debugConsoleInputBox = new System.Windows.Forms.TextBox();
            this.debugConsoleSubmitButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblNoImplemented1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGPUStatus1 = new System.Windows.Forms.Label();
            this.iconGPU = new System.Windows.Forms.PictureBox();
            this.iconGPUTemp = new System.Windows.Forms.PictureBox();
            this.pbGPUTemp = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRAMStatus1 = new System.Windows.Forms.Label();
            this.iconRAM = new System.Windows.Forms.PictureBox();
            this.iconRAMTemp = new System.Windows.Forms.PictureBox();
            this.pbRAMTemp = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.iconCPU = new System.Windows.Forms.PictureBox();
            this.lblCPUStatus1 = new System.Windows.Forms.Label();
            this.iconCPUTemp = new System.Windows.Forms.PictureBox();
            this.pbCPUTemp = new System.Windows.Forms.ProgressBar();
            this.perfCounterCPU = new System.Diagnostics.PerformanceCounter();
            this.perfCounterRAM = new System.Diagnostics.PerformanceCounter();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.pbGPUUsage = new System.Windows.Forms.ProgressBar();
            this.pbRAMUsage = new System.Windows.Forms.ProgressBar();
            this.pbCPUUsage = new System.Windows.Forms.ProgressBar();
            this.perfCounterGPU = new System.Diagnostics.PerformanceCounter();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconGPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGPUTemp)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRAMTemp)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCPUTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCounterCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCounterRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCounterGPU)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip_ProgramStatus,
            this.StatusStrip_CPUUsage,
            this.StatusStrip_Separator1,
            this.StatusStrip_RAMUsage,
            this.StatusStrip_Separator2,
            this.StatusStrip_GPUUsage,
            this.StatusStrip_Separator3,
            this.StatusStrip_StorageUsage,
            this.StatusStrip_Separator4,
            this.StatusStrip_NetworkSpeed});
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.SizingGrip = false;
            // 
            // StatusStrip_ProgramStatus
            // 
            resources.ApplyResources(this.StatusStrip_ProgramStatus, "StatusStrip_ProgramStatus");
            this.StatusStrip_ProgramStatus.Name = "StatusStrip_ProgramStatus";
            // 
            // StatusStrip_CPUUsage
            // 
            this.StatusStrip_CPUUsage.Name = "StatusStrip_CPUUsage";
            resources.ApplyResources(this.StatusStrip_CPUUsage, "StatusStrip_CPUUsage");
            // 
            // StatusStrip_Separator1
            // 
            this.StatusStrip_Separator1.Name = "StatusStrip_Separator1";
            resources.ApplyResources(this.StatusStrip_Separator1, "StatusStrip_Separator1");
            // 
            // StatusStrip_RAMUsage
            // 
            this.StatusStrip_RAMUsage.Name = "StatusStrip_RAMUsage";
            resources.ApplyResources(this.StatusStrip_RAMUsage, "StatusStrip_RAMUsage");
            // 
            // StatusStrip_Separator2
            // 
            this.StatusStrip_Separator2.Name = "StatusStrip_Separator2";
            resources.ApplyResources(this.StatusStrip_Separator2, "StatusStrip_Separator2");
            // 
            // StatusStrip_GPUUsage
            // 
            this.StatusStrip_GPUUsage.Name = "StatusStrip_GPUUsage";
            resources.ApplyResources(this.StatusStrip_GPUUsage, "StatusStrip_GPUUsage");
            // 
            // StatusStrip_Separator3
            // 
            this.StatusStrip_Separator3.Name = "StatusStrip_Separator3";
            resources.ApplyResources(this.StatusStrip_Separator3, "StatusStrip_Separator3");
            // 
            // StatusStrip_StorageUsage
            // 
            this.StatusStrip_StorageUsage.Name = "StatusStrip_StorageUsage";
            resources.ApplyResources(this.StatusStrip_StorageUsage, "StatusStrip_StorageUsage");
            // 
            // StatusStrip_Separator4
            // 
            this.StatusStrip_Separator4.Name = "StatusStrip_Separator4";
            resources.ApplyResources(this.StatusStrip_Separator4, "StatusStrip_Separator4");
            // 
            // StatusStrip_NetworkSpeed
            // 
            this.StatusStrip_NetworkSpeed.Name = "StatusStrip_NetworkSpeed";
            resources.ApplyResources(this.StatusStrip_NetworkSpeed, "StatusStrip_NetworkSpeed");
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_App,
            this.MenuStrip_Advanced,
            this.MenuStrip_Help});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // MenuStrip_App
            // 
            this.MenuStrip_App.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MenuStrip_App.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuStrip_App.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_App_Preferences,
            this.MenuStrip_App_Separator1,
            this.MenuStrip_App_ProgramRestart,
            this.MenuStrip_App_ProgramShutdown});
            this.MenuStrip_App.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.MenuStrip_App.Name = "MenuStrip_App";
            resources.ApplyResources(this.MenuStrip_App, "MenuStrip_App");
            this.MenuStrip_App.MouseHover += new System.EventHandler(this.MenuStrip_App_MouseHover);
            // 
            // MenuStrip_App_Preferences
            // 
            this.MenuStrip_App_Preferences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MenuStrip_App_Preferences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.MenuStrip_App_Preferences.Name = "MenuStrip_App_Preferences";
            resources.ApplyResources(this.MenuStrip_App_Preferences, "MenuStrip_App_Preferences");
            this.MenuStrip_App_Preferences.Click += new System.EventHandler(this.MenuStrip_App_Preferences_Click);
            // 
            // MenuStrip_App_Separator1
            // 
            this.MenuStrip_App_Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MenuStrip_App_Separator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.MenuStrip_App_Separator1.Name = "MenuStrip_App_Separator1";
            resources.ApplyResources(this.MenuStrip_App_Separator1, "MenuStrip_App_Separator1");
            // 
            // MenuStrip_App_ProgramRestart
            // 
            this.MenuStrip_App_ProgramRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MenuStrip_App_ProgramRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.MenuStrip_App_ProgramRestart.Name = "MenuStrip_App_ProgramRestart";
            resources.ApplyResources(this.MenuStrip_App_ProgramRestart, "MenuStrip_App_ProgramRestart");
            this.MenuStrip_App_ProgramRestart.Click += new System.EventHandler(this.MenuStrip_App_ProgramRestart_Click);
            // 
            // MenuStrip_App_ProgramShutdown
            // 
            this.MenuStrip_App_ProgramShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MenuStrip_App_ProgramShutdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.MenuStrip_App_ProgramShutdown.Name = "MenuStrip_App_ProgramShutdown";
            resources.ApplyResources(this.MenuStrip_App_ProgramShutdown, "MenuStrip_App_ProgramShutdown");
            this.MenuStrip_App_ProgramShutdown.Click += new System.EventHandler(this.MenuStrip_App_ProgramShutdown_Click);
            // 
            // MenuStrip_Advanced
            // 
            this.MenuStrip_Advanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MenuStrip_Advanced.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_Advanced_AIDiagnosis});
            this.MenuStrip_Advanced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.MenuStrip_Advanced.Name = "MenuStrip_Advanced";
            resources.ApplyResources(this.MenuStrip_Advanced, "MenuStrip_Advanced");
            this.MenuStrip_Advanced.MouseHover += new System.EventHandler(this.MenuStrip_Advanced_MouseHover);
            // 
            // MenuStrip_Advanced_AIDiagnosis
            // 
            this.MenuStrip_Advanced_AIDiagnosis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MenuStrip_Advanced_AIDiagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.MenuStrip_Advanced_AIDiagnosis.Name = "MenuStrip_Advanced_AIDiagnosis";
            resources.ApplyResources(this.MenuStrip_Advanced_AIDiagnosis, "MenuStrip_Advanced_AIDiagnosis");
            this.MenuStrip_Advanced_AIDiagnosis.Click += new System.EventHandler(this.MenuStrip_Advanced_AIDiagnosis_Click);
            // 
            // MenuStrip_Help
            // 
            this.MenuStrip_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_Help_About,
            this.ManuStrip_Help_Manual,
            this.ManuStrip_Help_Separator1,
            this.MenuStrip_Help_CheckUpdates});
            this.MenuStrip_Help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.MenuStrip_Help.Name = "MenuStrip_Help";
            resources.ApplyResources(this.MenuStrip_Help, "MenuStrip_Help");
            this.MenuStrip_Help.MouseHover += new System.EventHandler(this.MenuStrip_Help_MouseHover);
            // 
            // MenuStrip_Help_About
            // 
            this.MenuStrip_Help_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MenuStrip_Help_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.MenuStrip_Help_About.Name = "MenuStrip_Help_About";
            resources.ApplyResources(this.MenuStrip_Help_About, "MenuStrip_Help_About");
            this.MenuStrip_Help_About.Click += new System.EventHandler(this.MenuStrip_Help_About_Click);
            // 
            // ManuStrip_Help_Manual
            // 
            this.ManuStrip_Help_Manual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.ManuStrip_Help_Manual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ManuStrip_Help_Manual.Name = "ManuStrip_Help_Manual";
            resources.ApplyResources(this.ManuStrip_Help_Manual, "ManuStrip_Help_Manual");
            this.ManuStrip_Help_Manual.Click += new System.EventHandler(this.ManuStrip_Help_Manual_Click);
            // 
            // ManuStrip_Help_Separator1
            // 
            this.ManuStrip_Help_Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.ManuStrip_Help_Separator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.ManuStrip_Help_Separator1.Name = "ManuStrip_Help_Separator1";
            resources.ApplyResources(this.ManuStrip_Help_Separator1, "ManuStrip_Help_Separator1");
            // 
            // MenuStrip_Help_CheckUpdates
            // 
            this.MenuStrip_Help_CheckUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MenuStrip_Help_CheckUpdates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.MenuStrip_Help_CheckUpdates.Name = "MenuStrip_Help_CheckUpdates";
            resources.ApplyResources(this.MenuStrip_Help_CheckUpdates, "MenuStrip_Help_CheckUpdates");
            this.MenuStrip_Help_CheckUpdates.Click += new System.EventHandler(this.MenuStrip_Help_CheckUpdates_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.debugConsoleOutputBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // debugConsoleOutputBox
            // 
            this.debugConsoleOutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(14)))));
            this.debugConsoleOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.debugConsoleOutputBox, "debugConsoleOutputBox");
            this.debugConsoleOutputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.debugConsoleOutputBox.Name = "debugConsoleOutputBox";
            this.debugConsoleOutputBox.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.debugConsoleInputBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.debugConsoleSubmitButton, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // debugConsoleInputBox
            // 
            this.debugConsoleInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.debugConsoleInputBox, "debugConsoleInputBox");
            this.debugConsoleInputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.debugConsoleInputBox.Name = "debugConsoleInputBox";
            // 
            // debugConsoleSubmitButton
            // 
            this.debugConsoleSubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.debugConsoleSubmitButton, "debugConsoleSubmitButton");
            this.debugConsoleSubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.debugConsoleSubmitButton.Name = "debugConsoleSubmitButton";
            this.debugConsoleSubmitButton.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.tabPage2.Controls.Add(this.lblNoImplemented1);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // lblNoImplemented1
            // 
            resources.ApplyResources(this.lblNoImplemented1, "lblNoImplemented1");
            this.lblNoImplemented1.Name = "lblNoImplemented1";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.lblGPUStatus1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.iconGPU, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.iconGPUTemp, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.pbGPUUsage, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.pbGPUTemp, 4, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // lblGPUStatus1
            // 
            resources.ApplyResources(this.lblGPUStatus1, "lblGPUStatus1");
            this.lblGPUStatus1.Name = "lblGPUStatus1";
            // 
            // iconGPU
            // 
            this.iconGPU.Image = global::AdvancedStatusMonitor.Properties.Resources.icon_graphics;
            resources.ApplyResources(this.iconGPU, "iconGPU");
            this.iconGPU.Name = "iconGPU";
            this.iconGPU.TabStop = false;
            // 
            // iconGPUTemp
            // 
            this.iconGPUTemp.Image = global::AdvancedStatusMonitor.Properties.Resources.icon_temperture_celsius;
            resources.ApplyResources(this.iconGPUTemp, "iconGPUTemp");
            this.iconGPUTemp.Name = "iconGPUTemp";
            this.iconGPUTemp.TabStop = false;
            // 
            // pbGPUTemp
            // 
            this.pbGPUTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.pbGPUTemp, "pbGPUTemp");
            this.pbGPUTemp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pbGPUTemp.Name = "pbGPUTemp";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.lblRAMStatus1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.iconRAM, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.iconRAMTemp, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.pbRAMUsage, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.pbRAMTemp, 4, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // lblRAMStatus1
            // 
            resources.ApplyResources(this.lblRAMStatus1, "lblRAMStatus1");
            this.lblRAMStatus1.Name = "lblRAMStatus1";
            // 
            // iconRAM
            // 
            this.iconRAM.Image = global::AdvancedStatusMonitor.Properties.Resources.icon_memory;
            resources.ApplyResources(this.iconRAM, "iconRAM");
            this.iconRAM.Name = "iconRAM";
            this.iconRAM.TabStop = false;
            // 
            // iconRAMTemp
            // 
            this.iconRAMTemp.Image = global::AdvancedStatusMonitor.Properties.Resources.icon_temperture_celsius;
            resources.ApplyResources(this.iconRAMTemp, "iconRAMTemp");
            this.iconRAMTemp.Name = "iconRAMTemp";
            this.iconRAMTemp.TabStop = false;
            // 
            // pbRAMTemp
            // 
            this.pbRAMTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.pbRAMTemp, "pbRAMTemp");
            this.pbRAMTemp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pbRAMTemp.Name = "pbRAMTemp";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.iconCPU, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblCPUStatus1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.iconCPUTemp, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.pbCPUUsage, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.pbCPUTemp, 4, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // iconCPU
            // 
            this.iconCPU.Image = global::AdvancedStatusMonitor.Properties.Resources.icon_processor;
            resources.ApplyResources(this.iconCPU, "iconCPU");
            this.iconCPU.Name = "iconCPU";
            this.iconCPU.TabStop = false;
            // 
            // lblCPUStatus1
            // 
            resources.ApplyResources(this.lblCPUStatus1, "lblCPUStatus1");
            this.lblCPUStatus1.Name = "lblCPUStatus1";
            // 
            // iconCPUTemp
            // 
            this.iconCPUTemp.Image = global::AdvancedStatusMonitor.Properties.Resources.icon_temperture_celsius;
            resources.ApplyResources(this.iconCPUTemp, "iconCPUTemp");
            this.iconCPUTemp.Name = "iconCPUTemp";
            this.iconCPUTemp.TabStop = false;
            // 
            // pbCPUTemp
            // 
            this.pbCPUTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.pbCPUTemp, "pbCPUTemp");
            this.pbCPUTemp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pbCPUTemp.Name = "pbCPUTemp";
            // 
            // perfCounterCPU
            // 
            this.perfCounterCPU.CategoryName = "Processor";
            this.perfCounterCPU.CounterName = "% Processor Time";
            // 
            // perfCounterRAM
            // 
            this.perfCounterRAM.CategoryName = "Memory";
            this.perfCounterRAM.CounterName = "Available MBytes";
            // 
            // pbGPUUsage
            // 
            this.pbGPUUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.pbGPUUsage, "pbGPUUsage");
            this.pbGPUUsage.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pbGPUUsage.Name = "pbGPUUsage";
            // 
            // pbRAMUsage
            // 
            this.pbRAMUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.pbRAMUsage, "pbRAMUsage");
            this.pbRAMUsage.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pbRAMUsage.Name = "pbRAMUsage";
            // 
            // pbCPUUsage
            // 
            this.pbCPUUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.pbCPUUsage, "pbCPUUsage");
            this.pbCPUUsage.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pbCPUUsage.Name = "pbCPUUsage";
            // 
            // perfCounterGPU
            // 
            this.perfCounterGPU.CategoryName = "Thermal Zone Information";
            this.perfCounterGPU.CounterName = "Temperature";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.CausesValidation = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconGPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGPUTemp)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRAMTemp)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCPUTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCounterCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCounterRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCounterGPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_App;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_ProgramStatus;
        private System.Windows.Forms.ToolStripSeparator MenuStrip_App_Separator1;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_App_Preferences;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_App_ProgramRestart;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_App_ProgramShutdown;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Advanced;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Advanced_AIDiagnosis;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Help_About;
        private System.Windows.Forms.ToolStripMenuItem ManuStrip_Help_Manual;
        private System.Windows.Forms.ToolStripSeparator ManuStrip_Help_Separator1;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Help_CheckUpdates;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox debugConsoleOutputBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox debugConsoleInputBox;
        private System.Windows.Forms.Button debugConsoleSubmitButton;
        private System.Windows.Forms.Label lblNoImplemented1;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_CPUUsage;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Separator1;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_RAMUsage;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Separator2;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_GPUUsage;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Separator3;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_StorageUsage;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Separator4;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_NetworkSpeed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox iconCPU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox iconGPU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox iconRAM;
        private System.Windows.Forms.Label lblGPUStatus1;
        private System.Windows.Forms.Label lblRAMStatus1;
        private System.Windows.Forms.Label lblCPUStatus1;
        private System.Windows.Forms.PictureBox iconCPUTemp;
        private System.Diagnostics.PerformanceCounter perfCounterCPU;
        private System.Windows.Forms.PictureBox iconGPUTemp;
        private System.Windows.Forms.PictureBox iconRAMTemp;
        private System.Windows.Forms.ProgressBar pbGPUTemp;
        private System.Windows.Forms.ProgressBar pbRAMTemp;
        private System.Windows.Forms.ProgressBar pbCPUTemp;
        private System.Diagnostics.PerformanceCounter perfCounterRAM;
        private System.Diagnostics.PerformanceCounter perfCounterGPU;
        private System.Windows.Forms.ProgressBar pbGPUUsage;
        private System.Windows.Forms.ProgressBar pbRAMUsage;
        private System.Windows.Forms.ProgressBar pbCPUUsage;
        private System.Windows.Forms.Timer timerMain;
    }
}

