namespace QuanLySinhVien
{
    partial class FormMonHoc
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

            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.comboBoxHinhThuc = new System.Windows.Forms.ComboBox();
            this.labelHinhThuc = new System.Windows.Forms.Label();
            this.numericUpDownSoGio = new System.Windows.Forms.NumericUpDown();
            this.labelSoGio = new System.Windows.Forms.Label();
            this.textBoxTenMonHoc = new System.Windows.Forms.TextBox();
            this.labelTenMonHoc = new System.Windows.Forms.Label();
            this.textBoxMaMonHoc = new System.Windows.Forms.TextBox();
            this.labelMaMonHoc = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewMonHoc = new System.Windows.Forms.DataGridView();

            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoGio)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
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
            this.labelTitle.Size = new System.Drawing.Size(292, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ MÔN HỌC";

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
            this.labelSearch.Location = new System.Drawing.Point(730, 18);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(84, 23);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Mã/Tên MH:";

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
            this.groupBoxThongTin.Controls.Add(this.comboBoxHinhThuc);
            this.groupBoxThongTin.Controls.Add(this.labelHinhThuc);
            this.groupBoxThongTin.Controls.Add(this.numericUpDownSoGio);
            this.groupBoxThongTin.Controls.Add(this.labelSoGio);
            this.groupBoxThongTin.Controls.Add(this.textBoxTenMonHoc);
            this.groupBoxThongTin.Controls.Add(this.labelTenMonHoc);
            this.groupBoxThongTin.Controls.Add(this.textBoxMaMonHoc);
            this.groupBoxThongTin.Controls.Add(this.labelMaMonHoc);
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
            this.groupBoxThongTin.Text = "Thông tin môn học";

            // 
            // comboBoxHinhThuc
            // 
            this.comboBoxHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHinhThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxHinhThuc.FormattingEnabled = true;
            this.comboBoxHinhThuc.Location = new System.Drawing.Point(18, 330);
            this.comboBoxHinhThuc.Name = "comboBoxHinhThuc";
            this.comboBoxHinhThuc.Size = new System.Drawing.Size(350, 31);
            this.comboBoxHinhThuc.TabIndex = 9;

            // 
            // labelHinhThuc
            // 
            this.labelHinhThuc.AutoSize = true;
            this.labelHinhThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelHinhThuc.Location = new System.Drawing.Point(18, 300);
            this.labelHinhThuc.Name = "labelHinhThuc";
            this.labelHinhThuc.Size = new System.Drawing.Size(107, 23);
            this.labelHinhThuc.TabIndex = 8;
            this.labelHinhThuc.Text = "Hình thức:";

            // 
            // numericUpDownSoGio
            // 
            this.numericUpDownSoGio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDownSoGio.Location = new System.Drawing.Point(18, 260);
            this.numericUpDownSoGio.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            this.numericUpDownSoGio.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            this.numericUpDownSoGio.Name = "numericUpDownSoGio";
            this.numericUpDownSoGio.Size = new System.Drawing.Size(350, 30);
            this.numericUpDownSoGio.TabIndex = 7;
            this.numericUpDownSoGio.Value = new decimal(new int[] { 45, 0, 0, 0 });

            // 
            // labelSoGio
            // 
            this.labelSoGio.AutoSize = true;
            this.labelSoGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelSoGio.Location = new System.Drawing.Point(18, 230);
            this.labelSoGio.Name = "labelSoGio";
            this.labelSoGio.Size = new System.Drawing.Size(77, 23);
            this.labelSoGio.TabIndex = 6;
            this.labelSoGio.Text = "Số giờ:";

            // 
            // textBoxTenMonHoc
            // 
            this.textBoxTenMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTenMonHoc.Location = new System.Drawing.Point(18, 160);
            this.textBoxTenMonHoc.Name = "textBoxTenMonHoc";
            this.textBoxTenMonHoc.Size = new System.Drawing.Size(350, 30);
            this.textBoxTenMonHoc.TabIndex = 5;

            // 
            // labelTenMonHoc
            // 
            this.labelTenMonHoc.AutoSize = true;
            this.labelTenMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTenMonHoc.Location = new System.Drawing.Point(18, 130);
            this.labelTenMonHoc.Name = "labelTenMonHoc";
            this.labelTenMonHoc.Size = new System.Drawing.Size(117, 23);
            this.labelTenMonHoc.TabIndex = 4;
            this.labelTenMonHoc.Text = "Tên môn học:";

            // 
            // textBoxMaMonHoc
            // 
            this.textBoxMaMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxMaMonHoc.Location = new System.Drawing.Point(18, 80);
            this.textBoxMaMonHoc.Name = "textBoxMaMonHoc";
            this.textBoxMaMonHoc.Size = new System.Drawing.Size(200, 30);
            this.textBoxMaMonHoc.TabIndex = 3;

            // 
            // labelMaMonHoc
            // 
            this.labelMaMonHoc.AutoSize = true;
            this.labelMaMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelMaMonHoc.Location = new System.Drawing.Point(18, 50);
            this.labelMaMonHoc.Name = "labelMaMonHoc";
            this.labelMaMonHoc.Size = new System.Drawing.Size(107, 23);
            this.labelMaMonHoc.TabIndex = 2;
            this.labelMaMonHoc.Text = "Mã môn học:";

            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxID.Location = new System.Drawing.Point(268, 80);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 30);
            this.textBoxID.TabIndex = 1;

            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelID.Location = new System.Drawing.Point(268, 50);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(32, 23);
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

            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.dataGridViewMonHoc);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(420, 120);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(15);
            this.panelRight.Size = new System.Drawing.Size(780, 580);
            this.panelRight.TabIndex = 3;

            // 
            // dataGridViewMonHoc
            // 
            this.dataGridViewMonHoc.AllowUserToAddRows = false;
            this.dataGridViewMonHoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.dataGridViewMonHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMonHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMonHoc.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMonHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMonHoc.EnableHeadersVisualStyles = false;
            this.dataGridViewMonHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewMonHoc.MultiSelect = false;
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.ReadOnly = true;
            this.dataGridViewMonHoc.RowHeadersVisible = false;
            this.dataGridViewMonHoc.RowHeadersWidth = 51;
            this.dataGridViewMonHoc.RowTemplate.Height = 35;
            this.dataGridViewMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(750, 550);
            this.dataGridViewMonHoc.TabIndex = 0;

            // 
            // FormMonHoc
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
            this.Name = "FormMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý môn học";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoGio)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxHinhThuc;
        private System.Windows.Forms.Label labelHinhThuc;
        private System.Windows.Forms.NumericUpDown numericUpDownSoGio;
        private System.Windows.Forms.Label labelSoGio;
        private System.Windows.Forms.TextBox textBoxTenMonHoc;
        private System.Windows.Forms.Label labelTenMonHoc;
        private System.Windows.Forms.TextBox textBoxMaMonHoc;
        private System.Windows.Forms.Label labelMaMonHoc;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataGridViewMonHoc;
    }
}