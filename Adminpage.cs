using System;
using System.Collections;
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
    public partial class Adminpage : Form
    {
        public Adminpage()
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

        private void edit_userbtn_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM user_details";
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
