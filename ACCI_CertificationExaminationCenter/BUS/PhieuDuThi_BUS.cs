using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACCI_CertificationExaminationCenter.DAO;

namespace ACCI_CertificationExaminationCenter.BUS
{
    public class PhieuDuThi_BUS
    {
        private string SoBaoDanh { get; set; }
        private string MaThiSinh { get; set; }
        private string MaPhieuDangKy { get; set; }
        private string MaLichThi { get; set; }
        private string MaPhong { get; set; }
        private string TrangThai { get; set; }

        private PhieuDuThi_DAO dao = new PhieuDuThi_DAO();
        public void CapNhatTrangThai(string sbd, string trangThai, string nhanVienCapNhat)
        {
            dao.Connect();
            dao.CapNhatTrangThai(sbd, trangThai, nhanVienCapNhat);
            dao.Disconnect();
        }

    }
}
