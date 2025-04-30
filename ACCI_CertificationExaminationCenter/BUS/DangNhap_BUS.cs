using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCI_CertificationExaminationCenter.DAO;

namespace ACCI_CertificationExaminationCenter.BUS
{
    internal class DangNhap_BUS
    {
        public static bool KiemTraTaiKhoan(string tenDangNhap, string matKhau)
        {
            bool result = false;

            TaiKhoan_DAO.Connect();
            result = TaiKhoan_DAO.KiemTraTaiKhoan(tenDangNhap, matKhau);
            TaiKhoan_DAO.Disconnect();

            return result;
        }

        public static string LayVaiTro(string tenDangNhap)
        {
            NhanVien_DAO.Connect();
            DataTable dt = NhanVien_DAO.LayTTNhanVien(tenDangNhap);
            NhanVien_DAO.Disconnect();

            if (dt.Rows.Count > 0) return dt.Rows[0][7].ToString();
            else return "";
        }
    }
}
