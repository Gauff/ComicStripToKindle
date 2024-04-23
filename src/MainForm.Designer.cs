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
            this.panelImageEnhancement = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbDleteImageEnhancement = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.cbImageEnhancementProfile = new System.Windows.Forms.ComboBox();
            this.pbSaveImageEnhancement = new System.Windows.Forms.Button();
            this.chkGaussianSharpen = new System.Windows.Forms.CheckBox();
            this.txtSigma = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtKernel = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBlackLevel = new System.Windows.Forms.TextBox();
            this.chkLevelThreshold = new System.Windows.Forms.CheckBox();
            this.txtJpegQuality = new System.Windows.Forms.TextBox();
            this.txtRotationAngle = new System.Windows.Forms.TextBox();
            this.chkAutomaticContrastCorrection = new System.Windows.Forms.CheckBox();
            this.txtWhiteLevel = new System.Windows.Forms.TextBox();
            this.chkCorrectionSharpen = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAutomaticRotation = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelEreader = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbGenerateGammaScale = new System.Windows.Forms.Button();
            this.pVolumeConected = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDocumentDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVolumeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lConvertedSize = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pHidePreview = new System.Windows.Forms.Button();
            this.pOriginal = new System.Windows.Forms.PictureBox();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.pbAddComicDirectory = new System.Windows.Forms.Button();
            this.pbTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            this.panelComic.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.panelImageEnhancement.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelEreader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pVolumeConected)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panelEmailSettings.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPageConversionErrors.SuspendLayout();
            this.pPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pbConvert
            // 
            this.pbConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbConvert.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbConvert.Location = new System.Drawing.Point(614, 728);
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
            this.pbSelectComicFile.Location = new System.Drawing.Point(366, 729);
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
            this.txtPdfDirectory.Location = new System.Drawing.Point(64, 16);
            this.txtPdfDirectory.Name = "txtPdfDirectory";
            this.txtPdfDirectory.Size = new System.Drawing.Size(220, 22);
            this.txtPdfDirectory.TabIndex = 21;
            this.txtPdfDirectory.TextChanged += new System.EventHandler(this.txtPdfDirectory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "Directory:";
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
            this.lvFiles.Size = new System.Drawing.Size(640, 711);
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
            this.progressBar.Location = new System.Drawing.Point(614, 758);
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
            this.groupBox1.Size = new System.Drawing.Size(330, 673);
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
            this.txtErrors.Size = new System.Drawing.Size(317, 647);
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
            this.tabControl.Size = new System.Drawing.Size(350, 769);
            this.tabControl.TabIndex = 40;
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageConfiguration.Controls.Add(this.panelComic);
            this.tabPageConfiguration.Controls.Add(this.panelImageEnhancement);
            this.tabPageConfiguration.Controls.Add(this.panelEreader);
            this.tabPageConfiguration.Controls.Add(this.collapsibleControlImageEnhancement);
            this.tabPageConfiguration.Controls.Add(this.panelOutput);
            this.tabPageConfiguration.Controls.Add(this.collapsibleControlEmail);
            this.tabPageConfiguration.Controls.Add(this.collapsibleControlComic);
            this.tabPageConfiguration.Controls.Add(this.collapsibleControlEreader);
            this.tabPageConfiguration.Controls.Add(this.panelEmailSettings);
            this.tabPageConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 23);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(342, 742);
            this.tabPageConfiguration.TabIndex = 0;
            this.tabPageConfiguration.Text = "Configuration";
            // 
            // panelComic
            // 
            this.panelComic.Controls.Add(this.groupBox6);
            this.panelComic.Location = new System.Drawing.Point(2, 105);
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
            // panelImageEnhancement
            // 
            this.panelImageEnhancement.Controls.Add(this.groupBox4);
            this.panelImageEnhancement.Location = new System.Drawing.Point(6, 305);
            this.panelImageEnhancement.Name = "panelImageEnhancement";
            this.panelImageEnhancement.Size = new System.Drawing.Size(343, 226);
            this.panelImageEnhancement.TabIndex = 50;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.pbDleteImageEnhancement);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.cbImageEnhancementProfile);
            this.groupBox4.Controls.Add(this.pbSaveImageEnhancement);
            this.groupBox4.Controls.Add(this.chkGaussianSharpen);
            this.groupBox4.Controls.Add(this.txtSigma);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtKernel);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtBlackLevel);
            this.groupBox4.Controls.Add(this.chkLevelThreshold);
            this.groupBox4.Controls.Add(this.txtJpegQuality);
            this.groupBox4.Controls.Add(this.txtRotationAngle);
            this.groupBox4.Controls.Add(this.chkAutomaticContrastCorrection);
            this.groupBox4.Controls.Add(this.txtWhiteLevel);
            this.groupBox4.Controls.Add(this.chkCorrectionSharpen);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.chkAutomaticRotation);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox4.Location = new System.Drawing.Point(1, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 220);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image Enhancement && Quality";
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
            // chkGaussianSharpen
            // 
            this.chkGaussianSharpen.AutoSize = true;
            this.chkGaussianSharpen.Location = new System.Drawing.Point(6, 138);
            this.chkGaussianSharpen.Name = "chkGaussianSharpen";
            this.chkGaussianSharpen.Size = new System.Drawing.Size(117, 18);
            this.chkGaussianSharpen.TabIndex = 55;
            this.chkGaussianSharpen.Text = "Gaussian Sharpen:";
            this.chkGaussianSharpen.UseVisualStyleBackColor = true;
            this.chkGaussianSharpen.CheckedChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // txtSigma
            // 
            this.txtSigma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSigma.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSigma.Location = new System.Drawing.Point(235, 135);
            this.txtSigma.Name = "txtSigma";
            this.txtSigma.Size = new System.Drawing.Size(27, 21);
            this.txtSigma.TabIndex = 53;
            this.txtSigma.Text = "1";
            this.txtSigma.TextChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            this.txtSigma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSigma_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label21.Location = new System.Drawing.Point(194, 139);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 14);
            this.label21.TabIndex = 54;
            this.label21.Text = "Sigma:";
            // 
            // txtKernel
            // 
            this.txtKernel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKernel.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKernel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtKernel.Location = new System.Drawing.Point(165, 135);
            this.txtKernel.Name = "txtKernel";
            this.txtKernel.Size = new System.Drawing.Size(27, 21);
            this.txtKernel.TabIndex = 51;
            this.txtKernel.Text = "3";
            this.txtKernel.TextChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label20.Location = new System.Drawing.Point(124, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 14);
            this.label20.TabIndex = 52;
            this.label20.Text = "Kernel:";
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
            this.txtJpegQuality.Location = new System.Drawing.Point(79, 186);
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
            // chkCorrectionSharpen
            // 
            this.chkCorrectionSharpen.AutoSize = true;
            this.chkCorrectionSharpen.Location = new System.Drawing.Point(6, 162);
            this.chkCorrectionSharpen.Name = "chkCorrectionSharpen";
            this.chkCorrectionSharpen.Size = new System.Drawing.Size(67, 18);
            this.chkCorrectionSharpen.TabIndex = 37;
            this.chkCorrectionSharpen.Text = "Sharpen";
            this.chkCorrectionSharpen.UseVisualStyleBackColor = true;
            this.chkCorrectionSharpen.CheckedChanged += new System.EventHandler(this.UI_SaveImageEnhancementProfile);
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
            this.label16.Location = new System.Drawing.Point(7, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 14);
            this.label16.TabIndex = 45;
            this.label16.Text = "JPEG quality:";
            // 
            // panelEreader
            // 
            this.panelEreader.Controls.Add(this.groupBox2);
            this.panelEreader.Location = new System.Drawing.Point(88, 85);
            this.panelEreader.Name = "panelEreader";
            this.panelEreader.Size = new System.Drawing.Size(350, 214);
            this.panelEreader.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbGenerateGammaScale);
            this.groupBox2.Controls.Add(this.pVolumeConected);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDocumentDirectory);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtVolumeName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pbDeleteEreaderProfile);
            this.groupBox2.Controls.Add(this.cbEReaderProfile);
            this.groupBox2.Controls.Add(this.pbSaveEreaderProfile);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 208);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "E Ink E-Reader";
            // 
            // pbGenerateGammaScale
            // 
            this.pbGenerateGammaScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbGenerateGammaScale.Font = new System.Drawing.Font("Corbel", 8F);
            this.pbGenerateGammaScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbGenerateGammaScale.Location = new System.Drawing.Point(271, 134);
            this.pbGenerateGammaScale.Name = "pbGenerateGammaScale";
            this.pbGenerateGammaScale.Size = new System.Drawing.Size(58, 66);
            this.pbGenerateGammaScale.TabIndex = 50;
            this.pbGenerateGammaScale.Text = "Generate Gamma Scale";
            this.pbGenerateGammaScale.UseVisualStyleBackColor = true;
            this.pbGenerateGammaScale.Click += new System.EventHandler(this.pbGenerateGammaScale_Click);
            // 
            // pVolumeConected
            // 
            this.pVolumeConected.Location = new System.Drawing.Point(313, 112);
            this.pVolumeConected.Name = "pVolumeConected";
            this.pVolumeConected.Size = new System.Drawing.Size(16, 16);
            this.pVolumeConected.TabIndex = 48;
            this.pVolumeConected.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 14);
            this.label11.TabIndex = 49;
            this.label11.Text = "Status:";
            // 
            // txtDocumentDirectory
            // 
            this.txtDocumentDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDocumentDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDocumentDirectory.Location = new System.Drawing.Point(115, 178);
            this.txtDocumentDirectory.Name = "txtDocumentDirectory";
            this.txtDocumentDirectory.Size = new System.Drawing.Size(152, 22);
            this.txtDocumentDirectory.TabIndex = 47;
            this.txtDocumentDirectory.Text = "documents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 14);
            this.label3.TabIndex = 46;
            this.label3.Text = "Document Directory:";
            // 
            // txtVolumeName
            // 
            this.txtVolumeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVolumeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtVolumeName.Location = new System.Drawing.Point(115, 152);
            this.txtVolumeName.Name = "txtVolumeName";
            this.txtVolumeName.Size = new System.Drawing.Size(152, 22);
            this.txtVolumeName.TabIndex = 45;
            this.txtVolumeName.Text = "Kindle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 44;
            this.label2.Text = "Volume Name:";
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
            this.groupBox5.Size = new System.Drawing.Size(258, 100);
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
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.groupBox8);
            this.panelOutput.Location = new System.Drawing.Point(6, 540);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(330, 196);
            this.panelOutput.TabIndex = 51;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtPdfFileName);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.pbConcatenate);
            this.groupBox8.Controls.Add(this.chkSendByEmail);
            this.groupBox8.Controls.Add(this.chkOpenDirectoryAfterConversion);
            this.groupBox8.Controls.Add(this.chkCopyToEreader);
            this.groupBox8.Controls.Add(this.txtPdfDirectory);
            this.groupBox8.Controls.Add(this.pbSelectOutputDirectory);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox8.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox8.Location = new System.Drawing.Point(1, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(327, 190);
            this.groupBox8.TabIndex = 46;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Output";
            // 
            // txtPdfFileName
            // 
            this.txtPdfFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPdfFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPdfFileName.Location = new System.Drawing.Point(64, 113);
            this.txtPdfFileName.Name = "txtPdfFileName";
            this.txtPdfFileName.Size = new System.Drawing.Size(257, 22);
            this.txtPdfFileName.TabIndex = 50;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 119);
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
            this.pbConcatenate.Location = new System.Drawing.Point(233, 146);
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
            this.chkSendByEmail.Location = new System.Drawing.Point(9, 65);
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
            this.chkOpenDirectoryAfterConversion.Location = new System.Drawing.Point(9, 89);
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
            this.chkCopyToEreader.Location = new System.Drawing.Point(9, 41);
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
            this.pbSelectOutputDirectory.Location = new System.Drawing.Point(288, 16);
            this.pbSelectOutputDirectory.Name = "pbSelectOutputDirectory";
            this.pbSelectOutputDirectory.Size = new System.Drawing.Size(33, 20);
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
            this.panelEmailSettings.Location = new System.Drawing.Point(20, 120);
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
            this.tabPageConversionErrors.Size = new System.Drawing.Size(342, 742);
            this.tabPageConversionErrors.TabIndex = 1;
            this.tabPageConversionErrors.Text = "Conversion errors";
            // 
            // pbClearComicFiles
            // 
            this.pbClearComicFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbClearComicFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbClearComicFiles.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbClearComicFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbClearComicFiles.Location = new System.Drawing.Point(490, 729);
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
            this.pPreview.Controls.Add(this.lConvertedSize);
            this.pPreview.Controls.Add(this.label18);
            this.pPreview.Controls.Add(this.label17);
            this.pPreview.Controls.Add(this.pHidePreview);
            this.pPreview.Controls.Add(this.pOriginal);
            this.pPreview.Controls.Add(this.picturePreview);
            this.pPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pPreview.Location = new System.Drawing.Point(366, 200);
            this.pPreview.Name = "pPreview";
            this.pPreview.Size = new System.Drawing.Size(640, 521);
            this.pPreview.TabIndex = 42;
            this.pPreview.SizeChanged += new System.EventHandler(this.pPreview_SizeChanged);
            this.pPreview.Resize += new System.EventHandler(this.pPreview_Resize);
            // 
            // lConvertedSize
            // 
            this.lConvertedSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lConvertedSize.AutoSize = true;
            this.lConvertedSize.Location = new System.Drawing.Point(594, 502);
            this.lConvertedSize.Name = "lConvertedSize";
            this.lConvertedSize.Size = new System.Drawing.Size(13, 13);
            this.lConvertedSize.TabIndex = 47;
            this.lConvertedSize.Text = "0";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(519, 502);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Preview size:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 502);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Original";
            // 
            // pHidePreview
            // 
            this.pHidePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pHidePreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pHidePreview.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHidePreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pHidePreview.Location = new System.Drawing.Point(260, 493);
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
            this.pbAddComicDirectory.Location = new System.Drawing.Point(366, 758);
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
            this.pbTest.Location = new System.Drawing.Point(490, 758);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(118, 23);
            this.pbTest.TabIndex = 44;
            this.pbTest.Text = "Test";
            this.pbTest.UseVisualStyleBackColor = true;
            this.pbTest.Click += new System.EventHandler(this.pbTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1018, 787);
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
            this.panelImageEnhancement.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelEreader.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pVolumeConected)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lConvertedSize;
        private System.Windows.Forms.TextBox txtBlackLevel;
        private System.Windows.Forms.CheckBox chkLevelThreshold;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button pbAddComicDirectory;
        private System.Windows.Forms.TextBox txtSigma;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtKernel;
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
    }
}

