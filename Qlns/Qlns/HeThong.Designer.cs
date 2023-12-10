namespace Qlns
{
    partial class HeThong
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
            this.tabChucDanh = new System.Windows.Forms.TabPage();
            this.btnXoaCD = new System.Windows.Forms.Button();
            this.btnSuaCD = new System.Windows.Forms.Button();
            this.btnThemCD = new System.Windows.Forms.Button();
            this.DgvCD = new System.Windows.Forms.DataGridView();
            this.tabTaiKhoan = new System.Windows.Forms.TabPage();
            this.tabCongTac = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabChucDanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChucDanh);
            this.tabControl1.Controls.Add(this.tabTaiKhoan);
            this.tabControl1.Controls.Add(this.tabCongTac);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1178, 620);
            this.tabControl1.TabIndex = 1;
            // 
            // tabChucDanh
            // 
            this.tabChucDanh.BackColor = System.Drawing.Color.Transparent;
            this.tabChucDanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabChucDanh.Controls.Add(this.btnXoaCD);
            this.tabChucDanh.Controls.Add(this.btnSuaCD);
            this.tabChucDanh.Controls.Add(this.btnThemCD);
            this.tabChucDanh.Controls.Add(this.DgvCD);
            this.tabChucDanh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabChucDanh.Location = new System.Drawing.Point(4, 44);
            this.tabChucDanh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabChucDanh.Name = "tabChucDanh";
            this.tabChucDanh.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabChucDanh.Size = new System.Drawing.Size(1170, 572);
            this.tabChucDanh.TabIndex = 0;
            this.tabChucDanh.Text = "Chức danh";
            this.tabChucDanh.Click += new System.EventHandler(this.tabChucDanh_Click);
            // 
            // btnXoaCD
            // 
            this.btnXoaCD.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaCD.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoaCD.Location = new System.Drawing.Point(704, 402);
            this.btnXoaCD.Name = "btnXoaCD";
            this.btnXoaCD.Size = new System.Drawing.Size(182, 61);
            this.btnXoaCD.TabIndex = 3;
            this.btnXoaCD.Text = "Xóa";
            this.btnXoaCD.UseVisualStyleBackColor = false;
            // 
            // btnSuaCD
            // 
            this.btnSuaCD.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSuaCD.ForeColor = System.Drawing.Color.Transparent;
            this.btnSuaCD.Location = new System.Drawing.Point(468, 402);
            this.btnSuaCD.Name = "btnSuaCD";
            this.btnSuaCD.Size = new System.Drawing.Size(182, 61);
            this.btnSuaCD.TabIndex = 2;
            this.btnSuaCD.Text = "Sửa";
            this.btnSuaCD.UseVisualStyleBackColor = false;
            // 
            // btnThemCD
            // 
            this.btnThemCD.BackColor = System.Drawing.Color.Gold;
            this.btnThemCD.ForeColor = System.Drawing.Color.Transparent;
            this.btnThemCD.Location = new System.Drawing.Point(209, 402);
            this.btnThemCD.Name = "btnThemCD";
            this.btnThemCD.Size = new System.Drawing.Size(182, 61);
            this.btnThemCD.TabIndex = 1;
            this.btnThemCD.Text = "Thêm";
            this.btnThemCD.UseVisualStyleBackColor = false;
            this.btnThemCD.Click += new System.EventHandler(this.btnThemCD_Click);
            // 
            // DgvCD
            // 
            this.DgvCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCD.GridColor = System.Drawing.Color.LightSeaGreen;
            this.DgvCD.Location = new System.Drawing.Point(77, 53);
            this.DgvCD.Name = "DgvCD";
            this.DgvCD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DgvCD.RowTemplate.Height = 28;
            this.DgvCD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvCD.Size = new System.Drawing.Size(1004, 288);
            this.DgvCD.TabIndex = 0;
            // 
            // tabTaiKhoan
            // 
            this.tabTaiKhoan.Location = new System.Drawing.Point(4, 44);
            this.tabTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabTaiKhoan.Name = "tabTaiKhoan";
            this.tabTaiKhoan.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabTaiKhoan.Size = new System.Drawing.Size(1170, 572);
            this.tabTaiKhoan.TabIndex = 1;
            this.tabTaiKhoan.Text = "Tai khoản";
            this.tabTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tabCongTac
            // 
            this.tabCongTac.Location = new System.Drawing.Point(4, 44);
            this.tabCongTac.Name = "tabCongTac";
            this.tabCongTac.Padding = new System.Windows.Forms.Padding(3);
            this.tabCongTac.Size = new System.Drawing.Size(1170, 572);
            this.tabCongTac.TabIndex = 2;
            this.tabCongTac.Text = "Công tác";
            this.tabCongTac.UseVisualStyleBackColor = true;
            // 
            // HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 620);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HeThong";
            this.Text = "HeThong";
            this.Load += new System.EventHandler(this.tabChucDanh_Click);
            this.tabControl1.ResumeLayout(false);
            this.tabChucDanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChucDanh;
        private System.Windows.Forms.TabPage tabTaiKhoan;
        private System.Windows.Forms.TabPage tabCongTac;
        private System.Windows.Forms.DataGridView DgvCD;
        private System.Windows.Forms.Button btnXoaCD;
        private System.Windows.Forms.Button btnSuaCD;
        private System.Windows.Forms.Button btnThemCD;
    }
}