namespace ACCI_CertificationExaminationCenter
{
    public partial class MainForm : Form
    {
        bool menuExpand = false;
        bool paymentExpand = false;
        bool isInDashboard = true;
        bool isInRegister = false;
        bool isInSelectExam = false;
        bool isInExamineeResults = false;
        bool isInCertificate = false;

        public MainForm()
        {
            InitializeComponent();
            LoadControl(new DashboardControl());
        }

        private void LoadControl(UserControl control)
        {
            main_panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            main_panel.Controls.Add(control);
        }

        private void UpdateStatus(string currentActivity)
        {
            isInDashboard = false;
            isInRegister = false;
            isInSelectExam = false;
            isInExamineeResults = false;
            isInCertificate = false;

            if (currentActivity == "Dashboard")
            {
                isInDashboard = true;
            }
            else if (currentActivity == "Register")
            {
                isInRegister = true;
            }
            else if (currentActivity == "SelectExam")
            {
                isInSelectExam = true;
            }
            else if (currentActivity == "ExamineeResults")
            {
                isInExamineeResults = true;
            }
            else if (currentActivity == "Certificate")
            {
                isInCertificate = true;
            }
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                nav_drawer_flowLayoutPanel.Width -= 10;
                if (nav_drawer_flowLayoutPanel.Width <= 96)
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
                    payment_register_menu_pictureBox.Margin = new Padding(60, 24, 3, 3);
                    payment_extension_menu_pictureBox.Margin = new Padding(60, 24, 3, 3);
                }
                else
                {
                    payment_register_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
                    payment_extension_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
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
            isInDashboard = true;
            LoadControl(new DashboardControl());
            UpdateStatus("Dashboard");
        }

        private void dashboard_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            isInDashboard = true;
            LoadControl(new DashboardControl());
            UpdateStatus("Dashboard");
        }

        private void dashboard_menu_label_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            isInDashboard = true;
            LoadControl(new DashboardControl());
            UpdateStatus("Dashboard");
        }

        private void register_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInRegister)
            {
                return;
            }
            isInRegister = true;
            LoadControl(new CreateRegistrationControl());
            UpdateStatus("Register");
        }

        private void register_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInRegister)
            {
                return;
            }
            isInRegister = true;
            LoadControl(new CreateRegistrationControl());
            UpdateStatus("Register");
        }

        private void register_menu_label_Click(object sender, EventArgs e)
        {
            if (isInRegister)
            {
                return;
            }
            isInRegister = true;
            LoadControl(new CreateRegistrationControl());
            UpdateStatus("Register");
        }

        private void results_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInExamineeResults)
            {
                return;
            }
            isInExamineeResults = true;
            LoadControl(new ExamineeResultsControl());
            UpdateStatus("ExamineeResults");
        }

        private void results_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInExamineeResults)
            {
                return;
            }
            isInExamineeResults = true;
            LoadControl(new ExamineeResultsControl());
            UpdateStatus("ExamineeResults");
        }

        private void results_menu_label_Click(object sender, EventArgs e)
        {
            if (isInExamineeResults)
            {
                return;
            }
            isInExamineeResults = true;
            LoadControl(new ExamineeResultsControl());
            UpdateStatus("ExamineeResults");
        }

        private void certificate_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInCertificate)
            {
                return;
            }
            isInCertificate = true;
            LoadControl(new FindCertificateControl());
            UpdateStatus("Certificate");
        }

        private void certificate_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInCertificate)
            {
                return;
            }
            isInCertificate = true;
            LoadControl(new FindCertificateControl());
            UpdateStatus("Certificate");
        }

        private void certificate_menu_label_Click(object sender, EventArgs e)
        {
            if (isInCertificate)
            {
                return;
            }
            isInCertificate = true;
            LoadControl(new FindCertificateControl());
            UpdateStatus("Certificate");
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
