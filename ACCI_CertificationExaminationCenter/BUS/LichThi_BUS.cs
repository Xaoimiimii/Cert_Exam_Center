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
        private DateOnly NgayThi { get; set; }
        private TimeOnly ThoiGianThi { get; set; }
        private int SoLuongToiDa { get; set; }
        private int SoLuongDaDK { get; set; }
        private string LoaiDanhGia { get; set; }

        public static DataTable LayDSLichThi()
        {
            LichThi_DAO.Connect();
            DataTable dt = LichThi_DAO.LayDSLichThi();
            LichThi_DAO.Disconnect();
            return dt;
        }

        public static DataTable LayTTLichThi(string maLichThi)
        {
            LichThi_DAO.Connect();
            DataTable dt = LichThi_DAO.LayTTLichThi(maLichThi);
            LichThi_DAO.Disconnect();
            return dt;
        }

        public static DataTable LayTTLichThi(DateOnly? ngayThi, TimeOnly? thoiGianThi, string? loaiDanhGia)
        {
            LichThi_DAO.Connect();
            DataTable dt = LichThi_DAO.LayTTLichThi(ngayThi, thoiGianThi, loaiDanhGia);
            LichThi_DAO.Disconnect();
            return dt;
        }
    }
}
