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
    public partial class FormReportTiLeSV : Form
    {
        public FormReportTiLeSV()
        {
            InitializeComponent();
        }

        private void FormReportTiLeSV_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string tenmon = textBoxTenMon.Text.Trim();

            if (string.IsNullOrEmpty(tenmon))
            {
                MessageBox.Show("Vui lòng nhập tên mon");
                return;
            }

            var adapter = new QuanLyDiemDataSetTableAdapters.TiLeQuaMonTableAdapter();

            var table = adapter.GetData(tenmon);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("TiLeQuaMon", (System.Data.DataTable)table)
            );

            reportViewer1.RefreshReport();
        }
    }
}
