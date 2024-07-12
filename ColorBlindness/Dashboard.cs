using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp3
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.Black;
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.Black;
            kryptonButton4.StateCommon.Content.ShortText.Color1 = Color.Black;
            kryptonButton5.StateCommon.Content.ShortText.Color1 = Color.Black;
            kryptonButton6.StateCommon.Content.ShortText.Color1 = Color.Black;
        }

        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void kryptonButton_Click(object sender, EventArgs e){
            panel1.Visible = !panel1.Visible;                       }
        private void kryptonButton1_Click(object sender, EventArgs e){
            panel1.Visible = false;                                  }
        private void kryptonButton2_Click(object sender, EventArgs e) { }
        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            Forms.Corrector correctorForm = new Forms.Corrector();
            correctorForm.Show();
            this.Hide();
        }
        private void kryptonButton2_Click_1(object sender, EventArgs e)
        {
            Forms.Test testForm = new Forms.Test();
            testForm.Show();
            this.Hide();
        }
        private void pictureBox3_Click(object sender, EventArgs e) { }
       private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.FormClosed += (s, args) => this.Close(); // Close the login form when dashboard is closed
            dashboard.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Forms.Simulator simulatorForm = new Forms.Simulator();
            simulatorForm.Show();
            this.Hide();
        }
        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            Forms.ColorDetector cdForm = new Forms.ColorDetector();
            cdForm.Show();
            this.Hide();
        }
    }
}
