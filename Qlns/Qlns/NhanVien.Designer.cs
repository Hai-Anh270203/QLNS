namespace Qlns
{
    partial class NhanVien
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tadNhanVien = new System.Windows.Forms.TabPage();
            this.tabQLBH = new System.Windows.Forms.TabPage();
            this.DGVNhanVien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.tabQLTV = new System.Windows.Forms.TabPage();
            this.PAnh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tadNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tadNhanVien);
            this.tabControl1.Controls.Add(this.tabQLBH);
            this.tabControl1.Controls.Add(this.tabQLTV);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1473, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // tadNhanVien
            // 
            this.tadNhanVien.Controls.Add(this.label1);
            this.tadNhanVien.Controls.Add(this.PAnh);
            this.tadNhanVien.Controls.Add(this.btnXuatExcel);
            this.tadNhanVien.Controls.Add(this.btnLamMoi);
            this.tadNhanVien.Controls.Add(this.btnSua);
            this.tadNhanVien.Controls.Add(this.btnXoa);
            this.tadNhanVien.Controls.Add(this.button1);
            this.tadNhanVien.Controls.Add(this.DGVNhanVien);
            this.tadNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tadNhanVien.Name = "tadNhanVien";
            this.tadNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tadNhanVien.Size = new System.Drawing.Size(1465, 409);
            this.tadNhanVien.TabIndex = 0;
            this.tadNhanVien.Text = "Nhân viên";
            this.tadNhanVien.UseVisualStyleBackColor = true;
            this.tadNhanVien.Click += new System.EventHandler(this.tadNhanVien_Click);
            // 
            // tabQLBH
            // 
            this.tabQLBH.Location = new System.Drawing.Point(4, 22);
            this.tabQLBH.Name = "tabQLBH";
            this.tabQLBH.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLBH.Size = new System.Drawing.Size(1465, 409);
            this.tabQLBH.TabIndex = 1;
            this.tabQLBH.Text = "Quản lý bảo hiểm";
            this.tabQLBH.UseVisualStyleBackColor = true;
            // 
            // DGVNhanVien
            // 
            this.DGVNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.LoaiHopDong,
            this.Column12,
            this.Column14});
            this.DGVNhanVien.Location = new System.Drawing.Point(51, 32);
            this.DGVNhanVien.Name = "DGVNhanVien";
            this.DGVNhanVien.Size = new System.Drawing.Size(1193, 315);
            this.DGVNhanVien.TabIndex = 0;
            this.DGVNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNhanVien_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm nhân sự";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(313, 366);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa nhân sự";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(481, 366);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa nhân sự";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(641, 365);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(804, 365);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(75, 23);
            this.btnXuatExcel.TabIndex = 5;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // tabQLTV
            // 
            this.tabQLTV.Location = new System.Drawing.Point(4, 22);
            this.tabQLTV.Name = "tabQLTV";
            this.tabQLTV.Size = new System.Drawing.Size(1465, 409);
            this.tabQLTV.TabIndex = 2;
            this.tabQLTV.Text = "Quản lý thử thôi việc";
            this.tabQLTV.UseVisualStyleBackColor = true;
            // 
            // PAnh
            // 
            this.PAnh.Location = new System.Drawing.Point(1284, 32);
            this.PAnh.Name = "PAnh";
            this.PAnh.Size = new System.Drawing.Size(114, 142);
            this.PAnh.TabIndex = 6;
            this.PAnh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1300, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ảnh nhân viên";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNhanVien";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DiaChi";
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DangVien";
            this.Column7.HeaderText = "Đảng viên";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "HocVan";
            this.Column8.HeaderText = "Học vấn";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "CMND";
            this.Column9.HeaderText = "CMND";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TenChucDanh";
            this.Column10.HeaderText = "Chức danh";
            this.Column10.Name = "Column10";
            // 
            // LoaiHopDong
            // 
            this.LoaiHopDong.DataPropertyName = "LoaiHopDong";
            this.LoaiHopDong.HeaderText = "Loại hợp đồng";
            this.LoaiHopDong.Name = "LoaiHopDong";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Id";
            this.Column12.HeaderText = "Mã tiền lương";
            this.Column12.Name = "Column12";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "TenCongTac";
            this.Column14.HeaderText = "Công tác";
            this.Column14.Name = "Column14";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tadNhanVien.ResumeLayout(false);
            this.tadNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tadNhanVien;
        private System.Windows.Forms.TabPage tabQLBH;
        private System.Windows.Forms.DataGridView DGVNhanVien;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabQLTV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}