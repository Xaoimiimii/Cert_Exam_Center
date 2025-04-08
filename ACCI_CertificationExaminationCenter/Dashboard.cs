namespace ACCI_CertificationExaminationCenter
{
    public partial class Dashboard : Form
    {
        bool menuExpand = false;
        bool paymentExpand = false;

        public Dashboard()
        {
            InitializeComponent();
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
    }
}
