using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    //Sign Up inherited from "Form" class
    public partial class Signup : Form
    {
        //connect encapsulated in signup
        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\KASHIF\\OneDrive\\Documents\\LoginData.mdf;Integrated Security=True;Connect Timeout=30");
        public Signup()
        {
            InitializeComponent();
        }
        //OpenDashboard  and Open SignUP is being overriden
        private void OpenDashboard()
        {
            // Hiding the login form
            this.Hide();
            // Creating and showing the dashboard form
            Dashboard dashboard = new Dashboard();
           dashboard.Show();
        }
        private void OpenSignIn()
        {
            // Hide the login form
            this.Hide();

            // Create and show the dashboard form
            Login loginpage = new Login();
            loginpage.FormClosed += (s, args) => this.Close(); // Close the form
            loginpage.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    //checks if username already exist
                    string checkusername = "select * from datalog where username ='" + kryptonTextBox3.Text.Trim() + "'";
                    using (SqlCommand checkuser = new SqlCommand(checkusername, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkuser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(kryptonTextBox3.Text + " is already exist", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertdata = "insert into datalog(username,password) values(@username,@password)";
                            using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                            {
                                //To avoid SQL injection.
                                cmd.Parameters.AddWithValue("@username", kryptonTextBox3.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", kryptonTextBox3.Text.Trim());
                                //Non Query : when we aren't retrieving any data
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Registered successfully");
                                OpenDashboard();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connect.Close();
                }

            }
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            OpenSignIn();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}