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
    public partial class QuanLyHocSinh : Form
    {
        public QuanLyHocSinh()
        {
            InitializeComponent();
        }

        private void dgvquanlyhocsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void LoadDanhSachHocSinh()
        {
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == ConnectionState.Open)
            {
                string query = "SELECT MaNguoiDung, HoTen, Email , matkhau FROM NguoiDung WHERE VaiTro = 'hocsinh' AND DaXoa = 0";
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
        private void QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            LoadDanhSachHocSinh();
            textBox1.Text = "Mã học sinh...";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Nhập họ tên";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Nhập email";
            textBox3.ForeColor = Color.Gray;
            textBox4.Text = "Nhập mật khẩu";
            textBox4.ForeColor = Color.Gray;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string hoTen = textBox2.Text;
            string email = textBox3.Text;
            string matKhau = textBox4.Text; 

            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();
            if (conn.State == ConnectionState.Open)
            {
                string query = "INSERT INTO NguoiDung (HoTen, Email, MatKhau, VaiTro, DaXoa) VALUES (@HoTen, @Email, @MatKhau, 'hocsinh', 0)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau); 

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm học sinh thành công.");
                    LoadDanhSachHocSinh();
                }
                else
                {
                    MessageBox.Show("Thêm học sinh không thành công.");
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
            string maNguoiDung = textBox1.Text;
            if (string.IsNullOrWhiteSpace(maNguoiDung))
            {
                MessageBox.Show("Vui lòng nhập mã học sinh cần xóa.");
                return;
            }

            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();
            if (conn.State == ConnectionState.Open)
            {
                string query = "UPDATE NguoiDung SET DaXoa = 1 WHERE MaNguoiDung = @MaNguoiDung";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Xóa học sinh thành công.");
                    LoadDanhSachHocSinh();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy học sinh để xóa.");
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
            string maNguoiDung = textBox1.Text;
            string hoTen = textBox2.Text;
            string email = textBox3.Text;
            string matKhau = textBox4.Text; 

            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(maNguoiDung))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();
            if (conn.State == ConnectionState.Open)
            {
                string query = "UPDATE NguoiDung SET HoTen = @HoTen, Email = @Email, MatKhau = @MatKhau WHERE MaNguoiDung = @MaNguoiDung";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau); // Mật khẩu đã mã hóa

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thông tin học sinh thành công.");
                    LoadDanhSachHocSinh();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công.");
                }

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

                textBox1.Text = row.Cells["MaNguoiDung"].Value.ToString(); 
                textBox2.Text = row.Cells["HoTen"].Value.ToString();       
                textBox3.Text = row.Cells["Email"].Value.ToString();
                textBox4.Text = row.Cells["matKhau"].Value.ToString();
            }
        }
    }
}
