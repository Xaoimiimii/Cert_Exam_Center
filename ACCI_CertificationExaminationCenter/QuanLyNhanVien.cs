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
    public partial class QuanLyNhanVien : UserControl
    {
        private MainForm mainForm;
        public QuanLyNhanVien(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;

        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlTraCuuNhanVien_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new TraCuuNhanVien(mainForm));
        }

        private void pnlThemNhanVien_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new ThemNhanVien(mainForm));
        }

        private void pnlXoaNhanVien_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new TraCuuNhanVien(mainForm));
        }

        private void pnlChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new TraCuuNhanVien(mainForm));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlTraCuuNhanVien_Click(sender, e);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            pnlTraCuuNhanVien_Click(sender, e);
        }

        private void pnlTraCuuNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
