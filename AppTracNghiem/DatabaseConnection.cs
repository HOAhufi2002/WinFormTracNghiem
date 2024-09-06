using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTracNghiem
{
    public class DatabaseConnection
    {
        private string connectionString;

        public DatabaseConnection()
        {
            connectionString = "Server=minhhoa;Database=tracnghiem;User Id=sa;Password=123;";
        }

        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();  // Mở kết nối
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Không thể kết nối cơ sở dữ liệu: " + ex.Message);
            }
            return conn;
        }

        public void CloseConnection(SqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();  
            }
        }
    }
}
