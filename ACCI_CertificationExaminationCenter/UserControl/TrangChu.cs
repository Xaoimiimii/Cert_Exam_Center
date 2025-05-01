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
    public partial class TrangChu : UserControl
    {
        private MainForm mainForm;

        public TrangChu(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            lTieuDe.Location = bg_pictureBox.PointToClient(lTieuDe.PointToScreen(Point.Empty));
            lNgayThangNam.Location = bg_pictureBox.PointToClient(lNgayThangNam.PointToScreen(Point.Empty));
            lTieuDe.Parent = bg_pictureBox;
            lNgayThangNam.Parent = bg_pictureBox;
            lTieuDe.BackColor = Color.Transparent;
            lNgayThangNam.BackColor = Color.Transparent;
            lTieuDe.Text = "Xin chào, " + mainForm.tenDangNhap;
            string dayOfWeek = DateTime.Now.ToString("dddd");
            if (dayOfWeek == "Monday") dayOfWeek = "Thứ 2";
            else if (dayOfWeek == "Tuesday") dayOfWeek = "Thứ 3";
            else if (dayOfWeek == "Wednesday") dayOfWeek = "Thứ 4";
            else if (dayOfWeek == "Thursday") dayOfWeek = "Thứ 5";
            else if (dayOfWeek == "Friday") dayOfWeek = "Thứ 6";
            else if (dayOfWeek == "Saturday") dayOfWeek = "Thứ 7";
            else if (dayOfWeek == "Sunday") dayOfWeek = "Chủ nhật";
            lNgayThangNam.Text = dayOfWeek + ", " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void register_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Register");
            mainForm.LoadControl(new LapPhieuDangKy(mainForm));
        }

        private void register_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Register");
            mainForm.LoadControl(new LapPhieuDangKy(mainForm));
        }

        private void register_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Register");
            mainForm.LoadControl(new LapPhieuDangKy(mainForm));
        }

        private void payment_register_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Payment");
            mainForm.LoadControl(new ThanhToanPhieuDangKy(mainForm));
        }

        private void payment_register_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Payment");
            mainForm.LoadControl(new ThanhToanPhieuDangKy(mainForm));
        }

        private void payment_register_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Payment");
            mainForm.LoadControl(new ThanhToanPhieuDangKy(mainForm));
        }

        private void results_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Results");
            mainForm.LoadControl(new ExamineeResultsControl(mainForm));
        }

        private void result_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Results");
            mainForm.LoadControl(new ExamineeResultsControl(mainForm));
        }

        private void results_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Results");
            mainForm.LoadControl(new ExamineeResultsControl(mainForm));
        }

        private void certificate_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Certificate");
            mainForm.LoadControl(new UpdateCertificateStatusControl(mainForm));
        }

        private void certificate_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Certificate");
            mainForm.LoadControl(new UpdateCertificateStatusControl(mainForm));
        }

        private void certificate_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Certificate");
            mainForm.LoadControl(new UpdateCertificateStatusControl(mainForm));
        }

        private void register_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            register_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void register_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            register_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void register_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            register_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void register_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            register_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void register_label_MouseEnter(object sender, EventArgs e)
        {
            register_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void register_label_MouseLeave(object sender, EventArgs e)
        {
            register_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void payment_register_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            payment_register_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void payment_register_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            payment_register_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void payment_register_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            payment_register_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void payment_register_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            payment_register_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void payment_register_label_MouseEnter(object sender, EventArgs e)
        {
            payment_register_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void payment_register_label_MouseLeave(object sender, EventArgs e)
        {
            payment_register_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void payment_extend_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            payment_extend_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void payment_extend_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            payment_extend_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void payment_extend_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            payment_extend_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void payment_extend_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            payment_extend_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void payment_extend_label_MouseEnter(object sender, EventArgs e)
        {
            payment_extend_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void payment_extend_label_MouseLeave(object sender, EventArgs e)
        {
            payment_extend_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void extend_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            extend_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void extend_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            extend_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void extend_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            extend_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void extend_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            extend_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void extend_label_MouseEnter(object sender, EventArgs e)
        {
            extend_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void extend_label_MouseLeave(object sender, EventArgs e)
        {
            extend_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void results_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            results_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void results_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            results_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void result_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            results_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void result_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            results_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void results_label_MouseEnter(object sender, EventArgs e)
        {
            results_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void results_label_MouseLeave(object sender, EventArgs e)
        {
            results_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void certificate_guna2ShadowPanel_MouseEnter(object sender, EventArgs e)
        {
            certificate_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void certificate_guna2ShadowPanel_MouseLeave(object sender, EventArgs e)
        {
            certificate_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void certificate_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            certificate_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void certificate_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            certificate_guna2ShadowPanel.FillColor = Color.LightCyan;
        }

        private void certificate_label_MouseEnter(object sender, EventArgs e)
        {
            certificate_guna2ShadowPanel.FillColor = Color.PowderBlue;
        }

        private void certificate_label_MouseLeave(object sender, EventArgs e)
        {
            certificate_guna2ShadowPanel.FillColor = Color.LightCyan;
        }


    }
}
