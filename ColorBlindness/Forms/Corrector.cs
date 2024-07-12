using OpenCvSharp.Extensions;
using OpenCvSharp;
using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Numerics;
using System.Threading;

namespace WinFormsApp3.Forms
{
    public partial class Corrector : Form
    {
        public Corrector()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
        }

        private void ProcessImage(string filePath)
        {
            //Reading the image by ImRead
            Mat image = Cv2.ImRead(filePath);
            //Using Bitmap Converter class's function(ToBitmap) converting img in bitmap(grid of pixels) format.
            pictureBox1.Image = BitmapConverter.ToBitmap(image);
            Mat enhancedImage = EnhanceColorsForColorBlindness(image);
            pictureBox2.Image = BitmapConverter.ToBitmap(enhancedImage);
        }

        private Mat EnhanceColorsForColorBlindness(Mat image)
        {
            Mat lmsImage = ConvertBGRToLMS(image);
            Mat enhancedLMSImage = EnhanceColors(lmsImage, materialSlider1.Value);
            Mat enhancedImage = ConvertLMSToBGR(enhancedLMSImage);
            return enhancedImage;
        }

        private Mat ConvertLMSToBGR(Mat lmsImage)
        {
            // creating matrix : bgrimage as same size of lmsImage and type of 8-bit,unsigned,matrix with 3 channels(BGR)
            Mat bgrImage = new Mat(lmsImage.Size(), MatType.CV_8UC3);

            for (int y = 0; y < lmsImage.Rows; y++)
            {
                for (int x = 0; x < lmsImage.Cols; x++)
                {
                    // Vec3f : data structure representing a vector of three floating-point values, here is used to represent pixels in the LMS (Long, Medium, Short) color space. 
                    //lmsPixel storing the value(y,x) in vector
                    Vec3f lmsPixel = lmsImage.At<Vec3f>(y, x);
                    //Extracting l,m,s values through vector's indexing
                    float l = lmsPixel[0];
                    float m = lmsPixel[1];
                    float s = lmsPixel[2];
                    //converting l,m,s value to r,g,b values
                    float r = (4.4679f * l) - (3.5873f * m) + (0.1193f * s);
                    float g = (-1.2186f * l) + (2.3809f * m) - (0.1624f * s);
                    float b = (0.0497f * l) - (0.2439f * m) + (1.2045f * s);
                    //.Set method setting value at(y,x) position
                    bgrImage.Set(y, x, new Vec3b(
                        //clamping bgr values b/w 0 & 1 , then ensuring range:0-255 , then typecasting it to bytes
                        (byte)(Math.Min(Math.Max(b, 0), 1) * 255),
                        (byte)(Math.Min(Math.Max(g, 0), 1) * 255),
                        (byte)(Math.Min(Math.Max(r, 0), 1) * 255)
                    ));
                }
            }

            return bgrImage;
        }

        private Mat ConvertBGRToLMS(Mat bgrImage)
        {
            //CV_32F: denoting a 32-bit floating-point number, with matrixn of 3 channels
            Mat lmsImage = new Mat(bgrImage.Size(), MatType.CV_32FC3);

            for (int y = 0; y < bgrImage.Rows; y++)
            {
                for (int x = 0; x < bgrImage.Cols; x++)
                {
                    //Vec3b : Vector of 3 bytes
                    Vec3b bgrPixel = bgrImage.At<Vec3b>(y, x);
                    float b = bgrPixel[0] / 255.0f;
                    float g = bgrPixel[1] / 255.0f;
                    float r = bgrPixel[2] / 255.0f;

                    float l = (0.3811f * r) + (0.5783f * g) + (0.0402f * b);
                    float m = (0.1967f * r) + (0.7244f * g) + (0.0782f * b);
                    float s = (0.0241f * r) + (0.1288f * g) + (0.8444f * b);
                    lmsImage.Set(y, x, new Vec3f(l, m, s));
                }
            }

            return lmsImage;
        }

