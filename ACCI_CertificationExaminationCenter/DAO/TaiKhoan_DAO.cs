using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ACCI_CertificationExaminationCenter.DAO
{
    internal class TaiKhoan_DAO
    {
        private SqlConnection connection;
        private string strConnection = "Data Source=LAPTOP-OJ43E27H;Initial Catalog=PTTK;Integrated Security=True;TrustServerCertificate=True";

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

        public bool KiemTraTaiKhoan(string tenDangNhap, string matKhau)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("KiemTraDangNhap", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                int result = (int)cmd.ExecuteScalar();
                return result > 0;
            }
            finally
            {
                Disconnect();
            }

        }



    }
}
