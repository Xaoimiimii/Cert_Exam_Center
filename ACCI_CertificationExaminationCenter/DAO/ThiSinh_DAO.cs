using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter.DAO
{
    internal class ThiSinh_DAO
    {
        private SqlConnection connection;
        //private string strConnection = "Data Source=.;Initial Catalog=TenCSDL;Integrated Security=True";
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

            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }

        public DataTable LayTTThiSinh(string MaPDK, string MaTS)
        {
            strSQL = "SELECT * FROM ThiSinh WHERE MaPhieuDK = @MaPhieuDK AND MaThiSinh = @MaThiSinh";
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            cmd.Parameters.AddWithValue("@MaPhieuDK", MaPDK);
            cmd.Parameters.AddWithValue("@MaThiSinh", MaTS);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void ThemThiSinh(string maPDK, string hoTen, string gioiTinh, string sdt, string email, string diaChi, DateTime ngaySinh)
        {
            //SqlCommand cmd = new SqlCommand("ThemThiSinh", connection);
            //cmd.Parameters.AddWithValue("@MaPhieuDK", maPDK);
            //cmd.Parameters.AddWithValue("@HoTen", hoTen);
            //cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            //cmd.Parameters.AddWithValue("@SDT", sdt);
            //cmd.Parameters.AddWithValue("@Email", email);
            //cmd.Parameters.AddWithValue("@DiaChi", diaChi);
            //cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh.Date);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            SqlCommand cmd = new SqlCommand("ThemThiSinh", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieuDK", maPDK);
            cmd.Parameters.AddWithValue("@HoTen", hoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh.Date);
            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
            cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
            cmd.Parameters.AddWithValue("@Email", email);

            cmd.ExecuteNonQuery(); // 
        }

        public void XoaThiSinh(string MaPDK, string Email)
        {
            strSQL = "DELETE FROM ThiSinh WHERE MaPhieuDK = @MaPhieuDK AND Email = @Email";
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            cmd.Parameters.AddWithValue("@MaPhieuDK", MaPDK);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.ExecuteNonQuery();
        }

        public bool KTraEmailThiSinh(string MaPDK, string Email)
        {
            strSQL = "SELECT COUNT(*) FROM ThiSinh WHERE MaPhieuDK = @MaPhieuDK AND Email = @Email";
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            cmd.Parameters.AddWithValue("@MaPhieuDK", MaPDK);
            cmd.Parameters.AddWithValue("@Email", Email);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        public DataTable LayDSThiSinhDK(string MaPDK)
        {
            strSQL = "SELECT * FROM ThiSinh WHERE MaPhieuDK = @MaPhieuDK";
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            cmd.Parameters.AddWithValue("@MaPhieuDK", MaPDK);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
