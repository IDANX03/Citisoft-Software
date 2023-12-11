using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Citisoft_Software
{
    public partial class login_form : Form
    {
        public static login_form instance;
        public TextBox tbemail;
        public TextBox tbpassword;

        public login_form()
        {
            InitializeComponent();
            instance = this;
            tbemail = email_logintextbox;
            tbpassword = password_logintextbox;


        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\iamid\Documents\Idan documents\Software engineering\Visual studios code\Citisoft Software\userdata.mdf"";Integrated Security=True");



        private void btn_login_Click(object sender, EventArgs e)
        {

            con.Open();
            try
            {
                // Assigning email_logintextbox.Text and password_logintextbox.Text to  variables email and password
                String email, password;
                email = email_logintextbox.Text;
                password = password_logintextbox.Text;
                //query for searching through the table if the given email and password exist.
                String query = "SELECT email_address,password FROM user_details WHERE email_address = '" + email + "' AND password = '" + password + "' ";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Mainmenu mainmenu = new Mainmenu();
                    mainmenu.Show();
                    this.Hide();
                }
                //Creating a admin email and password
                else if (email_logintextbox.Text == "admin@gmail.com" && password_logintextbox.Text == "Admin2023")
                {
                    this.Hide();
                    Adminpage adminpage = new Adminpage();
                    adminpage.Show();
                }
                //display error if details are empty
                else if (email_logintextbox.Text == "" || password_logintextbox.Text == "")
                {

                    label5.Visible = true;
                    label7.Visible = true;

                }
                else
                {
                    //If the details do not match
                    MessageBox.Show("Login details do not match", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
