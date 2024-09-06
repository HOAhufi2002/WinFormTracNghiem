using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTracNghiem
{
    public partial class Home : Form
    {

        private int maNguoiDung;  

        public Home(int maNguoiDung)
        {
            InitializeComponent();
            this.maNguoiDung = maNguoiDung;  
        }


        private void tabformcauhoi_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            CauHoi formCauHoi = new CauHoi();

            formCauHoi.TopLevel = false;
            formCauHoi.FormBorderStyle = FormBorderStyle.None;
            formCauHoi.Dock = DockStyle.Fill;

            panel2.Controls.Add(formCauHoi);
            formCauHoi.Show();
        }

        private void tabformbaithi_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            QuanLyBaiThi formCauHoi = new QuanLyBaiThi();

            formCauHoi.TopLevel = false;
            formCauHoi.FormBorderStyle = FormBorderStyle.None;
            formCauHoi.Dock = DockStyle.Fill;

            panel2.Controls.Add(formCauHoi);
            formCauHoi.Show();
        }

        private void tabformquanlyhocsinh_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            QuanLyHocSinh formCauHoi = new QuanLyHocSinh();

            formCauHoi.TopLevel = false;
            formCauHoi.FormBorderStyle = FormBorderStyle.None;
            formCauHoi.Dock = DockStyle.Fill;

            panel2.Controls.Add(formCauHoi);
            formCauHoi.Show();
        }

        private void tabformquanlyketquathi_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();

            QuanLyKetQuaThi formCauHoi = new QuanLyKetQuaThi();

            formCauHoi.TopLevel = false;
            formCauHoi.FormBorderStyle = FormBorderStyle.None;
            formCauHoi.Dock = DockStyle.Fill;

            panel2.Controls.Add(formCauHoi);
            formCauHoi.Show();
        }

        private void tabformquanlythongke_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            QuanLyThongKe formCauHoi = new QuanLyThongKe();

            formCauHoi.TopLevel = false;
            formCauHoi.FormBorderStyle = FormBorderStyle.None;
            formCauHoi.Dock = DockStyle.Fill;

            panel2.Controls.Add(formCauHoi);
            formCauHoi.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            QuanLyCaThi formCauHoi = new QuanLyCaThi(maNguoiDung);

            formCauHoi.TopLevel = false;
            formCauHoi.FormBorderStyle = FormBorderStyle.None;
            formCauHoi.Dock = DockStyle.Fill;

            panel2.Controls.Add(formCauHoi);
            formCauHoi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            DanhSachKetQuaThi formCauHoi = new DanhSachKetQuaThi();

            formCauHoi.TopLevel = false;
            formCauHoi.FormBorderStyle = FormBorderStyle.None;
            formCauHoi.Dock = DockStyle.Fill;

            panel2.Controls.Add(formCauHoi);
            formCauHoi.Show();
        }
    }
}
