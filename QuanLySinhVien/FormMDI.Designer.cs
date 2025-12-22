namespace QuanLySinhVien
{
    partial class FormMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNghe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHinhThucThi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhSachSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhSachDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTaiKhoan = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusNgayGio = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuQuanLy,
            this.menuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangXuat,
            this.toolStripSeparator1,
            this.menuThoat});
            this.menuHeThong.ForeColor = System.Drawing.Color.White;
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(96, 27);
            this.menuHeThong.Text = "Hệ thống";
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(198, 28);
            this.menuDangXuat.Text = "Đăng xuất";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuThoat.Size = new System.Drawing.Size(198, 28);
            this.menuThoat.Text = "Thoát";
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKhoa,
            this.menuNghe,
            this.menuLop,
            this.menuSinhVien,
            this.toolStripSeparator2,
            this.menuMonHoc,
            this.toolStripSeparator3,
            this.menuDiem,
            this.menuHinhThucThi,
            this.toolStripSeparator4,
            this.menuTaiKhoan});
            this.menuQuanLy.ForeColor = System.Drawing.Color.White;
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(83, 27);
            this.menuQuanLy.Text = "Quản lý";
            // 
            // menuKhoa
            // 
            this.menuKhoa.Name = "menuKhoa";
            this.menuKhoa.Size = new System.Drawing.Size(224, 28);
            this.menuKhoa.Text = "Khoa";
            // 
            // menuNghe
            // 
            this.menuNghe.Name = "menuNghe";
            this.menuNghe.Size = new System.Drawing.Size(224, 28);
            this.menuNghe.Text = "Nghề";
            // 
            // menuLop
            // 
            this.menuLop.Name = "menuLop";
            this.menuLop.Size = new System.Drawing.Size(224, 28);
            this.menuLop.Text = "Lớp";
            // 
            // menuSinhVien
            // 
            this.menuSinhVien.Name = "menuSinhVien";
            this.menuSinhVien.Size = new System.Drawing.Size(224, 28);
            this.menuSinhVien.Text = "Sinh viên";
            this.menuSinhVien.Click += new System.EventHandler(this.menuSinhVien_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // menuMonHoc
            // 
            this.menuMonHoc.Name = "menuMonHoc";
            this.menuMonHoc.Size = new System.Drawing.Size(224, 28);
            this.menuMonHoc.Text = "Môn học";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // menuDiem
            // 
            this.menuDiem.Name = "menuDiem";
            this.menuDiem.Size = new System.Drawing.Size(224, 28);
            this.menuDiem.Text = "Điểm";
            // 
            // menuHinhThucThi
            // 
            this.menuHinhThucThi.Name = "menuHinhThucThi";
            this.menuHinhThucThi.Size = new System.Drawing.Size(224, 28);
            this.menuHinhThucThi.Text = "Hình thức thi";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(224, 28);
            this.menuTaiKhoan.Text = "Tài khoản";
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDanhSachSinhVien,
            this.menuDanhSachDiem,
            this.menuThongKe});
            this.menuBaoCao.ForeColor = System.Drawing.Color.White;
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(85, 27);
            this.menuBaoCao.Text = "Báo cáo";
            // 
            // menuDanhSachSinhVien
            // 
            this.menuDanhSachSinhVien.Name = "menuDanhSachSinhVien";
            this.menuDanhSachSinhVien.Size = new System.Drawing.Size(353, 28);
            this.menuDanhSachSinhVien.Text = "Tỉ lệ sinh viên qua môn,trượt môn";
            this.menuDanhSachSinhVien.Click += new System.EventHandler(this.menuDanhSachSinhVien_Click);
            // 
            // menuDanhSachDiem
            // 
            this.menuDanhSachDiem.Name = "menuDanhSachDiem";
            this.menuDanhSachDiem.Size = new System.Drawing.Size(353, 28);
            this.menuDanhSachDiem.Text = "Danh sách điểm";
            this.menuDanhSachDiem.Click += new System.EventHandler(this.menuDanhSachDiem_Click);
            // 
            // menuThongKe
            // 
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(353, 28);
            this.menuThongKe.Text = "Thống kê sinh viên";
            this.menuThongKe.Click += new System.EventHandler(this.menuThongKe_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusTaiKhoan,
            this.toolStripStatusLabel2,
            this.statusNgayGio});
            this.statusStrip1.Location = new System.Drawing.Point(0, 674);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1200, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 20);
            this.toolStripStatusLabel1.Text = "Tài khoản:";
            // 
            // statusTaiKhoan
            // 
            this.statusTaiKhoan.Name = "statusTaiKhoan";
            this.statusTaiKhoan.Size = new System.Drawing.Size(81, 20);
            this.statusTaiKhoan.Text = "[Tài khoản]";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(938, 20);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // statusNgayGio
            // 
            this.statusNgayGio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusNgayGio.Name = "statusNgayGio";
            this.statusNgayGio.Size = new System.Drawing.Size(84, 20);
            this.statusNgayGio.Text = "[Ngày giờ]";
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuKhoa;
        private System.Windows.Forms.ToolStripMenuItem menuNghe;
        private System.Windows.Forms.ToolStripMenuItem menuLop;
        private System.Windows.Forms.ToolStripMenuItem menuSinhVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuMonHoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuDiem;
        private System.Windows.Forms.ToolStripMenuItem menuHinhThucThi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuDanhSachSinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuDanhSachDiem;
        private System.Windows.Forms.ToolStripMenuItem menuThongKe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusTaiKhoan;
        private System.Windows.Forms.ToolStripStatusLabel statusNgayGio;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}