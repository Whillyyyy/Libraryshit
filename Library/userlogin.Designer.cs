﻿namespace Library
{
    partial class userlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userlogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registertlink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.forgotlink = new System.Windows.Forms.LinkLabel();
            this.checkboxtxt = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Adminloginbtn = new System.Windows.Forms.Button();
            this.passstudentxt = new System.Windows.Forms.TextBox();
            this.studentnumtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 1102);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.registertlink);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.forgotlink);
            this.panel2.Controls.Add(this.checkboxtxt);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.Adminloginbtn);
            this.panel2.Controls.Add(this.passstudentxt);
            this.panel2.Controls.Add(this.studentnumtxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(391, 315);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 471);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 441);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // registertlink
            // 
            this.registertlink.AutoSize = true;
            this.registertlink.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registertlink.Location = new System.Drawing.Point(388, 420);
            this.registertlink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registertlink.Name = "registertlink";
            this.registertlink.Size = new System.Drawing.Size(70, 26);
            this.registertlink.TabIndex = 11;
            this.registertlink.TabStop = true;
            this.registertlink.Text = "Register";
            this.registertlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registertlink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Don\'t have account?";
            // 
            // forgotlink
            // 
            this.forgotlink.AutoSize = true;
            this.forgotlink.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotlink.Location = new System.Drawing.Point(341, 302);
            this.forgotlink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotlink.Name = "forgotlink";
            this.forgotlink.Size = new System.Drawing.Size(142, 26);
            this.forgotlink.TabIndex = 9;
            this.forgotlink.TabStop = true;
            this.forgotlink.Text = "Forgot Password?";
            this.forgotlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkboxtxt
            // 
            this.checkboxtxt.AutoSize = true;
            this.checkboxtxt.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxtxt.Location = new System.Drawing.Point(127, 302);
            this.checkboxtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkboxtxt.Name = "checkboxtxt";
            this.checkboxtxt.Size = new System.Drawing.Size(141, 38);
            this.checkboxtxt.TabIndex = 8;
            this.checkboxtxt.Text = "Remind Me";
            this.checkboxtxt.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(457, 183);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(457, 256);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Adminloginbtn
            // 
            this.Adminloginbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Adminloginbtn.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminloginbtn.ForeColor = System.Drawing.Color.White;
            this.Adminloginbtn.Location = new System.Drawing.Point(189, 352);
            this.Adminloginbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Adminloginbtn.Name = "Adminloginbtn";
            this.Adminloginbtn.Size = new System.Drawing.Size(255, 47);
            this.Adminloginbtn.TabIndex = 4;
            this.Adminloginbtn.Text = "Log In";
            this.Adminloginbtn.UseVisualStyleBackColor = false;
            this.Adminloginbtn.Click += new System.EventHandler(this.Adminloginbtn_Click);
            // 
            // passstudentxt
            // 
            this.passstudentxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passstudentxt.Location = new System.Drawing.Point(127, 245);
            this.passstudentxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passstudentxt.Multiline = true;
            this.passstudentxt.Name = "passstudentxt";
            this.passstudentxt.Size = new System.Drawing.Size(365, 48);
            this.passstudentxt.TabIndex = 3;
            this.passstudentxt.Text = "Password";
            // 
            // studentnumtxt
            // 
            this.studentnumtxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnumtxt.Location = new System.Drawing.Point(127, 172);
            this.studentnumtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentnumtxt.Multiline = true;
            this.studentnumtxt.Name = "studentnumtxt";
            this.studentnumtxt.Size = new System.Drawing.Size(365, 48);
            this.studentnumtxt.TabIndex = 2;
            this.studentnumtxt.Text = "Student Number";
            this.studentnumtxt.TextChanged += new System.EventHandler(this.studentnumtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // userlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 1055);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "userlogin";
            this.Text = "userlogin";
            this.Load += new System.EventHandler(this.userlogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Adminloginbtn;
        private System.Windows.Forms.TextBox passstudentxt;
        private System.Windows.Forms.TextBox studentnumtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkboxtxt;
        private System.Windows.Forms.LinkLabel registertlink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel forgotlink;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}