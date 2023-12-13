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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void DGVNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
/*            int i;
            i = DGVNhanVien.CurrentRow.Index;
            txtId.Text = DGV.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = DGV.Rows[i].Cells[1].Value.ToString();
            txtNgaySinh.Text = DGV.Rows[i].Cells[2].Value.ToString();
            txtEmail.Text = DGV.Rows[i].Cells[3].Value.ToString();
            CbGioiTinh.Text = DGV.Rows[i].Cells[4].Value.ToString();
            txtCMND.Text = DGV.Rows[i].Cells[5].Value.ToString();
            txtDiaChi.Text = DGV.Rows[i].Cells[6].Value.ToString();
            CbDangVien.Text = DGV.Rows[i].Cells[7].Value.ToString();
            txtTenCongTac.Text = DGV.Rows[i].Cells[8].Value.ToString();
            txtTenChucVu.Text = DGV.Rows[i].Cells[9].Value.ToString();
            txtHopDong.Text = DGV.Rows[i].Cells[10].Value.ToString();
            txtAnh.Text = DGV.Rows[i].Cells[11].Value.ToString();
            string imagePath = @"C:\Users\DOUBLE COMPUTER\Pictures\005.jpg";
            MessageBox.Show("da den day");
            // Kiểm tra xem tập tin ảnh có tồn tại không
            if (File.Exists(imagePath))
            {
                PAnh.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("not anh");
            }*/
        }

        private void tadNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DAL.NhanVienDAL nhanVienDAL=new DAL.NhanVienDAL();
            List<DTO.NhanVienDTO> NhanVienList = nhanVienDAL.GetNhanVienList();
            if(NhanVienList != null )
            {
                DGVNhanVien.DataSource= NhanVienList;
           /*     DGVNhanVien.AutoGenerateColumns = true;*/
            }
            else
            {
                MessageBox.Show("Không thể lấy danh sách nhân viên");
            }
        }
    }
}
