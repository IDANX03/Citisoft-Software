using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualBasic.Logging;


namespace Citisoft_Software
{
    public class Product
    {
        public int product_id { get; set; }
        public int vendor_id { get; set; }
        public string ProductName { get; set; }
        public string? software_type{ get; set; }
        public string? description { get; set;}

        public List<Product> GetVendors()
        {
            List<Product> products = new List<Product>();

            string relativePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string dbPath = Path.Combine(relativePath, "userdata.mdf");
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ dbPath + ";Integrated Security=True");

            string query = "SELECT * FROM Product";

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Product product = new Product();
                product.product_id = Convert.ToInt32(reader["product_id"]);
                product.vendor_id = Convert.ToInt32(reader["vendor_id"]);
                product.ProductName = reader["product_name"].ToString();
                product.software_type = reader["software_type"].ToString();
                product.description = reader["Description"].ToString();

                products.Add(product);
            }
            return products;
        }

    }
    
}
