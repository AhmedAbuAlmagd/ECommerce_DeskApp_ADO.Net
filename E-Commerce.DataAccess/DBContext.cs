using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess
{
    public class DBContext
    {

        public SqlConnection connection;
        public DBContext(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }


        // DisConnected Mode 
        public DataTable Select(string selectCommand)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        // connected Mode 
        public int ExecuteNonQuery(string command)
        {
            int affectedRows = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(command, connection);
                connection.Open();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error");
            }
            finally
            {
                connection.Close();
            }

            return affectedRows;
        }


    }
}
