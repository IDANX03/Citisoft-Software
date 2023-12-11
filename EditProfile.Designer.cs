namespace Citisoft_Software
{
    partial class EditProfile
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            fullname_edit_textbox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            password_edit_textbox = new TextBox();
            email_edit_textbox = new TextBox();
            label5 = new Label();
            conpassword_edit_textbox = new TextBox();
            btn_save = new Button();
            back_edit_btn = new Button();
            show_password_checkbox = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.citisoft;
            pictureBox1.Location = new Point(395, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(173, 39);
            label1.TabIndex = 1;
            label1.Text = "Edit Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 2;
            label2.Text = "Fullname:";
            // 
            // fullname_edit_textbox
            // 
            fullname_edit_textbox.Location = new Point(195, 107);
            fullname_edit_textbox.Name = "fullname_edit_textbox";
            fullname_edit_textbox.Size = new Size(199, 27);
            fullname_edit_textbox.TabIndex = 3;
            fullname_edit_textbox.TextChanged += fullname_edit_textbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(133, 22);
            label3.TabIndex = 4;
            label3.Text = "Email Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 222);
            label4.Name = "label4";
            label4.Size = new Size(94, 22);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // password_edit_textbox
            // 
            password_edit_textbox.Location = new Point(195, 217);
            password_edit_textbox.Name = "password_edit_textbox";
            password_edit_textbox.Size = new Size(199, 27);
            password_edit_textbox.TabIndex = 6;
            password_edit_textbox.TextChanged += password_edit_textbox_TextChanged;
            // 
            // email_edit_textbox
            // 
            email_edit_textbox.Location = new Point(195, 160);
            email_edit_textbox.Name = "email_edit_textbox";
            email_edit_textbox.Size = new Size(199, 27);
            email_edit_textbox.TabIndex = 7;
            email_edit_textbox.TextChanged += email_edit_textbox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 284);
            label5.Name = "label5";
            label5.Size = new Size(164, 22);
            label5.TabIndex = 8;
            label5.Text = "Confirm Password:";
            // 
            // conpassword_edit_textbox
            // 
            conpassword_edit_textbox.Location = new Point(195, 279);
            conpassword_edit_textbox.Name = "conpassword_edit_textbox";
            conpassword_edit_textbox.Size = new Size(199, 27);
            conpassword_edit_textbox.TabIndex = 9;
            conpassword_edit_textbox.TextChanged += conpassword_edit_textbox_TextChanged;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaptionText;
            btn_save.Cursor = Cursors.Hand;
            btn_save.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_save.ForeColor = SystemColors.ButtonHighlight;
            btn_save.Location = new Point(178, 343);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(122, 40);
            btn_save.TabIndex = 18;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // back_edit_btn
            // 
            back_edit_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back_edit_btn.Location = new Point(12, 393);
            back_edit_btn.Name = "back_edit_btn";
            back_edit_btn.Size = new Size(94, 29);
            back_edit_btn.TabIndex = 19;
            back_edit_btn.Text = "Back";
            back_edit_btn.UseVisualStyleBackColor = true;
            back_edit_btn.Click += back_edit_btn_Click;
            // 
            // show_password_checkbox
            // 
            show_password_checkbox.AutoSize = true;
            show_password_checkbox.Cursor = Cursors.Hand;
            show_password_checkbox.FlatStyle = FlatStyle.Flat;
            show_password_checkbox.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show_password_checkbox.Location = new Point(373, 327);
            show_password_checkbox.Name = "show_password_checkbox";
            show_password_checkbox.Size = new Size(121, 21);
            show_password_checkbox.TabIndex = 20;
            show_password_checkbox.Text = "Show Password";
            show_password_checkbox.UseVisualStyleBackColor = true;
            show_password_checkbox.CheckedChanged += show_password_checkbox_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(195, 137);
            label6.Name = "label6";
            label6.Size = new Size(168, 17);
            label6.TabIndex = 26;
            label6.Text = "Max 50 characters allowed";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(192, 0, 0);
            label7.Location = new Point(195, 190);
            label7.Name = "label7";
            label7.Size = new Size(168, 17);
            label7.TabIndex = 27;
            label7.Text = "Max 50 characters allowed";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLightLight;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(195, 247);
            label8.Name = "label8";
            label8.Size = new Size(168, 17);
            label8.TabIndex = 28;
            label8.Text = "Max 50 characters allowed";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlLightLight;
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(192, 0, 0);
            label9.Location = new Point(195, 309);
            label9.Name = "label9";
            label9.Size = new Size(168, 17);
            label9.TabIndex = 29;
            label9.Text = "Max 50 characters allowed";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlLightLight;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(192, 0, 0);
            label10.Location = new Point(195, 309);
            label10.Name = "label10";
            label10.Size = new Size(141, 17);
            label10.TabIndex = 30;
            label10.Text = "Passwords dont match";
            label10.Visible = false;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 439);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(show_password_checkbox);
            Controls.Add(back_edit_btn);
            Controls.Add(btn_save);
            Controls.Add(conpassword_edit_textbox);
            Controls.Add(label5);
            Controls.Add(email_edit_textbox);
            Controls.Add(password_edit_textbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(fullname_edit_textbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox fullname_edit_textbox;
        private Label label3;
        private Label label4;
        private TextBox password_edit_textbox;
        private TextBox email_edit_textbox;
        private Label label5;
        private TextBox conpassword_edit_textbox;
        private Button btn_save;
        private Button back_edit_btn;
        private CheckBox show_password_checkbox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}