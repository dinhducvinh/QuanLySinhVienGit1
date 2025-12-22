using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormDiem : Form
    {
        SqlConnection conn = new SqlConnection(
           @"Data Source=.;Initial Catalog=QuanLyDiem;Integrated Security=True"
        );

        public FormDiem()
        {
            InitializeComponent();
            LoadSinhVien();
            LoadMonHoc();
            LoadDiem();
        }

        // ================= LOAD =================

        void LoadSinhVien()
        {
            string sql = "SELECT ID, TenSinhVien FROM SinhVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxSinhVien.DataSource = dt;
            comboBoxSinhVien.DisplayMember = "TenSinhVien";
            comboBoxSinhVien.ValueMember = "ID";
        }

        void LoadMonHoc()
        {
            string sql = "SELECT ID, TenMonHoc FROM MonHoc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxMonHoc.DataSource = dt;
            comboBoxMonHoc.DisplayMember = "TenMonHoc";
            comboBoxMonHoc.ValueMember = "ID";
        }

        void LoadDiem()
        {
            string sql = @"SELECT sv.TenSinhVien, mh.TenMonHoc,
                                  d.LanThi, d.NgayThi, d.Diem
                           FROM Diem d
                           JOIN SinhVien sv ON d.ID_SinhVien = sv.ID
                           JOIN MonHoc mh ON d.ID_MonHoc = mh.ID";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewDiem.DataSource = dt;
        }

        // ================= THÊM =================

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO Diem
                          (ID_SinhVien, ID_MonHoc, LanThi, NgayThi, Diem)
                          VALUES (@SV, @MH, @LanThi, @NgayThi, @Diem)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@SV", comboBoxSinhVien.SelectedValue);
            cmd.Parameters.AddWithValue("@MH", comboBoxMonHoc.SelectedValue);
            cmd.Parameters.AddWithValue("@LanThi", numericUpDownLanThi.Value);
            cmd.Parameters.AddWithValue("@NgayThi", dateTimePickerNgayThi.Value);
            cmd.Parameters.AddWithValue("@Diem", numericUpDownDiem.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadDiem();
            MessageBox.Show("Thêm điểm thành công!");
        }

        // ================= SỬA =================
        // Sửa theo: Sinh viên + Môn học + Lần thi

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE Diem 
                           SET NgayThi=@NgayThi, Diem=@Diem
                           WHERE ID_SinhVien=@SV 
                             AND ID_MonHoc=@MH 
                             AND LanThi=@LanThi";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@SV", comboBoxSinhVien.SelectedValue);
            cmd.Parameters.AddWithValue("@MH", comboBoxMonHoc.SelectedValue);
            cmd.Parameters.AddWithValue("@LanThi", numericUpDownLanThi.Value);
            cmd.Parameters.AddWithValue("@NgayThi", dateTimePickerNgayThi.Value);
            cmd.Parameters.AddWithValue("@Diem", numericUpDownDiem.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadDiem();
            MessageBox.Show("Sửa điểm thành công!");
        }

        // ================= XÓA =================

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = @"DELETE FROM Diem
                               WHERE ID_SinhVien=@SV 
                                 AND ID_MonHoc=@MH 
                                 AND LanThi=@LanThi";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SV", comboBoxSinhVien.SelectedValue);
                cmd.Parameters.AddWithValue("@MH", comboBoxMonHoc.SelectedValue);
                cmd.Parameters.AddWithValue("@LanThi", numericUpDownLanThi.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadDiem();
            }
        }

        // ================= LÀM MỚI =================

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            numericUpDownLanThi.Value = 1;
            numericUpDownDiem.Value = 0;
            dateTimePickerNgayThi.Value = DateTime.Now;
            textBoxTimKiem.Clear();
            comboBoxSinhVien.SelectedIndex = 0;
            comboBoxMonHoc.SelectedIndex = 0;
        }

        // ================= TÌM KIẾM =================
        // Tìm theo tên sinh viên

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT sv.TenSinhVien, mh.TenMonHoc,
                                  d.LanThi, d.NgayThi, d.Diem
                           FROM Diem d
                           JOIN SinhVien sv ON d.ID_SinhVien = sv.ID
                           JOIN MonHoc mh ON d.ID_MonHoc = mh.ID
                           WHERE sv.TenSinhVien LIKE @Ten";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue(
                "@Ten", "%" + textBoxTimKiem.Text + "%"
            );

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDiem.DataSource = dt;
        }

        // ================= CLICK GRID =================

        private void dataGridViewDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDiem.Rows[e.RowIndex];

                comboBoxSinhVien.Text = row.Cells["TenSinhVien"].Value.ToString();
                comboBoxMonHoc.Text = row.Cells["TenMonHoc"].Value.ToString();
                numericUpDownLanThi.Value = Convert.ToDecimal(row.Cells["LanThi"].Value);
                dateTimePickerNgayThi.Value = Convert.ToDateTime(row.Cells["NgayThi"].Value);
                numericUpDownDiem.Value = Convert.ToDecimal(row.Cells["Diem"].Value);
            }
        }
    }
}
