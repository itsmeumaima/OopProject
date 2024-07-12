namespace WinFormsApp3.Forms
{
    partial class ColorDetector
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Showcard Gothic", 9.75F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(819, 552);
            button1.Name = "button1";
            button1.Size = new Size(189, 37);
            button1.TabIndex = 15;
            button1.Text = "L o a d   I m a g e";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(79, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(929, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(79, 545);
            label1.Name = "label1";
            label1.Size = new Size(107, 44);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton1.Location = new Point(1052, 12);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(84, 25);
            kryptonButton1.TabIndex = 18;
            kryptonButton1.Values.Text = "B A C K";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // ColorDetector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1166, 611);
            Controls.Add(kryptonButton1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "ColorDetector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ColorDetector";
            Load += ColorDetector_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}