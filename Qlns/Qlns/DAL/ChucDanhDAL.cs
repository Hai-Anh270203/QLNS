using Qlns.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns.DAL
{
    internal class ChucDanhDAL
    {
        ConnectDB.Connect Kn = new ConnectDB.Connect();
        public List<DTO.ChucDanhDTO> LayChucDanh()
        {
            List<DTO.ChucDanhDTO> ChucDanhList = new List<ChucDanhDTO>();


            SqlConnection ketnoi = Kn.OpenConnection();
            string query = "SELECT * FROM ChucDanh";
            SqlCommand cmd = new SqlCommand(query, ketnoi);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                DTO.ChucDanhDTO CD = new DTO.ChucDanhDTO()
                {
                    Id = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Id")),
                    TenChucDanh=sqlDataReader.GetString(sqlDataReader.GetOrdinal("TenChucDanh")),
                    Status =sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                };
                // Process or use the ChucDanhDTO object here
                ChucDanhList.Add(CD);
            }
       
            return ChucDanhList;

        }
        public bool SuaChucDanh(int Id, string TenChucDanh)
        {
            try
            {
                using (SqlConnection ketnoi = Kn.OpenConnection())
                {
                    string query = "UPDATE ChucDanh SET TenChucDanh = @TenChucDanh WHERE Id = @Id;";
                    using (SqlCommand command = new SqlCommand(query, ketnoi))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@TenChucDanh", TenChucDanh);

                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            // No rows were affected, meaning the update did not succeed
                            MessageBox.Show("Update failed. No rows were affected.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}

