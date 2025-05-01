using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter.DAO
{
    internal class PhieuDangKy_DAO
    {
        private SqlConnection connection;
        string strConnection = "Data Source=LAPTOP-OJ43E27H;Initial Catalog=PTTK;Integrated Security=True;TrustServerCertificate=True";
        private string strSQL;

        
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

        public string ThemPhieuDK(string MaNV)
        {
            string maphieuDK = "";
            SqlCommand cmd = new SqlCommand("ThemPhieuDK", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    maphieuDK = reader.GetString(0);
                }
            }
            return maphieuDK;
        }

        public void XoaPhieuDK()
        {
            // TODO: Xóa phiếu đăng ký khỏi CSDL
        }

        public DataTable LayTTPhieuDK(string maPhieuDK)
        {
            // TODO: Lấy thông tin phiếu đăng ký theo mã
            return new DataTable();
        }

        public DataTable LayTTPhieuDK(string maKH, string trangThai)
        {
            // TODO: Lấy danh sách phiếu đăng ký theo mã KH và trạng thái
            return new DataTable();
        }

        public string DangKyLichThi(string maPhieuDK, string maLichThi)
        {
            string ketQua = "OK";
            SqlCommand cmd = new SqlCommand("DangKyLichThi", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieuDK", maPhieuDK);
            cmd.Parameters.AddWithValue("@MaLichThi", maLichThi);

            try
            {
                cmd.ExecuteNonQuery(); // SP không trả về kết quả
            }
            catch (SqlException ex)
            {
                ketQua = ex.Message; // Bắt RAISERROR bên trong SP
            }

            return ketQua;
        }

        public DataTable LayDSDaThanhToan(string maKH)
        {
            // TODO: Lấy danh sách phiếu đăng ký đã thanh toán
            return new DataTable();
        }

        public void CapNhatMaKH(string maPhieuDK, string maKH)
        {
            string strSQL = "UPDATE PhieuDangKy SET MaKhachHang = @MaKH WHERE MaPhieuDK = @MaPhieuDK";
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            cmd.Parameters.AddWithValue("@MaKH", maKH);
            cmd.Parameters.AddWithValue("@MaPhieuDK", maPhieuDK);
            cmd.ExecuteNonQuery();
        }
    }
}
