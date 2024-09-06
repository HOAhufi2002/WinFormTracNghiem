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
    public partial class QuanLyBaiThi : Form
    {
        public QuanLyBaiThi()
        {
            InitializeComponent();
        }

        private void dgvquanlybaithi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDanhSachBaiThi()
        {
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == ConnectionState.Open)
            {
                string query = "SELECT MaBaiThi, MaNguoiDung, ThoiGianBatDau, ThoiGianKetThuc, Diem FROM BaiThi WHERE DaXoa = 0";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                dgvquanlybaithi.DataSource = dt;

                dbConn.CloseConnection(conn);
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }
        private void QuanLyBaiThi_Load(object sender, EventArgs e)
        {
            LoadDanhSachBaiThi();

        }
    }
}
