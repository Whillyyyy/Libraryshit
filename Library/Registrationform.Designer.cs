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
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkboxtxt = new System.Windows.Forms.CheckBox();
            this.register_showPass2 = new System.Windows.Forms.PictureBox();
            this.register_showPass = new System.Windows.Forms.PictureBox();
            this.conpassregtxt = new System.Windows.Forms.TextBox();
            this.register_password = new System.Windows.Forms.TextBox();
            this.studentnumtxt = new System.Windows.Forms.TextBox();
            this.emailaddtxt = new System.Windows.Forms.TextBox();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.registertlink = new System.Windows.Forms.LinkLabel();
            this.register_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_showPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.register_showPass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 1102);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkboxtxt);
            this.panel2.Controls.Add(this.register_showPass2);
            this.panel2.Controls.Add(this.register_showPass);
            this.panel2.Controls.Add(this.conpassregtxt);
            this.panel2.Controls.Add(this.register_password);
            this.panel2.Controls.Add(this.studentnumtxt);
            this.panel2.Controls.Add(this.emailaddtxt);
            this.panel2.Controls.Add(this.lastnametxt);
            this.panel2.Controls.Add(this.firstnametxt);
            this.panel2.Controls.Add(this.registertlink);
            this.panel2.Controls.Add(this.register_btn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(391, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 539);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // checkboxtxt
            // 
            this.checkboxtxt.AutoSize = true;
            this.checkboxtxt.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxtxt.Location = new System.Drawing.Point(108, 393);
            this.checkboxtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkboxtxt.Name = "checkboxtxt";
            this.checkboxtxt.Size = new System.Drawing.Size(212, 29);
            this.checkboxtxt.TabIndex = 23;
            this.checkboxtxt.Text = "Accept Terms & Conditions";
            this.checkboxtxt.UseVisualStyleBackColor = true;
            // 
            // register_showPass2
            // 
            this.register_showPass2.Image = ((System.Drawing.Image)(resources.GetObject("register_showPass2.Image")));
            this.register_showPass2.Location = new System.Drawing.Point(471, 353);
            this.register_showPass2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_showPass2.Name = "register_showPass2";
            this.register_showPass2.Size = new System.Drawing.Size(27, 27);
            this.register_showPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.register_showPass2.TabIndex = 21;
            this.register_showPass2.TabStop = false;
            // 
            // register_showPass
            // 
            this.register_showPass.Image = ((System.Drawing.Image)(resources.GetObject("register_showPass.Image")));
            this.register_showPass.Location = new System.Drawing.Point(471, 297);
            this.register_showPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(27, 27);
            this.register_showPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.register_showPass.TabIndex = 20;
            this.register_showPass.TabStop = false;
            // 
            // conpassregtxt
            // 
            this.conpassregtxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conpassregtxt.Location = new System.Drawing.Point(108, 342);
            this.conpassregtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conpassregtxt.Multiline = true;
            this.conpassregtxt.Name = "conpassregtxt";
            this.conpassregtxt.Size = new System.Drawing.Size(407, 48);
            this.conpassregtxt.TabIndex = 19;
            this.conpassregtxt.Text = "Confirm Password";
            // 
            // register_password
            // 
            this.register_password.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(108, 286);
            this.register_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_password.Multiline = true;
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(407, 48);
            this.register_password.TabIndex = 18;
            this.register_password.Text = "Password";
            this.register_password.TextChanged += new System.EventHandler(this.passregtxt_TextChanged);
            // 
            // studentnumtxt
            // 
            this.studentnumtxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnumtxt.Location = new System.Drawing.Point(108, 229);
            this.studentnumtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentnumtxt.Multiline = true;
            this.studentnumtxt.Name = "studentnumtxt";
            this.studentnumtxt.Size = new System.Drawing.Size(407, 48);
            this.studentnumtxt.TabIndex = 15;
            this.studentnumtxt.Text = "Student Number";
            // 
            // emailaddtxt
            // 
            this.emailaddtxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailaddtxt.Location = new System.Drawing.Point(108, 172);
            this.emailaddtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailaddtxt.Multiline = true;
            this.emailaddtxt.Name = "emailaddtxt";
            this.emailaddtxt.Size = new System.Drawing.Size(407, 48);
            this.emailaddtxt.TabIndex = 14;
            this.emailaddtxt.Text = "Email Address";
            // 
            // lastnametxt
            // 
            this.lastnametxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnametxt.Location = new System.Drawing.Point(321, 122);
            this.lastnametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastnametxt.Multiline = true;
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(193, 42);
            this.lastnametxt.TabIndex = 13;
            this.lastnametxt.Text = "Last Name";
            // 
            // firstnametxt
            // 
            this.firstnametxt.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnametxt.Location = new System.Drawing.Point(108, 122);
            this.firstnametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstnametxt.Multiline = true;
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(204, 42);
            this.firstnametxt.TabIndex = 12;
            this.firstnametxt.Text = "First Name";
            // 
            // registertlink
            // 
            this.registertlink.AutoSize = true;
            this.registertlink.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registertlink.Location = new System.Drawing.Point(292, 487);
            this.registertlink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registertlink.Name = "registertlink";
            this.registertlink.Size = new System.Drawing.Size(62, 30);
            this.registertlink.TabIndex = 11;
            this.registertlink.TabStop = true;
            this.registertlink.Text = "Log In";
            this.registertlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registertlink_LinkClicked);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.register_btn.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(189, 437);
            this.register_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(255, 47);
            this.register_btn.TabIndex = 4;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.Adminloginbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration";
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
            // Registrationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 1055);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registrationform";
            this.Text = "Registrationform";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_showPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.register_showPass)).EndInit();
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
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conpassregtxt;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.PictureBox register_showPass2;
        private System.Windows.Forms.PictureBox register_showPass;
        private System.Windows.Forms.CheckBox checkboxtxt;
    }
}