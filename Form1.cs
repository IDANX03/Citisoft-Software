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

        private void btn_login_Click(object sender, EventArgs e)
        {
            DBConnection dBConn = DBConnection.getInstanceOfDBConnection();
            DataSet dsuserdata = dBConn.getDataSet("SELECT * FROM userdata");
            if (email_logintextbox.Text == "" && password_logintextbox.Text == "")
            {

            }
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
