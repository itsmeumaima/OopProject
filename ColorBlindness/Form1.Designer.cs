namespace WinFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            themeToggle = new MaterialSkin.Controls.MaterialSwitch();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonColorButton1 = new Krypton.Toolkit.KryptonColorButton();
            menuStrip1 = new MenuStrip();
            uhuyuToolStripMenuItem = new ToolStripMenuItem();
            ijijijToolStripMenuItem = new ToolStripMenuItem();
            jjjkjToolStripMenuItem = new ToolStripMenuItem();
            jkjkkToolStripMenuItem = new ToolStripMenuItem();
            jjkToolStripMenuItem = new ToolStripMenuItem();
            jkToolStripMenuItem = new ToolStripMenuItem();
            kkjkToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // themeToggle
            // 
            themeToggle.AutoSize = true;
            themeToggle.Depth = 0;
            themeToggle.Location = new Point(20, 330);
            themeToggle.Margin = new Padding(0);
            themeToggle.MouseLocation = new Point(-1, -1);
            themeToggle.MouseState = MaterialSkin.MouseState.HOVER;
            themeToggle.Name = "themeToggle";
            themeToggle.Ripple = true;
            themeToggle.Size = new Size(173, 37);
            themeToggle.TabIndex = 0;
            themeToggle.Text = "materialSwitch1";
            themeToggle.UseVisualStyleBackColor = true;
            themeToggle.CheckedChanged += themeToggle_CheckedChanged;
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.BreadCrumb;
            kryptonButton1.Location = new Point(292, 413);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(259, 25);
            kryptonButton1.TabIndex = 4;
            kryptonButton1.Values.Text = "kryptonButton1";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.FlatStyle = FlatStyle.Popup;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(439, 319);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 6;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(447, 169);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(500, 1);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonColorButton1
            // 
            kryptonColorButton1.Location = new Point(205, 213);
            kryptonColorButton1.Name = "kryptonColorButton1";
            kryptonColorButton1.Size = new Size(90, 25);
            kryptonColorButton1.TabIndex = 8;
            kryptonColorButton1.Values.Image = (Image)resources.GetObject("kryptonColorButton1.Values.Image");
            kryptonColorButton1.Values.Text = "kryptonColorButton1";
            kryptonColorButton1.SelectedColorChanged += kryptonColorButton1_SelectedColorChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { uhuyuToolStripMenuItem, ijijijToolStripMenuItem, kkjkToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1575, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // uhuyuToolStripMenuItem
            // 
            uhuyuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jjjkjToolStripMenuItem, jkjkkToolStripMenuItem, jjkToolStripMenuItem });
            uhuyuToolStripMenuItem.Name = "uhuyuToolStripMenuItem";
            uhuyuToolStripMenuItem.Size = new Size(53, 20);
            uhuyuToolStripMenuItem.Text = "uhuyu";
            // 
            // ijijijToolStripMenuItem
            // 
            ijijijToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jkToolStripMenuItem });
            ijijijToolStripMenuItem.Name = "ijijijToolStripMenuItem";
            ijijijToolStripMenuItem.Size = new Size(37, 20);
            ijijijToolStripMenuItem.Text = "ijijij";
            // 
            // jjjkjToolStripMenuItem
            // 
            jjjkjToolStripMenuItem.Name = "jjjkjToolStripMenuItem";
            jjjkjToolStripMenuItem.Size = new Size(180, 22);
            jjjkjToolStripMenuItem.Text = "jjjkj";
            // 
            // jkjkkToolStripMenuItem
            // 
            jkjkkToolStripMenuItem.Name = "jkjkkToolStripMenuItem";
            jkjkkToolStripMenuItem.Size = new Size(180, 22);
            jkjkkToolStripMenuItem.Text = "jkjkk";
            // 
            // jjkToolStripMenuItem
            // 
            jjkToolStripMenuItem.Name = "jjkToolStripMenuItem";
            jjkToolStripMenuItem.Size = new Size(180, 22);
            jjkToolStripMenuItem.Text = "jjk";
            // 
            // jkToolStripMenuItem
            // 
            jkToolStripMenuItem.Name = "jkToolStripMenuItem";
            jkToolStripMenuItem.Size = new Size(180, 22);
            jkToolStripMenuItem.Text = "jk";
            // 
            // kkjkToolStripMenuItem
            // 
            kkjkToolStripMenuItem.Name = "kkjkToolStripMenuItem";
            kkjkToolStripMenuItem.Size = new Size(40, 20);
            kkjkToolStripMenuItem.Text = "kkjk";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1581, 920);
            Controls.Add(kryptonColorButton1);
            Controls.Add(kryptonBorderEdge1);
            Controls.Add(materialButton1);
            Controls.Add(kryptonButton1);
            Controls.Add(themeToggle);
            Controls.Add(menuStrip1);
            DrawerBackgroundWithAccent = true;
            DrawerUseColors = true;
            FormBorderStyle = FormBorderStyle.Sizable;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            TransparencyKey = Color.Thistle;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch themeToggle;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonColorButton kryptonColorButton1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem uhuyuToolStripMenuItem;
        private ToolStripMenuItem jjjkjToolStripMenuItem;
        private ToolStripMenuItem jkjkkToolStripMenuItem;
        private ToolStripMenuItem jjkToolStripMenuItem;
        private ToolStripMenuItem ijijijToolStripMenuItem;
        private ToolStripMenuItem jkToolStripMenuItem;
        private ToolStripMenuItem kkjkToolStripMenuItem;
    }
}