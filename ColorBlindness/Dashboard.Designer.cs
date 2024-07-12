namespace WinFormsApp3
{
    partial class Dashboard
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            kryptonButton = new Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            pictureBox3 = new PictureBox();
            kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1166, 611);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // kryptonButton
            // 
            kryptonButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton.CornerRoundingRadius = 2F;
            kryptonButton.Location = new Point(48, 12);
            kryptonButton.Name = "kryptonButton";
            kryptonButton.Size = new Size(81, 24);
            kryptonButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton.StateCommon.Border.Rounding = 2F;
            kryptonButton.TabIndex = 4;
            kryptonButton.Values.Text = "M E N U";
            kryptonButton.Click += kryptonButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(kryptonButton2);
            panel1.Controls.Add(kryptonButton1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(kryptonButton6);
            panel1.Controls.Add(kryptonButton5);
            panel1.Controls.Add(kryptonButton4);
            panel1.Controls.Add(kryptonButton3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 611);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // kryptonButton2
            // 
            kryptonButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton2.CornerRoundingRadius = 10F;
            kryptonButton2.Location = new Point(-2, 341);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(200, 40);
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.Rounding = 10F;
            kryptonButton2.TabIndex = 7;
            kryptonButton2.Values.Text = "T E S T";
            kryptonButton2.Click += kryptonButton2_Click_1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton1.Location = new Point(109, 418);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(84, 25);
            kryptonButton1.TabIndex = 6;
            kryptonButton1.Values.Text = "B A C K";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(167, 126);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // kryptonButton6
            // 
            kryptonButton6.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton6.CornerRoundingRadius = 10F;
            kryptonButton6.Location = new Point(-2, 295);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.Size = new Size(200, 40);
            kryptonButton6.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton6.StateCommon.Border.Rounding = 10F;
            kryptonButton6.TabIndex = 5;
            kryptonButton6.Values.Text = "C O L O R   D E T E C T O R";
            kryptonButton6.Click += kryptonButton6_Click;
            // 
            // kryptonButton5
            // 
            kryptonButton5.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton5.CornerRoundingRadius = 10F;
            kryptonButton5.Location = new Point(-2, 249);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.Size = new Size(200, 40);
            kryptonButton5.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton5.StateCommon.Border.Rounding = 10F;
            kryptonButton5.TabIndex = 4;
            kryptonButton5.Values.Text = "C O R R E C T O R";
            kryptonButton5.Click += kryptonButton5_Click;
            // 
            // kryptonButton4
            // 
            kryptonButton4.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton4.CornerRoundingRadius = 10F;
            kryptonButton4.Location = new Point(0, 203);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(200, 40);
            kryptonButton4.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton4.StateCommon.Border.Rounding = 10F;
            kryptonButton4.TabIndex = 3;
            kryptonButton4.Values.Text = "S I M U L A T O R";
            kryptonButton4.Click += kryptonButton4_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton3.CornerRoundingRadius = 10F;
            kryptonButton3.Location = new Point(0, 157);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(200, 40);
            kryptonButton3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton3.StateCommon.Border.Rounding = 10F;
            kryptonButton3.TabIndex = 2;
            kryptonButton3.Values.Text = "H O M E";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1166, 611);
            Controls.Add(panel1);
            Controls.Add(kryptonButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonButton kryptonButton;
        private Panel panel1;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private PictureBox pictureBox3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}