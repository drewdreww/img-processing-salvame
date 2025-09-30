using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WebCamLib;

namespace ImageProcessingSalvame
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap processedImage;
        private Bitmap imageB; // Green screen image
        private Bitmap imageA; // Background image
        private Bitmap webcamBackground; // Background for webcam subtraction

        // Webcam variables
        private Device currentWebcam;
        private Bitmap webcamFrame;
        private bool isWebcamRunning = false;
        private bool isWebcamSubtractionMode = false;
        private WebcamFilter currentWebcamFilter = WebcamFilter.NoFilter;

        private enum WebcamFilter
        {
            NoFilter,
            BasicCopy,
            Greyscale,
            Inversion,
            Sepia,
            Subtraction
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadWebcamDevices();
            groupBoxWebcam.Visible = false;
            groupBoxSubtraction.Visible = false;
            groupBoxImageProcessing.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopWebcam();

            // Clean up bitmaps
            originalImage?.Dispose();
            processedImage?.Dispose();
            imageA?.Dispose();
            imageB?.Dispose();
            webcamFrame?.Dispose();
            webcamBackground?.Dispose();
        }

        #region Image Loading Methods

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    originalImage?.Dispose();
                    originalImage = new Bitmap(openFileDialog1.FileName);
                    pictureBoxOriginal.Image = originalImage;
                    statusLabel.Text = $"Loaded: {Path.GetFileName(openFileDialog1.FileName)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLoadImage_Click(sender, e);
        }

        private void btnLoadImageA_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageA?.Dispose();
                    imageA = new Bitmap(openFileDialog2.FileName);
                    pictureBoxImageA.Image = imageA;
                    statusLabel.Text = $"Loaded Image A (Background): {Path.GetFileName(openFileDialog2.FileName)} - Size: {imageA.Width}x{imageA.Height}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadImageB_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageB?.Dispose();
                    imageB = new Bitmap(openFileDialog3.FileName);
                    pictureBoxImageB.Image = imageB;
                    statusLabel.Text = $"Loaded Image B (Green Screen): {Path.GetFileName(openFileDialog3.FileName)} - Size: {imageB.Width}x{imageB.Height}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadBackgroundForWebcam_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    webcamBackground?.Dispose();
                    webcamBackground = new Bitmap(openFileDialog1.FileName);
                    labelWebcamStatus.Text = "Background Loaded";
                    statusLabel.Text = $"Loaded background for webcam: {Path.GetFileName(openFileDialog1.FileName)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading background image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Part 1: Basic Image Processing Filters

        private void basicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedImage?.Dispose();
            processedImage = BasicCopy(originalImage);
            pictureBoxProcessed.Image = processedImage;
            statusLabel.Text = "Applied: Basic Copy";
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedImage?.Dispose();
            processedImage = ConvertToGrayscale(originalImage);
            pictureBoxProcessed.Image = processedImage;
            statusLabel.Text = "Applied: Grayscale";
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedImage?.Dispose();
            processedImage = InvertColors(originalImage);
            pictureBoxProcessed.Image = processedImage;
            statusLabel.Text = "Applied: Color Inversion";
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedImage?.Dispose();
            processedImage = ApplySepia(originalImage);
            pictureBoxProcessed.Image = processedImage;
            statusLabel.Text = "Applied: Sepia";
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedImage?.Dispose();
            processedImage = GenerateHistogram(originalImage);
            pictureBoxProcessed.Image = processedImage;
            statusLabel.Text = "Applied: Histogram";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processedImage != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ImageFormat format = ImageFormat.Jpeg;
                        string ext = Path.GetExtension(saveFileDialog1.FileName).ToLower();
                        switch (ext)
                        {
                            case ".png": format = ImageFormat.Png; break;
                            case ".bmp": format = ImageFormat.Bmp; break;
                            default: format = ImageFormat.Jpeg; break;
                        }

                        processedImage.Save(saveFileDialog1.FileName, format);
                        statusLabel.Text = $"Saved: {Path.GetFileName(saveFileDialog1.FileName)}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No processed image to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Part 2: Image Subtraction with Green Screen

        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopWebcam();
            groupBoxSubtraction.Visible = true;
            groupBoxWebcam.Visible = false;
            groupBoxImageProcessing.Visible = false;
            statusLabel.Text = "Image Subtraction Mode - Load Image B (Green Screen) and Image A (Background)";
        }

        private void btnApplySubtraction_Click(object sender, EventArgs e)
        {
            if (imageA == null || imageB == null)
            {
                MessageBox.Show("Please load both Image A (Background) and Image B (Green Screen) first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedImage?.Dispose();
            processedImage = PerformSubtraction(imageB, imageA);
            pictureBoxSubtractionResult.Image = processedImage;
            statusLabel.Text = "Applied: Image Subtraction (Green Screen Removal)";
        }

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private Bitmap PerformSubtraction(Bitmap foreground, Bitmap background)
        {
            // Resize background to match foreground dimensions
            Bitmap resizedBackground = ResizeImage(background, foreground.Width, foreground.Height);

            Bitmap resultImage = new Bitmap(foreground.Width, foreground.Height);

            for (int x = 0; x < foreground.Width; x++)
            {
                for (int y = 0; y < foreground.Height; y++)
                {
                    Color foregroundPixel = foreground.GetPixel(x, y);
                    Color backgroundPixel = resizedBackground.GetPixel(x, y);

                    // Enhanced green detection
                    bool isGreen = IsGreenScreenPixel(foregroundPixel);

                    // If pixel is green, use background, otherwise use foreground
                    if (isGreen)
                    {
                        resultImage.SetPixel(x, y, backgroundPixel);
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, foregroundPixel);
                    }
                }
            }

            resizedBackground.Dispose();
            return resultImage;
        }

        private bool IsGreenScreenPixel(Color pixel)
        {
            // Enhanced green screen detection
            return pixel.G > pixel.R + 50 &&
                   pixel.G > pixel.B + 50 &&
                   pixel.G > 100 &&
                   Math.Abs(pixel.R - pixel.B) < 30; // Ensure red and blue are somewhat balanced
        }

        #endregion

        #region Webcam Methods

        private void LoadWebcamDevices()
        {
            try
            {
                comboBoxWebcamDevices.Items.Clear();
                Device[] devices = DeviceManager.GetAllDevices();

                if (devices != null && devices.Length > 0)
                {
                    foreach (Device device in devices)
                    {
                        comboBoxWebcamDevices.Items.Add(new WebcamDeviceItem(device));
                    }
                    comboBoxWebcamDevices.SelectedIndex = 0;
                }
                else
                {
                    comboBoxWebcamDevices.Items.Add("No webcams detected");
                }
            }
            catch (Exception ex)
            {
                comboBoxWebcamDevices.Items.Add($"Error: {ex.Message}");
            }
        }

        private void btnStartWebcam_Click(object sender, EventArgs e)
        {
            groupBoxWebcam.Visible = true;
            groupBoxSubtraction.Visible = false;
            groupBoxImageProcessing.Visible = false;
            StartWebcam();
        }

        private void btnStopWebcam_Click(object sender, EventArgs e) => StopWebcam();

        private void btnWebcamSubtraction_Click(object sender, EventArgs e)
        {
            if (webcamBackground == null)
            {
                MessageBox.Show("Please load a background image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isWebcamSubtractionMode = !isWebcamSubtractionMode;

            if (isWebcamSubtractionMode)
            {
                currentWebcamFilter = WebcamFilter.Subtraction;
                btnWebcamSubtraction.Text = "Stop Subtraction";
                labelWebcamStatus.Text = "Subtraction Active";
                statusLabel.Text = "Webcam subtraction mode activated - Stand in front of green screen";
            }
            else
            {
                currentWebcamFilter = WebcamFilter.NoFilter;
                btnWebcamSubtraction.Text = "Webcam Subtraction";
                labelWebcamStatus.Text = "Subtraction Stopped";
                statusLabel.Text = "Webcam subtraction mode deactivated";
            }
        }

        private void startWebcamToolStripMenuItem_Click(object sender, EventArgs e) => btnStartWebcam_Click(sender, e);
        private void stopWebcamToolStripMenuItem_Click(object sender, EventArgs e) => StopWebcam();

        private void StartWebcam()
        {
            if (comboBoxWebcamDevices.SelectedItem is WebcamDeviceItem deviceItem)
            {
                try
                {
                    StopWebcam();
                    currentWebcam = deviceItem.Device;
                    currentWebcam.ShowWindow(pictureBoxWebcamOriginal);
                    isWebcamRunning = true;
                    timerWebcam.Start();
                    statusLabel.Text = $"Webcam started: {currentWebcam.Name}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error starting webcam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StopWebcam()
        {
            if (isWebcamRunning)
            {
                timerWebcam.Stop();
                currentWebcam?.Stop();
                isWebcamRunning = false;
                isWebcamSubtractionMode = false;

                // Clean up
                var oldOriginal = pictureBoxWebcamOriginal.Image;
                var oldProcessed = pictureBoxWebcamProcessed.Image;
                pictureBoxWebcamOriginal.Image = null;
                pictureBoxWebcamProcessed.Image = null;
                oldOriginal?.Dispose();
                oldProcessed?.Dispose();
                webcamFrame?.Dispose();
                webcamFrame = null;

                btnWebcamSubtraction.Text = "Webcam Subtraction";
                labelWebcamStatus.Text = "Webcam Stopped";
                statusLabel.Text = "Webcam stopped";
            }
        }

        private void timerWebcam_Tick(object sender, EventArgs e)
        {
            if (!isWebcamRunning || currentWebcam == null) return;

            try
            {
                webcamFrame = CaptureWebcamFrame();
                if (webcamFrame != null)
                {
                    var oldOriginal = pictureBoxWebcamOriginal.Image;
                    pictureBoxWebcamOriginal.Image = (Bitmap)webcamFrame.Clone();
                    oldOriginal?.Dispose();

                    Bitmap processedFrame = ApplyWebcamFilter(webcamFrame, currentWebcamFilter);

                    var oldProcessed = pictureBoxWebcamProcessed.Image;
                    pictureBoxWebcamProcessed.Image = processedFrame;
                    oldProcessed?.Dispose();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Webcam error: {ex.Message}");
            }
        }

        private Bitmap CaptureWebcamFrame()
        {
            if (currentWebcam == null) return null;
            try
            {
                currentWebcam.Sendmessage();
                return Clipboard.ContainsImage() ? new Bitmap(Clipboard.GetImage()) : null;
            }
            catch { return null; }
        }

        private Bitmap ApplyWebcamFilter(Bitmap frame, WebcamFilter filter)
        {
            switch (filter)
            {
                case WebcamFilter.BasicCopy:
                    return BasicCopy(frame);
                case WebcamFilter.Greyscale:
                    return ConvertToGrayscale(frame);
                case WebcamFilter.Inversion:
                    return InvertColors(frame);
                case WebcamFilter.Sepia:
                    return ApplySepia(frame);
                case WebcamFilter.Subtraction:
                    return PerformWebcamSubtraction(frame);
                case WebcamFilter.NoFilter:
                default:
                    return BasicCopy(frame);
            }
        }

        private Bitmap PerformWebcamSubtraction(Bitmap webcamFrame)
        {
            if (webcamBackground == null) return BasicCopy(webcamFrame);

            // Resize background to match webcam frame size
            Bitmap resizedBackground = ResizeImage(webcamBackground, webcamFrame.Width, webcamFrame.Height);
            Bitmap result = new Bitmap(webcamFrame.Width, webcamFrame.Height);

            for (int x = 0; x < webcamFrame.Width; x++)
            {
                for (int y = 0; y < webcamFrame.Height; y++)
                {
                    Color webcamPixel = webcamFrame.GetPixel(x, y);
                    Color backgroundPixel = resizedBackground.GetPixel(x, y);

                    bool isGreen = IsGreenScreenPixel(webcamPixel);

                    if (isGreen)
                    {
                        result.SetPixel(x, y, backgroundPixel);
                    }
                    else
                    {
                        result.SetPixel(x, y, webcamPixel);
                    }
                }
            }

            resizedBackground.Dispose();
            return result;
        }

        // Webcam filter handlers
        private void webcamNoFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentWebcamFilter = WebcamFilter.NoFilter;
            isWebcamSubtractionMode = false;
            btnWebcamSubtraction.Text = "Webcam Subtraction";
            labelWebcamStatus.Text = "No Filter";
            statusLabel.Text = "Webcam filter: No Filter";
        }

        private void webcamBasicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentWebcamFilter = WebcamFilter.BasicCopy;
            isWebcamSubtractionMode = false;
            btnWebcamSubtraction.Text = "Webcam Subtraction";
            labelWebcamStatus.Text = "Basic Copy";
            statusLabel.Text = "Webcam filter: Basic Copy";
        }

        private void webcamGreyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentWebcamFilter = WebcamFilter.Greyscale;
            isWebcamSubtractionMode = false;
            btnWebcamSubtraction.Text = "Webcam Subtraction";
            labelWebcamStatus.Text = "Greyscale";
            statusLabel.Text = "Webcam filter: Greyscale";
        }

        private void webcamInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentWebcamFilter = WebcamFilter.Inversion;
            isWebcamSubtractionMode = false;
            btnWebcamSubtraction.Text = "Webcam Subtraction";
            labelWebcamStatus.Text = "Inversion";
            statusLabel.Text = "Webcam filter: Inversion";
        }

        private void webcamSepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentWebcamFilter = WebcamFilter.Sepia;
            isWebcamSubtractionMode = false;
            btnWebcamSubtraction.Text = "Webcam Subtraction";
            labelWebcamStatus.Text = "Sepia";
            statusLabel.Text = "Webcam filter: Sepia";
        }

        private void btnRefreshWebcams_Click(object sender, EventArgs e) => LoadWebcamDevices();

        #endregion

        #region Image Processing Algorithms

        private Bitmap BasicCopy(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    result.SetPixel(x, y, source.GetPixel(x, y));
                }
            }
            return result;
        }

        private Bitmap ConvertToGrayscale(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color pixel = source.GetPixel(x, y);
                    int gray = (int)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);
                    result.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return result;
        }

        private Bitmap InvertColors(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color pixel = source.GetPixel(x, y);
                    result.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }
            return result;
        }

        private Bitmap ApplySepia(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color pixel = source.GetPixel(x, y);
                    int r = Math.Min(255, (int)(pixel.R * 0.393 + pixel.G * 0.769 + pixel.B * 0.189));
                    int g = Math.Min(255, (int)(pixel.R * 0.349 + pixel.G * 0.686 + pixel.B * 0.168));
                    int b = Math.Min(255, (int)(pixel.R * 0.272 + pixel.G * 0.534 + pixel.B * 0.131));
                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return result;
        }

        private Bitmap GenerateHistogram(Bitmap source)
        {
            Bitmap grayscale = ConvertToGrayscale(source);
            int[] histogram = new int[256];

            for (int y = 0; y < grayscale.Height; y++)
            {
                for (int x = 0; x < grayscale.Width; x++)
                {
                    Color pixel = grayscale.GetPixel(x, y);
                    histogram[pixel.R]++;
                }
            }

            int max = histogram.Max();
            if (max == 0) max = 1;

            Bitmap histImage = new Bitmap(256, 200);
            using (Graphics g = Graphics.FromImage(histImage))
            {
                g.Clear(Color.White);
                Pen pen = new Pen(Color.Black);
                for (int i = 0; i < 256; i++)
                {
                    int height = (int)((double)histogram[i] / max * 200);
                    g.DrawLine(pen, i, 200, i, 200 - height);
                }
            }

            grayscale.Dispose();
            return histImage;
        }

        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private class WebcamDeviceItem
        {
            public Device Device { get; set; }
            public WebcamDeviceItem(Device device) { Device = device; }
            public override string ToString() => Device.Name;
        }
        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedImage?.Dispose();
            processedImage = new Bitmap(originalImage);
            BitmapFilter.Smooth(processedImage, 1);
            pictureBoxProcessed.Image = processedImage;
            statusLabel.Text = "Applied: Blur Filter";
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedImage?.Dispose();
            processedImage = new Bitmap(originalImage);
            BitmapFilter.Sharpen(processedImage, 11);
            pictureBoxProcessed.Image = processedImage;
            statusLabel.Text = "Applied: Sharpen Filter";
        }

        private void edgeDetectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedImage?.Dispose();
            processedImage = new Bitmap(originalImage);
            BitmapFilter.EdgeDetectQuick(processedImage);
            pictureBoxProcessed.Image = processedImage;
            statusLabel.Text = "Applied: Edge Detection Filter";
        }

        private void embossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedImage?.Dispose();
            processedImage = new Bitmap(originalImage);
            BitmapFilter.EmbossLaplacian(processedImage);
            pictureBoxProcessed.Image = processedImage;
            statusLabel.Text = "Applied: Emboss Filter";
        }

        private void gaussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            processedImage?.Dispose();
            processedImage = new Bitmap(originalImage);
            BitmapFilter.GaussianBlur(processedImage, 4);
            pictureBoxProcessed.Image = processedImage;
            statusLabel.Text = "Applied: Gaussian Blur Filter";
        }
    }
}