using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter
{
    public class LichThi_BUS
    {
        public string MaLichThi { get; set; }
        public DateTime NgayThi { get; set; }
        public TimeSpan ThoiGianThi { get; set; }
        public int SoLuongToiDa { get; set; }
        public int SoLuongDaDK { get; set; }
        public string LoaiDanhGia { get; set; }

        private LichThi_DAO dao = new LichThi_DAO();

        public List<LichThi_BUS> LayDSLichThi()
        {
            DataTable dt = dao.LayDSLichThi();
            List<LichThi_BUS> lichThiList = new List<LichThi_BUS>();

            foreach (DataRow row in dt.Rows)
            {
                lichThiList.Add(ChuyenDataRowThanhLichThi(row));
            }

            return lichThiList;
        }


        public List<LichThi_BUS> LayTTLichThi(string maLichThi)
        {
            DataTable dt = dao.LayTTLichThi(maLichThi);
            List<LichThi_BUS> lichThiList = new List<LichThi_BUS>();

            foreach (DataRow row in dt.Rows)
            {
                lichThiList.Add(ChuyenDataRowThanhLichThi(row));
            }

            return lichThiList;
        }


        public List<LichThi_BUS> LayTTLichThi(DateTime? ngayThi, TimeSpan? thoiGianThi, string? loaiDanhGia)
        {
            DataTable dt = dao.LayTTLichThi(ngayThi, thoiGianThi, loaiDanhGia);
            List<LichThi_BUS> lichThiList = new List<LichThi_BUS>();

            foreach (DataRow row in dt.Rows)
            {
                lichThiList.Add(ChuyenDataRowThanhLichThi(row));
            }

            return lichThiList;
        }


        private LichThi_BUS ChuyenDataRowThanhLichThi(DataRow row)
        {
            return new LichThi_BUS
            {
                MaLichThi = row["MaLichThi"].ToString(),
                NgayThi = Convert.ToDateTime(row["NgayThi"]),
                ThoiGianThi = (TimeSpan)row["ThoiGianThi"],
                SoLuongToiDa = Convert.ToInt32(row["SoLuongToiDa"]),
                SoLuongDaDK = Convert.ToInt32(row["SoLuongDaDK"]),
                LoaiDanhGia = row["LoaiDanhGia"].ToString()
            };
        }
    }
}
