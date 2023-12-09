using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citisoft_Software
{
    public partial class register_form : Form
    {
        public register_form()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\iamid\Documents\Idan documents\Software engineering\Visual studios code\Citisoft Software\userdata.mdf"";Integrated Security=True");

        private void back_to_login_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form log = new login_form();
            log.Show();

        }

        private void show_password_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password_checkbox.Checked)
            {
                password_textbox.UseSystemPasswordChar = false;
                confirm_password_textbox.UseSystemPasswordChar = false;
            }
            else
            {
                password_textbox.UseSystemPasswordChar = true;
                confirm_password_textbox.UseSystemPasswordChar = true;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                if (fullname_textbox.Text == "" && email_textbox.Text == "" && password_textbox.Text == "" && confirm_password_textbox.Text == "")
                {
                    MessageBox.Show("Required boxes is Empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password_textbox.Text == confirm_password_textbox.Text)
                {
                    con.Open();
                    string reg = "INSERT INTO user_details(full_name,email_address,password) VALUES('" + fullname_textbox.Text + "', '" + email_textbox.Text + "', '" + password_textbox.Text + "')";

                    SqlCommand cmd = new SqlCommand(reg, con);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Account created Successfully", "Registration Completed", MessageBoxButtons.OK);
                    fullname_textbox.Clear();
                    email_textbox.Clear();
                    password_textbox.Clear();
                    confirm_password_textbox.Clear();
                    label10.Visible = false;
                    fullname_textbox.Focus();
                }
                else
                {
                    label10.Visible = true;
                    password_textbox.Clear();
                    confirm_password_textbox.Clear() ;
                    password_textbox.Focus();
                }




            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
            con.Close();
        }

        private void fullname_textbox_TextChanged(object sender, EventArgs e)
        {
            if (fullname_textbox.Text.Length > 50)
            {
                label6.Visible = true;
            }
            else { label6.Visible = false; }
        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {
            if (email_textbox.Text.Length > 50)
            {
                label7.Visible = true;
            }
            else { label7.Visible = false; }
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            if (password_textbox.Text.Length > 50)
            {
                label8.Visible = true;
            }
            else { label8.Visible = false; }
        }

        private void confirm_password_textbox_TextChanged(object sender, EventArgs e)
        {
            if (confirm_password_textbox.Text.Length > 50)
            {
                label9.Visible = true;
            }
            else { label9.Visible = false; }
        }
    }
}

            
            
                
            
            
            
           