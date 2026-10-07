using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace BlazorSample.DAL
{
    public static class DBUtils
    {

        private static SqlCommand GetSqlCommand(string connectionString, CommandType commandType, string commandText)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            // Connection is open and ready to use
            SqlCommand cmd = conn.CreateCommand();
            //cmd.Connection = conn;
            cmd.CommandType = commandType;
            cmd.CommandText = commandText; // Set your SQL query here
            
            return cmd;
        }

        public static DataTable GetQueryDataTable(string connectionString, string query)
        {
            
            using (SqlCommand cmd = GetSqlCommand(connectionString, CommandType.Text, query))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt); //Execute the query and fill the DataTable with the results
                    cmd.Connection.Close(); // Close the connection after filling the DataTable
                    return dt;
                }
            }
           
        }
        
        public static DataSet GetQueryDataSet(string connectionString, string query)
        {
            using (SqlCommand cmd = GetSqlCommand(connectionString, CommandType.Text, query))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds); //Execute the query and fill the DataSet with the results
                    cmd.Connection.Close(); // Close the connection after filling the DataSet
                    return ds;
                }
            }
        }
    }
}