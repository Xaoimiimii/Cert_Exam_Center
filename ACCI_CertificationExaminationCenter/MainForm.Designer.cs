namespace ACCI_CertificationExaminationCenter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            nav_drawer_flowLayoutPanel = new FlowLayoutPanel();
            menu_group_panel = new Panel();
            close_menu_pictureBox = new PictureBox();
            show_menu_pictureBox = new PictureBox();
            dashboard_menu_group_flowLayoutPanel = new FlowLayoutPanel();
            dashboard_menu_flowLayoutPanel = new FlowLayoutPanel();
            dashboard_menu_pictureBox = new PictureBox();
            dashboard_menu_label = new Label();
            register_menu_flowLayoutPanel = new FlowLayoutPanel();
            register_menu_pictureBox = new PictureBox();
            register_menu_label = new Label();
            payment_menu_group_flowLayoutPanel = new FlowLayoutPanel();
            payment_menu_flowLayoutPanel = new FlowLayoutPanel();
            payment_menu_pictureBox = new PictureBox();
            payment_menu_label = new Label();
            payment_register_menu_flowLayoutPanel = new FlowLayoutPanel();
            payment_register_menu_pictureBox = new PictureBox();
            payment_register_menu_label = new Label();
            payment_extension_menu_flowLayoutPanel = new FlowLayoutPanel();
            payment_extensive_menu_pictureBox = new PictureBox();
            payment_extension_menu_label = new Label();
            extensive_menu_flowLayoutPanel = new FlowLayoutPanel();
            extensive_menu_pictureBox = new PictureBox();
            extensive_menu_label = new Label();
            results_menu_flowLayoutPanel = new FlowLayoutPanel();
            results_menu_pictureBox = new PictureBox();
            results_menu_label = new Label();
            certificate_menu_flowLayoutPanel = new FlowLayoutPanel();
            certificate_menu_pictureBox = new PictureBox();
            certificate_menu_label = new Label();
            setting_menu_flowLayoutPanel = new FlowLayoutPanel();
            setting_menu_pictureBox = new PictureBox();
            setting_menu_label = new Label();
            out_menu_flowLayoutPanel = new FlowLayoutPanel();
            out_menu_pictureBox = new PictureBox();
            out_menu_label = new Label();
            menuTransition = new System.Windows.Forms.Timer(components);
            paymentTransition = new System.Windows.Forms.Timer(components);
            main_panel = new Panel();
            nav_drawer_flowLayoutPanel.SuspendLayout();
            menu_group_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close_menu_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)show_menu_pictureBox).BeginInit();
            dashboard_menu_group_flowLayoutPanel.SuspendLayout();
            dashboard_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboard_menu_pictureBox).BeginInit();
            register_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)register_menu_pictureBox).BeginInit();
            payment_menu_group_flowLayoutPanel.SuspendLayout();
            payment_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payment_menu_pictureBox).BeginInit();
            payment_register_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payment_register_menu_pictureBox).BeginInit();
            payment_extension_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payment_extensive_menu_pictureBox).BeginInit();
            extensive_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)extensive_menu_pictureBox).BeginInit();
            results_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)results_menu_pictureBox).BeginInit();
            certificate_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)certificate_menu_pictureBox).BeginInit();
            setting_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)setting_menu_pictureBox).BeginInit();
            out_menu_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)out_menu_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // nav_drawer_flowLayoutPanel
            // 
            nav_drawer_flowLayoutPanel.BackColor = SystemColors.ActiveCaptionText;
            nav_drawer_flowLayoutPanel.Controls.Add(menu_group_panel);
            nav_drawer_flowLayoutPanel.Controls.Add(dashboard_menu_group_flowLayoutPanel);
            nav_drawer_flowLayoutPanel.Controls.Add(setting_menu_flowLayoutPanel);
            nav_drawer_flowLayoutPanel.Controls.Add(out_menu_flowLayoutPanel);
            nav_drawer_flowLayoutPanel.Dock = DockStyle.Left;
            nav_drawer_flowLayoutPanel.Location = new Point(0, 0);
            nav_drawer_flowLayoutPanel.Name = "nav_drawer_flowLayoutPanel";
            nav_drawer_flowLayoutPanel.Size = new Size(100, 1209);
            nav_drawer_flowLayoutPanel.TabIndex = 0;
            // 
            // menu_group_panel
            // 
            menu_group_panel.Controls.Add(close_menu_pictureBox);
            menu_group_panel.Controls.Add(show_menu_pictureBox);
            menu_group_panel.Location = new Point(3, 3);
            menu_group_panel.Margin = new Padding(3, 3, 3, 64);
            menu_group_panel.Name = "menu_group_panel";
            menu_group_panel.Size = new Size(312, 61);
            menu_group_panel.TabIndex = 2;
            // 
            // close_menu_pictureBox
            // 
            close_menu_pictureBox.Image = Properties.Resources.close1;
            close_menu_pictureBox.Location = new Point(260, 19);
            close_menu_pictureBox.Name = "close_menu_pictureBox";
            close_menu_pictureBox.Size = new Size(32, 32);
            close_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            close_menu_pictureBox.TabIndex = 1;
            close_menu_pictureBox.TabStop = false;
            close_menu_pictureBox.Click += close_menu_pictureBox_Click;
            // 
            // show_menu_pictureBox
            // 
            show_menu_pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            show_menu_pictureBox.Image = Properties.Resources.menu_icon;
            show_menu_pictureBox.Location = new Point(25, 19);
            show_menu_pictureBox.Margin = new Padding(0);
            show_menu_pictureBox.Name = "show_menu_pictureBox";
            show_menu_pictureBox.Size = new Size(32, 32);
            show_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            show_menu_pictureBox.TabIndex = 1;
            show_menu_pictureBox.TabStop = false;
            show_menu_pictureBox.Click += show_menu_pictureBox_Click;
            // 
            // dashboard_menu_group_flowLayoutPanel
            // 
            dashboard_menu_group_flowLayoutPanel.Controls.Add(dashboard_menu_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Controls.Add(register_menu_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Controls.Add(payment_menu_group_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Controls.Add(extensive_menu_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Controls.Add(results_menu_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Controls.Add(certificate_menu_flowLayoutPanel);
            dashboard_menu_group_flowLayoutPanel.Location = new Point(0, 128);
            dashboard_menu_group_flowLayoutPanel.Margin = new Padding(0, 0, 0, 40);
            dashboard_menu_group_flowLayoutPanel.Name = "dashboard_menu_group_flowLayoutPanel";
            dashboard_menu_group_flowLayoutPanel.Size = new Size(318, 800);
            dashboard_menu_group_flowLayoutPanel.TabIndex = 4;
            // 
            // dashboard_menu_flowLayoutPanel
            // 
            dashboard_menu_flowLayoutPanel.BackColor = Color.Transparent;
            dashboard_menu_flowLayoutPanel.Controls.Add(dashboard_menu_pictureBox);
            dashboard_menu_flowLayoutPanel.Controls.Add(dashboard_menu_label);
            dashboard_menu_flowLayoutPanel.Location = new Point(0, 0);
            dashboard_menu_flowLayoutPanel.Margin = new Padding(0);
            dashboard_menu_flowLayoutPanel.Name = "dashboard_menu_flowLayoutPanel";
            dashboard_menu_flowLayoutPanel.Size = new Size(318, 80);
            dashboard_menu_flowLayoutPanel.TabIndex = 1;
            dashboard_menu_flowLayoutPanel.WrapContents = false;
            dashboard_menu_flowLayoutPanel.Click += dashboard_menu_flowLayoutPanel_Click;
            // 
            // dashboard_menu_pictureBox
            // 
            dashboard_menu_pictureBox.Image = Properties.Resources.dashboard_white;
            dashboard_menu_pictureBox.Location = new Point(32, 24);
            dashboard_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            dashboard_menu_pictureBox.Name = "dashboard_menu_pictureBox";
            dashboard_menu_pictureBox.Size = new Size(32, 32);
            dashboard_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            dashboard_menu_pictureBox.TabIndex = 0;
            dashboard_menu_pictureBox.TabStop = false;
            dashboard_menu_pictureBox.Click += dashboard_menu_pictureBox_Click;
            // 
            // dashboard_menu_label
            // 
            dashboard_menu_label.AutoSize = true;
            dashboard_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_menu_label.ForeColor = Color.White;
            dashboard_menu_label.Location = new Point(117, 24);
            dashboard_menu_label.Margin = new Padding(50, 24, 3, 0);
            dashboard_menu_label.Name = "dashboard_menu_label";
            dashboard_menu_label.Size = new Size(138, 37);
            dashboard_menu_label.TabIndex = 1;
            dashboard_menu_label.Text = "Trang chủ";
            dashboard_menu_label.Click += dashboard_menu_label_Click;
            // 
            // register_menu_flowLayoutPanel
            // 
            register_menu_flowLayoutPanel.BackColor = Color.Transparent;
            register_menu_flowLayoutPanel.Controls.Add(register_menu_pictureBox);
            register_menu_flowLayoutPanel.Controls.Add(register_menu_label);
            register_menu_flowLayoutPanel.Location = new Point(0, 80);
            register_menu_flowLayoutPanel.Margin = new Padding(0);
            register_menu_flowLayoutPanel.Name = "register_menu_flowLayoutPanel";
            register_menu_flowLayoutPanel.Size = new Size(318, 80);
            register_menu_flowLayoutPanel.TabIndex = 5;
            register_menu_flowLayoutPanel.WrapContents = false;
            register_menu_flowLayoutPanel.Click += register_menu_flowLayoutPanel_Click;
            // 
            // register_menu_pictureBox
            // 
            register_menu_pictureBox.Image = Properties.Resources.register_white;
            register_menu_pictureBox.Location = new Point(32, 24);
            register_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            register_menu_pictureBox.Name = "register_menu_pictureBox";
            register_menu_pictureBox.Size = new Size(32, 32);
            register_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            register_menu_pictureBox.TabIndex = 0;
            register_menu_pictureBox.TabStop = false;
            register_menu_pictureBox.Click += register_menu_pictureBox_Click;
            // 
            // register_menu_label
            // 
            register_menu_label.AutoSize = true;
            register_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_menu_label.ForeColor = Color.White;
            register_menu_label.Location = new Point(117, 24);
            register_menu_label.Margin = new Padding(50, 24, 3, 0);
            register_menu_label.Name = "register_menu_label";
            register_menu_label.Size = new Size(157, 37);
            register_menu_label.TabIndex = 1;
            register_menu_label.Text = "Đăng ký thi";
            register_menu_label.Click += register_menu_label_Click;
            // 
            // payment_menu_group_flowLayoutPanel
            // 
            payment_menu_group_flowLayoutPanel.Controls.Add(payment_menu_flowLayoutPanel);
            payment_menu_group_flowLayoutPanel.Controls.Add(payment_register_menu_flowLayoutPanel);
            payment_menu_group_flowLayoutPanel.Controls.Add(payment_extension_menu_flowLayoutPanel);
            payment_menu_group_flowLayoutPanel.Location = new Point(0, 160);
            payment_menu_group_flowLayoutPanel.Margin = new Padding(0);
            payment_menu_group_flowLayoutPanel.Name = "payment_menu_group_flowLayoutPanel";
            payment_menu_group_flowLayoutPanel.Size = new Size(318, 80);
            payment_menu_group_flowLayoutPanel.TabIndex = 12;
            // 
            // payment_menu_flowLayoutPanel
            // 
            payment_menu_flowLayoutPanel.BackColor = Color.Transparent;
            payment_menu_flowLayoutPanel.Controls.Add(payment_menu_pictureBox);
            payment_menu_flowLayoutPanel.Controls.Add(payment_menu_label);
            payment_menu_flowLayoutPanel.Location = new Point(0, 0);
            payment_menu_flowLayoutPanel.Margin = new Padding(0);
            payment_menu_flowLayoutPanel.Name = "payment_menu_flowLayoutPanel";
            payment_menu_flowLayoutPanel.Size = new Size(318, 80);
            payment_menu_flowLayoutPanel.TabIndex = 6;
            payment_menu_flowLayoutPanel.WrapContents = false;
            payment_menu_flowLayoutPanel.Click += payment_menu_flowLayoutPanel_Click;
            // 
            // payment_menu_pictureBox
            // 
            payment_menu_pictureBox.Image = Properties.Resources.pay_white;
            payment_menu_pictureBox.Location = new Point(32, 24);
            payment_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            payment_menu_pictureBox.Name = "payment_menu_pictureBox";
            payment_menu_pictureBox.Size = new Size(32, 32);
            payment_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            payment_menu_pictureBox.TabIndex = 0;
            payment_menu_pictureBox.TabStop = false;
            payment_menu_pictureBox.Click += payment_menu_pictureBox_Click;
            // 
            // payment_menu_label
            // 
            payment_menu_label.AutoSize = true;
            payment_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_menu_label.ForeColor = Color.White;
            payment_menu_label.Location = new Point(117, 24);
            payment_menu_label.Margin = new Padding(50, 24, 3, 0);
            payment_menu_label.Name = "payment_menu_label";
            payment_menu_label.Size = new Size(157, 37);
            payment_menu_label.TabIndex = 1;
            payment_menu_label.Text = "Thanh toán";
            payment_menu_label.Click += payment_menu_label_Click;
            // 
            // payment_register_menu_flowLayoutPanel
            // 
            payment_register_menu_flowLayoutPanel.BackColor = Color.Transparent;
            payment_register_menu_flowLayoutPanel.Controls.Add(payment_register_menu_pictureBox);
            payment_register_menu_flowLayoutPanel.Controls.Add(payment_register_menu_label);
            payment_register_menu_flowLayoutPanel.Location = new Point(0, 80);
            payment_register_menu_flowLayoutPanel.Margin = new Padding(0);
            payment_register_menu_flowLayoutPanel.Name = "payment_register_menu_flowLayoutPanel";
            payment_register_menu_flowLayoutPanel.Size = new Size(318, 80);
            payment_register_menu_flowLayoutPanel.TabIndex = 10;
            payment_register_menu_flowLayoutPanel.WrapContents = false;
            // 
            // payment_register_menu_pictureBox
            // 
            payment_register_menu_pictureBox.Image = Properties.Resources.receipt_white;
            payment_register_menu_pictureBox.Location = new Point(76, 24);
            payment_register_menu_pictureBox.Margin = new Padding(76, 24, 3, 3);
            payment_register_menu_pictureBox.Name = "payment_register_menu_pictureBox";
            payment_register_menu_pictureBox.Size = new Size(32, 32);
            payment_register_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            payment_register_menu_pictureBox.TabIndex = 1;
            payment_register_menu_pictureBox.TabStop = false;
            // 
            // payment_register_menu_label
            // 
            payment_register_menu_label.AutoSize = true;
            payment_register_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_register_menu_label.ForeColor = Color.White;
            payment_register_menu_label.Location = new Point(143, 24);
            payment_register_menu_label.Margin = new Padding(32, 24, 0, 0);
            payment_register_menu_label.Name = "payment_register_menu_label";
            payment_register_menu_label.Size = new Size(117, 37);
            payment_register_menu_label.TabIndex = 1;
            payment_register_menu_label.Text = "Đăng ký";
            // 
            // payment_extension_menu_flowLayoutPanel
            // 
            payment_extension_menu_flowLayoutPanel.BackColor = Color.Transparent;
            payment_extension_menu_flowLayoutPanel.Controls.Add(payment_extensive_menu_pictureBox);
            payment_extension_menu_flowLayoutPanel.Controls.Add(payment_extension_menu_label);
            payment_extension_menu_flowLayoutPanel.Location = new Point(0, 160);
            payment_extension_menu_flowLayoutPanel.Margin = new Padding(0);
            payment_extension_menu_flowLayoutPanel.Name = "payment_extension_menu_flowLayoutPanel";
            payment_extension_menu_flowLayoutPanel.Size = new Size(318, 80);
            payment_extension_menu_flowLayoutPanel.TabIndex = 11;
            payment_extension_menu_flowLayoutPanel.WrapContents = false;
            // 
            // payment_extensive_menu_pictureBox
            // 
            payment_extensive_menu_pictureBox.Image = Properties.Resources.extend_white;
            payment_extensive_menu_pictureBox.Location = new Point(76, 24);
            payment_extensive_menu_pictureBox.Margin = new Padding(76, 24, 3, 3);
            payment_extensive_menu_pictureBox.Name = "payment_extensive_menu_pictureBox";
            payment_extensive_menu_pictureBox.Size = new Size(32, 32);
            payment_extensive_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            payment_extensive_menu_pictureBox.TabIndex = 2;
            payment_extensive_menu_pictureBox.TabStop = false;
            // 
            // payment_extension_menu_label
            // 
            payment_extension_menu_label.AutoSize = true;
            payment_extension_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_extension_menu_label.ForeColor = Color.White;
            payment_extension_menu_label.Location = new Point(143, 24);
            payment_extension_menu_label.Margin = new Padding(32, 24, 0, 0);
            payment_extension_menu_label.Name = "payment_extension_menu_label";
            payment_extension_menu_label.Size = new Size(110, 37);
            payment_extension_menu_label.TabIndex = 1;
            payment_extension_menu_label.Text = "Gia hạn";
            // 
            // extensive_menu_flowLayoutPanel
            // 
            extensive_menu_flowLayoutPanel.BackColor = Color.Transparent;
            extensive_menu_flowLayoutPanel.Controls.Add(extensive_menu_pictureBox);
            extensive_menu_flowLayoutPanel.Controls.Add(extensive_menu_label);
            extensive_menu_flowLayoutPanel.Location = new Point(0, 240);
            extensive_menu_flowLayoutPanel.Margin = new Padding(0);
            extensive_menu_flowLayoutPanel.Name = "extensive_menu_flowLayoutPanel";
            extensive_menu_flowLayoutPanel.Size = new Size(318, 80);
            extensive_menu_flowLayoutPanel.TabIndex = 7;
            extensive_menu_flowLayoutPanel.WrapContents = false;
            // 
            // extensive_menu_pictureBox
            // 
            extensive_menu_pictureBox.Image = Properties.Resources.calen_white;
            extensive_menu_pictureBox.Location = new Point(32, 24);
            extensive_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            extensive_menu_pictureBox.Name = "extensive_menu_pictureBox";
            extensive_menu_pictureBox.Size = new Size(32, 32);
            extensive_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            extensive_menu_pictureBox.TabIndex = 0;
            extensive_menu_pictureBox.TabStop = false;
            // 
            // extensive_menu_label
            // 
            extensive_menu_label.AutoSize = true;
            extensive_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            extensive_menu_label.ForeColor = Color.White;
            extensive_menu_label.Location = new Point(117, 24);
            extensive_menu_label.Margin = new Padding(50, 24, 3, 0);
            extensive_menu_label.Name = "extensive_menu_label";
            extensive_menu_label.Size = new Size(150, 37);
            extensive_menu_label.TabIndex = 1;
            extensive_menu_label.Text = "Gia hạn thi";
            // 
            // results_menu_flowLayoutPanel
            // 
            results_menu_flowLayoutPanel.BackColor = Color.Transparent;
            results_menu_flowLayoutPanel.Controls.Add(results_menu_pictureBox);
            results_menu_flowLayoutPanel.Controls.Add(results_menu_label);
            results_menu_flowLayoutPanel.Location = new Point(0, 320);
            results_menu_flowLayoutPanel.Margin = new Padding(0);
            results_menu_flowLayoutPanel.Name = "results_menu_flowLayoutPanel";
            results_menu_flowLayoutPanel.Size = new Size(318, 80);
            results_menu_flowLayoutPanel.TabIndex = 8;
            results_menu_flowLayoutPanel.WrapContents = false;
            results_menu_flowLayoutPanel.Click += results_menu_flowLayoutPanel_Click;
            // 
            // results_menu_pictureBox
            // 
            results_menu_pictureBox.Image = Properties.Resources.grade_white;
            results_menu_pictureBox.Location = new Point(32, 24);
            results_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            results_menu_pictureBox.Name = "results_menu_pictureBox";
            results_menu_pictureBox.Size = new Size(32, 32);
            results_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            results_menu_pictureBox.TabIndex = 0;
            results_menu_pictureBox.TabStop = false;
            results_menu_pictureBox.Click += results_menu_pictureBox_Click;
            // 
            // results_menu_label
            // 
            results_menu_label.AutoSize = true;
            results_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            results_menu_label.ForeColor = Color.White;
            results_menu_label.Location = new Point(117, 24);
            results_menu_label.Margin = new Padding(50, 24, 3, 0);
            results_menu_label.Name = "results_menu_label";
            results_menu_label.Size = new Size(151, 37);
            results_menu_label.TabIndex = 1;
            results_menu_label.Text = "Kết quả thi";
            results_menu_label.Click += results_menu_label_Click;
            // 
            // certificate_menu_flowLayoutPanel
            // 
            certificate_menu_flowLayoutPanel.BackColor = Color.Transparent;
            certificate_menu_flowLayoutPanel.Controls.Add(certificate_menu_pictureBox);
            certificate_menu_flowLayoutPanel.Controls.Add(certificate_menu_label);
            certificate_menu_flowLayoutPanel.Location = new Point(0, 400);
            certificate_menu_flowLayoutPanel.Margin = new Padding(0);
            certificate_menu_flowLayoutPanel.Name = "certificate_menu_flowLayoutPanel";
            certificate_menu_flowLayoutPanel.Size = new Size(318, 80);
            certificate_menu_flowLayoutPanel.TabIndex = 9;
            certificate_menu_flowLayoutPanel.WrapContents = false;
            certificate_menu_flowLayoutPanel.Click += certificate_menu_flowLayoutPanel_Click;
            // 
            // certificate_menu_pictureBox
            // 
            certificate_menu_pictureBox.Image = Properties.Resources.cert_white;
            certificate_menu_pictureBox.Location = new Point(32, 24);
            certificate_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            certificate_menu_pictureBox.Name = "certificate_menu_pictureBox";
            certificate_menu_pictureBox.Size = new Size(32, 32);
            certificate_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            certificate_menu_pictureBox.TabIndex = 0;
            certificate_menu_pictureBox.TabStop = false;
            certificate_menu_pictureBox.Click += certificate_menu_pictureBox_Click;
            // 
            // certificate_menu_label
            // 
            certificate_menu_label.AutoSize = true;
            certificate_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            certificate_menu_label.ForeColor = Color.White;
            certificate_menu_label.Location = new Point(117, 24);
            certificate_menu_label.Margin = new Padding(50, 24, 3, 0);
            certificate_menu_label.Name = "certificate_menu_label";
            certificate_menu_label.Size = new Size(142, 37);
            certificate_menu_label.TabIndex = 1;
            certificate_menu_label.Text = "Chứng chỉ";
            certificate_menu_label.Click += certificate_menu_label_Click;
            // 
            // setting_menu_flowLayoutPanel
            // 
            setting_menu_flowLayoutPanel.Controls.Add(setting_menu_pictureBox);
            setting_menu_flowLayoutPanel.Controls.Add(setting_menu_label);
            setting_menu_flowLayoutPanel.Location = new Point(0, 968);
            setting_menu_flowLayoutPanel.Margin = new Padding(0);
            setting_menu_flowLayoutPanel.Name = "setting_menu_flowLayoutPanel";
            setting_menu_flowLayoutPanel.Size = new Size(318, 80);
            setting_menu_flowLayoutPanel.TabIndex = 2;
            setting_menu_flowLayoutPanel.WrapContents = false;
            // 
            // setting_menu_pictureBox
            // 
            setting_menu_pictureBox.Image = Properties.Resources.setting_whitee;
            setting_menu_pictureBox.Location = new Point(32, 24);
            setting_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            setting_menu_pictureBox.Name = "setting_menu_pictureBox";
            setting_menu_pictureBox.Size = new Size(32, 32);
            setting_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            setting_menu_pictureBox.TabIndex = 0;
            setting_menu_pictureBox.TabStop = false;
            // 
            // setting_menu_label
            // 
            setting_menu_label.AutoSize = true;
            setting_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            setting_menu_label.ForeColor = Color.White;
            setting_menu_label.Location = new Point(117, 24);
            setting_menu_label.Margin = new Padding(50, 24, 3, 0);
            setting_menu_label.Name = "setting_menu_label";
            setting_menu_label.Size = new Size(102, 37);
            setting_menu_label.TabIndex = 1;
            setting_menu_label.Text = "Cài đặt";
            // 
            // out_menu_flowLayoutPanel
            // 
            out_menu_flowLayoutPanel.Controls.Add(out_menu_pictureBox);
            out_menu_flowLayoutPanel.Controls.Add(out_menu_label);
            out_menu_flowLayoutPanel.Location = new Point(0, 1048);
            out_menu_flowLayoutPanel.Margin = new Padding(0);
            out_menu_flowLayoutPanel.Name = "out_menu_flowLayoutPanel";
            out_menu_flowLayoutPanel.Size = new Size(318, 80);
            out_menu_flowLayoutPanel.TabIndex = 3;
            out_menu_flowLayoutPanel.WrapContents = false;
            out_menu_flowLayoutPanel.Click += out_menu_flowLayoutPanel_Click;
            // 
            // out_menu_pictureBox
            // 
            out_menu_pictureBox.Image = Properties.Resources.out_whitee;
            out_menu_pictureBox.Location = new Point(32, 24);
            out_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            out_menu_pictureBox.Name = "out_menu_pictureBox";
            out_menu_pictureBox.Size = new Size(32, 32);
            out_menu_pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            out_menu_pictureBox.TabIndex = 0;
            out_menu_pictureBox.TabStop = false;
            out_menu_pictureBox.Click += out_menu_pictureBox_Click;
            // 
            // out_menu_label
            // 
            out_menu_label.AutoSize = true;
            out_menu_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            out_menu_label.ForeColor = Color.White;
            out_menu_label.Location = new Point(117, 24);
            out_menu_label.Margin = new Padding(50, 24, 3, 0);
            out_menu_label.Name = "out_menu_label";
            out_menu_label.Size = new Size(143, 37);
            out_menu_label.TabIndex = 1;
            out_menu_label.Text = "Đăng xuất";
            out_menu_label.Click += out_menu_label_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // paymentTransition
            // 
            paymentTransition.Interval = 10;
            paymentTransition.Tick += paymentTransition_Tick;
            // 
            // main_panel
            // 
            main_panel.Location = new Point(103, 0);
            main_panel.Margin = new Padding(0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1620, 1209);
            main_panel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1724, 1209);
            Controls.Add(nav_drawer_flowLayoutPanel);
            Controls.Add(main_panel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            nav_drawer_flowLayoutPanel.ResumeLayout(false);
            menu_group_panel.ResumeLayout(false);
            menu_group_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)close_menu_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)show_menu_pictureBox).EndInit();
            dashboard_menu_group_flowLayoutPanel.ResumeLayout(false);
            dashboard_menu_flowLayoutPanel.ResumeLayout(false);
            dashboard_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboard_menu_pictureBox).EndInit();
            register_menu_flowLayoutPanel.ResumeLayout(false);
            register_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)register_menu_pictureBox).EndInit();
            payment_menu_group_flowLayoutPanel.ResumeLayout(false);
            payment_menu_flowLayoutPanel.ResumeLayout(false);
            payment_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)payment_menu_pictureBox).EndInit();
            payment_register_menu_flowLayoutPanel.ResumeLayout(false);
            payment_register_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)payment_register_menu_pictureBox).EndInit();
            payment_extension_menu_flowLayoutPanel.ResumeLayout(false);
            payment_extension_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)payment_extensive_menu_pictureBox).EndInit();
            extensive_menu_flowLayoutPanel.ResumeLayout(false);
            extensive_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)extensive_menu_pictureBox).EndInit();
            results_menu_flowLayoutPanel.ResumeLayout(false);
            results_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)results_menu_pictureBox).EndInit();
            certificate_menu_flowLayoutPanel.ResumeLayout(false);
            certificate_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)certificate_menu_pictureBox).EndInit();
            setting_menu_flowLayoutPanel.ResumeLayout(false);
            setting_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)setting_menu_pictureBox).EndInit();
            out_menu_flowLayoutPanel.ResumeLayout(false);
            out_menu_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)out_menu_pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel nav_drawer_flowLayoutPanel;
        private PictureBox show_menu_pictureBox;
        private Panel menu_group_panel;
        private PictureBox close_menu_pictureBox;
        private FlowLayoutPanel dashboard_menu_flowLayoutPanel;
        private PictureBox dashboard_menu_pictureBox;
        private Label dashboard_menu_label;
        private FlowLayoutPanel setting_menu_flowLayoutPanel;
        private PictureBox setting_menu_pictureBox;
        private Label setting_menu_label;
        private FlowLayoutPanel out_menu_flowLayoutPanel;
        private PictureBox out_menu_pictureBox;
        private Label out_menu_label;
        private FlowLayoutPanel dashboard_menu_group_flowLayoutPanel;
        private FlowLayoutPanel register_menu_flowLayoutPanel;
        private PictureBox register_menu_pictureBox;
        private Label register_menu_label;
        private FlowLayoutPanel payment_menu_flowLayoutPanel;
        private PictureBox payment_menu_pictureBox;
        private Label payment_menu_label;
        private FlowLayoutPanel extensive_menu_flowLayoutPanel;
        private PictureBox extensive_menu_pictureBox;
        private Label extensive_menu_label;
        private FlowLayoutPanel results_menu_flowLayoutPanel;
        private PictureBox results_menu_pictureBox;
        private Label results_menu_label;
        private FlowLayoutPanel certificate_menu_flowLayoutPanel;
        private PictureBox certificate_menu_pictureBox;
        private Label certificate_menu_label;
        private FlowLayoutPanel payment_register_menu_flowLayoutPanel;
        private Label payment_register_menu_label;
        private FlowLayoutPanel payment_extension_menu_flowLayoutPanel;
        private Label payment_extension_menu_label;
        private FlowLayoutPanel payment_menu_group_flowLayoutPanel;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer paymentTransition;
        private Panel main_panel;
        private PictureBox payment_register_menu_pictureBox;
        private PictureBox payment_extensive_menu_pictureBox;
    }
}
