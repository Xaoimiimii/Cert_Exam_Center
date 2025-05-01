using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCI_CertificationExaminationCenter.DAO;

namespace ACCI_CertificationExaminationCenter.BUS
{
    internal class ThiSinh_BUS
    {
        private string MaPhieuDK;
        private string HoTenTS;
        private string GioiTinhTS;
        private string SDTTS;
        private string EmailTS;
        private string DiaChiTS;
        private DateTime NgaySinhTS;
        private ThiSinh_DAO dao = new ThiSinh_DAO();

        public ThiSinh_BUS() { }

        public ThiSinh_BUS(string maPDK, string hoTen, string gioiTinh, string sdt, string email, string diaChi, DateTime ngaySinh)
        {
            MaPhieuDK = maPDK;
            HoTenTS = hoTen;
            GioiTinhTS = gioiTinh;
            SDTTS = sdt;
            EmailTS = email;
            DiaChiTS = diaChi;
            NgaySinhTS = ngaySinh;
        }

        public static DataTable LayTTThiSinh(string MaPDK, string MaTS)
        {
            ThiSinh_DAO dao = new ThiSinh_DAO();
            dao.Connect();
            DataTable dt = dao.LayTTThiSinh(MaPDK, MaTS);
            dao.Disconnect();
            return dt;
        }

        public void ThemThiSinh()
        {
            dao.Connect();
            dao.ThemThiSinh(MaPhieuDK, HoTenTS, GioiTinhTS, SDTTS, EmailTS, DiaChiTS, NgaySinhTS);
            dao.Disconnect();
        }

        public static void XoaThiSinh(string MaPDK, string Email)
        {
            ThiSinh_DAO dao = new ThiSinh_DAO();
            dao.Connect();
            dao.XoaThiSinh(MaPDK, Email);
            dao.Disconnect();
        }

        public static bool KTraEmailThiSinh(string MaPDK, string Email)
        {
            ThiSinh_DAO dao = new ThiSinh_DAO();
            dao.Connect();
            bool KetQua = dao.KTraEmailThiSinh(MaPDK, Email);
            dao.Disconnect();
            return KetQua;
        }

        public static DataTable LayDSThiSinhDK(string MaPDK)
        {
            ThiSinh_DAO dao = new ThiSinh_DAO();
            dao.Connect();
            DataTable dt = dao.LayDSThiSinhDK(MaPDK);
            dao.Disconnect();
            return dt;
        }
    }
}
