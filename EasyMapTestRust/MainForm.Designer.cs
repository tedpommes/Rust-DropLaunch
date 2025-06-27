namespace EasyMapTestRust
{
	partial class MainForm
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
			if (disposing)
			{
				// Dispose of the FileSystemWatcher if it exists
				if (watcher != null)
				{
					watcher.Dispose();
					watcher = null;
				}

				// Dispose of the NotifyIcon if it exists
				if (notifyIcon != null)
				{
					notifyIcon.Dispose();
					notifyIcon = null;
				}

				// Dispose of other components
				if (components != null)
				{
					components.Dispose();
				}
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties25 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties26 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties27 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties28 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties29 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties30 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties31 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties32 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties33 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties34 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties35 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties36 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuShadowPanel2 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.MainPages = new Bunifu.UI.WinForms.BunifuPages();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.StatusLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.StatusPic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TabsFoundMaps = new System.Windows.Forms.TabControl();
            this.MapsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createStartFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startServerWithMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPrefabStartFileAndStartServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openMapDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openServerDirectoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openClientMapsDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyMapDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMapNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.moreStartFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkFolderTab = new System.Windows.Forms.TabPage();
            this.MapsDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.NameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryTab = new System.Windows.Forms.TabPage();
            this.HistoryDataView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HelpTab = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.HelpPanelScroll = new Bunifu.UI.WinForms.BunifuPanel();
            this.FileWatcherPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.FilewatcherLabel = new System.Windows.Forms.Label();
            this.HelpVideosPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bunifuGroupBox7 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuGroupBox5 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.SetupLabel = new System.Windows.Forms.Label();
            this.HelpMapStartPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bunifuGroupBox6 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.TestingMaplabel = new System.Windows.Forms.Label();
            this.BottomConsolePanel = new System.Windows.Forms.Panel();
            this.ConsoleTextbox = new System.Windows.Forms.RichTextBox();
            this.SettingsBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.bunifuShadowPanel6 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.CheckToolTips = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.SettingsBranchDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.UpdateServerButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.WriteStartfilesButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.CheckDeleteClientMap = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckboxFileWatch = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.CheckboxDesktopNoti = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.CheckNewStart = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.SettingsDirectoryPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.RustGameDirbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.bunifuSeparator4 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.MapDirBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerFiles = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.SteamCMDBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuSeparator10 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.PanelSaperator2 = new System.Windows.Forms.Panel();
            this.ServerFilesDirbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.DirectoriesLab = new System.Windows.Forms.Label();
            this.DirectoriesLabel = new System.Windows.Forms.Label();
            this.SettingsTopPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.SaveSettingsButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SettingsBackButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SetupDirsPage = new System.Windows.Forms.TabPage();
            this.SetupMapsGroup = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.SetupRustGameDirbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuSeparator11 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.SetupMapsDirectory = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SetupServerFilesGroup = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.SetupCMDdir = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuSeparator5 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SetupServerTextbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.DropDownBranches = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuShadowPanel3 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.SetupDirBackButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SetupDirNextButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SetupCMDPage = new System.Windows.Forms.TabPage();
            this.CMDDownloadText = new System.Windows.Forms.RichTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.SetupStepsLabel = new System.Windows.Forms.Label();
            this.bunifuLoader1 = new Bunifu.UI.WinForms.BunifuLoader();
            this.AutoNextSetupCheck = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CMDStatusLabel = new System.Windows.Forms.Label();
            this.bunifuSeparator7 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuShadowPanel4 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.SetupCMDNextButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SetupCMDBackButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SetupEndPage = new System.Windows.Forms.TabPage();
            this.bunifuGroupBox4 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.CheckNoHelp = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.CheckHelpTooltips = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.CheckOpenReadme = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuGroupBox8 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.FinishRustGameDirbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuGroupBox3 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.CheckNoPlugins = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.RadioCarbon = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.RadioUmod = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.CheckRusteditDLL = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.CheckNoTesting = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CheckRunExampleStart = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.CheckCopyConnect = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuShadowPanel5 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.SetupcompletedHome = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.FirstRunPage = new System.Windows.Forms.TabPage();
            this.ImageButtonDiscord = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonGithub = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.bunifuShadowPanel9 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.FirstRunCustomInstall = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator12 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator13 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel11 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator14 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuShadowPanel11 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.bunifuShadowPanel8 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.FirstRunOneClick = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator9 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator6 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator8 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuShadowPanel10 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.label29 = new System.Windows.Forms.Label();
            this.bunifuShadowPanel7 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.FirstRunHomeButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label26 = new System.Windows.Forms.Label();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.MainSnackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.openServerDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.MainPages.SuspendLayout();
            this.MainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPic)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.TabsFoundMaps.SuspendLayout();
            this.MapsContextMenu.SuspendLayout();
            this.WorkFolderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapsDataGridView)).BeginInit();
            this.HistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataView)).BeginInit();
            this.HelpTab.SuspendLayout();
            this.panel9.SuspendLayout();
            this.HelpPanelScroll.SuspendLayout();
            this.FileWatcherPanel.SuspendLayout();
            this.HelpVideosPanel.SuspendLayout();
            this.bunifuGroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.bunifuGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.HelpMapStartPanel.SuspendLayout();
            this.BottomConsolePanel.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.bunifuShadowPanel6.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SettingsDirectoryPanel.SuspendLayout();
            this.bunifuGroupBox1.SuspendLayout();
            this.ServerFiles.SuspendLayout();
            this.PanelSaperator2.SuspendLayout();
            this.SettingsTopPanel.SuspendLayout();
            this.SetupDirsPage.SuspendLayout();
            this.SetupMapsGroup.SuspendLayout();
            this.SetupServerFilesGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bunifuShadowPanel3.SuspendLayout();
            this.SetupCMDPage.SuspendLayout();
            this.panel8.SuspendLayout();
            this.bunifuShadowPanel4.SuspendLayout();
            this.SetupEndPage.SuspendLayout();
            this.bunifuGroupBox4.SuspendLayout();
            this.bunifuGroupBox8.SuspendLayout();
            this.bunifuGroupBox3.SuspendLayout();
            this.bunifuGroupBox2.SuspendLayout();
            this.bunifuShadowPanel5.SuspendLayout();
            this.FirstRunPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuShadowPanel9.SuspendLayout();
            this.bunifuShadowPanel11.SuspendLayout();
            this.bunifuShadowPanel8.SuspendLayout();
            this.bunifuShadowPanel10.SuspendLayout();
            this.bunifuShadowPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel2
            // 
            this.bunifuShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.BorderRadius = 1;
            this.bunifuShadowPanel2.BorderThickness = 1;
            this.bunifuShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            this.bunifuShadowPanel2.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel2.ShadowDept = 2;
            this.bunifuShadowPanel2.ShadowDepth = 2;
            this.bunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel2.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel2.Size = new System.Drawing.Size(484, 466);
            this.bunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel2.TabIndex = 1;
            this.MainToolTip.SetToolTip(this.bunifuShadowPanel2, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuShadowPanel2, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuShadowPanel2, "");
            // 
            // MainPages
            // 
            this.MainPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.MainPages.AllowTransitions = false;
            this.MainPages.Controls.Add(this.MainPage);
            this.MainPages.Controls.Add(this.SettingsPage);
            this.MainPages.Controls.Add(this.SetupDirsPage);
            this.MainPages.Controls.Add(this.SetupCMDPage);
            this.MainPages.Controls.Add(this.SetupEndPage);
            this.MainPages.Controls.Add(this.FirstRunPage);
            this.MainPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPages.Location = new System.Drawing.Point(0, 0);
            this.MainPages.Multiline = true;
            this.MainPages.Name = "MainPages";
            this.MainPages.Page = this.FirstRunPage;
            this.MainPages.PageIndex = 5;
            this.MainPages.PageName = "FirstRunPage";
            this.MainPages.PageTitle = "FirstRun";
            this.MainPages.SelectedIndex = 0;
            this.MainPages.Size = new System.Drawing.Size(484, 466);
            this.MainPages.TabIndex = 0;
            this.MainToolTip.SetToolTip(this.MainPages, "");
            this.MainToolTip.SetToolTipIcon(this.MainPages, null);
            this.MainToolTip.SetToolTipTitle(this.MainPages, "");
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.MainPages.Transition = animation1;
            this.MainPages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MainPage.Controls.Add(this.StatusLabel);
            this.MainPage.Controls.Add(this.StatusPic);
            this.MainPage.Controls.Add(this.MainPanel);
            this.MainPage.Controls.Add(this.BottomConsolePanel);
            this.MainPage.Location = new System.Drawing.Point(4, 4);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(10);
            this.MainPage.Size = new System.Drawing.Size(476, 440);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "MainPage";
            this.MainToolTip.SetToolTip(this.MainPage, "");
            this.MainToolTip.SetToolTipIcon(this.MainPage, null);
            this.MainToolTip.SetToolTipTitle(this.MainPage, "");
            // 
            // StatusLabel
            // 
            this.StatusLabel.AllowParentOverrides = false;
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoEllipsis = false;
            this.StatusLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.StatusLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.StatusLabel.Location = new System.Drawing.Point(328, 7);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusLabel.Size = new System.Drawing.Size(111, 15);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "SteamCMD Status:";
            this.StatusLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.StatusLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.StatusLabel, "");
            this.MainToolTip.SetToolTipIcon(this.StatusLabel, null);
            this.MainToolTip.SetToolTipTitle(this.StatusLabel, "");
            // 
            // StatusPic
            // 
            this.StatusPic.AllowFocused = false;
            this.StatusPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusPic.AutoSizeHeight = true;
            this.StatusPic.BorderRadius = 0;
            this.StatusPic.Image = global::EasyMapTestRust.Properties.Resources.icons8_red_circle_48;
            this.StatusPic.IsCircle = false;
            this.StatusPic.Location = new System.Drawing.Point(444, 2);
            this.StatusPic.Name = "StatusPic";
            this.StatusPic.Size = new System.Drawing.Size(24, 24);
            this.StatusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatusPic.TabIndex = 6;
            this.StatusPic.TabStop = false;
            this.MainToolTip.SetToolTip(this.StatusPic, "");
            this.MainToolTip.SetToolTipIcon(this.StatusPic, null);
            this.MainToolTip.SetToolTipTitle(this.StatusPic, "");
            this.StatusPic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TabsFoundMaps);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(10, 10);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MainPanel.Size = new System.Drawing.Size(456, 327);
            this.MainPanel.TabIndex = 4;
            this.MainToolTip.SetToolTip(this.MainPanel, "");
            this.MainToolTip.SetToolTipIcon(this.MainPanel, null);
            this.MainToolTip.SetToolTipTitle(this.MainPanel, "");
            // 
            // TabsFoundMaps
            // 
            this.TabsFoundMaps.ContextMenuStrip = this.MapsContextMenu;
            this.TabsFoundMaps.Controls.Add(this.WorkFolderTab);
            this.TabsFoundMaps.Controls.Add(this.HistoryTab);
            this.TabsFoundMaps.Controls.Add(this.HelpTab);
            this.TabsFoundMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsFoundMaps.Location = new System.Drawing.Point(0, 0);
            this.TabsFoundMaps.Name = "TabsFoundMaps";
            this.TabsFoundMaps.SelectedIndex = 0;
            this.TabsFoundMaps.Size = new System.Drawing.Size(456, 322);
            this.TabsFoundMaps.TabIndex = 1;
            this.MainToolTip.SetToolTip(this.TabsFoundMaps, "");
            this.MainToolTip.SetToolTipIcon(this.TabsFoundMaps, null);
            this.MainToolTip.SetToolTipTitle(this.TabsFoundMaps, "");
            this.TabsFoundMaps.SelectedIndexChanged += new System.EventHandler(this.TabsFoundMaps_SelectedIndexChanged);
            // 
            // MapsContextMenu
            // 
            this.MapsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createStartFileToolStripMenuItem,
            this.startServerWithMapToolStripMenuItem,
            this.createPrefabStartFileAndStartServerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openMapDirectoryToolStripMenuItem,
            this.openServerDirectoryToolStripMenuItem1,
            this.openClientMapsDirectoryToolStripMenuItem,
            this.toolStripMenuItem2,
            this.copyMapDirectoryToolStripMenuItem,
            this.copyMapNameToolStripMenuItem,
            this.toolStripMenuItem3,
            this.moreStartFilesToolStripMenuItem});
            this.MapsContextMenu.Name = "MapsContextMenu";
            this.MapsContextMenu.Size = new System.Drawing.Size(281, 220);
            this.MainToolTip.SetToolTip(this.MapsContextMenu, "");
            this.MainToolTip.SetToolTipIcon(this.MapsContextMenu, null);
            this.MainToolTip.SetToolTipTitle(this.MapsContextMenu, "");
            this.MapsContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.MapsContextMenu_Opening);
            // 
            // createStartFileToolStripMenuItem
            // 
            this.createStartFileToolStripMenuItem.Name = "createStartFileToolStripMenuItem";
            this.createStartFileToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.createStartFileToolStripMenuItem.Text = "Create Map Start File";
            this.createStartFileToolStripMenuItem.Click += new System.EventHandler(this.createStartFileToolStripMenuItem_Click);
            // 
            // startServerWithMapToolStripMenuItem
            // 
            this.startServerWithMapToolStripMenuItem.Name = "startServerWithMapToolStripMenuItem";
            this.startServerWithMapToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.startServerWithMapToolStripMenuItem.Text = "Create Start File And Start Server ";
            this.startServerWithMapToolStripMenuItem.Click += new System.EventHandler(this.startServerWithMapToolStripMenuItem_Click_1);
            // 
            // createPrefabStartFileAndStartServerToolStripMenuItem
            // 
            this.createPrefabStartFileAndStartServerToolStripMenuItem.Name = "createPrefabStartFileAndStartServerToolStripMenuItem";
            this.createPrefabStartFileAndStartServerToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.createPrefabStartFileAndStartServerToolStripMenuItem.Text = "Create Prefab Start File And Start Server";
            this.createPrefabStartFileAndStartServerToolStripMenuItem.Click += new System.EventHandler(this.createPrefabStartFileAndStartServerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(277, 6);
            // 
            // openMapDirectoryToolStripMenuItem
            // 
            this.openMapDirectoryToolStripMenuItem.Name = "openMapDirectoryToolStripMenuItem";
            this.openMapDirectoryToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.openMapDirectoryToolStripMenuItem.Text = "Open Maps Directory";
            this.openMapDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openMapDirectoryToolStripMenuItem_Click);
            // 
            // openServerDirectoryToolStripMenuItem1
            // 
            this.openServerDirectoryToolStripMenuItem1.Name = "openServerDirectoryToolStripMenuItem1";
            this.openServerDirectoryToolStripMenuItem1.Size = new System.Drawing.Size(280, 22);
            this.openServerDirectoryToolStripMenuItem1.Text = "Open Server Directory";
            this.openServerDirectoryToolStripMenuItem1.Click += new System.EventHandler(this.openServerDirectoryToolStripMenuItem1_Click);
            // 
            // openClientMapsDirectoryToolStripMenuItem
            // 
            this.openClientMapsDirectoryToolStripMenuItem.Name = "openClientMapsDirectoryToolStripMenuItem";
            this.openClientMapsDirectoryToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.openClientMapsDirectoryToolStripMenuItem.Text = "Open Client Maps Directory";
            this.openClientMapsDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openClientMapsDirectoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(277, 6);
            // 
            // copyMapDirectoryToolStripMenuItem
            // 
            this.copyMapDirectoryToolStripMenuItem.Name = "copyMapDirectoryToolStripMenuItem";
            this.copyMapDirectoryToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.copyMapDirectoryToolStripMenuItem.Text = "Copy Map Directory";
            this.copyMapDirectoryToolStripMenuItem.Click += new System.EventHandler(this.copyMapDirectoryToolStripMenuItem_Click);
            // 
            // copyMapNameToolStripMenuItem
            // 
            this.copyMapNameToolStripMenuItem.Name = "copyMapNameToolStripMenuItem";
            this.copyMapNameToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.copyMapNameToolStripMenuItem.Text = "Copy Map Name";
            this.copyMapNameToolStripMenuItem.Click += new System.EventHandler(this.copyMapNameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(277, 6);
            // 
            // moreStartFilesToolStripMenuItem
            // 
            this.moreStartFilesToolStripMenuItem.Name = "moreStartFilesToolStripMenuItem";
            this.moreStartFilesToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.moreStartFilesToolStripMenuItem.Text = "Create ProcGen Start File";
            this.moreStartFilesToolStripMenuItem.Click += new System.EventHandler(this.moreStartFilesToolStripMenuItem_Click);
            // 
            // WorkFolderTab
            // 
            this.WorkFolderTab.Controls.Add(this.MapsDataGridView);
            this.WorkFolderTab.Location = new System.Drawing.Point(4, 22);
            this.WorkFolderTab.Name = "WorkFolderTab";
            this.WorkFolderTab.Padding = new System.Windows.Forms.Padding(3);
            this.WorkFolderTab.Size = new System.Drawing.Size(448, 296);
            this.WorkFolderTab.TabIndex = 0;
            this.WorkFolderTab.Text = "Active Folder";
            this.MainToolTip.SetToolTip(this.WorkFolderTab, "");
            this.MainToolTip.SetToolTipIcon(this.WorkFolderTab, null);
            this.MainToolTip.SetToolTipTitle(this.WorkFolderTab, "");
            this.WorkFolderTab.UseVisualStyleBackColor = true;
            // 
            // MapsDataGridView
            // 
            this.MapsDataGridView.AllowCustomTheming = false;
            this.MapsDataGridView.AllowUserToAddRows = false;
            this.MapsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.MapsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MapsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MapsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MapsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MapsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MapsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MapsDataGridView.ColumnHeadersHeight = 40;
            this.MapsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTab,
            this.LocationTab,
            this.DateTab});
            this.MapsDataGridView.ContextMenuStrip = this.MapsContextMenu;
            this.MapsDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.MapsDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MapsDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MapsDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.MapsDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.MapsDataGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.MapsDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.MapsDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.MapsDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.MapsDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MapsDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.MapsDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MapsDataGridView.CurrentTheme.Name = null;
            this.MapsDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MapsDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MapsDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MapsDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.MapsDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MapsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MapsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapsDataGridView.EnableHeadersVisualStyles = false;
            this.MapsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.MapsDataGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.MapsDataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.MapsDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.MapsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.MapsDataGridView.MultiSelect = false;
            this.MapsDataGridView.Name = "MapsDataGridView";
            this.MapsDataGridView.ReadOnly = true;
            this.MapsDataGridView.RowHeadersVisible = false;
            this.MapsDataGridView.RowTemplate.Height = 40;
            this.MapsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MapsDataGridView.Size = new System.Drawing.Size(442, 290);
            this.MapsDataGridView.TabIndex = 0;
            this.MapsDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.MainToolTip.SetToolTip(this.MapsDataGridView, "Rightclick for more options for selected map file.\r\nDouble click Map to start. \r\n" +
        "\r\nDrop map file on app to start server.\r\nDrop map file on non running app to sta" +
        "rt server.");
            this.MainToolTip.SetToolTipIcon(this.MapsDataGridView, null);
            this.MainToolTip.SetToolTipTitle(this.MapsDataGridView, "");
            this.MapsDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.MapsDataGridView_RowsRemoved);
            this.MapsDataGridView.DoubleClick += new System.EventHandler(this.MapsDataGridView_DoubleClick);
            // 
            // NameTab
            // 
            this.NameTab.HeaderText = "Name";
            this.NameTab.Name = "NameTab";
            this.NameTab.ReadOnly = true;
            // 
            // LocationTab
            // 
            this.LocationTab.HeaderText = "Location";
            this.LocationTab.Name = "LocationTab";
            this.LocationTab.ReadOnly = true;
            // 
            // DateTab
            // 
            this.DateTab.HeaderText = "Date ";
            this.DateTab.Name = "DateTab";
            this.DateTab.ReadOnly = true;
            // 
            // HistoryTab
            // 
            this.HistoryTab.Controls.Add(this.HistoryDataView);
            this.HistoryTab.Location = new System.Drawing.Point(4, 22);
            this.HistoryTab.Name = "HistoryTab";
            this.HistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryTab.Size = new System.Drawing.Size(448, 296);
            this.HistoryTab.TabIndex = 1;
            this.HistoryTab.Text = "Run History";
            this.MainToolTip.SetToolTip(this.HistoryTab, "");
            this.MainToolTip.SetToolTipIcon(this.HistoryTab, null);
            this.MainToolTip.SetToolTipTitle(this.HistoryTab, "");
            this.HistoryTab.UseVisualStyleBackColor = true;
            // 
            // HistoryDataView
            // 
            this.HistoryDataView.AllowCustomTheming = false;
            this.HistoryDataView.AllowUserToAddRows = false;
            this.HistoryDataView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.HistoryDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.HistoryDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.HistoryDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistoryDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.HistoryDataView.ColumnHeadersHeight = 40;
            this.HistoryDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.HistoryDataView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.HistoryDataView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.HistoryDataView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.HistoryDataView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.HistoryDataView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.HistoryDataView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.HistoryDataView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.HistoryDataView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.HistoryDataView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.HistoryDataView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.HistoryDataView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.HistoryDataView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.HistoryDataView.CurrentTheme.Name = null;
            this.HistoryDataView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.HistoryDataView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.HistoryDataView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.HistoryDataView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.HistoryDataView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HistoryDataView.DefaultCellStyle = dataGridViewCellStyle6;
            this.HistoryDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryDataView.EnableHeadersVisualStyles = false;
            this.HistoryDataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.HistoryDataView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.HistoryDataView.HeaderBgColor = System.Drawing.Color.Empty;
            this.HistoryDataView.HeaderForeColor = System.Drawing.Color.White;
            this.HistoryDataView.Location = new System.Drawing.Point(3, 3);
            this.HistoryDataView.Name = "HistoryDataView";
            this.HistoryDataView.ReadOnly = true;
            this.HistoryDataView.RowHeadersVisible = false;
            this.HistoryDataView.RowTemplate.Height = 40;
            this.HistoryDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HistoryDataView.Size = new System.Drawing.Size(442, 290);
            this.HistoryDataView.TabIndex = 1;
            this.HistoryDataView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.MainToolTip.SetToolTip(this.HistoryDataView, "");
            this.MainToolTip.SetToolTipIcon(this.HistoryDataView, null);
            this.MainToolTip.SetToolTipTitle(this.HistoryDataView, "");
            this.HistoryDataView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.HistoryDataView_RowsRemoved);
            this.HistoryDataView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.HistoryDataView_UserDeletingRow);
            this.HistoryDataView.DoubleClick += new System.EventHandler(this.HistoryDataView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Location";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Date ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // HelpTab
            // 
            this.HelpTab.AutoScroll = true;
            this.HelpTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.HelpTab.Controls.Add(this.panel9);
            this.HelpTab.Location = new System.Drawing.Point(4, 22);
            this.HelpTab.Name = "HelpTab";
            this.HelpTab.Padding = new System.Windows.Forms.Padding(5);
            this.HelpTab.Size = new System.Drawing.Size(448, 296);
            this.HelpTab.TabIndex = 2;
            this.HelpTab.Text = "Help";
            this.MainToolTip.SetToolTip(this.HelpTab, "");
            this.MainToolTip.SetToolTipIcon(this.HelpTab, null);
            this.MainToolTip.SetToolTipTitle(this.HelpTab, "");
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.HelpPanelScroll);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(5, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(438, 286);
            this.panel9.TabIndex = 7;
            this.MainToolTip.SetToolTip(this.panel9, "");
            this.MainToolTip.SetToolTipIcon(this.panel9, null);
            this.MainToolTip.SetToolTipTitle(this.panel9, "");
            // 
            // HelpPanelScroll
            // 
            this.HelpPanelScroll.AutoScroll = true;
            this.HelpPanelScroll.BackgroundColor = System.Drawing.Color.Transparent;
            this.HelpPanelScroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HelpPanelScroll.BackgroundImage")));
            this.HelpPanelScroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HelpPanelScroll.BorderColor = System.Drawing.Color.Transparent;
            this.HelpPanelScroll.BorderRadius = 3;
            this.HelpPanelScroll.BorderThickness = 1;
            this.HelpPanelScroll.Controls.Add(this.FileWatcherPanel);
            this.HelpPanelScroll.Controls.Add(this.HelpVideosPanel);
            this.HelpPanelScroll.Controls.Add(this.HelpMapStartPanel);
            this.HelpPanelScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpPanelScroll.Location = new System.Drawing.Point(0, 0);
            this.HelpPanelScroll.Name = "HelpPanelScroll";
            this.HelpPanelScroll.Padding = new System.Windows.Forms.Padding(5);
            this.HelpPanelScroll.ShowBorders = true;
            this.HelpPanelScroll.Size = new System.Drawing.Size(438, 286);
            this.HelpPanelScroll.TabIndex = 7;
            this.MainToolTip.SetToolTip(this.HelpPanelScroll, "");
            this.MainToolTip.SetToolTipIcon(this.HelpPanelScroll, null);
            this.MainToolTip.SetToolTipTitle(this.HelpPanelScroll, "");
            // 
            // FileWatcherPanel
            // 
            this.FileWatcherPanel.BackColor = System.Drawing.Color.Transparent;
            this.FileWatcherPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.FileWatcherPanel.BorderRadius = 8;
            this.FileWatcherPanel.BorderThickness = 1;
            this.FileWatcherPanel.Controls.Add(this.FilewatcherLabel);
            this.FileWatcherPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileWatcherPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.FileWatcherPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.FileWatcherPanel.Location = new System.Drawing.Point(5, 505);
            this.FileWatcherPanel.Name = "FileWatcherPanel";
            this.FileWatcherPanel.Padding = new System.Windows.Forms.Padding(10);
            this.FileWatcherPanel.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.FileWatcherPanel.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.FileWatcherPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.FileWatcherPanel.ShadowDept = 2;
            this.FileWatcherPanel.ShadowDepth = 5;
            this.FileWatcherPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.FileWatcherPanel.ShadowTopLeftVisible = false;
            this.FileWatcherPanel.Size = new System.Drawing.Size(411, 250);
            this.FileWatcherPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.FileWatcherPanel.TabIndex = 2;
            this.MainToolTip.SetToolTip(this.FileWatcherPanel, "");
            this.MainToolTip.SetToolTipIcon(this.FileWatcherPanel, null);
            this.MainToolTip.SetToolTipTitle(this.FileWatcherPanel, "");
            // 
            // FilewatcherLabel
            // 
            this.FilewatcherLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilewatcherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilewatcherLabel.Location = new System.Drawing.Point(10, 10);
            this.FilewatcherLabel.Name = "FilewatcherLabel";
            this.FilewatcherLabel.Size = new System.Drawing.Size(391, 20);
            this.FilewatcherLabel.TabIndex = 6;
            this.FilewatcherLabel.Text = "File Watcher";
            this.FilewatcherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.FilewatcherLabel, "");
            this.MainToolTip.SetToolTipIcon(this.FilewatcherLabel, null);
            this.MainToolTip.SetToolTipTitle(this.FilewatcherLabel, "");
            this.FilewatcherLabel.Click += new System.EventHandler(this.FilewatcherLabel_Click);
            // 
            // HelpVideosPanel
            // 
            this.HelpVideosPanel.BackColor = System.Drawing.Color.Transparent;
            this.HelpVideosPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.HelpVideosPanel.BorderRadius = 8;
            this.HelpVideosPanel.BorderThickness = 1;
            this.HelpVideosPanel.Controls.Add(this.bunifuGroupBox7);
            this.HelpVideosPanel.Controls.Add(this.bunifuSeparator1);
            this.HelpVideosPanel.Controls.Add(this.bunifuGroupBox5);
            this.HelpVideosPanel.Controls.Add(this.SetupLabel);
            this.HelpVideosPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelpVideosPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.HelpVideosPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.HelpVideosPanel.Location = new System.Drawing.Point(5, 255);
            this.HelpVideosPanel.Name = "HelpVideosPanel";
            this.HelpVideosPanel.Padding = new System.Windows.Forms.Padding(10);
            this.HelpVideosPanel.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.HelpVideosPanel.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.HelpVideosPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.HelpVideosPanel.ShadowDept = 2;
            this.HelpVideosPanel.ShadowDepth = 5;
            this.HelpVideosPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.HelpVideosPanel.ShadowTopLeftVisible = false;
            this.HelpVideosPanel.Size = new System.Drawing.Size(411, 250);
            this.HelpVideosPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.HelpVideosPanel.TabIndex = 0;
            this.MainToolTip.SetToolTip(this.HelpVideosPanel, "");
            this.MainToolTip.SetToolTipIcon(this.HelpVideosPanel, null);
            this.MainToolTip.SetToolTipTitle(this.HelpVideosPanel, "");
            // 
            // bunifuGroupBox7
            // 
            this.bunifuGroupBox7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuGroupBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuGroupBox7.BorderRadius = 8;
            this.bunifuGroupBox7.BorderThickness = 2;
            this.bunifuGroupBox7.Controls.Add(this.bunifuLabel5);
            this.bunifuGroupBox7.Controls.Add(this.bunifuPictureBox1);
            this.bunifuGroupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox7.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox7.LabelIndent = 10;
            this.bunifuGroupBox7.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox7.Location = new System.Drawing.Point(10, 131);
            this.bunifuGroupBox7.Name = "bunifuGroupBox7";
            this.bunifuGroupBox7.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.bunifuGroupBox7.Size = new System.Drawing.Size(391, 106);
            this.bunifuGroupBox7.TabIndex = 22;
            this.bunifuGroupBox7.TabStop = false;
            this.bunifuGroupBox7.Text = "Full app overview: 3 min";
            this.MainToolTip.SetToolTip(this.bunifuGroupBox7, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuGroupBox7, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuGroupBox7, "");
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel5.Location = new System.Drawing.Point(31, 22);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(162, 75);
            this.bunifuLabel5.TabIndex = 8;
            this.bunifuLabel5.Text = "App setup\r\nExample workflow\r\nMultiple ways to launch a map\r\nFilewatcher explained" +
    "\r\nExtra app options";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.bunifuLabel5, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLabel5, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLabel5, "");
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = false;
            this.bunifuPictureBox1.BorderRadius = 8;
            this.bunifuPictureBox1.Image = global::EasyMapTestRust.Properties.Resources.icons8_update_64;
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(229, 33);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(133, 54);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuPictureBox1.TabIndex = 7;
            this.bunifuPictureBox1.TabStop = false;
            this.MainToolTip.SetToolTip(this.bunifuPictureBox1, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuPictureBox1, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuPictureBox1, "");
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(10, 108);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(391, 23);
            this.bunifuSeparator1.TabIndex = 23;
            this.MainToolTip.SetToolTip(this.bunifuSeparator1, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator1, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator1, "");
            // 
            // bunifuGroupBox5
            // 
            this.bunifuGroupBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuGroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuGroupBox5.BorderRadius = 8;
            this.bunifuGroupBox5.BorderThickness = 2;
            this.bunifuGroupBox5.Controls.Add(this.bunifuLabel4);
            this.bunifuGroupBox5.Controls.Add(this.bunifuPictureBox2);
            this.bunifuGroupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox5.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox5.LabelIndent = 10;
            this.bunifuGroupBox5.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox5.Location = new System.Drawing.Point(10, 30);
            this.bunifuGroupBox5.Name = "bunifuGroupBox5";
            this.bunifuGroupBox5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.bunifuGroupBox5.Size = new System.Drawing.Size(391, 78);
            this.bunifuGroupBox5.TabIndex = 21;
            this.bunifuGroupBox5.TabStop = false;
            this.bunifuGroupBox5.Text = "Quick start video: 1 Min";
            this.MainToolTip.SetToolTip(this.bunifuGroupBox5, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuGroupBox5, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuGroupBox5, "");
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.Location = new System.Drawing.Point(31, 22);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(132, 45);
            this.bunifuLabel4.TabIndex = 8;
            this.bunifuLabel4.Text = "Downloading server files.\r\nLaunching a map\r\nUpdating the server files.";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.bunifuLabel4, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLabel4, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLabel4, "");
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = false;
            this.bunifuPictureBox2.BorderRadius = 8;
            this.bunifuPictureBox2.Image = global::EasyMapTestRust.Properties.Resources.icons8_update_64;
            this.bunifuPictureBox2.IsCircle = false;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(229, 16);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(133, 54);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuPictureBox2.TabIndex = 7;
            this.bunifuPictureBox2.TabStop = false;
            this.MainToolTip.SetToolTip(this.bunifuPictureBox2, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuPictureBox2, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuPictureBox2, "");
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // SetupLabel
            // 
            this.SetupLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupLabel.Location = new System.Drawing.Point(10, 10);
            this.SetupLabel.Name = "SetupLabel";
            this.SetupLabel.Size = new System.Drawing.Size(391, 20);
            this.SetupLabel.TabIndex = 6;
            this.SetupLabel.Text = "Help Videos";
            this.SetupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.SetupLabel, "");
            this.MainToolTip.SetToolTipIcon(this.SetupLabel, null);
            this.MainToolTip.SetToolTipTitle(this.SetupLabel, "");
            this.SetupLabel.Click += new System.EventHandler(this.SetupLabel_Click);
            // 
            // HelpMapStartPanel
            // 
            this.HelpMapStartPanel.BackColor = System.Drawing.Color.Transparent;
            this.HelpMapStartPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.HelpMapStartPanel.BorderRadius = 8;
            this.HelpMapStartPanel.BorderThickness = 1;
            this.HelpMapStartPanel.Controls.Add(this.bunifuGroupBox6);
            this.HelpMapStartPanel.Controls.Add(this.TestingMaplabel);
            this.HelpMapStartPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelpMapStartPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.HelpMapStartPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.HelpMapStartPanel.Location = new System.Drawing.Point(5, 5);
            this.HelpMapStartPanel.Name = "HelpMapStartPanel";
            this.HelpMapStartPanel.Padding = new System.Windows.Forms.Padding(10);
            this.HelpMapStartPanel.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.HelpMapStartPanel.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.HelpMapStartPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.HelpMapStartPanel.ShadowDept = 2;
            this.HelpMapStartPanel.ShadowDepth = 5;
            this.HelpMapStartPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.HelpMapStartPanel.ShadowTopLeftVisible = false;
            this.HelpMapStartPanel.Size = new System.Drawing.Size(411, 250);
            this.HelpMapStartPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.HelpMapStartPanel.TabIndex = 1;
            this.MainToolTip.SetToolTip(this.HelpMapStartPanel, "");
            this.MainToolTip.SetToolTipIcon(this.HelpMapStartPanel, null);
            this.MainToolTip.SetToolTipTitle(this.HelpMapStartPanel, "");
            // 
            // bunifuGroupBox6
            // 
            this.bunifuGroupBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuGroupBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuGroupBox6.BorderRadius = 8;
            this.bunifuGroupBox6.BorderThickness = 2;
            this.bunifuGroupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox6.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox6.LabelIndent = 10;
            this.bunifuGroupBox6.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox6.Location = new System.Drawing.Point(10, 30);
            this.bunifuGroupBox6.Name = "bunifuGroupBox6";
            this.bunifuGroupBox6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.bunifuGroupBox6.Size = new System.Drawing.Size(391, 135);
            this.bunifuGroupBox6.TabIndex = 22;
            this.bunifuGroupBox6.TabStop = false;
            this.bunifuGroupBox6.Text = "Server Files (Required)";
            this.MainToolTip.SetToolTip(this.bunifuGroupBox6, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuGroupBox6, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuGroupBox6, "");
            // 
            // TestingMaplabel
            // 
            this.TestingMaplabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TestingMaplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestingMaplabel.Location = new System.Drawing.Point(10, 10);
            this.TestingMaplabel.Name = "TestingMaplabel";
            this.TestingMaplabel.Size = new System.Drawing.Size(391, 20);
            this.TestingMaplabel.TabIndex = 6;
            this.TestingMaplabel.Text = "Launch a map";
            this.TestingMaplabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.TestingMaplabel, "");
            this.MainToolTip.SetToolTipIcon(this.TestingMaplabel, null);
            this.MainToolTip.SetToolTipTitle(this.TestingMaplabel, "");
            this.TestingMaplabel.Click += new System.EventHandler(this.TestingMaplabel_Click);
            // 
            // BottomConsolePanel
            // 
            this.BottomConsolePanel.Controls.Add(this.ConsoleTextbox);
            this.BottomConsolePanel.Controls.Add(this.SettingsBtn);
            this.BottomConsolePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomConsolePanel.Location = new System.Drawing.Point(10, 337);
            this.BottomConsolePanel.Name = "BottomConsolePanel";
            this.BottomConsolePanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BottomConsolePanel.Size = new System.Drawing.Size(456, 93);
            this.BottomConsolePanel.TabIndex = 3;
            this.MainToolTip.SetToolTip(this.BottomConsolePanel, "");
            this.MainToolTip.SetToolTipIcon(this.BottomConsolePanel, null);
            this.MainToolTip.SetToolTipTitle(this.BottomConsolePanel, "");
            // 
            // ConsoleTextbox
            // 
            this.ConsoleTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ConsoleTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleTextbox.Location = new System.Drawing.Point(0, 5);
            this.ConsoleTextbox.Name = "ConsoleTextbox";
            this.ConsoleTextbox.ReadOnly = true;
            this.ConsoleTextbox.Size = new System.Drawing.Size(456, 61);
            this.ConsoleTextbox.TabIndex = 1;
            this.ConsoleTextbox.Text = "";
            this.MainToolTip.SetToolTip(this.ConsoleTextbox, "");
            this.MainToolTip.SetToolTipIcon(this.ConsoleTextbox, null);
            this.MainToolTip.SetToolTipTitle(this.ConsoleTextbox, "");
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.AllowAnimations = true;
            this.SettingsBtn.AllowMouseEffects = true;
            this.SettingsBtn.AllowToggling = false;
            this.SettingsBtn.AnimationSpeed = 200;
            this.SettingsBtn.AutoGenerateColors = false;
            this.SettingsBtn.AutoRoundBorders = false;
            this.SettingsBtn.AutoSizeLeftIcon = true;
            this.SettingsBtn.AutoSizeRightIcon = true;
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.SettingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.BackgroundImage")));
            this.SettingsBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SettingsBtn.ButtonText = "SETTINGS";
            this.SettingsBtn.ButtonTextMarginLeft = 0;
            this.SettingsBtn.ColorContrastOnClick = 45;
            this.SettingsBtn.ColorContrastOnHover = 45;
            this.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.SettingsBtn.CustomizableEdges = borderEdges1;
            this.SettingsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingsBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SettingsBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SettingsBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SettingsBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SettingsBtn.IconMarginLeft = 11;
            this.SettingsBtn.IconPadding = 10;
            this.SettingsBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SettingsBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SettingsBtn.IconSize = 25;
            this.SettingsBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SettingsBtn.IdleBorderRadius = 3;
            this.SettingsBtn.IdleBorderThickness = 1;
            this.SettingsBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.SettingsBtn.IdleIconLeftImage = null;
            this.SettingsBtn.IdleIconRightImage = null;
            this.SettingsBtn.IndicateFocus = false;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 66);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SettingsBtn.OnDisabledState.BorderRadius = 3;
            this.SettingsBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SettingsBtn.OnDisabledState.BorderThickness = 1;
            this.SettingsBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SettingsBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SettingsBtn.OnDisabledState.IconLeftImage = null;
            this.SettingsBtn.OnDisabledState.IconRightImage = null;
            this.SettingsBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SettingsBtn.onHoverState.BorderRadius = 3;
            this.SettingsBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SettingsBtn.onHoverState.BorderThickness = 1;
            this.SettingsBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SettingsBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.onHoverState.IconLeftImage = null;
            this.SettingsBtn.onHoverState.IconRightImage = null;
            this.SettingsBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SettingsBtn.OnIdleState.BorderRadius = 3;
            this.SettingsBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SettingsBtn.OnIdleState.BorderThickness = 1;
            this.SettingsBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.SettingsBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.OnIdleState.IconLeftImage = null;
            this.SettingsBtn.OnIdleState.IconRightImage = null;
            this.SettingsBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SettingsBtn.OnPressedState.BorderRadius = 3;
            this.SettingsBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SettingsBtn.OnPressedState.BorderThickness = 1;
            this.SettingsBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SettingsBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.OnPressedState.IconLeftImage = null;
            this.SettingsBtn.OnPressedState.IconRightImage = null;
            this.SettingsBtn.Size = new System.Drawing.Size(456, 27);
            this.SettingsBtn.TabIndex = 2;
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SettingsBtn.TextMarginLeft = 0;
            this.SettingsBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.SettingsBtn, "");
            this.MainToolTip.SetToolTipIcon(this.SettingsBtn, null);
            this.MainToolTip.SetToolTipTitle(this.SettingsBtn, "");
            this.SettingsBtn.UseDefaultRadiusAndThickness = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // SettingsPage
            // 
            this.SettingsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SettingsPage.Controls.Add(this.bunifuShadowPanel6);
            this.SettingsPage.Controls.Add(this.bunifuShadowPanel1);
            this.SettingsPage.Controls.Add(this.SettingsDirectoryPanel);
            this.SettingsPage.Controls.Add(this.SettingsTopPanel);
            this.SettingsPage.Location = new System.Drawing.Point(4, 4);
            this.SettingsPage.Margin = new System.Windows.Forms.Padding(10);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.SettingsPage.Size = new System.Drawing.Size(476, 440);
            this.SettingsPage.TabIndex = 1;
            this.SettingsPage.Text = "SettingsPage";
            this.MainToolTip.SetToolTip(this.SettingsPage, "");
            this.MainToolTip.SetToolTipIcon(this.SettingsPage, null);
            this.MainToolTip.SetToolTipTitle(this.SettingsPage, "");
            // 
            // bunifuShadowPanel6
            // 
            this.bunifuShadowPanel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel6.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel6.BorderRadius = 8;
            this.bunifuShadowPanel6.BorderThickness = 1;
            this.bunifuShadowPanel6.Controls.Add(this.label19);
            this.bunifuShadowPanel6.Controls.Add(this.CheckToolTips);
            this.bunifuShadowPanel6.Controls.Add(this.SettingsBranchDropdown);
            this.bunifuShadowPanel6.Controls.Add(this.UpdateServerButton);
            this.bunifuShadowPanel6.Controls.Add(this.WriteStartfilesButton);
            this.bunifuShadowPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel6.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel6.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel6.Location = new System.Drawing.Point(10, 408);
            this.bunifuShadowPanel6.Name = "bunifuShadowPanel6";
            this.bunifuShadowPanel6.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuShadowPanel6.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel6.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel6.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel6.ShadowDept = 2;
            this.bunifuShadowPanel6.ShadowDepth = 5;
            this.bunifuShadowPanel6.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel6.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel6.Size = new System.Drawing.Size(456, 52);
            this.bunifuShadowPanel6.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel6.TabIndex = 20;
            this.MainToolTip.SetToolTip(this.bunifuShadowPanel6, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuShadowPanel6, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuShadowPanel6, "");
            // 
            // label19
            // 
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(166, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Show help tooltips";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MainToolTip.SetToolTip(this.label19, "");
            this.MainToolTip.SetToolTipIcon(this.label19, null);
            this.MainToolTip.SetToolTipTitle(this.label19, "");
            // 
            // CheckToolTips
            // 
            this.CheckToolTips.AllowBindingControlAnimation = true;
            this.CheckToolTips.AllowBindingControlColorChanges = false;
            this.CheckToolTips.AllowBindingControlLocation = true;
            this.CheckToolTips.AllowCheckBoxAnimation = false;
            this.CheckToolTips.AllowCheckmarkAnimation = true;
            this.CheckToolTips.AllowOnHoverStates = true;
            this.CheckToolTips.AutoCheck = true;
            this.CheckToolTips.BackColor = System.Drawing.Color.Transparent;
            this.CheckToolTips.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckToolTips.BackgroundImage")));
            this.CheckToolTips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckToolTips.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckToolTips.BorderRadius = 12;
            this.CheckToolTips.Checked = true;
            this.CheckToolTips.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.CheckToolTips.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckToolTips.CustomCheckmarkImage = null;
            this.CheckToolTips.Location = new System.Drawing.Point(141, 16);
            this.CheckToolTips.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckToolTips.Name = "CheckToolTips";
            this.CheckToolTips.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckToolTips.OnCheck.BorderRadius = 12;
            this.CheckToolTips.OnCheck.BorderThickness = 2;
            this.CheckToolTips.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckToolTips.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckToolTips.OnCheck.CheckmarkThickness = 2;
            this.CheckToolTips.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckToolTips.OnDisable.BorderRadius = 12;
            this.CheckToolTips.OnDisable.BorderThickness = 2;
            this.CheckToolTips.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckToolTips.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckToolTips.OnDisable.CheckmarkThickness = 2;
            this.CheckToolTips.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckToolTips.OnHoverChecked.BorderRadius = 12;
            this.CheckToolTips.OnHoverChecked.BorderThickness = 2;
            this.CheckToolTips.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckToolTips.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckToolTips.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckToolTips.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckToolTips.OnHoverUnchecked.BorderRadius = 12;
            this.CheckToolTips.OnHoverUnchecked.BorderThickness = 1;
            this.CheckToolTips.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckToolTips.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckToolTips.OnUncheck.BorderRadius = 12;
            this.CheckToolTips.OnUncheck.BorderThickness = 1;
            this.CheckToolTips.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckToolTips.Size = new System.Drawing.Size(21, 21);
            this.CheckToolTips.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckToolTips.TabIndex = 16;
            this.CheckToolTips.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckToolTips, "");
            this.MainToolTip.SetToolTipIcon(this.CheckToolTips, null);
            this.CheckToolTips.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckToolTips, "");
            this.CheckToolTips.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.CheckToolTips_CheckedChanged);
            // 
            // SettingsBranchDropdown
            // 
            this.SettingsBranchDropdown.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBranchDropdown.BackgroundColor = System.Drawing.Color.DimGray;
            this.SettingsBranchDropdown.BorderColor = System.Drawing.Color.Silver;
            this.SettingsBranchDropdown.BorderRadius = 8;
            this.SettingsBranchDropdown.Color = System.Drawing.Color.Silver;
            this.SettingsBranchDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.SettingsBranchDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SettingsBranchDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SettingsBranchDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SettingsBranchDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SettingsBranchDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.SettingsBranchDropdown.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsBranchDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SettingsBranchDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.SettingsBranchDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingsBranchDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.SettingsBranchDropdown.FillDropDown = true;
            this.SettingsBranchDropdown.FillIndicator = false;
            this.SettingsBranchDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBranchDropdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SettingsBranchDropdown.ForeColor = System.Drawing.Color.Black;
            this.SettingsBranchDropdown.FormattingEnabled = true;
            this.SettingsBranchDropdown.Icon = null;
            this.SettingsBranchDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.SettingsBranchDropdown.IndicatorColor = System.Drawing.Color.DarkGray;
            this.SettingsBranchDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.SettingsBranchDropdown.IndicatorThickness = 2;
            this.SettingsBranchDropdown.IsDropdownOpened = false;
            this.SettingsBranchDropdown.ItemBackColor = System.Drawing.Color.White;
            this.SettingsBranchDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.SettingsBranchDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.SettingsBranchDropdown.ItemHeight = 26;
            this.SettingsBranchDropdown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.SettingsBranchDropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.SettingsBranchDropdown.Items.AddRange(new object[] {
            "Main",
            "Staging",
            "Aux02",
            "Aux03"});
            this.SettingsBranchDropdown.ItemTopMargin = 3;
            this.SettingsBranchDropdown.Location = new System.Drawing.Point(281, 10);
            this.SettingsBranchDropdown.Name = "SettingsBranchDropdown";
            this.SettingsBranchDropdown.Size = new System.Drawing.Size(73, 32);
            this.SettingsBranchDropdown.TabIndex = 12;
            this.SettingsBranchDropdown.Text = null;
            this.SettingsBranchDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.SettingsBranchDropdown.TextLeftMargin = 5;
            this.MainToolTip.SetToolTip(this.SettingsBranchDropdown, "Choose a branch from the dropdown.\r\n\r\nThe main branch - Normal server files\r\nStag" +
        "ing - Updated files before they hit the main branch\r\nAux02 - \r\nAux03 - Known use" +
        "d branch (requires password)");
            this.MainToolTip.SetToolTipIcon(this.SettingsBranchDropdown, null);
            this.MainToolTip.SetToolTipTitle(this.SettingsBranchDropdown, "");
            // 
            // UpdateServerButton
            // 
            this.UpdateServerButton.AllowAnimations = true;
            this.UpdateServerButton.AllowMouseEffects = true;
            this.UpdateServerButton.AllowToggling = false;
            this.UpdateServerButton.AnimationSpeed = 200;
            this.UpdateServerButton.AutoGenerateColors = false;
            this.UpdateServerButton.AutoRoundBorders = false;
            this.UpdateServerButton.AutoSizeLeftIcon = true;
            this.UpdateServerButton.AutoSizeRightIcon = true;
            this.UpdateServerButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateServerButton.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.UpdateServerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateServerButton.BackgroundImage")));
            this.UpdateServerButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.UpdateServerButton.ButtonText = "Update Server";
            this.UpdateServerButton.ButtonTextMarginLeft = 0;
            this.UpdateServerButton.ColorContrastOnClick = 45;
            this.UpdateServerButton.ColorContrastOnHover = 45;
            this.UpdateServerButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.UpdateServerButton.CustomizableEdges = borderEdges2;
            this.UpdateServerButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateServerButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateServerButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateServerButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateServerButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.UpdateServerButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.UpdateServerButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateServerButton.ForeColor = System.Drawing.Color.White;
            this.UpdateServerButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateServerButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateServerButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.UpdateServerButton.IconMarginLeft = 11;
            this.UpdateServerButton.IconPadding = 10;
            this.UpdateServerButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateServerButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateServerButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.UpdateServerButton.IconSize = 25;
            this.UpdateServerButton.IdleBorderColor = System.Drawing.Color.Peru;
            this.UpdateServerButton.IdleBorderRadius = 8;
            this.UpdateServerButton.IdleBorderThickness = 1;
            this.UpdateServerButton.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.UpdateServerButton.IdleIconLeftImage = null;
            this.UpdateServerButton.IdleIconRightImage = null;
            this.UpdateServerButton.IndicateFocus = false;
            this.UpdateServerButton.Location = new System.Drawing.Point(354, 10);
            this.UpdateServerButton.Name = "UpdateServerButton";
            this.UpdateServerButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateServerButton.OnDisabledState.BorderRadius = 8;
            this.UpdateServerButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.UpdateServerButton.OnDisabledState.BorderThickness = 1;
            this.UpdateServerButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateServerButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateServerButton.OnDisabledState.IconLeftImage = null;
            this.UpdateServerButton.OnDisabledState.IconRightImage = null;
            this.UpdateServerButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UpdateServerButton.onHoverState.BorderRadius = 8;
            this.UpdateServerButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.UpdateServerButton.onHoverState.BorderThickness = 1;
            this.UpdateServerButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UpdateServerButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.UpdateServerButton.onHoverState.IconLeftImage = null;
            this.UpdateServerButton.onHoverState.IconRightImage = null;
            this.UpdateServerButton.OnIdleState.BorderColor = System.Drawing.Color.Peru;
            this.UpdateServerButton.OnIdleState.BorderRadius = 8;
            this.UpdateServerButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.UpdateServerButton.OnIdleState.BorderThickness = 1;
            this.UpdateServerButton.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.UpdateServerButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.UpdateServerButton.OnIdleState.IconLeftImage = null;
            this.UpdateServerButton.OnIdleState.IconRightImage = null;
            this.UpdateServerButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.UpdateServerButton.OnPressedState.BorderRadius = 8;
            this.UpdateServerButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.UpdateServerButton.OnPressedState.BorderThickness = 1;
            this.UpdateServerButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.UpdateServerButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.UpdateServerButton.OnPressedState.IconLeftImage = null;
            this.UpdateServerButton.OnPressedState.IconRightImage = null;
            this.UpdateServerButton.Size = new System.Drawing.Size(92, 32);
            this.UpdateServerButton.TabIndex = 13;
            this.UpdateServerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateServerButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateServerButton.TextMarginLeft = 0;
            this.UpdateServerButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.UpdateServerButton, "");
            this.MainToolTip.SetToolTipIcon(this.UpdateServerButton, null);
            this.MainToolTip.SetToolTipTitle(this.UpdateServerButton, "");
            this.UpdateServerButton.UseDefaultRadiusAndThickness = true;
            this.UpdateServerButton.Click += new System.EventHandler(this.UpdateServerButton_Click);
            // 
            // WriteStartfilesButton
            // 
            this.WriteStartfilesButton.AllowAnimations = true;
            this.WriteStartfilesButton.AllowMouseEffects = true;
            this.WriteStartfilesButton.AllowToggling = false;
            this.WriteStartfilesButton.AnimationSpeed = 200;
            this.WriteStartfilesButton.AutoGenerateColors = false;
            this.WriteStartfilesButton.AutoRoundBorders = false;
            this.WriteStartfilesButton.AutoSizeLeftIcon = true;
            this.WriteStartfilesButton.AutoSizeRightIcon = true;
            this.WriteStartfilesButton.BackColor = System.Drawing.Color.Transparent;
            this.WriteStartfilesButton.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.WriteStartfilesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WriteStartfilesButton.BackgroundImage")));
            this.WriteStartfilesButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.WriteStartfilesButton.ButtonText = "Reset Settings";
            this.WriteStartfilesButton.ButtonTextMarginLeft = 0;
            this.WriteStartfilesButton.ColorContrastOnClick = 45;
            this.WriteStartfilesButton.ColorContrastOnHover = 45;
            this.WriteStartfilesButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.WriteStartfilesButton.CustomizableEdges = borderEdges3;
            this.WriteStartfilesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.WriteStartfilesButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.WriteStartfilesButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.WriteStartfilesButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.WriteStartfilesButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.WriteStartfilesButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.WriteStartfilesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteStartfilesButton.ForeColor = System.Drawing.Color.White;
            this.WriteStartfilesButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WriteStartfilesButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.WriteStartfilesButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.WriteStartfilesButton.IconMarginLeft = 11;
            this.WriteStartfilesButton.IconPadding = 10;
            this.WriteStartfilesButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WriteStartfilesButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.WriteStartfilesButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.WriteStartfilesButton.IconSize = 25;
            this.WriteStartfilesButton.IdleBorderColor = System.Drawing.Color.Peru;
            this.WriteStartfilesButton.IdleBorderRadius = 8;
            this.WriteStartfilesButton.IdleBorderThickness = 1;
            this.WriteStartfilesButton.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.WriteStartfilesButton.IdleIconLeftImage = null;
            this.WriteStartfilesButton.IdleIconRightImage = null;
            this.WriteStartfilesButton.IndicateFocus = false;
            this.WriteStartfilesButton.Location = new System.Drawing.Point(10, 10);
            this.WriteStartfilesButton.Name = "WriteStartfilesButton";
            this.WriteStartfilesButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.WriteStartfilesButton.OnDisabledState.BorderRadius = 8;
            this.WriteStartfilesButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.WriteStartfilesButton.OnDisabledState.BorderThickness = 1;
            this.WriteStartfilesButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.WriteStartfilesButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.WriteStartfilesButton.OnDisabledState.IconLeftImage = null;
            this.WriteStartfilesButton.OnDisabledState.IconRightImage = null;
            this.WriteStartfilesButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.WriteStartfilesButton.onHoverState.BorderRadius = 8;
            this.WriteStartfilesButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.WriteStartfilesButton.onHoverState.BorderThickness = 1;
            this.WriteStartfilesButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.WriteStartfilesButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.WriteStartfilesButton.onHoverState.IconLeftImage = null;
            this.WriteStartfilesButton.onHoverState.IconRightImage = null;
            this.WriteStartfilesButton.OnIdleState.BorderColor = System.Drawing.Color.Peru;
            this.WriteStartfilesButton.OnIdleState.BorderRadius = 8;
            this.WriteStartfilesButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.WriteStartfilesButton.OnIdleState.BorderThickness = 1;
            this.WriteStartfilesButton.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.WriteStartfilesButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.WriteStartfilesButton.OnIdleState.IconLeftImage = null;
            this.WriteStartfilesButton.OnIdleState.IconRightImage = null;
            this.WriteStartfilesButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.WriteStartfilesButton.OnPressedState.BorderRadius = 8;
            this.WriteStartfilesButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.WriteStartfilesButton.OnPressedState.BorderThickness = 1;
            this.WriteStartfilesButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.WriteStartfilesButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.WriteStartfilesButton.OnPressedState.IconLeftImage = null;
            this.WriteStartfilesButton.OnPressedState.IconRightImage = null;
            this.WriteStartfilesButton.Size = new System.Drawing.Size(99, 32);
            this.WriteStartfilesButton.TabIndex = 14;
            this.WriteStartfilesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WriteStartfilesButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.WriteStartfilesButton.TextMarginLeft = 0;
            this.WriteStartfilesButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.WriteStartfilesButton, "");
            this.MainToolTip.SetToolTipIcon(this.WriteStartfilesButton, null);
            this.MainToolTip.SetToolTipTitle(this.WriteStartfilesButton, "");
            this.WriteStartfilesButton.UseDefaultRadiusAndThickness = true;
            this.WriteStartfilesButton.Click += new System.EventHandler(this.WriteStartfilesButton_Click);
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 8;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.label21);
            this.bunifuShadowPanel1.Controls.Add(this.CheckDeleteClientMap);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuSeparator2);
            this.bunifuShadowPanel1.Controls.Add(this.label7);
            this.bunifuShadowPanel1.Controls.Add(this.label6);
            this.bunifuShadowPanel1.Controls.Add(this.label4);
            this.bunifuShadowPanel1.Controls.Add(this.CheckboxFileWatch);
            this.bunifuShadowPanel1.Controls.Add(this.CheckboxDesktopNoti);
            this.bunifuShadowPanel1.Controls.Add(this.CheckNewStart);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(10, 348);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuShadowPanel1.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(456, 60);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 3;
            this.MainToolTip.SetToolTip(this.bunifuShadowPanel1, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuShadowPanel1, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuShadowPanel1, "");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(246, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(188, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Backup .map file from client each boot";
            this.MainToolTip.SetToolTip(this.label21, "Delets the map file from steam client maps folder.\r\nWill prevent client side file" +
        " mismatch. \r\nMake sure the rust game maps location is set.\r\n\r\nSteam\\steamapps\\co" +
        "mmon\\Rust\\maps\r\n\r\n");
            this.MainToolTip.SetToolTipIcon(this.label21, null);
            this.MainToolTip.SetToolTipTitle(this.label21, "");
            // 
            // CheckDeleteClientMap
            // 
            this.CheckDeleteClientMap.AllowBindingControlAnimation = true;
            this.CheckDeleteClientMap.AllowBindingControlColorChanges = false;
            this.CheckDeleteClientMap.AllowBindingControlLocation = true;
            this.CheckDeleteClientMap.AllowCheckBoxAnimation = false;
            this.CheckDeleteClientMap.AllowCheckmarkAnimation = true;
            this.CheckDeleteClientMap.AllowOnHoverStates = true;
            this.CheckDeleteClientMap.AutoCheck = true;
            this.CheckDeleteClientMap.BackColor = System.Drawing.Color.Transparent;
            this.CheckDeleteClientMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckDeleteClientMap.BackgroundImage")));
            this.CheckDeleteClientMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckDeleteClientMap.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckDeleteClientMap.BorderRadius = 12;
            this.CheckDeleteClientMap.Checked = true;
            this.CheckDeleteClientMap.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.CheckDeleteClientMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckDeleteClientMap.CustomCheckmarkImage = null;
            this.CheckDeleteClientMap.Location = new System.Drawing.Point(219, 31);
            this.CheckDeleteClientMap.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckDeleteClientMap.Name = "CheckDeleteClientMap";
            this.CheckDeleteClientMap.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckDeleteClientMap.OnCheck.BorderRadius = 12;
            this.CheckDeleteClientMap.OnCheck.BorderThickness = 2;
            this.CheckDeleteClientMap.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckDeleteClientMap.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckDeleteClientMap.OnCheck.CheckmarkThickness = 2;
            this.CheckDeleteClientMap.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckDeleteClientMap.OnDisable.BorderRadius = 12;
            this.CheckDeleteClientMap.OnDisable.BorderThickness = 2;
            this.CheckDeleteClientMap.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckDeleteClientMap.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckDeleteClientMap.OnDisable.CheckmarkThickness = 2;
            this.CheckDeleteClientMap.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckDeleteClientMap.OnHoverChecked.BorderRadius = 12;
            this.CheckDeleteClientMap.OnHoverChecked.BorderThickness = 2;
            this.CheckDeleteClientMap.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckDeleteClientMap.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckDeleteClientMap.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckDeleteClientMap.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckDeleteClientMap.OnHoverUnchecked.BorderRadius = 12;
            this.CheckDeleteClientMap.OnHoverUnchecked.BorderThickness = 1;
            this.CheckDeleteClientMap.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckDeleteClientMap.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckDeleteClientMap.OnUncheck.BorderRadius = 12;
            this.CheckDeleteClientMap.OnUncheck.BorderThickness = 1;
            this.CheckDeleteClientMap.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckDeleteClientMap.Size = new System.Drawing.Size(21, 21);
            this.CheckDeleteClientMap.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckDeleteClientMap.TabIndex = 11;
            this.CheckDeleteClientMap.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckDeleteClientMap, "Delets the map file from steam client maps folder.\r\nWill prevent client side file" +
        " mismatch. \r\nMake sure the rust game maps location is set.\r\n\r\nSteam\\steamapps\\co" +
        "mmon\\Rust\\maps\r\n\r\n\r\n");
            this.MainToolTip.SetToolTipIcon(this.CheckDeleteClientMap, null);
            this.CheckDeleteClientMap.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckDeleteClientMap, "");
            this.CheckDeleteClientMap.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.CheckDeleteClientMap_CheckedChanged);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(190, 11);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator2.Size = new System.Drawing.Size(14, 42);
            this.bunifuSeparator2.TabIndex = 13;
            this.MainToolTip.SetToolTip(this.bunifuSeparator2, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator2, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator2, "");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Activate file watcher";
            this.MainToolTip.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.label7, null);
            this.MainToolTip.SetToolTipTitle(this.label7, "");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Show desktop notifications";
            this.MainToolTip.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.label6, null);
            this.MainToolTip.SetToolTipTitle(this.label6, "");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Create a new server folder each boot";
            this.MainToolTip.SetToolTip(this.label4, "Creates a start file with a random identity.\r\nWill prevent Server side map file m" +
        "ismatch. \r\n\r\n");
            this.MainToolTip.SetToolTipIcon(this.label4, null);
            this.MainToolTip.SetToolTipTitle(this.label4, "");
            // 
            // CheckboxFileWatch
            // 
            this.CheckboxFileWatch.AllowBindingControlAnimation = true;
            this.CheckboxFileWatch.AllowBindingControlColorChanges = false;
            this.CheckboxFileWatch.AllowBindingControlLocation = true;
            this.CheckboxFileWatch.AllowCheckBoxAnimation = false;
            this.CheckboxFileWatch.AllowCheckmarkAnimation = true;
            this.CheckboxFileWatch.AllowOnHoverStates = true;
            this.CheckboxFileWatch.AutoCheck = true;
            this.CheckboxFileWatch.BackColor = System.Drawing.Color.Transparent;
            this.CheckboxFileWatch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckboxFileWatch.BackgroundImage")));
            this.CheckboxFileWatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckboxFileWatch.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckboxFileWatch.BorderRadius = 12;
            this.CheckboxFileWatch.Checked = true;
            this.CheckboxFileWatch.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.CheckboxFileWatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckboxFileWatch.CustomCheckmarkImage = null;
            this.CheckboxFileWatch.Location = new System.Drawing.Point(12, 9);
            this.CheckboxFileWatch.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckboxFileWatch.Name = "CheckboxFileWatch";
            this.CheckboxFileWatch.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckboxFileWatch.OnCheck.BorderRadius = 12;
            this.CheckboxFileWatch.OnCheck.BorderThickness = 2;
            this.CheckboxFileWatch.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckboxFileWatch.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckboxFileWatch.OnCheck.CheckmarkThickness = 2;
            this.CheckboxFileWatch.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckboxFileWatch.OnDisable.BorderRadius = 12;
            this.CheckboxFileWatch.OnDisable.BorderThickness = 2;
            this.CheckboxFileWatch.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckboxFileWatch.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckboxFileWatch.OnDisable.CheckmarkThickness = 2;
            this.CheckboxFileWatch.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckboxFileWatch.OnHoverChecked.BorderRadius = 12;
            this.CheckboxFileWatch.OnHoverChecked.BorderThickness = 2;
            this.CheckboxFileWatch.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckboxFileWatch.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckboxFileWatch.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckboxFileWatch.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckboxFileWatch.OnHoverUnchecked.BorderRadius = 12;
            this.CheckboxFileWatch.OnHoverUnchecked.BorderThickness = 1;
            this.CheckboxFileWatch.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckboxFileWatch.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckboxFileWatch.OnUncheck.BorderRadius = 12;
            this.CheckboxFileWatch.OnUncheck.BorderThickness = 1;
            this.CheckboxFileWatch.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckboxFileWatch.Size = new System.Drawing.Size(21, 21);
            this.CheckboxFileWatch.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckboxFileWatch.TabIndex = 8;
            this.CheckboxFileWatch.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckboxFileWatch, resources.GetString("CheckboxFileWatch.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.CheckboxFileWatch, null);
            this.CheckboxFileWatch.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckboxFileWatch, "");
            this.CheckboxFileWatch.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.CheckboxFileWatch_CheckedChanged);
            // 
            // CheckboxDesktopNoti
            // 
            this.CheckboxDesktopNoti.AllowBindingControlAnimation = true;
            this.CheckboxDesktopNoti.AllowBindingControlColorChanges = false;
            this.CheckboxDesktopNoti.AllowBindingControlLocation = true;
            this.CheckboxDesktopNoti.AllowCheckBoxAnimation = false;
            this.CheckboxDesktopNoti.AllowCheckmarkAnimation = true;
            this.CheckboxDesktopNoti.AllowOnHoverStates = true;
            this.CheckboxDesktopNoti.AutoCheck = true;
            this.CheckboxDesktopNoti.BackColor = System.Drawing.Color.Transparent;
            this.CheckboxDesktopNoti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckboxDesktopNoti.BackgroundImage")));
            this.CheckboxDesktopNoti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckboxDesktopNoti.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckboxDesktopNoti.BorderRadius = 12;
            this.CheckboxDesktopNoti.Checked = true;
            this.CheckboxDesktopNoti.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.CheckboxDesktopNoti.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckboxDesktopNoti.CustomCheckmarkImage = null;
            this.CheckboxDesktopNoti.Location = new System.Drawing.Point(12, 31);
            this.CheckboxDesktopNoti.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckboxDesktopNoti.Name = "CheckboxDesktopNoti";
            this.CheckboxDesktopNoti.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckboxDesktopNoti.OnCheck.BorderRadius = 12;
            this.CheckboxDesktopNoti.OnCheck.BorderThickness = 2;
            this.CheckboxDesktopNoti.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckboxDesktopNoti.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckboxDesktopNoti.OnCheck.CheckmarkThickness = 2;
            this.CheckboxDesktopNoti.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckboxDesktopNoti.OnDisable.BorderRadius = 12;
            this.CheckboxDesktopNoti.OnDisable.BorderThickness = 2;
            this.CheckboxDesktopNoti.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckboxDesktopNoti.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckboxDesktopNoti.OnDisable.CheckmarkThickness = 2;
            this.CheckboxDesktopNoti.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckboxDesktopNoti.OnHoverChecked.BorderRadius = 12;
            this.CheckboxDesktopNoti.OnHoverChecked.BorderThickness = 2;
            this.CheckboxDesktopNoti.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckboxDesktopNoti.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckboxDesktopNoti.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckboxDesktopNoti.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckboxDesktopNoti.OnHoverUnchecked.BorderRadius = 12;
            this.CheckboxDesktopNoti.OnHoverUnchecked.BorderThickness = 1;
            this.CheckboxDesktopNoti.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckboxDesktopNoti.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckboxDesktopNoti.OnUncheck.BorderRadius = 12;
            this.CheckboxDesktopNoti.OnUncheck.BorderThickness = 1;
            this.CheckboxDesktopNoti.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckboxDesktopNoti.Size = new System.Drawing.Size(21, 21);
            this.CheckboxDesktopNoti.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckboxDesktopNoti.TabIndex = 9;
            this.CheckboxDesktopNoti.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckboxDesktopNoti, resources.GetString("CheckboxDesktopNoti.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.CheckboxDesktopNoti, null);
            this.CheckboxDesktopNoti.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckboxDesktopNoti, "");
            this.CheckboxDesktopNoti.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.CheckboxDesktopNoti_CheckedChanged);
            // 
            // CheckNewStart
            // 
            this.CheckNewStart.AllowBindingControlAnimation = true;
            this.CheckNewStart.AllowBindingControlColorChanges = false;
            this.CheckNewStart.AllowBindingControlLocation = true;
            this.CheckNewStart.AllowCheckBoxAnimation = false;
            this.CheckNewStart.AllowCheckmarkAnimation = true;
            this.CheckNewStart.AllowOnHoverStates = true;
            this.CheckNewStart.AutoCheck = true;
            this.CheckNewStart.BackColor = System.Drawing.Color.Transparent;
            this.CheckNewStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckNewStart.BackgroundImage")));
            this.CheckNewStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckNewStart.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckNewStart.BorderRadius = 12;
            this.CheckNewStart.Checked = true;
            this.CheckNewStart.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.CheckNewStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckNewStart.CustomCheckmarkImage = null;
            this.CheckNewStart.Location = new System.Drawing.Point(219, 9);
            this.CheckNewStart.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckNewStart.Name = "CheckNewStart";
            this.CheckNewStart.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckNewStart.OnCheck.BorderRadius = 12;
            this.CheckNewStart.OnCheck.BorderThickness = 2;
            this.CheckNewStart.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckNewStart.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckNewStart.OnCheck.CheckmarkThickness = 2;
            this.CheckNewStart.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckNewStart.OnDisable.BorderRadius = 12;
            this.CheckNewStart.OnDisable.BorderThickness = 2;
            this.CheckNewStart.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNewStart.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckNewStart.OnDisable.CheckmarkThickness = 2;
            this.CheckNewStart.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNewStart.OnHoverChecked.BorderRadius = 12;
            this.CheckNewStart.OnHoverChecked.BorderThickness = 2;
            this.CheckNewStart.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNewStart.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckNewStart.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckNewStart.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNewStart.OnHoverUnchecked.BorderRadius = 12;
            this.CheckNewStart.OnHoverUnchecked.BorderThickness = 1;
            this.CheckNewStart.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNewStart.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckNewStart.OnUncheck.BorderRadius = 12;
            this.CheckNewStart.OnUncheck.BorderThickness = 1;
            this.CheckNewStart.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNewStart.Size = new System.Drawing.Size(21, 21);
            this.CheckNewStart.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckNewStart.TabIndex = 10;
            this.CheckNewStart.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckNewStart, "Creates a start file with a random identity.\r\nWill prevent Server side map file m" +
        "ismatch. \r\n");
            this.MainToolTip.SetToolTipIcon(this.CheckNewStart, null);
            this.CheckNewStart.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckNewStart, "");
            this.CheckNewStart.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.CheckNewStart_CheckedChanged);
            // 
            // SettingsDirectoryPanel
            // 
            this.SettingsDirectoryPanel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsDirectoryPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsDirectoryPanel.BorderRadius = 8;
            this.SettingsDirectoryPanel.BorderThickness = 1;
            this.SettingsDirectoryPanel.Controls.Add(this.bunifuGroupBox1);
            this.SettingsDirectoryPanel.Controls.Add(this.ServerFiles);
            this.SettingsDirectoryPanel.Controls.Add(this.DirectoriesLabel);
            this.SettingsDirectoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsDirectoryPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.SettingsDirectoryPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.SettingsDirectoryPanel.Location = new System.Drawing.Point(10, 45);
            this.SettingsDirectoryPanel.Name = "SettingsDirectoryPanel";
            this.SettingsDirectoryPanel.Padding = new System.Windows.Forms.Padding(10);
            this.SettingsDirectoryPanel.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.SettingsDirectoryPanel.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.SettingsDirectoryPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.SettingsDirectoryPanel.ShadowDept = 2;
            this.SettingsDirectoryPanel.ShadowDepth = 5;
            this.SettingsDirectoryPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.SettingsDirectoryPanel.ShadowTopLeftVisible = false;
            this.SettingsDirectoryPanel.Size = new System.Drawing.Size(456, 303);
            this.SettingsDirectoryPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.SettingsDirectoryPanel.TabIndex = 2;
            this.MainToolTip.SetToolTip(this.SettingsDirectoryPanel, "");
            this.MainToolTip.SetToolTipIcon(this.SettingsDirectoryPanel, null);
            this.MainToolTip.SetToolTipTitle(this.SettingsDirectoryPanel, "");
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuGroupBox1.BorderRadius = 8;
            this.bunifuGroupBox1.BorderThickness = 2;
            this.bunifuGroupBox1.Controls.Add(this.RustGameDirbox);
            this.bunifuGroupBox1.Controls.Add(this.label17);
            this.bunifuGroupBox1.Controls.Add(this.bunifuSeparator4);
            this.bunifuGroupBox1.Controls.Add(this.MapDirBox);
            this.bunifuGroupBox1.Controls.Add(this.label2);
            this.bunifuGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(10, 160);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.bunifuGroupBox1.Size = new System.Drawing.Size(436, 133);
            this.bunifuGroupBox1.TabIndex = 21;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Map Features (Optional)";
            this.MainToolTip.SetToolTip(this.bunifuGroupBox1, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuGroupBox1, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuGroupBox1, "");
            // 
            // RustGameDirbox
            // 
            this.RustGameDirbox.AcceptsReturn = false;
            this.RustGameDirbox.AcceptsTab = false;
            this.RustGameDirbox.AnimationSpeed = 200;
            this.RustGameDirbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.RustGameDirbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.RustGameDirbox.AutoSizeHeight = true;
            this.RustGameDirbox.BackColor = System.Drawing.Color.Transparent;
            this.RustGameDirbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RustGameDirbox.BackgroundImage")));
            this.RustGameDirbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.RustGameDirbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RustGameDirbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.RustGameDirbox.BorderColorIdle = System.Drawing.Color.Silver;
            this.RustGameDirbox.BorderRadius = 8;
            this.RustGameDirbox.BorderThickness = 1;
            this.RustGameDirbox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.RustGameDirbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RustGameDirbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RustGameDirbox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RustGameDirbox.DefaultText = "";
            this.RustGameDirbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RustGameDirbox.FillColor = System.Drawing.Color.DimGray;
            this.RustGameDirbox.HideSelection = true;
            this.RustGameDirbox.IconLeft = global::EasyMapTestRust.Properties.Resources._3767084__1_;
            this.RustGameDirbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.RustGameDirbox.IconPadding = 7;
            this.RustGameDirbox.IconRight = null;
            this.RustGameDirbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.RustGameDirbox.Lines = new string[0];
            this.RustGameDirbox.Location = new System.Drawing.Point(5, 87);
            this.RustGameDirbox.MaxLength = 32767;
            this.RustGameDirbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.RustGameDirbox.Modified = false;
            this.RustGameDirbox.Multiline = false;
            this.RustGameDirbox.Name = "RustGameDirbox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RustGameDirbox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.RustGameDirbox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RustGameDirbox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.DimGray;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RustGameDirbox.OnIdleState = stateProperties4;
            this.RustGameDirbox.Padding = new System.Windows.Forms.Padding(3);
            this.RustGameDirbox.PasswordChar = '\0';
            this.RustGameDirbox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.RustGameDirbox.PlaceholderText = "Rust Game Location";
            this.RustGameDirbox.ReadOnly = false;
            this.RustGameDirbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RustGameDirbox.SelectedText = "";
            this.RustGameDirbox.SelectionLength = 0;
            this.RustGameDirbox.SelectionStart = 0;
            this.RustGameDirbox.ShortcutsEnabled = true;
            this.RustGameDirbox.Size = new System.Drawing.Size(426, 39);
            this.RustGameDirbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.RustGameDirbox.TabIndex = 7;
            this.RustGameDirbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RustGameDirbox.TextMarginBottom = 0;
            this.RustGameDirbox.TextMarginLeft = 3;
            this.RustGameDirbox.TextMarginTop = 1;
            this.RustGameDirbox.TextPlaceholder = "Rust Game Location";
            this.MainToolTip.SetToolTip(this.RustGameDirbox, resources.GetString("RustGameDirbox.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.RustGameDirbox, null);
            this.MainToolTip.SetToolTipTitle(this.RustGameDirbox, "");
            this.RustGameDirbox.UseSystemPasswordChar = false;
            this.RustGameDirbox.WordWrap = true;
            this.RustGameDirbox.TextChange += new System.EventHandler(this.RustGameDirbox_TextChange);
            this.RustGameDirbox.OnIconLeftClick += new System.EventHandler(this.RustGameDirbox_OnIconLeftClick);
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(426, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Rust Game Maps Location";
            this.MainToolTip.SetToolTip(this.label17, resources.GetString("label17.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.label17, null);
            this.MainToolTip.SetToolTipTitle(this.label17, "");
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator4.BackgroundImage")));
            this.bunifuSeparator4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator4.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator4.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(5, 68);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator4.Size = new System.Drawing.Size(426, 6);
            this.bunifuSeparator4.TabIndex = 19;
            this.MainToolTip.SetToolTip(this.bunifuSeparator4, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator4, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator4, "");
            // 
            // MapDirBox
            // 
            this.MapDirBox.AcceptsReturn = false;
            this.MapDirBox.AcceptsTab = false;
            this.MapDirBox.AnimationSpeed = 200;
            this.MapDirBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MapDirBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MapDirBox.AutoSizeHeight = true;
            this.MapDirBox.BackColor = System.Drawing.Color.Transparent;
            this.MapDirBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MapDirBox.BackgroundImage")));
            this.MapDirBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.MapDirBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.MapDirBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.MapDirBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.MapDirBox.BorderRadius = 8;
            this.MapDirBox.BorderThickness = 1;
            this.MapDirBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.MapDirBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MapDirBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MapDirBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.MapDirBox.DefaultText = "";
            this.MapDirBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MapDirBox.FillColor = System.Drawing.Color.DimGray;
            this.MapDirBox.HideSelection = true;
            this.MapDirBox.IconLeft = global::EasyMapTestRust.Properties.Resources._3767084__1_;
            this.MapDirBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.MapDirBox.IconPadding = 7;
            this.MapDirBox.IconRight = null;
            this.MapDirBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.MapDirBox.Lines = new string[0];
            this.MapDirBox.Location = new System.Drawing.Point(5, 29);
            this.MapDirBox.MaxLength = 32767;
            this.MapDirBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.MapDirBox.Modified = false;
            this.MapDirBox.Multiline = false;
            this.MapDirBox.Name = "MapDirBox";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.MapDirBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.MapDirBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.MapDirBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.DimGray;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.MapDirBox.OnIdleState = stateProperties8;
            this.MapDirBox.Padding = new System.Windows.Forms.Padding(3);
            this.MapDirBox.PasswordChar = '\0';
            this.MapDirBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.MapDirBox.PlaceholderText = "Maps filewatcher Location";
            this.MapDirBox.ReadOnly = false;
            this.MapDirBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MapDirBox.SelectedText = "";
            this.MapDirBox.SelectionLength = 0;
            this.MapDirBox.SelectionStart = 0;
            this.MapDirBox.ShortcutsEnabled = true;
            this.MapDirBox.Size = new System.Drawing.Size(426, 39);
            this.MapDirBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.MapDirBox.TabIndex = 6;
            this.MapDirBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MapDirBox.TextMarginBottom = 0;
            this.MapDirBox.TextMarginLeft = 3;
            this.MapDirBox.TextMarginTop = 1;
            this.MapDirBox.TextPlaceholder = "Maps filewatcher Location";
            this.MainToolTip.SetToolTip(this.MapDirBox, resources.GetString("MapDirBox.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.MapDirBox, null);
            this.MainToolTip.SetToolTipTitle(this.MapDirBox, "");
            this.MapDirBox.UseSystemPasswordChar = false;
            this.MapDirBox.WordWrap = true;
            this.MapDirBox.TextChange += new System.EventHandler(this.MapDirBox_TextChange);
            this.MapDirBox.OnIconLeftClick += new System.EventHandler(this.MapDirBox_OnIconLeftClick);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Maps Filewatcher Location";
            this.MainToolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.label2, null);
            this.MainToolTip.SetToolTipTitle(this.label2, "");
            // 
            // ServerFiles
            // 
            this.ServerFiles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ServerFiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.ServerFiles.BorderRadius = 8;
            this.ServerFiles.BorderThickness = 2;
            this.ServerFiles.Controls.Add(this.SteamCMDBox);
            this.ServerFiles.Controls.Add(this.label12);
            this.ServerFiles.Controls.Add(this.bunifuSeparator10);
            this.ServerFiles.Controls.Add(this.PanelSaperator2);
            this.ServerFiles.Controls.Add(this.DirectoriesLab);
            this.ServerFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServerFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerFiles.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ServerFiles.LabelIndent = 10;
            this.ServerFiles.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.ServerFiles.Location = new System.Drawing.Point(10, 25);
            this.ServerFiles.Name = "ServerFiles";
            this.ServerFiles.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.ServerFiles.Size = new System.Drawing.Size(436, 135);
            this.ServerFiles.TabIndex = 20;
            this.ServerFiles.TabStop = false;
            this.ServerFiles.Text = "Server Files (Required)";
            this.MainToolTip.SetToolTip(this.ServerFiles, "");
            this.MainToolTip.SetToolTipIcon(this.ServerFiles, null);
            this.MainToolTip.SetToolTipTitle(this.ServerFiles, "");
            // 
            // SteamCMDBox
            // 
            this.SteamCMDBox.AcceptsReturn = false;
            this.SteamCMDBox.AcceptsTab = false;
            this.SteamCMDBox.AnimationSpeed = 200;
            this.SteamCMDBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SteamCMDBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SteamCMDBox.AutoSizeHeight = true;
            this.SteamCMDBox.BackColor = System.Drawing.Color.Transparent;
            this.SteamCMDBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SteamCMDBox.BackgroundImage")));
            this.SteamCMDBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SteamCMDBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SteamCMDBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SteamCMDBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.SteamCMDBox.BorderRadius = 8;
            this.SteamCMDBox.BorderThickness = 1;
            this.SteamCMDBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.SteamCMDBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SteamCMDBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SteamCMDBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.SteamCMDBox.DefaultText = "";
            this.SteamCMDBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SteamCMDBox.FillColor = System.Drawing.Color.DimGray;
            this.SteamCMDBox.HideSelection = true;
            this.SteamCMDBox.IconLeft = global::EasyMapTestRust.Properties.Resources._3767084__1_;
            this.SteamCMDBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SteamCMDBox.IconPadding = 7;
            this.SteamCMDBox.IconRight = null;
            this.SteamCMDBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SteamCMDBox.Lines = new string[0];
            this.SteamCMDBox.Location = new System.Drawing.Point(5, 88);
            this.SteamCMDBox.MaxLength = 32767;
            this.SteamCMDBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.SteamCMDBox.Modified = false;
            this.SteamCMDBox.Multiline = false;
            this.SteamCMDBox.Name = "SteamCMDBox";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SteamCMDBox.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SteamCMDBox.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SteamCMDBox.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.DimGray;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SteamCMDBox.OnIdleState = stateProperties12;
            this.SteamCMDBox.Padding = new System.Windows.Forms.Padding(3);
            this.SteamCMDBox.PasswordChar = '\0';
            this.SteamCMDBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.SteamCMDBox.PlaceholderText = "SteamCMD Location";
            this.SteamCMDBox.ReadOnly = false;
            this.SteamCMDBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SteamCMDBox.SelectedText = "";
            this.SteamCMDBox.SelectionLength = 0;
            this.SteamCMDBox.SelectionStart = 0;
            this.SteamCMDBox.ShortcutsEnabled = true;
            this.SteamCMDBox.Size = new System.Drawing.Size(426, 39);
            this.SteamCMDBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SteamCMDBox.TabIndex = 5;
            this.SteamCMDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SteamCMDBox.TextMarginBottom = 0;
            this.SteamCMDBox.TextMarginLeft = 3;
            this.SteamCMDBox.TextMarginTop = 1;
            this.SteamCMDBox.TextPlaceholder = "SteamCMD Location";
            this.MainToolTip.SetToolTip(this.SteamCMDBox, "This directory is used for the SteamCMD files.\r\n\r\nIf steamCMD is detected nothing" +
        " will be downloaded. \r\n\r\nIf steamCMD is not found, the official steamCMD zip fil" +
        "e will be downloaded and extracted.");
            this.MainToolTip.SetToolTipIcon(this.SteamCMDBox, null);
            this.MainToolTip.SetToolTipTitle(this.SteamCMDBox, "");
            this.SteamCMDBox.UseSystemPasswordChar = false;
            this.SteamCMDBox.WordWrap = true;
            this.SteamCMDBox.TextChange += new System.EventHandler(this.SteamCMDBox_TextChange);
            this.SteamCMDBox.OnIconLeftClick += new System.EventHandler(this.SteamCMDBox_OnIconLeftClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "SteamCMD Location";
            this.MainToolTip.SetToolTip(this.label12, "This directory is used for the SteamCMD files.\r\n\r\nIf steamCMD is detected nothing" +
        " will be downloaded. \r\n\r\nIf steamCMD is not found, the official steamCMD zip fil" +
        "e will be downloaded and extracted.\r\n");
            this.MainToolTip.SetToolTipIcon(this.label12, null);
            this.MainToolTip.SetToolTipTitle(this.label12, "");
            // 
            // bunifuSeparator10
            // 
            this.bunifuSeparator10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator10.BackgroundImage")));
            this.bunifuSeparator10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator10.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator10.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator10.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator10.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator10.LineThickness = 1;
            this.bunifuSeparator10.Location = new System.Drawing.Point(5, 68);
            this.bunifuSeparator10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuSeparator10.Name = "bunifuSeparator10";
            this.bunifuSeparator10.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator10.Size = new System.Drawing.Size(426, 5);
            this.bunifuSeparator10.TabIndex = 14;
            this.MainToolTip.SetToolTip(this.bunifuSeparator10, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator10, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator10, "");
            // 
            // PanelSaperator2
            // 
            this.PanelSaperator2.Controls.Add(this.ServerFilesDirbox);
            this.PanelSaperator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSaperator2.Location = new System.Drawing.Point(5, 29);
            this.PanelSaperator2.Name = "PanelSaperator2";
            this.PanelSaperator2.Padding = new System.Windows.Forms.Padding(3);
            this.PanelSaperator2.Size = new System.Drawing.Size(426, 39);
            this.PanelSaperator2.TabIndex = 4;
            this.MainToolTip.SetToolTip(this.PanelSaperator2, "");
            this.MainToolTip.SetToolTipIcon(this.PanelSaperator2, null);
            this.MainToolTip.SetToolTipTitle(this.PanelSaperator2, "");
            // 
            // ServerFilesDirbox
            // 
            this.ServerFilesDirbox.AcceptsReturn = false;
            this.ServerFilesDirbox.AcceptsTab = false;
            this.ServerFilesDirbox.AnimationSpeed = 200;
            this.ServerFilesDirbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ServerFilesDirbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ServerFilesDirbox.AutoSizeHeight = true;
            this.ServerFilesDirbox.BackColor = System.Drawing.Color.Transparent;
            this.ServerFilesDirbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ServerFilesDirbox.BackgroundImage")));
            this.ServerFilesDirbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.ServerFilesDirbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ServerFilesDirbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ServerFilesDirbox.BorderColorIdle = System.Drawing.Color.Silver;
            this.ServerFilesDirbox.BorderRadius = 8;
            this.ServerFilesDirbox.BorderThickness = 1;
            this.ServerFilesDirbox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.ServerFilesDirbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ServerFilesDirbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerFilesDirbox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ServerFilesDirbox.DefaultText = "";
            this.ServerFilesDirbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerFilesDirbox.FillColor = System.Drawing.Color.DimGray;
            this.ServerFilesDirbox.HideSelection = true;
            this.ServerFilesDirbox.IconLeft = global::EasyMapTestRust.Properties.Resources._3767084__1_;
            this.ServerFilesDirbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerFilesDirbox.IconPadding = 7;
            this.ServerFilesDirbox.IconRight = null;
            this.ServerFilesDirbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerFilesDirbox.Lines = new string[0];
            this.ServerFilesDirbox.Location = new System.Drawing.Point(3, 3);
            this.ServerFilesDirbox.MaxLength = 32767;
            this.ServerFilesDirbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.ServerFilesDirbox.Modified = false;
            this.ServerFilesDirbox.Multiline = false;
            this.ServerFilesDirbox.Name = "ServerFilesDirbox";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ServerFilesDirbox.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.ServerFilesDirbox.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ServerFilesDirbox.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.DimGray;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ServerFilesDirbox.OnIdleState = stateProperties16;
            this.ServerFilesDirbox.Padding = new System.Windows.Forms.Padding(3);
            this.ServerFilesDirbox.PasswordChar = '\0';
            this.ServerFilesDirbox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.ServerFilesDirbox.PlaceholderText = "Server Files Location";
            this.ServerFilesDirbox.ReadOnly = false;
            this.ServerFilesDirbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServerFilesDirbox.SelectedText = "";
            this.ServerFilesDirbox.SelectionLength = 0;
            this.ServerFilesDirbox.SelectionStart = 0;
            this.ServerFilesDirbox.ShortcutsEnabled = true;
            this.ServerFilesDirbox.Size = new System.Drawing.Size(420, 33);
            this.ServerFilesDirbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.ServerFilesDirbox.TabIndex = 4;
            this.ServerFilesDirbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ServerFilesDirbox.TextMarginBottom = 0;
            this.ServerFilesDirbox.TextMarginLeft = 3;
            this.ServerFilesDirbox.TextMarginTop = 1;
            this.ServerFilesDirbox.TextPlaceholder = "Server Files Location";
            this.MainToolTip.SetToolTip(this.ServerFilesDirbox, "This directory is used to download the rust server files too. \r\n\r\nIf server files" +
        " are detected it will update the server. ");
            this.MainToolTip.SetToolTipIcon(this.ServerFilesDirbox, null);
            this.MainToolTip.SetToolTipTitle(this.ServerFilesDirbox, "");
            this.ServerFilesDirbox.UseSystemPasswordChar = false;
            this.ServerFilesDirbox.WordWrap = true;
            this.ServerFilesDirbox.TextChange += new System.EventHandler(this.ServerFilesDirbox_TextChange);
            this.ServerFilesDirbox.OnIconLeftClick += new System.EventHandler(this.ServerFilesDirbox_OnIconLeftClick);
            // 
            // DirectoriesLab
            // 
            this.DirectoriesLab.Dock = System.Windows.Forms.DockStyle.Top;
            this.DirectoriesLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoriesLab.Location = new System.Drawing.Point(5, 16);
            this.DirectoriesLab.Name = "DirectoriesLab";
            this.DirectoriesLab.Size = new System.Drawing.Size(426, 13);
            this.DirectoriesLab.TabIndex = 15;
            this.DirectoriesLab.Text = "Server Files";
            this.MainToolTip.SetToolTip(this.DirectoriesLab, "This directory is used to download the rust server files too. \r\n\r\nIf server files" +
        " are detected it will update the server. \r\n");
            this.MainToolTip.SetToolTipIcon(this.DirectoriesLab, null);
            this.MainToolTip.SetToolTipTitle(this.DirectoriesLab, "");
            // 
            // DirectoriesLabel
            // 
            this.DirectoriesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DirectoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoriesLabel.Location = new System.Drawing.Point(10, 10);
            this.DirectoriesLabel.Name = "DirectoriesLabel";
            this.DirectoriesLabel.Size = new System.Drawing.Size(436, 15);
            this.DirectoriesLabel.TabIndex = 2;
            this.DirectoriesLabel.Text = "Directories";
            this.DirectoriesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MainToolTip.SetToolTip(this.DirectoriesLabel, "");
            this.MainToolTip.SetToolTipIcon(this.DirectoriesLabel, null);
            this.MainToolTip.SetToolTipTitle(this.DirectoriesLabel, "");
            // 
            // SettingsTopPanel
            // 
            this.SettingsTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTopPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsTopPanel.BorderRadius = 8;
            this.SettingsTopPanel.BorderThickness = 1;
            this.SettingsTopPanel.Controls.Add(this.SettingsLabel);
            this.SettingsTopPanel.Controls.Add(this.SaveSettingsButton);
            this.SettingsTopPanel.Controls.Add(this.SettingsBackButton);
            this.SettingsTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsTopPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.SettingsTopPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.SettingsTopPanel.Location = new System.Drawing.Point(10, 5);
            this.SettingsTopPanel.Name = "SettingsTopPanel";
            this.SettingsTopPanel.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.SettingsTopPanel.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.SettingsTopPanel.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.SettingsTopPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.SettingsTopPanel.ShadowDept = 2;
            this.SettingsTopPanel.ShadowDepth = 5;
            this.SettingsTopPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.SettingsTopPanel.ShadowTopLeftVisible = false;
            this.SettingsTopPanel.Size = new System.Drawing.Size(456, 40);
            this.SettingsTopPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.SettingsTopPanel.TabIndex = 0;
            this.MainToolTip.SetToolTip(this.SettingsTopPanel, "");
            this.MainToolTip.SetToolTipIcon(this.SettingsTopPanel, null);
            this.MainToolTip.SetToolTipTitle(this.SettingsTopPanel, "");
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.Location = new System.Drawing.Point(80, 10);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(273, 20);
            this.SettingsLabel.TabIndex = 4;
            this.SettingsLabel.Text = "Settings";
            this.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.SettingsLabel, "");
            this.MainToolTip.SetToolTipIcon(this.SettingsLabel, null);
            this.MainToolTip.SetToolTipTitle(this.SettingsLabel, "");
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.AllowAnimations = true;
            this.SaveSettingsButton.AllowMouseEffects = true;
            this.SaveSettingsButton.AllowToggling = false;
            this.SaveSettingsButton.AnimationSpeed = 200;
            this.SaveSettingsButton.AutoGenerateColors = false;
            this.SaveSettingsButton.AutoRoundBorders = false;
            this.SaveSettingsButton.AutoSizeLeftIcon = true;
            this.SaveSettingsButton.AutoSizeRightIcon = true;
            this.SaveSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveSettingsButton.BackColor1 = System.Drawing.Color.Peru;
            this.SaveSettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveSettingsButton.BackgroundImage")));
            this.SaveSettingsButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SaveSettingsButton.ButtonText = "Run Setup";
            this.SaveSettingsButton.ButtonTextMarginLeft = 0;
            this.SaveSettingsButton.ColorContrastOnClick = 45;
            this.SaveSettingsButton.ColorContrastOnHover = 45;
            this.SaveSettingsButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.SaveSettingsButton.CustomizableEdges = borderEdges4;
            this.SaveSettingsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveSettingsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveSettingsButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveSettingsButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveSettingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveSettingsButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.SaveSettingsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettingsButton.ForeColor = System.Drawing.Color.White;
            this.SaveSettingsButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveSettingsButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SaveSettingsButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SaveSettingsButton.IconMarginLeft = 11;
            this.SaveSettingsButton.IconPadding = 10;
            this.SaveSettingsButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveSettingsButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SaveSettingsButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SaveSettingsButton.IconSize = 25;
            this.SaveSettingsButton.IdleBorderColor = System.Drawing.Color.Peru;
            this.SaveSettingsButton.IdleBorderRadius = 8;
            this.SaveSettingsButton.IdleBorderThickness = 1;
            this.SaveSettingsButton.IdleFillColor = System.Drawing.Color.Peru;
            this.SaveSettingsButton.IdleIconLeftImage = null;
            this.SaveSettingsButton.IdleIconRightImage = null;
            this.SaveSettingsButton.IndicateFocus = false;
            this.SaveSettingsButton.Location = new System.Drawing.Point(353, 10);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveSettingsButton.OnDisabledState.BorderRadius = 8;
            this.SaveSettingsButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SaveSettingsButton.OnDisabledState.BorderThickness = 1;
            this.SaveSettingsButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveSettingsButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveSettingsButton.OnDisabledState.IconLeftImage = null;
            this.SaveSettingsButton.OnDisabledState.IconRightImage = null;
            this.SaveSettingsButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SaveSettingsButton.onHoverState.BorderRadius = 8;
            this.SaveSettingsButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SaveSettingsButton.onHoverState.BorderThickness = 1;
            this.SaveSettingsButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SaveSettingsButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SaveSettingsButton.onHoverState.IconLeftImage = null;
            this.SaveSettingsButton.onHoverState.IconRightImage = null;
            this.SaveSettingsButton.OnIdleState.BorderColor = System.Drawing.Color.Peru;
            this.SaveSettingsButton.OnIdleState.BorderRadius = 8;
            this.SaveSettingsButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SaveSettingsButton.OnIdleState.BorderThickness = 1;
            this.SaveSettingsButton.OnIdleState.FillColor = System.Drawing.Color.Peru;
            this.SaveSettingsButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SaveSettingsButton.OnIdleState.IconLeftImage = null;
            this.SaveSettingsButton.OnIdleState.IconRightImage = null;
            this.SaveSettingsButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveSettingsButton.OnPressedState.BorderRadius = 8;
            this.SaveSettingsButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SaveSettingsButton.OnPressedState.BorderThickness = 1;
            this.SaveSettingsButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveSettingsButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SaveSettingsButton.OnPressedState.IconLeftImage = null;
            this.SaveSettingsButton.OnPressedState.IconRightImage = null;
            this.SaveSettingsButton.Size = new System.Drawing.Size(91, 20);
            this.SaveSettingsButton.TabIndex = 1;
            this.SaveSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveSettingsButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveSettingsButton.TextMarginLeft = 0;
            this.SaveSettingsButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.SaveSettingsButton, "");
            this.MainToolTip.SetToolTipIcon(this.SaveSettingsButton, null);
            this.MainToolTip.SetToolTipTitle(this.SaveSettingsButton, "");
            this.SaveSettingsButton.UseDefaultRadiusAndThickness = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // SettingsBackButton
            // 
            this.SettingsBackButton.AllowAnimations = true;
            this.SettingsBackButton.AllowMouseEffects = true;
            this.SettingsBackButton.AllowToggling = false;
            this.SettingsBackButton.AnimationSpeed = 200;
            this.SettingsBackButton.AutoGenerateColors = false;
            this.SettingsBackButton.AutoRoundBorders = false;
            this.SettingsBackButton.AutoSizeLeftIcon = true;
            this.SettingsBackButton.AutoSizeRightIcon = true;
            this.SettingsBackButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBackButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.SettingsBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsBackButton.BackgroundImage")));
            this.SettingsBackButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SettingsBackButton.ButtonText = "Back";
            this.SettingsBackButton.ButtonTextMarginLeft = 0;
            this.SettingsBackButton.ColorContrastOnClick = 45;
            this.SettingsBackButton.ColorContrastOnHover = 45;
            this.SettingsBackButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.SettingsBackButton.CustomizableEdges = borderEdges5;
            this.SettingsBackButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingsBackButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SettingsBackButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SettingsBackButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SettingsBackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsBackButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.SettingsBackButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBackButton.ForeColor = System.Drawing.Color.White;
            this.SettingsBackButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBackButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SettingsBackButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SettingsBackButton.IconMarginLeft = 11;
            this.SettingsBackButton.IconPadding = 10;
            this.SettingsBackButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsBackButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SettingsBackButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SettingsBackButton.IconSize = 25;
            this.SettingsBackButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SettingsBackButton.IdleBorderRadius = 8;
            this.SettingsBackButton.IdleBorderThickness = 1;
            this.SettingsBackButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SettingsBackButton.IdleIconLeftImage = null;
            this.SettingsBackButton.IdleIconRightImage = null;
            this.SettingsBackButton.IndicateFocus = false;
            this.SettingsBackButton.Location = new System.Drawing.Point(12, 10);
            this.SettingsBackButton.Name = "SettingsBackButton";
            this.SettingsBackButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SettingsBackButton.OnDisabledState.BorderRadius = 8;
            this.SettingsBackButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SettingsBackButton.OnDisabledState.BorderThickness = 1;
            this.SettingsBackButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SettingsBackButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SettingsBackButton.OnDisabledState.IconLeftImage = null;
            this.SettingsBackButton.OnDisabledState.IconRightImage = null;
            this.SettingsBackButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SettingsBackButton.onHoverState.BorderRadius = 8;
            this.SettingsBackButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SettingsBackButton.onHoverState.BorderThickness = 1;
            this.SettingsBackButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SettingsBackButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SettingsBackButton.onHoverState.IconLeftImage = null;
            this.SettingsBackButton.onHoverState.IconRightImage = null;
            this.SettingsBackButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SettingsBackButton.OnIdleState.BorderRadius = 8;
            this.SettingsBackButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SettingsBackButton.OnIdleState.BorderThickness = 1;
            this.SettingsBackButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SettingsBackButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SettingsBackButton.OnIdleState.IconLeftImage = null;
            this.SettingsBackButton.OnIdleState.IconRightImage = null;
            this.SettingsBackButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SettingsBackButton.OnPressedState.BorderRadius = 8;
            this.SettingsBackButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SettingsBackButton.OnPressedState.BorderThickness = 1;
            this.SettingsBackButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SettingsBackButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SettingsBackButton.OnPressedState.IconLeftImage = null;
            this.SettingsBackButton.OnPressedState.IconRightImage = null;
            this.SettingsBackButton.Size = new System.Drawing.Size(68, 20);
            this.SettingsBackButton.TabIndex = 0;
            this.SettingsBackButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsBackButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SettingsBackButton.TextMarginLeft = 0;
            this.SettingsBackButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.SettingsBackButton, "");
            this.MainToolTip.SetToolTipIcon(this.SettingsBackButton, null);
            this.MainToolTip.SetToolTipTitle(this.SettingsBackButton, "");
            this.SettingsBackButton.UseDefaultRadiusAndThickness = true;
            this.SettingsBackButton.Click += new System.EventHandler(this.SettingsBackButton_Click);
            // 
            // SetupDirsPage
            // 
            this.SetupDirsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SetupDirsPage.Controls.Add(this.SetupMapsGroup);
            this.SetupDirsPage.Controls.Add(this.panel6);
            this.SetupDirsPage.Controls.Add(this.SetupServerFilesGroup);
            this.SetupDirsPage.Controls.Add(this.panel1);
            this.SetupDirsPage.Controls.Add(this.panel3);
            this.SetupDirsPage.Controls.Add(this.label10);
            this.SetupDirsPage.Controls.Add(this.bunifuShadowPanel3);
            this.SetupDirsPage.Location = new System.Drawing.Point(4, 4);
            this.SetupDirsPage.Name = "SetupDirsPage";
            this.SetupDirsPage.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.SetupDirsPage.Size = new System.Drawing.Size(476, 440);
            this.SetupDirsPage.TabIndex = 2;
            this.SetupDirsPage.Text = "SetupDirs";
            this.MainToolTip.SetToolTip(this.SetupDirsPage, "");
            this.MainToolTip.SetToolTipIcon(this.SetupDirsPage, null);
            this.MainToolTip.SetToolTipTitle(this.SetupDirsPage, "");
            // 
            // SetupMapsGroup
            // 
            this.SetupMapsGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.SetupMapsGroup.BorderRadius = 8;
            this.SetupMapsGroup.BorderThickness = 2;
            this.SetupMapsGroup.Controls.Add(this.SetupRustGameDirbox);
            this.SetupMapsGroup.Controls.Add(this.label11);
            this.SetupMapsGroup.Controls.Add(this.bunifuSeparator11);
            this.SetupMapsGroup.Controls.Add(this.SetupMapsDirectory);
            this.SetupMapsGroup.Controls.Add(this.label1);
            this.SetupMapsGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetupMapsGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupMapsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.SetupMapsGroup.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SetupMapsGroup.LabelIndent = 10;
            this.SetupMapsGroup.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.SetupMapsGroup.Location = new System.Drawing.Point(10, 283);
            this.SetupMapsGroup.Name = "SetupMapsGroup";
            this.SetupMapsGroup.Padding = new System.Windows.Forms.Padding(5);
            this.SetupMapsGroup.Size = new System.Drawing.Size(456, 144);
            this.SetupMapsGroup.TabIndex = 25;
            this.SetupMapsGroup.TabStop = false;
            this.SetupMapsGroup.Text = "Map Features (Optional)";
            this.MainToolTip.SetToolTip(this.SetupMapsGroup, "");
            this.MainToolTip.SetToolTipIcon(this.SetupMapsGroup, null);
            this.MainToolTip.SetToolTipTitle(this.SetupMapsGroup, "");
            // 
            // SetupRustGameDirbox
            // 
            this.SetupRustGameDirbox.AcceptsReturn = false;
            this.SetupRustGameDirbox.AcceptsTab = false;
            this.SetupRustGameDirbox.AnimationSpeed = 200;
            this.SetupRustGameDirbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SetupRustGameDirbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SetupRustGameDirbox.AutoSizeHeight = true;
            this.SetupRustGameDirbox.BackColor = System.Drawing.Color.Transparent;
            this.SetupRustGameDirbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetupRustGameDirbox.BackgroundImage")));
            this.SetupRustGameDirbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SetupRustGameDirbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupRustGameDirbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupRustGameDirbox.BorderColorIdle = System.Drawing.Color.Silver;
            this.SetupRustGameDirbox.BorderRadius = 8;
            this.SetupRustGameDirbox.BorderThickness = 1;
            this.SetupRustGameDirbox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.SetupRustGameDirbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SetupRustGameDirbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupRustGameDirbox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.SetupRustGameDirbox.DefaultText = "";
            this.SetupRustGameDirbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetupRustGameDirbox.FillColor = System.Drawing.Color.DimGray;
            this.SetupRustGameDirbox.ForeColor = System.Drawing.Color.Black;
            this.SetupRustGameDirbox.HideSelection = true;
            this.SetupRustGameDirbox.IconLeft = global::EasyMapTestRust.Properties.Resources._3767084__1_;
            this.SetupRustGameDirbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupRustGameDirbox.IconPadding = 10;
            this.SetupRustGameDirbox.IconRight = null;
            this.SetupRustGameDirbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupRustGameDirbox.Lines = new string[0];
            this.SetupRustGameDirbox.Location = new System.Drawing.Point(5, 98);
            this.SetupRustGameDirbox.MaxLength = 32767;
            this.SetupRustGameDirbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.SetupRustGameDirbox.Modified = false;
            this.SetupRustGameDirbox.Multiline = false;
            this.SetupRustGameDirbox.Name = "SetupRustGameDirbox";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupRustGameDirbox.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SetupRustGameDirbox.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupRustGameDirbox.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.DimGray;
            stateProperties20.ForeColor = System.Drawing.Color.Black;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupRustGameDirbox.OnIdleState = stateProperties20;
            this.SetupRustGameDirbox.Padding = new System.Windows.Forms.Padding(3);
            this.SetupRustGameDirbox.PasswordChar = '\0';
            this.SetupRustGameDirbox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.SetupRustGameDirbox.PlaceholderText = "Rust Game Location (Optional)";
            this.SetupRustGameDirbox.ReadOnly = false;
            this.SetupRustGameDirbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SetupRustGameDirbox.SelectedText = "";
            this.SetupRustGameDirbox.SelectionLength = 0;
            this.SetupRustGameDirbox.SelectionStart = 0;
            this.SetupRustGameDirbox.ShortcutsEnabled = true;
            this.SetupRustGameDirbox.Size = new System.Drawing.Size(446, 39);
            this.SetupRustGameDirbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SetupRustGameDirbox.TabIndex = 21;
            this.SetupRustGameDirbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SetupRustGameDirbox.TextMarginBottom = 0;
            this.SetupRustGameDirbox.TextMarginLeft = 3;
            this.SetupRustGameDirbox.TextMarginTop = 1;
            this.SetupRustGameDirbox.TextPlaceholder = "Rust Game Location (Optional)";
            this.MainToolTip.SetToolTip(this.SetupRustGameDirbox, resources.GetString("SetupRustGameDirbox.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.SetupRustGameDirbox, null);
            this.MainToolTip.SetToolTipTitle(this.SetupRustGameDirbox, "");
            this.SetupRustGameDirbox.UseSystemPasswordChar = false;
            this.SetupRustGameDirbox.WordWrap = true;
            this.SetupRustGameDirbox.OnIconLeftClick += new System.EventHandler(this.SetupRustGameDirbox_OnIconLeftClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label11.Location = new System.Drawing.Point(5, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Rust Game Maps Location (Optional)";
            this.MainToolTip.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.label11, null);
            this.MainToolTip.SetToolTipTitle(this.label11, "");
            // 
            // bunifuSeparator11
            // 
            this.bunifuSeparator11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator11.BackgroundImage")));
            this.bunifuSeparator11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator11.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator11.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator11.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator11.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator11.LineThickness = 1;
            this.bunifuSeparator11.Location = new System.Drawing.Point(5, 73);
            this.bunifuSeparator11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuSeparator11.Name = "bunifuSeparator11";
            this.bunifuSeparator11.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator11.Size = new System.Drawing.Size(446, 12);
            this.bunifuSeparator11.TabIndex = 23;
            this.MainToolTip.SetToolTip(this.bunifuSeparator11, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator11, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator11, "");
            // 
            // SetupMapsDirectory
            // 
            this.SetupMapsDirectory.AcceptsReturn = false;
            this.SetupMapsDirectory.AcceptsTab = false;
            this.SetupMapsDirectory.AnimationSpeed = 200;
            this.SetupMapsDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SetupMapsDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SetupMapsDirectory.AutoSizeHeight = true;
            this.SetupMapsDirectory.BackColor = System.Drawing.Color.Transparent;
            this.SetupMapsDirectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetupMapsDirectory.BackgroundImage")));
            this.SetupMapsDirectory.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SetupMapsDirectory.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupMapsDirectory.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupMapsDirectory.BorderColorIdle = System.Drawing.Color.Silver;
            this.SetupMapsDirectory.BorderRadius = 8;
            this.SetupMapsDirectory.BorderThickness = 1;
            this.SetupMapsDirectory.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.SetupMapsDirectory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SetupMapsDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupMapsDirectory.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.SetupMapsDirectory.DefaultText = "";
            this.SetupMapsDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetupMapsDirectory.FillColor = System.Drawing.Color.DimGray;
            this.SetupMapsDirectory.ForeColor = System.Drawing.Color.Black;
            this.SetupMapsDirectory.HideSelection = true;
            this.SetupMapsDirectory.IconLeft = global::EasyMapTestRust.Properties.Resources._3767084__1_;
            this.SetupMapsDirectory.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupMapsDirectory.IconPadding = 10;
            this.SetupMapsDirectory.IconRight = null;
            this.SetupMapsDirectory.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupMapsDirectory.Lines = new string[0];
            this.SetupMapsDirectory.Location = new System.Drawing.Point(5, 34);
            this.SetupMapsDirectory.MaxLength = 32767;
            this.SetupMapsDirectory.MinimumSize = new System.Drawing.Size(1, 1);
            this.SetupMapsDirectory.Modified = false;
            this.SetupMapsDirectory.Multiline = false;
            this.SetupMapsDirectory.Name = "SetupMapsDirectory";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupMapsDirectory.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SetupMapsDirectory.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupMapsDirectory.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.DimGray;
            stateProperties24.ForeColor = System.Drawing.Color.Black;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupMapsDirectory.OnIdleState = stateProperties24;
            this.SetupMapsDirectory.Padding = new System.Windows.Forms.Padding(3);
            this.SetupMapsDirectory.PasswordChar = '\0';
            this.SetupMapsDirectory.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.SetupMapsDirectory.PlaceholderText = "Maps In Progress Location";
            this.SetupMapsDirectory.ReadOnly = false;
            this.SetupMapsDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SetupMapsDirectory.SelectedText = "";
            this.SetupMapsDirectory.SelectionLength = 0;
            this.SetupMapsDirectory.SelectionStart = 0;
            this.SetupMapsDirectory.ShortcutsEnabled = true;
            this.SetupMapsDirectory.Size = new System.Drawing.Size(446, 39);
            this.SetupMapsDirectory.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SetupMapsDirectory.TabIndex = 4;
            this.SetupMapsDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SetupMapsDirectory.TextMarginBottom = 0;
            this.SetupMapsDirectory.TextMarginLeft = 3;
            this.SetupMapsDirectory.TextMarginTop = 1;
            this.SetupMapsDirectory.TextPlaceholder = "Maps In Progress Location";
            this.MainToolTip.SetToolTip(this.SetupMapsDirectory, resources.GetString("SetupMapsDirectory.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.SetupMapsDirectory, null);
            this.MainToolTip.SetToolTipTitle(this.SetupMapsDirectory, "");
            this.SetupMapsDirectory.UseSystemPasswordChar = false;
            this.SetupMapsDirectory.WordWrap = true;
            this.SetupMapsDirectory.TextChanged += new System.EventHandler(this.SetupMapsDirectory_TextChanged);
            this.SetupMapsDirectory.OnIconLeftClick += new System.EventHandler(this.SetupMapsDirectory_OnIconLeftClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Maps In Progress Location (Optional)";
            this.MainToolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.label1, null);
            this.MainToolTip.SetToolTipTitle(this.label1, "");
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 266);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(456, 17);
            this.panel6.TabIndex = 26;
            this.MainToolTip.SetToolTip(this.panel6, "");
            this.MainToolTip.SetToolTipIcon(this.panel6, null);
            this.MainToolTip.SetToolTipTitle(this.panel6, "");
            // 
            // SetupServerFilesGroup
            // 
            this.SetupServerFilesGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.SetupServerFilesGroup.BorderRadius = 8;
            this.SetupServerFilesGroup.BorderThickness = 2;
            this.SetupServerFilesGroup.Controls.Add(this.SetupCMDdir);
            this.SetupServerFilesGroup.Controls.Add(this.label9);
            this.SetupServerFilesGroup.Controls.Add(this.bunifuSeparator5);
            this.SetupServerFilesGroup.Controls.Add(this.panel2);
            this.SetupServerFilesGroup.Controls.Add(this.label8);
            this.SetupServerFilesGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetupServerFilesGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupServerFilesGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.SetupServerFilesGroup.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SetupServerFilesGroup.LabelIndent = 10;
            this.SetupServerFilesGroup.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.SetupServerFilesGroup.Location = new System.Drawing.Point(10, 116);
            this.SetupServerFilesGroup.Name = "SetupServerFilesGroup";
            this.SetupServerFilesGroup.Padding = new System.Windows.Forms.Padding(5);
            this.SetupServerFilesGroup.Size = new System.Drawing.Size(456, 150);
            this.SetupServerFilesGroup.TabIndex = 24;
            this.SetupServerFilesGroup.TabStop = false;
            this.SetupServerFilesGroup.Text = "Server Files (Required)";
            this.MainToolTip.SetToolTip(this.SetupServerFilesGroup, "");
            this.MainToolTip.SetToolTipIcon(this.SetupServerFilesGroup, null);
            this.MainToolTip.SetToolTipTitle(this.SetupServerFilesGroup, "");
            // 
            // SetupCMDdir
            // 
            this.SetupCMDdir.AcceptsReturn = false;
            this.SetupCMDdir.AcceptsTab = false;
            this.SetupCMDdir.AnimationSpeed = 200;
            this.SetupCMDdir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SetupCMDdir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SetupCMDdir.AutoSizeHeight = true;
            this.SetupCMDdir.BackColor = System.Drawing.Color.Transparent;
            this.SetupCMDdir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetupCMDdir.BackgroundImage")));
            this.SetupCMDdir.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SetupCMDdir.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupCMDdir.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupCMDdir.BorderColorIdle = System.Drawing.Color.Silver;
            this.SetupCMDdir.BorderRadius = 8;
            this.SetupCMDdir.BorderThickness = 1;
            this.SetupCMDdir.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.SetupCMDdir.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SetupCMDdir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupCMDdir.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.SetupCMDdir.DefaultText = "";
            this.SetupCMDdir.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetupCMDdir.FillColor = System.Drawing.Color.DimGray;
            this.SetupCMDdir.ForeColor = System.Drawing.Color.Black;
            this.SetupCMDdir.HideSelection = true;
            this.SetupCMDdir.IconLeft = global::EasyMapTestRust.Properties.Resources._3767084__1_;
            this.SetupCMDdir.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupCMDdir.IconPadding = 10;
            this.SetupCMDdir.IconRight = null;
            this.SetupCMDdir.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupCMDdir.Lines = new string[0];
            this.SetupCMDdir.Location = new System.Drawing.Point(5, 104);
            this.SetupCMDdir.MaxLength = 32767;
            this.SetupCMDdir.MinimumSize = new System.Drawing.Size(1, 1);
            this.SetupCMDdir.Modified = false;
            this.SetupCMDdir.Multiline = false;
            this.SetupCMDdir.Name = "SetupCMDdir";
            stateProperties25.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties25.FillColor = System.Drawing.Color.Empty;
            stateProperties25.ForeColor = System.Drawing.Color.Empty;
            stateProperties25.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupCMDdir.OnActiveState = stateProperties25;
            stateProperties26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties26.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SetupCMDdir.OnDisabledState = stateProperties26;
            stateProperties27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties27.FillColor = System.Drawing.Color.Empty;
            stateProperties27.ForeColor = System.Drawing.Color.Empty;
            stateProperties27.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupCMDdir.OnHoverState = stateProperties27;
            stateProperties28.BorderColor = System.Drawing.Color.Silver;
            stateProperties28.FillColor = System.Drawing.Color.DimGray;
            stateProperties28.ForeColor = System.Drawing.Color.Black;
            stateProperties28.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupCMDdir.OnIdleState = stateProperties28;
            this.SetupCMDdir.Padding = new System.Windows.Forms.Padding(3);
            this.SetupCMDdir.PasswordChar = '\0';
            this.SetupCMDdir.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.SetupCMDdir.PlaceholderText = "SteamCMD Location";
            this.SetupCMDdir.ReadOnly = false;
            this.SetupCMDdir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SetupCMDdir.SelectedText = "";
            this.SetupCMDdir.SelectionLength = 0;
            this.SetupCMDdir.SelectionStart = 0;
            this.SetupCMDdir.ShortcutsEnabled = true;
            this.SetupCMDdir.Size = new System.Drawing.Size(446, 39);
            this.SetupCMDdir.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SetupCMDdir.TabIndex = 9;
            this.SetupCMDdir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SetupCMDdir.TextMarginBottom = 0;
            this.SetupCMDdir.TextMarginLeft = 3;
            this.SetupCMDdir.TextMarginTop = 1;
            this.SetupCMDdir.TextPlaceholder = "SteamCMD Location";
            this.MainToolTip.SetToolTip(this.SetupCMDdir, resources.GetString("SetupCMDdir.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.SetupCMDdir, null);
            this.MainToolTip.SetToolTipTitle(this.SetupCMDdir, "");
            this.SetupCMDdir.UseSystemPasswordChar = false;
            this.SetupCMDdir.WordWrap = true;
            this.SetupCMDdir.TextChanged += new System.EventHandler(this.SetupCMDdir_TextChanged);
            this.SetupCMDdir.OnIconLeftClick += new System.EventHandler(this.SetupCMDdir_OnIconLeftClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label9.Location = new System.Drawing.Point(5, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "SteamCMD Location";
            this.MainToolTip.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.label9, null);
            this.MainToolTip.SetToolTipTitle(this.label9, "");
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator5.BackgroundImage")));
            this.bunifuSeparator5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator5.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator5.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(5, 81);
            this.bunifuSeparator5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator5.Size = new System.Drawing.Size(446, 10);
            this.bunifuSeparator5.TabIndex = 8;
            this.MainToolTip.SetToolTip(this.bunifuSeparator5, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator5, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator5, "");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SetupServerTextbox);
            this.panel2.Controls.Add(this.DropDownBranches);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 34);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(446, 47);
            this.panel2.TabIndex = 19;
            this.MainToolTip.SetToolTip(this.panel2, "");
            this.MainToolTip.SetToolTipIcon(this.panel2, null);
            this.MainToolTip.SetToolTipTitle(this.panel2, "");
            // 
            // SetupServerTextbox
            // 
            this.SetupServerTextbox.AcceptsReturn = false;
            this.SetupServerTextbox.AcceptsTab = false;
            this.SetupServerTextbox.AnimationSpeed = 200;
            this.SetupServerTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SetupServerTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SetupServerTextbox.AutoSizeHeight = true;
            this.SetupServerTextbox.BackColor = System.Drawing.Color.Transparent;
            this.SetupServerTextbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetupServerTextbox.BackgroundImage")));
            this.SetupServerTextbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SetupServerTextbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupServerTextbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupServerTextbox.BorderColorIdle = System.Drawing.Color.Silver;
            this.SetupServerTextbox.BorderRadius = 8;
            this.SetupServerTextbox.BorderThickness = 1;
            this.SetupServerTextbox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.SetupServerTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SetupServerTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupServerTextbox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.SetupServerTextbox.DefaultText = "";
            this.SetupServerTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetupServerTextbox.FillColor = System.Drawing.Color.DimGray;
            this.SetupServerTextbox.ForeColor = System.Drawing.Color.Black;
            this.SetupServerTextbox.HideSelection = true;
            this.SetupServerTextbox.IconLeft = global::EasyMapTestRust.Properties.Resources._3767084__1_;
            this.SetupServerTextbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupServerTextbox.IconPadding = 10;
            this.SetupServerTextbox.IconRight = null;
            this.SetupServerTextbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SetupServerTextbox.Lines = new string[0];
            this.SetupServerTextbox.Location = new System.Drawing.Point(85, 5);
            this.SetupServerTextbox.MaxLength = 32767;
            this.SetupServerTextbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.SetupServerTextbox.Modified = false;
            this.SetupServerTextbox.Multiline = false;
            this.SetupServerTextbox.Name = "SetupServerTextbox";
            stateProperties29.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties29.FillColor = System.Drawing.Color.Empty;
            stateProperties29.ForeColor = System.Drawing.Color.Empty;
            stateProperties29.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupServerTextbox.OnActiveState = stateProperties29;
            stateProperties30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties30.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SetupServerTextbox.OnDisabledState = stateProperties30;
            stateProperties31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties31.FillColor = System.Drawing.Color.Empty;
            stateProperties31.ForeColor = System.Drawing.Color.Empty;
            stateProperties31.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupServerTextbox.OnHoverState = stateProperties31;
            stateProperties32.BorderColor = System.Drawing.Color.Silver;
            stateProperties32.FillColor = System.Drawing.Color.DimGray;
            stateProperties32.ForeColor = System.Drawing.Color.Black;
            stateProperties32.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SetupServerTextbox.OnIdleState = stateProperties32;
            this.SetupServerTextbox.Padding = new System.Windows.Forms.Padding(3);
            this.SetupServerTextbox.PasswordChar = '\0';
            this.SetupServerTextbox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.SetupServerTextbox.PlaceholderText = "Server Files Location";
            this.SetupServerTextbox.ReadOnly = false;
            this.SetupServerTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SetupServerTextbox.SelectedText = "";
            this.SetupServerTextbox.SelectionLength = 0;
            this.SetupServerTextbox.SelectionStart = 0;
            this.SetupServerTextbox.ShortcutsEnabled = true;
            this.SetupServerTextbox.Size = new System.Drawing.Size(356, 37);
            this.SetupServerTextbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SetupServerTextbox.TabIndex = 0;
            this.SetupServerTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SetupServerTextbox.TextMarginBottom = 0;
            this.SetupServerTextbox.TextMarginLeft = 3;
            this.SetupServerTextbox.TextMarginTop = 1;
            this.SetupServerTextbox.TextPlaceholder = "Server Files Location";
            this.MainToolTip.SetToolTip(this.SetupServerTextbox, "This directory is used to download the rust server files too. \r\n\r\nIf server files" +
        " are detected it will update the server. \r\n");
            this.MainToolTip.SetToolTipIcon(this.SetupServerTextbox, null);
            this.MainToolTip.SetToolTipTitle(this.SetupServerTextbox, "");
            this.SetupServerTextbox.UseSystemPasswordChar = false;
            this.SetupServerTextbox.WordWrap = true;
            this.SetupServerTextbox.TextChange += new System.EventHandler(this.SetupServerTextbox_TextChange);
            this.SetupServerTextbox.OnIconLeftClick += new System.EventHandler(this.SetupServerTextbox_OnIconLeftClick);
            // 
            // DropDownBranches
            // 
            this.DropDownBranches.BackColor = System.Drawing.Color.Transparent;
            this.DropDownBranches.BackgroundColor = System.Drawing.Color.DimGray;
            this.DropDownBranches.BorderColor = System.Drawing.Color.Silver;
            this.DropDownBranches.BorderRadius = 8;
            this.DropDownBranches.Color = System.Drawing.Color.Silver;
            this.DropDownBranches.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DropDownBranches.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownBranches.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DropDownBranches.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownBranches.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DropDownBranches.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DropDownBranches.Dock = System.Windows.Forms.DockStyle.Left;
            this.DropDownBranches.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownBranches.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DropDownBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownBranches.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownBranches.FillDropDown = true;
            this.DropDownBranches.FillIndicator = false;
            this.DropDownBranches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropDownBranches.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DropDownBranches.ForeColor = System.Drawing.Color.Black;
            this.DropDownBranches.FormattingEnabled = true;
            this.DropDownBranches.Icon = null;
            this.DropDownBranches.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownBranches.IndicatorColor = System.Drawing.Color.DarkGray;
            this.DropDownBranches.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownBranches.IndicatorThickness = 2;
            this.DropDownBranches.IsDropdownOpened = false;
            this.DropDownBranches.ItemBackColor = System.Drawing.Color.White;
            this.DropDownBranches.ItemBorderColor = System.Drawing.Color.White;
            this.DropDownBranches.ItemForeColor = System.Drawing.Color.Black;
            this.DropDownBranches.ItemHeight = 26;
            this.DropDownBranches.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DropDownBranches.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DropDownBranches.Items.AddRange(new object[] {
            "Main",
            "Staging",
            "Aux02",
            "Aux03"});
            this.DropDownBranches.ItemTopMargin = 3;
            this.DropDownBranches.Location = new System.Drawing.Point(5, 5);
            this.DropDownBranches.Name = "DropDownBranches";
            this.DropDownBranches.Size = new System.Drawing.Size(80, 32);
            this.DropDownBranches.TabIndex = 18;
            this.DropDownBranches.Text = null;
            this.DropDownBranches.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownBranches.TextLeftMargin = 5;
            this.MainToolTip.SetToolTip(this.DropDownBranches, "Choose a branch from the dropdown.\r\n\r\nThe main branch - Normal server files\r\nAux0" +
        "2 - Updated files before they hit the main branch\r\nAux03 - Known used branch (re" +
        "quires password)");
            this.MainToolTip.SetToolTipIcon(this.DropDownBranches, null);
            this.MainToolTip.SetToolTipTitle(this.DropDownBranches, "");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label8.Location = new System.Drawing.Point(5, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rust server files location";
            this.MainToolTip.SetToolTip(this.label8, "This directory is used to download the rust server files too. \r\n\r\nIf server files" +
        " are detected it will update the server. \r\n");
            this.MainToolTip.SetToolTipIcon(this.label8, null);
            this.MainToolTip.SetToolTipTitle(this.label8, "");
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 33);
            this.panel1.TabIndex = 19;
            this.MainToolTip.SetToolTip(this.panel1, "");
            this.MainToolTip.SetToolTipIcon(this.panel1, null);
            this.MainToolTip.SetToolTipTitle(this.panel1, "");
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 28);
            this.panel3.TabIndex = 20;
            this.MainToolTip.SetToolTip(this.panel3, "");
            this.MainToolTip.SetToolTipIcon(this.panel3, null);
            this.MainToolTip.SetToolTipTitle(this.panel3, "");
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label10.Location = new System.Drawing.Point(10, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(456, 43);
            this.label10.TabIndex = 7;
            this.label10.Text = "Select the preferred directories below.\r\nClick the folder icon to browse.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.label10, "");
            this.MainToolTip.SetToolTipIcon(this.label10, null);
            this.MainToolTip.SetToolTipTitle(this.label10, "");
            // 
            // bunifuShadowPanel3
            // 
            this.bunifuShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel3.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel3.BorderRadius = 8;
            this.bunifuShadowPanel3.BorderThickness = 1;
            this.bunifuShadowPanel3.Controls.Add(this.label20);
            this.bunifuShadowPanel3.Controls.Add(this.SetupDirBackButton);
            this.bunifuShadowPanel3.Controls.Add(this.SetupDirNextButton);
            this.bunifuShadowPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel3.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel3.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel3.Location = new System.Drawing.Point(10, 5);
            this.bunifuShadowPanel3.Name = "bunifuShadowPanel3";
            this.bunifuShadowPanel3.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.bunifuShadowPanel3.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel3.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel3.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel3.ShadowDept = 2;
            this.bunifuShadowPanel3.ShadowDepth = 5;
            this.bunifuShadowPanel3.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel3.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel3.Size = new System.Drawing.Size(456, 40);
            this.bunifuShadowPanel3.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel3.TabIndex = 12;
            this.MainToolTip.SetToolTip(this.bunifuShadowPanel3, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuShadowPanel3, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuShadowPanel3, "");
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(80, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(273, 20);
            this.label20.TabIndex = 5;
            this.label20.Text = "Setup";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.label20, "");
            this.MainToolTip.SetToolTipIcon(this.label20, null);
            this.MainToolTip.SetToolTipTitle(this.label20, "");
            // 
            // SetupDirBackButton
            // 
            this.SetupDirBackButton.AllowAnimations = true;
            this.SetupDirBackButton.AllowMouseEffects = true;
            this.SetupDirBackButton.AllowToggling = false;
            this.SetupDirBackButton.AnimationSpeed = 200;
            this.SetupDirBackButton.AutoGenerateColors = false;
            this.SetupDirBackButton.AutoRoundBorders = false;
            this.SetupDirBackButton.AutoSizeLeftIcon = true;
            this.SetupDirBackButton.AutoSizeRightIcon = true;
            this.SetupDirBackButton.BackColor = System.Drawing.Color.Transparent;
            this.SetupDirBackButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.SetupDirBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetupDirBackButton.BackgroundImage")));
            this.SetupDirBackButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupDirBackButton.ButtonText = "Back";
            this.SetupDirBackButton.ButtonTextMarginLeft = 0;
            this.SetupDirBackButton.ColorContrastOnClick = 45;
            this.SetupDirBackButton.ColorContrastOnHover = 45;
            this.SetupDirBackButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.SetupDirBackButton.CustomizableEdges = borderEdges6;
            this.SetupDirBackButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SetupDirBackButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SetupDirBackButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupDirBackButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SetupDirBackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SetupDirBackButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.SetupDirBackButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupDirBackButton.ForeColor = System.Drawing.Color.White;
            this.SetupDirBackButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetupDirBackButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SetupDirBackButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SetupDirBackButton.IconMarginLeft = 11;
            this.SetupDirBackButton.IconPadding = 10;
            this.SetupDirBackButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SetupDirBackButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SetupDirBackButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SetupDirBackButton.IconSize = 25;
            this.SetupDirBackButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SetupDirBackButton.IdleBorderRadius = 8;
            this.SetupDirBackButton.IdleBorderThickness = 1;
            this.SetupDirBackButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SetupDirBackButton.IdleIconLeftImage = null;
            this.SetupDirBackButton.IdleIconRightImage = null;
            this.SetupDirBackButton.IndicateFocus = false;
            this.SetupDirBackButton.Location = new System.Drawing.Point(12, 10);
            this.SetupDirBackButton.Name = "SetupDirBackButton";
            this.SetupDirBackButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SetupDirBackButton.OnDisabledState.BorderRadius = 8;
            this.SetupDirBackButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupDirBackButton.OnDisabledState.BorderThickness = 1;
            this.SetupDirBackButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupDirBackButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SetupDirBackButton.OnDisabledState.IconLeftImage = null;
            this.SetupDirBackButton.OnDisabledState.IconRightImage = null;
            this.SetupDirBackButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupDirBackButton.onHoverState.BorderRadius = 8;
            this.SetupDirBackButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupDirBackButton.onHoverState.BorderThickness = 1;
            this.SetupDirBackButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupDirBackButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SetupDirBackButton.onHoverState.IconLeftImage = null;
            this.SetupDirBackButton.onHoverState.IconRightImage = null;
            this.SetupDirBackButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SetupDirBackButton.OnIdleState.BorderRadius = 8;
            this.SetupDirBackButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupDirBackButton.OnIdleState.BorderThickness = 1;
            this.SetupDirBackButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SetupDirBackButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SetupDirBackButton.OnIdleState.IconLeftImage = null;
            this.SetupDirBackButton.OnIdleState.IconRightImage = null;
            this.SetupDirBackButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SetupDirBackButton.OnPressedState.BorderRadius = 8;
            this.SetupDirBackButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupDirBackButton.OnPressedState.BorderThickness = 1;
            this.SetupDirBackButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SetupDirBackButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SetupDirBackButton.OnPressedState.IconLeftImage = null;
            this.SetupDirBackButton.OnPressedState.IconRightImage = null;
            this.SetupDirBackButton.Size = new System.Drawing.Size(68, 20);
            this.SetupDirBackButton.TabIndex = 0;
            this.SetupDirBackButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SetupDirBackButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetupDirBackButton.TextMarginLeft = 0;
            this.SetupDirBackButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.SetupDirBackButton, "");
            this.MainToolTip.SetToolTipIcon(this.SetupDirBackButton, null);
            this.MainToolTip.SetToolTipTitle(this.SetupDirBackButton, "");
            this.SetupDirBackButton.UseDefaultRadiusAndThickness = true;
            this.SetupDirBackButton.Click += new System.EventHandler(this.SetupDirBackButton_Click);
            // 
            // SetupDirNextButton
            // 
            this.SetupDirNextButton.AllowAnimations = true;
            this.SetupDirNextButton.AllowMouseEffects = true;
            this.SetupDirNextButton.AllowToggling = false;
            this.SetupDirNextButton.AnimationSpeed = 200;
            this.SetupDirNextButton.AutoGenerateColors = false;
            this.SetupDirNextButton.AutoRoundBorders = false;
            this.SetupDirNextButton.AutoSizeLeftIcon = true;
            this.SetupDirNextButton.AutoSizeRightIcon = true;
            this.SetupDirNextButton.BackColor = System.Drawing.Color.Transparent;
            this.SetupDirNextButton.BackColor1 = System.Drawing.Color.OliveDrab;
            this.SetupDirNextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetupDirNextButton.BackgroundImage")));
            this.SetupDirNextButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupDirNextButton.ButtonText = "Next";
            this.SetupDirNextButton.ButtonTextMarginLeft = 0;
            this.SetupDirNextButton.ColorContrastOnClick = 45;
            this.SetupDirNextButton.ColorContrastOnHover = 45;
            this.SetupDirNextButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.SetupDirNextButton.CustomizableEdges = borderEdges7;
            this.SetupDirNextButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SetupDirNextButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SetupDirNextButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupDirNextButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SetupDirNextButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SetupDirNextButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.SetupDirNextButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupDirNextButton.ForeColor = System.Drawing.Color.White;
            this.SetupDirNextButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetupDirNextButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SetupDirNextButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SetupDirNextButton.IconMarginLeft = 11;
            this.SetupDirNextButton.IconPadding = 10;
            this.SetupDirNextButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SetupDirNextButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SetupDirNextButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SetupDirNextButton.IconSize = 25;
            this.SetupDirNextButton.IdleBorderColor = System.Drawing.Color.OliveDrab;
            this.SetupDirNextButton.IdleBorderRadius = 8;
            this.SetupDirNextButton.IdleBorderThickness = 1;
            this.SetupDirNextButton.IdleFillColor = System.Drawing.Color.OliveDrab;
            this.SetupDirNextButton.IdleIconLeftImage = null;
            this.SetupDirNextButton.IdleIconRightImage = null;
            this.SetupDirNextButton.IndicateFocus = false;
            this.SetupDirNextButton.Location = new System.Drawing.Point(353, 10);
            this.SetupDirNextButton.Name = "SetupDirNextButton";
            this.SetupDirNextButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SetupDirNextButton.OnDisabledState.BorderRadius = 8;
            this.SetupDirNextButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupDirNextButton.OnDisabledState.BorderThickness = 1;
            this.SetupDirNextButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupDirNextButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SetupDirNextButton.OnDisabledState.IconLeftImage = null;
            this.SetupDirNextButton.OnDisabledState.IconRightImage = null;
            this.SetupDirNextButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupDirNextButton.onHoverState.BorderRadius = 8;
            this.SetupDirNextButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupDirNextButton.onHoverState.BorderThickness = 1;
            this.SetupDirNextButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupDirNextButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SetupDirNextButton.onHoverState.IconLeftImage = null;
            this.SetupDirNextButton.onHoverState.IconRightImage = null;
            this.SetupDirNextButton.OnIdleState.BorderColor = System.Drawing.Color.OliveDrab;
            this.SetupDirNextButton.OnIdleState.BorderRadius = 8;
            this.SetupDirNextButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupDirNextButton.OnIdleState.BorderThickness = 1;
            this.SetupDirNextButton.OnIdleState.FillColor = System.Drawing.Color.OliveDrab;
            this.SetupDirNextButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SetupDirNextButton.OnIdleState.IconLeftImage = null;
            this.SetupDirNextButton.OnIdleState.IconRightImage = null;
            this.SetupDirNextButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SetupDirNextButton.OnPressedState.BorderRadius = 8;
            this.SetupDirNextButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupDirNextButton.OnPressedState.BorderThickness = 1;
            this.SetupDirNextButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SetupDirNextButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SetupDirNextButton.OnPressedState.IconLeftImage = null;
            this.SetupDirNextButton.OnPressedState.IconRightImage = null;
            this.SetupDirNextButton.Size = new System.Drawing.Size(91, 20);
            this.SetupDirNextButton.TabIndex = 1;
            this.SetupDirNextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SetupDirNextButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetupDirNextButton.TextMarginLeft = 0;
            this.SetupDirNextButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.SetupDirNextButton, "");
            this.MainToolTip.SetToolTipIcon(this.SetupDirNextButton, null);
            this.MainToolTip.SetToolTipTitle(this.SetupDirNextButton, "");
            this.SetupDirNextButton.UseDefaultRadiusAndThickness = true;
            this.SetupDirNextButton.Click += new System.EventHandler(this.SetupDirNextButton_Click);
            // 
            // SetupCMDPage
            // 
            this.SetupCMDPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SetupCMDPage.Controls.Add(this.CMDDownloadText);
            this.SetupCMDPage.Controls.Add(this.panel7);
            this.SetupCMDPage.Controls.Add(this.panel8);
            this.SetupCMDPage.Controls.Add(this.bunifuSeparator7);
            this.SetupCMDPage.Controls.Add(this.bunifuShadowPanel4);
            this.SetupCMDPage.Location = new System.Drawing.Point(4, 4);
            this.SetupCMDPage.Name = "SetupCMDPage";
            this.SetupCMDPage.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.SetupCMDPage.Size = new System.Drawing.Size(476, 440);
            this.SetupCMDPage.TabIndex = 3;
            this.SetupCMDPage.Text = "Setup CMD";
            this.MainToolTip.SetToolTip(this.SetupCMDPage, "");
            this.MainToolTip.SetToolTipIcon(this.SetupCMDPage, null);
            this.MainToolTip.SetToolTipTitle(this.SetupCMDPage, "");
            // 
            // CMDDownloadText
            // 
            this.CMDDownloadText.BackColor = System.Drawing.Color.DimGray;
            this.CMDDownloadText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMDDownloadText.Enabled = false;
            this.CMDDownloadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDDownloadText.Location = new System.Drawing.Point(10, 58);
            this.CMDDownloadText.Name = "CMDDownloadText";
            this.CMDDownloadText.Size = new System.Drawing.Size(456, 274);
            this.CMDDownloadText.TabIndex = 10;
            this.CMDDownloadText.Text = "";
            this.MainToolTip.SetToolTip(this.CMDDownloadText, "");
            this.MainToolTip.SetToolTipIcon(this.CMDDownloadText, null);
            this.MainToolTip.SetToolTipTitle(this.CMDDownloadText, "");
            this.CMDDownloadText.TextChanged += new System.EventHandler(this.CMDDownloadText_TextChanged);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(10, 332);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(456, 17);
            this.panel7.TabIndex = 27;
            this.MainToolTip.SetToolTip(this.panel7, "");
            this.MainToolTip.SetToolTipIcon(this.panel7, null);
            this.MainToolTip.SetToolTipTitle(this.panel7, "");
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.SetupStepsLabel);
            this.panel8.Controls.Add(this.bunifuLoader1);
            this.panel8.Controls.Add(this.AutoNextSetupCheck);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.CMDStatusLabel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(10, 349);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(456, 81);
            this.panel8.TabIndex = 19;
            this.MainToolTip.SetToolTip(this.panel8, "");
            this.MainToolTip.SetToolTipIcon(this.panel8, null);
            this.MainToolTip.SetToolTipTitle(this.panel8, "");
            // 
            // SetupStepsLabel
            // 
            this.SetupStepsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetupStepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupStepsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.SetupStepsLabel.Location = new System.Drawing.Point(399, 25);
            this.SetupStepsLabel.Name = "SetupStepsLabel";
            this.SetupStepsLabel.Size = new System.Drawing.Size(36, 32);
            this.SetupStepsLabel.TabIndex = 18;
            this.SetupStepsLabel.Text = "Step\r\n1/8";
            this.SetupStepsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.SetupStepsLabel, "");
            this.MainToolTip.SetToolTipIcon(this.SetupStepsLabel, null);
            this.MainToolTip.SetToolTipTitle(this.SetupStepsLabel, "");
            // 
            // bunifuLoader1
            // 
            this.bunifuLoader1.AllowStylePresets = true;
            this.bunifuLoader1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLoader1.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Triangle;
            this.bunifuLoader1.Color = System.Drawing.Color.DodgerBlue;
            this.bunifuLoader1.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.bunifuLoader1.Customization = "";
            this.bunifuLoader1.DashWidth = 0.5F;
            this.bunifuLoader1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuLoader1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLoader1.Image = null;
            this.bunifuLoader1.Location = new System.Drawing.Point(376, 0);
            this.bunifuLoader1.Name = "bunifuLoader1";
            this.bunifuLoader1.NoRounding = false;
            this.bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Diamond;
            this.bunifuLoader1.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Dotted;
            this.bunifuLoader1.ShowText = false;
            this.bunifuLoader1.Size = new System.Drawing.Size(80, 81);
            this.bunifuLoader1.Speed = 4;
            this.bunifuLoader1.TabIndex = 16;
            this.bunifuLoader1.Text = "bunifuLoader1";
            this.bunifuLoader1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuLoader1.Thickness = 5;
            this.MainToolTip.SetToolTip(this.bunifuLoader1, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLoader1, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLoader1, "");
            this.bunifuLoader1.Transparent = true;
            // 
            // AutoNextSetupCheck
            // 
            this.AutoNextSetupCheck.AllowBindingControlAnimation = true;
            this.AutoNextSetupCheck.AllowBindingControlColorChanges = false;
            this.AutoNextSetupCheck.AllowBindingControlLocation = true;
            this.AutoNextSetupCheck.AllowCheckBoxAnimation = false;
            this.AutoNextSetupCheck.AllowCheckmarkAnimation = true;
            this.AutoNextSetupCheck.AllowOnHoverStates = true;
            this.AutoNextSetupCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AutoNextSetupCheck.AutoCheck = true;
            this.AutoNextSetupCheck.BackColor = System.Drawing.Color.Transparent;
            this.AutoNextSetupCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AutoNextSetupCheck.BackgroundImage")));
            this.AutoNextSetupCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AutoNextSetupCheck.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.AutoNextSetupCheck.BorderRadius = 12;
            this.AutoNextSetupCheck.Checked = true;
            this.AutoNextSetupCheck.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.AutoNextSetupCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.AutoNextSetupCheck.CustomCheckmarkImage = null;
            this.AutoNextSetupCheck.Location = new System.Drawing.Point(121, 40);
            this.AutoNextSetupCheck.MinimumSize = new System.Drawing.Size(17, 17);
            this.AutoNextSetupCheck.Name = "AutoNextSetupCheck";
            this.AutoNextSetupCheck.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.AutoNextSetupCheck.OnCheck.BorderRadius = 12;
            this.AutoNextSetupCheck.OnCheck.BorderThickness = 2;
            this.AutoNextSetupCheck.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.AutoNextSetupCheck.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.AutoNextSetupCheck.OnCheck.CheckmarkThickness = 2;
            this.AutoNextSetupCheck.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.AutoNextSetupCheck.OnDisable.BorderRadius = 12;
            this.AutoNextSetupCheck.OnDisable.BorderThickness = 2;
            this.AutoNextSetupCheck.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.AutoNextSetupCheck.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.AutoNextSetupCheck.OnDisable.CheckmarkThickness = 2;
            this.AutoNextSetupCheck.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AutoNextSetupCheck.OnHoverChecked.BorderRadius = 12;
            this.AutoNextSetupCheck.OnHoverChecked.BorderThickness = 2;
            this.AutoNextSetupCheck.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AutoNextSetupCheck.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.AutoNextSetupCheck.OnHoverChecked.CheckmarkThickness = 2;
            this.AutoNextSetupCheck.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AutoNextSetupCheck.OnHoverUnchecked.BorderRadius = 12;
            this.AutoNextSetupCheck.OnHoverUnchecked.BorderThickness = 1;
            this.AutoNextSetupCheck.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.AutoNextSetupCheck.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.AutoNextSetupCheck.OnUncheck.BorderRadius = 12;
            this.AutoNextSetupCheck.OnUncheck.BorderThickness = 1;
            this.AutoNextSetupCheck.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.AutoNextSetupCheck.Size = new System.Drawing.Size(21, 21);
            this.AutoNextSetupCheck.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.AutoNextSetupCheck.TabIndex = 14;
            this.AutoNextSetupCheck.ThreeState = false;
            this.MainToolTip.SetToolTip(this.AutoNextSetupCheck, "");
            this.MainToolTip.SetToolTipIcon(this.AutoNextSetupCheck, null);
            this.AutoNextSetupCheck.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.AutoNextSetupCheck, "");
            this.AutoNextSetupCheck.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.AutoNextSetupCheck_CheckedChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label14.Location = new System.Drawing.Point(6, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(450, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Go to next page when completed";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.label14, "");
            this.MainToolTip.SetToolTipIcon(this.label14, null);
            this.MainToolTip.SetToolTipTitle(this.label14, "");
            // 
            // CMDStatusLabel
            // 
            this.CMDStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMDStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.CMDStatusLabel.Location = new System.Drawing.Point(3, 11);
            this.CMDStatusLabel.Name = "CMDStatusLabel";
            this.CMDStatusLabel.Size = new System.Drawing.Size(453, 26);
            this.CMDStatusLabel.TabIndex = 11;
            this.CMDStatusLabel.Text = "Please wait for the download to finish.";
            this.CMDStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.CMDStatusLabel, "");
            this.MainToolTip.SetToolTipIcon(this.CMDStatusLabel, null);
            this.MainToolTip.SetToolTipTitle(this.CMDStatusLabel, "");
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator7.BackgroundImage")));
            this.bunifuSeparator7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator7.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator7.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator7.LineThickness = 1;
            this.bunifuSeparator7.Location = new System.Drawing.Point(10, 45);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator7.Size = new System.Drawing.Size(456, 13);
            this.bunifuSeparator7.TabIndex = 8;
            this.MainToolTip.SetToolTip(this.bunifuSeparator7, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator7, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator7, "");
            // 
            // bunifuShadowPanel4
            // 
            this.bunifuShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel4.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel4.BorderRadius = 8;
            this.bunifuShadowPanel4.BorderThickness = 1;
            this.bunifuShadowPanel4.Controls.Add(this.label3);
            this.bunifuShadowPanel4.Controls.Add(this.SetupCMDNextButton);
            this.bunifuShadowPanel4.Controls.Add(this.SetupCMDBackButton);
            this.bunifuShadowPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel4.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel4.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel4.Location = new System.Drawing.Point(10, 5);
            this.bunifuShadowPanel4.Name = "bunifuShadowPanel4";
            this.bunifuShadowPanel4.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.bunifuShadowPanel4.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel4.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel4.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel4.ShadowDept = 2;
            this.bunifuShadowPanel4.ShadowDepth = 5;
            this.bunifuShadowPanel4.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel4.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel4.Size = new System.Drawing.Size(456, 40);
            this.bunifuShadowPanel4.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel4.TabIndex = 13;
            this.MainToolTip.SetToolTip(this.bunifuShadowPanel4, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuShadowPanel4, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuShadowPanel4, "");
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(80, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Server Files Download";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.label3, "");
            this.MainToolTip.SetToolTipIcon(this.label3, null);
            this.MainToolTip.SetToolTipTitle(this.label3, "");
            // 
            // SetupCMDNextButton
            // 
            this.SetupCMDNextButton.AllowAnimations = true;
            this.SetupCMDNextButton.AllowMouseEffects = true;
            this.SetupCMDNextButton.AllowToggling = false;
            this.SetupCMDNextButton.AnimationSpeed = 200;
            this.SetupCMDNextButton.AutoGenerateColors = false;
            this.SetupCMDNextButton.AutoRoundBorders = false;
            this.SetupCMDNextButton.AutoSizeLeftIcon = true;
            this.SetupCMDNextButton.AutoSizeRightIcon = true;
            this.SetupCMDNextButton.BackColor = System.Drawing.Color.Transparent;
            this.SetupCMDNextButton.BackColor1 = System.Drawing.Color.OliveDrab;
            this.SetupCMDNextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetupCMDNextButton.BackgroundImage")));
            this.SetupCMDNextButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupCMDNextButton.ButtonText = "Next";
            this.SetupCMDNextButton.ButtonTextMarginLeft = 0;
            this.SetupCMDNextButton.ColorContrastOnClick = 45;
            this.SetupCMDNextButton.ColorContrastOnHover = 45;
            this.SetupCMDNextButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.SetupCMDNextButton.CustomizableEdges = borderEdges8;
            this.SetupCMDNextButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SetupCMDNextButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SetupCMDNextButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupCMDNextButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SetupCMDNextButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SetupCMDNextButton.Enabled = false;
            this.SetupCMDNextButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.SetupCMDNextButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupCMDNextButton.ForeColor = System.Drawing.Color.White;
            this.SetupCMDNextButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetupCMDNextButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SetupCMDNextButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SetupCMDNextButton.IconMarginLeft = 11;
            this.SetupCMDNextButton.IconPadding = 10;
            this.SetupCMDNextButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SetupCMDNextButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SetupCMDNextButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SetupCMDNextButton.IconSize = 25;
            this.SetupCMDNextButton.IdleBorderColor = System.Drawing.Color.OliveDrab;
            this.SetupCMDNextButton.IdleBorderRadius = 8;
            this.SetupCMDNextButton.IdleBorderThickness = 1;
            this.SetupCMDNextButton.IdleFillColor = System.Drawing.Color.OliveDrab;
            this.SetupCMDNextButton.IdleIconLeftImage = null;
            this.SetupCMDNextButton.IdleIconRightImage = null;
            this.SetupCMDNextButton.IndicateFocus = false;
            this.SetupCMDNextButton.Location = new System.Drawing.Point(353, 10);
            this.SetupCMDNextButton.Name = "SetupCMDNextButton";
            this.SetupCMDNextButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SetupCMDNextButton.OnDisabledState.BorderRadius = 8;
            this.SetupCMDNextButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupCMDNextButton.OnDisabledState.BorderThickness = 1;
            this.SetupCMDNextButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupCMDNextButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SetupCMDNextButton.OnDisabledState.IconLeftImage = null;
            this.SetupCMDNextButton.OnDisabledState.IconRightImage = null;
            this.SetupCMDNextButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupCMDNextButton.onHoverState.BorderRadius = 8;
            this.SetupCMDNextButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupCMDNextButton.onHoverState.BorderThickness = 1;
            this.SetupCMDNextButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupCMDNextButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SetupCMDNextButton.onHoverState.IconLeftImage = null;
            this.SetupCMDNextButton.onHoverState.IconRightImage = null;
            this.SetupCMDNextButton.OnIdleState.BorderColor = System.Drawing.Color.OliveDrab;
            this.SetupCMDNextButton.OnIdleState.BorderRadius = 8;
            this.SetupCMDNextButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupCMDNextButton.OnIdleState.BorderThickness = 1;
            this.SetupCMDNextButton.OnIdleState.FillColor = System.Drawing.Color.OliveDrab;
            this.SetupCMDNextButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SetupCMDNextButton.OnIdleState.IconLeftImage = null;
            this.SetupCMDNextButton.OnIdleState.IconRightImage = null;
            this.SetupCMDNextButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SetupCMDNextButton.OnPressedState.BorderRadius = 8;
            this.SetupCMDNextButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupCMDNextButton.OnPressedState.BorderThickness = 1;
            this.SetupCMDNextButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SetupCMDNextButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SetupCMDNextButton.OnPressedState.IconLeftImage = null;
            this.SetupCMDNextButton.OnPressedState.IconRightImage = null;
            this.SetupCMDNextButton.Size = new System.Drawing.Size(91, 20);
            this.SetupCMDNextButton.TabIndex = 3;
            this.SetupCMDNextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SetupCMDNextButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetupCMDNextButton.TextMarginLeft = 0;
            this.SetupCMDNextButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.SetupCMDNextButton, "");
            this.MainToolTip.SetToolTipIcon(this.SetupCMDNextButton, null);
            this.MainToolTip.SetToolTipTitle(this.SetupCMDNextButton, "");
            this.SetupCMDNextButton.UseDefaultRadiusAndThickness = true;
            this.SetupCMDNextButton.Click += new System.EventHandler(this.SetupCMDNextButton_Click);
            // 
            // SetupCMDBackButton
            // 
            this.SetupCMDBackButton.AllowAnimations = true;
            this.SetupCMDBackButton.AllowMouseEffects = true;
            this.SetupCMDBackButton.AllowToggling = false;
            this.SetupCMDBackButton.AnimationSpeed = 200;
            this.SetupCMDBackButton.AutoGenerateColors = false;
            this.SetupCMDBackButton.AutoRoundBorders = false;
            this.SetupCMDBackButton.AutoSizeLeftIcon = true;
            this.SetupCMDBackButton.AutoSizeRightIcon = true;
            this.SetupCMDBackButton.BackColor = System.Drawing.Color.Transparent;
            this.SetupCMDBackButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.SetupCMDBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetupCMDBackButton.BackgroundImage")));
            this.SetupCMDBackButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupCMDBackButton.ButtonText = "Back";
            this.SetupCMDBackButton.ButtonTextMarginLeft = 0;
            this.SetupCMDBackButton.ColorContrastOnClick = 45;
            this.SetupCMDBackButton.ColorContrastOnHover = 45;
            this.SetupCMDBackButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.SetupCMDBackButton.CustomizableEdges = borderEdges9;
            this.SetupCMDBackButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SetupCMDBackButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SetupCMDBackButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupCMDBackButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SetupCMDBackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SetupCMDBackButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.SetupCMDBackButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupCMDBackButton.ForeColor = System.Drawing.Color.White;
            this.SetupCMDBackButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetupCMDBackButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SetupCMDBackButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SetupCMDBackButton.IconMarginLeft = 11;
            this.SetupCMDBackButton.IconPadding = 10;
            this.SetupCMDBackButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SetupCMDBackButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SetupCMDBackButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SetupCMDBackButton.IconSize = 25;
            this.SetupCMDBackButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SetupCMDBackButton.IdleBorderRadius = 8;
            this.SetupCMDBackButton.IdleBorderThickness = 1;
            this.SetupCMDBackButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SetupCMDBackButton.IdleIconLeftImage = null;
            this.SetupCMDBackButton.IdleIconRightImage = null;
            this.SetupCMDBackButton.IndicateFocus = false;
            this.SetupCMDBackButton.Location = new System.Drawing.Point(12, 10);
            this.SetupCMDBackButton.Name = "SetupCMDBackButton";
            this.SetupCMDBackButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SetupCMDBackButton.OnDisabledState.BorderRadius = 8;
            this.SetupCMDBackButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupCMDBackButton.OnDisabledState.BorderThickness = 1;
            this.SetupCMDBackButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupCMDBackButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SetupCMDBackButton.OnDisabledState.IconLeftImage = null;
            this.SetupCMDBackButton.OnDisabledState.IconRightImage = null;
            this.SetupCMDBackButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupCMDBackButton.onHoverState.BorderRadius = 8;
            this.SetupCMDBackButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupCMDBackButton.onHoverState.BorderThickness = 1;
            this.SetupCMDBackButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupCMDBackButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SetupCMDBackButton.onHoverState.IconLeftImage = null;
            this.SetupCMDBackButton.onHoverState.IconRightImage = null;
            this.SetupCMDBackButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SetupCMDBackButton.OnIdleState.BorderRadius = 8;
            this.SetupCMDBackButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupCMDBackButton.OnIdleState.BorderThickness = 1;
            this.SetupCMDBackButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SetupCMDBackButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SetupCMDBackButton.OnIdleState.IconLeftImage = null;
            this.SetupCMDBackButton.OnIdleState.IconRightImage = null;
            this.SetupCMDBackButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SetupCMDBackButton.OnPressedState.BorderRadius = 8;
            this.SetupCMDBackButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupCMDBackButton.OnPressedState.BorderThickness = 1;
            this.SetupCMDBackButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SetupCMDBackButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SetupCMDBackButton.OnPressedState.IconLeftImage = null;
            this.SetupCMDBackButton.OnPressedState.IconRightImage = null;
            this.SetupCMDBackButton.Size = new System.Drawing.Size(68, 20);
            this.SetupCMDBackButton.TabIndex = 2;
            this.SetupCMDBackButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SetupCMDBackButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetupCMDBackButton.TextMarginLeft = 0;
            this.SetupCMDBackButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.SetupCMDBackButton, "");
            this.MainToolTip.SetToolTipIcon(this.SetupCMDBackButton, null);
            this.MainToolTip.SetToolTipTitle(this.SetupCMDBackButton, "");
            this.SetupCMDBackButton.UseDefaultRadiusAndThickness = true;
            this.SetupCMDBackButton.Click += new System.EventHandler(this.SetupCMDBackButton_Click);
            // 
            // SetupEndPage
            // 
            this.SetupEndPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SetupEndPage.Controls.Add(this.bunifuGroupBox4);
            this.SetupEndPage.Controls.Add(this.bunifuGroupBox8);
            this.SetupEndPage.Controls.Add(this.bunifuGroupBox3);
            this.SetupEndPage.Controls.Add(this.bunifuGroupBox2);
            this.SetupEndPage.Controls.Add(this.label15);
            this.SetupEndPage.Controls.Add(this.panel4);
            this.SetupEndPage.Controls.Add(this.bunifuShadowPanel5);
            this.SetupEndPage.Controls.Add(this.SetupcompletedHome);
            this.SetupEndPage.Location = new System.Drawing.Point(4, 4);
            this.SetupEndPage.Name = "SetupEndPage";
            this.SetupEndPage.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.SetupEndPage.Size = new System.Drawing.Size(476, 440);
            this.SetupEndPage.TabIndex = 4;
            this.SetupEndPage.Text = "Setup End";
            this.MainToolTip.SetToolTip(this.SetupEndPage, "");
            this.MainToolTip.SetToolTipIcon(this.SetupEndPage, null);
            this.MainToolTip.SetToolTipTitle(this.SetupEndPage, "");
            // 
            // bunifuGroupBox4
            // 
            this.bunifuGroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuGroupBox4.BorderRadius = 8;
            this.bunifuGroupBox4.BorderThickness = 2;
            this.bunifuGroupBox4.Controls.Add(this.bunifuLabel3);
            this.bunifuGroupBox4.Controls.Add(this.CheckNoHelp);
            this.bunifuGroupBox4.Controls.Add(this.label25);
            this.bunifuGroupBox4.Controls.Add(this.CheckHelpTooltips);
            this.bunifuGroupBox4.Controls.Add(this.label23);
            this.bunifuGroupBox4.Controls.Add(this.CheckOpenReadme);
            this.bunifuGroupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.bunifuGroupBox4.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox4.LabelIndent = 10;
            this.bunifuGroupBox4.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox4.Location = new System.Drawing.Point(10, 352);
            this.bunifuGroupBox4.Name = "bunifuGroupBox4";
            this.bunifuGroupBox4.Size = new System.Drawing.Size(456, 71);
            this.bunifuGroupBox4.TabIndex = 37;
            this.bunifuGroupBox4.TabStop = false;
            this.bunifuGroupBox4.Text = "Help";
            this.MainToolTip.SetToolTip(this.bunifuGroupBox4, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuGroupBox4, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuGroupBox4, "");
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(25, 47);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(40, 15);
            this.bunifuLabel3.TabIndex = 42;
            this.bunifuLabel3.Text = "Disable";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.bunifuLabel3, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLabel3, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLabel3, "");
            // 
            // CheckNoHelp
            // 
            this.CheckNoHelp.AllowBindingControlAnimation = true;
            this.CheckNoHelp.AllowBindingControlColorChanges = false;
            this.CheckNoHelp.AllowBindingControlLocation = true;
            this.CheckNoHelp.AllowCheckBoxAnimation = false;
            this.CheckNoHelp.AllowCheckmarkAnimation = true;
            this.CheckNoHelp.AllowOnHoverStates = true;
            this.CheckNoHelp.AutoCheck = true;
            this.CheckNoHelp.BackColor = System.Drawing.Color.Transparent;
            this.CheckNoHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckNoHelp.BackgroundImage")));
            this.CheckNoHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckNoHelp.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckNoHelp.BorderRadius = 12;
            this.CheckNoHelp.Checked = false;
            this.CheckNoHelp.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.CheckNoHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckNoHelp.CustomCheckmarkImage = null;
            this.CheckNoHelp.Location = new System.Drawing.Point(33, 20);
            this.CheckNoHelp.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckNoHelp.Name = "CheckNoHelp";
            this.CheckNoHelp.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckNoHelp.OnCheck.BorderRadius = 12;
            this.CheckNoHelp.OnCheck.BorderThickness = 2;
            this.CheckNoHelp.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckNoHelp.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckNoHelp.OnCheck.CheckmarkThickness = 2;
            this.CheckNoHelp.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckNoHelp.OnDisable.BorderRadius = 12;
            this.CheckNoHelp.OnDisable.BorderThickness = 2;
            this.CheckNoHelp.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNoHelp.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckNoHelp.OnDisable.CheckmarkThickness = 2;
            this.CheckNoHelp.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNoHelp.OnHoverChecked.BorderRadius = 12;
            this.CheckNoHelp.OnHoverChecked.BorderThickness = 2;
            this.CheckNoHelp.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNoHelp.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckNoHelp.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckNoHelp.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNoHelp.OnHoverUnchecked.BorderRadius = 12;
            this.CheckNoHelp.OnHoverUnchecked.BorderThickness = 1;
            this.CheckNoHelp.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNoHelp.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckNoHelp.OnUncheck.BorderRadius = 12;
            this.CheckNoHelp.OnUncheck.BorderThickness = 1;
            this.CheckNoHelp.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNoHelp.Size = new System.Drawing.Size(21, 21);
            this.CheckNoHelp.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckNoHelp.TabIndex = 41;
            this.CheckNoHelp.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckNoHelp, "");
            this.MainToolTip.SetToolTipIcon(this.CheckNoHelp, null);
            this.CheckNoHelp.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckNoHelp, "");
            this.CheckNoHelp.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.CheckNoHelp_CheckedChanged);
            this.CheckNoHelp.Click += new System.EventHandler(this.CheckNoHelp_Click);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label25.Location = new System.Drawing.Point(124, 39);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(185, 29);
            this.label25.TabIndex = 39;
            this.label25.Text = "Enable Help Tooltips";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainToolTip.SetToolTip(this.label25, "Enables the tool tips across the whole map.\r\nTool tips are there to help explain " +
        "things for newer map creators.");
            this.MainToolTip.SetToolTipIcon(this.label25, null);
            this.MainToolTip.SetToolTipTitle(this.label25, "");
            // 
            // CheckHelpTooltips
            // 
            this.CheckHelpTooltips.AllowBindingControlAnimation = true;
            this.CheckHelpTooltips.AllowBindingControlColorChanges = false;
            this.CheckHelpTooltips.AllowBindingControlLocation = true;
            this.CheckHelpTooltips.AllowCheckBoxAnimation = false;
            this.CheckHelpTooltips.AllowCheckmarkAnimation = true;
            this.CheckHelpTooltips.AllowOnHoverStates = true;
            this.CheckHelpTooltips.AutoCheck = true;
            this.CheckHelpTooltips.BackColor = System.Drawing.Color.Transparent;
            this.CheckHelpTooltips.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckHelpTooltips.BackgroundImage")));
            this.CheckHelpTooltips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckHelpTooltips.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckHelpTooltips.BorderRadius = 12;
            this.CheckHelpTooltips.Checked = true;
            this.CheckHelpTooltips.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.CheckHelpTooltips.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckHelpTooltips.CustomCheckmarkImage = null;
            this.CheckHelpTooltips.Location = new System.Drawing.Point(97, 43);
            this.CheckHelpTooltips.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckHelpTooltips.Name = "CheckHelpTooltips";
            this.CheckHelpTooltips.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckHelpTooltips.OnCheck.BorderRadius = 12;
            this.CheckHelpTooltips.OnCheck.BorderThickness = 2;
            this.CheckHelpTooltips.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckHelpTooltips.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckHelpTooltips.OnCheck.CheckmarkThickness = 2;
            this.CheckHelpTooltips.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckHelpTooltips.OnDisable.BorderRadius = 12;
            this.CheckHelpTooltips.OnDisable.BorderThickness = 2;
            this.CheckHelpTooltips.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckHelpTooltips.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckHelpTooltips.OnDisable.CheckmarkThickness = 2;
            this.CheckHelpTooltips.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckHelpTooltips.OnHoverChecked.BorderRadius = 12;
            this.CheckHelpTooltips.OnHoverChecked.BorderThickness = 2;
            this.CheckHelpTooltips.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckHelpTooltips.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckHelpTooltips.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckHelpTooltips.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckHelpTooltips.OnHoverUnchecked.BorderRadius = 12;
            this.CheckHelpTooltips.OnHoverUnchecked.BorderThickness = 1;
            this.CheckHelpTooltips.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckHelpTooltips.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckHelpTooltips.OnUncheck.BorderRadius = 12;
            this.CheckHelpTooltips.OnUncheck.BorderThickness = 1;
            this.CheckHelpTooltips.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckHelpTooltips.Size = new System.Drawing.Size(21, 21);
            this.CheckHelpTooltips.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckHelpTooltips.TabIndex = 40;
            this.CheckHelpTooltips.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckHelpTooltips, "Enables the tool tips across the whole map.\r\nTool tips are there to help explain " +
        "things for newer map creators.");
            this.MainToolTip.SetToolTipIcon(this.CheckHelpTooltips, null);
            this.CheckHelpTooltips.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckHelpTooltips, "");
            this.CheckHelpTooltips.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.CheckHelpTooltips_CheckedChanged);
            this.CheckHelpTooltips.Click += new System.EventHandler(this.CheckHelpTooltips_Click);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label23.Location = new System.Drawing.Point(124, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(185, 29);
            this.label23.TabIndex = 37;
            this.label23.Text = "Open Read Me / Help tab";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainToolTip.SetToolTip(this.label23, "When at home page will open the show help tab.\r\nGreat when using the app for the " +
        "first time.\r\n\r\n");
            this.MainToolTip.SetToolTipIcon(this.label23, null);
            this.MainToolTip.SetToolTipTitle(this.label23, "");
            // 
            // CheckOpenReadme
            // 
            this.CheckOpenReadme.AllowBindingControlAnimation = true;
            this.CheckOpenReadme.AllowBindingControlColorChanges = false;
            this.CheckOpenReadme.AllowBindingControlLocation = true;
            this.CheckOpenReadme.AllowCheckBoxAnimation = false;
            this.CheckOpenReadme.AllowCheckmarkAnimation = true;
            this.CheckOpenReadme.AllowOnHoverStates = true;
            this.CheckOpenReadme.AutoCheck = true;
            this.CheckOpenReadme.BackColor = System.Drawing.Color.Transparent;
            this.CheckOpenReadme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckOpenReadme.BackgroundImage")));
            this.CheckOpenReadme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckOpenReadme.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckOpenReadme.BorderRadius = 12;
            this.CheckOpenReadme.Checked = true;
            this.CheckOpenReadme.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.CheckOpenReadme.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckOpenReadme.CustomCheckmarkImage = null;
            this.CheckOpenReadme.Location = new System.Drawing.Point(97, 17);
            this.CheckOpenReadme.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckOpenReadme.Name = "CheckOpenReadme";
            this.CheckOpenReadme.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckOpenReadme.OnCheck.BorderRadius = 12;
            this.CheckOpenReadme.OnCheck.BorderThickness = 2;
            this.CheckOpenReadme.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckOpenReadme.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckOpenReadme.OnCheck.CheckmarkThickness = 2;
            this.CheckOpenReadme.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckOpenReadme.OnDisable.BorderRadius = 12;
            this.CheckOpenReadme.OnDisable.BorderThickness = 2;
            this.CheckOpenReadme.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckOpenReadme.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckOpenReadme.OnDisable.CheckmarkThickness = 2;
            this.CheckOpenReadme.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckOpenReadme.OnHoverChecked.BorderRadius = 12;
            this.CheckOpenReadme.OnHoverChecked.BorderThickness = 2;
            this.CheckOpenReadme.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckOpenReadme.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckOpenReadme.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckOpenReadme.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckOpenReadme.OnHoverUnchecked.BorderRadius = 12;
            this.CheckOpenReadme.OnHoverUnchecked.BorderThickness = 1;
            this.CheckOpenReadme.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckOpenReadme.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckOpenReadme.OnUncheck.BorderRadius = 12;
            this.CheckOpenReadme.OnUncheck.BorderThickness = 1;
            this.CheckOpenReadme.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckOpenReadme.Size = new System.Drawing.Size(21, 21);
            this.CheckOpenReadme.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckOpenReadme.TabIndex = 38;
            this.CheckOpenReadme.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckOpenReadme, "When at home page will open the show help tab.\r\nGreat when using the app for the " +
        "first time.");
            this.MainToolTip.SetToolTipIcon(this.CheckOpenReadme, null);
            this.CheckOpenReadme.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckOpenReadme, "");
            this.CheckOpenReadme.Click += new System.EventHandler(this.CheckOpenReadme_Click);
            // 
            // bunifuGroupBox8
            // 
            this.bunifuGroupBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuGroupBox8.BorderRadius = 8;
            this.bunifuGroupBox8.BorderThickness = 2;
            this.bunifuGroupBox8.Controls.Add(this.FinishRustGameDirbox);
            this.bunifuGroupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.bunifuGroupBox8.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox8.LabelIndent = 10;
            this.bunifuGroupBox8.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox8.Location = new System.Drawing.Point(10, 287);
            this.bunifuGroupBox8.Name = "bunifuGroupBox8";
            this.bunifuGroupBox8.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.bunifuGroupBox8.Size = new System.Drawing.Size(456, 65);
            this.bunifuGroupBox8.TabIndex = 38;
            this.bunifuGroupBox8.TabStop = false;
            this.bunifuGroupBox8.Text = "Client Maps Location (Click the folder icon to browse)";
            this.MainToolTip.SetToolTip(this.bunifuGroupBox8, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuGroupBox8, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuGroupBox8, "");
            // 
            // FinishRustGameDirbox
            // 
            this.FinishRustGameDirbox.AcceptsReturn = false;
            this.FinishRustGameDirbox.AcceptsTab = false;
            this.FinishRustGameDirbox.AnimationSpeed = 200;
            this.FinishRustGameDirbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.FinishRustGameDirbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.FinishRustGameDirbox.AutoSizeHeight = true;
            this.FinishRustGameDirbox.BackColor = System.Drawing.Color.Transparent;
            this.FinishRustGameDirbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FinishRustGameDirbox.BackgroundImage")));
            this.FinishRustGameDirbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.FinishRustGameDirbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FinishRustGameDirbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FinishRustGameDirbox.BorderColorIdle = System.Drawing.Color.Silver;
            this.FinishRustGameDirbox.BorderRadius = 8;
            this.FinishRustGameDirbox.BorderThickness = 1;
            this.FinishRustGameDirbox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.FinishRustGameDirbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.FinishRustGameDirbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FinishRustGameDirbox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FinishRustGameDirbox.DefaultText = "";
            this.FinishRustGameDirbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FinishRustGameDirbox.FillColor = System.Drawing.Color.DimGray;
            this.FinishRustGameDirbox.ForeColor = System.Drawing.Color.Black;
            this.FinishRustGameDirbox.HideSelection = true;
            this.FinishRustGameDirbox.IconLeft = global::EasyMapTestRust.Properties.Resources._3767084__1_;
            this.FinishRustGameDirbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.FinishRustGameDirbox.IconPadding = 10;
            this.FinishRustGameDirbox.IconRight = null;
            this.FinishRustGameDirbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.FinishRustGameDirbox.Lines = new string[0];
            this.FinishRustGameDirbox.Location = new System.Drawing.Point(5, 20);
            this.FinishRustGameDirbox.MaxLength = 32767;
            this.FinishRustGameDirbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.FinishRustGameDirbox.Modified = false;
            this.FinishRustGameDirbox.Multiline = false;
            this.FinishRustGameDirbox.Name = "FinishRustGameDirbox";
            stateProperties33.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties33.FillColor = System.Drawing.Color.Empty;
            stateProperties33.ForeColor = System.Drawing.Color.Empty;
            stateProperties33.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.FinishRustGameDirbox.OnActiveState = stateProperties33;
            stateProperties34.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties34.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties34.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.FinishRustGameDirbox.OnDisabledState = stateProperties34;
            stateProperties35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties35.FillColor = System.Drawing.Color.Empty;
            stateProperties35.ForeColor = System.Drawing.Color.Empty;
            stateProperties35.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.FinishRustGameDirbox.OnHoverState = stateProperties35;
            stateProperties36.BorderColor = System.Drawing.Color.Silver;
            stateProperties36.FillColor = System.Drawing.Color.DimGray;
            stateProperties36.ForeColor = System.Drawing.Color.Black;
            stateProperties36.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.FinishRustGameDirbox.OnIdleState = stateProperties36;
            this.FinishRustGameDirbox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.FinishRustGameDirbox.PasswordChar = '\0';
            this.FinishRustGameDirbox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.FinishRustGameDirbox.PlaceholderText = "Rust Client Maps Folder (Optional)";
            this.FinishRustGameDirbox.ReadOnly = false;
            this.FinishRustGameDirbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FinishRustGameDirbox.SelectedText = "";
            this.FinishRustGameDirbox.SelectionLength = 0;
            this.FinishRustGameDirbox.SelectionStart = 0;
            this.FinishRustGameDirbox.ShortcutsEnabled = true;
            this.FinishRustGameDirbox.Size = new System.Drawing.Size(446, 37);
            this.FinishRustGameDirbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.FinishRustGameDirbox.TabIndex = 23;
            this.FinishRustGameDirbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FinishRustGameDirbox.TextMarginBottom = 0;
            this.FinishRustGameDirbox.TextMarginLeft = 3;
            this.FinishRustGameDirbox.TextMarginTop = 1;
            this.FinishRustGameDirbox.TextPlaceholder = "Rust Client Maps Folder (Optional)";
            this.MainToolTip.SetToolTip(this.FinishRustGameDirbox, resources.GetString("FinishRustGameDirbox.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.FinishRustGameDirbox, null);
            this.MainToolTip.SetToolTipTitle(this.FinishRustGameDirbox, "");
            this.FinishRustGameDirbox.UseSystemPasswordChar = false;
            this.FinishRustGameDirbox.WordWrap = true;
            this.FinishRustGameDirbox.TextChange += new System.EventHandler(this.FinishRustGameDirbox_TextChange);
            this.FinishRustGameDirbox.OnIconLeftClick += new System.EventHandler(this.FinishRustGameDirbox_OnIconLeftClick);
            // 
            // bunifuGroupBox3
            // 
            this.bunifuGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuGroupBox3.BorderRadius = 8;
            this.bunifuGroupBox3.BorderThickness = 2;
            this.bunifuGroupBox3.Controls.Add(this.bunifuLabel1);
            this.bunifuGroupBox3.Controls.Add(this.CheckNoPlugins);
            this.bunifuGroupBox3.Controls.Add(this.RadioCarbon);
            this.bunifuGroupBox3.Controls.Add(this.RadioUmod);
            this.bunifuGroupBox3.Controls.Add(this.label28);
            this.bunifuGroupBox3.Controls.Add(this.label18);
            this.bunifuGroupBox3.Controls.Add(this.label24);
            this.bunifuGroupBox3.Controls.Add(this.CheckRusteditDLL);
            this.bunifuGroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.bunifuGroupBox3.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox3.LabelIndent = 10;
            this.bunifuGroupBox3.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox3.Location = new System.Drawing.Point(10, 193);
            this.bunifuGroupBox3.Name = "bunifuGroupBox3";
            this.bunifuGroupBox3.Size = new System.Drawing.Size(456, 94);
            this.bunifuGroupBox3.TabIndex = 36;
            this.bunifuGroupBox3.TabStop = false;
            this.bunifuGroupBox3.Text = "Ext.RustEdit";
            this.MainToolTip.SetToolTip(this.bunifuGroupBox3, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuGroupBox3, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuGroupBox3, "");
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(25, 59);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(40, 15);
            this.bunifuLabel1.TabIndex = 37;
            this.bunifuLabel1.Text = "Disable";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.bunifuLabel1, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLabel1, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLabel1, "");
            // 
            // CheckNoPlugins
            // 
            this.CheckNoPlugins.AllowBindingControlAnimation = true;
            this.CheckNoPlugins.AllowBindingControlColorChanges = false;
            this.CheckNoPlugins.AllowBindingControlLocation = true;
            this.CheckNoPlugins.AllowCheckBoxAnimation = false;
            this.CheckNoPlugins.AllowCheckmarkAnimation = true;
            this.CheckNoPlugins.AllowOnHoverStates = true;
            this.CheckNoPlugins.AutoCheck = true;
            this.CheckNoPlugins.BackColor = System.Drawing.Color.Transparent;
            this.CheckNoPlugins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckNoPlugins.BackgroundImage")));
            this.CheckNoPlugins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckNoPlugins.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckNoPlugins.BorderRadius = 12;
            this.CheckNoPlugins.Checked = false;
            this.CheckNoPlugins.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.CheckNoPlugins.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckNoPlugins.CustomCheckmarkImage = null;
            this.CheckNoPlugins.Location = new System.Drawing.Point(33, 32);
            this.CheckNoPlugins.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckNoPlugins.Name = "CheckNoPlugins";
            this.CheckNoPlugins.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckNoPlugins.OnCheck.BorderRadius = 12;
            this.CheckNoPlugins.OnCheck.BorderThickness = 2;
            this.CheckNoPlugins.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckNoPlugins.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckNoPlugins.OnCheck.CheckmarkThickness = 2;
            this.CheckNoPlugins.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckNoPlugins.OnDisable.BorderRadius = 12;
            this.CheckNoPlugins.OnDisable.BorderThickness = 2;
            this.CheckNoPlugins.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNoPlugins.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckNoPlugins.OnDisable.CheckmarkThickness = 2;
            this.CheckNoPlugins.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNoPlugins.OnHoverChecked.BorderRadius = 12;
            this.CheckNoPlugins.OnHoverChecked.BorderThickness = 2;
            this.CheckNoPlugins.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNoPlugins.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckNoPlugins.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckNoPlugins.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNoPlugins.OnHoverUnchecked.BorderRadius = 12;
            this.CheckNoPlugins.OnHoverUnchecked.BorderThickness = 1;
            this.CheckNoPlugins.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNoPlugins.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckNoPlugins.OnUncheck.BorderRadius = 12;
            this.CheckNoPlugins.OnUncheck.BorderThickness = 1;
            this.CheckNoPlugins.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNoPlugins.Size = new System.Drawing.Size(21, 21);
            this.CheckNoPlugins.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckNoPlugins.TabIndex = 36;
            this.CheckNoPlugins.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckNoPlugins, "");
            this.MainToolTip.SetToolTipIcon(this.CheckNoPlugins, null);
            this.CheckNoPlugins.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckNoPlugins, "");
            this.CheckNoPlugins.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.CheckNoPlugins_CheckedChanged);
            // 
            // RadioCarbon
            // 
            this.RadioCarbon.AllowBindingControlLocation = false;
            this.RadioCarbon.BackColor = System.Drawing.Color.Transparent;
            this.RadioCarbon.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.RadioCarbon.BorderThickness = 1;
            this.RadioCarbon.Checked = false;
            this.RadioCarbon.Location = new System.Drawing.Point(97, 15);
            this.RadioCarbon.Name = "RadioCarbon";
            this.RadioCarbon.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.RadioCarbon.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.RadioCarbon.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.RadioCarbon.RadioColor = System.Drawing.Color.DodgerBlue;
            this.RadioCarbon.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.RadioCarbon.Size = new System.Drawing.Size(21, 21);
            this.RadioCarbon.TabIndex = 35;
            this.RadioCarbon.Text = null;
            this.MainToolTip.SetToolTip(this.RadioCarbon, "");
            this.MainToolTip.SetToolTipIcon(this.RadioCarbon, null);
            this.MainToolTip.SetToolTipTitle(this.RadioCarbon, "");
            this.RadioCarbon.Click += new System.EventHandler(this.RadioCarbon_Click);
            // 
            // RadioUmod
            // 
            this.RadioUmod.AllowBindingControlLocation = false;
            this.RadioUmod.BackColor = System.Drawing.Color.Transparent;
            this.RadioUmod.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.RadioUmod.BorderThickness = 1;
            this.RadioUmod.Checked = true;
            this.RadioUmod.Location = new System.Drawing.Point(97, 40);
            this.RadioUmod.Name = "RadioUmod";
            this.RadioUmod.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.RadioUmod.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.RadioUmod.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.RadioUmod.RadioColor = System.Drawing.Color.DodgerBlue;
            this.RadioUmod.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.RadioUmod.Size = new System.Drawing.Size(21, 21);
            this.RadioUmod.TabIndex = 35;
            this.RadioUmod.Text = null;
            this.MainToolTip.SetToolTip(this.RadioUmod, "");
            this.MainToolTip.SetToolTipIcon(this.RadioUmod, null);
            this.MainToolTip.SetToolTipTitle(this.RadioUmod, "");
            this.RadioUmod.Click += new System.EventHandler(this.RadioUmod_Click);
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label28.Location = new System.Drawing.Point(124, 36);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(239, 29);
            this.label28.TabIndex = 33;
            this.label28.Text = "Download and install Umod";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainToolTip.SetToolTip(this.label28, resources.GetString("label28.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.label28, null);
            this.MainToolTip.SetToolTipTitle(this.label28, "");
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label18.Location = new System.Drawing.Point(124, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(283, 29);
            this.label18.TabIndex = 22;
            this.label18.Text = "Download and install CarbonMod";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainToolTip.SetToolTip(this.label18, resources.GetString("label18.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.label18, null);
            this.MainToolTip.SetToolTipTitle(this.label18, "");
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label24.Location = new System.Drawing.Point(124, 62);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(225, 29);
            this.label24.TabIndex = 31;
            this.label24.Text = "Download Ext.RustEdit.dll ";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainToolTip.SetToolTip(this.label24, "Certain custom map features require the Ext.RustEdit.dll to be installed.\r\n\r\nDown" +
        "loads the official .dll file from github.\r\nMoves the file to the carbon extentio" +
        "ns folder.");
            this.MainToolTip.SetToolTipIcon(this.label24, null);
            this.MainToolTip.SetToolTipTitle(this.label24, "");
            // 
            // CheckRusteditDLL
            // 
            this.CheckRusteditDLL.AllowBindingControlAnimation = true;
            this.CheckRusteditDLL.AllowBindingControlColorChanges = false;
            this.CheckRusteditDLL.AllowBindingControlLocation = true;
            this.CheckRusteditDLL.AllowCheckBoxAnimation = false;
            this.CheckRusteditDLL.AllowCheckmarkAnimation = true;
            this.CheckRusteditDLL.AllowOnHoverStates = true;
            this.CheckRusteditDLL.AutoCheck = true;
            this.CheckRusteditDLL.BackColor = System.Drawing.Color.Transparent;
            this.CheckRusteditDLL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckRusteditDLL.BackgroundImage")));
            this.CheckRusteditDLL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckRusteditDLL.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckRusteditDLL.BorderRadius = 12;
            this.CheckRusteditDLL.Checked = true;
            this.CheckRusteditDLL.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.CheckRusteditDLL.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckRusteditDLL.CustomCheckmarkImage = null;
            this.CheckRusteditDLL.Location = new System.Drawing.Point(97, 66);
            this.CheckRusteditDLL.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckRusteditDLL.Name = "CheckRusteditDLL";
            this.CheckRusteditDLL.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckRusteditDLL.OnCheck.BorderRadius = 12;
            this.CheckRusteditDLL.OnCheck.BorderThickness = 2;
            this.CheckRusteditDLL.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckRusteditDLL.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckRusteditDLL.OnCheck.CheckmarkThickness = 2;
            this.CheckRusteditDLL.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckRusteditDLL.OnDisable.BorderRadius = 12;
            this.CheckRusteditDLL.OnDisable.BorderThickness = 2;
            this.CheckRusteditDLL.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckRusteditDLL.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckRusteditDLL.OnDisable.CheckmarkThickness = 2;
            this.CheckRusteditDLL.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckRusteditDLL.OnHoverChecked.BorderRadius = 12;
            this.CheckRusteditDLL.OnHoverChecked.BorderThickness = 2;
            this.CheckRusteditDLL.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckRusteditDLL.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckRusteditDLL.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckRusteditDLL.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckRusteditDLL.OnHoverUnchecked.BorderRadius = 12;
            this.CheckRusteditDLL.OnHoverUnchecked.BorderThickness = 1;
            this.CheckRusteditDLL.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckRusteditDLL.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckRusteditDLL.OnUncheck.BorderRadius = 12;
            this.CheckRusteditDLL.OnUncheck.BorderThickness = 1;
            this.CheckRusteditDLL.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckRusteditDLL.Size = new System.Drawing.Size(21, 21);
            this.CheckRusteditDLL.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckRusteditDLL.TabIndex = 32;
            this.CheckRusteditDLL.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckRusteditDLL, "Certain custom map features require the Ext.RustEdit.dll to be installed.\r\n\r\nDown" +
        "loads the official .dll file from github.\r\nMoves the file to the carbon extentio" +
        "ns folder.\r\n");
            this.MainToolTip.SetToolTipIcon(this.CheckRusteditDLL, null);
            this.CheckRusteditDLL.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckRusteditDLL, "");
            this.CheckRusteditDLL.Click += new System.EventHandler(this.CheckRusteditDLL_Click);
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuGroupBox2.BorderRadius = 8;
            this.bunifuGroupBox2.BorderThickness = 2;
            this.bunifuGroupBox2.Controls.Add(this.bunifuLabel2);
            this.bunifuGroupBox2.Controls.Add(this.CheckNoTesting);
            this.bunifuGroupBox2.Controls.Add(this.label16);
            this.bunifuGroupBox2.Controls.Add(this.CheckRunExampleStart);
            this.bunifuGroupBox2.Controls.Add(this.label22);
            this.bunifuGroupBox2.Controls.Add(this.CheckCopyConnect);
            this.bunifuGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(10, 118);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(456, 75);
            this.bunifuGroupBox2.TabIndex = 35;
            this.bunifuGroupBox2.TabStop = false;
            this.bunifuGroupBox2.Text = "Server testing";
            this.MainToolTip.SetToolTip(this.bunifuGroupBox2, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuGroupBox2, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuGroupBox2, "");
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(25, 49);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(40, 15);
            this.bunifuLabel2.TabIndex = 39;
            this.bunifuLabel2.Text = "Disable";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.bunifuLabel2, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLabel2, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLabel2, "");
            // 
            // CheckNoTesting
            // 
            this.CheckNoTesting.AllowBindingControlAnimation = true;
            this.CheckNoTesting.AllowBindingControlColorChanges = false;
            this.CheckNoTesting.AllowBindingControlLocation = true;
            this.CheckNoTesting.AllowCheckBoxAnimation = false;
            this.CheckNoTesting.AllowCheckmarkAnimation = true;
            this.CheckNoTesting.AllowOnHoverStates = true;
            this.CheckNoTesting.AutoCheck = true;
            this.CheckNoTesting.BackColor = System.Drawing.Color.Transparent;
            this.CheckNoTesting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckNoTesting.BackgroundImage")));
            this.CheckNoTesting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckNoTesting.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckNoTesting.BorderRadius = 12;
            this.CheckNoTesting.Checked = false;
            this.CheckNoTesting.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.CheckNoTesting.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckNoTesting.CustomCheckmarkImage = null;
            this.CheckNoTesting.Location = new System.Drawing.Point(33, 22);
            this.CheckNoTesting.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckNoTesting.Name = "CheckNoTesting";
            this.CheckNoTesting.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckNoTesting.OnCheck.BorderRadius = 12;
            this.CheckNoTesting.OnCheck.BorderThickness = 2;
            this.CheckNoTesting.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckNoTesting.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckNoTesting.OnCheck.CheckmarkThickness = 2;
            this.CheckNoTesting.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckNoTesting.OnDisable.BorderRadius = 12;
            this.CheckNoTesting.OnDisable.BorderThickness = 2;
            this.CheckNoTesting.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNoTesting.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckNoTesting.OnDisable.CheckmarkThickness = 2;
            this.CheckNoTesting.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNoTesting.OnHoverChecked.BorderRadius = 12;
            this.CheckNoTesting.OnHoverChecked.BorderThickness = 2;
            this.CheckNoTesting.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNoTesting.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckNoTesting.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckNoTesting.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckNoTesting.OnHoverUnchecked.BorderRadius = 12;
            this.CheckNoTesting.OnHoverUnchecked.BorderThickness = 1;
            this.CheckNoTesting.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNoTesting.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckNoTesting.OnUncheck.BorderRadius = 12;
            this.CheckNoTesting.OnUncheck.BorderThickness = 1;
            this.CheckNoTesting.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckNoTesting.Size = new System.Drawing.Size(21, 21);
            this.CheckNoTesting.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckNoTesting.TabIndex = 38;
            this.CheckNoTesting.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckNoTesting, "");
            this.MainToolTip.SetToolTipIcon(this.CheckNoTesting, null);
            this.CheckNoTesting.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckNoTesting, "");
            this.CheckNoTesting.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.CheckNoTesting_CheckedChanged);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label16.Location = new System.Drawing.Point(124, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(248, 29);
            this.label16.TabIndex = 22;
            this.label16.Text = "Run example ProcGen server";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainToolTip.SetToolTip(this.label16, resources.GetString("label16.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.label16, null);
            this.MainToolTip.SetToolTipTitle(this.label16, "");
            // 
            // CheckRunExampleStart
            // 
            this.CheckRunExampleStart.AllowBindingControlAnimation = true;
            this.CheckRunExampleStart.AllowBindingControlColorChanges = false;
            this.CheckRunExampleStart.AllowBindingControlLocation = true;
            this.CheckRunExampleStart.AllowCheckBoxAnimation = false;
            this.CheckRunExampleStart.AllowCheckmarkAnimation = true;
            this.CheckRunExampleStart.AllowOnHoverStates = true;
            this.CheckRunExampleStart.AutoCheck = true;
            this.CheckRunExampleStart.BackColor = System.Drawing.Color.Transparent;
            this.CheckRunExampleStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckRunExampleStart.BackgroundImage")));
            this.CheckRunExampleStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckRunExampleStart.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckRunExampleStart.BorderRadius = 12;
            this.CheckRunExampleStart.Checked = true;
            this.CheckRunExampleStart.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.CheckRunExampleStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckRunExampleStart.CustomCheckmarkImage = null;
            this.CheckRunExampleStart.Location = new System.Drawing.Point(97, 18);
            this.CheckRunExampleStart.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckRunExampleStart.Name = "CheckRunExampleStart";
            this.CheckRunExampleStart.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckRunExampleStart.OnCheck.BorderRadius = 12;
            this.CheckRunExampleStart.OnCheck.BorderThickness = 2;
            this.CheckRunExampleStart.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckRunExampleStart.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckRunExampleStart.OnCheck.CheckmarkThickness = 2;
            this.CheckRunExampleStart.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckRunExampleStart.OnDisable.BorderRadius = 12;
            this.CheckRunExampleStart.OnDisable.BorderThickness = 2;
            this.CheckRunExampleStart.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckRunExampleStart.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckRunExampleStart.OnDisable.CheckmarkThickness = 2;
            this.CheckRunExampleStart.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckRunExampleStart.OnHoverChecked.BorderRadius = 12;
            this.CheckRunExampleStart.OnHoverChecked.BorderThickness = 2;
            this.CheckRunExampleStart.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckRunExampleStart.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckRunExampleStart.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckRunExampleStart.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckRunExampleStart.OnHoverUnchecked.BorderRadius = 12;
            this.CheckRunExampleStart.OnHoverUnchecked.BorderThickness = 1;
            this.CheckRunExampleStart.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckRunExampleStart.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckRunExampleStart.OnUncheck.BorderRadius = 12;
            this.CheckRunExampleStart.OnUncheck.BorderThickness = 1;
            this.CheckRunExampleStart.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckRunExampleStart.Size = new System.Drawing.Size(21, 21);
            this.CheckRunExampleStart.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckRunExampleStart.TabIndex = 30;
            this.CheckRunExampleStart.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckRunExampleStart, resources.GetString("CheckRunExampleStart.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.CheckRunExampleStart, null);
            this.CheckRunExampleStart.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckRunExampleStart, "");
            this.CheckRunExampleStart.Click += new System.EventHandler(this.CheckRunExampleStart_Click);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label22.Location = new System.Drawing.Point(124, 41);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(264, 29);
            this.label22.TabIndex = 31;
            this.label22.Text = "Copy \"connect localhost:28015\" ";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainToolTip.SetToolTip(this.label22, "Copy the connection command to your clipboard.\r\nAllows for easy connection to the" +
        " server once in game.");
            this.MainToolTip.SetToolTipIcon(this.label22, null);
            this.MainToolTip.SetToolTipTitle(this.label22, "");
            // 
            // CheckCopyConnect
            // 
            this.CheckCopyConnect.AllowBindingControlAnimation = true;
            this.CheckCopyConnect.AllowBindingControlColorChanges = false;
            this.CheckCopyConnect.AllowBindingControlLocation = true;
            this.CheckCopyConnect.AllowCheckBoxAnimation = false;
            this.CheckCopyConnect.AllowCheckmarkAnimation = true;
            this.CheckCopyConnect.AllowOnHoverStates = true;
            this.CheckCopyConnect.AutoCheck = true;
            this.CheckCopyConnect.BackColor = System.Drawing.Color.Transparent;
            this.CheckCopyConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckCopyConnect.BackgroundImage")));
            this.CheckCopyConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckCopyConnect.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckCopyConnect.BorderRadius = 12;
            this.CheckCopyConnect.Checked = true;
            this.CheckCopyConnect.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.CheckCopyConnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckCopyConnect.CustomCheckmarkImage = null;
            this.CheckCopyConnect.Location = new System.Drawing.Point(97, 45);
            this.CheckCopyConnect.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckCopyConnect.Name = "CheckCopyConnect";
            this.CheckCopyConnect.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckCopyConnect.OnCheck.BorderRadius = 12;
            this.CheckCopyConnect.OnCheck.BorderThickness = 2;
            this.CheckCopyConnect.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckCopyConnect.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckCopyConnect.OnCheck.CheckmarkThickness = 2;
            this.CheckCopyConnect.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckCopyConnect.OnDisable.BorderRadius = 12;
            this.CheckCopyConnect.OnDisable.BorderThickness = 2;
            this.CheckCopyConnect.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckCopyConnect.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckCopyConnect.OnDisable.CheckmarkThickness = 2;
            this.CheckCopyConnect.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckCopyConnect.OnHoverChecked.BorderRadius = 12;
            this.CheckCopyConnect.OnHoverChecked.BorderThickness = 2;
            this.CheckCopyConnect.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckCopyConnect.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckCopyConnect.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckCopyConnect.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckCopyConnect.OnHoverUnchecked.BorderRadius = 12;
            this.CheckCopyConnect.OnHoverUnchecked.BorderThickness = 1;
            this.CheckCopyConnect.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckCopyConnect.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckCopyConnect.OnUncheck.BorderRadius = 12;
            this.CheckCopyConnect.OnUncheck.BorderThickness = 1;
            this.CheckCopyConnect.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckCopyConnect.Size = new System.Drawing.Size(21, 21);
            this.CheckCopyConnect.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckCopyConnect.TabIndex = 32;
            this.CheckCopyConnect.ThreeState = false;
            this.MainToolTip.SetToolTip(this.CheckCopyConnect, "Copy the connection command to your clipboard.\r\nAllows for easy connection to the" +
        " server once in game.\r\n");
            this.MainToolTip.SetToolTipIcon(this.CheckCopyConnect, null);
            this.CheckCopyConnect.ToolTipText = null;
            this.MainToolTip.SetToolTipTitle(this.CheckCopyConnect, "");
            this.CheckCopyConnect.Click += new System.EventHandler(this.CheckCopyConnect_Click);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label15.Location = new System.Drawing.Point(10, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(456, 63);
            this.label15.TabIndex = 20;
            this.label15.Text = "Server files are ready. Its recommended to run the example start file first, then" +
    " start using your maps.\r\nChoose below and click finish setup.";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.label15, "");
            this.MainToolTip.SetToolTipIcon(this.label15, null);
            this.MainToolTip.SetToolTipTitle(this.label15, "");
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 10);
            this.panel4.TabIndex = 27;
            this.MainToolTip.SetToolTip(this.panel4, "");
            this.MainToolTip.SetToolTipIcon(this.panel4, null);
            this.MainToolTip.SetToolTipTitle(this.panel4, "");
            // 
            // bunifuShadowPanel5
            // 
            this.bunifuShadowPanel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel5.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel5.BorderRadius = 8;
            this.bunifuShadowPanel5.BorderThickness = 1;
            this.bunifuShadowPanel5.Controls.Add(this.label13);
            this.bunifuShadowPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel5.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel5.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel5.Location = new System.Drawing.Point(10, 5);
            this.bunifuShadowPanel5.Name = "bunifuShadowPanel5";
            this.bunifuShadowPanel5.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.bunifuShadowPanel5.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel5.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel5.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel5.ShadowDept = 2;
            this.bunifuShadowPanel5.ShadowDepth = 5;
            this.bunifuShadowPanel5.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel5.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel5.Size = new System.Drawing.Size(456, 40);
            this.bunifuShadowPanel5.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel5.TabIndex = 15;
            this.MainToolTip.SetToolTip(this.bunifuShadowPanel5, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuShadowPanel5, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuShadowPanel5, "");
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(12, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(432, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Server Files Downloaded";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.label13, "");
            this.MainToolTip.SetToolTipIcon(this.label13, null);
            this.MainToolTip.SetToolTipTitle(this.label13, "");
            // 
            // SetupcompletedHome
            // 
            this.SetupcompletedHome.AllowAnimations = true;
            this.SetupcompletedHome.AllowMouseEffects = true;
            this.SetupcompletedHome.AllowToggling = false;
            this.SetupcompletedHome.AnimationSpeed = 200;
            this.SetupcompletedHome.AutoGenerateColors = false;
            this.SetupcompletedHome.AutoRoundBorders = false;
            this.SetupcompletedHome.AutoSizeLeftIcon = true;
            this.SetupcompletedHome.AutoSizeRightIcon = true;
            this.SetupcompletedHome.BackColor = System.Drawing.Color.Transparent;
            this.SetupcompletedHome.BackColor1 = System.Drawing.Color.ForestGreen;
            this.SetupcompletedHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetupcompletedHome.BackgroundImage")));
            this.SetupcompletedHome.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupcompletedHome.ButtonText = "Finish Setup";
            this.SetupcompletedHome.ButtonTextMarginLeft = 0;
            this.SetupcompletedHome.ColorContrastOnClick = 45;
            this.SetupcompletedHome.ColorContrastOnHover = 45;
            this.SetupcompletedHome.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.SetupcompletedHome.CustomizableEdges = borderEdges10;
            this.SetupcompletedHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SetupcompletedHome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SetupcompletedHome.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupcompletedHome.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SetupcompletedHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SetupcompletedHome.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.SetupcompletedHome.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupcompletedHome.ForeColor = System.Drawing.Color.White;
            this.SetupcompletedHome.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetupcompletedHome.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SetupcompletedHome.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SetupcompletedHome.IconMarginLeft = 11;
            this.SetupcompletedHome.IconPadding = 10;
            this.SetupcompletedHome.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SetupcompletedHome.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SetupcompletedHome.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SetupcompletedHome.IconSize = 25;
            this.SetupcompletedHome.IdleBorderColor = System.Drawing.Color.ForestGreen;
            this.SetupcompletedHome.IdleBorderRadius = 3;
            this.SetupcompletedHome.IdleBorderThickness = 1;
            this.SetupcompletedHome.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.SetupcompletedHome.IdleIconLeftImage = null;
            this.SetupcompletedHome.IdleIconRightImage = null;
            this.SetupcompletedHome.IndicateFocus = false;
            this.SetupcompletedHome.Location = new System.Drawing.Point(10, 408);
            this.SetupcompletedHome.Name = "SetupcompletedHome";
            this.SetupcompletedHome.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SetupcompletedHome.OnDisabledState.BorderRadius = 3;
            this.SetupcompletedHome.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupcompletedHome.OnDisabledState.BorderThickness = 1;
            this.SetupcompletedHome.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SetupcompletedHome.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SetupcompletedHome.OnDisabledState.IconLeftImage = null;
            this.SetupcompletedHome.OnDisabledState.IconRightImage = null;
            this.SetupcompletedHome.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupcompletedHome.onHoverState.BorderRadius = 3;
            this.SetupcompletedHome.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupcompletedHome.onHoverState.BorderThickness = 1;
            this.SetupcompletedHome.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SetupcompletedHome.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SetupcompletedHome.onHoverState.IconLeftImage = null;
            this.SetupcompletedHome.onHoverState.IconRightImage = null;
            this.SetupcompletedHome.OnIdleState.BorderColor = System.Drawing.Color.ForestGreen;
            this.SetupcompletedHome.OnIdleState.BorderRadius = 3;
            this.SetupcompletedHome.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupcompletedHome.OnIdleState.BorderThickness = 1;
            this.SetupcompletedHome.OnIdleState.FillColor = System.Drawing.Color.ForestGreen;
            this.SetupcompletedHome.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SetupcompletedHome.OnIdleState.IconLeftImage = null;
            this.SetupcompletedHome.OnIdleState.IconRightImage = null;
            this.SetupcompletedHome.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SetupcompletedHome.OnPressedState.BorderRadius = 3;
            this.SetupcompletedHome.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SetupcompletedHome.OnPressedState.BorderThickness = 1;
            this.SetupcompletedHome.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SetupcompletedHome.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SetupcompletedHome.OnPressedState.IconLeftImage = null;
            this.SetupcompletedHome.OnPressedState.IconRightImage = null;
            this.SetupcompletedHome.Size = new System.Drawing.Size(456, 27);
            this.SetupcompletedHome.TabIndex = 17;
            this.SetupcompletedHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SetupcompletedHome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetupcompletedHome.TextMarginLeft = 0;
            this.SetupcompletedHome.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.SetupcompletedHome, "");
            this.MainToolTip.SetToolTipIcon(this.SetupcompletedHome, null);
            this.MainToolTip.SetToolTipTitle(this.SetupcompletedHome, "");
            this.SetupcompletedHome.UseDefaultRadiusAndThickness = true;
            this.SetupcompletedHome.Click += new System.EventHandler(this.SetupcompletedHome_Click);
            // 
            // FirstRunPage
            // 
            this.FirstRunPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.FirstRunPage.Controls.Add(this.ImageButtonDiscord);
            this.FirstRunPage.Controls.Add(this.bunifuImageButton1);
            this.FirstRunPage.Controls.Add(this.ImageButtonGithub);
            this.FirstRunPage.Controls.Add(this.pictureBox1);
            this.FirstRunPage.Controls.Add(this.label31);
            this.FirstRunPage.Controls.Add(this.label27);
            this.FirstRunPage.Controls.Add(this.bunifuShadowPanel9);
            this.FirstRunPage.Controls.Add(this.bunifuShadowPanel8);
            this.FirstRunPage.Controls.Add(this.bunifuShadowPanel7);
            this.FirstRunPage.Controls.Add(this.bunifuSeparator3);
            this.FirstRunPage.Location = new System.Drawing.Point(4, 4);
            this.FirstRunPage.Name = "FirstRunPage";
            this.FirstRunPage.Padding = new System.Windows.Forms.Padding(10);
            this.FirstRunPage.Size = new System.Drawing.Size(476, 440);
            this.FirstRunPage.TabIndex = 5;
            this.FirstRunPage.Text = "FirstRun";
            this.MainToolTip.SetToolTip(this.FirstRunPage, "");
            this.MainToolTip.SetToolTipIcon(this.FirstRunPage, null);
            this.MainToolTip.SetToolTipTitle(this.FirstRunPage, "");
            // 
            // ImageButtonDiscord
            // 
            this.ImageButtonDiscord.ActiveImage = null;
            this.ImageButtonDiscord.AllowAnimations = true;
            this.ImageButtonDiscord.AllowBuffering = false;
            this.ImageButtonDiscord.AllowToggling = false;
            this.ImageButtonDiscord.AllowZooming = true;
            this.ImageButtonDiscord.AllowZoomingOnFocus = false;
            this.ImageButtonDiscord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageButtonDiscord.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonDiscord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonDiscord.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonDiscord.ErrorImage")));
            this.ImageButtonDiscord.FadeWhenInactive = false;
            this.ImageButtonDiscord.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonDiscord.Image = global::EasyMapTestRust.Properties.Resources.DIscord;
            this.ImageButtonDiscord.ImageActive = null;
            this.ImageButtonDiscord.ImageLocation = null;
            this.ImageButtonDiscord.ImageMargin = 20;
            this.ImageButtonDiscord.ImageSize = new System.Drawing.Size(50, 39);
            this.ImageButtonDiscord.ImageZoomSize = new System.Drawing.Size(70, 59);
            this.ImageButtonDiscord.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonDiscord.InitialImage")));
            this.ImageButtonDiscord.Location = new System.Drawing.Point(355, 384);
            this.ImageButtonDiscord.Name = "ImageButtonDiscord";
            this.ImageButtonDiscord.Rotation = 0;
            this.ImageButtonDiscord.ShowActiveImage = true;
            this.ImageButtonDiscord.ShowCursorChanges = true;
            this.ImageButtonDiscord.ShowImageBorders = true;
            this.ImageButtonDiscord.ShowSizeMarkers = false;
            this.ImageButtonDiscord.Size = new System.Drawing.Size(70, 59);
            this.ImageButtonDiscord.TabIndex = 34;
            this.MainToolTip.SetToolTip(this.ImageButtonDiscord, "");
            this.MainToolTip.SetToolTipIcon(this.ImageButtonDiscord, null);
            this.ImageButtonDiscord.ToolTipText = "";
            this.MainToolTip.SetToolTipTitle(this.ImageButtonDiscord, "");
            this.ImageButtonDiscord.WaitOnLoad = false;
            this.ImageButtonDiscord.Zoom = 20;
            this.ImageButtonDiscord.ZoomSpeed = 10;
            this.ImageButtonDiscord.Click += new System.EventHandler(this.ImageButtonDiscord_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::EasyMapTestRust.Properties.Resources.Template___copy_this__3_;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(142, 79);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(162, 99);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(156, 331);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(162, 99);
            this.bunifuImageButton1.TabIndex = 34;
            this.MainToolTip.SetToolTip(this.bunifuImageButton1, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuImageButton1, null);
            this.bunifuImageButton1.ToolTipText = "";
            this.MainToolTip.SetToolTipTitle(this.bunifuImageButton1, "");
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.ImageButtonGithub_Click);
            // 
            // ImageButtonGithub
            // 
            this.ImageButtonGithub.ActiveImage = null;
            this.ImageButtonGithub.AllowAnimations = true;
            this.ImageButtonGithub.AllowBuffering = false;
            this.ImageButtonGithub.AllowToggling = false;
            this.ImageButtonGithub.AllowZooming = true;
            this.ImageButtonGithub.AllowZoomingOnFocus = false;
            this.ImageButtonGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageButtonGithub.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonGithub.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonGithub.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonGithub.ErrorImage")));
            this.ImageButtonGithub.FadeWhenInactive = false;
            this.ImageButtonGithub.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonGithub.Image = global::EasyMapTestRust.Properties.Resources.Github;
            this.ImageButtonGithub.ImageActive = null;
            this.ImageButtonGithub.ImageLocation = null;
            this.ImageButtonGithub.ImageMargin = 20;
            this.ImageButtonGithub.ImageSize = new System.Drawing.Size(39, 39);
            this.ImageButtonGithub.ImageZoomSize = new System.Drawing.Size(59, 59);
            this.ImageButtonGithub.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonGithub.InitialImage")));
            this.ImageButtonGithub.Location = new System.Drawing.Point(389, 324);
            this.ImageButtonGithub.Name = "ImageButtonGithub";
            this.ImageButtonGithub.Rotation = 0;
            this.ImageButtonGithub.ShowActiveImage = true;
            this.ImageButtonGithub.ShowCursorChanges = true;
            this.ImageButtonGithub.ShowImageBorders = true;
            this.ImageButtonGithub.ShowSizeMarkers = false;
            this.ImageButtonGithub.Size = new System.Drawing.Size(59, 59);
            this.ImageButtonGithub.TabIndex = 34;
            this.MainToolTip.SetToolTip(this.ImageButtonGithub, "");
            this.MainToolTip.SetToolTipIcon(this.ImageButtonGithub, null);
            this.ImageButtonGithub.ToolTipText = "";
            this.MainToolTip.SetToolTipTitle(this.ImageButtonGithub, "");
            this.ImageButtonGithub.WaitOnLoad = false;
            this.ImageButtonGithub.Zoom = 20;
            this.ImageButtonGithub.ZoomSpeed = 10;
            this.ImageButtonGithub.Click += new System.EventHandler(this.ImageButtonGithub_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::EasyMapTestRust.Properties.Resources.icons8_question_mark_64;
            this.pictureBox1.Location = new System.Drawing.Point(323, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.MainToolTip.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            this.MainToolTip.SetToolTipIcon(this.pictureBox1, global::EasyMapTestRust.Properties.Resources.icons8_update_64);
            this.MainToolTip.SetToolTipTitle(this.pictureBox1, "Welcome to DropLaunch!");
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label31.Location = new System.Drawing.Point(13, 309);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(180, 98);
            this.label31.TabIndex = 31;
            this.label31.Text = "Creates a folder for:\r\n-SteamCMD\r\n-Server Files\r\n-Maps";
            this.MainToolTip.SetToolTip(this.label31, "");
            this.MainToolTip.SetToolTipIcon(this.label31, null);
            this.MainToolTip.SetToolTipTitle(this.label31, "");
            // 
            // label27
            // 
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.label27.Location = new System.Drawing.Point(10, 50);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(456, 42);
            this.label27.TabIndex = 28;
            this.label27.Text = "Choose one of the options below";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.label27, "");
            this.MainToolTip.SetToolTipIcon(this.label27, null);
            this.MainToolTip.SetToolTipTitle(this.label27, "");
            // 
            // bunifuShadowPanel9
            // 
            this.bunifuShadowPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuShadowPanel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel9.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel9.BorderRadius = 8;
            this.bunifuShadowPanel9.BorderThickness = 1;
            this.bunifuShadowPanel9.Controls.Add(this.FirstRunCustomInstall);
            this.bunifuShadowPanel9.Controls.Add(this.bunifuLabel9);
            this.bunifuShadowPanel9.Controls.Add(this.bunifuSeparator12);
            this.bunifuShadowPanel9.Controls.Add(this.bunifuLabel10);
            this.bunifuShadowPanel9.Controls.Add(this.bunifuSeparator13);
            this.bunifuShadowPanel9.Controls.Add(this.bunifuLabel11);
            this.bunifuShadowPanel9.Controls.Add(this.bunifuSeparator14);
            this.bunifuShadowPanel9.Controls.Add(this.bunifuShadowPanel11);
            this.bunifuShadowPanel9.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel9.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel9.Location = new System.Drawing.Point(273, 99);
            this.bunifuShadowPanel9.Name = "bunifuShadowPanel9";
            this.bunifuShadowPanel9.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuShadowPanel9.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel9.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel9.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel9.ShadowDept = 2;
            this.bunifuShadowPanel9.ShadowDepth = 3;
            this.bunifuShadowPanel9.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel9.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel9.Size = new System.Drawing.Size(193, 208);
            this.bunifuShadowPanel9.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel9.TabIndex = 14;
            this.MainToolTip.SetToolTip(this.bunifuShadowPanel9, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuShadowPanel9, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuShadowPanel9, "");
            // 
            // FirstRunCustomInstall
            // 
            this.FirstRunCustomInstall.AllowAnimations = true;
            this.FirstRunCustomInstall.AllowMouseEffects = true;
            this.FirstRunCustomInstall.AllowToggling = false;
            this.FirstRunCustomInstall.AnimationSpeed = 200;
            this.FirstRunCustomInstall.AutoGenerateColors = false;
            this.FirstRunCustomInstall.AutoRoundBorders = false;
            this.FirstRunCustomInstall.AutoSizeLeftIcon = true;
            this.FirstRunCustomInstall.AutoSizeRightIcon = true;
            this.FirstRunCustomInstall.BackColor = System.Drawing.Color.Transparent;
            this.FirstRunCustomInstall.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.FirstRunCustomInstall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstRunCustomInstall.BackgroundImage")));
            this.FirstRunCustomInstall.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunCustomInstall.ButtonText = "Custom";
            this.FirstRunCustomInstall.ButtonTextMarginLeft = 0;
            this.FirstRunCustomInstall.ColorContrastOnClick = 45;
            this.FirstRunCustomInstall.ColorContrastOnHover = 45;
            this.FirstRunCustomInstall.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.FirstRunCustomInstall.CustomizableEdges = borderEdges11;
            this.FirstRunCustomInstall.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FirstRunCustomInstall.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FirstRunCustomInstall.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FirstRunCustomInstall.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FirstRunCustomInstall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FirstRunCustomInstall.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.FirstRunCustomInstall.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstRunCustomInstall.ForeColor = System.Drawing.Color.White;
            this.FirstRunCustomInstall.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstRunCustomInstall.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.FirstRunCustomInstall.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.FirstRunCustomInstall.IconMarginLeft = 11;
            this.FirstRunCustomInstall.IconPadding = 10;
            this.FirstRunCustomInstall.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FirstRunCustomInstall.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.FirstRunCustomInstall.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.FirstRunCustomInstall.IconSize = 25;
            this.FirstRunCustomInstall.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.FirstRunCustomInstall.IdleBorderRadius = 8;
            this.FirstRunCustomInstall.IdleBorderThickness = 1;
            this.FirstRunCustomInstall.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.FirstRunCustomInstall.IdleIconLeftImage = null;
            this.FirstRunCustomInstall.IdleIconRightImage = null;
            this.FirstRunCustomInstall.IndicateFocus = false;
            this.FirstRunCustomInstall.Location = new System.Drawing.Point(10, 171);
            this.FirstRunCustomInstall.Name = "FirstRunCustomInstall";
            this.FirstRunCustomInstall.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FirstRunCustomInstall.OnDisabledState.BorderRadius = 8;
            this.FirstRunCustomInstall.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunCustomInstall.OnDisabledState.BorderThickness = 1;
            this.FirstRunCustomInstall.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FirstRunCustomInstall.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FirstRunCustomInstall.OnDisabledState.IconLeftImage = null;
            this.FirstRunCustomInstall.OnDisabledState.IconRightImage = null;
            this.FirstRunCustomInstall.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FirstRunCustomInstall.onHoverState.BorderRadius = 8;
            this.FirstRunCustomInstall.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunCustomInstall.onHoverState.BorderThickness = 1;
            this.FirstRunCustomInstall.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FirstRunCustomInstall.onHoverState.ForeColor = System.Drawing.Color.White;
            this.FirstRunCustomInstall.onHoverState.IconLeftImage = null;
            this.FirstRunCustomInstall.onHoverState.IconRightImage = null;
            this.FirstRunCustomInstall.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.FirstRunCustomInstall.OnIdleState.BorderRadius = 8;
            this.FirstRunCustomInstall.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunCustomInstall.OnIdleState.BorderThickness = 1;
            this.FirstRunCustomInstall.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.FirstRunCustomInstall.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.FirstRunCustomInstall.OnIdleState.IconLeftImage = null;
            this.FirstRunCustomInstall.OnIdleState.IconRightImage = null;
            this.FirstRunCustomInstall.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.FirstRunCustomInstall.OnPressedState.BorderRadius = 8;
            this.FirstRunCustomInstall.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunCustomInstall.OnPressedState.BorderThickness = 1;
            this.FirstRunCustomInstall.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.FirstRunCustomInstall.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.FirstRunCustomInstall.OnPressedState.IconLeftImage = null;
            this.FirstRunCustomInstall.OnPressedState.IconRightImage = null;
            this.FirstRunCustomInstall.Size = new System.Drawing.Size(173, 27);
            this.FirstRunCustomInstall.TabIndex = 40;
            this.FirstRunCustomInstall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirstRunCustomInstall.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstRunCustomInstall.TextMarginLeft = 0;
            this.FirstRunCustomInstall.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.FirstRunCustomInstall, "");
            this.MainToolTip.SetToolTipIcon(this.FirstRunCustomInstall, null);
            this.MainToolTip.SetToolTipTitle(this.FirstRunCustomInstall, "");
            this.FirstRunCustomInstall.UseDefaultRadiusAndThickness = true;
            this.FirstRunCustomInstall.Click += new System.EventHandler(this.FirstRunCustomInstall_Click);
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.AutoSize = false;
            this.bunifuLabel9.CursorType = null;
            this.bunifuLabel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel9.Location = new System.Drawing.Point(10, 138);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(173, 31);
            this.bunifuLabel9.TabIndex = 36;
            this.bunifuLabel9.Text = "Choose maps directory";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.bunifuLabel9, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLabel9, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLabel9, "");
            // 
            // bunifuSeparator12
            // 
            this.bunifuSeparator12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator12.BackgroundImage")));
            this.bunifuSeparator12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator12.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator12.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator12.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator12.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator12.LineThickness = 1;
            this.bunifuSeparator12.Location = new System.Drawing.Point(10, 128);
            this.bunifuSeparator12.Name = "bunifuSeparator12";
            this.bunifuSeparator12.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator12.Size = new System.Drawing.Size(173, 10);
            this.bunifuSeparator12.TabIndex = 39;
            this.MainToolTip.SetToolTip(this.bunifuSeparator12, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator12, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator12, "");
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.AutoSize = false;
            this.bunifuLabel10.CursorType = null;
            this.bunifuLabel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel10.Location = new System.Drawing.Point(10, 97);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(173, 31);
            this.bunifuLabel10.TabIndex = 35;
            this.bunifuLabel10.Text = "Choose Server files directory";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.bunifuLabel10, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLabel10, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLabel10, "");
            // 
            // bunifuSeparator13
            // 
            this.bunifuSeparator13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator13.BackgroundImage")));
            this.bunifuSeparator13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator13.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator13.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator13.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator13.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator13.LineThickness = 1;
            this.bunifuSeparator13.Location = new System.Drawing.Point(10, 87);
            this.bunifuSeparator13.Name = "bunifuSeparator13";
            this.bunifuSeparator13.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator13.Size = new System.Drawing.Size(173, 10);
            this.bunifuSeparator13.TabIndex = 37;
            this.MainToolTip.SetToolTip(this.bunifuSeparator13, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator13, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator13, "");
            // 
            // bunifuLabel11
            // 
            this.bunifuLabel11.AllowParentOverrides = false;
            this.bunifuLabel11.AutoEllipsis = false;
            this.bunifuLabel11.AutoSize = false;
            this.bunifuLabel11.CursorType = null;
            this.bunifuLabel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel11.Location = new System.Drawing.Point(10, 56);
            this.bunifuLabel11.Name = "bunifuLabel11";
            this.bunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel11.Size = new System.Drawing.Size(173, 31);
            this.bunifuLabel11.TabIndex = 34;
            this.bunifuLabel11.Text = "Choose SteamCMD folder\r\nUse existing or download";
            this.bunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.bunifuLabel11, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLabel11, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLabel11, "");
            // 
            // bunifuSeparator14
            // 
            this.bunifuSeparator14.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator14.BackgroundImage")));
            this.bunifuSeparator14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator14.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator14.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator14.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator14.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator14.LineThickness = 1;
            this.bunifuSeparator14.Location = new System.Drawing.Point(10, 46);
            this.bunifuSeparator14.Name = "bunifuSeparator14";
            this.bunifuSeparator14.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator14.Size = new System.Drawing.Size(173, 10);
            this.bunifuSeparator14.TabIndex = 38;
            this.MainToolTip.SetToolTip(this.bunifuSeparator14, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator14, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator14, "");
            // 
            // bunifuShadowPanel11
            // 
            this.bunifuShadowPanel11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel11.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel11.BorderRadius = 8;
            this.bunifuShadowPanel11.BorderThickness = 1;
            this.bunifuShadowPanel11.Controls.Add(this.label30);
            this.bunifuShadowPanel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel11.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel11.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel11.Location = new System.Drawing.Point(10, 10);
            this.bunifuShadowPanel11.Name = "bunifuShadowPanel11";
            this.bunifuShadowPanel11.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.bunifuShadowPanel11.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel11.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel11.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuShadowPanel11.ShadowDept = 2;
            this.bunifuShadowPanel11.ShadowDepth = 4;
            this.bunifuShadowPanel11.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel11.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel11.Size = new System.Drawing.Size(173, 36);
            this.bunifuShadowPanel11.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel11.TabIndex = 15;
            this.MainToolTip.SetToolTip(this.bunifuShadowPanel11, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuShadowPanel11, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuShadowPanel11, "");
            // 
            // label30
            // 
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(12, 10);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(149, 16);
            this.label30.TabIndex = 5;
            this.label30.Text = "Custom install";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.label30, "");
            this.MainToolTip.SetToolTipIcon(this.label30, null);
            this.MainToolTip.SetToolTipTitle(this.label30, "");
            // 
            // bunifuShadowPanel8
            // 
            this.bunifuShadowPanel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel8.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel8.BorderRadius = 8;
            this.bunifuShadowPanel8.BorderThickness = 1;
            this.bunifuShadowPanel8.Controls.Add(this.FirstRunOneClick);
            this.bunifuShadowPanel8.Controls.Add(this.bunifuLabel8);
            this.bunifuShadowPanel8.Controls.Add(this.bunifuSeparator9);
            this.bunifuShadowPanel8.Controls.Add(this.bunifuLabel7);
            this.bunifuShadowPanel8.Controls.Add(this.bunifuSeparator6);
            this.bunifuShadowPanel8.Controls.Add(this.bunifuLabel6);
            this.bunifuShadowPanel8.Controls.Add(this.bunifuSeparator8);
            this.bunifuShadowPanel8.Controls.Add(this.bunifuShadowPanel10);
            this.bunifuShadowPanel8.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel8.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel8.Location = new System.Drawing.Point(10, 99);
            this.bunifuShadowPanel8.Name = "bunifuShadowPanel8";
            this.bunifuShadowPanel8.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuShadowPanel8.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel8.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel8.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel8.ShadowDept = 2;
            this.bunifuShadowPanel8.ShadowDepth = 3;
            this.bunifuShadowPanel8.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel8.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel8.Size = new System.Drawing.Size(193, 208);
            this.bunifuShadowPanel8.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel8.TabIndex = 14;
            this.MainToolTip.SetToolTip(this.bunifuShadowPanel8, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuShadowPanel8, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuShadowPanel8, "");
            // 
            // FirstRunOneClick
            // 
            this.FirstRunOneClick.AllowAnimations = true;
            this.FirstRunOneClick.AllowMouseEffects = true;
            this.FirstRunOneClick.AllowToggling = false;
            this.FirstRunOneClick.AnimationSpeed = 200;
            this.FirstRunOneClick.AutoGenerateColors = false;
            this.FirstRunOneClick.AutoRoundBorders = false;
            this.FirstRunOneClick.AutoSizeLeftIcon = true;
            this.FirstRunOneClick.AutoSizeRightIcon = true;
            this.FirstRunOneClick.BackColor = System.Drawing.Color.Transparent;
            this.FirstRunOneClick.BackColor1 = System.Drawing.Color.ForestGreen;
            this.FirstRunOneClick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstRunOneClick.BackgroundImage")));
            this.FirstRunOneClick.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunOneClick.ButtonText = "One-Click";
            this.FirstRunOneClick.ButtonTextMarginLeft = 0;
            this.FirstRunOneClick.ColorContrastOnClick = 45;
            this.FirstRunOneClick.ColorContrastOnHover = 45;
            this.FirstRunOneClick.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.FirstRunOneClick.CustomizableEdges = borderEdges12;
            this.FirstRunOneClick.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FirstRunOneClick.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FirstRunOneClick.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FirstRunOneClick.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FirstRunOneClick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FirstRunOneClick.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.FirstRunOneClick.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstRunOneClick.ForeColor = System.Drawing.Color.White;
            this.FirstRunOneClick.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstRunOneClick.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.FirstRunOneClick.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.FirstRunOneClick.IconMarginLeft = 11;
            this.FirstRunOneClick.IconPadding = 10;
            this.FirstRunOneClick.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FirstRunOneClick.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.FirstRunOneClick.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.FirstRunOneClick.IconSize = 25;
            this.FirstRunOneClick.IdleBorderColor = System.Drawing.Color.ForestGreen;
            this.FirstRunOneClick.IdleBorderRadius = 8;
            this.FirstRunOneClick.IdleBorderThickness = 1;
            this.FirstRunOneClick.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.FirstRunOneClick.IdleIconLeftImage = null;
            this.FirstRunOneClick.IdleIconRightImage = null;
            this.FirstRunOneClick.IndicateFocus = false;
            this.FirstRunOneClick.Location = new System.Drawing.Point(10, 171);
            this.FirstRunOneClick.Name = "FirstRunOneClick";
            this.FirstRunOneClick.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FirstRunOneClick.OnDisabledState.BorderRadius = 8;
            this.FirstRunOneClick.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunOneClick.OnDisabledState.BorderThickness = 1;
            this.FirstRunOneClick.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FirstRunOneClick.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FirstRunOneClick.OnDisabledState.IconLeftImage = null;
            this.FirstRunOneClick.OnDisabledState.IconRightImage = null;
            this.FirstRunOneClick.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FirstRunOneClick.onHoverState.BorderRadius = 8;
            this.FirstRunOneClick.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunOneClick.onHoverState.BorderThickness = 1;
            this.FirstRunOneClick.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FirstRunOneClick.onHoverState.ForeColor = System.Drawing.Color.White;
            this.FirstRunOneClick.onHoverState.IconLeftImage = null;
            this.FirstRunOneClick.onHoverState.IconRightImage = null;
            this.FirstRunOneClick.OnIdleState.BorderColor = System.Drawing.Color.ForestGreen;
            this.FirstRunOneClick.OnIdleState.BorderRadius = 8;
            this.FirstRunOneClick.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunOneClick.OnIdleState.BorderThickness = 1;
            this.FirstRunOneClick.OnIdleState.FillColor = System.Drawing.Color.ForestGreen;
            this.FirstRunOneClick.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.FirstRunOneClick.OnIdleState.IconLeftImage = null;
            this.FirstRunOneClick.OnIdleState.IconRightImage = null;
            this.FirstRunOneClick.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.FirstRunOneClick.OnPressedState.BorderRadius = 8;
            this.FirstRunOneClick.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunOneClick.OnPressedState.BorderThickness = 1;
            this.FirstRunOneClick.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.FirstRunOneClick.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.FirstRunOneClick.OnPressedState.IconLeftImage = null;
            this.FirstRunOneClick.OnPressedState.IconRightImage = null;
            this.FirstRunOneClick.Size = new System.Drawing.Size(173, 27);
            this.FirstRunOneClick.TabIndex = 34;
            this.FirstRunOneClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirstRunOneClick.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstRunOneClick.TextMarginLeft = 0;
            this.FirstRunOneClick.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.FirstRunOneClick, "");
            this.MainToolTip.SetToolTipIcon(this.FirstRunOneClick, null);
            this.MainToolTip.SetToolTipTitle(this.FirstRunOneClick, "");
            this.FirstRunOneClick.UseDefaultRadiusAndThickness = true;
            this.FirstRunOneClick.Click += new System.EventHandler(this.FirstRunOneClick_Click);
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.AutoSize = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel8.Location = new System.Drawing.Point(10, 138);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(173, 31);
            this.bunifuLabel8.TabIndex = 17;
            this.bunifuLabel8.Text = "Set maps directory to\r\ncurrent folder";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.bunifuLabel8, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLabel8, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLabel8, "");
            // 
            // bunifuSeparator9
            // 
            this.bunifuSeparator9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator9.BackgroundImage")));
            this.bunifuSeparator9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator9.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator9.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator9.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator9.LineThickness = 1;
            this.bunifuSeparator9.Location = new System.Drawing.Point(10, 128);
            this.bunifuSeparator9.Name = "bunifuSeparator9";
            this.bunifuSeparator9.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator9.Size = new System.Drawing.Size(173, 10);
            this.bunifuSeparator9.TabIndex = 33;
            this.MainToolTip.SetToolTip(this.bunifuSeparator9, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator9, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator9, "");
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.AutoSize = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel7.Location = new System.Drawing.Point(10, 97);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(173, 31);
            this.bunifuLabel7.TabIndex = 16;
            this.bunifuLabel7.Text = "Download Server Files\r\nto current folder";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.bunifuLabel7, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLabel7, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLabel7, "");
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator6.BackgroundImage")));
            this.bunifuSeparator6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator6.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator6.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(10, 87);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator6.Size = new System.Drawing.Size(173, 10);
            this.bunifuSeparator6.TabIndex = 31;
            this.MainToolTip.SetToolTip(this.bunifuSeparator6, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator6, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator6, "");
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.AutoSize = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.Location = new System.Drawing.Point(10, 56);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(173, 31);
            this.bunifuLabel6.TabIndex = 15;
            this.bunifuLabel6.Text = "Download SteamCMD \r\nto current folder";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.MainToolTip.SetToolTip(this.bunifuLabel6, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuLabel6, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuLabel6, "");
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator8.BackgroundImage")));
            this.bunifuSeparator8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator8.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator8.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator8.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(10, 46);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator8.Size = new System.Drawing.Size(173, 10);
            this.bunifuSeparator8.TabIndex = 32;
            this.MainToolTip.SetToolTip(this.bunifuSeparator8, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator8, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator8, "");
            // 
            // bunifuShadowPanel10
            // 
            this.bunifuShadowPanel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel10.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel10.BorderRadius = 8;
            this.bunifuShadowPanel10.BorderThickness = 1;
            this.bunifuShadowPanel10.Controls.Add(this.label29);
            this.bunifuShadowPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel10.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel10.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel10.Location = new System.Drawing.Point(10, 10);
            this.bunifuShadowPanel10.Name = "bunifuShadowPanel10";
            this.bunifuShadowPanel10.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.bunifuShadowPanel10.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel10.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel10.ShadowColor = System.Drawing.Color.OliveDrab;
            this.bunifuShadowPanel10.ShadowDept = 2;
            this.bunifuShadowPanel10.ShadowDepth = 4;
            this.bunifuShadowPanel10.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel10.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel10.Size = new System.Drawing.Size(173, 36);
            this.bunifuShadowPanel10.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel10.TabIndex = 14;
            this.MainToolTip.SetToolTip(this.bunifuShadowPanel10, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuShadowPanel10, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuShadowPanel10, "");
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(12, 10);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(149, 16);
            this.label29.TabIndex = 5;
            this.label29.Text = "One-Click install";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.label29, "");
            this.MainToolTip.SetToolTipIcon(this.label29, null);
            this.MainToolTip.SetToolTipTitle(this.label29, "");
            // 
            // bunifuShadowPanel7
            // 
            this.bunifuShadowPanel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel7.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel7.BorderRadius = 8;
            this.bunifuShadowPanel7.BorderThickness = 1;
            this.bunifuShadowPanel7.Controls.Add(this.FirstRunHomeButton);
            this.bunifuShadowPanel7.Controls.Add(this.label26);
            this.bunifuShadowPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel7.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel7.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel7.Location = new System.Drawing.Point(10, 10);
            this.bunifuShadowPanel7.Name = "bunifuShadowPanel7";
            this.bunifuShadowPanel7.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.bunifuShadowPanel7.PanelColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel7.PanelColor2 = System.Drawing.SystemColors.ScrollBar;
            this.bunifuShadowPanel7.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel7.ShadowDept = 2;
            this.bunifuShadowPanel7.ShadowDepth = 5;
            this.bunifuShadowPanel7.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel7.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel7.Size = new System.Drawing.Size(456, 40);
            this.bunifuShadowPanel7.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel7.TabIndex = 13;
            this.MainToolTip.SetToolTip(this.bunifuShadowPanel7, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuShadowPanel7, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuShadowPanel7, "");
            // 
            // FirstRunHomeButton
            // 
            this.FirstRunHomeButton.AllowAnimations = true;
            this.FirstRunHomeButton.AllowMouseEffects = true;
            this.FirstRunHomeButton.AllowToggling = false;
            this.FirstRunHomeButton.AnimationSpeed = 200;
            this.FirstRunHomeButton.AutoGenerateColors = false;
            this.FirstRunHomeButton.AutoRoundBorders = false;
            this.FirstRunHomeButton.AutoSizeLeftIcon = true;
            this.FirstRunHomeButton.AutoSizeRightIcon = true;
            this.FirstRunHomeButton.BackColor = System.Drawing.Color.Transparent;
            this.FirstRunHomeButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.FirstRunHomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstRunHomeButton.BackgroundImage")));
            this.FirstRunHomeButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunHomeButton.ButtonText = "Home";
            this.FirstRunHomeButton.ButtonTextMarginLeft = 0;
            this.FirstRunHomeButton.ColorContrastOnClick = 45;
            this.FirstRunHomeButton.ColorContrastOnHover = 45;
            this.FirstRunHomeButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.FirstRunHomeButton.CustomizableEdges = borderEdges13;
            this.FirstRunHomeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FirstRunHomeButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FirstRunHomeButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FirstRunHomeButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FirstRunHomeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstRunHomeButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.FirstRunHomeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstRunHomeButton.ForeColor = System.Drawing.Color.White;
            this.FirstRunHomeButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstRunHomeButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.FirstRunHomeButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.FirstRunHomeButton.IconMarginLeft = 11;
            this.FirstRunHomeButton.IconPadding = 10;
            this.FirstRunHomeButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FirstRunHomeButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.FirstRunHomeButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.FirstRunHomeButton.IconSize = 25;
            this.FirstRunHomeButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.FirstRunHomeButton.IdleBorderRadius = 8;
            this.FirstRunHomeButton.IdleBorderThickness = 1;
            this.FirstRunHomeButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.FirstRunHomeButton.IdleIconLeftImage = null;
            this.FirstRunHomeButton.IdleIconRightImage = null;
            this.FirstRunHomeButton.IndicateFocus = false;
            this.FirstRunHomeButton.Location = new System.Drawing.Point(12, 10);
            this.FirstRunHomeButton.Name = "FirstRunHomeButton";
            this.FirstRunHomeButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FirstRunHomeButton.OnDisabledState.BorderRadius = 8;
            this.FirstRunHomeButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunHomeButton.OnDisabledState.BorderThickness = 1;
            this.FirstRunHomeButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FirstRunHomeButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FirstRunHomeButton.OnDisabledState.IconLeftImage = null;
            this.FirstRunHomeButton.OnDisabledState.IconRightImage = null;
            this.FirstRunHomeButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FirstRunHomeButton.onHoverState.BorderRadius = 8;
            this.FirstRunHomeButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunHomeButton.onHoverState.BorderThickness = 1;
            this.FirstRunHomeButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FirstRunHomeButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.FirstRunHomeButton.onHoverState.IconLeftImage = null;
            this.FirstRunHomeButton.onHoverState.IconRightImage = null;
            this.FirstRunHomeButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.FirstRunHomeButton.OnIdleState.BorderRadius = 8;
            this.FirstRunHomeButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunHomeButton.OnIdleState.BorderThickness = 1;
            this.FirstRunHomeButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.FirstRunHomeButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.FirstRunHomeButton.OnIdleState.IconLeftImage = null;
            this.FirstRunHomeButton.OnIdleState.IconRightImage = null;
            this.FirstRunHomeButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.FirstRunHomeButton.OnPressedState.BorderRadius = 8;
            this.FirstRunHomeButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.FirstRunHomeButton.OnPressedState.BorderThickness = 1;
            this.FirstRunHomeButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.FirstRunHomeButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.FirstRunHomeButton.OnPressedState.IconLeftImage = null;
            this.FirstRunHomeButton.OnPressedState.IconRightImage = null;
            this.FirstRunHomeButton.Size = new System.Drawing.Size(68, 20);
            this.FirstRunHomeButton.TabIndex = 6;
            this.FirstRunHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirstRunHomeButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstRunHomeButton.TextMarginLeft = 0;
            this.FirstRunHomeButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.MainToolTip.SetToolTip(this.FirstRunHomeButton, "");
            this.MainToolTip.SetToolTipIcon(this.FirstRunHomeButton, null);
            this.MainToolTip.SetToolTipTitle(this.FirstRunHomeButton, "");
            this.FirstRunHomeButton.UseDefaultRadiusAndThickness = true;
            this.FirstRunHomeButton.Click += new System.EventHandler(this.FirstRunHomeButton_Click);
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(12, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(432, 20);
            this.label26.TabIndex = 5;
            this.label26.Text = "Install Required Files";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.label26, "");
            this.MainToolTip.SetToolTipIcon(this.label26, null);
            this.MainToolTip.SetToolTipTitle(this.label26, "");
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(230, 102);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator3.Size = new System.Drawing.Size(14, 205);
            this.bunifuSeparator3.TabIndex = 30;
            this.MainToolTip.SetToolTip(this.bunifuSeparator3, "");
            this.MainToolTip.SetToolTipIcon(this.bunifuSeparator3, null);
            this.MainToolTip.SetToolTipTitle(this.bunifuSeparator3, "");
            // 
            // MainSnackbar
            // 
            this.MainSnackbar.AllowDragging = false;
            this.MainSnackbar.AllowMultipleViews = true;
            this.MainSnackbar.ClickToClose = true;
            this.MainSnackbar.DoubleClickToClose = true;
            this.MainSnackbar.DurationAfterIdle = 3000;
            this.MainSnackbar.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainSnackbar.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainSnackbar.ErrorOptions.ActionBorderRadius = 1;
            this.MainSnackbar.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.MainSnackbar.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MainSnackbar.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.MainSnackbar.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.MainSnackbar.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.MainSnackbar.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainSnackbar.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.MainSnackbar.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.MainSnackbar.ErrorOptions.IconLeftMargin = 12;
            this.MainSnackbar.FadeCloseIcon = false;
            this.MainSnackbar.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.MainSnackbar.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainSnackbar.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainSnackbar.InformationOptions.ActionBorderRadius = 1;
            this.MainSnackbar.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.MainSnackbar.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MainSnackbar.InformationOptions.BackColor = System.Drawing.Color.White;
            this.MainSnackbar.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.MainSnackbar.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.MainSnackbar.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainSnackbar.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.MainSnackbar.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.MainSnackbar.InformationOptions.IconLeftMargin = 12;
            this.MainSnackbar.Margin = 10;
            this.MainSnackbar.MaximumSize = new System.Drawing.Size(0, 0);
            this.MainSnackbar.MaximumViews = 7;
            this.MainSnackbar.MessageRightMargin = 15;
            this.MainSnackbar.MessageTopMargin = 0;
            this.MainSnackbar.MinimumSize = new System.Drawing.Size(0, 0);
            this.MainSnackbar.ShowBorders = false;
            this.MainSnackbar.ShowCloseIcon = false;
            this.MainSnackbar.ShowIcon = true;
            this.MainSnackbar.ShowShadows = true;
            this.MainSnackbar.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainSnackbar.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainSnackbar.SuccessOptions.ActionBorderRadius = 1;
            this.MainSnackbar.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.MainSnackbar.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MainSnackbar.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.MainSnackbar.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.MainSnackbar.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.MainSnackbar.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainSnackbar.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.MainSnackbar.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.MainSnackbar.SuccessOptions.IconLeftMargin = 12;
            this.MainSnackbar.ViewsMargin = 7;
            this.MainSnackbar.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainSnackbar.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainSnackbar.WarningOptions.ActionBorderRadius = 1;
            this.MainSnackbar.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.MainSnackbar.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MainSnackbar.WarningOptions.BackColor = System.Drawing.Color.White;
            this.MainSnackbar.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.MainSnackbar.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.MainSnackbar.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainSnackbar.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.MainSnackbar.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.MainSnackbar.WarningOptions.IconLeftMargin = 12;
            this.MainSnackbar.ZoomCloseIcon = true;
            // 
            // openServerDirectoryToolStripMenuItem
            // 
            this.openServerDirectoryToolStripMenuItem.Name = "openServerDirectoryToolStripMenuItem";
            this.openServerDirectoryToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.openServerDirectoryToolStripMenuItem.Text = "Open Server Directory";
            // 
            // MainToolTip
            // 
            this.MainToolTip.Active = true;
            this.MainToolTip.AlignTextWithTitle = false;
            this.MainToolTip.AllowAutoClose = false;
            this.MainToolTip.AllowFading = true;
            this.MainToolTip.AutoCloseDuration = 5000;
            this.MainToolTip.BackColor = System.Drawing.SystemColors.Control;
            this.MainToolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.MainToolTip.ClickToShowDisplayControl = false;
            this.MainToolTip.ConvertNewlinesToBreakTags = true;
            this.MainToolTip.DisplayControl = null;
            this.MainToolTip.EntryAnimationSpeed = 350;
            this.MainToolTip.ExitAnimationSpeed = 200;
            this.MainToolTip.GenerateAutoCloseDuration = false;
            this.MainToolTip.IconMargin = 6;
            this.MainToolTip.InitialDelay = 0;
            this.MainToolTip.Name = "MainToolTip";
            this.MainToolTip.Opacity = 1D;
            this.MainToolTip.OverrideToolTipTitles = false;
            this.MainToolTip.Padding = new System.Windows.Forms.Padding(10);
            this.MainToolTip.ReshowDelay = 100;
            this.MainToolTip.ShowAlways = true;
            this.MainToolTip.ShowBorders = true;
            this.MainToolTip.ShowIcons = true;
            this.MainToolTip.ShowShadows = true;
            this.MainToolTip.Tag = null;
            this.MainToolTip.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.MainToolTip.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainToolTip.TextMargin = 2;
            this.MainToolTip.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MainToolTip.TitleForeColor = System.Drawing.Color.Black;
            this.MainToolTip.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.MainToolTip.ToolTipTitle = "22";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(484, 466);
            this.Controls.Add(this.MainPages);
            this.Controls.Add(this.bunifuShadowPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rust DropLaunch - Alpha 0.2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPages.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPic)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.TabsFoundMaps.ResumeLayout(false);
            this.MapsContextMenu.ResumeLayout(false);
            this.WorkFolderTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapsDataGridView)).EndInit();
            this.HistoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataView)).EndInit();
            this.HelpTab.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.HelpPanelScroll.ResumeLayout(false);
            this.FileWatcherPanel.ResumeLayout(false);
            this.HelpVideosPanel.ResumeLayout(false);
            this.bunifuGroupBox7.ResumeLayout(false);
            this.bunifuGroupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.bunifuGroupBox5.ResumeLayout(false);
            this.bunifuGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.HelpMapStartPanel.ResumeLayout(false);
            this.BottomConsolePanel.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            this.bunifuShadowPanel6.ResumeLayout(false);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.SettingsDirectoryPanel.ResumeLayout(false);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.ServerFiles.ResumeLayout(false);
            this.ServerFiles.PerformLayout();
            this.PanelSaperator2.ResumeLayout(false);
            this.SettingsTopPanel.ResumeLayout(false);
            this.SetupDirsPage.ResumeLayout(false);
            this.SetupMapsGroup.ResumeLayout(false);
            this.SetupMapsGroup.PerformLayout();
            this.SetupServerFilesGroup.ResumeLayout(false);
            this.SetupServerFilesGroup.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.bunifuShadowPanel3.ResumeLayout(false);
            this.SetupCMDPage.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.bunifuShadowPanel4.ResumeLayout(false);
            this.SetupEndPage.ResumeLayout(false);
            this.bunifuGroupBox4.ResumeLayout(false);
            this.bunifuGroupBox4.PerformLayout();
            this.bunifuGroupBox8.ResumeLayout(false);
            this.bunifuGroupBox3.ResumeLayout(false);
            this.bunifuGroupBox3.PerformLayout();
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox2.PerformLayout();
            this.bunifuShadowPanel5.ResumeLayout(false);
            this.FirstRunPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuShadowPanel9.ResumeLayout(false);
            this.bunifuShadowPanel11.ResumeLayout(false);
            this.bunifuShadowPanel8.ResumeLayout(false);
            this.bunifuShadowPanel10.ResumeLayout(false);
            this.bunifuShadowPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel2;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 SettingsBtn;
		private Bunifu.UI.WinForms.BunifuPages MainPages;
		private System.Windows.Forms.TabPage MainPage;
		private System.Windows.Forms.TabPage SettingsPage;
		private System.Windows.Forms.Panel BottomConsolePanel;
		private System.Windows.Forms.Panel MainPanel;
		private Bunifu.UI.WinForms.BunifuDataGridView MapsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameTab;
		private System.Windows.Forms.DataGridViewTextBoxColumn LocationTab;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateTab;
		private Bunifu.UI.WinForms.BunifuShadowPanel SettingsTopPanel;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 SaveSettingsButton;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 SettingsBackButton;
		private Bunifu.UI.WinForms.BunifuShadowPanel SettingsDirectoryPanel;
		private System.Windows.Forms.Label DirectoriesLabel;
		private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
		private Bunifu.UI.WinForms.BunifuCheckBox CheckboxFileWatch;
		private Bunifu.UI.WinForms.BunifuCheckBox CheckboxDesktopNoti;
		private Bunifu.UI.WinForms.BunifuCheckBox CheckNewStart;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
		private Bunifu.UI.WinForms.BunifuSnackbar MainSnackbar;
		private System.Windows.Forms.TabPage SetupDirsPage;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 SetupDirNextButton;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 SetupDirBackButton;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TabControl TabsFoundMaps;
		private System.Windows.Forms.TabPage WorkFolderTab;
		private System.Windows.Forms.TabPage HistoryTab;
		private Bunifu.UI.WinForms.BunifuDataGridView HistoryDataView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Label SettingsLabel;
		private System.Windows.Forms.ContextMenuStrip MapsContextMenu;
		private System.Windows.Forms.ToolStripMenuItem startServerWithMapToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openMapDirectoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem copyMapDirectoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyMapNameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createStartFileToolStripMenuItem;
		private System.Windows.Forms.TabPage SetupCMDPage;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 SetupCMDNextButton;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 SetupCMDBackButton;
		private System.Windows.Forms.RichTextBox CMDDownloadText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label CMDStatusLabel;
		private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel3;
		private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel4;
		private System.Windows.Forms.TabPage SetupEndPage;
		private System.Windows.Forms.RichTextBox ConsoleTextbox;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 UpdateServerButton;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 WriteStartfilesButton;
		private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private Bunifu.UI.WinForms.BunifuLabel StatusLabel;
		private Bunifu.UI.WinForms.BunifuPictureBox StatusPic;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 SetupcompletedHome;
		private System.Windows.Forms.Label label14;
		private Bunifu.UI.WinForms.BunifuCheckBox AutoNextSetupCheck;
		private System.Windows.Forms.ToolStripMenuItem moreStartFilesToolStripMenuItem;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ToolStripMenuItem openServerDirectoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openServerDirectoryToolStripMenuItem1;
		private Bunifu.UI.WinForms.BunifuLoader bunifuLoader1;
		private System.Windows.Forms.Label SetupStepsLabel;
		private System.Windows.Forms.Label label20;
		private Bunifu.UI.WinForms.BunifuToolTip MainToolTip;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label21;
		private Bunifu.UI.WinForms.BunifuCheckBox CheckDeleteClientMap;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator7;
		private System.Windows.Forms.Panel panel8;
		private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
		private Bunifu.UI.WinForms.BunifuTextBox RustGameDirbox;
		private System.Windows.Forms.Label label17;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator4;
		private Bunifu.UI.WinForms.BunifuTextBox MapDirBox;
		private System.Windows.Forms.Label label2;
		private Bunifu.UI.WinForms.BunifuGroupBox ServerFiles;
		private Bunifu.UI.WinForms.BunifuTextBox SteamCMDBox;
		private System.Windows.Forms.Label label12;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator10;
		private System.Windows.Forms.Panel PanelSaperator2;
		private Bunifu.UI.WinForms.BunifuTextBox ServerFilesDirbox;
		private Bunifu.UI.WinForms.BunifuDropdown SettingsBranchDropdown;
		private System.Windows.Forms.Label DirectoriesLab;
		private Bunifu.UI.WinForms.BunifuGroupBox SetupMapsGroup;
		private Bunifu.UI.WinForms.BunifuTextBox SetupRustGameDirbox;
		private System.Windows.Forms.Label label11;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator11;
		private Bunifu.UI.WinForms.BunifuTextBox SetupMapsDirectory;
		private System.Windows.Forms.Label label1;
		private Bunifu.UI.WinForms.BunifuGroupBox SetupServerFilesGroup;
		private Bunifu.UI.WinForms.BunifuTextBox SetupCMDdir;
		private System.Windows.Forms.Label label9;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator5;
		private System.Windows.Forms.Panel panel2;
		private Bunifu.UI.WinForms.BunifuTextBox SetupServerTextbox;
		private Bunifu.UI.WinForms.BunifuDropdown DropDownBranches;
		private System.Windows.Forms.Label label8;
		private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel6;
		private System.Windows.Forms.ToolStripMenuItem openClientMapsDirectoryToolStripMenuItem;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label19;
		private Bunifu.UI.WinForms.BunifuCheckBox CheckToolTips;
		private Bunifu.UI.WinForms.BunifuCheckBox CheckCopyConnect;
		private System.Windows.Forms.Label label22;
		private Bunifu.UI.WinForms.BunifuCheckBox CheckRunExampleStart;
		private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
		private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox3;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label24;
		private Bunifu.UI.WinForms.BunifuCheckBox CheckRusteditDLL;
		private System.Windows.Forms.ToolStripMenuItem createPrefabStartFileAndStartServerToolStripMenuItem;
		private System.Windows.Forms.TabPage HelpTab;
		private System.Windows.Forms.Label label23;
		private Bunifu.UI.WinForms.BunifuCheckBox CheckOpenReadme;
		private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox4;
		private System.Windows.Forms.Label label25;
		private Bunifu.UI.WinForms.BunifuCheckBox CheckHelpTooltips;
		private Bunifu.UI.WinForms.BunifuShadowPanel HelpVideosPanel;
		private System.Windows.Forms.Label SetupLabel;
		private Bunifu.UI.WinForms.BunifuShadowPanel HelpMapStartPanel;
		private System.Windows.Forms.Label TestingMaplabel;
		private Bunifu.UI.WinForms.BunifuPanel HelpPanelScroll;
		private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label28;
        private Bunifu.UI.WinForms.BunifuRadioButton RadioCarbon;
        private Bunifu.UI.WinForms.BunifuRadioButton RadioUmod;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuCheckBox CheckNoPlugins;
        private Bunifu.UI.WinForms.BunifuShadowPanel FileWatcherPanel;
        private System.Windows.Forms.Label FilewatcherLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuCheckBox CheckNoHelp;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuCheckBox CheckNoTesting;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox6;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox5;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox7;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TabPage FirstRunPage;
        private System.Windows.Forms.Label label27;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel8;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel7;
        private System.Windows.Forms.Label label26;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel9;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel10;
        private System.Windows.Forms.Label label29;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel11;
        private System.Windows.Forms.Label label30;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator12;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator13;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel11;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator14;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator9;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 FirstRunCustomInstall;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 FirstRunOneClick;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonGithub;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonDiscord;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox8;
        private Bunifu.UI.WinForms.BunifuTextBox FinishRustGameDirbox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 FirstRunHomeButton;
    }
}

