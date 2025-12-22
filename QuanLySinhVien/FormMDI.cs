using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void menuSinhVien_Click(object sender, EventArgs e)
        {
            FormSinhVien sv = new FormSinhVien();
            sv.MdiParent = this;
            sv.WindowState = FormWindowState.Maximized;
            sv.Show();
        }

        private void menuDanhSachSinhVien_Click(object sender, EventArgs e)
        {
            FormReportTiLeSV sv = new FormReportTiLeSV();
            sv.MdiParent = this;
            sv.WindowState = FormWindowState.Maximized;
            sv.Show();
            sv.BringToFront();
        }

        private void menuDanhSachDiem_Click(object sender, EventArgs e)
        {
            FormDiemTheoLop diem = new FormDiemTheoLop();
            diem.MdiParent = this;
            diem.WindowState = FormWindowState.Maximized;
            diem.Show();
            diem.BringToFront();
        }

        private void menuThongKe_Click(object sender, EventArgs e)
        {
            FormReport thongke = new FormReport();
            thongke.MdiParent = this;
            thongke.WindowState = FormWindowState.Maximized;
            thongke.Show();
            thongke.BringToFront();
        }
    }
}
