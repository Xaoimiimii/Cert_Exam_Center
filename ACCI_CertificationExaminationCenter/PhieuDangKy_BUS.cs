using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter
{
    public class PhieuDangKy_BUS
    {
        // Fields
        private string MaPhieuDK;
        private DateTime NgayLap;
        private string TrangThaiThanhToan;
        private string MaNVLap;
        private string MaLichThi;
        private string MaKH;
        private PhieuDangKy_DAO dao = new PhieuDangKy_DAO();

        public PhieuDangKy_BUS() { }

        public PhieuDangKy_BUS(string MaNhanVien)
        {
            this.MaNVLap = MaNhanVien;
        }


        // Methods

        public string ThemPhieuDK()
        {
            string MaPhieuDK = "";
            dao.Connect();
            MaPhieuDK = dao.ThemPhieuDK(MaNVLap);
            dao.Disconnect();
            return MaPhieuDK;
        }

        public void XoaPhieuDK()
        {
            // TODO: Implement logic
        }

        public string LayMaPDK()
        {
            // TODO: Implement logic
            return "";
        }

        public string LayMaKH()
        {
            // TODO: Implement logic
            return "";
        }

        public string LayMaLichThi()
        {
            // TODO: Implement logic
            return "";
        }

        public DataTable LayTTPhieuDK(string maPhieuDK)
        {
            // TODO: Implement logic
            return new DataTable();
        }

        public DataTable LayTTPhieuDK(string maKH, string trangThai)
        {
            // TODO: Implement logic
            return new DataTable();
        }

        public void CapNhatMaKH(string maPhieuDK, string maKH)
        {
            // TODO: Implement logic
        }

        public bool DangKyLichThi(string maLichThi)
        {
            // TODO: Implement logic
            return false;
        }

        public DataTable LayDSDaThanhToan(string maKH)
        {
            // TODO: Implement logic
            return new DataTable();
        }
    }
}
