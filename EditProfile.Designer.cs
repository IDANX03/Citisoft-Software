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
            // 
            // email_edit_textbox
            // 
            email_edit_textbox.Location = new Point(195, 160);
            email_edit_textbox.Name = "email_edit_textbox";
            email_edit_textbox.Size = new Size(199, 27);
            email_edit_textbox.TabIndex = 7;
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
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 439);
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
    }
}