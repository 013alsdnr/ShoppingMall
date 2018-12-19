using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ShoppingApp2
{
    class Con_database
    {
        public static string constring1 = @"Data Source = 115.92.190.185,3433;
                                          Initial Catalog = ShoppingDB;
                                          User ID = dzicube;
                                          Password = ejwhs123$";

        SqlConnection conn = new SqlConnection();
        private string sConnString = "";

        public void ConnectDB()
        {
            try
            {
                sConnString = constring1;
            }
            catch
            {
            }

            if (conn.State.ToString().Equals("Closed"))
            {
                conn.ConnectionString = sConnString;
                conn.Open();
            }
        }

        public void CloseDB()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public DataTable GetDBTable(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
