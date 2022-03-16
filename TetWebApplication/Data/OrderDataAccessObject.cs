using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TetWebApplication.Data
{
    public class OrderDataAccessObject
    {
        public DataTable GetOrders()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Study\TetWebApplication\TetWebApplication\TetWebApplication\App_Data\Database1.mdf;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from Request", connection);               

                SqlDataAdapter adaptor = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                adaptor.Fill(ds);

                return ds.Tables[0];
            }
        }
    }
}