using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Library
{
    public partial class userlogin : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public userlogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void userlogin_Load(object sender, EventArgs e)
        {

        }

        private void studentnumtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void registertlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrationform rForm = new Registrationform();
            rForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Adminloginbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentnumtxt.Text) || string.IsNullOrEmpty(passstudentxt.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                try
                {
                    // Open connection
                    connection.Open();

                    // Use parameterized query to prevent SQL injection
                    string selectQuery = "SELECT * FROM user_register WHERE student_num = @studentnum AND passWord = @password";
                    MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                    cmd.Parameters.AddWithValue("@studentnum", studentnumtxt.Text);
                    cmd.Parameters.AddWithValue("@password", passstudentxt.Text);

                    MySqlDataReader mdr = cmd.ExecuteReader();

                    if (mdr.HasRows)
                    {
                        // User is valid, now update the last login
                        mdr.Close(); // Close the reader before using it again

                        string MyConnection2 = "Server=127.0.0.1;Database=library;username=root;password=";
                        string Query = "UPDATE user_register SET LastLogin = @studentnum WHERE student_num = @studentnum";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MyCommand2.Parameters.AddWithValue("@studentnum", studentnumtxt.Text);
                        MyConn2.Open();
                        MyCommand2.ExecuteNonQuery();
                        MyConn2.Close();

                        MessageBox.Show("Login Successful!");
                        this.Hide(); // Hide login form (or navigate to another form)
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Login Information! Try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }
    }
}
