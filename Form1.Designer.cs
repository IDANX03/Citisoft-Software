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
            label4 = new Label();
            confirm_password_textbox = new TextBox();
            password_textbox = new TextBox();
            username_textbox = new TextBox();
            show_password_checkbox = new CheckBox();
            btn_register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 60);
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
            label2.Size = new Size(108, 22);
            label2.TabIndex = 1;
            label2.Text = "Username:";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 285);
            label4.Name = "label4";
            label4.Size = new Size(182, 22);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password:";
            // 
            // confirm_password_textbox
            // 
            confirm_password_textbox.BorderStyle = BorderStyle.FixedSingle;
            confirm_password_textbox.ForeColor = SystemColors.WindowText;
            confirm_password_textbox.Location = new Point(219, 285);
            confirm_password_textbox.Name = "confirm_password_textbox";
            confirm_password_textbox.Size = new Size(243, 27);
            confirm_password_textbox.TabIndex = 4;
            // 
            // password_textbox
            // 
            password_textbox.BorderStyle = BorderStyle.FixedSingle;
            password_textbox.Location = new Point(219, 211);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(243, 27);
            password_textbox.TabIndex = 5;
            // 
            // username_textbox
            // 
            username_textbox.BorderStyle = BorderStyle.FixedSingle;
            username_textbox.Location = new Point(219, 143);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(243, 27);
            username_textbox.TabIndex = 6;
            // 
            // show_password_checkbox
            // 
            show_password_checkbox.AutoSize = true;
            show_password_checkbox.Cursor = Cursors.Hand;
            show_password_checkbox.FlatStyle = FlatStyle.Flat;
            show_password_checkbox.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show_password_checkbox.Location = new Point(366, 334);
            show_password_checkbox.Name = "show_password_checkbox";
            show_password_checkbox.Size = new Size(121, 21);
            show_password_checkbox.TabIndex = 7;
            show_password_checkbox.Text = "Show Password";
            show_password_checkbox.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(188, 357);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(152, 42);
            btn_register.TabIndex = 8;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = true;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 486);
            Controls.Add(btn_register);
            Controls.Add(show_password_checkbox);
            Controls.Add(username_textbox);
            Controls.Add(password_textbox);
            Controls.Add(confirm_password_textbox);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox confirm_password_textbox;
        private TextBox password_textbox;
        private TextBox username_textbox;
        private CheckBox show_password_checkbox;
        private Button btn_register;
    }
}
