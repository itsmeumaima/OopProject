namespace WinFormsApp3.Forms
{
    partial class Simulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulator));
            pictureBox1 = new PictureBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button2 = new Button();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(58, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(767, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.FromArgb(0, 192, 192);
            radioButton3.Location = new Point(879, 330);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(134, 21);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "T r i t a n o p i a";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.FromArgb(0, 192, 192);
            radioButton2.Location = new Point(879, 279);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(150, 21);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "D e u t r a n o p i a";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.FromArgb(0, 192, 192);
            radioButton1.Location = new Point(879, 228);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(139, 21);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "P r o t a n o p i a";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Font = new Font("Showcard Gothic", 9.75F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(879, 503);
            button2.Name = "button2";
            button2.Size = new Size(189, 37);
            button2.TabIndex = 15;
            button2.Text = "A p p l y   E f f e c t";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Showcard Gothic", 9.75F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(879, 425);
            button1.Name = "button1";
            button1.Size = new Size(189, 37);
            button1.TabIndex = 14;
            button1.Text = "L o a d   I m a g e";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(879, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 138);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton1.Location = new Point(1070, 12);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(84, 25);
            kryptonButton1.TabIndex = 19;
            kryptonButton1.Values.Text = "B A C K";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // Simulator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1166, 611);
            Controls.Add(kryptonButton1);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Name = "Simulator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simulator";
            Load += Simulator_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox3;
        private OpenFileDialog openFileDialog1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}