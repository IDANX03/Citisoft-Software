namespace Citisoft_Software
{
    partial class Adminpage
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            edit_userbtn = new Button();
            logout_btn = new Button();
            add_user_btn = new Button();
            delete_user_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(172, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(606, 390);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.citisoft;
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(13, 154);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 3;
            button1.Text = "Edit Vendor";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(13, 216);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 4;
            button2.Text = "Edit Products";
            button2.UseVisualStyleBackColor = true;
            // 
            // edit_userbtn
            // 
            edit_userbtn.Cursor = Cursors.Hand;
            edit_userbtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edit_userbtn.Location = new Point(12, 286);
            edit_userbtn.Name = "edit_userbtn";
            edit_userbtn.Size = new Size(125, 29);
            edit_userbtn.TabIndex = 5;
            edit_userbtn.Text = "Edit User";
            edit_userbtn.UseVisualStyleBackColor = true;
            edit_userbtn.Click += edit_userbtn_Click;
            // 
            // logout_btn
            // 
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatStyle = FlatStyle.Popup;
            logout_btn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.Location = new Point(13, 373);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(98, 36);
            logout_btn.TabIndex = 6;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // add_user_btn
            // 
            add_user_btn.Cursor = Cursors.Hand;
            add_user_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_user_btn.Location = new Point(172, 98);
            add_user_btn.Name = "add_user_btn";
            add_user_btn.Size = new Size(94, 29);
            add_user_btn.TabIndex = 7;
            add_user_btn.Text = "Add User";
            add_user_btn.UseVisualStyleBackColor = true;
            add_user_btn.Click += add_user_btn_Click;
            // 
            // delete_user_btn
            // 
            delete_user_btn.Cursor = Cursors.Hand;
            delete_user_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_user_btn.Location = new Point(301, 98);
            delete_user_btn.Name = "delete_user_btn";
            delete_user_btn.Size = new Size(106, 29);
            delete_user_btn.TabIndex = 8;
            delete_user_btn.Text = "Delete User";
            delete_user_btn.UseVisualStyleBackColor = true;
            delete_user_btn.Click += delete_user_btn_Click;
            // 
            // Adminpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 573);
            Controls.Add(delete_user_btn);
            Controls.Add(add_user_btn);
            Controls.Add(logout_btn);
            Controls.Add(edit_userbtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "Adminpage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adminpage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button edit_userbtn;
        private Button logout_btn;
        private Button add_user_btn;
        private Button delete_user_btn;
    }
}