        private Mat EnhanceColors(Mat lmsImage, int hueAdjustment)
        {
            float lChannelFactor = 1.0f;
            float mChannelFactor = 1.0f;

            if (radioButton1.Checked)
            {
                lChannelFactor = 1.05f;
                mChannelFactor = 0.95f;
            }
            else if (radioButton2.Checked)
            {
                lChannelFactor = 0.95f;
                mChannelFactor = 1.05f;
            }
            else if (radioButton3.Checked)
            {
                lChannelFactor = 0.95f;
                mChannelFactor = 0.95f;
            }

            for (int y = 0; y < lmsImage.Rows; y++)
            {
                for (int x = 0; x < lmsImage.Cols; x++)
                {
                    Vec3f pixel = lmsImage.At<Vec3f>(y, x);
                    pixel[0] *= lChannelFactor;
                    pixel[1] *= mChannelFactor;
                    pixel[0] = ApplyHueAdjustment(pixel[0], hueAdjustment);
                    pixel[1] = ApplyHueAdjustment(pixel[1], hueAdjustment);

                    pixel[0] = Math.Min(Math.Max(pixel[0], 0), 1);
                    pixel[1] = Math.Min(Math.Max(pixel[1], 0), 1);
                    pixel[2] = Math.Min(Math.Max(pixel[2], 0), 1);

                    lmsImage.Set(y, x, pixel);
                }
            }

            Mat originalLmsImage = lmsImage.Clone();
            Mat blendedImage = new Mat();
            Cv2.AddWeighted(originalLmsImage, 0.7, lmsImage, 0.3, 0, blendedImage);

            return blendedImage;
        }

        private float ApplyHueAdjustment(float value, int hue)
        {
            return value * (1.0f + (hue / 360.0f));
        }
        //private void ProcessVideo(string filePath)
        //{
        //    VideoCapture capture = new VideoCapture(filePath);
        //    Mat frame = new Mat();
        //    int frameSkip = 5; // Process every nth frame to speed up the processing

        //    while (capture.Read(frame))
        //    {
        //        // Skip frames to speed up processing
        //        if (capture.PosFrames % frameSkip == 0)
        //        {
        //            Mat enhancedFrame = EnhanceColorsForColorBlindness(frame);
        //            pictureBox1.Image = BitmapConverter.ToBitmap(frame);
        //            pictureBox2.Image = BitmapConverter.ToBitmap(enhancedFrame);
        //        }

        //        Application.DoEvents();
        //        System.Threading.Thread.Sleep(10); // Lower sleep time to reduce delay, adjust as needed
        //    }

        //    capture.Release();
        //}
        private async void ProcessVideo(string filePath)
        {
            VideoCapture capture = new VideoCapture(filePath);
            Mat frame = new Mat();
            int frameSkip = 5; // Process every nth frame to speed up the processing

            while (capture.Read(frame))
            {
                // Skip frames to speed up processing
                if (capture.PosFrames % frameSkip == 0)
                {
                    Mat enhancedFrame = EnhanceColorsForColorBlindness(frame);

                    // Update UI asynchronously to avoid blocking the main thread
                    await Task.Run(() =>
                    {
                        pictureBox1.Invoke(new Action(() =>
                        {
                            pictureBox1.Image = BitmapConverter.ToBitmap(frame);
                        }));
                        pictureBox2.Invoke(new Action(() =>
                        {
                            pictureBox2.Image = BitmapConverter.ToBitmap(enhancedFrame);
                        }));
                    });
                }

               
            }

            capture.Release();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                ProcessImage(filePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.mov";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                ProcessVideo(filePath);
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && pictureBox2.Image != null)
            {
                ProcessImage(openFileDialog1.FileName);
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && pictureBox2.Image != null)
            {
                ProcessImage(openFileDialog1.FileName);
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && pictureBox2.Image != null)
            {
                ProcessImage(openFileDialog1.FileName);
            }
        }
        private void materialSlider1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && pictureBox2.Image != null)
            {
                ProcessImage(openFileDialog1.FileName);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();

            // Create and show the dashboard form
            Dashboard dashboard = new Dashboard();
            dashboard.FormClosed += (s, args) => this.Close(); // Close the login form when dashboard is closed
            dashboard.Show();
        }

        private void Corrector_Load(object sender, EventArgs e)
        {

        }
    }
}
