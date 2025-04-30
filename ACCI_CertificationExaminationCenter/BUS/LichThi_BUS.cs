using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCI_CertificationExaminationCenter.DAO;

namespace ACCI_CertificationExaminationCenter.BUS
{
    public class LichThi_BUS
    {
        private string MaLichThi { get; set; }
        private DateTime NgayThi { get; set; }
        private TimeSpan ThoiGianThi { get; set; }
        private int SoLuongToiDa { get; set; }
        private int SoLuongDaDK { get; set; }
        private string LoaiDanhGia { get; set; }

        private LichThi_DAO dao = new LichThi_DAO();

        public DataTable LayDSLichThi()
        {
            return dao.LayDSLichThi();
        }

        public DataTable LayTTLichThi(string maLichThi)
        {
            return dao.LayTTLichThi(maLichThi);
        }

        public DataTable LayTTLichThi(DateTime? ngayThi, TimeSpan? thoiGianThi, string? loaiDanhGia)
        {
            return dao.LayTTLichThi(ngayThi, thoiGianThi, loaiDanhGia);
        }
    }
}
