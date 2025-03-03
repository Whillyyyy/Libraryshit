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
    MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
    MySqlCommand command;
    MySqlDataReader mdr;
    public partial class Registrationform : Form
    {
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
                register_password.PasswordChar = '\0';
            }
        }

        private void show_btn2_Click(object sender, EventArgs e)
        {
            if (conpassregtxt.PasswordChar == '\0')
            {
                show_btn2.BringToFront();
                register_password.PasswordChar = '*';
            }
        }
    }
}
