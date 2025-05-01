using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ACCI_CertificationExaminationCenter.DAO
{
    internal class ChiTietLanThi_DAO
    {
        private SqlConnection connection;
        private string strConnection = @"Server=.;Database=PTTK;Trusted_Connection=True;TrustServerCertificate=True";

        public void Connect ()
        {
            connection = new SqlConnection (strConnection);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void Disconnect ()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public DataTable LayTTChiTietLanThi (string SoBaoDanh)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("LayTTChiTietLanThi", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SoBaoDanh", SoBaoDanh);

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
