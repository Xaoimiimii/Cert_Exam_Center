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
    public partial class ThemNhanVien : UserControl
    {
        private MainForm mainForm;
        public ThemNhanVien(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.Items.Add("Khác");

            cbbChucVu.Items.Add("Nhân viên nhập liệu");
            cbbChucVu.Items.Add("Nhân viên tiếp nhận");
            cbbChucVu.Items.Add("Nhân viên");
        }

        private void cbbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

