using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.Xml.Linq;

namespace QuanLySinhVien
{
    partial class FormHinhThucThi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxHocKy = new System.Windows.Forms.GroupBox();
            this.comboBoxNganhHK = new System.Windows.Forms.ComboBox();
            this.labelNganhHK = new System.Windows.Forms.Label();
            this.textBoxTenHocKy = new System.Windows.Forms.TextBox();
            this.labelTenHocKy = new System.Windows.Forms.Label();
            this.textBoxIDHocKy = new System.Windows.Forms.TextBox();
            this.labelIDHocKy = new System.Windows.Forms.Label();
            this.panelButtonsHocKy = new System.Windows.Forms.Panel();
            this.buttonLamMoiHK = new System.Windows.Forms.Button();
            this.buttonXoaHK = new System.Windows.Forms.Button();
            this.buttonSuaHK = new System.Windows.Forms.Button();
            this.buttonThemHK = new System.Windows.Forms.Button();
            this.groupBoxHinhThuc = new System.Windows.Forms.GroupBox();
            this.comboBoxHocKy = new System.Windows.Forms.ComboBox();
            this.labelHocKy = new System.Windows.Forms.Label();
            this.textBoxHinhThuc = new System.Windows.Forms.TextBox();
            this.labelHinhThuc = new System.Windows.Forms.Label();
            this.textBoxIDHinhThuc = new System.Windows.Forms.TextBox();
            this.labelIDHinhThuc = new System.Windows.Forms.Label();
            this.panelButtonsHinhThuc = new System.Windows.Forms.Panel();
            this.buttonLamMoiHT = new System.Windows.Forms.Button();
            this.buttonXoaHT = new System.Windows.Forms.Button();
            this.buttonSuaHT = new System.Windows.Forms.Button();
            this.buttonThemHT = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelHocKyGrid = new System.Windows.Forms.Panel();
            this.dataGridViewHocKy = new System.Windows.Forms.DataGridView();
            this.panelSearchHocKy = new System.Windows.Forms.Panel();
            this.buttonTimKiemHK = new System.Windows.Forms.Button();
            this.textBoxTimKiemHK = new System.Windows.Forms.TextBox();
            this.labelSearchHK = new System.Windows.Forms.Label();
            this.panelHinhThucGrid = new System.Windows.Forms.Panel();
            this.dataGridViewHinhThuc = new System.Windows.Forms.DataGridView();
            this.panelSearchHinhThuc = new System.Windows.Forms.Panel();
            this.buttonTimKiemHT = new System.Windows.Forms.Button();
            this.textBoxTimKiemHT = new System.Windows.Forms.TextBox();
            this.labelSearchHT = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxHocKy.SuspendLayout();
            this.panelButtonsHocKy.SuspendLayout();
            this.groupBoxHinhThuc.SuspendLayout();
            this.panelButtonsHinhThuc.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelHocKyGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHocKy)).BeginInit();
            this.panelSearchHocKy.SuspendLayout();
            this.panelHinhThucGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHinhThuc)).BeginInit();
            this.panelSearchHinhThuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1400, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(452, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ HỌC KỲ && HÌNH THỨC";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panelLeft.Controls.Add(this.groupBoxHinhThuc);
            this.panelLeft.Controls.Add(this.groupBoxHocKy);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 60);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(15);
            this.panelLeft.Size = new System.Drawing.Size(450, 690);
            this.panelLeft.TabIndex = 1;
            // 
            // groupBoxHocKy
            // 
            this.groupBoxHocKy.BackColor = System.Drawing.Color.White;
            this.groupBoxHocKy.Controls.Add(this.comboBoxNganhHK);
            this.groupBoxHocKy.Controls.Add(this.labelNganhHK);
            this.groupBoxHocKy.Controls.Add(this.textBoxTenHocKy);
            this.groupBoxHocKy.Controls.Add(this.labelTenHocKy);
            this.groupBoxHocKy.Controls.Add(this.textBoxIDHocKy);
            this.groupBoxHocKy.Controls.Add(this.labelIDHocKy);
            this.groupBoxHocKy.Controls.Add(this.panelButtonsHocKy);
            this.groupBoxHocKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHocKy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxHocKy.Location = new System.Drawing.Point(15, 15);
            this.groupBoxHocKy.Name = "groupBoxHocKy";
            this.groupBoxHocKy.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxHocKy.Size = new System.Drawing.Size(420, 330);
            this.groupBoxHocKy.TabIndex = 0;
            this.groupBoxHocKy.TabStop = false;
            this.groupBoxHocKy.Text = "QUẢN LÝ HỌC KỲ";
            // 
            // comboBoxNganhHK
            // 
            this.comboBoxNganhHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNganhHK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxNganhHK.FormattingEnabled = true;
            this.comboBoxNganhHK.Location = new System.Drawing.Point(18, 160);
            this.comboBoxNganhHK.Name = "comboBoxNganhHK";
            this.comboBoxNganhHK.Size = new System.Drawing.Size(380, 31);
            this.comboBoxNganhHK.TabIndex = 12;
            // 
            // labelNganhHK
            // 
            this.labelNganhHK.AutoSize = true;
            this.labelNganhHK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNganhHK.Location = new System.Drawing.Point(18, 130);
            this.labelNganhHK.Name = "labelNganhHK";
            this.labelNganhHK.Size = new System.Drawing.Size(97, 23);
            this.labelNganhHK.TabIndex = 11;
            this.labelNganhHK.Text = "Tên ngành:";
            // 
            // textBoxTenHocKy
            // 
            this.textBoxTenHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTenHocKy.Location = new System.Drawing.Point(140, 50);
            this.textBoxTenHocKy.Name = "textBoxTenHocKy";
            this.textBoxTenHocKy.Size = new System.Drawing.Size(258, 30);
            this.textBoxTenHocKy.TabIndex = 3;
            // 
            // labelTenHocKy
            // 
            this.labelTenHocKy.AutoSize = true;
            this.labelTenHocKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTenHocKy.Location = new System.Drawing.Point(140, 20);
            this.labelTenHocKy.Name = "labelTenHocKy";
            this.labelTenHocKy.Size = new System.Drawing.Size(101, 23);
            this.labelTenHocKy.TabIndex = 2;
            this.labelTenHocKy.Text = "Tên học kỳ:";
            // 
            // textBoxIDHocKy
            // 
            this.textBoxIDHocKy.Enabled = false;
            this.textBoxIDHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxIDHocKy.Location = new System.Drawing.Point(18, 50);
            this.textBoxIDHocKy.Name = "textBoxIDHocKy";
            this.textBoxIDHocKy.ReadOnly = true;
            this.textBoxIDHocKy.Size = new System.Drawing.Size(100, 30);
            this.textBoxIDHocKy.TabIndex = 1;
            // 
            // labelIDHocKy
            // 
            this.labelIDHocKy.AutoSize = true;
            this.labelIDHocKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelIDHocKy.Location = new System.Drawing.Point(18, 20);
            this.labelIDHocKy.Name = "labelIDHocKy";
            this.labelIDHocKy.Size = new System.Drawing.Size(32, 23);
            this.labelIDHocKy.TabIndex = 0;
            this.labelIDHocKy.Text = "ID:";
            // 
            // panelButtonsHocKy
            // 
            this.panelButtonsHocKy.Controls.Add(this.buttonLamMoiHK);
            this.panelButtonsHocKy.Controls.Add(this.buttonXoaHK);
            this.panelButtonsHocKy.Controls.Add(this.buttonSuaHK);
            this.panelButtonsHocKy.Controls.Add(this.buttonThemHK);
            this.panelButtonsHocKy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonsHocKy.Location = new System.Drawing.Point(15, 215);
            this.panelButtonsHocKy.Name = "panelButtonsHocKy";
            this.panelButtonsHocKy.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelButtonsHocKy.Size = new System.Drawing.Size(390, 100);
            this.panelButtonsHocKy.TabIndex = 13;
            // 
            // buttonLamMoiHK
            // 
            this.buttonLamMoiHK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.buttonLamMoiHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLamMoiHK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLamMoiHK.ForeColor = System.Drawing.Color.White;
            this.buttonLamMoiHK.Location = new System.Drawing.Point(3, 55);
            this.buttonLamMoiHK.Name = "buttonLamMoiHK";
            this.buttonLamMoiHK.Size = new System.Drawing.Size(380, 35);
            this.buttonLamMoiHK.TabIndex = 3;
            this.buttonLamMoiHK.Text = "Làm mới";
            this.buttonLamMoiHK.UseVisualStyleBackColor = false;
            // 
            // buttonXoaHK
            // 
            this.buttonXoaHK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.buttonXoaHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoaHK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonXoaHK.ForeColor = System.Drawing.Color.White;
            this.buttonXoaHK.Location = new System.Drawing.Point(263, 15);
            this.buttonXoaHK.Name = "buttonXoaHK";
            this.buttonXoaHK.Size = new System.Drawing.Size(120, 35);
            this.buttonXoaHK.TabIndex = 2;
            this.buttonXoaHK.Text = "Xóa";
            this.buttonXoaHK.UseVisualStyleBackColor = false;
            // 
            // buttonSuaHK
            // 
            this.buttonSuaHK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.buttonSuaHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuaHK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSuaHK.ForeColor = System.Drawing.Color.White;
            this.buttonSuaHK.Location = new System.Drawing.Point(133, 15);
            this.buttonSuaHK.Name = "buttonSuaHK";
            this.buttonSuaHK.Size = new System.Drawing.Size(120, 35);
            this.buttonSuaHK.TabIndex = 1;
            this.buttonSuaHK.Text = "Sửa";
            this.buttonSuaHK.UseVisualStyleBackColor = false;
            // 
            // buttonThemHK
            // 
            this.buttonThemHK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.buttonThemHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemHK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonThemHK.ForeColor = System.Drawing.Color.White;
            this.buttonThemHK.Location = new System.Drawing.Point(3, 15);
            this.buttonThemHK.Name = "buttonThemHK";
            this.buttonThemHK.Size = new System.Drawing.Size(120, 35);
            this.buttonThemHK.TabIndex = 0;
            this.buttonThemHK.Text = "Thêm";
            this.buttonThemHK.UseVisualStyleBackColor = false;
            // 
            // groupBoxHinhThuc
            // 
            this.groupBoxHinhThuc.BackColor = System.Drawing.Color.White;
            this.groupBoxHinhThuc.Controls.Add(this.comboBoxHocKy);
            this.groupBoxHinhThuc.Controls.Add(this.labelHocKy);
            this.groupBoxHinhThuc.Controls.Add(this.textBoxHinhThuc);
            this.groupBoxHinhThuc.Controls.Add(this.labelHinhThuc);
            this.groupBoxHinhThuc.Controls.Add(this.textBoxIDHinhThuc);
            this.groupBoxHinhThuc.Controls.Add(this.labelIDHinhThuc);
            this.groupBoxHinhThuc.Controls.Add(this.panelButtonsHinhThuc);
            this.groupBoxHinhThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxHinhThuc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxHinhThuc.Location = new System.Drawing.Point(15, 345);
            this.groupBoxHinhThuc.Name = "groupBoxHinhThuc";
            this.groupBoxHinhThuc.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxHinhThuc.Size = new System.Drawing.Size(420, 330);
            this.groupBoxHinhThuc.TabIndex = 1;
            this.groupBoxHinhThuc.TabStop = false;
            this.groupBoxHinhThuc.Text = "QUẢN LÝ HÌNH THỨC";
            // 
            // comboBoxHocKy
            // 
            this.comboBoxHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxHocKy.FormattingEnabled = true;
            this.comboBoxHocKy.Location = new System.Drawing.Point(18, 160);
            this.comboBoxHocKy.Name = "comboBoxHocKy";
            this.comboBoxHocKy.Size = new System.Drawing.Size(380, 31);
            this.comboBoxHocKy.TabIndex = 12;
            // 
            // labelHocKy
            // 
            this.labelHocKy.AutoSize = true;
            this.labelHocKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelHocKy.Location = new System.Drawing.Point(18, 130);
            this.labelHocKy.Name = "labelHocKy";
            this.labelHocKy.Size = new System.Drawing.Size(101, 23);
            this.labelHocKy.TabIndex = 11;
            this.labelHocKy.Text = "Tên học kỳ:";
            // 
            // textBoxHinhThuc
            // 
            this.textBoxHinhThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxHinhThuc.Location = new System.Drawing.Point(140, 50);
            this.textBoxHinhThuc.Name = "textBoxHinhThuc";
            this.textBoxHinhThuc.Size = new System.Drawing.Size(258, 30);
            this.textBoxHinhThuc.TabIndex = 3;
            // 
            // labelHinhThuc
            // 
            this.labelHinhThuc.AutoSize = true;
            this.labelHinhThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelHinhThuc.Location = new System.Drawing.Point(140, 20);
            this.labelHinhThuc.Name = "labelHinhThuc";
            this.labelHinhThuc.Size = new System.Drawing.Size(94, 23);
            this.labelHinhThuc.TabIndex = 2;
            this.labelHinhThuc.Text = "Hình thức:";
            // 
            // textBoxIDHinhThuc
            // 
            this.textBoxIDHinhThuc.Enabled = false;
            this.textBoxIDHinhThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxIDHinhThuc.Location = new System.Drawing.Point(18, 50);
            this.textBoxIDHinhThuc.Name = "textBoxIDHinhThuc";
            this.textBoxIDHinhThuc.ReadOnly = true;
            this.textBoxIDHinhThuc.Size = new System.Drawing.Size(100, 30);
            this.textBoxIDHinhThuc.TabIndex = 1;
            // 
            // labelIDHinhThuc
            // 
            this.labelIDHinhThuc.AutoSize = true;
            this.labelIDHinhThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelIDHinhThuc.Location = new System.Drawing.Point(18, 20);
            this.labelIDHinhThuc.Name = "labelIDHinhThuc";
            this.labelIDHinhThuc.Size = new System.Drawing.Size(32, 23);
            this.labelIDHinhThuc.TabIndex = 0;
            this.labelIDHinhThuc.Text = "ID:";
            // 
            // panelButtonsHinhThuc
            // 
            this.panelButtonsHinhThuc.Controls.Add(this.buttonLamMoiHT);
            this.panelButtonsHinhThuc.Controls.Add(this.buttonXoaHT);
            this.panelButtonsHinhThuc.Controls.Add(this.buttonSuaHT);
            this.panelButtonsHinhThuc.Controls.Add(this.buttonThemHT);
            this.panelButtonsHinhThuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonsHinhThuc.Location = new System.Drawing.Point(15, 215);
            this.panelButtonsHinhThuc.Name = "panelButtonsHinhThuc";
            this.panelButtonsHinhThuc.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelButtonsHinhThuc.Size = new System.Drawing.Size(390, 100);
            this.panelButtonsHinhThuc.TabIndex = 13;
            // 
            // buttonLamMoiHT
            // 
            this.buttonLamMoiHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.buttonLamMoiHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLamMoiHT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLamMoiHT.ForeColor = System.Drawing.Color.White;
            this.buttonLamMoiHT.Location = new System.Drawing.Point(3, 55);
            this.buttonLamMoiHT.Name = "buttonLamMoiHT";
            this.buttonLamMoiHT.Size = new System.Drawing.Size(380, 35);
            this.buttonLamMoiHT.TabIndex = 3;
            this.buttonLamMoiHT.Text = "Làm mới";
            this.buttonLamMoiHT.UseVisualStyleBackColor = false;
            // 
            // buttonXoaHT
            // 
            this.buttonXoaHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.buttonXoaHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoaHT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonXoaHT.ForeColor = System.Drawing.Color.White;
            this.buttonXoaHT.Location = new System.Drawing.Point(263, 15);
            this.buttonXoaHT.Name = "buttonXoaHT";
            this.buttonXoaHT.Size = new System.Drawing.Size(120, 35);
            this.buttonXoaHT.TabIndex = 2;
            this.buttonXoaHT.Text = "Xóa";
            this.buttonXoaHT.UseVisualStyleBackColor = false;
            // 
            // buttonSuaHT
            // 
            this.buttonSuaHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.buttonSuaHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuaHT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSuaHT.ForeColor = System.Drawing.Color.White;
            this.buttonSuaHT.Location = new System.Drawing.Point(133, 15);
            this.buttonSuaHT.Name = "buttonSuaHT";
            this.buttonSuaHT.Size = new System.Drawing.Size(120, 35);
            this.buttonSuaHT.TabIndex = 1;
            this.buttonSuaHT.Text = "Sửa";
            this.buttonSuaHT.UseVisualStyleBackColor = false;
            // 
            // buttonThemHT
            // 
            this.buttonThemHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.buttonThemHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemHT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonThemHT.ForeColor = System.Drawing.Color.White;
            this.buttonThemHT.Location = new System.Drawing.Point(3, 15);
            this.buttonThemHT.Name = "buttonThemHT";
            this.buttonThemHT.Size = new System.Drawing.Size(120, 35);
            this.buttonThemHT.TabIndex = 0;
            this.buttonThemHT.Text = "Thêm";
            this.buttonThemHT.UseVisualStyleBackColor = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.splitContainer);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(450, 60);
            this.panelRight.Padding = new System.Windows.Forms.Padding(15);
            this.panelRight.Size = new System.Drawing.Size(950, 690);
            this.panelRight.TabIndex = 2;
            //
            // splitContainer
            //
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(15, 15);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // splitContainer.Panel1
            //
            this.splitContainer.Panel1.Controls.Add(this.panelHocKyGrid);
            //
            // splitContainer.Panel2
            //
            this.splitContainer.Panel2.Controls.Add(this.panelHinhThucGrid);
            this.splitContainer.Size = new System.Drawing.Size(920, 660);
            this.splitContainer.SplitterDistance = 325;
            this.splitContainer.TabIndex = 0;
            //
            // panelHocKyGrid
            //
            this.panelHocKyGrid.Controls.Add(this.dataGridViewHocKy);
            this.panelHocKyGrid.Controls.Add(this.panelSearchHocKy);
            this.panelHocKyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHocKyGrid.Location = new System.Drawing.Point(0, 0);
            this.panelHocKyGrid.Name = "panelHocKyGrid";
            this.panelHocKyGrid.Size = new System.Drawing.Size(920, 325);
            this.panelHocKyGrid.TabIndex = 0;
            //
            // dataGridViewHocKy
            //
            this.dataGridViewHocKy.AllowUserToAddRows = false;
            this.dataGridViewHocKy.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.dataGridViewHocKy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHocKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHocKy.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHocKy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHocKy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHocKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHocKy.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHocKy.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHocKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHocKy.EnableHeadersVisualStyles = false;
            this.dataGridViewHocKy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewHocKy.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewHocKy.MultiSelect = false;
            this.dataGridViewHocKy.Name = "dataGridViewHocKy";
            this.dataGridViewHocKy.ReadOnly = true;
            this.dataGridViewHocKy.RowHeadersVisible = false;
            this.dataGridViewHocKy.RowHeadersWidth = 51;
            this.dataGridViewHocKy.RowTemplate.Height = 30;
            this.dataGridViewHocKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHocKy.Size = new System.Drawing.Size(920, 275);
            this.dataGridViewHocKy.TabIndex = 1;
            //
            // panelSearchHocKy
            //
            this.panelSearchHocKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panelSearchHocKy.Controls.Add(this.buttonTimKiemHK);
            this.panelSearchHocKy.Controls.Add(this.textBoxTimKiemHK);
            this.panelSearchHocKy.Controls.Add(this.labelSearchHK);
            this.panelSearchHocKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchHocKy.Location = new System.Drawing.Point(0, 0);
            this.panelSearchHocKy.Name = "panelSearchHocKy";
            this.panelSearchHocKy.Padding = new System.Windows.Forms.Padding(10);
            this.panelSearchHocKy.Size = new System.Drawing.Size(920, 50);
            this.panelSearchHocKy.TabIndex = 0;
            //
            // buttonTimKiemHK
            //
            this.buttonTimKiemHK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimKiemHK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonTimKiemHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiemHK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiemHK.ForeColor = System.Drawing.Color.White;
            this.buttonTimKiemHK.Location = new System.Drawing.Point(810, 10);
            this.buttonTimKiemHK.Name = "buttonTimKiemHK";
            this.buttonTimKiemHK.Size = new System.Drawing.Size(100, 30);
            this.buttonTimKiemHK.TabIndex = 2;
            this.buttonTimKiemHK.Text = "Tìm kiếm";
            this.buttonTimKiemHK.UseVisualStyleBackColor = false;
            //
            // textBoxTimKiemHK
            //
            this.textBoxTimKiemHK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimKiemHK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTimKiemHK.Location = new System.Drawing.Point(590, 10);
            this.textBoxTimKiemHK.Name = "textBoxTimKiemHK";
            this.textBoxTimKiemHK.Size = new System.Drawing.Size(210, 30);
            this.textBoxTimKiemHK.TabIndex = 1;
            //
            // labelSearchHK
            //
            this.labelSearchHK.AutoSize = true;
            this.labelSearchHK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelSearchHK.Location = new System.Drawing.Point(10, 13);
            this.labelSearchHK.Name = "labelSearchHK";
            this.labelSearchHK.Size = new System.Drawing.Size(187, 25);
            this.labelSearchHK.TabIndex = 0;
            this.labelSearchHK.Text = "📚 Danh sách Học kỳ";
            //
            // panelHinhThucGrid
            //
            this.panelHinhThucGrid.Controls.Add(this.dataGridViewHinhThuc);
            this.panelHinhThucGrid.Controls.Add(this.panelSearchHinhThuc);
            this.panelHinhThucGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHinhThucGrid.Location = new System.Drawing.Point(0, 0);
            this.panelHinhThucGrid.Name = "panelHinhThucGrid";
            this.panelHinhThucGrid.Size = new System.Drawing.Size(920, 331);
            this.panelHinhThucGrid.TabIndex = 0;
            //
            // dataGridViewHinhThuc
            //
            this.dataGridViewHinhThuc.AllowUserToAddRows = false;
            this.dataGridViewHinhThuc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.dataGridViewHinhThuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHinhThuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHinhThuc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHinhThuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHinhThuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHinhThuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewHinhThuc.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHinhThuc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewHinhThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHinhThuc.EnableHeadersVisualStyles = false;
            this.dataGridViewHinhThuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewHinhThuc.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewHinhThuc.MultiSelect = false;
            this.dataGridViewHinhThuc.Name = "dataGridViewHinhThuc";
            this.dataGridViewHinhThuc.ReadOnly = true;
            this.dataGridViewHinhThuc.RowHeadersVisible = false;
            this.dataGridViewHinhThuc.RowHeadersWidth = 51;
            this.dataGridViewHinhThuc.RowTemplate.Height = 30;
            this.dataGridViewHinhThuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHinhThuc.Size = new System.Drawing.Size(920, 281);
            this.dataGridViewHinhThuc.TabIndex = 1;
            //
            // panelSearchHinhThuc
            //
            this.panelSearchHinhThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panelSearchHinhThuc.Controls.Add(this.buttonTimKiemHT);
            this.panelSearchHinhThuc.Controls.Add(this.textBoxTimKiemHT);
            this.panelSearchHinhThuc.Controls.Add(this.labelSearchHT);
            this.panelSearchHinhThuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchHinhThuc.Location = new System.Drawing.Point(0, 0);
            this.panelSearchHinhThuc.Name = "panelSearchHinhThuc";
            this.panelSearchHinhThuc.Padding = new System.Windows.Forms.Padding(10);
            this.panelSearchHinhThuc.Size = new System.Drawing.Size(920, 50);
            this.panelSearchHinhThuc.TabIndex = 0;
            //
            // buttonTimKiemHT
            //
            this.buttonTimKiemHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimKiemHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonTimKiemHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiemHT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiemHT.ForeColor = System.Drawing.Color.White;
            this.buttonTimKiemHT.Location = new System.Drawing.Point(810, 10);
            this.buttonTimKiemHT.Name = "buttonTimKiemHT";
            this.buttonTimKiemHT.Size = new System.Drawing.Size(100, 30);
            this.buttonTimKiemHT.TabIndex = 2;
            this.buttonTimKiemHT.Text = "Tìm kiếm";
            this.buttonTimKiemHT.UseVisualStyleBackColor = false;
            //
            // textBoxTimKiemHT
            //
            this.textBoxTimKiemHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimKiemHT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTimKiemHT.Location = new System.Drawing.Point(590, 10);
            this.textBoxTimKiemHT.Name = "textBoxTimKiemHT";
            this.textBoxTimKiemHT.Size = new System.Drawing.Size(210, 30);
            this.textBoxTimKiemHT.TabIndex = 1;
            //
            // labelSearchHT
            //
            this.labelSearchHT.AutoSize = true;
            this.labelSearchHT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelSearchHT.Location = new System.Drawing.Point(10, 13);
            this.labelSearchHT.Name = "labelSearchHT";
            this.labelSearchHT.Size = new System.Drawing.Size(212, 25);
            this.labelSearchHT.TabIndex = 0;
            this.labelSearchHT.Text = "📝 Danh sách Hình thức";
            //
            // FormHinhThucThi
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FormHinhThucThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học kỳ và hình thức thi";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxHocKy.ResumeLayout(false);
            this.groupBoxHocKy.PerformLayout();
            this.panelButtonsHocKy.ResumeLayout(false);
            this.groupBoxHinhThuc.ResumeLayout(false);
            this.groupBoxHinhThuc.PerformLayout();
            this.panelButtonsHinhThuc.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelHocKyGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHocKy)).EndInit();
            this.panelSearchHocKy.ResumeLayout(false);
            this.panelSearchHocKy.PerformLayout();
            this.panelHinhThucGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHinhThuc)).EndInit();
            this.panelSearchHinhThuc.ResumeLayout(false);
            this.panelSearchHinhThuc.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxHocKy;
        private System.Windows.Forms.ComboBox comboBoxNganhHK;
        private System.Windows.Forms.Label labelNganhHK;
        private System.Windows.Forms.TextBox textBoxTenHocKy;
        private System.Windows.Forms.Label labelTenHocKy;
        private System.Windows.Forms.TextBox textBoxIDHocKy;
        private System.Windows.Forms.Label labelIDHocKy;
        private System.Windows.Forms.Panel panelButtonsHocKy;
        private System.Windows.Forms.Button buttonLamMoiHK;
        private System.Windows.Forms.Button buttonXoaHK;
        private System.Windows.Forms.Button buttonSuaHK;
        private System.Windows.Forms.Button buttonThemHK;
        private System.Windows.Forms.GroupBox groupBoxHinhThuc;
        private System.Windows.Forms.ComboBox comboBoxHocKy;
        private System.Windows.Forms.Label labelHocKy;
        private System.Windows.Forms.TextBox textBoxHinhThuc;
        private System.Windows.Forms.Label labelHinhThuc;
        private System.Windows.Forms.TextBox textBoxIDHinhThuc;
        private System.Windows.Forms.Label labelIDHinhThuc;
        private System.Windows.Forms.Panel panelButtonsHinhThuc;
        private System.Windows.Forms.Button buttonLamMoiHT;
        private System.Windows.Forms.Button buttonXoaHT;
        private System.Windows.Forms.Button buttonSuaHT;
        private System.Windows.Forms.Button buttonThemHT;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelHocKyGrid;
        private System.Windows.Forms.DataGridView dataGridViewHocKy;
        private System.Windows.Forms.Panel panelSearchHocKy;
        private System.Windows.Forms.Button buttonTimKiemHK;
        private System.Windows.Forms.TextBox textBoxTimKiemHK;
        private System.Windows.Forms.Label labelSearchHK;
        private System.Windows.Forms.Panel panelHinhThucGrid;
        private System.Windows.Forms.DataGridView dataGridViewHinhThuc;
        private System.Windows.Forms.Panel panelSearchHinhThuc;
        private System.Windows.Forms.Button buttonTimKiemHT;
        private System.Windows.Forms.TextBox textBoxTimKiemHT;
        private System.Windows.Forms.Label labelSearchHT;
    }
}