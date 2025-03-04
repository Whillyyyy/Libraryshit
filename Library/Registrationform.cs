using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    
    public partial class Registrationform : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Registrationform()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registertlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userlogin lForm = new userlogin();
            lForm.Show();
            this.Hide();
        }

        private void Adminloginbtn_Click(object sender, EventArgs e)
        {
            if (!this.emailaddtxt.Text.Contains('@') || !this.emailaddtxt.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (register_password.Text != register_password.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }
            if (conpassregtxt.Text != conpassregtxt.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(firstnametxt.Text) || string.IsNullOrEmpty(lastnametxt.Text) || string.IsNullOrEmpty(emailaddtxt.Text) || string.IsNullOrEmpty(studentnumtxt.Text) || string.IsNullOrEmpty(register_password.Text) || string.IsNullOrEmpty(conpassregtxt.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM `user_register` WHERE 1", connection),
                cmd2 = new MySqlCommand("SELECT * FROM `user_register` WHERE 1", connection);


                cmd1.Parameters.AddWithValue("@student_num", studentnumtxt.Text);
                cmd2.Parameters.AddWithValue("@emailAdd", emailaddtxt.Text);

                bool studentnumExists = false, emailAddExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (studentnumExists = dr1.HasRows) MessageBox.Show("Student Number not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (emailAddExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(studentnumExists || emailAddExists))
                {

                    string iquery = "INSERT INTO library.user_register(`ID`,`firstName`,`lastName`,`student_num`,`emailAdd`,`passWord`, 'confirmPass') VALUES (NULL, '" + firstnametxt.Text + "', '" + lastnametxt.Text + "', '" + emailaddtxt.Text + "', '" + studentnumtxt.Text + "', '" + register_password.Text + "', '" + conpassregtxt.Text + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Account Successfully Created!");

                }

                connection.Close();
            }

        }

        private void passregtxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(register_password.PasswordChar == '*')
            {
                hide_btn.BringToFront();
                register_password.PasswordChar = '\0';
            }
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            if (register_password.PasswordChar == '\0')
            {
                show_btn.BringToFront();
                register_password.PasswordChar = '*';
            }
        }

        private void hide_btn2_Click(object sender, EventArgs e)
        {
            if (conpassregtxt.PasswordChar == '*')
            {
                hide_btn2.BringToFront();
                conpassregtxt.PasswordChar = '\0';
            }
        }

        private void show_btn2_Click(object sender, EventArgs e)
        {
            if (conpassregtxt.PasswordChar == '\0')
            {
                show_btn2.BringToFront();
                conpassregtxt.PasswordChar = '*';
            }
        }
    }
}
