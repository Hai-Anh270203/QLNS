using Qlns.DAL;
using System;
using System.Windows.Forms;

namespace Qlns
{
    public partial class SuaCD : Form
    {
        private int _id;
        private string _tenChucDanh;

        public SuaCD(int Id, string TenChucDanh)
        {
            InitializeComponent();
            _id = Id;
            _tenChucDanh = TenChucDanh;
        }

        private void ntnSuaCD_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu mới từ các điều khiển trên form (txtTenChucDanh là ví dụ)
                string tenMoi = txtTenChucDanh.Text;

                // Kiểm tra xem tên mới có được nhập không
                if (string.IsNullOrWhiteSpace(tenMoi))
                {
                    MessageBox.Show("Vui lòng nhập tên chức danh mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi hàm SuaChucDanh để cập nhật thông tin
                ChucDanhDAL SuaDALcd = new ChucDanhDAL();
                bool ketQua = SuaDALcd.SuaChucDanh(_id, tenMoi);

                // Kiểm tra kết quả và thông báo cho người dùng
                if (ketQua)
                {
                    MessageBox.Show("Sửa chức danh thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Gửi kết quả về cho form gọi nếu cần thiết
                    DialogResult = DialogResult.OK;
                    // Đóng form sửa
                    Close();
                }
                else
                {
                    MessageBox.Show("Sửa chức danh thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuaCD_Load(object sender, EventArgs e)
        {
            // Hiển thị dữ liệu trong form khi form được load
            txtId.Text = _id.ToString();
            txtTenChucDanh.Text = _tenChucDanh;
        }
    }
}
