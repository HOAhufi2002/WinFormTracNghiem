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
    public partial class QuanLyKetQuaThi : Form
    {
        public QuanLyKetQuaThi()
        {
            InitializeComponent();
        }
        private void LoadKetQuaThi()
        {
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == ConnectionState.Open)
            {
                string query = "SELECT k.MaKetQua, n.HoTen, b.ThoiGianBatDau, b.ThoiGianKetThuc, k.SoCauDung, k.SoCauSai, k.Diem " +
                               "FROM KetQua k " +
                               "JOIN BaiThi b ON k.MaBaiThi = b.MaBaiThi " +
                               "JOIN NguoiDung n ON b.MaNguoiDung = n.MaNguoiDung " +
                               "WHERE b.DaXoa = 0";

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
        private void QuanLyKetQuaThi_Load(object sender, EventArgs e)
        {
            LoadKetQuaThi();
        }
    }
}
