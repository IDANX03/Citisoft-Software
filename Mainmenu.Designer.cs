namespace Citisoft_Software
{
    partial class Mainmenu
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            view_vendor_btn = new Button();
            view_product_btn = new Button();
            logout_btn = new Button();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            searchbtn = new Button();
            edit_profilebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.citisoft;
            pictureBox1.Location = new Point(22, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 27);
            textBox1.TabIndex = 1;
            // 
            // view_vendor_btn
            // 
            view_vendor_btn.Cursor = Cursors.Hand;
            view_vendor_btn.FlatStyle = FlatStyle.Popup;
            view_vendor_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view_vendor_btn.Location = new Point(22, 172);
            view_vendor_btn.Name = "view_vendor_btn";
            view_vendor_btn.Size = new Size(164, 36);
            view_vendor_btn.TabIndex = 2;
            view_vendor_btn.Text = "View Vendor";
            view_vendor_btn.UseVisualStyleBackColor = true;
            // 
            // view_product_btn
            // 
            view_product_btn.Cursor = Cursors.Hand;
            view_product_btn.FlatStyle = FlatStyle.Popup;
            view_product_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view_product_btn.Location = new Point(22, 235);
            view_product_btn.Name = "view_product_btn";
            view_product_btn.Size = new Size(164, 36);
            view_product_btn.TabIndex = 3;
            view_product_btn.Text = "View Product";
            view_product_btn.UseVisualStyleBackColor = true;
            // 
            // logout_btn
            // 
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatStyle = FlatStyle.Popup;
            logout_btn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.Location = new Point(22, 387);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(98, 36);
            logout_btn.TabIndex = 4;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 21);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(233, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(497, 280);
            dataGridView1.TabIndex = 6;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.Transparent;
            searchbtn.ForeColor = Color.DimGray;
            searchbtn.Location = new Point(524, 63);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(35, 31);
            searchbtn.TabIndex = 7;
            searchbtn.Text = ">";
            searchbtn.UseVisualStyleBackColor = false;
            // 
            // edit_profilebtn
            // 
            edit_profilebtn.Cursor = Cursors.Hand;
            edit_profilebtn.FlatStyle = FlatStyle.Popup;
            edit_profilebtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edit_profilebtn.Location = new Point(22, 318);
            edit_profilebtn.Name = "edit_profilebtn";
            edit_profilebtn.Size = new Size(164, 36);
            edit_profilebtn.TabIndex = 8;
            edit_profilebtn.Text = "Edit Profile";
            edit_profilebtn.UseVisualStyleBackColor = true;
            edit_profilebtn.Click += edit_profilebtn_Click;
            // 
            // Mainmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 450);
            Controls.Add(edit_profilebtn);
            Controls.Add(searchbtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(logout_btn);
            Controls.Add(view_product_btn);
            Controls.Add(view_vendor_btn);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Mainmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mainmenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button view_vendor_btn;
        private Button view_product_btn;
        private Button logout_btn;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private Button searchbtn;
        private Button edit_profilebtn;
    }
}