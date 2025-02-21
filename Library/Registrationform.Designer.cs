namespace Library
{
    partial class Registrationform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrationform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Adminloginbtn = new System.Windows.Forms.Button();
            this.registertlink = new System.Windows.Forms.LinkLabel();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.emailaddtxt = new System.Windows.Forms.TextBox();
            this.studentnumtxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passregtxt = new System.Windows.Forms.TextBox();
            this.conpassregtxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkboxtxt = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 895);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration";
            // 
            // Adminloginbtn
            // 
            this.Adminloginbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Adminloginbtn.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminloginbtn.ForeColor = System.Drawing.Color.White;
            this.Adminloginbtn.Location = new System.Drawing.Point(142, 355);
            this.Adminloginbtn.Name = "Adminloginbtn";
            this.Adminloginbtn.Size = new System.Drawing.Size(191, 38);
            this.Adminloginbtn.TabIndex = 4;
            this.Adminloginbtn.Text = "Register";
            this.Adminloginbtn.UseVisualStyleBackColor = false;
            // 
            // registertlink
            // 
            this.registertlink.AutoSize = true;
            this.registertlink.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registertlink.Location = new System.Drawing.Point(219, 396);
            this.registertlink.Name = "registertlink";
            this.registertlink.Size = new System.Drawing.Size(47, 23);
            this.registertlink.TabIndex = 11;
            this.registertlink.TabStop = true;
            this.registertlink.Text = "Log In";
            this.registertlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registertlink_LinkClicked);
            // 
            // firstnametxt
            // 
            this.firstnametxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnametxt.Location = new System.Drawing.Point(81, 99);
            this.firstnametxt.Multiline = true;
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(154, 35);
            this.firstnametxt.TabIndex = 12;
            this.firstnametxt.Text = "First Name";
            // 
            // lastnametxt
            // 
            this.lastnametxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnametxt.Location = new System.Drawing.Point(241, 99);
            this.lastnametxt.Multiline = true;
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(146, 35);
            this.lastnametxt.TabIndex = 13;
            this.lastnametxt.Text = "Last Name";
            // 
            // emailaddtxt
            // 
            this.emailaddtxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailaddtxt.Location = new System.Drawing.Point(81, 140);
            this.emailaddtxt.Multiline = true;
            this.emailaddtxt.Name = "emailaddtxt";
            this.emailaddtxt.Size = new System.Drawing.Size(306, 40);
            this.emailaddtxt.TabIndex = 14;
            this.emailaddtxt.Text = "Email Address";
            // 
            // studentnumtxt
            // 
            this.studentnumtxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnumtxt.Location = new System.Drawing.Point(81, 186);
            this.studentnumtxt.Multiline = true;
            this.studentnumtxt.Name = "studentnumtxt";
            this.studentnumtxt.Size = new System.Drawing.Size(306, 40);
            this.studentnumtxt.TabIndex = 15;
            this.studentnumtxt.Text = "Student Number";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkboxtxt);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.conpassregtxt);
            this.panel2.Controls.Add(this.passregtxt);
            this.panel2.Controls.Add(this.studentnumtxt);
            this.panel2.Controls.Add(this.emailaddtxt);
            this.panel2.Controls.Add(this.lastnametxt);
            this.panel2.Controls.Add(this.firstnametxt);
            this.panel2.Controls.Add(this.registertlink);
            this.panel2.Controls.Add(this.Adminloginbtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(293, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 438);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // passregtxt
            // 
            this.passregtxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passregtxt.Location = new System.Drawing.Point(81, 232);
            this.passregtxt.Multiline = true;
            this.passregtxt.Name = "passregtxt";
            this.passregtxt.Size = new System.Drawing.Size(306, 40);
            this.passregtxt.TabIndex = 18;
            this.passregtxt.Text = "Password";
            // 
            // conpassregtxt
            // 
            this.conpassregtxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conpassregtxt.Location = new System.Drawing.Point(81, 278);
            this.conpassregtxt.Multiline = true;
            this.conpassregtxt.Name = "conpassregtxt";
            this.conpassregtxt.Size = new System.Drawing.Size(306, 40);
            this.conpassregtxt.TabIndex = 19;
            this.conpassregtxt.Text = "Confirm Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(353, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // checkboxtxt
            // 
            this.checkboxtxt.AutoSize = true;
            this.checkboxtxt.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxtxt.Location = new System.Drawing.Point(81, 319);
            this.checkboxtxt.Name = "checkboxtxt";
            this.checkboxtxt.Size = new System.Drawing.Size(169, 23);
            this.checkboxtxt.TabIndex = 23;
            this.checkboxtxt.Text = "Accept Terms & Conditions";
            this.checkboxtxt.UseVisualStyleBackColor = true;
            // 
            // Registrationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 894);
            this.Controls.Add(this.panel1);
            this.Name = "Registrationform";
            this.Text = "Registrationform";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox studentnumtxt;
        private System.Windows.Forms.TextBox emailaddtxt;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.LinkLabel registertlink;
        private System.Windows.Forms.Button Adminloginbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conpassregtxt;
        private System.Windows.Forms.TextBox passregtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkboxtxt;
    }
}