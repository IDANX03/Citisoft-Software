using Accessibility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft_Software
{
    class DBConnection
    {
        private static DBConnection _instance;

        private string userDataConnection;
        
        private DBConnection()
        {
            userDataConnection = Properties.Settings.Default.userdataconnection;
        }


        public static DBConnection getInstanceOfDBConnection()
        {
            if (_instance==null)
                _instance = new DBConnection();
            return _instance;
        }
        public DataSet getDataSet( string sqlQuery)
        {
            DataSet dataset = new DataSet();

            using (SqlConnection ConnToDB = new SqlConnection(userDataConnection))
            {
                ConnToDB.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery,ConnToDB);
                adapter.Fill(dataset);

            }

                return dataset;
        }
    }
}
