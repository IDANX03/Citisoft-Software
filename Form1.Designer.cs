namespace Citisoft_Software
{
    partial class login_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            email_logintextbox = new TextBox();
            password_logintextbox = new TextBox();
            show_password_checkbox = new CheckBox();
            btn_login = new Button();
            label4 = new Label();
            create_account = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 29);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 145);
            label2.Name = "label2";
            label2.Size = new Size(134, 24);
            label2.TabIndex = 1;
            label2.Text = "Email Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 219);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // email_logintextbox
            // 
            email_logintextbox.BorderStyle = BorderStyle.FixedSingle;
            email_logintextbox.ForeColor = SystemColors.WindowText;
            email_logintextbox.Location = new Point(172, 146);
            email_logintextbox.Name = "email_logintextbox";
            email_logintextbox.Size = new Size(228, 27);
            email_logintextbox.TabIndex = 5;
            // 
            // password_logintextbox
            // 
            password_logintextbox.BorderStyle = BorderStyle.FixedSingle;
            password_logintextbox.Location = new Point(172, 216);
            password_logintextbox.Name = "password_logintextbox";
            password_logintextbox.Size = new Size(228, 27);
            password_logintextbox.TabIndex = 6;
            password_logintextbox.UseSystemPasswordChar = true;
            // 
            // show_password_checkbox
            // 
            show_password_checkbox.AutoSize = true;
            show_password_checkbox.Cursor = Cursors.Hand;
            show_password_checkbox.FlatStyle = FlatStyle.Flat;
            show_password_checkbox.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show_password_checkbox.Location = new Point(361, 259);
            show_password_checkbox.Name = "show_password_checkbox";
            show_password_checkbox.Size = new Size(121, 21);
            show_password_checkbox.TabIndex = 7;
            show_password_checkbox.Text = "Show Password";
            show_password_checkbox.UseVisualStyleBackColor = true;
            show_password_checkbox.CheckedChanged += show_password_checkbox_CheckedChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaptionText;
            btn_login.Cursor = Cursors.Hand;
            btn_login.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.ButtonFace;
            btn_login.Location = new Point(159, 341);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(152, 42);
            btn_login.TabIndex = 8;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(187, 408);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 9;
            label4.Text = "Not a user yet?";
            // 
            // create_account
            // 
            create_account.AutoSize = true;
            create_account.Cursor = Cursors.Hand;
            create_account.Font = new Font("Calibri", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            create_account.Location = new Point(172, 423);
            create_account.Name = "create_account";
            create_account.Size = new Size(118, 21);
            create_account.TabIndex = 10;
            create_account.Text = "Create Account";
            create_account.Click += create_account_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = Properties.Resources.citisoft;
            pictureBox1.Location = new Point(159, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(494, 486);
            Controls.Add(pictureBox1);
            Controls.Add(create_account);
            Controls.Add(label4);
            Controls.Add(btn_login);
            Controls.Add(show_password_checkbox);
            Controls.Add(password_logintextbox);
            Controls.Add(email_logintextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox confirm_password_textbox;
        private TextBox email_logintextbox;
        private TextBox password_logintextbox;
        private CheckBox show_password_checkbox;
        private Button btn_login;
        private Label label4;
        private Label create_account;
        private Label label6;
        private TextBox full_name_textbox;
        private PictureBox pictureBox1;
    }
}
