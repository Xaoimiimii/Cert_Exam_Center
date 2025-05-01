using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter
{
    internal class PhieuDuThi_DAO
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

        public void CapNhatTrangThai(string sbd, string trangThai)
        {
            try
            {
                connection.InfoMessage += (sender, e) =>
                {
                    throw new Exception(e.Message);//Để bắt lỗi
                };

                using (SqlCommand cmd = new SqlCommand("CapNhatTrangThai", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SBD", sbd);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);

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
    }
}
