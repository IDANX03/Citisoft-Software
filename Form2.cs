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
    }
}
