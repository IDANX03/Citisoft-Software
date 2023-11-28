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
            email_textbox = new TextBox();
            password_textbox = new TextBox();
            show_password_checkbox = new CheckBox();
            btn_login = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 29);
            label1.Name = "label1";
            label1.Size = new Size(176, 38);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 143);
            label2.Name = "label2";
            label2.Size = new Size(151, 22);
            label2.TabIndex = 1;
            label2.Text = "Email Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 211);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // email_textbox
            // 
            email_textbox.BorderStyle = BorderStyle.FixedSingle;
            email_textbox.Location = new Point(219, 138);
            email_textbox.Name = "email_textbox";
            email_textbox.Size = new Size(243, 27);
            email_textbox.TabIndex = 5;
            // 
            // password_textbox
            // 
            password_textbox.BorderStyle = BorderStyle.FixedSingle;
            password_textbox.Location = new Point(219, 206);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(243, 27);
            password_textbox.TabIndex = 6;
            // 
            // show_password_checkbox
            // 
            show_password_checkbox.AutoSize = true;
            show_password_checkbox.Cursor = Cursors.Hand;
            show_password_checkbox.FlatStyle = FlatStyle.Flat;
            show_password_checkbox.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show_password_checkbox.Location = new Point(361, 257);
            show_password_checkbox.Name = "show_password_checkbox";
            show_password_checkbox.Size = new Size(121, 21);
            show_password_checkbox.TabIndex = 7;
            show_password_checkbox.Text = "Show Password";
            show_password_checkbox.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            btn_login.Cursor = Cursors.Hand;
            btn_login.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(150, 297);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(152, 42);
            btn_login.TabIndex = 8;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 384);
            label4.Name = "label4";
            label4.Size = new Size(181, 26);
            label4.TabIndex = 9;
            label4.Text = "Need an Account?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(162, 423);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 10;
            label5.Text = "Create Account";
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 486);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_login);
            Controls.Add(show_password_checkbox);
            Controls.Add(password_textbox);
            Controls.Add(email_textbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox confirm_password_textbox;
        private TextBox email_textbox;
        private TextBox password_textbox;
        private CheckBox show_password_checkbox;
        private Button btn_login;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox full_name_textbox;
    }
}
