using Microsoft.Reporting.WinForms;
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
    public partial class FormDiemTheoLop : Form
    {
        public FormDiemTheoLop()
        {
            InitializeComponent();
        }

        private void FormDiemTheoLop_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string tenLop = textBoxTenLop.Text.Trim();

            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng nhập tên lớp");
                return;
            }

            var adapter = new QuanLyDiemDataSetTableAdapters._BangDiemTheoLopTableAdapter();

            var table = adapter.GetData(tenLop);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("BangDiemTheoLop",(System.Data.DataTable) table)
            );

            reportViewer1.RefreshReport();
        }
    }
}
