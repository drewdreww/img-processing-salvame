namespace ImageProcessingSalvame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWebcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWebcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamNoFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamBasicCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamGreyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamSepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxWebcam = new System.Windows.Forms.GroupBox();
            this.btnRefreshWebcams = new System.Windows.Forms.Button();
            this.pictureBoxWebcamOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxWebcamProcessed = new System.Windows.Forms.PictureBox();
            this.comboBoxWebcamDevices = new System.Windows.Forms.ComboBox();
            this.btnStartWebcam = new System.Windows.Forms.Button();
            this.btnStopWebcam = new System.Windows.Forms.Button();
            this.btnLoadBackgroundForWebcam = new System.Windows.Forms.Button();
            this.btnWebcamSubtraction = new System.Windows.Forms.Button();
            this.labelWebcamStatus = new System.Windows.Forms.Label();
            this.groupBoxSubtraction = new System.Windows.Forms.GroupBox();
            this.pictureBoxSubtractionResult = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageA = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageB = new System.Windows.Forms.PictureBox();
            this.btnLoadImageA = new System.Windows.Forms.Button();
            this.btnLoadImageB = new System.Windows.Forms.Button();
            this.btnApplySubtraction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxImageProcessing = new System.Windows.Forms.GroupBox();
            this.pictureBoxProcessed = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerWebcam = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();

            this.menuStrip1.SuspendLayout();
            this.groupBoxWebcam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamProcessed)).BeginInit();
            this.groupBoxSubtraction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtractionResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageB)).BeginInit();
            this.groupBoxImageProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.subtractionToolStripMenuItem,
            this.webcamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.openToolStripMenuItem.Text = "Open Image";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.saveToolStripMenuItem.Text = "Save Image";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            // Initialize ALL menu items first
            this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionToolStripMenuItem.Text = "Convolution";

            this.basicCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicCopyToolStripMenuItem.Text = "Basic Copy";
            this.basicCopyToolStripMenuItem.Click += new System.EventHandler(this.basicCopyToolStripMenuItem_Click);

            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);

            this.colorInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorInversionToolStripMenuItem.Text = "Color Inversion";
            this.colorInversionToolStripMenuItem.Click += new System.EventHandler(this.colorInversionToolStripMenuItem_Click);

            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);

            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);

            // Initialize convolution sub-menu items
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);

            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);

            this.edgeDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectToolStripMenuItem.Text = "Edge Detect";
            this.edgeDetectToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectToolStripMenuItem_Click);

            this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossToolStripMenuItem.Text = "Emboss";
            this.embossToolStripMenuItem.Click += new System.EventHandler(this.embossToolStripMenuItem_Click);

            this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianToolStripMenuItem.Click += new System.EventHandler(this.gaussianToolStripMenuItem_Click);

            // Set up convolution sub-menu
            this.convolutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.edgeDetectToolStripMenuItem,
            this.embossToolStripMenuItem,
            this.gaussianToolStripMenuItem});
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convolutionToolStripMenuItem,
            this.basicCopyToolStripMenuItem,
            this.greyscaleToolStripMenuItem,
            this.colorInversionToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // convolutionToolStripMenuItem
            // 
            this.convolutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.edgeDetectToolStripMenuItem,
            this.embossToolStripMenuItem,
            this.gaussianToolStripMenuItem});
            this.convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            this.convolutionToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.convolutionToolStripMenuItem.Text = "Convolution";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // edgeDetectToolStripMenuItem
            // 
            this.edgeDetectToolStripMenuItem.Name = "edgeDetectToolStripMenuItem";
            this.edgeDetectToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.edgeDetectToolStripMenuItem.Text = "Edge Detect";
            this.edgeDetectToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectToolStripMenuItem_Click);
            // 
            // embossToolStripMenuItem
            // 
            this.embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            this.embossToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.embossToolStripMenuItem.Text = "Emboss";
            this.embossToolStripMenuItem.Click += new System.EventHandler(this.embossToolStripMenuItem_Click);
            // 
            // gaussianToolStripMenuItem
            // 
            this.gaussianToolStripMenuItem.Name = "gaussianToolStripMenuItem";
            this.gaussianToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.gaussianToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianToolStripMenuItem.Click += new System.EventHandler(this.gaussianToolStripMenuItem_Click);
            // 
            // basicCopyToolStripMenuItem
            // 
            this.basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            this.basicCopyToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.basicCopyToolStripMenuItem.Text = "Basic Copy";
            this.basicCopyToolStripMenuItem.Click += new System.EventHandler(this.basicCopyToolStripMenuItem_Click);
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);
            // 
            // colorInversionToolStripMenuItem
            // 
            this.colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            this.colorInversionToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.colorInversionToolStripMenuItem.Text = "Color Inversion";
            this.colorInversionToolStripMenuItem.Click += new System.EventHandler(this.colorInversionToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // subtractionToolStripMenuItem
            // 
            this.subtractionToolStripMenuItem.Name = "subtractionToolStripMenuItem";
            this.subtractionToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.subtractionToolStripMenuItem.Text = "Subtraction";
            this.subtractionToolStripMenuItem.Click += new System.EventHandler(this.subtractionToolStripMenuItem_Click);
            // 
            // webcamToolStripMenuItem
            // 
            this.webcamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWebcamToolStripMenuItem,
            this.stopWebcamToolStripMenuItem,
            this.webcamFiltersToolStripMenuItem});
            this.webcamToolStripMenuItem.Name = "webcamToolStripMenuItem";
            this.webcamToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.webcamToolStripMenuItem.Text = "Webcam";
            // 
            // startWebcamToolStripMenuItem
            // 
            this.startWebcamToolStripMenuItem.Name = "startWebcamToolStripMenuItem";
            this.startWebcamToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.startWebcamToolStripMenuItem.Text = "Start Webcam";
            this.startWebcamToolStripMenuItem.Click += new System.EventHandler(this.startWebcamToolStripMenuItem_Click);
            // 
            // stopWebcamToolStripMenuItem
            // 
            this.stopWebcamToolStripMenuItem.Name = "stopWebcamToolStripMenuItem";
            this.stopWebcamToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.stopWebcamToolStripMenuItem.Text = "Stop Webcam";
            this.stopWebcamToolStripMenuItem.Click += new System.EventHandler(this.stopWebcamToolStripMenuItem_Click);
            // 
            // webcamFiltersToolStripMenuItem
            // 
            this.webcamFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webcamNoFilterToolStripMenuItem,
            this.webcamBasicCopyToolStripMenuItem,
            this.webcamGreyscaleToolStripMenuItem,
            this.webcamInversionToolStripMenuItem,
            this.webcamSepiaToolStripMenuItem});
            this.webcamFiltersToolStripMenuItem.Name = "webcamFiltersToolStripMenuItem";
            this.webcamFiltersToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.webcamFiltersToolStripMenuItem.Text = "Webcam Filters";
            // 
            // webcamNoFilterToolStripMenuItem
            // 
            this.webcamNoFilterToolStripMenuItem.Name = "webcamNoFilterToolStripMenuItem";
            this.webcamNoFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.webcamNoFilterToolStripMenuItem.Text = "No Filter";
            this.webcamNoFilterToolStripMenuItem.Click += new System.EventHandler(this.webcamNoFilterToolStripMenuItem_Click);
            // 
            // webcamBasicCopyToolStripMenuItem
            // 
            this.webcamBasicCopyToolStripMenuItem.Name = "webcamBasicCopyToolStripMenuItem";
            this.webcamBasicCopyToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.webcamBasicCopyToolStripMenuItem.Text = "Basic Copy";
            this.webcamBasicCopyToolStripMenuItem.Click += new System.EventHandler(this.webcamBasicCopyToolStripMenuItem_Click);
            // 
            // webcamGreyscaleToolStripMenuItem
            // 
            this.webcamGreyscaleToolStripMenuItem.Name = "webcamGreyscaleToolStripMenuItem";
            this.webcamGreyscaleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.webcamGreyscaleToolStripMenuItem.Text = "Greyscale";
            this.webcamGreyscaleToolStripMenuItem.Click += new System.EventHandler(this.webcamGreyscaleToolStripMenuItem_Click);
            // 
            // webcamInversionToolStripMenuItem
            // 
            this.webcamInversionToolStripMenuItem.Name = "webcamInversionToolStripMenuItem";
            this.webcamInversionToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.webcamInversionToolStripMenuItem.Text = "Inversion";
            this.webcamInversionToolStripMenuItem.Click += new System.EventHandler(this.webcamInversionToolStripMenuItem_Click);
            // 
            // webcamSepiaToolStripMenuItem
            // 
            this.webcamSepiaToolStripMenuItem.Name = "webcamSepiaToolStripMenuItem";
            this.webcamSepiaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.webcamSepiaToolStripMenuItem.Text = "Sepia";
            this.webcamSepiaToolStripMenuItem.Click += new System.EventHandler(this.webcamSepiaToolStripMenuItem_Click);
            // 
            // groupBoxWebcam
            // 
            this.groupBoxWebcam.Controls.Add(this.btnLoadBackgroundForWebcam);
            this.groupBoxWebcam.Controls.Add(this.btnWebcamSubtraction);
            this.groupBoxWebcam.Controls.Add(this.labelWebcamStatus);
            this.groupBoxWebcam.Controls.Add(this.btnRefreshWebcams);
            this.groupBoxWebcam.Controls.Add(this.pictureBoxWebcamOriginal);
            this.groupBoxWebcam.Controls.Add(this.pictureBoxWebcamProcessed);
            this.groupBoxWebcam.Controls.Add(this.comboBoxWebcamDevices);
            this.groupBoxWebcam.Controls.Add(this.btnStartWebcam);
            this.groupBoxWebcam.Controls.Add(this.btnStopWebcam);
            this.groupBoxWebcam.Location = new System.Drawing.Point(12, 40);
            this.groupBoxWebcam.Name = "groupBoxWebcam";
            this.groupBoxWebcam.Size = new System.Drawing.Size(560, 400);
            this.groupBoxWebcam.TabIndex = 1;
            this.groupBoxWebcam.TabStop = false;
            this.groupBoxWebcam.Text = "Webcam";
            this.groupBoxWebcam.Visible = false;
            // 
            // btnRefreshWebcams
            // 
            this.btnRefreshWebcams.Location = new System.Drawing.Point(380, 250);
            this.btnRefreshWebcams.Name = "btnRefreshWebcams";
            this.btnRefreshWebcams.Size = new System.Drawing.Size(75, 30);
            this.btnRefreshWebcams.TabIndex = 5;
            this.btnRefreshWebcams.Text = "Refresh";
            this.btnRefreshWebcams.UseVisualStyleBackColor = true;
            this.btnRefreshWebcams.Click += new System.EventHandler(this.btnRefreshWebcams_Click);
            // 
            // pictureBoxWebcamOriginal
            // 
            this.pictureBoxWebcamOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWebcamOriginal.Location = new System.Drawing.Point(10, 30);
            this.pictureBoxWebcamOriginal.Name = "pictureBoxWebcamOriginal";
            this.pictureBoxWebcamOriginal.Size = new System.Drawing.Size(260, 200);
            this.pictureBoxWebcamOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWebcamOriginal.TabIndex = 0;
            this.pictureBoxWebcamOriginal.TabStop = false;
            // 
            // pictureBoxWebcamProcessed
            // 
            this.pictureBoxWebcamProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWebcamProcessed.Location = new System.Drawing.Point(280, 30);
            this.pictureBoxWebcamProcessed.Name = "pictureBoxWebcamProcessed";
            this.pictureBoxWebcamProcessed.Size = new System.Drawing.Size(260, 200);
            this.pictureBoxWebcamProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWebcamProcessed.TabIndex = 1;
            this.pictureBoxWebcamProcessed.TabStop = false;
            // 
            // comboBoxWebcamDevices
            // 
            this.comboBoxWebcamDevices.FormattingEnabled = true;
            this.comboBoxWebcamDevices.Location = new System.Drawing.Point(10, 250);
            this.comboBoxWebcamDevices.Name = "comboBoxWebcamDevices";
            this.comboBoxWebcamDevices.Size = new System.Drawing.Size(200, 24);
            this.comboBoxWebcamDevices.TabIndex = 2;
            // 
            // btnStartWebcam
            // 
            this.btnStartWebcam.Location = new System.Drawing.Point(220, 250);
            this.btnStartWebcam.Name = "btnStartWebcam";
            this.btnStartWebcam.Size = new System.Drawing.Size(75, 30);
            this.btnStartWebcam.TabIndex = 3;
            this.btnStartWebcam.Text = "Start";
            this.btnStartWebcam.UseVisualStyleBackColor = true;
            this.btnStartWebcam.Click += new System.EventHandler(this.btnStartWebcam_Click);
            // 
            // btnStopWebcam
            // 
            this.btnStopWebcam.Location = new System.Drawing.Point(300, 250);
            this.btnStopWebcam.Name = "btnStopWebcam";
            this.btnStopWebcam.Size = new System.Drawing.Size(75, 30);
            this.btnStopWebcam.TabIndex = 4;
            this.btnStopWebcam.Text = "Stop";
            this.btnStopWebcam.UseVisualStyleBackColor = true;
            this.btnStopWebcam.Click += new System.EventHandler(this.btnStopWebcam_Click);
            // 
            // btnLoadBackgroundForWebcam
            // 
            this.btnLoadBackgroundForWebcam.Location = new System.Drawing.Point(10, 300);
            this.btnLoadBackgroundForWebcam.Name = "btnLoadBackgroundForWebcam";
            this.btnLoadBackgroundForWebcam.Size = new System.Drawing.Size(200, 30);
            this.btnLoadBackgroundForWebcam.TabIndex = 6;
            this.btnLoadBackgroundForWebcam.Text = "Load Background for Webcam";
            this.btnLoadBackgroundForWebcam.UseVisualStyleBackColor = true;
            this.btnLoadBackgroundForWebcam.Click += new System.EventHandler(this.btnLoadBackgroundForWebcam_Click);
            // 
            // btnWebcamSubtraction
            // 
            this.btnWebcamSubtraction.Location = new System.Drawing.Point(220, 300);
            this.btnWebcamSubtraction.Name = "btnWebcamSubtraction";
            this.btnWebcamSubtraction.Size = new System.Drawing.Size(200, 30);
            this.btnWebcamSubtraction.TabIndex = 7;
            this.btnWebcamSubtraction.Text = "Toggle Webcam Subtraction";
            this.btnWebcamSubtraction.UseVisualStyleBackColor = true;
            this.btnWebcamSubtraction.Click += new System.EventHandler(this.btnWebcamSubtraction_Click);
            // 
            // labelWebcamStatus
            // 
            this.labelWebcamStatus.AutoSize = true;
            this.labelWebcamStatus.Location = new System.Drawing.Point(10, 340);
            this.labelWebcamStatus.Name = "labelWebcamStatus";
            this.labelWebcamStatus.Size = new System.Drawing.Size(172, 16);
            this.labelWebcamStatus.TabIndex = 8;
            this.labelWebcamStatus.Text = "Webcam Subtraction: OFF";
            // 
            // groupBoxSubtraction
            // 
            this.groupBoxSubtraction.Controls.Add(this.pictureBoxSubtractionResult);
            this.groupBoxSubtraction.Controls.Add(this.pictureBoxImageA);
            this.groupBoxSubtraction.Controls.Add(this.pictureBoxImageB);
            this.groupBoxSubtraction.Controls.Add(this.btnLoadImageA);
            this.groupBoxSubtraction.Controls.Add(this.btnLoadImageB);
            this.groupBoxSubtraction.Controls.Add(this.btnApplySubtraction);
            this.groupBoxSubtraction.Controls.Add(this.label1);
            this.groupBoxSubtraction.Controls.Add(this.label2);
            this.groupBoxSubtraction.Controls.Add(this.label3);
            this.groupBoxSubtraction.Location = new System.Drawing.Point(600, 40);
            this.groupBoxSubtraction.Name = "groupBoxSubtraction";
            this.groupBoxSubtraction.Size = new System.Drawing.Size(560, 400);
            this.groupBoxSubtraction.TabIndex = 2;
            this.groupBoxSubtraction.TabStop = false;
            this.groupBoxSubtraction.Text = "Image Subtraction";
            this.groupBoxSubtraction.Visible = false;
            // 
            // pictureBoxSubtractionResult
            // 
            this.pictureBoxSubtractionResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSubtractionResult.Location = new System.Drawing.Point(380, 50);
            this.pictureBoxSubtractionResult.Name = "pictureBoxSubtractionResult";
            this.pictureBoxSubtractionResult.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxSubtractionResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSubtractionResult.TabIndex = 8;
            this.pictureBoxSubtractionResult.TabStop = false;
            // 
            // pictureBoxImageA
            // 
            this.pictureBoxImageA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageA.Location = new System.Drawing.Point(200, 50);
            this.pictureBoxImageA.Name = "pictureBoxImageA";
            this.pictureBoxImageA.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImageA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageA.TabIndex = 7;
            this.pictureBoxImageA.TabStop = false;
            // 
            // pictureBoxImageB
            // 
            this.pictureBoxImageB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageB.Location = new System.Drawing.Point(20, 50);
            this.pictureBoxImageB.Name = "pictureBoxImageB";
            this.pictureBoxImageB.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImageB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageB.TabIndex = 6;
            this.pictureBoxImageB.TabStop = false;
            // 
            // btnLoadImageA
            // 
            this.btnLoadImageA.Location = new System.Drawing.Point(200, 220);
            this.btnLoadImageA.Name = "btnLoadImageA";
            this.btnLoadImageA.Size = new System.Drawing.Size(150, 30);
            this.btnLoadImageA.TabIndex = 5;
            this.btnLoadImageA.Text = "Load Image A (Background)";
            this.btnLoadImageA.UseVisualStyleBackColor = true;
            this.btnLoadImageA.Click += new System.EventHandler(this.btnLoadImageA_Click);
            // 
            // btnLoadImageB
            // 
            this.btnLoadImageB.Location = new System.Drawing.Point(20, 220);
            this.btnLoadImageB.Name = "btnLoadImageB";
            this.btnLoadImageB.Size = new System.Drawing.Size(150, 30);
            this.btnLoadImageB.TabIndex = 4;
            this.btnLoadImageB.Text = "Load Image B (Green Screen)";
            this.btnLoadImageB.UseVisualStyleBackColor = true;
            this.btnLoadImageB.Click += new System.EventHandler(this.btnLoadImageB_Click);
            // 
            // btnApplySubtraction
            // 
            this.btnApplySubtraction.Location = new System.Drawing.Point(380, 220);
            this.btnApplySubtraction.Name = "btnApplySubtraction";
            this.btnApplySubtraction.Size = new System.Drawing.Size(150, 30);
            this.btnApplySubtraction.TabIndex = 3;
            this.btnApplySubtraction.Text = "Apply Subtraction";
            this.btnApplySubtraction.UseVisualStyleBackColor = true;
            this.btnApplySubtraction.Click += new System.EventHandler(this.btnApplySubtraction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image B (Green Screen)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image A (Background)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // groupBoxImageProcessing
            // 
            this.groupBoxImageProcessing.Controls.Add(this.pictureBoxProcessed);
            this.groupBoxImageProcessing.Controls.Add(this.pictureBoxOriginal);
            this.groupBoxImageProcessing.Controls.Add(this.btnLoadImage);
            this.groupBoxImageProcessing.Location = new System.Drawing.Point(12, 40);
            this.groupBoxImageProcessing.Name = "groupBoxImageProcessing";
            this.groupBoxImageProcessing.Size = new System.Drawing.Size(560, 400);
            this.groupBoxImageProcessing.TabIndex = 3;
            this.groupBoxImageProcessing.TabStop = false;
            this.groupBoxImageProcessing.Text = "Image Processing";
            // 
            // pictureBoxProcessed
            // 
            this.pictureBoxProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProcessed.Location = new System.Drawing.Point(280, 50);
            this.pictureBoxProcessed.Name = "pictureBoxProcessed";
            this.pictureBoxProcessed.Size = new System.Drawing.Size(260, 200);
            this.pictureBoxProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProcessed.TabIndex = 2;
            this.pictureBoxProcessed.TabStop = false;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(10, 50);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(260, 200);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 1;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(10, 270);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(120, 30);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(45, 16);
            this.statusLabel.Text = "Ready";
            // 
            // timerWebcam
            // 
            this.timerWebcam.Interval = 100;
            this.timerWebcam.Tick += new System.EventHandler(this.timerWebcam_Tick);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.groupBoxImageProcessing);
            this.Controls.Add(this.groupBoxWebcam);
            this.Controls.Add(this.groupBoxSubtraction);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing - Salvame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxWebcam.ResumeLayout(false);
            this.groupBoxWebcam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcamProcessed)).EndInit();
            this.groupBoxSubtraction.ResumeLayout(false);
            this.groupBoxSubtraction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtractionResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageB)).EndInit();
            this.groupBoxImageProcessing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorInversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webcamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWebcamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopWebcamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webcamFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webcamNoFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webcamBasicCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webcamGreyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webcamInversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webcamSepiaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxWebcam;
        private System.Windows.Forms.PictureBox pictureBoxWebcamOriginal;
        private System.Windows.Forms.PictureBox pictureBoxWebcamProcessed;
        private System.Windows.Forms.ComboBox comboBoxWebcamDevices;
        private System.Windows.Forms.Button btnStartWebcam;
        private System.Windows.Forms.Button btnStopWebcam;
        private System.Windows.Forms.Button btnRefreshWebcams;
        private System.Windows.Forms.Button btnLoadBackgroundForWebcam;
        private System.Windows.Forms.Button btnWebcamSubtraction;
        private System.Windows.Forms.Label labelWebcamStatus;
        private System.Windows.Forms.GroupBox groupBoxSubtraction;
        private System.Windows.Forms.PictureBox pictureBoxSubtractionResult;
        private System.Windows.Forms.PictureBox pictureBoxImageA;
        private System.Windows.Forms.PictureBox pictureBoxImageB;
        private System.Windows.Forms.Button btnLoadImageA;
        private System.Windows.Forms.Button btnLoadImageB;
        private System.Windows.Forms.Button btnApplySubtraction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxImageProcessing;
        private System.Windows.Forms.PictureBox pictureBoxProcessed;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Timer timerWebcam;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
    }
}