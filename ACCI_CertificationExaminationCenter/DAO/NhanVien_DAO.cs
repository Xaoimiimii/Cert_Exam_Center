using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ACCI_CertificationExaminationCenter.DAO
{
    internal class NhanVien_DAO
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

        public DataTable LayTTNhanVien(string maNV)
        {
            SqlCommand cmd = new SqlCommand("LayTTNhanVien", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhanVien", maNV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
