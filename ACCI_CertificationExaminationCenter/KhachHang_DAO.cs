using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter
{
    internal class KhachHang_DAO
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

            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }

        public DataTable LayTTKH(string MaKH)
        {
            strSQL = $"SELECT * FROM KHACHHANG WHERE MaKhachHang = {MaKH}";
            SqlDataAdapter adapter = new SqlDataAdapter(strSQL, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable LayTTKH(string sdt, string email)
        {
            if (sdt == "")
                strSQL = "SELECT * FROM KHACHHANG WHERE Email = @Email";
            else if (email == "")
                strSQL = "SELECT * FROM KHACHHANG WHERE SoDienThoai = @SDT";
            else
                strSQL = "SELECT * FROM KHACHHANG WHERE SoDienThoai = @SDT AND Email = @Email";

            SqlCommand cmd = new SqlCommand(strSQL, connection);
            cmd.Parameters.AddWithValue("@SDT", sdt);
            cmd.Parameters.AddWithValue("@Email", email);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public string ThemKH(string hoTen, string gioiTinh, string sdt, string email, string diaChi, string tenDonVi)
        {
            string MaKhachHang = "";
            SqlCommand cmd = new SqlCommand("ThemKhachHang", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@HoTen", hoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
            cmd.Parameters.Add("@TenDonVi", SqlDbType.NVarChar, 50).Value = (object)tenDonVi ?? DBNull.Value;


            SqlParameter outputMaKH = new SqlParameter("@MaKhachHang", SqlDbType.Char, 8);
            outputMaKH.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputMaKH);

            cmd.ExecuteNonQuery();

            MaKhachHang = outputMaKH.Value.ToString();

            return MaKhachHang;
        }

        public void CapNhatDiaChiKH(string maKH, string diaChi)
        {
            strSQL = "UPDATE KHACHHANG SET DiaChi = @DiaChi WHERE MaKhachHang = @MaKH";
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            if (string.IsNullOrWhiteSpace(diaChi))
                cmd.Parameters.AddWithValue("@DiaChi", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);

            cmd.Parameters.AddWithValue("@MaKH", maKH);
            cmd.ExecuteNonQuery();
        }

        public void CapNhatTenDonViKH(string maKH, string tenDonVi)
        {
            strSQL = "UPDATE KHACHHANG SET TenDonVi = @TenDonVi WHERE MaKhachHang = @MaKH";
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            cmd.Parameters.AddWithValue("@TenDonVi", tenDonVi);
            cmd.Parameters.AddWithValue("@MaKH", maKH);
            cmd.ExecuteNonQuery();
        }
    }
}
