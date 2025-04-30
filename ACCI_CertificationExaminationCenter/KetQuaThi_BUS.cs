using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCI_CertificationExaminationCenter
{
    public  class KetQuaThi_BUS
    {
        private string MaKetQuaThi { get; set; }
        private string SoBaoDanh { get; set; }
        private int DiemBaiThi { get; set; }   
        private DateTime NgayThi { get; set; }
        private Boolean KetQua { get; set; }

        private KetQuaThi_DAO dao = new KetQuaThi_DAO();

        public void CapNhatTrangThaiNhan(string sbd)
        {
            dao.CapNhatTrangThaiNhan(sbd);
        }

    }

}
