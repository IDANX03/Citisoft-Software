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
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? WebsiteLink { get; set; }
        public string? SoftwareName { get; set; }



        public List<Vendors> GetVendors()
        {
            List<Vendors> vendors = new List<Vendors>();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jishnu Chand\OneDrive\Documents\Github\Citisoft-Software\userdata.mdf"";Integrated Security=True");

            string query = "SELECT * FROM Vendor";

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Vendors vendor = new Vendors();
                vendor.Id = Convert.ToInt32(reader["id"]);
                vendor.CompanyName = reader["company_name"].ToString();
                vendor.WebsiteLink = reader["website_link"].ToString();
                vendor.SoftwareName = reader["software_name"].ToString();
                
                vendors.Add(vendor);
            }
            return vendors;
        }
    }
}