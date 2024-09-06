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
    public partial class CauHoi : Form
    {
        public CauHoi()
        {
            InitializeComponent();
        }
        private void LoadCauHoi()
        {
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == ConnectionState.Open)
            {
                string query = "SELECT * FROM CauHoi WHERE DaXoa = 0";  // Lấy tất cả các câu hỏi chưa bị xóa
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                DGVhienthicauhoi.DataSource = dt;

                dbConn.CloseConnection(conn);
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }

        private void DGVhienthicauhoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin câu hỏi.");
                return;
            }

            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == ConnectionState.Open)
            {
                string query = "INSERT INTO CauHoi (NoiDung, LuaChonA, LuaChonB, LuaChonC, LuaChonD, DapAnDung, DaXoa) " +
                               "VALUES (@NoiDung, @LuaChonA, @LuaChonB, @LuaChonC, @LuaChonD, @DapAnDung, 0)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NoiDung", textBox1.Text);
                cmd.Parameters.AddWithValue("@LuaChonA", textBox2.Text);
                cmd.Parameters.AddWithValue("@LuaChonB", textBox3.Text);
                cmd.Parameters.AddWithValue("@LuaChonC", textBox4.Text);
                cmd.Parameters.AddWithValue("@LuaChonD", textBox5.Text);
                cmd.Parameters.AddWithValue("@DapAnDung", textBox6.Text);

                cmd.ExecuteNonQuery();

                dbConn.CloseConnection(conn);

                MessageBox.Show("Đã thêm câu hỏi thành công.");

                LoadCauHoi();
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (DGVhienthicauhoi.SelectedRows.Count > 0)
            {
                int maCauHoi = Convert.ToInt32(DGVhienthicauhoi.SelectedRows[0].Cells["MaCauHoi"].Value);

                DatabaseConnection dbConn = new DatabaseConnection();
                SqlConnection conn = dbConn.GetConnection();

                if (conn.State == ConnectionState.Open)
                {
                    string query = "UPDATE CauHoi SET DaXoa = 1 WHERE MaCauHoi = @MaCauHoi";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaCauHoi", maCauHoi);

                    cmd.ExecuteNonQuery();

                    dbConn.CloseConnection(conn);

                    MessageBox.Show("Đã xóa câu hỏi thành công.");

                    // Tải lại dữ liệu câu hỏi
                    LoadCauHoi();
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn câu hỏi để xóa.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (DGVhienthicauhoi.SelectedRows.Count > 0)
            {
                int maCauHoi = Convert.ToInt32(DGVhienthicauhoi.SelectedRows[0].Cells["MaCauHoi"].Value);

                // Tạo kết nối cơ sở dữ liệu
                DatabaseConnection dbConn = new DatabaseConnection();
                SqlConnection conn = dbConn.GetConnection();

                if (conn.State == ConnectionState.Open)
                {
                    // Cập nhật câu hỏi
                    string query = "UPDATE CauHoi SET NoiDung = @NoiDung, LuaChonA = @LuaChonA, LuaChonB = @LuaChonB, " +
                                   "LuaChonC = @LuaChonC, LuaChonD = @LuaChonD, DapAnDung = @DapAnDung WHERE MaCauHoi = @MaCauHoi";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NoiDung", textBox1.Text);
                    cmd.Parameters.AddWithValue("@LuaChonA", textBox2.Text);
                    cmd.Parameters.AddWithValue("@LuaChonB", textBox3.Text);
                    cmd.Parameters.AddWithValue("@LuaChonC", textBox4.Text);
                    cmd.Parameters.AddWithValue("@LuaChonD", textBox5.Text);
                    cmd.Parameters.AddWithValue("@DapAnDung", textBox6.Text);
                    cmd.Parameters.AddWithValue("@MaCauHoi", maCauHoi);

                    cmd.ExecuteNonQuery();

                    dbConn.CloseConnection(conn);

                    MessageBox.Show("Đã cập nhật câu hỏi thành công.");

                    // Tải lại dữ liệu câu hỏi
                    LoadCauHoi();
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn câu hỏi để cập nhật.");
            }
        }

        private void CauHoi_Load(object sender, EventArgs e)
        {
            LoadCauHoi();

            textBox1.Text = "Nhập nội dung...";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Đáp án A";
            textBox2.ForeColor = Color.Gray;  
            textBox3.Text = "Đáp án B";
            textBox3.ForeColor = Color.Gray;  
            textBox4.Text = "Đáp án C";
            textBox4.ForeColor = Color.Gray; 
            textBox5.Text = "Đáp án D";
            textBox5.ForeColor = Color.Gray;  
            textBox6.Text = "Đáp án đúng";
            textBox6.ForeColor = Color.Gray;  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVhienthicauhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVhienthicauhoi.Rows[e.RowIndex];

                textBox1.Text = row.Cells["NoiDung"].Value.ToString();
                textBox2.Text = row.Cells["LuaChonA"].Value.ToString();
                textBox3.Text = row.Cells["LuaChonB"].Value.ToString();
                textBox4.Text = row.Cells["LuaChonC"].Value.ToString();
                textBox5.Text = row.Cells["LuaChonD"].Value.ToString();
                textBox6.Text = row.Cells["DapAnDung"].Value.ToString();
            }
        }
    }
}
