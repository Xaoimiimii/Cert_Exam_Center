namespace ACCI_CertificationExaminationCenter
{
    partial class RegisterDetailsFormControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            dataGridView1 = new DataGridView();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            Sdt = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            label2 = new Label();
            guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            exam_type_label = new Label();
            exam_type_panel = new Panel();
            exam_type_label_value = new Label();
            time_exam_label = new Label();
            time_exam_panel = new Panel();
            time_exam_label_value = new Label();
            date_exam_label = new Label();
            date_exam_panel = new Panel();
            date_exam_value = new Label();
            exam_id_panel = new Panel();
            exam_id_title_value = new Label();
            exam_id_title_label = new Label();
            guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            kh_fullname_panel = new Panel();
            label3 = new Label();
            kh_fullname_title_label = new Label();
            tt_kh_title_label = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            kh_phone_panel = new Panel();
            label5 = new Label();
            kh_phone_title_label = new Label();
            kh_email_panel = new Panel();
            label6 = new Label();
            kh_email_label = new Label();
            kh_address_panel = new Panel();
            label7 = new Label();
            kh_address_label = new Label();
            donvi_panel = new Panel();
            label8 = new Label();
            donvi_label = new Label();
            guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            tt_lt_title_label = new Label();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            kh_gender_label = new Label();
            kh_gender_panel = new Panel();
            label4 = new Label();
            select_exam_button = new Button();
            button1 = new Button();
            guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            exam_type_panel.SuspendLayout();
            time_exam_panel.SuspendLayout();
            date_exam_panel.SuspendLayout();
            exam_id_panel.SuspendLayout();
            kh_fullname_panel.SuspendLayout();
            kh_phone_panel.SuspendLayout();
            kh_email_panel.SuspendLayout();
            kh_address_panel.SuspendLayout();
            donvi_panel.SuspendLayout();
            kh_gender_panel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(dataGridView1);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(24, 718);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.DimGray;
            guna2ShadowPanel1.ShadowShift = 16;
            guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            guna2ShadowPanel1.Size = new Size(1480, 714);
            guna2ShadowPanel1.TabIndex = 54;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 46;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { HoTen, NgaySinh, GioiTinh, Sdt, Email, DiaChi });
            dataGridView1.GridColor = Color.PowderBlue;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1453, 662);
            dataGridView1.TabIndex = 0;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 10;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 10;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 10;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // Sdt
            // 
            Sdt.HeaderText = "Số điện thoại";
            Sdt.MinimumWidth = 10;
            Sdt.Name = "Sdt";
            Sdt.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 10;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 10;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 664);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(331, 50);
            label2.TabIndex = 53;
            label2.Text = "Danh sách thí sinh";
            // 
            // guna2Separator4
            // 
            guna2Separator4.FillThickness = 2;
            guna2Separator4.Location = new Point(0, 1229);
            guna2Separator4.Margin = new Padding(0);
            guna2Separator4.Name = "guna2Separator4";
            guna2Separator4.Size = new Size(0, 0);
            guna2Separator4.TabIndex = 52;
            // 
            // exam_type_label
            // 
            exam_type_label.AutoSize = true;
            exam_type_label.Dock = DockStyle.Left;
            exam_type_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exam_type_label.Location = new Point(0, 0);
            exam_type_label.Name = "exam_type_label";
            exam_type_label.Size = new Size(180, 37);
            exam_type_label.TabIndex = 0;
            exam_type_label.Text = "Loại đánh giá";
            // 
            // exam_type_panel
            // 
            exam_type_panel.Controls.Add(exam_type_label_value);
            exam_type_panel.Controls.Add(exam_type_label);
            exam_type_panel.Location = new Point(1164, 541);
            exam_type_panel.Name = "exam_type_panel";
            exam_type_panel.Size = new Size(325, 45);
            exam_type_panel.TabIndex = 61;
            // 
            // exam_type_label_value
            // 
            exam_type_label_value.AutoSize = true;
            exam_type_label_value.Font = new Font("Segoe UI", 10.125F);
            exam_type_label_value.Location = new Point(192, 0);
            exam_type_label_value.Margin = new Padding(5, 0, 5, 0);
            exam_type_label_value.Name = "exam_type_label_value";
            exam_type_label_value.Size = new Size(103, 37);
            exam_type_label_value.TabIndex = 2;
            exam_type_label_value.Text = "Tin học";
            // 
            // time_exam_label
            // 
            time_exam_label.AutoSize = true;
            time_exam_label.Dock = DockStyle.Left;
            time_exam_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            time_exam_label.Location = new Point(0, 0);
            time_exam_label.Name = "time_exam_label";
            time_exam_label.Size = new Size(172, 37);
            time_exam_label.TabIndex = 0;
            time_exam_label.Text = "Thời gian thi";
            // 
            // time_exam_panel
            // 
            time_exam_panel.Controls.Add(time_exam_label_value);
            time_exam_panel.Controls.Add(time_exam_label);
            time_exam_panel.Location = new Point(791, 541);
            time_exam_panel.Name = "time_exam_panel";
            time_exam_panel.Size = new Size(335, 45);
            time_exam_panel.TabIndex = 60;
            // 
            // time_exam_label_value
            // 
            time_exam_label_value.AutoSize = true;
            time_exam_label_value.BackColor = Color.White;
            time_exam_label_value.Font = new Font("Segoe UI", 10.125F);
            time_exam_label_value.Location = new Point(180, 0);
            time_exam_label_value.Margin = new Padding(5, 0, 5, 0);
            time_exam_label_value.Name = "time_exam_label_value";
            time_exam_label_value.Size = new Size(83, 37);
            time_exam_label_value.TabIndex = 2;
            time_exam_label_value.Text = "10:00";
            // 
            // date_exam_label
            // 
            date_exam_label.AutoSize = true;
            date_exam_label.Dock = DockStyle.Left;
            date_exam_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_exam_label.Location = new Point(0, 0);
            date_exam_label.Name = "date_exam_label";
            date_exam_label.Size = new Size(122, 37);
            date_exam_label.TabIndex = 0;
            date_exam_label.Text = "Ngày thi";
            // 
            // date_exam_panel
            // 
            date_exam_panel.Controls.Add(date_exam_value);
            date_exam_panel.Controls.Add(date_exam_label);
            date_exam_panel.Location = new Point(410, 541);
            date_exam_panel.Name = "date_exam_panel";
            date_exam_panel.Size = new Size(349, 45);
            date_exam_panel.TabIndex = 59;
            // 
            // date_exam_value
            // 
            date_exam_value.AutoSize = true;
            date_exam_value.Font = new Font("Segoe UI", 10.125F);
            date_exam_value.Location = new Point(132, 0);
            date_exam_value.Margin = new Padding(5, 0, 5, 0);
            date_exam_value.Name = "date_exam_value";
            date_exam_value.Size = new Size(159, 37);
            date_exam_value.TabIndex = 2;
            date_exam_value.Text = "30/01/2025";
            // 
            // exam_id_panel
            // 
            exam_id_panel.Controls.Add(exam_id_title_value);
            exam_id_panel.Controls.Add(exam_id_title_label);
            exam_id_panel.Location = new Point(24, 541);
            exam_id_panel.Name = "exam_id_panel";
            exam_id_panel.Size = new Size(348, 45);
            exam_id_panel.TabIndex = 58;
            // 
            // exam_id_title_value
            // 
            exam_id_title_value.AutoSize = true;
            exam_id_title_value.Font = new Font("Segoe UI", 10.125F);
            exam_id_title_value.Location = new Point(156, 0);
            exam_id_title_value.Margin = new Padding(5, 0, 5, 0);
            exam_id_title_value.Name = "exam_id_title_value";
            exam_id_title_value.Size = new Size(132, 37);
            exam_id_title_value.TabIndex = 1;
            exam_id_title_value.Text = "LT000004";
            // 
            // exam_id_title_label
            // 
            exam_id_title_label.AutoSize = true;
            exam_id_title_label.Dock = DockStyle.Left;
            exam_id_title_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exam_id_title_label.Location = new Point(0, 0);
            exam_id_title_label.Name = "exam_id_title_label";
            exam_id_title_label.Size = new Size(146, 37);
            exam_id_title_label.TabIndex = 0;
            exam_id_title_label.Text = "Mã lịch thi";
            // 
            // guna2Separator5
            // 
            guna2Separator5.FillColor = Color.White;
            guna2Separator5.Location = new Point(627, 2274);
            guna2Separator5.Name = "guna2Separator5";
            guna2Separator5.Size = new Size(400, 19);
            guna2Separator5.TabIndex = 56;
            // 
            // kh_fullname_panel
            // 
            kh_fullname_panel.Controls.Add(label3);
            kh_fullname_panel.Controls.Add(kh_fullname_title_label);
            kh_fullname_panel.Location = new Point(24, 203);
            kh_fullname_panel.Name = "kh_fullname_panel";
            kh_fullname_panel.Size = new Size(520, 45);
            kh_fullname_panel.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F);
            label3.Location = new Point(110, 0);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 37);
            label3.TabIndex = 2;
            label3.Text = "Trần Vĩnh Phúc";
            // 
            // kh_fullname_title_label
            // 
            kh_fullname_title_label.AutoSize = true;
            kh_fullname_title_label.Dock = DockStyle.Left;
            kh_fullname_title_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kh_fullname_title_label.Location = new Point(0, 0);
            kh_fullname_title_label.Name = "kh_fullname_title_label";
            kh_fullname_title_label.Size = new Size(100, 37);
            kh_fullname_title_label.TabIndex = 0;
            kh_fullname_title_label.Text = "Họ tên";
            // 
            // tt_kh_title_label
            // 
            tt_kh_title_label.AutoSize = true;
            tt_kh_title_label.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tt_kh_title_label.Location = new Point(24, 128);
            tt_kh_title_label.Margin = new Padding(0);
            tt_kh_title_label.Name = "tt_kh_title_label";
            tt_kh_title_label.Size = new Size(389, 50);
            tt_kh_title_label.TabIndex = 34;
            tt_kh_title_label.Text = "Thông tin khách hàng";
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 93);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1516, 21);
            guna2Separator1.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(471, 59);
            label1.TabIndex = 32;
            label1.Text = "Chi tiết phiếu đăng ký";
            // 
            // kh_phone_panel
            // 
            kh_phone_panel.Controls.Add(label5);
            kh_phone_panel.Controls.Add(kh_phone_title_label);
            kh_phone_panel.Location = new Point(1076, 203);
            kh_phone_panel.Name = "kh_phone_panel";
            kh_phone_panel.Size = new Size(413, 45);
            kh_phone_panel.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F);
            label5.Location = new Point(188, 0);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 37);
            label5.TabIndex = 3;
            label5.Text = "0909223424";
            // 
            // kh_phone_title_label
            // 
            kh_phone_title_label.AutoSize = true;
            kh_phone_title_label.Dock = DockStyle.Left;
            kh_phone_title_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kh_phone_title_label.Location = new Point(0, 0);
            kh_phone_title_label.Name = "kh_phone_title_label";
            kh_phone_title_label.Size = new Size(178, 37);
            kh_phone_title_label.TabIndex = 0;
            kh_phone_title_label.Text = "Số điện thoại";
            // 
            // kh_email_panel
            // 
            kh_email_panel.Controls.Add(label6);
            kh_email_panel.Controls.Add(kh_email_label);
            kh_email_panel.Location = new Point(24, 278);
            kh_email_panel.Name = "kh_email_panel";
            kh_email_panel.Size = new Size(520, 45);
            kh_email_panel.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F);
            label6.Location = new Point(91, 0);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(368, 37);
            label6.TabIndex = 3;
            label6.Text = "tieuhochoabinh5@gmail.com";
            // 
            // kh_email_label
            // 
            kh_email_label.AutoSize = true;
            kh_email_label.Dock = DockStyle.Left;
            kh_email_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kh_email_label.Location = new Point(0, 0);
            kh_email_label.Name = "kh_email_label";
            kh_email_label.Size = new Size(83, 37);
            kh_email_label.TabIndex = 0;
            kh_email_label.Text = "Email";
            // 
            // kh_address_panel
            // 
            kh_address_panel.Controls.Add(label7);
            kh_address_panel.Controls.Add(kh_address_label);
            kh_address_panel.Location = new Point(660, 278);
            kh_address_panel.Name = "kh_address_panel";
            kh_address_panel.Size = new Size(829, 45);
            kh_address_panel.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F);
            label7.Location = new Point(109, 0);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(324, 37);
            label7.TabIndex = 3;
            label7.Text = "232 Hùng Vương, P.9, Q.5";
            // 
            // kh_address_label
            // 
            kh_address_label.AutoSize = true;
            kh_address_label.Dock = DockStyle.Left;
            kh_address_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kh_address_label.Location = new Point(0, 0);
            kh_address_label.Name = "kh_address_label";
            kh_address_label.Size = new Size(100, 37);
            kh_address_label.TabIndex = 0;
            kh_address_label.Text = "Địa chỉ";
            // 
            // donvi_panel
            // 
            donvi_panel.Controls.Add(label8);
            donvi_panel.Controls.Add(donvi_label);
            donvi_panel.Location = new Point(24, 352);
            donvi_panel.Name = "donvi_panel";
            donvi_panel.Size = new Size(855, 45);
            donvi_panel.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F);
            label8.Location = new Point(153, 0);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(429, 37);
            label8.TabIndex = 3;
            label8.Text = "Trường tiểu học Hòa Bình - Quận 5";
            label8.Click += label8_Click;
            // 
            // donvi_label
            // 
            donvi_label.AutoSize = true;
            donvi_label.Dock = DockStyle.Left;
            donvi_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donvi_label.Location = new Point(0, 0);
            donvi_label.Name = "donvi_label";
            donvi_label.Size = new Size(143, 37);
            donvi_label.TabIndex = 0;
            donvi_label.Text = "Tên đơn vị";
            // 
            // guna2Separator3
            // 
            guna2Separator3.FillThickness = 2;
            guna2Separator3.Location = new Point(0, 626);
            guna2Separator3.Margin = new Padding(0);
            guna2Separator3.Name = "guna2Separator3";
            guna2Separator3.Size = new Size(1516, 21);
            guna2Separator3.TabIndex = 43;
            // 
            // tt_lt_title_label
            // 
            tt_lt_title_label.AutoSize = true;
            tt_lt_title_label.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tt_lt_title_label.Location = new Point(24, 466);
            tt_lt_title_label.Margin = new Padding(0);
            tt_lt_title_label.Name = "tt_lt_title_label";
            tt_lt_title_label.Size = new Size(309, 50);
            tt_lt_title_label.TabIndex = 42;
            tt_lt_title_label.Text = "Thông tin lịch thi";
            // 
            // guna2Separator2
            // 
            guna2Separator2.FillThickness = 2;
            guna2Separator2.Location = new Point(0, 429);
            guna2Separator2.Margin = new Padding(0);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(1516, 21);
            guna2Separator2.TabIndex = 41;
            // 
            // kh_gender_label
            // 
            kh_gender_label.AutoSize = true;
            kh_gender_label.Dock = DockStyle.Left;
            kh_gender_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kh_gender_label.Location = new Point(0, 0);
            kh_gender_label.Name = "kh_gender_label";
            kh_gender_label.Size = new Size(123, 37);
            kh_gender_label.TabIndex = 0;
            kh_gender_label.Text = "Giới tính";
            // 
            // kh_gender_panel
            // 
            kh_gender_panel.Controls.Add(kh_gender_label);
            kh_gender_panel.Location = new Point(660, 203);
            kh_gender_panel.Name = "kh_gender_panel";
            kh_gender_panel.Size = new Size(335, 45);
            kh_gender_panel.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F);
            label4.Location = new Point(790, 203);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 37);
            label4.TabIndex = 3;
            label4.Text = "Nam";
            // 
            // select_exam_button
            // 
            select_exam_button.BackColor = SystemColors.ActiveBorder;
            select_exam_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            select_exam_button.ForeColor = Color.Transparent;
            select_exam_button.Location = new Point(457, 1496);
            select_exam_button.Name = "select_exam_button";
            select_exam_button.Size = new Size(326, 78);
            select_exam_button.TabIndex = 62;
            select_exam_button.Text = "Tải PDF";
            select_exam_button.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(791, 1496);
            button1.Name = "button1";
            button1.Size = new Size(330, 78);
            button1.TabIndex = 63;
            button1.Text = "In phiếu";
            button1.UseVisualStyleBackColor = false;
            // 
            // RegisterDetailsFormControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(select_exam_button);
            Controls.Add(label4);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(label2);
            Controls.Add(guna2Separator4);
            Controls.Add(exam_type_panel);
            Controls.Add(time_exam_panel);
            Controls.Add(date_exam_panel);
            Controls.Add(exam_id_panel);
            Controls.Add(guna2Separator5);
            Controls.Add(kh_fullname_panel);
            Controls.Add(tt_kh_title_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Controls.Add(kh_phone_panel);
            Controls.Add(kh_email_panel);
            Controls.Add(kh_address_panel);
            Controls.Add(donvi_panel);
            Controls.Add(guna2Separator3);
            Controls.Add(tt_lt_title_label);
            Controls.Add(guna2Separator2);
            Controls.Add(kh_gender_panel);
            Margin = new Padding(5);
            Name = "RegisterDetailsFormControl";
            Size = new Size(1456, 1101);
            guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            exam_type_panel.ResumeLayout(false);
            exam_type_panel.PerformLayout();
            time_exam_panel.ResumeLayout(false);
            time_exam_panel.PerformLayout();
            date_exam_panel.ResumeLayout(false);
            date_exam_panel.PerformLayout();
            exam_id_panel.ResumeLayout(false);
            exam_id_panel.PerformLayout();
            kh_fullname_panel.ResumeLayout(false);
            kh_fullname_panel.PerformLayout();
            kh_phone_panel.ResumeLayout(false);
            kh_phone_panel.PerformLayout();
            kh_email_panel.ResumeLayout(false);
            kh_email_panel.PerformLayout();
            kh_address_panel.ResumeLayout(false);
            kh_address_panel.PerformLayout();
            donvi_panel.ResumeLayout(false);
            donvi_panel.PerformLayout();
            kh_gender_panel.ResumeLayout(false);
            kh_gender_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Sdt;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Label exam_type_label;
        private Panel exam_type_panel;
        private Label time_exam_label;
        private Panel time_exam_panel;
        private Label date_exam_label;
        private Panel date_exam_panel;
        private Panel exam_id_panel;
        private Label exam_id_title_label;
        private Label exam_id_title_value;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Panel kh_fullname_panel;
        private TextBox kh_fullname_textBox;
        private Label kh_fullname_title_label;
        private Label tt_kh_title_label;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Panel kh_phone_panel;
        private Label kh_phone_title_label;
        private Panel kh_email_panel;
        private TextBox kh_email_textBox;
        private Label kh_email_label;
        private Panel kh_address_panel;
        private Label kh_address_label;
        private Panel donvi_panel;
        private TextBox donvi_textBox;
        private Label donvi_label;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Label tt_lt_title_label;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Label kh_gender_label;
        private Panel kh_gender_panel;
        private Label exam_type_label_value;
        private Label time_exam_label_value;
        private Label date_exam_value;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label4;
        private Button select_exam_button;
        private Button button1;
    }
}
