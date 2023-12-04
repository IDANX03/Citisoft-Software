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
            view_vendor_adminbtn = new Button();
            pictureBox1 = new PictureBox();
            view_products_adminbtn = new Button();
            add_vendor_btn = new Button();
            add_products_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(162, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(479, 301);
            dataGridView1.TabIndex = 0;
            // 
            // view_vendor_adminbtn
            // 
            view_vendor_adminbtn.Cursor = Cursors.Hand;
            view_vendor_adminbtn.FlatStyle = FlatStyle.Popup;
            view_vendor_adminbtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view_vendor_adminbtn.Location = new Point(12, 121);
            view_vendor_adminbtn.Name = "view_vendor_adminbtn";
            view_vendor_adminbtn.Size = new Size(126, 29);
            view_vendor_adminbtn.TabIndex = 1;
            view_vendor_adminbtn.Text = "View Vendors";
            view_vendor_adminbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.citisoft;
            pictureBox1.Location = new Point(13, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // view_products_adminbtn
            // 
            view_products_adminbtn.Cursor = Cursors.Hand;
            view_products_adminbtn.FlatStyle = FlatStyle.Popup;
            view_products_adminbtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view_products_adminbtn.Location = new Point(13, 187);
            view_products_adminbtn.Name = "view_products_adminbtn";
            view_products_adminbtn.Size = new Size(125, 29);
            view_products_adminbtn.TabIndex = 3;
            view_products_adminbtn.Text = "View Products";
            view_products_adminbtn.UseVisualStyleBackColor = true;
            // 
            // add_vendor_btn
            // 
            add_vendor_btn.Cursor = Cursors.Hand;
            add_vendor_btn.FlatStyle = FlatStyle.Popup;
            add_vendor_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_vendor_btn.Location = new Point(12, 262);
            add_vendor_btn.Name = "add_vendor_btn";
            add_vendor_btn.Size = new Size(125, 29);
            add_vendor_btn.TabIndex = 4;
            add_vendor_btn.Text = "Add Vendors";
            add_vendor_btn.UseVisualStyleBackColor = true;
            // 
            // add_products_btn
            // 
            add_products_btn.Cursor = Cursors.Hand;
            add_products_btn.FlatStyle = FlatStyle.Popup;
            add_products_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_products_btn.Location = new Point(13, 337);
            add_products_btn.Name = "add_products_btn";
            add_products_btn.Size = new Size(125, 29);
            add_products_btn.TabIndex = 5;
            add_products_btn.Text = "Add Products";
            add_products_btn.UseVisualStyleBackColor = true;
            // 
            // Adminpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add_products_btn);
            Controls.Add(add_vendor_btn);
            Controls.Add(view_products_adminbtn);
            Controls.Add(pictureBox1);
            Controls.Add(view_vendor_adminbtn);
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
        private Button view_vendor_adminbtn;
        private PictureBox pictureBox1;
        private Button view_products_adminbtn;
        private Button add_vendor_btn;
        private Button add_products_btn;
    }
}