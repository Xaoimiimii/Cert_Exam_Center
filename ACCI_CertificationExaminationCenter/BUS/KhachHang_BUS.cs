using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCI_CertificationExaminationCenter.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ACCI_CertificationExaminationCenter.BUS
{
    internal class KhachHang_BUS
    {
        private string HoTenKH;
        private string GioiTinhKH;
        private string SDTKH;
        private string EmailKH;
        private string DiaChiKH;
        private string TenDonViKH;

        private KhachHang_DAO dao = new KhachHang_DAO();

        public KhachHang_BUS() { }

        public KhachHang_BUS(string hoTen, string gioiTinh, string sdt, string email, string diaChi, string tenDonVi)
        {
            HoTenKH = hoTen;
            GioiTinhKH = gioiTinh;
            SDTKH = sdt;
            EmailKH = email;
            DiaChiKH = diaChi;
            TenDonViKH = tenDonVi;
        }

        public static DataTable LayTTKH(string MaKH)
        {
            KhachHang_DAO dao = new KhachHang_DAO();
            dao.Connect();
            DataTable dt = dao.LayTTKH(MaKH);
            dao.Disconnect();
            return dt;
        }

        public static DataTable LayTTKH(string SDT, string Email)
        {
            KhachHang_DAO dao = new KhachHang_DAO();
            dao.Connect();
            DataTable dt = dao.LayTTKH(SDT, Email);
            dao.Disconnect();
            return dt;
        }

        public string ThemKH()
        {
            KhachHang_DAO dao = new KhachHang_DAO();
            dao.Connect();
            string MaKhacHang = dao.ThemKH(HoTenKH, GioiTinhKH, SDTKH, EmailKH, DiaChiKH, TenDonViKH);
            dao.Disconnect();
            return MaKhacHang;
        }
    }
}
