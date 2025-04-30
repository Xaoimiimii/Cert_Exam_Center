using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCI_CertificationExaminationCenter
{
    public partial class LapPhieuDangKy : UserControl
    {
        private MainForm mainForm;

        public LapPhieuDangKy(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuuLichThi_Click(object sender, EventArgs e)
        {
            TraCuuLichThi form = new TraCuuLichThi();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LichThi_BUS lichThi = form.LichThiDaChon;
                txtMaLichThi.Text = lichThi.MaLichThi;
                txtNgayThi.Text = lichThi.NgayThi.ToString("dd/MM/yyyy");
                txtThoiGianThi.Text = lichThi.ThoiGianThi.ToString(@"hh\:mm");
                txtLoaiDGNL.Text = lichThi.LoaiDanhGia;
            }
        }
    }
}
