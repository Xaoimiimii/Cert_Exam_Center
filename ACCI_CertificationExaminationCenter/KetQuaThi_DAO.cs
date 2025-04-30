using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter
{
    internal class KetQuaThi_DAO
    {
        private SqlConnection connection;
        private string strConnection = "Data Source=.;Initial Catalog=PTTK;Integrated Security=True;TrustServerCertificate=True";
        public void Connect()
        {
            if (connection == null)
                connection = new SqlConnection(strConnection);

            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }

        public void CapNhatTrangThaiNhan(string sbd)
        {
            try
            {
                connection.InfoMessage += (sender, e) =>
                {
                    throw new Exception(e.Message);//Để bắt lỗi
                };

                using (SqlCommand cmd = new SqlCommand("CapNhatTrangThaiNhan", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SBD", sbd);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Đã cập nhật trạng thái nhận chứng chỉ cho SBD: " + sbd);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ThemKQThi(string soBaoDanh, int diem, DateTime? ngayCapChungChi)
        {
            try
            {

                connection.InfoMessage += (sender, e) =>
                {
                    throw new Exception(e.Message);
                };

                using (SqlCommand cmd = new SqlCommand("ThemKQThi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SoBaoDanh", soBaoDanh);
                    cmd.Parameters.AddWithValue("@Diem", diem);
                    cmd.Parameters.AddWithValue("@NgayCapChungChi", (object?)ngayCapChungChi ?? DBNull.Value);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Đã thêm kết quả thi cho SBD: " + soBaoDanh);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}