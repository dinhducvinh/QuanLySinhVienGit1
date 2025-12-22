using System.Drawing;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    partial class FormDiem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxDiem = new System.Windows.Forms.GroupBox();
            this.numericUpDownDiem = new System.Windows.Forms.NumericUpDown();
            this.labelDiem = new System.Windows.Forms.Label();
            this.dateTimePickerNgayThi = new System.Windows.Forms.DateTimePicker();
            this.labelNgayThi = new System.Windows.Forms.Label();
            this.numericUpDownLanThi = new System.Windows.Forms.NumericUpDown();
            this.labelLanThi = new System.Windows.Forms.Label();
            this.comboBoxMonHoc = new System.Windows.Forms.ComboBox();
            this.labelMonHoc = new System.Windows.Forms.Label();
            this.comboBoxSinhVien = new System.Windows.Forms.ComboBox();
            this.labelSinhVien = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewDiem = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.groupBoxDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLanThi)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiem)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panelLeft.Controls.Add(this.groupBoxDiem);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(15);
            this.panelLeft.Size = new System.Drawing.Size(450, 700);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxDiem
            // 
            this.groupBoxDiem.BackColor = System.Drawing.Color.White;
            this.groupBoxDiem.Controls.Add(this.numericUpDownDiem);
            this.groupBoxDiem.Controls.Add(this.labelDiem);
            this.groupBoxDiem.Controls.Add(this.dateTimePickerNgayThi);
            this.groupBoxDiem.Controls.Add(this.labelNgayThi);
            this.groupBoxDiem.Controls.Add(this.numericUpDownLanThi);
            this.groupBoxDiem.Controls.Add(this.labelLanThi);
            this.groupBoxDiem.Controls.Add(this.comboBoxMonHoc);
            this.groupBoxDiem.Controls.Add(this.labelMonHoc);
            this.groupBoxDiem.Controls.Add(this.comboBoxSinhVien);
            this.groupBoxDiem.Controls.Add(this.labelSinhVien);
            this.groupBoxDiem.Controls.Add(this.panelButtons);
            this.groupBoxDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDiem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxDiem.Location = new System.Drawing.Point(15, 15);
            this.groupBoxDiem.Name = "groupBoxDiem";
            this.groupBoxDiem.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxDiem.Size = new System.Drawing.Size(420, 670);
            this.groupBoxDiem.TabIndex = 0;
            this.groupBoxDiem.TabStop = false;
            this.groupBoxDiem.Text = "THÔNG TIN ĐIỂM";
            // 
            // numericUpDownDiem
            // 
            this.numericUpDownDiem.DecimalPlaces = 2;
            this.numericUpDownDiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDownDiem.Location = new System.Drawing.Point(18, 320);
            this.numericUpDownDiem.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDiem.Name = "numericUpDownDiem";
            this.numericUpDownDiem.Size = new System.Drawing.Size(380, 30);
            this.numericUpDownDiem.TabIndex = 19;
            // 
            // labelDiem
            // 
            this.labelDiem.AutoSize = true;
            this.labelDiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelDiem.Location = new System.Drawing.Point(18, 290);
            this.labelDiem.Name = "labelDiem";
            this.labelDiem.Size = new System.Drawing.Size(58, 23);
            this.labelDiem.TabIndex = 18;
            this.labelDiem.Text = "Điểm:";
            // 
            // dateTimePickerNgayThi
            // 
            this.dateTimePickerNgayThi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayThi.Location = new System.Drawing.Point(18, 240);
            this.dateTimePickerNgayThi.Name = "dateTimePickerNgayThi";
            this.dateTimePickerNgayThi.Size = new System.Drawing.Size(380, 30);
            this.dateTimePickerNgayThi.TabIndex = 17;
            // 
            // labelNgayThi
            // 
            this.labelNgayThi.AutoSize = true;
            this.labelNgayThi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNgayThi.Location = new System.Drawing.Point(18, 210);
            this.labelNgayThi.Name = "labelNgayThi";
            this.labelNgayThi.Size = new System.Drawing.Size(84, 23);
            this.labelNgayThi.TabIndex = 16;
            this.labelNgayThi.Text = "Ngày thi:";
            // 
            // numericUpDownLanThi
            // 
            this.numericUpDownLanThi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDownLanThi.Location = new System.Drawing.Point(18, 160);
            this.numericUpDownLanThi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLanThi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLanThi.Name = "numericUpDownLanThi";
            this.numericUpDownLanThi.Size = new System.Drawing.Size(380, 30);
            this.numericUpDownLanThi.TabIndex = 15;
            this.numericUpDownLanThi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelLanThi
            // 
            this.labelLanThi.AutoSize = true;
            this.labelLanThi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelLanThi.Location = new System.Drawing.Point(18, 130);
            this.labelLanThi.Name = "labelLanThi";
            this.labelLanThi.Size = new System.Drawing.Size(70, 23);
            this.labelLanThi.TabIndex = 14;
            this.labelLanThi.Text = "Lần thi:";
            // 
            // comboBoxMonHoc
            // 
            this.comboBoxMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxMonHoc.FormattingEnabled = true;
            this.comboBoxMonHoc.Location = new System.Drawing.Point(208, 80);
            this.comboBoxMonHoc.Name = "comboBoxMonHoc";
            this.comboBoxMonHoc.Size = new System.Drawing.Size(190, 31);
            this.comboBoxMonHoc.TabIndex = 13;
            // 
            // labelMonHoc
            // 
            this.labelMonHoc.AutoSize = true;
            this.labelMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelMonHoc.Location = new System.Drawing.Point(208, 50);
            this.labelMonHoc.Name = "labelMonHoc";
            this.labelMonHoc.Size = new System.Drawing.Size(84, 23);
            this.labelMonHoc.TabIndex = 12;
            this.labelMonHoc.Text = "Môn học:";
            // 
            // comboBoxSinhVien
            // 
            this.comboBoxSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSinhVien.FormattingEnabled = true;
            this.comboBoxSinhVien.Location = new System.Drawing.Point(18, 80);
            this.comboBoxSinhVien.Name = "comboBoxSinhVien";
            this.comboBoxSinhVien.Size = new System.Drawing.Size(170, 31);
            this.comboBoxSinhVien.TabIndex = 11;
            // 
            // labelSinhVien
            // 
            this.labelSinhVien.AutoSize = true;
            this.labelSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelSinhVien.Location = new System.Drawing.Point(18, 50);
            this.labelSinhVien.Name = "labelSinhVien";
            this.labelSinhVien.Size = new System.Drawing.Size(88, 23);
            this.labelSinhVien.TabIndex = 10;
            this.labelSinhVien.Text = "Sinh viên:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonLamMoi);
            this.panelButtons.Controls.Add(this.buttonXoa);
            this.panelButtons.Controls.Add(this.buttonSua);
            this.panelButtons.Controls.Add(this.buttonThem);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(15, 555);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelButtons.Size = new System.Drawing.Size(390, 100);
            this.panelButtons.TabIndex = 13;
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.buttonLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLamMoi.ForeColor = System.Drawing.Color.White;
            this.buttonLamMoi.Location = new System.Drawing.Point(3, 55);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(380, 35);
            this.buttonLamMoi.TabIndex = 3;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = false;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(263, 15);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(120, 35);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(133, 15);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(120, 35);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Location = new System.Drawing.Point(3, 15);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(120, 35);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(450, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(750, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(393, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.dataGridViewDiem);
            this.panelRight.Controls.Add(this.panelSearch);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(450, 60);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(15);
            this.panelRight.Size = new System.Drawing.Size(750, 640);
            this.panelRight.TabIndex = 2;
            // 
            // dataGridViewDiem
            // 
            this.dataGridViewDiem.AllowUserToAddRows = false;
            this.dataGridViewDiem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.dataGridViewDiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDiem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDiem.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDiem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDiem.EnableHeadersVisualStyles = false;
            this.dataGridViewDiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewDiem.Location = new System.Drawing.Point(15, 65);
            this.dataGridViewDiem.MultiSelect = false;
            this.dataGridViewDiem.Name = "dataGridViewDiem";
            this.dataGridViewDiem.ReadOnly = true;
            this.dataGridViewDiem.RowHeadersVisible = false;
            this.dataGridViewDiem.RowHeadersWidth = 51;
            this.dataGridViewDiem.RowTemplate.Height = 30;
            this.dataGridViewDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDiem.Size = new System.Drawing.Size(720, 560);
            this.dataGridViewDiem.TabIndex = 1;
            this.dataGridViewDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDiem_CellClick);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panelSearch.Controls.Add(this.buttonTimKiem);
            this.panelSearch.Controls.Add(this.textBoxTimKiem);
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(15, 15);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(10);
            this.panelSearch.Size = new System.Drawing.Size(720, 50);
            this.panelSearch.TabIndex = 0;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiem.ForeColor = System.Drawing.Color.White;
            this.buttonTimKiem.Location = new System.Drawing.Point(610, 10);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(100, 30);
            this.buttonTimKiem.TabIndex = 2;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTimKiem.Location = new System.Drawing.Point(390, 10);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(210, 30);
            this.textBoxTimKiem.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelSearch.Location = new System.Drawing.Point(10, 13);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(306, 25);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "📊 DANH SÁCH ĐIỂM SINH VIÊN";
            // 
            // FormDiem
            // 
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLeft);
            this.Name = "FormDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm";
            this.panelLeft.ResumeLayout(false);
            this.groupBoxDiem.ResumeLayout(false);
            this.groupBoxDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLanThi)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiem)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLeft;
        private GroupBox groupBoxDiem;
        private NumericUpDown numericUpDownDiem;
        private Label labelDiem;
        private DateTimePicker dateTimePickerNgayThi;
        private Label labelNgayThi;
        private NumericUpDown numericUpDownLanThi;
        private Label labelLanThi;
        private ComboBox comboBoxMonHoc;
        private Label labelMonHoc;
        private ComboBox comboBoxSinhVien;
        private Label labelSinhVien;
        private Panel panelButtons;
        private Button buttonLamMoi;
        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonThem;
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelRight;
        private DataGridView dataGridViewDiem;
        private Panel panelSearch;
        private Button buttonTimKiem;
        private TextBox textBoxTimKiem;
        private Label labelSearch;
    }
}