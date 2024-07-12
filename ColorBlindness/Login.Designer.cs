namespace WinFormsApp3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            textBox1 = new TextBox();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox2 = new PictureBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(156, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 385);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_3;
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 20F;
            kryptonButton1.Location = new Point(651, 392);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(296, 34);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 20F;
            kryptonButton1.StateDisabled.Back.Color1 = Color.Teal;
            kryptonButton1.StateDisabled.Back.Color2 = Color.Cyan;
            kryptonButton1.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonButton1.StateDisabled.Back.ColorAngle = 10F;
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.Text = "L O G I N   I N";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(709, 452);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 17);
            textBox1.TabIndex = 2;
            textBox1.Text = "Not Registered |";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonButton2
            // 
            kryptonButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton2.Location = new Point(818, 453);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(81, 16);
            kryptonButton2.TabIndex = 3;
            kryptonButton2.Values.Text = "S i g n   U p";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.CornerRoundingRadius = 20F;
            kryptonTextBox1.Location = new Point(651, 329);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(296, 35);
            kryptonTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateCommon.Border.Rounding = 20F;
            kryptonTextBox1.TabIndex = 4;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.CornerRoundingRadius = 20F;
            kryptonTextBox2.Location = new Point(651, 251);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(296, 35);
            kryptonTextBox2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox2.StateCommon.Border.Rounding = 20F;
            kryptonTextBox2.TabIndex = 5;
            kryptonTextBox2.TextChanged += kryptonTextBox2_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.DarkSlateGray;
            textBox2.Location = new Point(670, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(103, 17);
            textBox2.TabIndex = 6;
            textBox2.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.DarkSlateGray;
            textBox3.Location = new Point(670, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(103, 17);
            textBox3.TabIndex = 7;
            textBox3.Text = "Name";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Bauhaus 93", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.LightBlue;
            textBox4.Location = new Point(651, 170);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(223, 52);
            textBox4.TabIndex = 8;
            textBox4.Text = "W E L C O M E";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(637, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.DarkSlateGray;
            textBox5.Location = new Point(709, 138);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(164, 17);
            textBox5.TabIndex = 10;
            textBox5.Text = "Experience the Unseen";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1166, 611);
            Controls.Add(textBox5);
            Controls.Add(pictureBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonButton2);
            Controls.Add(textBox1);
            Controls.Add(kryptonButton1);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TextBox textBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox2;
        private TextBox textBox5;
    }
}