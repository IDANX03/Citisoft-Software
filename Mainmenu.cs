using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }
        private void LinkClickEventHandler(object sender, EventArgs e)
        {
           
        }

        void FillVendorGridView()
        {
            DataGridViewLinkColumn websiteLinkColumn = new DataGridViewLinkColumn();
            websiteLinkColumn.HeaderText = "Website";
            websiteLinkColumn.DataPropertyName = "website_link";
            websiteLinkColumn.LinkBehavior = LinkBehavior.SystemDefault;

            List<Vendors> vendorList = new List<Vendors>();
            Vendors vendor = new Vendors();



            vendorList = vendor.GetVendors();

            dataGridView1.DataSource = vendorList;
            dataGridView1.Columns.Add(websiteLinkColumn);
        }

        void FillProductGridView()
        {
            List<Product> ProductList = new List<Product>();
            Product product = new Product();



            ProductList = product.GetVendors();

            dataGridView1.DataSource = ProductList;
        }

        void SearchProductGridView()
        {
            List<Product> ProductList = new List<Product>();
            Product product = new Product();

            ProductList = product.GetVendors();

            string searchText = searchBox.Text;

            List<Product> filteredList = ProductList
                .Where(product => product.ProductName.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            

            dataGridView1.DataSource = filteredList;
        }

        private void view_vendor_btn_Click(object sender, EventArgs e)
        {

            FillVendorGridView();
        }

        private void view_product_btn_Click(object sender, EventArgs e)
        {
            FillProductGridView();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SearchProductGridView();
        }
        
    }
}
