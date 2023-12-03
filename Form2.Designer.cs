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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // back_to_login
            // 
            back_to_login.AutoSize = true;
            back_to_login.Cursor = Cursors.Hand;
            back_to_login.Font = new Font("Calibri", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            back_to_login.Location = new Point(176, 445);
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
            label4.Location = new Point(176, 426);
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
            btn_register.Location = new Point(167, 335);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(122, 40);
            btn_register.TabIndex = 17;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            // 
            // show_password_checkbox
            // 
            show_password_checkbox.AutoSize = true;
            show_password_checkbox.Cursor = Cursors.Hand;
            show_password_checkbox.FlatStyle = FlatStyle.Flat;
            show_password_checkbox.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show_password_checkbox.Location = new Point(361, 302);
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
            password_textbox.Location = new Point(214, 212);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(243, 27);
            password_textbox.TabIndex = 15;
            password_textbox.UseSystemPasswordChar = true;
            // 
            // fullname_textbox
            // 
            fullname_textbox.BorderStyle = BorderStyle.FixedSingle;
            fullname_textbox.Location = new Point(214, 110);
            fullname_textbox.Name = "fullname_textbox";
            fullname_textbox.Size = new Size(243, 27);
            fullname_textbox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 212);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 163);
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
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 20;
            label1.Text = "Full Name:";
            // 
            // email_textbox
            // 
            email_textbox.BorderStyle = BorderStyle.FixedSingle;
            email_textbox.Location = new Point(214, 160);
            email_textbox.Name = "email_textbox";
            email_textbox.Size = new Size(243, 27);
            email_textbox.TabIndex = 21;
            // 
            // confirm_password_textbox
            // 
            confirm_password_textbox.BorderStyle = BorderStyle.FixedSingle;
            confirm_password_textbox.Location = new Point(214, 259);
            confirm_password_textbox.Name = "confirm_password_textbox";
            confirm_password_textbox.Size = new Size(243, 27);
            confirm_password_textbox.TabIndex = 23;
            confirm_password_textbox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 259);
            label5.Name = "label5";
            label5.Size = new Size(169, 24);
            label5.TabIndex = 22;
            label5.Text = "Confirm Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = Properties.Resources.citisoft;
            pictureBox1.Location = new Point(357, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // register_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(494, 513);
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
            Cursor = Cursors.Hand;
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
    }
}