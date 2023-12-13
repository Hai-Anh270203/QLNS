using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns.DAL
{
    internal class NhanVienDAL
    {
        ConnectDB.Connect kn = new ConnectDB.Connect();

        public List<DTO.NhanVienDTO> GetNhanVienList()
        {

            List<DTO.NhanVienDTO> NhanVienList = new List<DTO.NhanVienDTO>();

            // Mở kết nối
            SqlConnection connection = kn.OpenConnection();
            try
            {
                connection = kn.OpenConnection();
                string query =
                   "SELECT Users.Id, Users.HoTen, Users.NgaySinh, Users.Email, Users.GioiTinh, " +
                   "Users.DiaChi, Users.DangVien, Users.HocVan, Users.CMND, ChucDanh.TenChucDanh, CongTac.TenCongTac,  " +
                   "HopDong.LoaiHopDong, TienLuong.Id, NhanVien.MaNhanVien, Users.Image " +
                   "FROM Users " +
                   "JOIN NhanVien ON NhanVien.IdUser = Users.Id " +
                   "JOIN ChucDanh ON ChucDanh.Id = NhanVien.IdChucDanh " +
                   "JOIN TienLuong ON NhanVien.IdTienLuong = TienLuong.Id " +
                   "JOIN HopDong ON HopDong.Id = NhanVien.IdHopDong " +
                   "JOIN CongTac ON CongTac.Id = NhanVien.IdCongTac " +
                   "WHERE NhanVien.Status = 1;";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DTO.NhanVienDTO NVList = new DTO.NhanVienDTO()
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        HoTen = reader.GetString(reader.GetOrdinal("HoTen")),
                        NgaySinh = reader.GetDateTime(reader.GetOrdinal("NgaySinh")),
                        Email = reader.GetString(reader.GetOrdinal("Email")),
                        GioiTinh = reader.GetString(reader.GetOrdinal("GioiTinh")),
                        CMND = reader.GetString(reader.GetOrdinal("CMND")),
                        DiaChi = reader.GetString(reader.GetOrdinal("DiaChi")),
                        DangVien = reader.GetString(reader.GetOrdinal("DangVien")),
                        CongTac = reader.GetString(reader.GetOrdinal("TenCongTac")),
                        ChucDanh = reader.GetString(reader.GetOrdinal("TenChucDanh")),
                        HopDong = reader.GetString(reader.GetOrdinal("LoaiHopDong")),
                        HocVan = reader.GetString(reader.GetOrdinal("HocVan")),
                        TienLuong = reader.GetInt32(reader.GetOrdinal("Id")),
                        
                    };

                    NhanVienList.Add(NVList);
                    MessageBox.Show("ok");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đọc dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                MessageBox.Show("not ok");
                return null;
            }
            return NhanVienList;
        }


    }
}
