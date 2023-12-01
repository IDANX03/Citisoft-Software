using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
