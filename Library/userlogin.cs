using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class userlogin : Form
    {
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
    }
}
