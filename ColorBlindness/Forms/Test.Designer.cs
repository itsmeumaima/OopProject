namespace WinFormsApp3.Forms
{
    partial class Test
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
            lblTitle = new Label();
            lblInstructions = new Label();
            lblQuestionNumber = new Label();
            lblResult = new Label();
            lblDetails = new Label();
            pictureBox = new PictureBox();
            btnSubmitAnswer = new Button();
            btnRestart = new Button();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            txtAnswer = new TextBox();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.FlatStyle = FlatStyle.Popup;
            lblTitle.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(0, 192, 192);
            lblTitle.Location = new Point(24, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(321, 44);
            lblTitle.TabIndex = 18;
            lblTitle.Text = "Color Blindness Test";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.FlatStyle = FlatStyle.Popup;
            lblInstructions.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructions.ForeColor = Color.FromArgb(0, 64, 64);
            lblInstructions.Location = new Point(45, 89);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(377, 66);
            lblInstructions.TabIndex = 19;
            lblInstructions.Text = "Look at the image and enter the number you see. \r\nCLick submit after entering your answer.\r\nClick next to proceed to the next image";
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.FlatStyle = FlatStyle.Popup;
            lblQuestionNumber.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestionNumber.ForeColor = Color.FromArgb(0, 192, 192);
            lblQuestionNumber.Location = new Point(45, 174);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(129, 22);
            lblQuestionNumber.TabIndex = 20;
            lblQuestionNumber.Text = "Question 1 of 14";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.FlatStyle = FlatStyle.Popup;
            lblResult.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.FromArgb(0, 64, 64);
            lblResult.Location = new Point(45, 214);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(162, 22);
            lblResult.TabIndex = 21;
            lblResult.Text = "Result not yet tested";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.FlatStyle = FlatStyle.Popup;
            lblDetails.Font = new Font("Palatino Linotype", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetails.ForeColor = Color.FromArgb(0, 64, 64);
            lblDetails.Location = new Point(45, 332);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(80, 26);
            lblDetails.TabIndex = 22;
            lblDetails.Text = "Details:";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(472, 39);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(640, 470);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 23;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.BackColor = Color.FromArgb(0, 192, 192);
            btnSubmitAnswer.Font = new Font("Showcard Gothic", 9.75F);
            btnSubmitAnswer.ForeColor = SystemColors.ButtonHighlight;
            btnSubmitAnswer.Location = new Point(270, 529);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(171, 37);
            btnSubmitAnswer.TabIndex = 24;
            btnSubmitAnswer.Text = "S u b m i t";
            btnSubmitAnswer.UseVisualStyleBackColor = false;
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.FromArgb(0, 192, 192);
            btnRestart.Font = new Font("Showcard Gothic", 9.75F);
            btnRestart.ForeColor = SystemColors.ButtonHighlight;
            btnRestart.Location = new Point(45, 528);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(189, 37);
            btnRestart.TabIndex = 26;
            btnRestart.Text = "R e s t a r t";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            kryptonButton1.Location = new Point(1124, 12);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(146, 25);
            kryptonButton1.TabIndex = 28;
            kryptonButton1.Values.Text = "B A C K";
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Segoe UI", 14F);
            txtAnswer.Location = new Point(472, 528);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(452, 32);
            txtAnswer.TabIndex = 29;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(0, 192, 192);
            btnNext.Font = new Font("Showcard Gothic", 9.75F);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(974, 526);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(138, 34);
            btnNext.TabIndex = 30;
            btnNext.Text = "N e x t";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1166, 611);
            Controls.Add(btnNext);
            Controls.Add(txtAnswer);
            Controls.Add(kryptonButton1);
            Controls.Add(btnRestart);
            Controls.Add(btnSubmitAnswer);
            Controls.Add(pictureBox);
            Controls.Add(lblDetails);
            Controls.Add(lblResult);
            Controls.Add(lblQuestionNumber);
            Controls.Add(lblInstructions);
            Controls.Add(lblTitle);
            Name = "Test";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
            Load += Test_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInstructions;
        private Label lblQuestionNumber;
        private Label lblResult;
        private Label lblDetails;
        private PictureBox pictureBox;
        private Button btnSubmitAnswer;
        private Button btnRestart;
        //private Button btnExit;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private TextBox txtAnswer;
        private Button btnNext;
    }
}