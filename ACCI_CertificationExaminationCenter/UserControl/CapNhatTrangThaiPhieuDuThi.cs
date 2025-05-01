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
    public partial class CapNhatTrangThaiPhieuDuThi : UserControl
    {
        private MainForm mainForm;
        public CapNhatTrangThaiPhieuDuThi(MainForm mainForm)
        {
            InitializeComponent();

            cbbTrangThai.Items.Add("Đã hoàn thành bài thi");
            cbbTrangThai.Items.Add("Vắng mặt");
            this.mainForm = mainForm;
        }

        private void btnCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            pnlThongTinPDT.Visible = true;
        }

        private void CapNhatTrangThaiPhieuDuThi_Load(object sender, EventArgs e)
        {

        }
    }
}
