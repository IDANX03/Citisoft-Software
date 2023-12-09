using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft_Software
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Modules { get; set; }
        public string? CloudEnabled { get; set; }
        public string? DocumentAttached { get; set;}

        public List<Product> GetVendors()
        {
            List<Product> products = new List<Product>();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jishnu Chand\OneDrive\Documents\Github\Citisoft-Software\userdata.mdf"";Integrated Security=True");

            string query = "SELECT * FROM Product";

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Product product = new Product();
                product.Id = Convert.ToInt32(reader["id"]);
                product.ProductName = reader["product_name"].ToString();
                product.Modules = reader["modules"].ToString();
                product.CloudEnabled = reader["cloud_enabled"].ToString();
                product.DocumentAttached = reader["document_attached"].ToString();

                products.Add(product);
            }
            return products;
        }

    }
}
