using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citisoft_Software
{
    public partial class EditProfile : Form
    {
        public static EditProfile Instance;
        public EditProfile()
        {
            InitializeComponent();
            Instance = this;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\iamid\Documents\Idan documents\Software engineering\Visual studios code\Citisoft Software\userdata.mdf"";Integrated Security=True");


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (fullname_edit_textbox.Text == "" && email_edit_textbox.Text == "" && password_edit_textbox.Text == "" && conpassword_edit_textbox.Text == "")
                {
                    MessageBox.Show("Boxes are Empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password_edit_textbox.Text == conpassword_edit_textbox.Text)
                {
                    con.Open();
                    string update = "UPDATE user_details SET full_name= '"+fullname_edit_textbox.Text+"', email_address = '"+ email_edit_textbox.Text + "', password = '"+ password_edit_textbox.Text + "' WHERE email_address = '" + login_form.instance.tbemail.Text+ "' AND password = '" + login_form.instance.tbpassword.Text+ "'";
                    SqlCommand cmd = new SqlCommand(update, con);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Account updated Successfully", "Update Completed", MessageBoxButtons.OK);
                    fullname_edit_textbox.Clear();
                    email_edit_textbox.Clear();
                    password_edit_textbox.Clear();
                    conpassword_edit_textbox.Clear();
                    fullname_edit_textbox.Focus();
                }
                else
                {
                    MessageBox.Show("Passwords does not match", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password_edit_textbox.Clear();
                    conpassword_edit_textbox.Clear();
                    password_edit_textbox.Focus();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
            con.Close();
        }

        private void back_edit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Mainmenu mainmenu = new Mainmenu();
            mainmenu.Show();
        }
    }
}

