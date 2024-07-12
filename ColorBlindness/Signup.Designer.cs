namespace WinFormsApp3
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            pictureBox1 = new PictureBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            textBox1 = new TextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            textBox5 = new TextBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 417);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Bauhaus 93", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.LightBlue;
            textBox4.Location = new Point(696, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(291, 52);
            textBox4.TabIndex = 16;
            textBox4.Text = "C r e a t e N e w ";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.DarkSlateGray;
            textBox3.Location = new Point(696, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(103, 17);
            textBox3.TabIndex = 15;
            textBox3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.DarkSlateGray;
            textBox2.Location = new Point(696, 334);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 17);
            textBox2.TabIndex = 14;
            textBox2.Text = "Confirm Password";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.CornerRoundingRadius = 20F;
            kryptonTextBox2.Location = new Point(677, 279);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(296, 35);
            kryptonTextBox2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox2.StateCommon.Border.Rounding = 20F;
            kryptonTextBox2.TabIndex = 13;
            kryptonTextBox2.TextChanged += kryptonTextBox2_TextChanged;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.CornerRoundingRadius = 20F;
            kryptonTextBox1.Location = new Point(677, 357);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(296, 35);
            kryptonTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateCommon.Border.Rounding = 20F;
            kryptonTextBox1.TabIndex = 12;
            // 
            // kryptonButton2
            // 
            kryptonButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton2.Location = new Point(844, 470);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(81, 16);
            kryptonButton2.TabIndex = 11;
            kryptonButton2.Values.Text = "S i g n   I n";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(735, 469);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 17);
            textBox1.TabIndex = 10;
            textBox1.Text = "Already Registered |";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 20F;
            kryptonButton1.Location = new Point(677, 420);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(296, 34);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 20F;
            kryptonButton1.StateDisabled.Back.Color1 = Color.Teal;
            kryptonButton1.StateDisabled.Back.Color2 = Color.Cyan;
            kryptonButton1.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonButton1.StateDisabled.Back.ColorAngle = 10F;
            kryptonButton1.TabIndex = 9;
            kryptonButton1.Values.Text = "C r e a t e   A c c o u n t";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Bell MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.DarkSlateGray;
            textBox5.Location = new Point(696, 180);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(103, 17);
            textBox5.TabIndex = 18;
            textBox5.Text = "Name";
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.CornerRoundingRadius = 20F;
            kryptonTextBox3.Location = new Point(677, 203);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new Size(296, 35);
            kryptonTextBox3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox3.StateCommon.Border.Rounding = 20F;
            kryptonTextBox3.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Bauhaus 93", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.ForeColor = Color.LightBlue;
            textBox6.Location = new Point(682, 122);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(291, 52);
            textBox6.TabIndex = 19;
            textBox6.Text = "A c c o u n t";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 615);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(kryptonTextBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonButton2);
            Controls.Add(textBox1);
            Controls.Add(kryptonButton1);
            Controls.Add(pictureBox1);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            Load += Signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private TextBox textBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TextBox textBox5;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private TextBox textBox6;
    }
}