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
    public partial class Deleteuser : Form
    {
        public Deleteuser()
        {
            InitializeComponent();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\iamid\Documents\Idan documents\Software engineering\Visual studios code\Citisoft Software\userdata.mdf"";Integrated Security=True");

            try
            {
                if (delete_id_txt.Text == " ")
                {
                    MessageBox.Show("Please enter valid details", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    con.Open();
                    string del = "DELETE FROM user_details WHERE id = '"+delete_id_txt.Text+"' ";

                    SqlCommand cmd = new SqlCommand(del, con);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Account Deleted Successfully", "Delete Completed", MessageBoxButtons.OK);
                    this.Close();
                    Adminpage adminpage = new Adminpage();
                    adminpage.Show();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
            con.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Adminpage adminpage = new Adminpage();
            adminpage.Show();
        }
    } 

}
    

