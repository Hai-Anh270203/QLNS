using Qlns.BUS;
using Qlns.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void tabChucDanh_Click(object sender, EventArgs e)
        {
            ChucDanhDAL GoiChucDanh = new ChucDanhDAL();
            List<DTO.ChucDanhDTO> DsChucDanh = GoiChucDanh.LayChucDanh();
            DgvCD.DataSource = DsChucDanh;
            DgvCD.AutoGenerateColumns = true;
        }

        private void btnThemCD_Click(object sender, EventArgs e)
        {
            ThemCD cD = new ThemCD();
            cD.ShowDialog();
        }

        private void DgvCD_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Id = Convert.ToInt32(DgvCD.Rows[e.RowIndex].Cells[0].Value.ToString());
                string TenChucDanh = DgvCD.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Tạo một thể hiện của form sửa thông tin và truyền giá trị Id, TenChucDanh
                SuaCD editForm = new SuaCD(Id, TenChucDanh);

                // Mở form sửa thông tin
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Load lại thông tin từ form sửa vào DataGridView
                    DgvCD.Rows[e.RowIndex].Cells[1].Value = editForm.txtTenChucDanh;
                }
            }
        }


    }
}
