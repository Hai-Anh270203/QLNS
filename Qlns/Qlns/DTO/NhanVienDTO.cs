using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlns.DTO
{
    internal class NhanVienDTO
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string DangVien { get; set; }
/*        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }*/
        public string HocVan { get; set; }
        public string MaNhanVien { get; set; }
        public int TienLuong { get; set; }
        public string ChucDanh { get; set; }
        public string CongTac { get; set; }
        public string HopDong { get; set; }
        public Image image { get; set; }
        /*        public int Status { get; set; }*/

        /*       public Image Anh2 {  get; set; }*/
    }
}
