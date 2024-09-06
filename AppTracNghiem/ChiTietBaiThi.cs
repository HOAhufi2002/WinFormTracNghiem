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
    public partial class ChiTietBaiThi : Form
    {

        private int maBaiThi;

        public ChiTietBaiThi(int maBaiThi)
        {
            this.maBaiThi = maBaiThi;
            InitializeComponent();
        }

        private void ChiTietBaiThi_Load(object sender, EventArgs e)
        {
            LoadChiTietBaiThi();
        }

        private void LoadChiTietBaiThi()
        {
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == ConnectionState.Open)
            {
                string query = "SELECT c.NoiDung, c.LuaChonA, c.LuaChonB, c.LuaChonC, c.LuaChonD, ct.CauTraLoiNguoiDung, c.DapAnDung, " +
                               "CASE WHEN ct.CauTraLoiNguoiDung = c.DapAnDung THEN N'Đúng' ELSE N'Sai' END AS KetQua " +
                               "FROM CauHoiTrongBaiThi ct " +
                               "JOIN CauHoi c ON ct.MaCauHoi = c.MaCauHoi " +
                               "WHERE ct.MaBaiThi = @MaBaiThi";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBaiThi", maBaiThi);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
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
    }
}
