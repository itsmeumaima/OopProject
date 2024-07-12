using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WinFormsApp3
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey400, Primary.Blue100, Primary.Blue200, Accent.Blue200, TextShade.BLACK);

        }
        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private void themeToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (themeToggle.Checked)
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {


                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            kryptonButton1.BackColor = Color.Green;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, Krypton.Toolkit.ColorEventArgs e)
        {

        }
    }
}
