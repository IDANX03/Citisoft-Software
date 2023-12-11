using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft_Software
{
    public class Vendors
    {
        public int vendor_id { get; set; }
        public string? vendor_name { get; set; }
        public string? website_link { get; set; }
        public string? product_name { get; set; }
        public string? no_of_employees { get; set; }
        public string? vendor_established { get; set; }
        public string? address { get; set; }



        public List<Vendors> GetVendors()
        {
            List<Vendors> vendors = new List<Vendors>();
            string relativePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string dbPath = Path.Combine(relativePath, "userdata.mdf");
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ dbPath +"; Integrated Security=True");

            string query = "SELECT * FROM Vendor";

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Vendors vendor = new Vendors();
                vendor.vendor_id = Convert.ToInt32(reader["vendor_id"]);
                vendor.vendor_name = reader["vendor_name"].ToString();
                vendor.website_link = reader["website_link"].ToString();
                vendor.product_name = reader["product_name"].ToString();
                vendor.no_of_employees = reader["no.of_employees"].ToString();
                vendor.vendor_established = reader["vendor_established"].ToString();
                vendor.address = reader["address"].ToString();

                vendors.Add(vendor);
            }
            return vendors;
        }
    }
}