namespace ACCI_CertificationExaminationCenter
{
    partial class CapNhatTrangThaiPhieuDuThi : UserControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            btnCapNhatTrangThai = new Button();
            status_flowLayoutPanel = new FlowLayoutPanel();
            lbTrangThai = new Label();
            found_status_label = new Label();
            type_flowLayoutPanel = new FlowLayoutPanel();
            lbLoaiDanhGia = new Label();
            found_type_label = new Label();
            time_flowLayoutPanel = new FlowLayoutPanel();
            lbGioThi = new Label();
            found_time_label = new Label();
            date_flowLayoutPanel = new FlowLayoutPanel();
            lbNgayThi = new Label();
            found_date_label = new Label();
            sdt_flowLayoutPanel = new FlowLayoutPanel();
            lbSDT = new Label();
            found_sdt_label = new Label();
            gender_flowLayoutPanel = new FlowLayoutPanel();
            lbGioiTinh = new Label();
            found_gender_label = new Label();
            sbd_flowLayoutPanel = new FlowLayoutPanel();
            lbSBD = new Label();
            found_sbd_label = new Label();
            label3 = new Label();
            btnLuu = new Button();
            res_flowLayoutPanel = new FlowLayoutPanel();
            res_label = new Label();
            cbbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            lbPhieuDuThi = new Label();
            pnlThongTin = new Guna.UI2.WinForms.Guna2ShadowPanel();
            cert_pictureBox = new PictureBox();
            pnlThongTinPDT = new Guna.UI2.WinForms.Guna2ShadowPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbSoBaoDanh = new Label();
            txtSoBaoDanh = new Guna.UI2.WinForms.Guna2TextBox();
            btnTimKiem = new Button();
            status_flowLayoutPanel.SuspendLayout();
            type_flowLayoutPanel.SuspendLayout();
            time_flowLayoutPanel.SuspendLayout();
            date_flowLayoutPanel.SuspendLayout();
            sdt_flowLayoutPanel.SuspendLayout();
            gender_flowLayoutPanel.SuspendLayout();
            sbd_flowLayoutPanel.SuspendLayout();
            res_flowLayoutPanel.SuspendLayout();
            pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cert_pictureBox).BeginInit();
            pnlThongTinPDT.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(428, 37);
            label1.TabIndex = 1;
            label1.Text = "Cập nhật trạng thái phiếu dự thi";
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 62);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(997, 13);
            guna2Separator1.TabIndex = 30;
            // 
            // btnCapNhatTrangThai
            // 
            btnCapNhatTrangThai.BackColor = Color.MediumTurquoise;
            btnCapNhatTrangThai.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhatTrangThai.ForeColor = Color.Transparent;
            btnCapNhatTrangThai.Location = new Point(319, 261);
            btnCapNhatTrangThai.Margin = new Padding(0);
            btnCapNhatTrangThai.Name = "btnCapNhatTrangThai";
            btnCapNhatTrangThai.Size = new Size(184, 49);
            btnCapNhatTrangThai.TabIndex = 33;
            btnCapNhatTrangThai.Text = "Cập nhật trạng thái";
            btnCapNhatTrangThai.UseVisualStyleBackColor = false;
            btnCapNhatTrangThai.Click += btnCapNhatTrangThai_Click;
            // 
            // status_flowLayoutPanel
            // 
            status_flowLayoutPanel.Controls.Add(lbTrangThai);
            status_flowLayoutPanel.Controls.Add(found_status_label);
            status_flowLayoutPanel.Location = new Point(211, 210);
            status_flowLayoutPanel.Margin = new Padding(2);
            status_flowLayoutPanel.Name = "status_flowLayoutPanel";
            status_flowLayoutPanel.Size = new Size(292, 28);
            status_flowLayoutPanel.TabIndex = 39;
            // 
            // lbTrangThai
            // 
            lbTrangThai.AutoSize = true;
            lbTrangThai.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTrangThai.Location = new Point(2, 0);
            lbTrangThai.Margin = new Padding(2, 0, 2, 0);
            lbTrangThai.Name = "lbTrangThai";
            lbTrangThai.Size = new Size(91, 23);
            lbTrangThai.TabIndex = 0;
            lbTrangThai.Text = "Trạng thái:";
            // 
            // found_status_label
            // 
            found_status_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            found_status_label.ForeColor = SystemColors.WindowFrame;
            found_status_label.Location = new Point(2, 23);
            found_status_label.Margin = new Padding(2, 0, 2, 0);
            found_status_label.Name = "found_status_label";
            found_status_label.Size = new Size(197, 28);
            found_status_label.TabIndex = 1;
            // 
            // type_flowLayoutPanel
            // 
            type_flowLayoutPanel.Controls.Add(lbLoaiDanhGia);
            type_flowLayoutPanel.Controls.Add(found_type_label);
            type_flowLayoutPanel.Location = new Point(211, 185);
            type_flowLayoutPanel.Margin = new Padding(2);
            type_flowLayoutPanel.Name = "type_flowLayoutPanel";
            type_flowLayoutPanel.Size = new Size(292, 28);
            type_flowLayoutPanel.TabIndex = 38;
            // 
            // lbLoaiDanhGia
            // 
            lbLoaiDanhGia.AutoSize = true;
            lbLoaiDanhGia.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLoaiDanhGia.Location = new Point(2, 0);
            lbLoaiDanhGia.Margin = new Padding(2, 0, 2, 0);
            lbLoaiDanhGia.Name = "lbLoaiDanhGia";
            lbLoaiDanhGia.Size = new Size(117, 23);
            lbLoaiDanhGia.TabIndex = 0;
            lbLoaiDanhGia.Text = "Loại đánh giá:";
            // 
            // found_type_label
            // 
            found_type_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            found_type_label.ForeColor = SystemColors.WindowFrame;
            found_type_label.Location = new Point(2, 23);
            found_type_label.Margin = new Padding(2, 0, 2, 0);
            found_type_label.Name = "found_type_label";
            found_type_label.Size = new Size(168, 28);
            found_type_label.TabIndex = 1;
            // 
            // time_flowLayoutPanel
            // 
            time_flowLayoutPanel.Controls.Add(lbGioThi);
            time_flowLayoutPanel.Controls.Add(found_time_label);
            time_flowLayoutPanel.Location = new Point(211, 160);
            time_flowLayoutPanel.Margin = new Padding(2);
            time_flowLayoutPanel.Name = "time_flowLayoutPanel";
            time_flowLayoutPanel.Size = new Size(292, 28);
            time_flowLayoutPanel.TabIndex = 37;
            // 
            // lbGioThi
            // 
            lbGioThi.AutoSize = true;
            lbGioThi.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbGioThi.Location = new Point(2, 0);
            lbGioThi.Margin = new Padding(2, 0, 2, 0);
            lbGioThi.Name = "lbGioThi";
            lbGioThi.Size = new Size(65, 23);
            lbGioThi.TabIndex = 0;
            lbGioThi.Text = "Giờ thi:";
            // 
            // found_time_label
            // 
            found_time_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            found_time_label.ForeColor = SystemColors.WindowFrame;
            found_time_label.Location = new Point(71, 0);
            found_time_label.Margin = new Padding(2, 0, 2, 0);
            found_time_label.Name = "found_time_label";
            found_time_label.Size = new Size(168, 28);
            found_time_label.TabIndex = 1;
            // 
            // date_flowLayoutPanel
            // 
            date_flowLayoutPanel.Controls.Add(lbNgayThi);
            date_flowLayoutPanel.Controls.Add(found_date_label);
            date_flowLayoutPanel.Location = new Point(211, 135);
            date_flowLayoutPanel.Margin = new Padding(2);
            date_flowLayoutPanel.Name = "date_flowLayoutPanel";
            date_flowLayoutPanel.Size = new Size(292, 28);
            date_flowLayoutPanel.TabIndex = 36;
            // 
            // lbNgayThi
            // 
            lbNgayThi.AutoSize = true;
            lbNgayThi.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNgayThi.Location = new Point(2, 0);
            lbNgayThi.Margin = new Padding(2, 0, 2, 0);
            lbNgayThi.Name = "lbNgayThi";
            lbNgayThi.Size = new Size(79, 23);
            lbNgayThi.TabIndex = 0;
            lbNgayThi.Text = "Ngày thi:";
            // 
            // found_date_label
            // 
            found_date_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            found_date_label.ForeColor = SystemColors.WindowFrame;
            found_date_label.Location = new Point(85, 0);
            found_date_label.Margin = new Padding(2, 0, 2, 0);
            found_date_label.Name = "found_date_label";
            found_date_label.Size = new Size(168, 28);
            found_date_label.TabIndex = 1;
            // 
            // sdt_flowLayoutPanel
            // 
            sdt_flowLayoutPanel.Controls.Add(lbSDT);
            sdt_flowLayoutPanel.Controls.Add(found_sdt_label);
            sdt_flowLayoutPanel.Location = new Point(211, 110);
            sdt_flowLayoutPanel.Margin = new Padding(2);
            sdt_flowLayoutPanel.Name = "sdt_flowLayoutPanel";
            sdt_flowLayoutPanel.Size = new Size(292, 28);
            sdt_flowLayoutPanel.TabIndex = 35;
            // 
            // lbSDT
            // 
            lbSDT.AutoSize = true;
            lbSDT.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSDT.Location = new Point(2, 0);
            lbSDT.Margin = new Padding(2, 0, 2, 0);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(115, 23);
            lbSDT.TabIndex = 0;
            lbSDT.Text = "Số điện thoại:";
            // 
            // found_sdt_label
            // 
            found_sdt_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            found_sdt_label.ForeColor = SystemColors.WindowFrame;
            found_sdt_label.Location = new Point(121, 0);
            found_sdt_label.Margin = new Padding(2, 0, 2, 0);
            found_sdt_label.Name = "found_sdt_label";
            found_sdt_label.Size = new Size(168, 28);
            found_sdt_label.TabIndex = 1;
            // 
            // gender_flowLayoutPanel
            // 
            gender_flowLayoutPanel.Controls.Add(lbGioiTinh);
            gender_flowLayoutPanel.Controls.Add(found_gender_label);
            gender_flowLayoutPanel.Location = new Point(211, 85);
            gender_flowLayoutPanel.Margin = new Padding(2);
            gender_flowLayoutPanel.Name = "gender_flowLayoutPanel";
            gender_flowLayoutPanel.Size = new Size(292, 28);
            gender_flowLayoutPanel.TabIndex = 34;
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.AutoSize = true;
            lbGioiTinh.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbGioiTinh.Location = new Point(2, 0);
            lbGioiTinh.Margin = new Padding(2, 0, 2, 0);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(79, 23);
            lbGioiTinh.TabIndex = 0;
            lbGioiTinh.Text = "Giới tính:";
            // 
            // found_gender_label
            // 
            found_gender_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            found_gender_label.ForeColor = SystemColors.WindowFrame;
            found_gender_label.Location = new Point(85, 0);
            found_gender_label.Margin = new Padding(2, 0, 2, 0);
            found_gender_label.Name = "found_gender_label";
            found_gender_label.Size = new Size(168, 28);
            found_gender_label.TabIndex = 1;
            // 
            // sbd_flowLayoutPanel
            // 
            sbd_flowLayoutPanel.Controls.Add(lbSBD);
            sbd_flowLayoutPanel.Controls.Add(found_sbd_label);
            sbd_flowLayoutPanel.Location = new Point(211, 60);
            sbd_flowLayoutPanel.Margin = new Padding(2);
            sbd_flowLayoutPanel.Name = "sbd_flowLayoutPanel";
            sbd_flowLayoutPanel.Size = new Size(292, 28);
            sbd_flowLayoutPanel.TabIndex = 33;
            // 
            // lbSBD
            // 
            lbSBD.AutoSize = true;
            lbSBD.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSBD.Location = new Point(2, 0);
            lbSBD.Margin = new Padding(2, 0, 2, 0);
            lbSBD.Name = "lbSBD";
            lbSBD.Size = new Size(111, 23);
            lbSBD.TabIndex = 0;
            lbSBD.Text = "Số báo danh:";
            // 
            // found_sbd_label
            // 
            found_sbd_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            found_sbd_label.ForeColor = SystemColors.WindowFrame;
            found_sbd_label.Location = new Point(117, 0);
            found_sbd_label.Margin = new Padding(2, 0, 2, 0);
            found_sbd_label.Name = "found_sbd_label";
            found_sbd_label.Size = new Size(168, 28);
            found_sbd_label.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(211, 20);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 0;
            label3.Text = "Nguyễn Văn A";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.MediumTurquoise;
            btnLuu.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.Transparent;
            btnLuu.Location = new Point(150, 246);
            btnLuu.Margin = new Padding(0);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(164, 49);
            btnLuu.TabIndex = 36;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // res_flowLayoutPanel
            // 
            res_flowLayoutPanel.Controls.Add(res_label);
            res_flowLayoutPanel.Controls.Add(cbbTrangThai);
            res_flowLayoutPanel.Location = new Point(40, 67);
            res_flowLayoutPanel.Margin = new Padding(2);
            res_flowLayoutPanel.Name = "res_flowLayoutPanel";
            res_flowLayoutPanel.Size = new Size(356, 41);
            res_flowLayoutPanel.TabIndex = 34;
            // 
            // res_label
            // 
            res_label.AutoSize = true;
            res_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            res_label.Location = new Point(0, 9);
            res_label.Margin = new Padding(0, 9, 0, 0);
            res_label.Name = "res_label";
            res_label.Size = new Size(91, 23);
            res_label.TabIndex = 0;
            res_label.Text = "Trạng thái:";
            // 
            // cbbTrangThai
            // 
            cbbTrangThai.BackColor = Color.Transparent;
            cbbTrangThai.CustomizableEdges = customizableEdges1;
            cbbTrangThai.DrawMode = DrawMode.OwnerDrawFixed;
            cbbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTrangThai.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbTrangThai.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbTrangThai.Font = new Font("Segoe UI", 10F);
            cbbTrangThai.ForeColor = Color.FromArgb(68, 88, 112);
            cbbTrangThai.ItemHeight = 30;
            cbbTrangThai.Location = new Point(94, 3);
            cbbTrangThai.Name = "cbbTrangThai";
            cbbTrangThai.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbbTrangThai.Size = new Size(235, 36);
            cbbTrangThai.TabIndex = 36;
            // 
            // lbPhieuDuThi
            // 
            lbPhieuDuThi.AutoSize = true;
            lbPhieuDuThi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhieuDuThi.Location = new Point(40, 20);
            lbPhieuDuThi.Margin = new Padding(0);
            lbPhieuDuThi.Name = "lbPhieuDuThi";
            lbPhieuDuThi.RightToLeft = RightToLeft.No;
            lbPhieuDuThi.Size = new Size(128, 28);
            lbPhieuDuThi.TabIndex = 34;
            lbPhieuDuThi.Text = "Phiếu dự thi";
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.Transparent;
            pnlThongTin.Controls.Add(cert_pictureBox);
            pnlThongTin.Controls.Add(btnCapNhatTrangThai);
            pnlThongTin.Controls.Add(label3);
            pnlThongTin.Controls.Add(date_flowLayoutPanel);
            pnlThongTin.Controls.Add(status_flowLayoutPanel);
            pnlThongTin.Controls.Add(sdt_flowLayoutPanel);
            pnlThongTin.Controls.Add(sbd_flowLayoutPanel);
            pnlThongTin.Controls.Add(time_flowLayoutPanel);
            pnlThongTin.Controls.Add(type_flowLayoutPanel);
            pnlThongTin.Controls.Add(gender_flowLayoutPanel);
            pnlThongTin.FillColor = Color.White;
            pnlThongTin.Location = new Point(15, 183);
            pnlThongTin.Margin = new Padding(2);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Radius = 10;
            pnlThongTin.ShadowColor = Color.DimGray;
            pnlThongTin.ShadowShift = 10;
            pnlThongTin.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            pnlThongTin.Size = new Size(527, 326);
            pnlThongTin.TabIndex = 35;
            // 
            // cert_pictureBox
            // 
            cert_pictureBox.Image = Properties.Resources.certificate__3_;
            cert_pictureBox.Location = new Point(34, 20);
            cert_pictureBox.Margin = new Padding(2);
            cert_pictureBox.Name = "cert_pictureBox";
            cert_pictureBox.Size = new Size(164, 218);
            cert_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cert_pictureBox.TabIndex = 40;
            cert_pictureBox.TabStop = false;
            // 
            // pnlThongTinPDT
            // 
            pnlThongTinPDT.BackColor = Color.Transparent;
            pnlThongTinPDT.Controls.Add(btnLuu);
            pnlThongTinPDT.Controls.Add(lbPhieuDuThi);
            pnlThongTinPDT.Controls.Add(res_flowLayoutPanel);
            pnlThongTinPDT.FillColor = Color.White;
            pnlThongTinPDT.Location = new Point(557, 183);
            pnlThongTinPDT.Margin = new Padding(2);
            pnlThongTinPDT.Name = "pnlThongTinPDT";
            pnlThongTinPDT.Radius = 10;
            pnlThongTinPDT.ShadowColor = Color.DimGray;
            pnlThongTinPDT.ShadowShift = 10;
            pnlThongTinPDT.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            pnlThongTinPDT.Size = new Size(430, 326);
            pnlThongTinPDT.TabIndex = 36;
            pnlThongTinPDT.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lbSoBaoDanh);
            flowLayoutPanel1.Controls.Add(txtSoBaoDanh);
            flowLayoutPanel1.Location = new Point(34, 94);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(526, 58);
            flowLayoutPanel1.TabIndex = 39;
            // 
            // lbSoBaoDanh
            // 
            lbSoBaoDanh.AutoSize = true;
            lbSoBaoDanh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoBaoDanh.Location = new Point(0, 16);
            lbSoBaoDanh.Margin = new Padding(0, 16, 0, 0);
            lbSoBaoDanh.Name = "lbSoBaoDanh";
            lbSoBaoDanh.Size = new Size(127, 28);
            lbSoBaoDanh.TabIndex = 0;
            lbSoBaoDanh.Text = "Số báo danh";
            // 
            // txtSoBaoDanh
            // 
            txtSoBaoDanh.BorderRadius = 20;
            txtSoBaoDanh.CustomizableEdges = customizableEdges3;
            txtSoBaoDanh.DefaultText = "";
            txtSoBaoDanh.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSoBaoDanh.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSoBaoDanh.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSoBaoDanh.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSoBaoDanh.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSoBaoDanh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoBaoDanh.HoverState.BorderColor = Color.PowderBlue;
            txtSoBaoDanh.IconLeftOffset = new Point(16, 0);
            txtSoBaoDanh.IconRight = Properties.Resources.close__1_;
            txtSoBaoDanh.IconRightOffset = new Point(10, 0);
            txtSoBaoDanh.Location = new Point(133, 6);
            txtSoBaoDanh.Margin = new Padding(6);
            txtSoBaoDanh.Name = "txtSoBaoDanh";
            txtSoBaoDanh.Padding = new Padding(2);
            txtSoBaoDanh.PlaceholderText = "";
            txtSoBaoDanh.SelectedText = "";
            txtSoBaoDanh.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSoBaoDanh.Size = new Size(382, 45);
            txtSoBaoDanh.TabIndex = 32;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.MediumTurquoise;
            btnTimKiem.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Transparent;
            btnTimKiem.Location = new Point(579, 94);
            btnTimKiem.Margin = new Padding(0);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(164, 58);
            btnTimKiem.TabIndex = 38;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // CapNhatTrangThaiPhieuDuThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnTimKiem);
            Controls.Add(pnlThongTinPDT);
            Controls.Add(pnlThongTin);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "CapNhatTrangThaiPhieuDuThi";
            Size = new Size(998, 731);
            Load += CapNhatTrangThaiPhieuDuThi_Load;
            status_flowLayoutPanel.ResumeLayout(false);
            status_flowLayoutPanel.PerformLayout();
            type_flowLayoutPanel.ResumeLayout(false);
            type_flowLayoutPanel.PerformLayout();
            time_flowLayoutPanel.ResumeLayout(false);
            time_flowLayoutPanel.PerformLayout();
            date_flowLayoutPanel.ResumeLayout(false);
            date_flowLayoutPanel.PerformLayout();
            sdt_flowLayoutPanel.ResumeLayout(false);
            sdt_flowLayoutPanel.PerformLayout();
            gender_flowLayoutPanel.ResumeLayout(false);
            gender_flowLayoutPanel.PerformLayout();
            sbd_flowLayoutPanel.ResumeLayout(false);
            sbd_flowLayoutPanel.PerformLayout();
            res_flowLayoutPanel.ResumeLayout(false);
            res_flowLayoutPanel.PerformLayout();
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cert_pictureBox).EndInit();
            pnlThongTinPDT.ResumeLayout(false);
            pnlThongTinPDT.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label3;
        private FlowLayoutPanel sbd_flowLayoutPanel;
        private Label lbSBD;
        private Label found_sbd_label;
        private FlowLayoutPanel date_flowLayoutPanel;
        private Label lbNgayThi;
        private Label found_date_label;
        private FlowLayoutPanel sdt_flowLayoutPanel;
        private Label lbSDT;
        private Label found_sdt_label;
        private FlowLayoutPanel gender_flowLayoutPanel;
        private Label lbGioiTinh;
        private Label found_gender_label;
        private Button btnCapNhatTrangThai;
        private FlowLayoutPanel status_flowLayoutPanel;
        private Label lbTrangThai;
        private Label found_status_label;
        private FlowLayoutPanel type_flowLayoutPanel;
        private Label lbLoaiDanhGia;
        private Label found_type_label;
        private FlowLayoutPanel time_flowLayoutPanel;
        private Label lbGioThi;
        private Label found_time_label;
        private Panel insert_result_panel;
        private Label lbPhieuDuThi;
        private FlowLayoutPanel res_flowLayoutPanel;
        private Label res_label;
        private Button btnLuu;
        private Panel card_panel;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlThongTin;
        private PictureBox cert_pictureBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbSoBaoDanh;
        private Guna.UI2.WinForms.Guna2TextBox txtSoBaoDanh;
        private Button btnTimKiem;
        internal Guna.UI2.WinForms.Guna2ShadowPanel pnlThongTinPDT;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTrangThai;
    }
}
