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

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.subtractionToolStripMenuItem,
            this.webcamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 0;

            // fileToolStripMenuItem
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Text = "File";

            // openToolStripMenuItem
            this.openToolStripMenuItem.Text = "Open Image";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);

            // saveToolStripMenuItem
            this.saveToolStripMenuItem.Text = "Save Image";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);

            // exitToolStripMenuItem
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            // filtersToolStripMenuItem
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicCopyToolStripMenuItem,
            this.greyscaleToolStripMenuItem,
            this.colorInversionToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.filtersToolStripMenuItem.Text = "Filters";

            // basicCopyToolStripMenuItem
            this.basicCopyToolStripMenuItem.Text = "Basic Copy";
            this.basicCopyToolStripMenuItem.Click += new System.EventHandler(this.basicCopyToolStripMenuItem_Click);

            // greyscaleToolStripMenuItem
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);

            // colorInversionToolStripMenuItem
            this.colorInversionToolStripMenuItem.Text = "Color Inversion";
            this.colorInversionToolStripMenuItem.Click += new System.EventHandler(this.colorInversionToolStripMenuItem_Click);

            // sepiaToolStripMenuItem
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);

            // histogramToolStripMenuItem
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);

            // subtractionToolStripMenuItem
            this.subtractionToolStripMenuItem.Text = "Subtraction";
            this.subtractionToolStripMenuItem.Click += new System.EventHandler(this.subtractionToolStripMenuItem_Click);

            // webcamToolStripMenuItem
            this.webcamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWebcamToolStripMenuItem,
            this.stopWebcamToolStripMenuItem,
            this.webcamFiltersToolStripMenuItem});
            this.webcamToolStripMenuItem.Text = "Webcam";

            // startWebcamToolStripMenuItem
            this.startWebcamToolStripMenuItem.Text = "Start Webcam";
            this.startWebcamToolStripMenuItem.Click += new System.EventHandler(this.startWebcamToolStripMenuItem_Click);

            // stopWebcamToolStripMenuItem
            this.stopWebcamToolStripMenuItem.Text = "Stop Webcam";
            this.stopWebcamToolStripMenuItem.Click += new System.EventHandler(this.stopWebcamToolStripMenuItem_Click);

            // webcamFiltersToolStripMenuItem
            this.webcamFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webcamNoFilterToolStripMenuItem,
            this.webcamBasicCopyToolStripMenuItem,
            this.webcamGreyscaleToolStripMenuItem,
            this.webcamInversionToolStripMenuItem,
            this.webcamSepiaToolStripMenuItem});
            this.webcamFiltersToolStripMenuItem.Text = "Webcam Filters";

            // webcamNoFilterToolStripMenuItem
            this.webcamNoFilterToolStripMenuItem.Text = "No Filter";
            this.webcamNoFilterToolStripMenuItem.Click += new System.EventHandler(this.webcamNoFilterToolStripMenuItem_Click);

            // webcamBasicCopyToolStripMenuItem
            this.webcamBasicCopyToolStripMenuItem.Text = "Basic Copy";
            this.webcamBasicCopyToolStripMenuItem.Click += new System.EventHandler(this.webcamBasicCopyToolStripMenuItem_Click);

            // webcamGreyscaleToolStripMenuItem
            this.webcamGreyscaleToolStripMenuItem.Text = "Greyscale";
            this.webcamGreyscaleToolStripMenuItem.Click += new System.EventHandler(this.webcamGreyscaleToolStripMenuItem_Click);

            // webcamInversionToolStripMenuItem
            this.webcamInversionToolStripMenuItem.Text = "Inversion";
            this.webcamInversionToolStripMenuItem.Click += new System.EventHandler(this.webcamInversionToolStripMenuItem_Click);

            // webcamSepiaToolStripMenuItem
            this.webcamSepiaToolStripMenuItem.Text = "Sepia";
            this.webcamSepiaToolStripMenuItem.Click += new System.EventHandler(this.webcamSepiaToolStripMenuItem_Click);

            // groupBoxWebcam
            this.groupBoxWebcam.Controls.Add(this.btnRefreshWebcams);
            this.groupBoxWebcam.Controls.Add(this.pictureBoxWebcamOriginal);
            this.groupBoxWebcam.Controls.Add(this.pictureBoxWebcamProcessed);
            this.groupBoxWebcam.Controls.Add(this.comboBoxWebcamDevices);
            this.groupBoxWebcam.Controls.Add(this.btnStartWebcam);
            this.groupBoxWebcam.Controls.Add(this.btnStopWebcam);
            this.groupBoxWebcam.Location = new System.Drawing.Point(12, 40);
            this.groupBoxWebcam.Size = new System.Drawing.Size(560, 400);
            this.groupBoxWebcam.Text = "Webcam";

            this.btnRefreshWebcams.Location = new System.Drawing.Point(380, 250);
            this.btnRefreshWebcams.Text = "Refresh";
            this.btnRefreshWebcams.Click += new System.EventHandler(this.btnRefreshWebcams_Click);

            this.pictureBoxWebcamOriginal.Location = new System.Drawing.Point(10, 30);
            this.pictureBoxWebcamOriginal.Size = new System.Drawing.Size(260, 200);
            this.pictureBoxWebcamOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWebcamOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.pictureBoxWebcamProcessed.Location = new System.Drawing.Point(280, 30);
            this.pictureBoxWebcamProcessed.Size = new System.Drawing.Size(260, 200);
            this.pictureBoxWebcamProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWebcamProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.comboBoxWebcamDevices.Location = new System.Drawing.Point(10, 250);
            this.comboBoxWebcamDevices.Size = new System.Drawing.Size(200, 24);

            this.btnStartWebcam.Location = new System.Drawing.Point(220, 250);
            this.btnStartWebcam.Text = "Start";
            this.btnStartWebcam.Click += new System.EventHandler(this.btnStartWebcam_Click);

            this.btnStopWebcam.Location = new System.Drawing.Point(300, 250);
            this.btnStopWebcam.Text = "Stop";
            this.btnStopWebcam.Click += new System.EventHandler(this.btnStopWebcam_Click);

            // groupBoxSubtraction
            this.btnLoadBackgroundForWebcam = new System.Windows.Forms.Button();
            this.btnWebcamSubtraction = new System.Windows.Forms.Button();
            this.labelWebcamStatus = new System.Windows.Forms.Label();

            this.groupBoxWebcam.Controls.Add(this.btnLoadBackgroundForWebcam);
            this.groupBoxWebcam.Controls.Add(this.btnWebcamSubtraction);
            this.groupBoxWebcam.Controls.Add(this.labelWebcamStatus);

            this.btnLoadBackgroundForWebcam.Location = new System.Drawing.Point(10, 300);
            this.btnLoadBackgroundForWebcam.Size = new System.Drawing.Size(200, 30);
            this.btnLoadBackgroundForWebcam.Text = "Load Background for Webcam";
            this.btnLoadBackgroundForWebcam.Click += new System.EventHandler(this.btnLoadBackgroundForWebcam_Click);

            this.btnWebcamSubtraction.Location = new System.Drawing.Point(220, 300);
            this.btnWebcamSubtraction.Size = new System.Drawing.Size(200, 30);
            this.btnWebcamSubtraction.Text = "Toggle Webcam Subtraction";
            this.btnWebcamSubtraction.Click += new System.EventHandler(this.btnWebcamSubtraction_Click);

            this.labelWebcamStatus.Location = new System.Drawing.Point(10, 340);
            this.labelWebcamStatus.AutoSize = true;
            this.labelWebcamStatus.Text = "Webcam Subtraction: OFF";

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
            this.groupBoxSubtraction.Size = new System.Drawing.Size(560, 400);
            this.groupBoxSubtraction.Text = "Image Subtraction";
            this.groupBoxSubtraction.Visible = false;

            this.pictureBoxSubtractionResult.Location = new System.Drawing.Point(380, 50);
            this.pictureBoxSubtractionResult.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxSubtractionResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSubtractionResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.pictureBoxImageA.Location = new System.Drawing.Point(200, 50);
            this.pictureBoxImageA.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImageA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.pictureBoxImageB.Location = new System.Drawing.Point(20, 50);
            this.pictureBoxImageB.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImageB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnLoadImageA.Location = new System.Drawing.Point(200, 220);
            this.btnLoadImageA.Text = "Load Image A (Background)";
            this.btnLoadImageA.Click += new System.EventHandler(this.btnLoadImageA_Click);

            this.btnLoadImageB.Location = new System.Drawing.Point(20, 220);
            this.btnLoadImageB.Text = "Load Image B (Green Screen)";
            this.btnLoadImageB.Click += new System.EventHandler(this.btnLoadImageB_Click);

            this.btnApplySubtraction.Location = new System.Drawing.Point(380, 220);
            this.btnApplySubtraction.Text = "Apply Subtraction";
            this.btnApplySubtraction.Click += new System.EventHandler(this.btnApplySubtraction_Click);

            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Text = "Image B (Green Screen)";
            this.label1.AutoSize = true;

            this.label2.Location = new System.Drawing.Point(200, 30);
            this.label2.Text = "Image A (Background)";
            this.label2.AutoSize = true;

            this.label3.Location = new System.Drawing.Point(380, 30);
            this.label3.Text = "Result";
            this.label3.AutoSize = true;

            // groupBoxImageProcessing
            this.groupBoxImageProcessing.Controls.Add(this.pictureBoxProcessed);
            this.groupBoxImageProcessing.Controls.Add(this.pictureBoxOriginal);
            this.groupBoxImageProcessing.Controls.Add(this.btnLoadImage);
            this.groupBoxImageProcessing.Location = new System.Drawing.Point(12, 40);
            this.groupBoxImageProcessing.Size = new System.Drawing.Size(560, 400);
            this.groupBoxImageProcessing.Text = "Image Processing";

            this.pictureBoxProcessed.Location = new System.Drawing.Point(280, 50);
            this.pictureBoxProcessed.Size = new System.Drawing.Size(260, 200);
            this.pictureBoxProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.pictureBoxOriginal.Location = new System.Drawing.Point(10, 50);
            this.pictureBoxOriginal.Size = new System.Drawing.Size(260, 200);
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnLoadImage.Location = new System.Drawing.Point(10, 270);
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);

            // openFileDialog1
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // saveFileDialog1
            this.saveFileDialog1.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp";

            // openFileDialog2
            this.openFileDialog2.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // openFileDialog3
            this.openFileDialog3.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);

            this.statusLabel.Text = "Ready";

            // timerWebcam
            this.timerWebcam.Interval = 100;
            this.timerWebcam.Tick += new System.EventHandler(this.timerWebcam_Tick);

            // Form1
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.groupBoxImageProcessing);
            this.Controls.Add(this.groupBoxWebcam);
            this.Controls.Add(this.groupBoxSubtraction);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Image Processing - Salvame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxWebcam.ResumeLayout(false);
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

        private System.Windows.Forms.Button btnLoadBackgroundForWebcam;
        private System.Windows.Forms.Button btnWebcamSubtraction;
        private System.Windows.Forms.Label labelWebcamStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
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