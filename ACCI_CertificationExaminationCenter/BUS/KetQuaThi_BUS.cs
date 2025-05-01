using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCI_CertificationExaminationCenter.DAO;

namespace ACCI_CertificationExaminationCenter.BUS
{
    public class KetQuaThi_BUS
    {
        private string MaKetQuaThi { get; set; }
        private string SoBaoDanh { get; set; }
        private int DiemBaiThi { get; set; }
        private DateTime NgayThi { get; set; }
        private bool KetQua { get; set; }

        private KetQuaThi_DAO dao = new KetQuaThi_DAO();


        public void ThemKetQuaThi(string SoBaoDanh, int Diem, DateTime? NgayNhanChungChi, string nhanVienNhap)
        {
            dao.Connect();
            dao.ThemKQThi(SoBaoDanh, Diem, NgayNhanChungChi, nhanVienNhap);
            dao.Disconnect();
        }

    }

}