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
    public partial class DanhSachKetQuaThi : Form
    {
        public DanhSachKetQuaThi()
        {
            InitializeComponent();
        }

        private void DanhSachKetQuaThi_Load(object sender, EventArgs e)
        {
            LoadDanhSachKetQua();

        }
        private void LoadDanhSachKetQua()
        {
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == ConnectionState.Open)
            {
                string query = "SELECT k.MaKetQua, k.MaBaiThi, n.HoTen, k.Diem " +
                               "FROM KetQua k " +
                               "JOIN BaiThi b ON k.MaBaiThi = b.MaBaiThi " +
                               "JOIN NguoiDung n ON b.MaNguoiDung = n.MaNguoiDung";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                dgvquanlyhocsinh.DataSource = dt;

                dbConn.CloseConnection(conn);
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }

        private void dgvquanlyhocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvquanlyhocsinh.Rows[e.RowIndex];

                int maBaiThi = Convert.ToInt32(row.Cells["MaBaiThi"].Value);

                ChiTietBaiThi chiTietForm = new ChiTietBaiThi(maBaiThi);
                chiTietForm.Show();
            }
        }
    }
}
