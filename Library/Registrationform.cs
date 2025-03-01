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
    MySqlConnection connection = new MySqlConnection("datasource=locahost;port=3306;username=root;password=");
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
            register_password.PasswordChar = register_showPass.Cli
        }
    }
}
