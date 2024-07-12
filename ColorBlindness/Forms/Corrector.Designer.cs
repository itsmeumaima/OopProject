namespace WinFormsApp3.Forms
{
    partial class Corrector
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            openFileDialog1 = new OpenFileDialog();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(47, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 443);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(599, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(516, 443);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Showcard Gothic", 9.75F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(926, 510);
            button1.Name = "button1";
            button1.Size = new Size(189, 37);
            button1.TabIndex = 6;
            button1.Text = "L o a d   I m a g e";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Font = new Font("Showcard Gothic", 9.75F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(926, 553);
            button2.Name = "button2";
            button2.Size = new Size(189, 37);
            button2.TabIndex = 7;
            button2.Text = "L o a d   V i d e o";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.FromArgb(0, 192, 192);
            radioButton1.Location = new Point(47, 510);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(139, 21);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "P r o t a n o p i a";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.FromArgb(0, 192, 192);
            radioButton2.Location = new Point(46, 537);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(150, 21);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "D e u t r a n o p i a";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.FromArgb(0, 192, 192);
            radioButton3.Location = new Point(46, 568);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(134, 21);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "T r i t a n o p i a";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // materialSlider1
            // 
            materialSlider1.BackColor = Color.Teal;
            materialSlider1.Depth = 0;
            materialSlider1.ForeColor = Color.Teal;
            materialSlider1.Location = new Point(270, 527);
            materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSlider1.Name = "materialSlider1";
            materialSlider1.Size = new Size(557, 40);
            materialSlider1.TabIndex = 11;
            materialSlider1.Text = "0";
            materialSlider1.Value = 100;
            materialSlider1.Click += materialSlider1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton1.Location = new Point(1155, -3);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(64, 25);
            kryptonButton1.TabIndex = 20;
            kryptonButton1.Values.Text = "B A C K";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // Corrector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1166, 611);
            Controls.Add(kryptonButton1);
            Controls.Add(materialSlider1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Corrector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Corrector";
            TransparencyKey = Color.Teal;
            Load += Corrector_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private OpenFileDialog openFileDialog1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}