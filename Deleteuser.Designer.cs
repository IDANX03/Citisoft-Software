namespace Citisoft_Software
{
    partial class Deleteuser
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
            delete_id_txt = new TextBox();
            delete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.citisoft;
            pictureBox1.Location = new Point(249, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 1;
            label1.Text = "User ID:";
            // 
            // delete_id_txt
            // 
            delete_id_txt.Location = new Point(117, 103);
            delete_id_txt.Name = "delete_id_txt";
            delete_id_txt.Size = new Size(178, 27);
            delete_id_txt.TabIndex = 2;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = SystemColors.ButtonShadow;
            delete_btn.Cursor = Cursors.Hand;
            delete_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_btn.Location = new Point(117, 177);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(101, 33);
            delete_btn.TabIndex = 3;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // Deleteuser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 255);
            Controls.Add(delete_btn);
            Controls.Add(delete_id_txt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Deleteuser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deleteuser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox delete_id_txt;
        private Button delete_btn;
    }
}