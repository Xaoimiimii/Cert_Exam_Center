using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter.DAO
{
    internal class LichThi_DAO
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

        public DataTable LayDSLichThi()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("LayDSLichThi", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }


        public DataTable LayTTLichThi(string maLichThi)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("LayTTLichThi_MaLichThi", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaLichThi", maLichThi);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

        public DataTable LayTTLichThi(DateOnly? ngayThi, TimeOnly? thoiGianThi, string? loaiDanhGia)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("LayTTLichThi_Ngay_ThoiGian_LoaiDanhGia", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                if (ngayThi.HasValue)
                    cmd.Parameters.AddWithValue("@NgayThi", ngayThi);
                else
                    cmd.Parameters.AddWithValue("@NgayThi", DBNull.Value);

                if (thoiGianThi.HasValue)
                    cmd.Parameters.AddWithValue("@ThoiGianThi", thoiGianThi);
                else
                    cmd.Parameters.AddWithValue("@ThoiGianThi", DBNull.Value);

                if (!string.IsNullOrEmpty(loaiDanhGia))
                    cmd.Parameters.AddWithValue("@LoaiDanhGia", loaiDanhGia);
                else
                    cmd.Parameters.AddWithValue("@LoaiDanhGia", DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }
    }
}
