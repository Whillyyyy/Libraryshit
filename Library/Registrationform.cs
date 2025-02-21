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
    }
}
