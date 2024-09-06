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
using Charting = System.Windows.Forms.DataVisualization.Charting;

namespace AppTracNghiem
{
    public partial class QuanLyThongKe : Form
    {
        public QuanLyThongKe()
        {
            InitializeComponent();
        }
        private void LoadThongKe()
        {
            // Kết nối tới cơ sở dữ liệu
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == ConnectionState.Open)
            {
                // Truy vấn để lấy số lượng điểm từ 1 đến 10, làm tròn điểm đến số nguyên gần nhất
                string query = @"
            SELECT CAST(ROUND(Diem, 0) AS INT) AS RoundedScore, COUNT(*) AS Count
            FROM KetQua
            WHERE Diem BETWEEN 1 AND 10
            GROUP BY CAST(ROUND(Diem, 0) AS INT)
            ORDER BY RoundedScore";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                chart1.Series.Clear();
                var series = chart1.Series.Add("Điểm Số");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                while (reader.Read())
                {
                    int roundedScore = reader.GetInt32(0);
                    int count = reader.GetInt32(1);

                    series.Points.AddXY($"Điểm {roundedScore}", count);
                }

                reader.Close();
                dbConn.CloseConnection(conn);
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }
        private void QuanLyThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
