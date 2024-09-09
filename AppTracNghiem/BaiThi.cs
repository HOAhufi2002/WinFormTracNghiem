using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AppTracNghiem
{
    public partial class BaiThi : Form
    {
        private string userEmail;  
        private List<Question> dsQuestion; 
        private int cauHoiHienTai = 0; 
        private int timeLeft = 3600; 
        private DateTime thoiGianBatDau;
        private int maNguoiDung;
        private int maCaThi;
        public BaiThi(string email, int maNguoiDung, int maCaThi)
        {
            InitializeComponent();
            this.userEmail = email;
            this.maNguoiDung = maNguoiDung;
            this.maCaThi = maCaThi;
        }



        private void BaiThi_Load(object sender, EventArgs e)
        {
            lbltentaikhoan.Text = $"Tài khoản: {userEmail}";

            thoiGianBatDau = DateTime.Now;  

            LoadQuestion(); 
            timer1.Start(); 
        }

        private void LoadQuestion()
        {
            List<Question> allQuestion = new List<Question>();
            dsQuestion = new List<Question>();

            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT * FROM CauHoi WHERE DaXoa = 0"; 
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Question question = new Question
                    {
                        MaCauHoi = reader.GetInt32(0),
                        NoiDung = reader.GetString(1),
                        LuaChonA = reader.GetString(2),
                        LuaChonB = reader.GetString(3),
                        LuaChonC = reader.GetString(4),
                        LuaChonD = reader.GetString(5),
                        DapAnDung = reader.GetString(6)[0] 
                    };
                    allQuestion.Add(question);
                }

                reader.Close();
                dbConn.CloseConnection(conn);

                Random rand = new Random();
                dsQuestion = allQuestion.OrderBy(x => rand.Next()).Take(60).ToList();

                HienThiCauHoi(0);  
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }

        private void HienThiCauHoi(int soCauHoi)
        {
            var question = dsQuestion[soCauHoi];
            lblCauHoi.Text = $"Câu hỏi {soCauHoi + 1}: {question.NoiDung}";
            rbOptionA.Text = question.LuaChonA;
            rbOptionB.Text = question.LuaChonB;
            rbOptionC.Text = question.LuaChonC;
            rbOptionD.Text = question.LuaChonD;

    
            switch (question.UserAnswer)
            {
                case 'A':
                    rbOptionA.Checked = true;
                    break;
                case 'B':
                    rbOptionB.Checked = true;
                    break;
                case 'C':
                    rbOptionC.Checked = true;
                    break;
                case 'D':
                    rbOptionD.Checked = true;
                    break;
                default:
                    rbOptionA.Checked = rbOptionB.Checked = rbOptionC.Checked = rbOptionD.Checked = false;
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cauHoiHienTai < dsQuestion.Count - 1)
            {
                cauHoiHienTai++;
                HienThiCauHoi(cauHoiHienTai);
            }
            else
            {
                MessageBox.Show("Bạn đã đến câu hỏi cuối cùng.");
            }
        }
        private void LuuCauHoiTrongBaiThi(int maBaiThi)
        {
            try
            {
                DatabaseConnection dbConn = new DatabaseConnection();
                SqlConnection conn = dbConn.GetConnection();

                if (conn.State == ConnectionState.Open)
                {
                    foreach (var question in dsQuestion)
                    {
                       
                        bool dapAnDung = (question.UserAnswer == question.DapAnDung);

                        string query = "INSERT INTO CauHoiTrongBaiThi (MaBaiThi, MaCauHoi, CauTraLoiNguoiDung, DapAnDung, DaXoa) " +
                                       "VALUES (@MaBaiThi, @MaCauHoi, @CauTraLoiNguoiDung, @DapAnDung, 0)";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaBaiThi", maBaiThi);
                        cmd.Parameters.AddWithValue("@MaCauHoi", question.MaCauHoi);
                        cmd.Parameters.AddWithValue("@CauTraLoiNguoiDung", question.UserAnswer == '\0' ? DBNull.Value : (object)question.UserAnswer);  // Nếu người dùng chưa trả lời, lưu null
                        cmd.Parameters.AddWithValue("@DapAnDung", dapAnDung ? 1 : 0);  // Đánh dấu đúng/sai

                        cmd.ExecuteNonQuery();
                    }

                    dbConn.CloseConnection(conn);
                }
                else
                {
                    MessageBox.Show("Không thể kết nối cơ sở dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu câu hỏi: " + ex.Message);
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn nộp bài không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                NopBai();
            }
        }
        private int LuuKetQuaVaoCoSoDuLieu(int soCauDung, decimal diem)
        {
            int maBaiThi = 0;  // Khởi tạo giá trị mặc định
            try
            {
                DatabaseConnection dbConn = new DatabaseConnection();
                SqlConnection conn = dbConn.GetConnection();

                if (conn.State == ConnectionState.Open)
                {
                    if (thoiGianBatDau == DateTime.MinValue)
                    {
                        thoiGianBatDau = DateTime.Now;
                    }

                    string queryBaiThi = "INSERT INTO BaiThi (MaNguoiDung, ThoiGianBatDau, ThoiGianKetThuc, Diem, DaXoa) " +
                                         "OUTPUT INSERTED.MaBaiThi " +
                                         "VALUES (@MaNguoiDung, @ThoiGianBatDau, @ThoiGianKetThuc, @Diem, 0)";
                    SqlCommand cmdBaiThi = new SqlCommand(queryBaiThi, conn);
                    cmdBaiThi.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                    cmdBaiThi.Parameters.AddWithValue("@ThoiGianBatDau", thoiGianBatDau);  
                    cmdBaiThi.Parameters.AddWithValue("@ThoiGianKetThuc", DateTime.Now);
                    cmdBaiThi.Parameters.AddWithValue("@Diem", diem);

                    maBaiThi = (int)cmdBaiThi.ExecuteScalar();

                    string queryKetQua = "INSERT INTO KetQua (MaBaiThi, SoCauDung, SoCauSai, Diem, DaXoa) " +
                                         "VALUES (@MaBaiThi, @SoCauDung, @SoCauSai, @Diem, 0)";
                    SqlCommand cmdKetQua = new SqlCommand(queryKetQua, conn);
                    cmdKetQua.Parameters.AddWithValue("@MaBaiThi", maBaiThi);
                    cmdKetQua.Parameters.AddWithValue("@SoCauDung", soCauDung);
                    cmdKetQua.Parameters.AddWithValue("@SoCauSai", dsQuestion.Count - soCauDung);
                    cmdKetQua.Parameters.AddWithValue("@Diem", diem);

                    cmdKetQua.ExecuteNonQuery();

                    dbConn.CloseConnection(conn);
                }
                else
                {
                    MessageBox.Show("Không thể kết nối cơ sở dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu kết quả: " + ex.Message);
            }

            return maBaiThi;  // Trả về mã bài thi
        }

        private void NopBai()
        {
            int soCauDung = 0;
            foreach (var question in dsQuestion)
            {
                if (question.UserAnswer == question.DapAnDung)
                {
                    soCauDung++; 
                }
            }

            decimal diem = Math.Round((decimal)soCauDung / dsQuestion.Count * 10, 2);

            int maBaiThi = LuuKetQuaVaoCoSoDuLieu(soCauDung, diem);

            LuuCauHoiTrongBaiThi(maBaiThi);

            MessageBox.Show($"Kết quả: {soCauDung}/{dsQuestion.Count} câu đúng.\nĐiểm: {diem}");

            this.Close();  
        }

        private void rbOptionA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOptionA.Checked)
            {
                dsQuestion[cauHoiHienTai].UserAnswer = 'A'; 
            }
        }

        private void rbOptionB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOptionB.Checked)
            {
                dsQuestion[cauHoiHienTai].UserAnswer = 'B';
            }
        }

        private void rbOptionC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOptionC.Checked)
            {
                dsQuestion[cauHoiHienTai].UserAnswer = 'C';
            }
        }

        private void rbOptionD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOptionD.Checked)
            {
                dsQuestion[cauHoiHienTai].UserAnswer = 'D';
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblThoiGianConLai.Text = $"Thời gian còn lại: {timeLeft / 60}:{timeLeft % 60:D2}";
            }
            else
            {
                timer1.Stop();
                NopBai();  
            }
        }

        private void CauTruocDo_Click(object sender, EventArgs e)
        {
            if (cauHoiHienTai > 0)  // Kiểm tra nếu không phải là câu hỏi đầu tiên
            {
                cauHoiHienTai--;  // Giảm số thứ tự câu hỏi hiện tại
                HienThiCauHoi(cauHoiHienTai);  // Hiển thị câu hỏi trước đó
            }
            else
            {
                MessageBox.Show("Bạn đang ở câu hỏi đầu tiên.");
            }
        }
    }
}