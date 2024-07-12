using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.DataFormats;
using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;

namespace WinFormsApp3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        private void Login_Load(object sender, EventArgs e) { }
        private void OpenDashboard()
        {
            // Hiding the login form
            this.Hide();
            // Creating and showing the dashboard form
            Dashboard dashboard = new Dashboard();
            dashboard.FormClosed += (s, args) => this.Close(); // Close the login form when dashboard is closed
            dashboard.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
        private void pictureBox1_Click_2(object sender, EventArgs e) { }
        private void pictureBox1_Click_3(object sender, EventArgs e) { }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                MessageBox.Show("Enter the user name");
            }
            else if (kryptonTextBox1.Text == "")
            {
                MessageBox.Show("Enter the password");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\KASHIF\\OneDrive\\Documents\\LoginData.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand("select * from datalog where username=@username and password=@password", con);
                    //Parameters @username and @password are added to the SQL command to prevent SQL injection attacks.
                    cmd.Parameters.AddWithValue("@username", kryptonTextBox2.Text);
                    cmd.Parameters.AddWithValue("@password", kryptonTextBox1.Text);
                    //A SqlDataAdapter object da is created, to fill a DataTable object 'dt' with the result of the SQL query.
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        OpenDashboard();
                    }
                    else
                    {
                        MessageBox.Show("username or password is invalid");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void kryptonTextBox2_TextChanged(object sender, EventArgs e) { }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
