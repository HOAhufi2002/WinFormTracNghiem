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
    public partial class QuanLyCaThi : Form
    {
        private int maNguoiDung;
        public QuanLyCaThi(int maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;  
            InitializeComponent();
        }
        private void LoadDanhSachCaThi()
        {
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == ConnectionState.Open)
            {
                string query = "SELECT MaCaThi, TenCaThi, ThoiGianBatDau, ThoiGianKetThuc, TrangThai FROM CaThi WHERE DaXoa = 0";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                dgvcathi.DataSource = dt;

                dbConn.CloseConnection(conn);
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }
        private void QuanLyCaThi_Load(object sender, EventArgs e)
        {
            LoadDanhSachCaThi();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string tenCaThi = txtTenCaThi.Text;
            DateTime thoiGianBatDau = dateTimePicker1.Value;
            DateTime thoiGianKetThuc = dateTimePicker2.Value;

            if (string.IsNullOrEmpty(tenCaThi) || thoiGianBatDau >= thoiGianKetThuc)
            {
                MessageBox.Show("Vui lòng nhập tên ca thi và thời gian hợp lệ.");
                return;
            }

            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "INSERT INTO CaThi (TenCaThi, ThoiGianBatDau, ThoiGianKetThuc, TrangThai, MaNguoiDung) " +
                               "VALUES (@TenCaThi, @ThoiGianBatDau, @ThoiGianKetThuc, 1, @MaNguoiDung)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenCaThi", tenCaThi);
                cmd.Parameters.AddWithValue("@ThoiGianBatDau", thoiGianBatDau);
                cmd.Parameters.AddWithValue("@ThoiGianKetThuc", thoiGianKetThuc);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Tạo ca thi thành công.");
                    LoadDanhSachCaThi(); 
                }
                else
                {
                    MessageBox.Show("Không thể tạo ca thi.");
                }

                dbConn.CloseConnection(conn);
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            int maCaThi = Convert.ToInt32(txtmaca.Text);

            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "UPDATE CaThi SET DaXoa = 1 WHERE MaCaThi = @MaCaThi";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCaThi", maCaThi);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa ca thi thành công.");
                    LoadDanhSachCaThi();  
                }
                else
                {
                    MessageBox.Show("Không thể xóa ca thi.");
                }

                dbConn.CloseConnection(conn);
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int maCaThi = Convert.ToInt32(txtmaca.Text);
            string tenCaThi = txtTenCaThi.Text;
            DateTime thoiGianBatDau = dateTimePicker1.Value;
            DateTime thoiGianKetThuc = dateTimePicker2.Value;

            if (string.IsNullOrEmpty(tenCaThi) || thoiGianBatDau >= thoiGianKetThuc)
            {
                MessageBox.Show("Vui lòng nhập tên ca thi và thời gian hợp lệ.");
                return;
            }

            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "UPDATE CaThi SET TenCaThi = @TenCaThi, ThoiGianBatDau = @ThoiGianBatDau, ThoiGianKetThuc = @ThoiGianKetThuc " +
                               "WHERE MaCaThi = @MaCaThi";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenCaThi", tenCaThi);
                cmd.Parameters.AddWithValue("@ThoiGianBatDau", thoiGianBatDau);
                cmd.Parameters.AddWithValue("@ThoiGianKetThuc", thoiGianKetThuc);
                cmd.Parameters.AddWithValue("@MaCaThi", maCaThi);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật ca thi thành công.");
                    LoadDanhSachCaThi();  
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật ca thi.");
                }

                dbConn.CloseConnection(conn);
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }

        private void dgvcathi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcathi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvcathi.Rows[e.RowIndex];

                txtmaca.Text = row.Cells["MaCaThi"].Value.ToString();
                txtTenCaThi.Text = row.Cells["TenCaThi"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["ThoiGianBatDau"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["ThoiGianKetThuc"].Value);
            }
        }
    }
}
