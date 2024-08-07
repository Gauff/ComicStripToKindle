namespace ComicStripToKindle
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbConvert = new System.Windows.Forms.Button();
            this.pbSelectComicFile = new System.Windows.Forms.Button();
            this.txtPdfDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtErrors = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.panelComic = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.chkBlackBackground = new System.Windows.Forms.CheckBox();
            this.txtBackgroundTreshold = new System.Windows.Forms.TextBox();
            this.chkVerticalSplit = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.chkInvertPages = new System.Windows.Forms.CheckBox();
            this.chkIncludePageIfNoPanelDetected = new System.Windows.Forms.CheckBox();
            this.chkUnSkew = new System.Windows.Forms.CheckBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.cbHorizontalOnly = new System.Windows.Forms.CheckBox();
            this.rbAlgoCropOnly = new System.Windows.Forms.RadioButton();
            this.chkManga = new System.Windows.Forms.CheckBox();
            this.rbAlgoCombined = new System.Windows.Forms.RadioButton();
            this.rbAlgoEmptyLinesAndColumns = new System.Windows.Forms.RadioButton();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMinimumPanelHeight = new System.Windows.Forms.TextBox();
            this.txtMinimumPanelWidth = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.rbAlgoConnectedComponents = new System.Windows.Forms.RadioButton();
            this.pbDeleteComicProfile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbComicProfile = new System.Windows.Forms.ComboBox();
            this.pbSaveComicProfile = new System.Windows.Forms.Button();
            this.panelEreader = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbScp = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cbScpDirectoryList = new System.Windows.Forms.ComboBox();
            this.txtScpRemotePath = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtScpPrivateKeyFile = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.chkUseScp = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtScpHost = new System.Windows.Forms.TextBox();
            this.pHostAvailable = new System.Windows.Forms.PictureBox();
            this.txtScpUserName = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.gbLocalDrive = new System.Windows.Forms.GroupBox();
            this.chkUseKindleLocalDrive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVolumeName = new System.Windows.Forms.TextBox();
            this.pVolumeConected = new System.Windows.Forms.PictureBox();
            this.txtDocumentDirectory = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbGenerateGammaScale = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbDeleteEreaderProfile = new System.Windows.Forms.Button();
            this.cbEReaderProfile = new System.Windows.Forms.ComboBox();
            this.pbSaveEreaderProfile = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtCorrectionGamma = new System.Windows.Forms.TextBox();
            this.chkCorrectionGamma = new System.Windows.Forms.CheckBox();
            this.chkGrayscal = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResolutionHeight = new System.Windows.Forms.TextBox();
            this.txtResolutionWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.collapsibleControlImageEnhancement = new ComicStripToKindle.Controls.CollapsibleControl();
            this.panelImageEnhancement = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbSharpen2 = new System.Windows.Forms.GroupBox();
            this.chkGaussianSharpen = new System.Windows.Forms.CheckBox();
            this.txtGaussianSharpenSigma = new System.Windows.Forms.TextBox();
            this.chkCorrectionSharpen = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGaussianSharpenKernel = new System.Windows.Forms.TextBox();
            this.gbDescreening = new System.Windows.Forms.GroupBox();
            this.chkMedianFilter = new System.Windows.Forms.CheckBox();
            this.chkGaussianBlur = new System.Windows.Forms.CheckBox();
            this.txtGaussianBlurSigma = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtGaussianBlurKernel = new System.Windows.Forms.TextBox();
            this.pbDleteImageEnhancement = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.cbImageEnhancementProfile = new System.Windows.Forms.ComboBox();
            this.pbSaveImageEnhancement = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBlackLevel = new System.Windows.Forms.TextBox();
            this.chkLevelThreshold = new System.Windows.Forms.CheckBox();
            this.txtJpegQuality = new System.Windows.Forms.TextBox();
            this.txtRotationAngle = new System.Windows.Forms.TextBox();
            this.chkAutomaticContrastCorrection = new System.Windows.Forms.CheckBox();
            this.txtWhiteLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAutomaticRotation = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPdfFileName = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.pbConcatenate = new System.Windows.Forms.Button();
            this.chkSendByEmail = new System.Windows.Forms.CheckBox();
            this.chkOpenDirectoryAfterConversion = new System.Windows.Forms.CheckBox();
            this.chkCopyToEreader = new System.Windows.Forms.CheckBox();
            this.pbSelectOutputDirectory = new System.Windows.Forms.Button();
            this.collapsibleControlEmail = new ComicStripToKindle.Controls.CollapsibleControl();
            this.collapsibleControlComic = new ComicStripToKindle.Controls.CollapsibleControl();
            this.collapsibleControlEreader = new ComicStripToKindle.Controls.CollapsibleControl();
            this.panelEmailSettings = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cbSmtpPort = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSmtpPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSmtpServer = new System.Windows.Forms.TextBox();
            this.tabPageConversionErrors = new System.Windows.Forms.TabPage();
            this.pbClearComicFiles = new System.Windows.Forms.Button();
            this.pPreview = new System.Windows.Forms.Panel();
            this.lOriginalSize = new System.Windows.Forms.Label();
            this.lConvertedSize = new System.Windows.Forms.Label();
            this.lPreview = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pHidePreview = new System.Windows.Forms.Button();
            this.pOriginal = new System.Windows.Forms.PictureBox();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.pbAddComicDirectory = new System.Windows.Forms.Button();
            this.pbTest = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            this.panelComic.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.panelEreader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbScp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHostAvailable)).BeginInit();
            this.gbLocalDrive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pVolumeConected)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelImageEnhancement.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbSharpen2.SuspendLayout();
            this.gbDescreening.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panelEmailSettings.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPageConversionErrors.SuspendLayout();
            this.pPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbConvert
            // 
            this.pbConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbConvert.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbConvert.Location = new System.Drawing.Point(614, 972);
            this.pbConvert.Name = "pbConvert";
            this.pbConvert.Size = new System.Drawing.Size(399, 23);
            this.pbConvert.TabIndex = 0;
            this.pbConvert.Text = "Convert to PDF";
            this.pbConvert.UseVisualStyleBackColor = true;
            this.pbConvert.Click += new System.EventHandler(this.pbConvertToKindlePdf_Click);
            // 
            // pbSelectComicFile
            // 
            this.pbSelectComicFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbSelectComicFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbSelectComicFile.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbSelectComicFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbSelectComicFile.Location = new System.Drawing.Point(366, 973);
            this.pbSelectComicFile.Name = "pbSelectComicFile";
            this.pbSelectComicFile.Size = new System.Drawing.Size(118, 23);
            this.pbSelectComicFile.TabIndex = 19;
            this.pbSelectComicFile.Text = "Add Comic files";
            this.pbSelectComicFile.UseVisualStyleBackColor = true;
            this.pbSelectComicFile.Click += new System.EventHandler(this.pbSelectComicArchive_Click);
            // 
            // txtPdfDirectory
            // 
            this.txtPdfDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPdfDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPdfDirectory.Location = new System.Drawing.Point(89, 20);
            this.txtPdfDirectory.Name = "txtPdfDirectory";
            this.txtPdfDirectory.Size = new System.Drawing.Size(220, 22);
            this.txtPdfDirectory.TabIndex = 21;
            this.txtPdfDirectory.TextChanged += new System.EventHandler(this.txtPdfDirectory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "Directory path:";
            // 
            // lvFiles
            // 
            this.lvFiles.AllowDrop = true;
            this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvFiles.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(366, 12);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(640, 955);
            this.lvFiles.TabIndex = 23;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lvFiles_ColumnWidthChanged);
            this.lvFiles.SelectedIndexChanged += new System.EventHandler(this.lvFiles_SelectedIndexChanged);
            this.lvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvFiles_DragDrop);
            this.lvFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvFiles_DragEnter);
            this.lvFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.lvFiles_DragOver);
            this.lvFiles.DragLeave += new System.EventHandler(this.lvFiles_DragLeave);
            this.lvFiles.DoubleClick += new System.EventHandler(this.lvFiles_DoubleClick);
            this.lvFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvFiles_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Conversion progress";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Current operation";
            this.columnHeader3.Width = 193;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "U";
            this.columnHeader4.Width = 20;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "E";
            this.columnHeader5.Width = 20;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ForeColor = System.Drawing.Color.Black;
            this.progressBar.Location = new System.Drawing.Point(614, 1002);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(399, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.txtErrors);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 917);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected comic conversion errors";
            // 
            // txtErrors
            // 
            this.txtErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtErrors.Location = new System.Drawing.Point(7, 20);
            this.txtErrors.Multiline = true;
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.Size = new System.Drawing.Size(317, 891);
            this.txtErrors.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl.Controls.Add(this.tabPageConfiguration);
            this.tabControl.Controls.Add(this.tabPageConversionErrors);
            this.tabControl.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(10, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 1013);
            this.tabControl.TabIndex = 40;
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageConfiguration.Controls.Add(this.panelComic);
            this.tabPageConfiguration.Controls.Add(this.panelEreader);
            this.tabPageConfiguration.Controls.Add(this.collapsibleControlImageEnhancement);
            this.tabPageConfiguration.Controls.Add(this.panelImageEnhancement);
            this.tabPageConfiguration.Controls.Add(this.panelOutput);
            this.tabPageConfiguration.Controls.Add(this.collapsibleControlEmail);
            this.tabPageConfiguration.Controls.Add(this.collapsibleControlComic);
            this.tabPageConfiguration.Controls.Add(this.collapsibleControlEreader);
            this.tabPageConfiguration.Controls.Add(this.panelEmailSettings);
            this.tabPageConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 23);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(342, 986);
            this.tabPageConfiguration.TabIndex = 0;
            this.tabPageConfiguration.Text = "Configuration";
            // 
            // panelComic
            // 
            this.panelComic.Controls.Add(this.groupBox6);
            this.panelComic.Location = new System.Drawing.Point(205, 234);
            this.panelComic.Name = "panelComic";
            this.panelComic.Size = new System.Drawing.Size(344, 417);
            this.panelComic.TabIndex = 48;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox10);
            this.groupBox6.Controls.Add(this.groupBox16);
            this.groupBox6.Controls.Add(this.pbDeleteComicProfile);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.cbComicProfile);
            this.groupBox6.Controls.Add(this.pbSaveComicProfile);
            this.groupBox6.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(334, 407);
            this.groupBox6.TabIndex = 45;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Comic";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox10.Controls.Add(this.chkBlackBackground);
            this.groupBox10.Controls.Add(this.txtBackgroundTreshold);
            this.groupBox10.Controls.Add(this.chkVerticalSplit);
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Controls.Add(this.chkInvertPages);
            this.groupBox10.Controls.Add(this.chkIncludePageIfNoPanelDetected);
            this.groupBox10.Controls.Add(this.chkUnSkew);
            this.groupBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox10.Location = new System.Drawing.Point(9, 47);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(255, 147);
            this.groupBox10.TabIndex = 62;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Pages";
            // 
            // chkBlackBackground
            // 
            this.chkBlackBackground.AutoSize = true;
            this.chkBlackBackground.Location = new System.Drawing.Point(11, 103);
            this.chkBlackBackground.Name = "chkBlackBackground";
            this.chkBlackBackground.Size = new System.Drawing.Size(112, 18);
            this.chkBlackBackground.TabIndex = 54;
            this.chkBlackBackground.Text = "Black background";
            this.chkBlackBackground.UseVisualStyleBackColor = true;
            // 
            // txtBackgroundTreshold
            // 
            this.txtBackgroundTreshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBackgroundTreshold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBackgroundTreshold.Location = new System.Drawing.Point(150, 119);
            this.txtBackgroundTreshold.Name = "txtBackgroundTreshold";
            this.txtBackgroundTreshold.Size = new System.Drawing.Size(30, 22);
            this.txtBackgroundTreshold.TabIndex = 36;
            this.txtBackgroundTreshold.Text = "200";
            // 
            // chkVerticalSplit
            // 
            this.chkVerticalSplit.AutoSize = true;
            this.chkVerticalSplit.Location = new System.Drawing.Point(11, 18);
            this.chkVerticalSplit.Name = "chkVerticalSplit";
            this.chkVerticalSplit.Size = new System.Drawing.Size(158, 18);
            this.chkVerticalSplit.TabIndex = 58;
            this.chkVerticalSplit.Text = "Vertical split (2 pages scan)";
            this.chkVerticalSplit.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 124);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(136, 14);
            this.label26.TabIndex = 53;
            this.label26.Text = "Background color treshold:";
            // 
            // chkInvertPages
            // 
            this.chkInvertPages.AutoSize = true;
            this.chkInvertPages.Location = new System.Drawing.Point(11, 35);
            this.chkInvertPages.Name = "chkInvertPages";
            this.chkInvertPages.Size = new System.Drawing.Size(130, 18);
            this.chkInvertPages.TabIndex = 61;
            this.chkInvertPages.Text = "Invert pages (Manga)";
            this.chkInvertPages.UseVisualStyleBackColor = true;
            // 
            // chkIncludePageIfNoPanelDetected
            // 
            this.chkIncludePageIfNoPanelDetected.AutoSize = true;
            this.chkIncludePageIfNoPanelDetected.Location = new System.Drawing.Point(11, 69);
            this.chkIncludePageIfNoPanelDetected.Name = "chkIncludePageIfNoPanelDetected";
            this.chkIncludePageIfNoPanelDetected.Size = new System.Drawing.Size(184, 18);
            this.chkIncludePageIfNoPanelDetected.TabIndex = 59;
            this.chkIncludePageIfNoPanelDetected.Text = "Include page if no panel detected";
            this.chkIncludePageIfNoPanelDetected.UseVisualStyleBackColor = true;
            // 
            // chkUnSkew
            // 
            this.chkUnSkew.AutoSize = true;
            this.chkUnSkew.Location = new System.Drawing.Point(11, 52);
            this.chkUnSkew.Name = "chkUnSkew";
            this.chkUnSkew.Size = new System.Drawing.Size(84, 18);
            this.chkUnSkew.TabIndex = 56;
            this.chkUnSkew.Text = "Skew check";
            this.chkUnSkew.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox16.Controls.Add(this.cbHorizontalOnly);
            this.groupBox16.Controls.Add(this.rbAlgoCropOnly);
            this.groupBox16.Controls.Add(this.chkManga);
            this.groupBox16.Controls.Add(this.rbAlgoCombined);
            this.groupBox16.Controls.Add(this.rbAlgoEmptyLinesAndColumns);
            this.groupBox16.Controls.Add(this.groupBox15);
            this.groupBox16.Controls.Add(this.rbAlgoConnectedComponents);
            this.groupBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox16.Location = new System.Drawing.Point(8, 197);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(320, 201);
            this.groupBox16.TabIndex = 53;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Panel detection algorithm";
            // 
            // cbHorizontalOnly
            // 
            this.cbHorizontalOnly.AutoSize = true;
            this.cbHorizontalOnly.Location = new System.Drawing.Point(151, 78);
            this.cbHorizontalOnly.Name = "cbHorizontalOnly";
            this.cbHorizontalOnly.Size = new System.Drawing.Size(125, 18);
            this.cbHorizontalOnly.TabIndex = 61;
            this.cbHorizontalOnly.Text = "Horizontal lines only";
            this.cbHorizontalOnly.UseVisualStyleBackColor = true;
            // 
            // rbAlgoCropOnly
            // 
            this.rbAlgoCropOnly.AutoSize = true;
            this.rbAlgoCropOnly.Location = new System.Drawing.Point(11, 21);
            this.rbAlgoCropOnly.Name = "rbAlgoCropOnly";
            this.rbAlgoCropOnly.Size = new System.Drawing.Size(171, 18);
            this.rbAlgoCropOnly.TabIndex = 4;
            this.rbAlgoCropOnly.TabStop = true;
            this.rbAlgoCropOnly.Text = "None. Crop white borders only";
            this.rbAlgoCropOnly.UseVisualStyleBackColor = true;
            // 
            // chkManga
            // 
            this.chkManga.AutoSize = true;
            this.chkManga.Location = new System.Drawing.Point(151, 128);
            this.chkManga.Name = "chkManga";
            this.chkManga.Size = new System.Drawing.Size(166, 18);
            this.chkManga.TabIndex = 60;
            this.chkManga.Text = "Right to left reading (Manga)";
            this.chkManga.UseVisualStyleBackColor = true;
            // 
            // rbAlgoCombined
            // 
            this.rbAlgoCombined.Location = new System.Drawing.Point(10, 100);
            this.rbAlgoCombined.Name = "rbAlgoCombined";
            this.rbAlgoCombined.Size = new System.Drawing.Size(308, 22);
            this.rbAlgoCombined.TabIndex = 3;
            this.rbAlgoCombined.TabStop = true;
            this.rbAlgoCombined.Text = "By connected components and white lines detection";
            this.rbAlgoCombined.UseVisualStyleBackColor = true;
            // 
            // rbAlgoEmptyLinesAndColumns
            // 
            this.rbAlgoEmptyLinesAndColumns.AutoSize = true;
            this.rbAlgoEmptyLinesAndColumns.Location = new System.Drawing.Point(10, 77);
            this.rbAlgoEmptyLinesAndColumns.Name = "rbAlgoEmptyLinesAndColumns";
            this.rbAlgoEmptyLinesAndColumns.Size = new System.Drawing.Size(141, 18);
            this.rbAlgoEmptyLinesAndColumns.TabIndex = 2;
            this.rbAlgoEmptyLinesAndColumns.TabStop = true;
            this.rbAlgoEmptyLinesAndColumns.Text = "By white lines detection";
            this.rbAlgoEmptyLinesAndColumns.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox15.Controls.Add(this.label25);
            this.groupBox15.Controls.Add(this.label24);
            this.groupBox15.Controls.Add(this.txtMinimumPanelHeight);
            this.groupBox15.Controls.Add(this.txtMinimumPanelWidth);
            this.groupBox15.Controls.Add(this.label23);
            this.groupBox15.Controls.Add(this.label22);
            this.groupBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox15.Location = new System.Drawing.Point(6, 122);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(140, 74);
            this.groupBox15.TabIndex = 5;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Minimum panel size";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 46);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 14);
            this.label25.TabIndex = 52;
            this.label25.Text = "th of page height";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(49, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 14);
            this.label24.TabIndex = 51;
            this.label24.Text = "th of page width";
            // 
            // txtMinimumPanelHeight
            // 
            this.txtMinimumPanelHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMinimumPanelHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMinimumPanelHeight.Location = new System.Drawing.Point(20, 43);
            this.txtMinimumPanelHeight.Name = "txtMinimumPanelHeight";
            this.txtMinimumPanelHeight.Size = new System.Drawing.Size(30, 22);
            this.txtMinimumPanelHeight.TabIndex = 50;
            this.txtMinimumPanelHeight.Text = "8";
            // 
            // txtMinimumPanelWidth
            // 
            this.txtMinimumPanelWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMinimumPanelWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMinimumPanelWidth.Location = new System.Drawing.Point(20, 15);
            this.txtMinimumPanelWidth.Name = "txtMinimumPanelWidth";
            this.txtMinimumPanelWidth.Size = new System.Drawing.Size(30, 22);
            this.txtMinimumPanelWidth.TabIndex = 36;
            this.txtMinimumPanelWidth.Text = "6";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 14);
            this.label23.TabIndex = 49;
            this.label23.Text = "1/";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 14);
            this.label22.TabIndex = 48;
            this.label22.Text = "1/";
            // 
            // rbAlgoConnectedComponents
            // 
            this.rbAlgoConnectedComponents.Location = new System.Drawing.Point(10, 40);
            this.rbAlgoConnectedComponents.Name = "rbAlgoConnectedComponents";
            this.rbAlgoConnectedComponents.Size = new System.Drawing.Size(308, 34);
            this.rbAlgoConnectedComponents.TabIndex = 1;
            this.rbAlgoConnectedComponents.TabStop = true;
            this.rbAlgoConnectedComponents.Text = "Connected components, Rectangular (To detect rectangular delimited panels)";
            this.rbAlgoConnectedComponents.UseVisualStyleBackColor = true;
            // 
            // pbDeleteComicProfile
            // 
            this.pbDeleteComicProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbDeleteComicProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbDeleteComicProfile.Location = new System.Drawing.Point(271, 76);
            this.pbDeleteComicProfile.Name = "pbDeleteComicProfile";
            this.pbDeleteComicProfile.Size = new System.Drawing.Size(58, 23);
            this.pbDeleteComicProfile.TabIndex = 45;
            this.pbDeleteComicProfile.Text = "Delete";
            this.pbDeleteComicProfile.UseVisualStyleBackColor = true;
            this.pbDeleteComicProfile.Click += new System.EventHandler(this.pbDeleteComicProfile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 44;
            this.label9.Text = "Profile:";
            // 
            // cbComicProfile
            // 
            this.cbComicProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbComicProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbComicProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbComicProfile.FormattingEnabled = true;
            this.cbComicProfile.Location = new System.Drawing.Point(50, 19);
            this.cbComicProfile.Name = "cbComicProfile";
            this.cbComicProfile.Size = new System.Drawing.Size(278, 22);
            this.cbComicProfile.TabIndex = 41;
            this.cbComicProfile.SelectedIndexChanged += new System.EventHandler(this.cbComicProfile_SelectedIndexChanged);
            // 
            // pbSaveComicProfile
            // 
            this.pbSaveComicProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbSaveComicProfile.Location = new System.Drawing.Point(271, 47);
            this.pbSaveComicProfile.Name = "pbSaveComicProfile";
            this.pbSaveComicProfile.Size = new System.Drawing.Size(58, 23);
            this.pbSaveComicProfile.TabIndex = 43;
            this.pbSaveComicProfile.Text = "Save";
            this.pbSaveComicProfile.UseVisualStyleBackColor = true;
            this.pbSaveComicProfile.Click += new System.EventHandler(this.pbSaveComicProfile_Click);
            // 
            // panelEreader
            // 
            this.panelEreader.Controls.Add(this.groupBox2);
            this.panelEreader.Location = new System.Drawing.Point(294, 231);
            this.panelEreader.Name = "panelEreader";
            this.panelEreader.Size = new System.Drawing.Size(350, 492);
            this.panelEreader.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbScp);
            this.groupBox2.Controls.Add(this.gbLocalDrive);
            this.groupBox2.Controls.Add(this.pbGenerateGammaScale);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pbDeleteEreaderProfile);
            this.groupBox2.Controls.Add(this.cbEReaderProfile);
            this.groupBox2.Controls.Add(this.pbSaveEreaderProfile);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 486);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "E Ink E-Reader";
            // 
            // gbScp
            // 
            this.gbScp.Controls.Add(this.label35);
            this.gbScp.Controls.Add(this.cbScpDirectoryList);
            this.gbScp.Controls.Add(this.txtScpRemotePath);
            this.gbScp.Controls.Add(this.label34);
            this.gbScp.Controls.Add(this.txtScpPrivateKeyFile);
            this.gbScp.Controls.Add(this.label33);
            this.gbScp.Controls.Add(this.chkUseScp);
            this.gbScp.Controls.Add(this.label18);
            this.gbScp.Controls.Add(this.txtScpHost);
            this.gbScp.Controls.Add(this.pHostAvailable);
            this.gbScp.Controls.Add(this.txtScpUserName);
            this.gbScp.Controls.Add(this.label31);
            this.gbScp.Controls.Add(this.label32);
            this.gbScp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbScp.Location = new System.Drawing.Point(9, 256);
            this.gbScp.Name = "gbScp";
            this.gbScp.Size = new System.Drawing.Size(323, 224);
            this.gbScp.TabIndex = 52;
            this.gbScp.TabStop = false;
            this.gbScp.Text = "SCP drive (Koreader)";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(8, 128);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(76, 14);
            this.label35.TabIndex = 56;
            this.label35.Text = "Directory List:";
            // 
            // cbScpDirectoryList
            // 
            this.cbScpDirectoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbScpDirectoryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbScpDirectoryList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbScpDirectoryList.FormattingEnabled = true;
            this.cbScpDirectoryList.Location = new System.Drawing.Point(11, 146);
            this.cbScpDirectoryList.Name = "cbScpDirectoryList";
            this.cbScpDirectoryList.Size = new System.Drawing.Size(306, 22);
            this.cbScpDirectoryList.TabIndex = 55;
            this.cbScpDirectoryList.SelectedIndexChanged += new System.EventHandler(this.cbScpDirectoryList_SelectedIndexChanged);
            // 
            // txtScpRemotePath
            // 
            this.txtScpRemotePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScpRemotePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtScpRemotePath.Location = new System.Drawing.Point(115, 174);
            this.txtScpRemotePath.Name = "txtScpRemotePath";
            this.txtScpRemotePath.Size = new System.Drawing.Size(203, 22);
            this.txtScpRemotePath.TabIndex = 54;
            this.txtScpRemotePath.Text = "documents";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(8, 177);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(74, 14);
            this.label34.TabIndex = 53;
            this.label34.Text = "Remote Path:";
            // 
            // txtScpPrivateKeyFile
            // 
            this.txtScpPrivateKeyFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScpPrivateKeyFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtScpPrivateKeyFile.Location = new System.Drawing.Point(114, 96);
            this.txtScpPrivateKeyFile.Name = "txtScpPrivateKeyFile";
            this.txtScpPrivateKeyFile.Size = new System.Drawing.Size(203, 22);
            this.txtScpPrivateKeyFile.TabIndex = 52;
            this.txtScpPrivateKeyFile.Text = "documents";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 100);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(107, 14);
            this.label33.TabIndex = 51;
            this.label33.Text = "Private key file path:";
            // 
            // chkUseScp
            // 
            this.chkUseScp.AutoSize = true;
            this.chkUseScp.Checked = true;
            this.chkUseScp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseScp.Location = new System.Drawing.Point(7, 21);
            this.chkUseScp.Name = "chkUseScp";
            this.chkUseScp.Size = new System.Drawing.Size(102, 18);
            this.chkUseScp.TabIndex = 50;
            this.chkUseScp.Text = "Copy using SCP";
            this.chkUseScp.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 14);
            this.label18.TabIndex = 44;
            this.label18.Text = "Host:";
            // 
            // txtScpHost
            // 
            this.txtScpHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScpHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtScpHost.Location = new System.Drawing.Point(114, 40);
            this.txtScpHost.Name = "txtScpHost";
            this.txtScpHost.Size = new System.Drawing.Size(203, 22);
            this.txtScpHost.TabIndex = 45;
            this.txtScpHost.Text = "Kindle";
            // 
            // pHostAvailable
            // 
            this.pHostAvailable.Location = new System.Drawing.Point(300, 22);
            this.pHostAvailable.Name = "pHostAvailable";
            this.pHostAvailable.Size = new System.Drawing.Size(16, 16);
            this.pHostAvailable.TabIndex = 48;
            this.pHostAvailable.TabStop = false;
            // 
            // txtScpUserName
            // 
            this.txtScpUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScpUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtScpUserName.Location = new System.Drawing.Point(114, 68);
            this.txtScpUserName.Name = "txtScpUserName";
            this.txtScpUserName.Size = new System.Drawing.Size(203, 22);
            this.txtScpUserName.TabIndex = 47;
            this.txtScpUserName.Text = "documents";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(252, 21);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(42, 14);
            this.label31.TabIndex = 49;
            this.label31.Text = "Status:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 72);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(63, 14);
            this.label32.TabIndex = 46;
            this.label32.Text = "User name:";
            // 
            // gbLocalDrive
            // 
            this.gbLocalDrive.Controls.Add(this.chkUseKindleLocalDrive);
            this.gbLocalDrive.Controls.Add(this.label2);
            this.gbLocalDrive.Controls.Add(this.txtVolumeName);
            this.gbLocalDrive.Controls.Add(this.pVolumeConected);
            this.gbLocalDrive.Controls.Add(this.txtDocumentDirectory);
            this.gbLocalDrive.Controls.Add(this.label11);
            this.gbLocalDrive.Controls.Add(this.label3);
            this.gbLocalDrive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbLocalDrive.Location = new System.Drawing.Point(9, 152);
            this.gbLocalDrive.Name = "gbLocalDrive";
            this.gbLocalDrive.Size = new System.Drawing.Size(323, 98);
            this.gbLocalDrive.TabIndex = 51;
            this.gbLocalDrive.TabStop = false;
            this.gbLocalDrive.Text = "Local Drive (Kindle)";
            // 
            // chkUseKindleLocalDrive
            // 
            this.chkUseKindleLocalDrive.AutoSize = true;
            this.chkUseKindleLocalDrive.Checked = true;
            this.chkUseKindleLocalDrive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseKindleLocalDrive.Location = new System.Drawing.Point(7, 21);
            this.chkUseKindleLocalDrive.Name = "chkUseKindleLocalDrive";
            this.chkUseKindleLocalDrive.Size = new System.Drawing.Size(123, 18);
            this.chkUseKindleLocalDrive.TabIndex = 50;
            this.chkUseKindleLocalDrive.Text = "Copy to Kindle drive";
            this.chkUseKindleLocalDrive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 44;
            this.label2.Text = "Volume Name:";
            // 
            // txtVolumeName
            // 
            this.txtVolumeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVolumeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtVolumeName.Location = new System.Drawing.Point(114, 40);
            this.txtVolumeName.Name = "txtVolumeName";
            this.txtVolumeName.Size = new System.Drawing.Size(203, 22);
            this.txtVolumeName.TabIndex = 45;
            this.txtVolumeName.Text = "Kindle";
            // 
            // pVolumeConected
            // 
            this.pVolumeConected.Location = new System.Drawing.Point(300, 23);
            this.pVolumeConected.Name = "pVolumeConected";
            this.pVolumeConected.Size = new System.Drawing.Size(16, 16);
            this.pVolumeConected.TabIndex = 48;
            this.pVolumeConected.TabStop = false;
            // 
            // txtDocumentDirectory
            // 
            this.txtDocumentDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDocumentDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDocumentDirectory.Location = new System.Drawing.Point(114, 68);
            this.txtDocumentDirectory.Name = "txtDocumentDirectory";
            this.txtDocumentDirectory.Size = new System.Drawing.Size(204, 22);
            this.txtDocumentDirectory.TabIndex = 47;
            this.txtDocumentDirectory.Text = "documents";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 14);
            this.label11.TabIndex = 49;
            this.label11.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 14);
            this.label3.TabIndex = 46;
            this.label3.Text = "Document Directory:";
            // 
            // pbGenerateGammaScale
            // 
            this.pbGenerateGammaScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbGenerateGammaScale.Font = new System.Drawing.Font("Corbel", 8F);
            this.pbGenerateGammaScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbGenerateGammaScale.Location = new System.Drawing.Point(274, 358);
            this.pbGenerateGammaScale.Name = "pbGenerateGammaScale";
            this.pbGenerateGammaScale.Size = new System.Drawing.Size(58, 66);
            this.pbGenerateGammaScale.TabIndex = 50;
            this.pbGenerateGammaScale.Text = "Generate Gamma Scale";
            this.pbGenerateGammaScale.UseVisualStyleBackColor = true;
            this.pbGenerateGammaScale.Click += new System.EventHandler(this.pbGenerateGammaScale_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 40;
            this.label5.Text = "Profile:";
            // 
            // pbDeleteEreaderProfile
            // 
            this.pbDeleteEreaderProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbDeleteEreaderProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbDeleteEreaderProfile.Location = new System.Drawing.Point(271, 82);
            this.pbDeleteEreaderProfile.Name = "pbDeleteEreaderProfile";
            this.pbDeleteEreaderProfile.Size = new System.Drawing.Size(58, 23);
            this.pbDeleteEreaderProfile.TabIndex = 43;
            this.pbDeleteEreaderProfile.Text = "Delete";
            this.pbDeleteEreaderProfile.UseVisualStyleBackColor = true;
            this.pbDeleteEreaderProfile.Click += new System.EventHandler(this.pbDeleteEreaderProfile_Click);
            // 
            // cbEReaderProfile
            // 
            this.cbEReaderProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbEReaderProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEReaderProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbEReaderProfile.FormattingEnabled = true;
            this.cbEReaderProfile.Location = new System.Drawing.Point(51, 19);
            this.cbEReaderProfile.Name = "cbEReaderProfile";
            this.cbEReaderProfile.Size = new System.Drawing.Size(278, 22);
            this.cbEReaderProfile.TabIndex = 39;
            this.cbEReaderProfile.SelectedIndexChanged += new System.EventHandler(this.cbEReaderProfile_SelectedIndexChanged);
            // 
            // pbSaveEreaderProfile
            // 
            this.pbSaveEreaderProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbSaveEreaderProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbSaveEreaderProfile.Location = new System.Drawing.Point(271, 53);
            this.pbSaveEreaderProfile.Name = "pbSaveEreaderProfile";
            this.pbSaveEreaderProfile.Size = new System.Drawing.Size(58, 23);
            this.pbSaveEreaderProfile.TabIndex = 42;
            this.pbSaveEreaderProfile.Text = "Save";
            this.pbSaveEreaderProfile.UseVisualStyleBackColor = true;
            this.pbSaveEreaderProfile.Click += new System.EventHandler(this.pbSaveEreaderProfile_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox5.Location = new System.Drawing.Point(9, 46);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 100);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " E Ink electronic paper display characteristics";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtCorrectionGamma);
            this.groupBox7.Controls.Add(this.chkCorrectionGamma);
            this.groupBox7.Controls.Add(this.chkGrayscal);
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox7.Location = new System.Drawing.Point(122, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(127, 76);
            this.groupBox7.TabIndex = 41;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Corrections";
            // 
            // txtCorrectionGamma
            // 
            this.txtCorrectionGamma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorrectionGamma.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorrectionGamma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCorrectionGamma.Location = new System.Drawing.Point(81, 21);
            this.txtCorrectionGamma.MaxLength = 5;
            this.txtCorrectionGamma.Name = "txtCorrectionGamma";
            this.txtCorrectionGamma.Size = new System.Drawing.Size(40, 22);
            this.txtCorrectionGamma.TabIndex = 36;
            this.txtCorrectionGamma.Text = "2.0";
            this.txtCorrectionGamma.TextChanged += new System.EventHandler(this.EreaderUpdate);
            this.txtCorrectionGamma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorrectionGamma_KeyPress);
            // 
            // chkCorrectionGamma
            // 
            this.chkCorrectionGamma.AutoSize = true;
            this.chkCorrectionGamma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkCorrectionGamma.Location = new System.Drawing.Point(19, 23);
            this.chkCorrectionGamma.Name = "chkCorrectionGamma";
            this.chkCorrectionGamma.Size = new System.Drawing.Size(69, 18);
            this.chkCorrectionGamma.TabIndex = 34;
            this.chkCorrectionGamma.Text = "Gamma:";
            this.chkCorrectionGamma.UseVisualStyleBackColor = false;
            // 
            // chkGrayscal
            // 
            this.chkGrayscal.AutoSize = true;
            this.chkGrayscal.Checked = true;
            this.chkGrayscal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGrayscal.Location = new System.Drawing.Point(19, 48);
            this.chkGrayscal.Name = "chkGrayscal";
            this.chkGrayscal.Size = new System.Drawing.Size(75, 18);
            this.chkGrayscal.TabIndex = 42;
            this.chkGrayscal.Text = "Grayscale";
            this.chkGrayscal.UseVisualStyleBackColor = true;
            this.chkGrayscal.CheckedChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtResolutionHeight);
            this.groupBox3.Controls.Add(this.txtResolutionWidth);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 76);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resolution";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 14);
            this.label8.TabIndex = 34;
            this.label8.Text = "Width:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Height:";
            // 
            // txtResolutionHeight
            // 
            this.txtResolutionHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResolutionHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtResolutionHeight.Location = new System.Drawing.Point(61, 19);
            this.txtResolutionHeight.Name = "txtResolutionHeight";
            this.txtResolutionHeight.Size = new System.Drawing.Size(40, 22);
            this.txtResolutionHeight.TabIndex = 33;
            // 
            // txtResolutionWidth
            // 
            this.txtResolutionWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResolutionWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtResolutionWidth.Location = new System.Drawing.Point(61, 45);
            this.txtResolutionWidth.Name = "txtResolutionWidth";
            this.txtResolutionWidth.Size = new System.Drawing.Size(40, 22);
            this.txtResolutionWidth.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, -92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 14);
            this.label6.TabIndex = 39;
            this.label6.Text = "Gamma correction:";
            // 
            // collapsibleControlImageEnhancement
            // 
            this.collapsibleControlImageEnhancement.CollapsibleInterval = 5;
            this.collapsibleControlImageEnhancement.DisplayText = "Image Enhancement";
            this.collapsibleControlImageEnhancement.Image = null;
            this.collapsibleControlImageEnhancement.Location = new System.Drawing.Point(3, 77);
            this.collapsibleControlImageEnhancement.LowerPanel = null;
            this.collapsibleControlImageEnhancement.Name = "collapsibleControlImageEnhancement";
            this.collapsibleControlImageEnhancement.Size = new System.Drawing.Size(336, 22);
            this.collapsibleControlImageEnhancement.TabIndex = 52;
            this.collapsibleControlImageEnhancement.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.collapsibleControlImageEnhancement.Click += new System.EventHandler(this.collapsibleControlImageEnhancement_Click);
            // 
            // panelImageEnhancement
            // 
            this.panelImageEnhancement.Controls.Add(this.groupBox4);
            this.panelImageEnhancement.Location = new System.Drawing.Point(47, 253);
            this.panelImageEnhancement.Name = "panelImageEnhancement";
            this.panelImageEnhancement.Size = new System.Drawing.Size(343, 345);
            this.panelImageEnhancement.TabIndex = 50;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.gbSharpen2);
            this.groupBox4.Controls.Add(this.gbDescreening);
            this.groupBox4.Controls.Add(this.pbDleteImageEnhancement);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.cbImageEnhancementProfile);
            this.groupBox4.Controls.Add(this.pbSaveImageEnhancement);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtBlackLevel);
            this.groupBox4.Controls.Add(this.chkLevelThreshold);
            this.groupBox4.Controls.Add(this.txtJpegQuality);
            this.groupBox4.Controls.Add(this.txtRotationAngle);
            this.groupBox4.Controls.Add(this.chkAutomaticContrastCorrection);
            this.groupBox4.Controls.Add(this.txtWhiteLevel);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.chkAutomaticRotation);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox4.Location = new System.Drawing.Point(4, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 336);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image Enhancement && Quality";
            // 
            // gbSharpen2
            // 
            this.gbSharpen2.Controls.Add(this.chkGaussianSharpen);
            this.gbSharpen2.Controls.Add(this.txtGaussianSharpenSigma);
            this.gbSharpen2.Controls.Add(this.chkCorrectionSharpen);
            this.gbSharpen2.Controls.Add(this.label21);
            this.gbSharpen2.Controls.Add(this.label20);
            this.gbSharpen2.Controls.Add(this.txtGaussianSharpenKernel);
            this.gbSharpen2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbSharpen2.Location = new System.Drawing.Point(6, 219);
            this.gbSharpen2.Name = "gbSharpen2";
            this.gbSharpen2.Size = new System.Drawing.Size(324, 74);
            this.gbSharpen2.TabIndex = 39;
            this.gbSharpen2.TabStop = false;
            this.gbSharpen2.Text = "Sharpen";
            // 
            // chkGaussianSharpen
            // 
            this.chkGaussianSharpen.AutoSize = true;
            this.chkGaussianSharpen.Location = new System.Drawing.Point(6, 20);
            this.chkGaussianSharpen.Name = "chkGaussianSharpen";
            this.chkGaussianSharpen.Size = new System.Drawing.Size(76, 18);
            this.chkGaussianSharpen.TabIndex = 55;
            this.chkGaussianSharpen.Text = "Gaussian :";
            this.chkGaussianSharpen.UseVisualStyleBackColor = true;
            this.chkGaussianSharpen.CheckedChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // txtGaussianSharpenSigma
            // 
            this.txtGaussianSharpenSigma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGaussianSharpenSigma.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGaussianSharpenSigma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGaussianSharpenSigma.Location = new System.Drawing.Point(221, 18);
            this.txtGaussianSharpenSigma.Name = "txtGaussianSharpenSigma";
            this.txtGaussianSharpenSigma.Size = new System.Drawing.Size(27, 21);
            this.txtGaussianSharpenSigma.TabIndex = 53;
            this.txtGaussianSharpenSigma.Text = "1";
            this.txtGaussianSharpenSigma.TextChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            this.txtGaussianSharpenSigma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSigma_KeyPress);
            // 
            // chkCorrectionSharpen
            // 
            this.chkCorrectionSharpen.AutoSize = true;
            this.chkCorrectionSharpen.Location = new System.Drawing.Point(6, 47);
            this.chkCorrectionSharpen.Name = "chkCorrectionSharpen";
            this.chkCorrectionSharpen.Size = new System.Drawing.Size(64, 18);
            this.chkCorrectionSharpen.TabIndex = 37;
            this.chkCorrectionSharpen.Text = "Regular";
            this.chkCorrectionSharpen.UseVisualStyleBackColor = true;
            this.chkCorrectionSharpen.CheckedChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label21.Location = new System.Drawing.Point(181, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 14);
            this.label21.TabIndex = 54;
            this.label21.Text = "Sigma:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label20.Location = new System.Drawing.Point(106, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 14);
            this.label20.TabIndex = 52;
            this.label20.Text = "Kernel:";
            // 
            // txtGaussianSharpenKernel
            // 
            this.txtGaussianSharpenKernel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGaussianSharpenKernel.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGaussianSharpenKernel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGaussianSharpenKernel.Location = new System.Drawing.Point(148, 17);
            this.txtGaussianSharpenKernel.Name = "txtGaussianSharpenKernel";
            this.txtGaussianSharpenKernel.Size = new System.Drawing.Size(27, 21);
            this.txtGaussianSharpenKernel.TabIndex = 51;
            this.txtGaussianSharpenKernel.Text = "3";
            this.txtGaussianSharpenKernel.TextChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // gbDescreening
            // 
            this.gbDescreening.Controls.Add(this.chkMedianFilter);
            this.gbDescreening.Controls.Add(this.chkGaussianBlur);
            this.gbDescreening.Controls.Add(this.txtGaussianBlurSigma);
            this.gbDescreening.Controls.Add(this.label29);
            this.gbDescreening.Controls.Add(this.label30);
            this.gbDescreening.Controls.Add(this.txtGaussianBlurKernel);
            this.gbDescreening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbDescreening.Location = new System.Drawing.Point(6, 137);
            this.gbDescreening.Name = "gbDescreening";
            this.gbDescreening.Size = new System.Drawing.Size(324, 76);
            this.gbDescreening.TabIndex = 38;
            this.gbDescreening.TabStop = false;
            this.gbDescreening.Text = "Descreening";
            // 
            // chkMedianFilter
            // 
            this.chkMedianFilter.AutoSize = true;
            this.chkMedianFilter.Location = new System.Drawing.Point(7, 45);
            this.chkMedianFilter.Name = "chkMedianFilter";
            this.chkMedianFilter.Size = new System.Drawing.Size(88, 18);
            this.chkMedianFilter.TabIndex = 56;
            this.chkMedianFilter.Text = "Median filter";
            this.chkMedianFilter.UseVisualStyleBackColor = true;
            this.chkMedianFilter.CheckedChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // chkGaussianBlur
            // 
            this.chkGaussianBlur.AutoSize = true;
            this.chkGaussianBlur.Location = new System.Drawing.Point(7, 21);
            this.chkGaussianBlur.Name = "chkGaussianBlur";
            this.chkGaussianBlur.Size = new System.Drawing.Size(97, 18);
            this.chkGaussianBlur.TabIndex = 60;
            this.chkGaussianBlur.Text = "Gaussian blur :";
            this.chkGaussianBlur.UseVisualStyleBackColor = true;
            this.chkGaussianBlur.CheckedChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // txtGaussianBlurSigma
            // 
            this.txtGaussianBlurSigma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGaussianBlurSigma.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGaussianBlurSigma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGaussianBlurSigma.Location = new System.Drawing.Point(221, 20);
            this.txtGaussianBlurSigma.Name = "txtGaussianBlurSigma";
            this.txtGaussianBlurSigma.Size = new System.Drawing.Size(27, 21);
            this.txtGaussianBlurSigma.TabIndex = 58;
            this.txtGaussianBlurSigma.Text = "1";
            this.txtGaussianBlurSigma.TextChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label29.Location = new System.Drawing.Point(181, 22);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 14);
            this.label29.TabIndex = 59;
            this.label29.Text = "Sigma:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label30.Location = new System.Drawing.Point(106, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 14);
            this.label30.TabIndex = 57;
            this.label30.Text = "Kernel:";
            // 
            // txtGaussianBlurKernel
            // 
            this.txtGaussianBlurKernel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGaussianBlurKernel.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGaussianBlurKernel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGaussianBlurKernel.Location = new System.Drawing.Point(148, 19);
            this.txtGaussianBlurKernel.Name = "txtGaussianBlurKernel";
            this.txtGaussianBlurKernel.Size = new System.Drawing.Size(27, 21);
            this.txtGaussianBlurKernel.TabIndex = 56;
            this.txtGaussianBlurKernel.Text = "3";
            this.txtGaussianBlurKernel.TextChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // pbDleteImageEnhancement
            // 
            this.pbDleteImageEnhancement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbDleteImageEnhancement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbDleteImageEnhancement.Location = new System.Drawing.Point(274, 84);
            this.pbDleteImageEnhancement.Name = "pbDleteImageEnhancement";
            this.pbDleteImageEnhancement.Size = new System.Drawing.Size(58, 23);
            this.pbDleteImageEnhancement.TabIndex = 59;
            this.pbDleteImageEnhancement.Text = "Delete";
            this.pbDleteImageEnhancement.UseVisualStyleBackColor = true;
            this.pbDleteImageEnhancement.Click += new System.EventHandler(this.pbDleteImageEnhancement_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 14);
            this.label27.TabIndex = 58;
            this.label27.Text = "Profile:";
            // 
            // cbImageEnhancementProfile
            // 
            this.cbImageEnhancementProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbImageEnhancementProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbImageEnhancementProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbImageEnhancementProfile.FormattingEnabled = true;
            this.cbImageEnhancementProfile.Location = new System.Drawing.Point(53, 21);
            this.cbImageEnhancementProfile.Name = "cbImageEnhancementProfile";
            this.cbImageEnhancementProfile.Size = new System.Drawing.Size(278, 22);
            this.cbImageEnhancementProfile.TabIndex = 56;
            this.cbImageEnhancementProfile.SelectedIndexChanged += new System.EventHandler(this.cbImageEnhancementProfile_SelectedIndexChanged);
            // 
            // pbSaveImageEnhancement
            // 
            this.pbSaveImageEnhancement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbSaveImageEnhancement.Location = new System.Drawing.Point(274, 55);
            this.pbSaveImageEnhancement.Name = "pbSaveImageEnhancement";
            this.pbSaveImageEnhancement.Size = new System.Drawing.Size(58, 23);
            this.pbSaveImageEnhancement.TabIndex = 57;
            this.pbSaveImageEnhancement.Text = "Save";
            this.pbSaveImageEnhancement.UseVisualStyleBackColor = true;
            this.pbSaveImageEnhancement.Click += new System.EventHandler(this.pbSaveImageEnhancement_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label19.Location = new System.Drawing.Point(97, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 14);
            this.label19.TabIndex = 50;
            this.label19.Text = "->";
            // 
            // txtBlackLevel
            // 
            this.txtBlackLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBlackLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBlackLevel.Location = new System.Drawing.Point(64, 86);
            this.txtBlackLevel.Name = "txtBlackLevel";
            this.txtBlackLevel.Size = new System.Drawing.Size(31, 22);
            this.txtBlackLevel.TabIndex = 49;
            this.txtBlackLevel.Text = "10";
            this.txtBlackLevel.TextChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // chkLevelThreshold
            // 
            this.chkLevelThreshold.AutoSize = true;
            this.chkLevelThreshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkLevelThreshold.Location = new System.Drawing.Point(6, 88);
            this.chkLevelThreshold.Name = "chkLevelThreshold";
            this.chkLevelThreshold.Size = new System.Drawing.Size(61, 18);
            this.chkLevelThreshold.TabIndex = 48;
            this.chkLevelThreshold.Text = "Levels:";
            this.chkLevelThreshold.UseVisualStyleBackColor = false;
            this.chkLevelThreshold.CheckedChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // txtJpegQuality
            // 
            this.txtJpegQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtJpegQuality.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJpegQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtJpegQuality.Location = new System.Drawing.Point(78, 299);
            this.txtJpegQuality.Name = "txtJpegQuality";
            this.txtJpegQuality.Size = new System.Drawing.Size(27, 21);
            this.txtJpegQuality.TabIndex = 43;
            this.txtJpegQuality.Text = "70";
            this.txtJpegQuality.TextChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // txtRotationAngle
            // 
            this.txtRotationAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRotationAngle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRotationAngle.Location = new System.Drawing.Point(89, 59);
            this.txtRotationAngle.Name = "txtRotationAngle";
            this.txtRotationAngle.Size = new System.Drawing.Size(32, 22);
            this.txtRotationAngle.TabIndex = 45;
            this.txtRotationAngle.Text = "90";
            this.txtRotationAngle.TextChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // chkAutomaticContrastCorrection
            // 
            this.chkAutomaticContrastCorrection.Checked = true;
            this.chkAutomaticContrastCorrection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutomaticContrastCorrection.Location = new System.Drawing.Point(6, 110);
            this.chkAutomaticContrastCorrection.Name = "chkAutomaticContrastCorrection";
            this.chkAutomaticContrastCorrection.Size = new System.Drawing.Size(101, 24);
            this.chkAutomaticContrastCorrection.TabIndex = 46;
            this.chkAutomaticContrastCorrection.Text = "Auto Contrast";
            this.chkAutomaticContrastCorrection.UseVisualStyleBackColor = true;
            this.chkAutomaticContrastCorrection.CheckedChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // txtWhiteLevel
            // 
            this.txtWhiteLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWhiteLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtWhiteLevel.Location = new System.Drawing.Point(115, 86);
            this.txtWhiteLevel.Name = "txtWhiteLevel";
            this.txtWhiteLevel.Size = new System.Drawing.Size(31, 22);
            this.txtWhiteLevel.TabIndex = 47;
            this.txtWhiteLevel.Text = "230";
            this.txtWhiteLevel.TextChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 14);
            this.label4.TabIndex = 44;
            this.label4.Text = "°";
            // 
            // chkAutomaticRotation
            // 
            this.chkAutomaticRotation.Checked = true;
            this.chkAutomaticRotation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutomaticRotation.Location = new System.Drawing.Point(6, 58);
            this.chkAutomaticRotation.Name = "chkAutomaticRotation";
            this.chkAutomaticRotation.Size = new System.Drawing.Size(98, 24);
            this.chkAutomaticRotation.TabIndex = 43;
            this.chkAutomaticRotation.Text = "Auto Rotate";
            this.chkAutomaticRotation.UseVisualStyleBackColor = true;
            this.chkAutomaticRotation.CheckedChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Location = new System.Drawing.Point(6, 301);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 14);
            this.label16.TabIndex = 45;
            this.label16.Text = "JPEG quality:";
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.groupBox8);
            this.panelOutput.Location = new System.Drawing.Point(3, 738);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(330, 242);
            this.panelOutput.TabIndex = 51;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox12);
            this.groupBox8.Controls.Add(this.groupBox11);
            this.groupBox8.Controls.Add(this.chkSendByEmail);
            this.groupBox8.Controls.Add(this.chkCopyToEreader);
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox8.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox8.Location = new System.Drawing.Point(3, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(327, 235);
            this.groupBox8.TabIndex = 46;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Output";
            // 
            // txtPdfFileName
            // 
            this.txtPdfFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPdfFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPdfFileName.Location = new System.Drawing.Point(61, 21);
            this.txtPdfFileName.Name = "txtPdfFileName";
            this.txtPdfFileName.Size = new System.Drawing.Size(251, 22);
            this.txtPdfFileName.TabIndex = 50;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 27);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 14);
            this.label28.TabIndex = 49;
            this.label28.Text = "File name:";
            // 
            // pbConcatenate
            // 
            this.pbConcatenate.AutoEllipsis = true;
            this.pbConcatenate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbConcatenate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbConcatenate.Location = new System.Drawing.Point(223, 45);
            this.pbConcatenate.Name = "pbConcatenate";
            this.pbConcatenate.Size = new System.Drawing.Size(88, 27);
            this.pbConcatenate.TabIndex = 48;
            this.pbConcatenate.Text = "Concatenate";
            this.pbConcatenate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pbConcatenate.UseVisualStyleBackColor = true;
            this.pbConcatenate.Click += new System.EventHandler(this.pbConcatenate_Click);
            // 
            // chkSendByEmail
            // 
            this.chkSendByEmail.AutoSize = true;
            this.chkSendByEmail.Checked = true;
            this.chkSendByEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSendByEmail.Location = new System.Drawing.Point(6, 126);
            this.chkSendByEmail.Name = "chkSendByEmail";
            this.chkSendByEmail.Size = new System.Drawing.Size(95, 18);
            this.chkSendByEmail.TabIndex = 45;
            this.chkSendByEmail.Text = "Send by email";
            this.chkSendByEmail.UseVisualStyleBackColor = true;
            this.chkSendByEmail.CheckedChanged += new System.EventHandler(this.SaveOutputProfile);
            // 
            // chkOpenDirectoryAfterConversion
            // 
            this.chkOpenDirectoryAfterConversion.AutoSize = true;
            this.chkOpenDirectoryAfterConversion.Checked = true;
            this.chkOpenDirectoryAfterConversion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOpenDirectoryAfterConversion.Location = new System.Drawing.Point(9, 48);
            this.chkOpenDirectoryAfterConversion.Name = "chkOpenDirectoryAfterConversion";
            this.chkOpenDirectoryAfterConversion.Size = new System.Drawing.Size(180, 18);
            this.chkOpenDirectoryAfterConversion.TabIndex = 47;
            this.chkOpenDirectoryAfterConversion.Text = "Open directory after conversion";
            this.chkOpenDirectoryAfterConversion.UseVisualStyleBackColor = true;
            this.chkOpenDirectoryAfterConversion.CheckedChanged += new System.EventHandler(this.SaveOutputProfile);
            // 
            // chkCopyToEreader
            // 
            this.chkCopyToEreader.AutoSize = true;
            this.chkCopyToEreader.Checked = true;
            this.chkCopyToEreader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopyToEreader.Location = new System.Drawing.Point(6, 102);
            this.chkCopyToEreader.Name = "chkCopyToEreader";
            this.chkCopyToEreader.Size = new System.Drawing.Size(123, 18);
            this.chkCopyToEreader.TabIndex = 44;
            this.chkCopyToEreader.Text = "Upload on E-Reader";
            this.chkCopyToEreader.UseVisualStyleBackColor = true;
            this.chkCopyToEreader.CheckedChanged += new System.EventHandler(this.SaveOutputProfile);
            // 
            // pbSelectOutputDirectory
            // 
            this.pbSelectOutputDirectory.AutoEllipsis = true;
            this.pbSelectOutputDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbSelectOutputDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbSelectOutputDirectory.Location = new System.Drawing.Point(216, 48);
            this.pbSelectOutputDirectory.Name = "pbSelectOutputDirectory";
            this.pbSelectOutputDirectory.Size = new System.Drawing.Size(92, 20);
            this.pbSelectOutputDirectory.TabIndex = 40;
            this.pbSelectOutputDirectory.Text = "...";
            this.pbSelectOutputDirectory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pbSelectOutputDirectory.UseVisualStyleBackColor = true;
            // 
            // collapsibleControlEmail
            // 
            this.collapsibleControlEmail.CollapsibleInterval = 5;
            this.collapsibleControlEmail.DisplayText = "Email settings";
            this.collapsibleControlEmail.Image = null;
            this.collapsibleControlEmail.Location = new System.Drawing.Point(3, 52);
            this.collapsibleControlEmail.LowerPanel = null;
            this.collapsibleControlEmail.Name = "collapsibleControlEmail";
            this.collapsibleControlEmail.Size = new System.Drawing.Size(336, 20);
            this.collapsibleControlEmail.TabIndex = 49;
            this.collapsibleControlEmail.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.collapsibleControlEmail.Click += new System.EventHandler(this.collapsibleControlEmail_Click);
            // 
            // collapsibleControlComic
            // 
            this.collapsibleControlComic.CollapsibleInterval = 5;
            this.collapsibleControlComic.DisplayText = "---";
            this.collapsibleControlComic.Image = null;
            this.collapsibleControlComic.Location = new System.Drawing.Point(3, 29);
            this.collapsibleControlComic.LowerPanel = null;
            this.collapsibleControlComic.Name = "collapsibleControlComic";
            this.collapsibleControlComic.Size = new System.Drawing.Size(336, 20);
            this.collapsibleControlComic.TabIndex = 48;
            this.collapsibleControlComic.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.collapsibleControlComic.Click += new System.EventHandler(this.collapsibleControlComic_Click);
            // 
            // collapsibleControlEreader
            // 
            this.collapsibleControlEreader.CollapsibleInterval = 5;
            this.collapsibleControlEreader.DisplayText = "---";
            this.collapsibleControlEreader.Image = null;
            this.collapsibleControlEreader.Location = new System.Drawing.Point(3, 3);
            this.collapsibleControlEreader.LowerPanel = null;
            this.collapsibleControlEreader.Name = "collapsibleControlEreader";
            this.collapsibleControlEreader.Size = new System.Drawing.Size(336, 20);
            this.collapsibleControlEreader.TabIndex = 47;
            this.collapsibleControlEreader.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.collapsibleControlEreader.Click += new System.EventHandler(this.collapsibleControlEreader_Click);
            // 
            // panelEmailSettings
            // 
            this.panelEmailSettings.Controls.Add(this.groupBox9);
            this.panelEmailSettings.Location = new System.Drawing.Point(3, 102);
            this.panelEmailSettings.Name = "panelEmailSettings";
            this.panelEmailSettings.Size = new System.Drawing.Size(329, 120);
            this.panelEmailSettings.TabIndex = 48;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cbSmtpPort);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.txtSmtpPassword);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.txtTo);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.txtFrom);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.txtSmtpServer);
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(317, 114);
            this.groupBox9.TabIndex = 46;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Email Settings";
            // 
            // cbSmtpPort
            // 
            this.cbSmtpPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSmtpPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSmtpPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbSmtpPort.FormattingEnabled = true;
            this.cbSmtpPort.Items.AddRange(new object[] {
            "25",
            "465",
            "587",
            "2525",
            "4065",
            "25025"});
            this.cbSmtpPort.Location = new System.Drawing.Point(262, 14);
            this.cbSmtpPort.Name = "cbSmtpPort";
            this.cbSmtpPort.Size = new System.Drawing.Size(49, 22);
            this.cbSmtpPort.TabIndex = 46;
            this.cbSmtpPort.TextChanged += new System.EventHandler(this.SaveOutputProfile);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 14);
            this.label15.TabIndex = 55;
            this.label15.Text = "Password:";
            // 
            // txtSmtpPassword
            // 
            this.txtSmtpPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSmtpPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSmtpPassword.Location = new System.Drawing.Point(92, 39);
            this.txtSmtpPassword.Name = "txtSmtpPassword";
            this.txtSmtpPassword.PasswordChar = '*';
            this.txtSmtpPassword.Size = new System.Drawing.Size(219, 22);
            this.txtSmtpPassword.TabIndex = 56;
            this.txtSmtpPassword.TextChanged += new System.EventHandler(this.SaveOutputProfile);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 14);
            this.label14.TabIndex = 53;
            this.label14.Text = "To:";
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTo.Location = new System.Drawing.Point(92, 87);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(219, 22);
            this.txtTo.TabIndex = 54;
            this.txtTo.TextChanged += new System.EventHandler(this.SaveOutputProfile);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 14);
            this.label13.TabIndex = 51;
            this.label13.Text = "From:";
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFrom.Location = new System.Drawing.Point(92, 63);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(219, 22);
            this.txtFrom.TabIndex = 52;
            this.txtFrom.TextChanged += new System.EventHandler(this.SaveOutputProfile);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 14);
            this.label12.TabIndex = 49;
            this.label12.Text = "Port:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 14);
            this.label10.TabIndex = 47;
            this.label10.Text = "SMTP Server:";
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSmtpServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSmtpServer.Location = new System.Drawing.Point(92, 15);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(134, 22);
            this.txtSmtpServer.TabIndex = 48;
            this.txtSmtpServer.TextChanged += new System.EventHandler(this.SaveOutputProfile);
            // 
            // tabPageConversionErrors
            // 
            this.tabPageConversionErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageConversionErrors.Controls.Add(this.groupBox1);
            this.tabPageConversionErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPageConversionErrors.Location = new System.Drawing.Point(4, 23);
            this.tabPageConversionErrors.Name = "tabPageConversionErrors";
            this.tabPageConversionErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConversionErrors.Size = new System.Drawing.Size(342, 986);
            this.tabPageConversionErrors.TabIndex = 1;
            this.tabPageConversionErrors.Text = "Conversion errors";
            // 
            // pbClearComicFiles
            // 
            this.pbClearComicFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbClearComicFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbClearComicFiles.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbClearComicFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbClearComicFiles.Location = new System.Drawing.Point(490, 973);
            this.pbClearComicFiles.Name = "pbClearComicFiles";
            this.pbClearComicFiles.Size = new System.Drawing.Size(118, 23);
            this.pbClearComicFiles.TabIndex = 41;
            this.pbClearComicFiles.Text = "Remove Comic files";
            this.pbClearComicFiles.UseVisualStyleBackColor = true;
            this.pbClearComicFiles.Click += new System.EventHandler(this.pbClearComicFiles_Click);
            // 
            // pPreview
            // 
            this.pPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pPreview.Controls.Add(this.lOriginalSize);
            this.pPreview.Controls.Add(this.lConvertedSize);
            this.pPreview.Controls.Add(this.lPreview);
            this.pPreview.Controls.Add(this.label17);
            this.pPreview.Controls.Add(this.pHidePreview);
            this.pPreview.Controls.Add(this.pOriginal);
            this.pPreview.Controls.Add(this.picturePreview);
            this.pPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pPreview.Location = new System.Drawing.Point(366, 200);
            this.pPreview.Name = "pPreview";
            this.pPreview.Size = new System.Drawing.Size(640, 765);
            this.pPreview.TabIndex = 42;
            this.pPreview.SizeChanged += new System.EventHandler(this.pPreview_SizeChanged);
            this.pPreview.Resize += new System.EventHandler(this.pPreview_Resize);
            // 
            // lOriginalSize
            // 
            this.lOriginalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lOriginalSize.AutoSize = true;
            this.lOriginalSize.Location = new System.Drawing.Point(70, 747);
            this.lOriginalSize.Name = "lOriginalSize";
            this.lOriginalSize.Size = new System.Drawing.Size(13, 13);
            this.lOriginalSize.TabIndex = 48;
            this.lOriginalSize.Text = "0";
            // 
            // lConvertedSize
            // 
            this.lConvertedSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lConvertedSize.AutoSize = true;
            this.lConvertedSize.Location = new System.Drawing.Point(468, 747);
            this.lConvertedSize.Name = "lConvertedSize";
            this.lConvertedSize.Size = new System.Drawing.Size(13, 13);
            this.lConvertedSize.TabIndex = 47;
            this.lConvertedSize.Text = "0";
            // 
            // lPreview
            // 
            this.lPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lPreview.AutoSize = true;
            this.lPreview.Location = new System.Drawing.Point(393, 747);
            this.lPreview.Name = "lPreview";
            this.lPreview.Size = new System.Drawing.Size(69, 13);
            this.lPreview.TabIndex = 45;
            this.lPreview.Text = "Preview size:";
            this.lPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 747);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Original size:";
            // 
            // pHidePreview
            // 
            this.pHidePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pHidePreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pHidePreview.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHidePreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pHidePreview.Location = new System.Drawing.Point(260, 737);
            this.pHidePreview.Name = "pHidePreview";
            this.pHidePreview.Size = new System.Drawing.Size(118, 23);
            this.pHidePreview.TabIndex = 43;
            this.pHidePreview.Text = "Hide Preview";
            this.pHidePreview.UseVisualStyleBackColor = true;
            this.pHidePreview.Click += new System.EventHandler(this.pHidePreview_Click);
            // 
            // pOriginal
            // 
            this.pOriginal.Location = new System.Drawing.Point(3, 33);
            this.pOriginal.Name = "pOriginal";
            this.pOriginal.Size = new System.Drawing.Size(300, 622);
            this.pOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pOriginal.TabIndex = 1;
            this.pOriginal.TabStop = false;
            // 
            // picturePreview
            // 
            this.picturePreview.Location = new System.Drawing.Point(330, 33);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(300, 622);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview.TabIndex = 0;
            this.picturePreview.TabStop = false;
            // 
            // pbAddComicDirectory
            // 
            this.pbAddComicDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbAddComicDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbAddComicDirectory.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbAddComicDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbAddComicDirectory.Location = new System.Drawing.Point(366, 1002);
            this.pbAddComicDirectory.Name = "pbAddComicDirectory";
            this.pbAddComicDirectory.Size = new System.Drawing.Size(118, 23);
            this.pbAddComicDirectory.TabIndex = 43;
            this.pbAddComicDirectory.Text = "Add Comic Directory";
            this.pbAddComicDirectory.UseVisualStyleBackColor = true;
            this.pbAddComicDirectory.Click += new System.EventHandler(this.pbAddComicDirectory_Click);
            // 
            // pbTest
            // 
            this.pbTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbTest.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbTest.Location = new System.Drawing.Point(490, 1002);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(118, 23);
            this.pbTest.TabIndex = 44;
            this.pbTest.Text = "Test";
            this.pbTest.UseVisualStyleBackColor = true;
            this.pbTest.Click += new System.EventHandler(this.pbTest_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label1);
            this.groupBox11.Controls.Add(this.txtPdfDirectory);
            this.groupBox11.Controls.Add(this.chkOpenDirectoryAfterConversion);
            this.groupBox11.Controls.Add(this.pbSelectOutputDirectory);
            this.groupBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox11.Location = new System.Drawing.Point(6, 18);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(315, 78);
            this.groupBox11.TabIndex = 51;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Local working directory";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtPdfFileName);
            this.groupBox12.Controls.Add(this.label28);
            this.groupBox12.Controls.Add(this.pbConcatenate);
            this.groupBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox12.Location = new System.Drawing.Point(3, 150);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(318, 78);
            this.groupBox12.TabIndex = 52;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Pdf concatenation";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1018, 1031);
            this.Controls.Add(this.pbTest);
            this.Controls.Add(this.pbAddComicDirectory);
            this.Controls.Add(this.pPreview);
            this.Controls.Add(this.pbClearComicFiles);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.pbSelectComicFile);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pbConvert);
            this.Name = "MainForm";
            this.Text = "Comics to  E Ink E-Reader Converter ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageConfiguration.ResumeLayout(false);
            this.panelComic.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.panelEreader.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbScp.ResumeLayout(false);
            this.gbScp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHostAvailable)).EndInit();
            this.gbLocalDrive.ResumeLayout(false);
            this.gbLocalDrive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pVolumeConected)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelImageEnhancement.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbSharpen2.ResumeLayout(false);
            this.gbSharpen2.PerformLayout();
            this.gbDescreening.ResumeLayout(false);
            this.gbDescreening.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panelEmailSettings.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPageConversionErrors.ResumeLayout(false);
            this.pPreview.ResumeLayout(false);
            this.pPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pbConvert;
        private System.Windows.Forms.Button pbSelectComicFile;
        private System.Windows.Forms.TextBox txtPdfDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtErrors;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.Button pbSelectOutputDirectory;
        private System.Windows.Forms.TabPage tabPageConversionErrors;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtCorrectionGamma;
        private System.Windows.Forms.CheckBox chkCorrectionGamma;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResolutionHeight;
        private System.Windows.Forms.TextBox txtResolutionWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEReaderProfile;
        private System.Windows.Forms.ComboBox cbComicProfile;
        private System.Windows.Forms.Button pbSaveEreaderProfile;
        private System.Windows.Forms.Button pbSaveComicProfile;
        private System.Windows.Forms.Button pbClearComicFiles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkAutomaticContrastCorrection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRotationAngle;
        private System.Windows.Forms.CheckBox chkAutomaticRotation;
        private System.Windows.Forms.CheckBox chkGrayscal;
        private System.Windows.Forms.CheckBox chkCorrectionSharpen;
        private System.Windows.Forms.Button pbDeleteEreaderProfile;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button pbDeleteComicProfile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCopyToEreader;
        private System.Windows.Forms.TextBox txtDocumentDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVolumeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox chkSendByEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSmtpServer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pVolumeConected;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ComboBox cbSmtpPort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSmtpPassword;
        private System.Windows.Forms.CheckBox chkOpenDirectoryAfterConversion;
        private System.Windows.Forms.TextBox txtJpegQuality;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtWhiteLevel;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel pPreview;
        private System.Windows.Forms.PictureBox pOriginal;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.Button pHidePreview;
        private System.Windows.Forms.Label lPreview;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lConvertedSize;
        private System.Windows.Forms.TextBox txtBlackLevel;
        private System.Windows.Forms.CheckBox chkLevelThreshold;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button pbAddComicDirectory;
        private System.Windows.Forms.TextBox txtGaussianSharpenSigma;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtGaussianSharpenKernel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkGaussianSharpen;
        private System.Windows.Forms.Button pbGenerateGammaScale;
        private System.Windows.Forms.Panel panelEreader;
        private Controls.CollapsibleControl collapsibleControlEreader;
        private System.Windows.Forms.Panel panelComic;
        private Controls.CollapsibleControl collapsibleControlComic;
        private System.Windows.Forms.Panel panelEmailSettings;
        private Controls.CollapsibleControl collapsibleControlEmail;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Panel panelImageEnhancement;
        private System.Windows.Forms.CheckBox chkUnSkew;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMinimumPanelHeight;
        private System.Windows.Forms.TextBox txtMinimumPanelWidth;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.RadioButton rbAlgoEmptyLinesAndColumns;
        private System.Windows.Forms.RadioButton rbAlgoConnectedComponents;
        private System.Windows.Forms.Button pbTest;
        private System.Windows.Forms.RadioButton rbAlgoCombined;
        private System.Windows.Forms.TextBox txtBackgroundTreshold;
        private System.Windows.Forms.CheckBox chkBlackBackground;
        private System.Windows.Forms.Label label26;
        private Controls.CollapsibleControl collapsibleControlImageEnhancement;
        private System.Windows.Forms.Button pbDleteImageEnhancement;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbImageEnhancementProfile;
        private System.Windows.Forms.Button pbSaveImageEnhancement;
        private System.Windows.Forms.CheckBox chkVerticalSplit;
        private System.Windows.Forms.CheckBox chkIncludePageIfNoPanelDetected;
        private System.Windows.Forms.CheckBox chkManga;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox chkInvertPages;
        private System.Windows.Forms.RadioButton rbAlgoCropOnly;
        private System.Windows.Forms.TextBox txtPdfFileName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button pbConcatenate;
        private System.Windows.Forms.CheckBox cbHorizontalOnly;
        private System.Windows.Forms.GroupBox gbSharpen2;
        private System.Windows.Forms.GroupBox gbDescreening;
        private System.Windows.Forms.CheckBox chkMedianFilter;
        private System.Windows.Forms.CheckBox chkGaussianBlur;
        private System.Windows.Forms.TextBox txtGaussianBlurSigma;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtGaussianBlurKernel;
        private System.Windows.Forms.Label lOriginalSize;
        private System.Windows.Forms.GroupBox gbLocalDrive;
        private System.Windows.Forms.CheckBox chkUseKindleLocalDrive;
        private System.Windows.Forms.GroupBox gbScp;
        private System.Windows.Forms.TextBox txtScpPrivateKeyFile;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckBox chkUseScp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtScpHost;
        private System.Windows.Forms.PictureBox pHostAvailable;
        private System.Windows.Forms.TextBox txtScpUserName;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cbScpDirectoryList;
        private System.Windows.Forms.TextBox txtScpRemotePath;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
    }
}

