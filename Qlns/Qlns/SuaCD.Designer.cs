namespace Qlns
{
    partial class SuaCD
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
            this.ntnSuaCD = new System.Windows.Forms.Button();
            this.txtTenChucDanh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ntnSuaCD
            // 
            this.ntnSuaCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.ntnSuaCD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ntnSuaCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ntnSuaCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntnSuaCD.ForeColor = System.Drawing.SystemColors.Control;
            this.ntnSuaCD.Location = new System.Drawing.Point(275, 215);
            this.ntnSuaCD.Name = "ntnSuaCD";
            this.ntnSuaCD.Size = new System.Drawing.Size(197, 48);
            this.ntnSuaCD.TabIndex = 7;
            this.ntnSuaCD.Text = "Sửa";
            this.ntnSuaCD.UseVisualStyleBackColor = false;
            this.ntnSuaCD.Click += new System.EventHandler(this.ntnSuaCD_Click);
            // 
            // txtTenChucDanh
            // 
            this.txtTenChucDanh.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtTenChucDanh.Location = new System.Drawing.Point(257, 134);
            this.txtTenChucDanh.MaximumSize = new System.Drawing.Size(250, 100);
            this.txtTenChucDanh.Name = "txtTenChucDanh";
            this.txtTenChucDanh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTenChucDanh.Size = new System.Drawing.Size(250, 26);
            this.txtTenChucDanh.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Chức Danh";
            // 
            // txtId
            // 
            this.txtId.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtId.Location = new System.Drawing.Point(257, 69);
            this.txtId.MaximumSize = new System.Drawing.Size(250, 100);
            this.txtId.Name = "txtId";
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtId.Size = new System.Drawing.Size(250, 26);
            this.txtId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id";
            // 
            // SuaCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ntnSuaCD);
            this.Controls.Add(this.txtTenChucDanh);
            this.Controls.Add(this.label2);
            this.Name = "SuaCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaCD";
            this.Load += new System.EventHandler(this.SuaCD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ntnSuaCD;
        public System.Windows.Forms.TextBox txtTenChucDanh;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
    }
}