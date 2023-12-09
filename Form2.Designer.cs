namespace Citisoft_Software
{
    partial class register_form
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
            back_to_login = new Label();
            label4 = new Label();
            btn_register = new Button();
            show_password_checkbox = new CheckBox();
            password_textbox = new TextBox();
            fullname_textbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            login = new Label();
            label1 = new Label();
            email_textbox = new TextBox();
            confirm_password_textbox = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // back_to_login
            // 
            back_to_login.AutoSize = true;
            back_to_login.Cursor = Cursors.Hand;
            back_to_login.Font = new Font("Calibri", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            back_to_login.Location = new Point(183, 476);
            back_to_login.Name = "back_to_login";
            back_to_login.Size = new Size(103, 21);
            back_to_login.TabIndex = 19;
            back_to_login.Text = "Back to Login";
            back_to_login.Click += back_to_login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(183, 457);
            label4.Name = "label4";
            label4.Size = new Size(113, 19);
            label4.TabIndex = 18;
            label4.Text = "Already a user?";
            // 
            // btn_register
            // 
            btn_register.BackColor = SystemColors.ActiveCaptionText;
            btn_register.Cursor = Cursors.Hand;
            btn_register.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.ForeColor = SystemColors.ButtonHighlight;
            btn_register.Location = new Point(183, 363);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(122, 40);
            btn_register.TabIndex = 17;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // show_password_checkbox
            // 
            show_password_checkbox.AutoSize = true;
            show_password_checkbox.Cursor = Cursors.Hand;
            show_password_checkbox.FlatStyle = FlatStyle.Flat;
            show_password_checkbox.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show_password_checkbox.Location = new Point(394, 329);
            show_password_checkbox.Name = "show_password_checkbox";
            show_password_checkbox.Size = new Size(121, 21);
            show_password_checkbox.TabIndex = 16;
            show_password_checkbox.Text = "Show Password";
            show_password_checkbox.UseVisualStyleBackColor = true;
            show_password_checkbox.CheckedChanged += show_password_checkbox_CheckedChanged;
            // 
            // password_textbox
            // 
            password_textbox.BorderStyle = BorderStyle.FixedSingle;
            password_textbox.Location = new Point(210, 224);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(243, 27);
            password_textbox.TabIndex = 15;
            password_textbox.UseSystemPasswordChar = true;
            password_textbox.TextChanged += password_textbox_TextChanged;
            // 
            // fullname_textbox
            // 
            fullname_textbox.BorderStyle = BorderStyle.FixedSingle;
            fullname_textbox.Location = new Point(210, 108);
            fullname_textbox.Name = "fullname_textbox";
            fullname_textbox.Size = new Size(243, 27);
            fullname_textbox.TabIndex = 14;
            fullname_textbox.TextChanged += fullname_textbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 224);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 171);
            label2.Name = "label2";
            label2.Size = new Size(134, 24);
            label2.TabIndex = 12;
            label2.Text = "Email Address:";
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Californian FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.Location = new Point(36, 22);
            login.Name = "login";
            login.Size = new Size(188, 33);
            login.TabIndex = 11;
            login.Text = "Create Account";
            login.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 107);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 20;
            label1.Text = "Full Name:";
            // 
            // email_textbox
            // 
            email_textbox.BorderStyle = BorderStyle.FixedSingle;
            email_textbox.Location = new Point(210, 168);
            email_textbox.Name = "email_textbox";
            email_textbox.Size = new Size(243, 27);
            email_textbox.TabIndex = 21;
            email_textbox.TextChanged += email_textbox_TextChanged;
            // 
            // confirm_password_textbox
            // 
            confirm_password_textbox.BorderStyle = BorderStyle.FixedSingle;
            confirm_password_textbox.Location = new Point(210, 275);
            confirm_password_textbox.Name = "confirm_password_textbox";
            confirm_password_textbox.Size = new Size(243, 27);
            confirm_password_textbox.TabIndex = 23;
            confirm_password_textbox.UseSystemPasswordChar = true;
            confirm_password_textbox.TextChanged += confirm_password_textbox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 278);
            label5.Name = "label5";
            label5.Size = new Size(169, 24);
            label5.TabIndex = 22;
            label5.Text = "Confirm Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = Properties.Resources.citisoft;
            pictureBox1.Location = new Point(381, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(210, 138);
            label6.Name = "label6";
            label6.Size = new Size(168, 17);
            label6.TabIndex = 25;
            label6.Text = "Max 50 characters allowed";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(192, 0, 0);
            label7.Location = new Point(210, 198);
            label7.Name = "label7";
            label7.Size = new Size(168, 17);
            label7.TabIndex = 26;
            label7.Text = "Max 50 characters allowed";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLightLight;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(210, 254);
            label8.Name = "label8";
            label8.Size = new Size(168, 17);
            label8.TabIndex = 27;
            label8.Text = "Max 50 characters allowed";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlLightLight;
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(192, 0, 0);
            label9.Location = new Point(210, 305);
            label9.Name = "label9";
            label9.Size = new Size(168, 17);
            label9.TabIndex = 28;
            label9.Text = "Max 50 characters allowed";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlLightLight;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(192, 0, 0);
            label10.Location = new Point(210, 305);
            label10.Name = "label10";
            label10.Size = new Size(141, 17);
            label10.TabIndex = 29;
            label10.Text = "Passwords dont match";
            label10.Visible = false;
            // 
            // register_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(527, 513);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(confirm_password_textbox);
            Controls.Add(label5);
            Controls.Add(email_textbox);
            Controls.Add(label1);
            Controls.Add(back_to_login);
            Controls.Add(label4);
            Controls.Add(btn_register);
            Controls.Add(show_password_checkbox);
            Controls.Add(password_textbox);
            Controls.Add(fullname_textbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(login);
            Name = "register_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label back_to_login;
        private Label label4;
        private Button btn_register;
        private CheckBox show_password_checkbox;
        private TextBox password_textbox;
        private TextBox fullname_textbox;
        private Label label3;
        private Label label2;
        private Label login;
        private Label label1;
        private TextBox email_textbox;
        private TextBox confirm_password_textbox;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}