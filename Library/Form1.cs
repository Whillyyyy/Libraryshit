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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            userlogin userlogin = new userlogin();
            userlogin.Show();
            this.Hide();
        }

        private void Adminloginbtn_Click(object sender, EventArgs e)
        {
            admindashboard admindashboard = new admindashboard();
            admindashboard.Show();
            this.Hide();
        }
    }
}
