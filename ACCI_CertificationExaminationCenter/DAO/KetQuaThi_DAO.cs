﻿using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter.DAO
{
    public class KetQuaThi_DAO
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


        public void ThemKQThi(string soBaoDanh, int diem, DateTime? ngayCapChungChi, string nhanVienNhap)
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
                    cmd.Parameters.AddWithValue("@NhanVienNhap", nhanVienNhap);

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