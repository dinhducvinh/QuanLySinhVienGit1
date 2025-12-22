namespace QuanLySinhVien
{
    partial class FormDiemTheoLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quanLyDiemDataSet = new QuanLySinhVien.QuanLyDiemDataSet();
            this.bangDiemTheoLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BangDiemTheoLopTableAdapter = new QuanLySinhVien.QuanLyDiemDataSetTableAdapters._BangDiemTheoLopTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemTheoLopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTimKiem);
            this.panel1.Controls.Add(this.textBoxTenLop);
            this.panel1.Controls.Add(this.labelSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 600);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BangDiemTheoLop";
            reportDataSource1.Value = this.bangDiemTheoLopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.ReportDiem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonTimKiem.ForeColor = System.Drawing.Color.White;
            this.buttonTimKiem.Location = new System.Drawing.Point(718, 30);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(110, 40);
            this.buttonTimKiem.TabIndex = 5;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTenLop.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxTenLop.Location = new System.Drawing.Point(463, 35);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(245, 32);
            this.textBoxTenLop.TabIndex = 4;
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelSearch.Location = new System.Drawing.Point(373, 38);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(74, 23);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Tên lớp:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên lớp:";
            // 
            // quanLyDiemDataSet
            // 
            this.quanLyDiemDataSet.DataSetName = "QuanLyDiemDataSet";
            this.quanLyDiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangDiemTheoLopBindingSource
            // 
            this.bangDiemTheoLopBindingSource.DataMember = " BangDiemTheoLop";
            this.bangDiemTheoLopBindingSource.DataSource = this.quanLyDiemDataSet;
            // 
            // _BangDiemTheoLopTableAdapter
            // 
            this._BangDiemTheoLopTableAdapter.ClearBeforeFill = true;
            // 
            // FormDiemTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDiemTheoLop";
            this.Text = "FormDiemTheoLop";
            this.Load += new System.EventHandler(this.FormDiemTheoLop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemTheoLopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bangDiemTheoLopBindingSource;
        private QuanLyDiemDataSet quanLyDiemDataSet;
        private QuanLyDiemDataSetTableAdapters._BangDiemTheoLopTableAdapter _BangDiemTheoLopTableAdapter;
    }
}