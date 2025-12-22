namespace QuanLySinhVien
{
    partial class FormSinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.labelLop = new System.Windows.Forms.Label();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.textBoxTenSinhVien = new System.Windows.Forms.TextBox();
            this.labelTenSinhVien = new System.Windows.Forms.Label();
            this.textBoxMaSinhVien = new System.Windows.Forms.TextBox();
            this.labelMaSinhVien = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxThongTin.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(308, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.buttonTimKiem);
            this.panelSearch.Controls.Add(this.textBoxTimKiem);
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 60);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelSearch.Size = new System.Drawing.Size(1200, 60);
            this.panelSearch.TabIndex = 1;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiem.ForeColor = System.Drawing.Color.White;
            this.buttonTimKiem.Location = new System.Drawing.Point(1075, 10);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(110, 40);
            this.buttonTimKiem.TabIndex = 2;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxTimKiem.Location = new System.Drawing.Point(820, 15);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(245, 32);
            this.textBoxTimKiem.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelSearch.Location = new System.Drawing.Point(705, 18);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(101, 23);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Mã/Tên SV:";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panelLeft.Controls.Add(this.groupBoxThongTin);
            this.panelLeft.Controls.Add(this.panelButtons);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 120);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(15);
            this.panelLeft.Size = new System.Drawing.Size(420, 580);
            this.panelLeft.TabIndex = 2;
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.BackColor = System.Drawing.Color.White;
            this.groupBoxThongTin.Controls.Add(this.comboBoxLop);
            this.groupBoxThongTin.Controls.Add(this.labelLop);
            this.groupBoxThongTin.Controls.Add(this.dateTimePickerNgaySinh);
            this.groupBoxThongTin.Controls.Add(this.labelNgaySinh);
            this.groupBoxThongTin.Controls.Add(this.textBoxTenSinhVien);
            this.groupBoxThongTin.Controls.Add(this.labelTenSinhVien);
            this.groupBoxThongTin.Controls.Add(this.textBoxMaSinhVien);
            this.groupBoxThongTin.Controls.Add(this.labelMaSinhVien);
            this.groupBoxThongTin.Controls.Add(this.textBoxID);
            this.groupBoxThongTin.Controls.Add(this.labelID);
            this.groupBoxThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxThongTin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxThongTin.Location = new System.Drawing.Point(15, 15);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxThongTin.Size = new System.Drawing.Size(390, 450);
            this.groupBoxThongTin.TabIndex = 0;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông tin sinh viên";
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Location = new System.Drawing.Point(18, 260);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(350, 31);
            this.comboBoxLop.TabIndex = 9;
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelLop.Location = new System.Drawing.Point(18, 230);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(46, 23);
            this.labelLop.TabIndex = 8;
            this.labelLop.Text = "Lớp:";
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(18, 190);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(350, 30);
            this.dateTimePickerNgaySinh.TabIndex = 7;
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNgaySinh.Location = new System.Drawing.Point(18, 160);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(94, 23);
            this.labelNgaySinh.TabIndex = 6;
            this.labelNgaySinh.Text = "Ngày sinh:";
            // 
            // textBoxTenSinhVien
            // 
            this.textBoxTenSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTenSinhVien.Location = new System.Drawing.Point(18, 120);
            this.textBoxTenSinhVien.Name = "textBoxTenSinhVien";
            this.textBoxTenSinhVien.Size = new System.Drawing.Size(350, 30);
            this.textBoxTenSinhVien.TabIndex = 5;
            // 
            // labelTenSinhVien
            // 
            this.labelTenSinhVien.AutoSize = true;
            this.labelTenSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTenSinhVien.Location = new System.Drawing.Point(18, 90);
            this.labelTenSinhVien.Name = "labelTenSinhVien";
            this.labelTenSinhVien.Size = new System.Drawing.Size(117, 23);
            this.labelTenSinhVien.TabIndex = 4;
            this.labelTenSinhVien.Text = "Tên sinh viên:";
            // 
            // textBoxMaSinhVien
            // 
            this.textBoxMaSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxMaSinhVien.Location = new System.Drawing.Point(18, 50);
            this.textBoxMaSinhVien.Name = "textBoxMaSinhVien";
            this.textBoxMaSinhVien.Size = new System.Drawing.Size(200, 30);
            this.textBoxMaSinhVien.TabIndex = 3;
            // 
            // labelMaSinhVien
            // 
            this.labelMaSinhVien.AutoSize = true;
            this.labelMaSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelMaSinhVien.Location = new System.Drawing.Point(18, 20);
            this.labelMaSinhVien.Name = "labelMaSinhVien";
            this.labelMaSinhVien.Size = new System.Drawing.Size(115, 23);
            this.labelMaSinhVien.TabIndex = 2;
            this.labelMaSinhVien.Text = "Mã sinh viên:";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxID.Location = new System.Drawing.Point(268, 50);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 30);
            this.textBoxID.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelID.Location = new System.Drawing.Point(268, 20);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(33, 23);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonLamMoi);
            this.panelButtons.Controls.Add(this.buttonXoa);
            this.panelButtons.Controls.Add(this.buttonSua);
            this.panelButtons.Controls.Add(this.buttonThem);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(15, 465);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelButtons.Size = new System.Drawing.Size(390, 100);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.buttonLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLamMoi.ForeColor = System.Drawing.Color.White;
            this.buttonLamMoi.Location = new System.Drawing.Point(15, 55);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(360, 40);
            this.buttonLamMoi.TabIndex = 3;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = false;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(255, 15);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(110, 40);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(135, 15);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(110, 40);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Location = new System.Drawing.Point(15, 15);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(110, 40);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.dataGridViewSinhVien);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(420, 120);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(15);
            this.panelRight.Size = new System.Drawing.Size(780, 580);
            this.panelRight.TabIndex = 3;
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.AllowUserToAddRows = false;
            this.dataGridViewSinhVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.dataGridViewSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSinhVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSinhVien.ColumnHeadersHeight = 40;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSinhVien.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSinhVien.EnableHeadersVisualStyles = false;
            this.dataGridViewSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewSinhVien.MultiSelect = false;
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.ReadOnly = true;
            this.dataGridViewSinhVien.RowHeadersVisible = false;
            this.dataGridViewSinhVien.RowHeadersWidth = 51;
            this.dataGridViewSinhVien.RowTemplate.Height = 35;
            this.dataGridViewSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(750, 550);
            this.dataGridViewSinhVien.TabIndex = 0;
            this.dataGridViewSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSinhVien_CellClick);
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.TextBox textBoxTenSinhVien;
        private System.Windows.Forms.Label labelTenSinhVien;
        private System.Windows.Forms.TextBox textBoxMaSinhVien;
        private System.Windows.Forms.Label labelMaSinhVien;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
    }
}