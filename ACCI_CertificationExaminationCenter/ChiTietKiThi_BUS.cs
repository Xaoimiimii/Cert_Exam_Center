using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter
{
    internal class ChiTietKiThi_BUS
    {
        private string HoTen { get; set; }
        private string SoBaoDanh { get; set; }
        private string GioiTinh { get; set; }
        private string SoDienThoai { get; set; }    
        private DateTime NgayThi { get; set; }

        private string LoaiDanhGia { get; set; }
        private string TrangThai { get; set; }

        private ChiTietKiThi_DAO dao = new ChiTietKiThi_DAO();

        public DataTable LayChiTietKiThi(string sbd)
        {
            return dao.LayChiTietKiThi(sbd);
        }
    }
}
