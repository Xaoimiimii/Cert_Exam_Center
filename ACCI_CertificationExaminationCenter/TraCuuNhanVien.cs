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
    public partial class TraCuuNhanVien : UserControl
    {
        private MainForm mainForm;
        public TraCuuNhanVien(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;

            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.Items.Add("Khác");

            cbbChucVu.Items.Add("Nhân viên nhập liệu");
            cbbChucVu.Items.Add("Nhân viên tiếp nhận");
            cbbChucVu.Items.Add("Nhân viên");
        }

        private void ChinhSuaThongTinNV_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            pnlThongTinNV.Visible = true;
        }
    }
}
