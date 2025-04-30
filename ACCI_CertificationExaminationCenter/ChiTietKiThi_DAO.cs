using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ACCI_CertificationExaminationCenter
{
    internal class ChiTietKiThi_DAO
    {
        private SqlConnection connection;
        private string strConnection = "Data Source=LAPTOP-RRQH8TCQ;Initial Catalog=PTTK;Integrated Security=True;TrustServerCertificate=True";
        private void Connect()
        {
            if (connection == null)
                connection = new SqlConnection(strConnection);

            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        private void Disconnect()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }

        public DataTable LayChiTietKiThi (string sbd)
        {

            if (string.IsNullOrWhiteSpace(sbd))
            {
                return null;
            }
            DataTable dt = new DataTable();
            try
            {
                Connect();
                connection.InfoMessage += (sender, e) =>
                {
                    throw new Exception(e.Message);//Để bắt lỗi
                };

                using (SqlCommand cmd = new SqlCommand("LayChiTietKiThi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SBD", sbd);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
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
            finally
            {
                Disconnect();
            }
            return dt;
        }

    }
}
