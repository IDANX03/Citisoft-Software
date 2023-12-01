using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Citisoft_Software
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\iamid\Documents\Idan documents\Software engineering\Visual studios code\Citisoft Software\userdata.mdf"";Integrated Security=True");
        private void btn_login_Click(object sender, EventArgs e)
        {
            string email , password;

            email = email_logintextbox.Text;
            password = password_logintextbox.Text;
            try
            {
                string querry = "SELECT * FROM userdata WHERE email_address = '" + email_logintextbox.Text + "' AND password= '" + password_logintextbox.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    email = email_logintextbox.Text; 
                    password = password_logintextbox.Text;
                    Mainmenu mainform= new Mainmenu();
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email or Password incorrect","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    email_logintextbox.Clear();
                    password_logintextbox.Clear();

                    email_logintextbox.Focus();
                    
                }

            }
            catch
            {
                MessageBox.Show("Login Error");
            }
            finally { con.Close(); }
        }

        private void create_account_Click(object sender, EventArgs e)
        {
            this.Hide();
            register_form reg_form = new register_form();
            reg_form.Show();
        }

        private void show_password_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password_checkbox.Checked)
            {
                password_logintextbox.UseSystemPasswordChar = false;

            }
            else
            {
                password_logintextbox.UseSystemPasswordChar = true;
            }
        }
    }
}
