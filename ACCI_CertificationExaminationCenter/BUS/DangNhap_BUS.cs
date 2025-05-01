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

            TaiKhoan_DAO taiKhoan_DAO = new TaiKhoan_DAO();
            taiKhoan_DAO.Connect();
            result = taiKhoan_DAO.KiemTraTaiKhoan(tenDangNhap, matKhau);
            taiKhoan_DAO.Disconnect();

            return result;
        }

        public static string LayVaiTro(string tenDangNhap)
        {
            NhanVien_DAO nhanVien_DAO = new NhanVien_DAO();
            nhanVien_DAO.Connect();
            DataTable dt = nhanVien_DAO.LayTTNhanVien(tenDangNhap);
            nhanVien_DAO.Disconnect();

            if (dt.Rows.Count > 0) return dt.Rows[0][7].ToString();
            else return "";
        }
    }
}
