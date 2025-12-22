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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
        private void FormReport_Load(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu
            var adapter = new QuanLyDiemDataSetTableAdapters.ThongKeSinhVienTheoNganhTableAdapter();
            var table = adapter.GetData();

            // 2. Gán datasource
            reportViewer1.LocalReport.DataSources.Clear();
 reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ThongKeSinhVienTheoNganh", (System.Data.DataTable)table));

            // 3. Hiển thị report
            reportViewer1.RefreshReport();
        }

    }
}
