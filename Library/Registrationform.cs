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
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=library;username=root;password=");
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
        { string firstname = firstnametxt.Text;
            string lastname = lastnametxt.Text;
            string studentnum = studentnumtxt.Text;
            string emailadd = emailaddtxt.Text;
            string password = register_password.Text;
            string confirmpass = conpassregtxt.Text;



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
            try
            {
                connection.Open();
                string query = "INSERT INTO `user_register`( `firstName`, `lastName`, `student_num`, `emailAdd`, `passWord`, `confirmPass`) VALUES (@firstname,@lastname,@studentnum,@emailadd,@password,@conpass)";
                MySqlCommand cmd = new MySqlCommand(query,connection);
                cmd.Parameters.AddWithValue("@firstname",firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@studentnum", studentnum);
                cmd.Parameters.AddWithValue("@emailadd", emailadd);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@conpass", confirmpass);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully");

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
