using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinFormsApp3.Forms
{
    public partial class ColorDetector : Form
    {
        //used for color manipulation
        [DllImport("user32.dll")]
        //In C#, extern is primarily used to declare a method that is implemented externally,such as a DLL 
        static extern bool GetCursorPos(ref Point lpPoint);

        private Dictionary<Color, string> colorNames;
        public ColorDetector()
        {
            InitializeComponent();
            InitializeColorNames();
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        private void InitializeColorNames()
        {
            colorNames = new Dictionary<Color, string>
            {
                { Color.Red, "Red" },
                { Color.Green, "Green" },
                { Color.Blue, "Blue" },
                { Color.Black, "Black" },
                { Color.White, "White" },
                { Color.Yellow, "Yellow" },
                { Color.Orange, "Orange" },
                { Color.Purple, "Purple" },
                { Color.Pink, "Pink" },
                { Color.Brown, "Brown" },
                { Color.Gray, "Gray" },
                { Color.AliceBlue, "AliceBlue" },
                { Color.AntiqueWhite, "AntiqueWhite" },
                { Color.Aqua, "Aqua" },
                { Color.Aquamarine, "Aquamarine" },
                { Color.Azure, "Azure" },
                { Color.Beige, "Beige" },
                { Color.Bisque, "Bisque" },
                { Color.BlanchedAlmond, "BlanchedAlmond" },
                { Color.BlueViolet, "BlueViolet" },
                { Color.BurlyWood, "BurlyWood" },
                { Color.CadetBlue, "CadetBlue" },
                { Color.Chartreuse, "Chartreuse" },
                { Color.Chocolate, "Choclate" },
                { Color.Coral, "Coral" },
                { Color.CornflowerBlue, "CornFlowerBlue" },
                { Color.Cornsilk, "Cornsilk" },
                { Color.Crimson, "Crimson" },
                { Color.Cyan, "Cyaan" },
                { Color.DarkBlue, "Dark Blue" },
                { Color.DarkCyan, "Dark cyan" },
                { Color.DarkGoldenrod, "DarkGoldenrod" },
                { Color.DarkGreen, "Dark Green" },
                { Color.DarkKhaki, "Dark khaki" },
                { Color.DarkMagenta, "Dark Magenta" },
                { Color.DarkOliveGreen, "Dark Olive green" },
                { Color.DarkOrange, "Dark Orange" },
                { Color.DarkOrchid, "Dark Orchid" },
                { Color.DarkRed, "Dark Red" },
                { Color.DarkSalmon, "Dark Salmon" },
                { Color.DarkSeaGreen, "Dark Sea Green" },
                { Color.DarkSlateBlue, "Dark Slate Blue" }




       // More colors can be added for  better accuracy
            };
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);

            Color color = GetColorAt(cursor);
            string colorName = GetColorName(color);
            label1.Text = colorName ?? $"Unknown Color: {color}";
        }

        private Color GetColorAt(Point location)
        {
            using (Bitmap screenshot = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(screenshot))
                {
                    g.CopyFromScreen(location, new Point(0, 0), new Size(1, 1));
                }
                return screenshot.GetPixel(0, 0);
            }
        }

        private string GetColorName(Color color)
        {
            // Find the closest matching color name
            string closestColorName = null;
            double closestDistance = double.MaxValue;

            foreach (var kvp in colorNames)
            {
                double distance = GetColorDistance(color, kvp.Key);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestColorName = kvp.Value;
                }
            }

            return closestColorName;
        }

        private double GetColorDistance(Color c1, Color c2)
        {
            int rDiff = c1.R - c2.R;
            int gDiff = c1.G - c2.G;
            int bDiff = c1.B - c2.B;
            return Math.Sqrt(rDiff * rDiff + gDiff * gDiff + bDiff * bDiff);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter for file types
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Check if the user selected a file and clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();
            // Create and show the dashboard form
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void ColorDetector_Load(object sender, EventArgs e)
        {

        }
    }
}
