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
    public partial class FormChonCaThi : Form
    {
        private int maNguoiDung;
        private string vaiTro;
        private string userEmail;

        public FormChonCaThi(string email, int maNguoiDung, string vaiTro)
        {
            InitializeComponent();
            this.userEmail = email;
            this.maNguoiDung = maNguoiDung;
            this.vaiTro = vaiTro;
            LoadDanhSachCaThi();
        }

        private void LoadDanhSachCaThi()
        {
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == ConnectionState.Open)
            {
                string query = "SELECT MaCaThi, TenCaThi, ThoiGianBatDau, ThoiGianKetThuc FROM CaThi WHERE DaXoa = 0 AND ThoiGianKetThuc >= GETDATE()";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dbConn.CloseConnection(conn);
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) // Kiểm tra nếu không có hàng nào được chọn
            {
                MessageBox.Show("Vui lòng chọn một ca thi.");
                return;
            }

            // Kiểm tra nếu ô giá trị là DBNull trước khi chuyển đổi
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value == DBNull.Value ||
                dataGridView1.Rows[e.RowIndex].Cells[2].Value == DBNull.Value ||
                dataGridView1.Rows[e.RowIndex].Cells[3].Value == DBNull.Value)
            {
                MessageBox.Show("Vui lòng chọn ca thi.");
                return;
            }

            // Lấy thông tin từ DataGridView khi có hàng được chọn
            int maCaThi = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            DateTime thoiGianBatDau = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            DateTime thoiGianKetThuc = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

            // Kiểm tra thời gian bắt đầu và kết thúc của ca thi
            if (DateTime.Now < thoiGianBatDau)
            {
                MessageBox.Show("Ca thi chưa bắt đầu.");
                return;
            }
            if (DateTime.Now > thoiGianKetThuc)
            {
                MessageBox.Show("Ca thi đã kết thúc.");
                return;
            }

            // Ẩn form hiện tại và mở form bài thi
            this.Hide();
            var formBaiThi = new BaiThi(userEmail, maNguoiDung, maCaThi);
            formBaiThi.Show();
        }
        private void FormChonCaThi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
