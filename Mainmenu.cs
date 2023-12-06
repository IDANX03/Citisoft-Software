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
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }
        




        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                login_form login_Form = new login_form();
                login_Form.Show();
            }
            else
            {
                this.Show();



            }

        }

        private void edit_profilebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
           
        }
    }
}
