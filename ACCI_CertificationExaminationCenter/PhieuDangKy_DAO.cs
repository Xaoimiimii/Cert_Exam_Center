using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter
{
    internal class PhieuDangKy_DAO
    {
        private SqlConnection connection;
        string strConnection = "Data Source=192.168.1.109,1433;" +
                       "Initial Catalog=PTTK;" +
                       "User ID=sa;" +
                       "Password=Lucia.N123;" +
                       "TrustServerCertificate=True;";
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

        public string ThemPhieuDK(string MaNhanVien)
        {
            string maphieuDK = "";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("ThemPhieuDK", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", MaNhanVien);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        maphieuDK = reader.GetString(0); // Lấy cột đầu tiên (MaPhieuDK)
                    }
                }
            }
            finally
            {
                Disconnect();
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

        public void CapNhatMaKH(string maPhieuDK, string maKH)
        {
            // TODO: Cập nhật mã khách hàng cho phiếu đăng ký
        }

        public bool DangKyLichThi(string maPhieuDK, string maLichThi)
        {
            // TODO: Đăng ký lịch thi cho phiếu đăng ký
            return false;
        }

        public DataTable LayDSDaThanhToan(string maKH)
        {
            // TODO: Lấy danh sách phiếu đăng ký đã thanh toán
            return new DataTable();
        }
    }
}
