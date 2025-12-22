using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormSinhVien : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=.;Initial Catalog=QuanLyDiem;Integrated Security=True"
        );

        public FormSinhVien()
        {
            InitializeComponent();
            LoadLop();
            LoadSinhVien();
        }

        void LoadSinhVien()
        {
            string sql = @"SELECT sv.ID, sv.MaSinhVien, sv.TenSinhVien, sv.NgaySinh, lh.TenLop
                           FROM SinhVien sv
                           JOIN LopHoc lh ON sv.ID_Lop = lh.ID";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewSinhVien.DataSource = dt;
        }

        void LoadLop()
        {
            string sql = "SELECT ID, TenLop FROM LopHoc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxLop.DataSource = dt;
            comboBoxLop.DisplayMember = "TenLop";
            comboBoxLop.ValueMember = "ID";
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO SinhVien(MaSinhVien, TenSinhVien, NgaySinh, ID_Lop)
                           VALUES (@MaSV, @TenSV, @NgaySinh, @IDLop)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaSV", textBoxMaSinhVien.Text);
            cmd.Parameters.AddWithValue("@TenSV", textBoxTenSinhVien.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dateTimePickerNgaySinh.Value);
            cmd.Parameters.AddWithValue("@IDLop", comboBoxLop.SelectedValue);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadSinhVien();
            MessageBox.Show("Thêm sinh viên thành công!");
        }


        private void buttonSua_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE SinhVien 
                           SET MaSinhVien=@MaSV, TenSinhVien=@TenSV,
                               NgaySinh=@NgaySinh, ID_Lop=@IDLop
                           WHERE ID=@ID";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
            cmd.Parameters.AddWithValue("@MaSV", textBoxMaSinhVien.Text);
            cmd.Parameters.AddWithValue("@TenSV", textBoxTenSinhVien.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dateTimePickerNgaySinh.Value);
            cmd.Parameters.AddWithValue("@IDLop", comboBoxLop.SelectedValue);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadSinhVien();
            MessageBox.Show("Sửa sinh viên thành công!");
        }


        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM SinhVien WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", textBoxID.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadSinhVien();
            }
        }


        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxMaSinhVien.Clear();
            textBoxTenSinhVien.Clear();
            textBoxTimKiem.Clear();
            dateTimePickerNgaySinh.Value = DateTime.Now;
            comboBoxLop.SelectedIndex = 0;
        }


        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT sv.ID, sv.MaSinhVien, sv.TenSinhVien, sv.NgaySinh, lh.TenLop
                           FROM SinhVien sv
                           JOIN LopHoc lh ON sv.ID_Lop = lh.ID
                           WHERE sv.TenSinhVien LIKE @Ten";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue(
                "@Ten", "%" + textBoxTimKiem.Text + "%"
            );

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSinhVien.DataSource = dt;
        }



        private void dataGridViewSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSinhVien.Rows[e.RowIndex];

                textBoxID.Text = row.Cells["ID"].Value.ToString();
                textBoxMaSinhVien.Text = row.Cells["MaSinhVien"].Value.ToString();
                textBoxTenSinhVien.Text = row.Cells["TenSinhVien"].Value.ToString();
                dateTimePickerNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                comboBoxLop.Text = row.Cells["TenLop"].Value.ToString();
            }
        }
    }
}
