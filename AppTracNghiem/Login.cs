using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTracNghiem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string email = textBox1.Text;
            string password = textBox2.Text;

            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT MaNguoiDung, VaiTro FROM NguoiDung WHERE Email=@Email AND MatKhau=@MatKhau";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MatKhau", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int maNguoiDung = reader.GetInt32(0);
                    string vaiTro = reader.GetString(1);

                    reader.Close();
                    dbConn.CloseConnection(conn);

                    this.Hide();

                    if (vaiTro == "giaovien")
                    {
                        var homeForm = new Home(maNguoiDung); 
                        homeForm.Show();
                    }
                    else if (vaiTro == "hocsinh")
                    {
                        var formChonCaThi = new FormChonCaThi(email, maNguoiDung, vaiTro);
                        formChonCaThi.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập!");
                    dbConn.CloseConnection(conn);
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }
    }
}
