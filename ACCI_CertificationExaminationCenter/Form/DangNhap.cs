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
    public partial class DangNhap : Form
    {
        private string tenDangNhap;
        private string matKhau;
        private string vaiTro;

        public DangNhap()
        {
            InitializeComponent();
        }

        public void btnDangNhap_Click(object sender, EventArgs e)
        {
            tenDangNhap = txtTenDangNhap.Text;
            matKhau = txtMatKhau.Text;

            if (DangNhap_BUS.KiemTraDangNhap(tenDangNhap, matKhau))
            {
                vaiTro = DangNhap_BUS.LayVaiTro(tenDangNhap);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string LayTenDangNhap()
        {
            return tenDangNhap;
        }

        public string LayVaiTro()
        {
            return vaiTro;
        }
    }
}
