namespace ACCI_CertificationExaminationCenter
{
    public partial class MainForm : Form
    {
        bool menuExpand = false;
        bool paymentExpand = false;
        public bool isInDashboard = false;
        public bool isInRegister = false;
        public bool isInSelectExam = false;
        public bool isInExamineeResults = false;
        public bool isInCertificate = false;

        public MainForm()
        {
            InitializeComponent();
            LoadControl(new DashboardControl(this));
            UpdateStatus("Dashboard");
        }

        public void LoadControl(UserControl control)
        {
            main_panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            main_panel.Controls.Add(control);
        }

        public void UpdateStatus(string currentActivity)
        {
            isInDashboard = false;
            isInRegister = false;
            isInSelectExam = false;
            isInExamineeResults = false;
            isInCertificate = false;

            dashboard_menu_pictureBox.Image = Properties.Resources.dashboard_white;
            register_menu_pictureBox.Image = Properties.Resources.register_white;
            results_menu_pictureBox.Image = Properties.Resources.grade_white;
            certificate_menu_pictureBox.Image = Properties.Resources.cert_white;

            if (currentActivity == "Dashboard")
            {
                isInDashboard = true;
                dashboard_menu_pictureBox.Image = Properties.Resources.dashboard_green;
            }
            else if (currentActivity == "Register")
            {
                isInRegister = true;
                register_menu_pictureBox.Image = Properties.Resources.register_green;
            }
            else if (currentActivity == "SelectExam")
            {
                isInSelectExam = true;
            }
            else if (currentActivity == "ExamineeResults")
            {
                isInExamineeResults = true;
                results_menu_pictureBox.Image = Properties.Resources.grade_green;
            }
            else if (currentActivity == "Certificate")
            {
                isInCertificate = true;
                certificate_menu_pictureBox.Image = Properties.Resources.cert_green;
            }
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                nav_drawer_flowLayoutPanel.Width -= 10;
                if (nav_drawer_flowLayoutPanel.Width <= 98)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
            else
            {
                nav_drawer_flowLayoutPanel.Width += 10;
                if (nav_drawer_flowLayoutPanel.Width >= 318)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
        }

        private void paymentTransition_Tick(object sender, EventArgs e)
        {
            if (paymentExpand)
            {
                payment_menu_group_flowLayoutPanel.Height -= 10;
                if (payment_menu_group_flowLayoutPanel.Height <= 80)
                {
                    paymentTransition.Stop();
                    paymentExpand = false;
                }
            }
            else
            {
                if (menuExpand)
                {
                    payment_register_menu_pictureBox.Margin = new Padding(76, 24, 3, 3);
                    payment_extensive_menu_pictureBox.Margin = new Padding(76, 24, 3, 3);
                }
                else
                {
                    payment_register_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
                    payment_extensive_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
                }
                    payment_menu_group_flowLayoutPanel.Height += 10;
                if (payment_menu_group_flowLayoutPanel.Height >= 240)
                {
                    paymentTransition.Stop();
                    paymentExpand = true;
                }
            }
        }

        private void show_menu_pictureBox_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            show_menu_pictureBox.Visible = false;
        }

        private void close_menu_pictureBox_Click(object sender, EventArgs e)
        {
            show_menu_pictureBox.Visible = true;
            menuTransition.Start();

            if (paymentExpand)
            {
                paymentTransition.Start();
            }
        }

        private void payment_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            paymentTransition.Start();
        }

        private void payment_menu_pictureBox_Click(object sender, EventArgs e)
        {
            paymentTransition.Start();
        }

        private void payment_menu_label_Click(object sender, EventArgs e)
        {
            paymentTransition.Start();
        }

        private void dashboard_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            UpdateStatus("Dashboard");
            LoadControl(new DashboardControl(this));
        }

        private void dashboard_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            UpdateStatus("Dashboard");
            LoadControl(new DashboardControl(this));
        }

        private void dashboard_menu_label_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            UpdateStatus("Dashboard");
            LoadControl(new DashboardControl(this));
        }

        private void register_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInRegister)
            {
                return;
            }
            UpdateStatus("Register");
            LoadControl(new CreateRegisterFormControl(this));
        }

        private void register_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInRegister)
            {
                return;
            }
            UpdateStatus("Register");
            LoadControl(new CreateRegisterFormControl(this));
        }

        private void register_menu_label_Click(object sender, EventArgs e)
        {
            if (isInRegister)
            {
                return;
            }
            UpdateStatus("Register");
            LoadControl(new CreateRegisterFormControl(this));
        }

        private void results_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInExamineeResults)
            {
                return;
            }
            UpdateStatus("ExamineeResults");
            LoadControl(new ExamineeResultsControl(this));
        }

        private void results_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInExamineeResults)
            {
                return;
            }
            UpdateStatus("ExamineeResults");
            LoadControl(new ExamineeResultsControl(this));
        }

        private void results_menu_label_Click(object sender, EventArgs e)
        {
            if (isInExamineeResults)
            {
                return;
            }
            UpdateStatus("ExamineeResults");
            LoadControl(new ExamineeResultsControl(this));
        }

        private void certificate_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInCertificate)
            {
                return;
            }
            UpdateStatus("Certificate");
            LoadControl(new UpdateCertificateStatusControl(this));
        }

        private void certificate_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInCertificate)
            {
                return;
            }
            UpdateStatus("Certificate");
            LoadControl(new UpdateCertificateStatusControl(this));
        }

        private void certificate_menu_label_Click(object sender, EventArgs e)
        {
            if (isInCertificate)
            {
                return;
            }
            UpdateStatus("Certificate");
            LoadControl(new UpdateCertificateStatusControl(this));
        }

        private void out_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {

        }

        private void out_menu_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void out_menu_label_Click(object sender, EventArgs e)
        {

        }
    }
}
