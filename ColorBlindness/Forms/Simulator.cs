using System;
using System.Drawing;
using System.Windows.Forms;
using static MaterialSkin.MaterialSkinManager;
using static OpenCvSharp.LineIterator;
using static System.Net.Mime.MediaTypeNames;
namespace WinFormsApp3.Forms
{
    public partial class Simulator : Form
    {
        //The Bitmap class is generally used to work with images.It represents a grid of pixels and provides methods to manipulate these pixels
        private Bitmap originalImage;
        //The ColorTransformer class is used for applying color transformations to images.
        private ColorTransformer colorTransformer;
        //Constructor
        public Simulator()
        {
            InitializeComponent();
            colorTransformer = new ColorTransformer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    pictureBox1.Image = originalImage; // Display the loaded image in the PictureBox
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }

            Bitmap transformedImage = TransformImage(originalImage);
            pictureBox1.Image = transformedImage; // Display the transformed image in the PictureBox
        }

        private Bitmap TransformImage(Bitmap original)
        {
            Bitmap transformedImage = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color originalColor = original.GetPixel(x, y);
                    Color transformedColor = colorTransformer.Transform(originalColor, GetSelectedColorBlindnessType());

                    transformedImage.SetPixel(x, y, transformedColor);
                }
            }

            return transformedImage;
        }

        private ColorBlindnessType GetSelectedColorBlindnessType()
        {
            //Checking the input from radiobtn.
            if (radioButton1.Checked)
                return ColorBlindnessType.Protanopia;
            else if (radioButton2.Checked)
                return ColorBlindnessType.Deuteranopia;
            else if (radioButton3.Checked)
                return ColorBlindnessType.Tritanopia;
            else
                return ColorBlindnessType.Protanopia; // Default to Protanopia if no radio button is selected
        }

        // ColorTransformer Class Definition
        public class ColorTransformer
        {
            public Color Transform(Color color, ColorBlindnessType type)
            {
                //Checking the type of color blindness
                switch (type)
                {
                    case ColorBlindnessType.Protanopia:
                        return SimulateProtanopia(color);
                    case ColorBlindnessType.Deuteranopia:
                        return SimulateDeuteranopia(color);
                    case ColorBlindnessType.Tritanopia:
                        return SimulateTritanopia(color);
                    default:
                        return color; // Default behavior, no transformation
                }
            }

            private Color SimulateProtanopia(Color color)
            {
                int r = color.R;
                int g = color.G;
                int b = color.B;
                // calculating new RGB valuse based on standard scientific matrices
                int newR = Clamp((int)(0.567 * r + 0.433 * g));
                int newG = Clamp((int)(0.558 * r + 0.442 * g));
                int newB = Clamp((int)(0.0 * r + 0.242 * g + 0.758 * b));

                return Color.FromArgb(newR, newG, newB);
            }

            private Color SimulateDeuteranopia(Color color)
            {
                int r = color.R;
                int g = color.G;
                int b = color.B;

                int newR = Clamp((int)(0.625 * r + 0.375 * g));
                int newG = Clamp((int)(0.7 * r + 0.3 * g));
                int newB = Clamp((int)(0.0 * r + 0.3 * g + 0.7 * b));

                return Color.FromArgb(newR, newG, newB);
            }

            private Color SimulateTritanopia(Color color)
            {
                int r = color.R;
                int g = color.G;
                int b = color.B;

                int newR = Clamp((int)(0.95 * r + 0.05 * g));
                int newG = Clamp((int)(0.0 * r + 0.433 * g + 0.567 * b));
                int newB = Clamp((int)(0.0 * r + 0.475 * g + 0.525 * b));

                return Color.FromArgb(newR, newG, newB);
            }
            //Function to ensure the calculated values must be in range 0 - 255
            private int Clamp(int value)
            {
                return Math.Max(0, Math.Min(255, value));
            }
        }
        //Enum is used to create a collection of related values that can be referenced by name.
        public enum ColorBlindnessType
        {
            Protanopia,
            Deuteranopia,
            Tritanopia
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Hide the login form
            this.Hide();
            // Create and show the dashboard form
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Simulator_Load(object sender, EventArgs e)
        {

        }
    }
}
