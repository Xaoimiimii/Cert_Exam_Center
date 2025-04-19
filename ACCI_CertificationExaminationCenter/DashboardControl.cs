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
    public partial class DashboardControl : UserControl
    {
        private MainForm mainForm;

        public DashboardControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            hello_label.Parent = bg_pictureBox;
            date_label.Parent = bg_pictureBox;
            hello_label.BackColor = Color.Transparent;
            date_label.BackColor = Color.Transparent;
        }

        private void register_guna2ShadowPanel_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Register");
            mainForm.LoadControl(new CreateRegisterFormControl(mainForm));
        }

        private void register_pictureBox_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Register");
            mainForm.LoadControl(new CreateRegisterFormControl(mainForm));
        }

        private void register_label_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Register");
            mainForm.LoadControl(new CreateRegisterFormControl(mainForm));
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

        private void pnlTest_Click(object sender, EventArgs e)
        {
            mainForm.LoadControl(new QuanLyNhanVien(mainForm));
        }

    }
}
