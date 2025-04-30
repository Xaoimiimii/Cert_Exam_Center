using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACCI_CertificationExaminationCenter.BUS;

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

        private void select_exam_button_Click(object sender, EventArgs e)
        {
            TraCuuLichThi form = new TraCuuLichThi();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataTable lichThi = form.LayLichThiDaChon();
                DataRow dataRow = lichThi.Rows[0];
                txtMaLichThi.Text = dataRow[0].ToString();
                txtNgayThi.Text = Convert.ToDateTime(dataRow[1]).ToString("dd/MM/yyyy");
                txtThoiGianThi.Text = ((TimeSpan)dataRow[2]).ToString(@"hh\:mm");
                txtLoaiDGNL.Text = dataRow[3].ToString();
            }
        }
    }
}
