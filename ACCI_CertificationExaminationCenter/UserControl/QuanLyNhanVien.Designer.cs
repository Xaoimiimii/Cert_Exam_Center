using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace ACCI_CertificationExaminationCenter
{
    partial class QuanLyNhanVien
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
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            search_student_label = new Label();
            dgvDSNhanVien = new DataGridView();
            txtHoTen = new TextBox();
            hoTen_label = new Label();
            cbbGioiTinh = new ComboBox();
            gioiTinh_label = new Label();
            khoa_label = new Label();
            txtSoDT = new TextBox();
            sdt_label = new Label();
            cbbLoaiNV = new ComboBox();
            txtDiaChi = new TextBox();
            diaChi_label = new Label();
            ngaySinh_label = new Label();
            mcNgaySinh = new DateTimePicker();
            btnThem = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnTraCuu = new Button();
            info_panel = new Panel();
            lbEmail = new Label();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDSNhanVien).BeginInit();
            info_panel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 61);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(996, 13);
            guna2Separator1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 16);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(245, 37);
            label1.TabIndex = 9;
            label1.Text = "Quản lý nhân viên";
            // 
            // txtMaNV
            // 
            txtMaNV.BorderRadius = 20;
            txtMaNV.CustomizableEdges = customizableEdges1;
            txtMaNV.DefaultText = "";
            txtMaNV.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaNV.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaNV.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaNV.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaNV.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaNV.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNV.HoverState.BorderColor = Color.Gray;
            txtMaNV.IconLeftOffset = new Point(10, 0);
            txtMaNV.IconRight = Properties.Resources.close__1_;
            txtMaNV.IconRightOffset = new Point(10, 0);
            txtMaNV.Location = new Point(137, 86);
            txtMaNV.Margin = new Padding(4, 4, 4, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "";
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaNV.Size = new Size(283, 32);
            txtMaNV.TabIndex = 43;
            // 
            // search_student_label
            // 
            search_student_label.AutoSize = true;
            search_student_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_student_label.Location = new Point(15, 89);
            search_student_label.Margin = new Padding(0);
            search_student_label.Name = "search_student_label";
            search_student_label.Size = new Size(120, 23);
            search_student_label.TabIndex = 42;
            search_student_label.Text = "Mã nhân viên:";
            // 
            // dgvDSNhanVien
            // 
            dgvDSNhanVien.AllowUserToResizeRows = false;
            dgvDSNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSNhanVien.BackgroundColor = Color.Azure;
            dgvDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
            dgvDSNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSNhanVien.Location = new Point(15, 133);
            dgvDSNhanVien.Margin = new Padding(0);
            dgvDSNhanVien.MultiSelect = false;
            dgvDSNhanVien.Name = "dgvDSNhanVien";
            dgvDSNhanVien.RowHeadersVisible = false;
            dgvDSNhanVien.RowHeadersWidth = 82;
            dgvDSNhanVien.Size = new Size(964, 328);
            dgvDSNhanVien.TabIndex = 45;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(12, 58);
            txtHoTen.Margin = new Padding(2, 2, 2, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(213, 30);
            txtHoTen.TabIndex = 84;
            // 
            // hoTen_label
            // 
            hoTen_label.AutoSize = true;
            hoTen_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoTen_label.Location = new Point(12, 27);
            hoTen_label.Margin = new Padding(0);
            hoTen_label.Name = "hoTen_label";
            hoTen_label.Size = new Size(63, 23);
            hoTen_label.TabIndex = 83;
            hoTen_label.Text = "Họ tên";
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGioiTinh.Location = new Point(551, 59);
            cbbGioiTinh.Margin = new Padding(2, 2, 2, 2);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(186, 31);
            cbbGioiTinh.TabIndex = 82;
            // 
            // gioiTinh_label
            // 
            gioiTinh_label.AutoSize = true;
            gioiTinh_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gioiTinh_label.Location = new Point(551, 27);
            gioiTinh_label.Margin = new Padding(0);
            gioiTinh_label.Name = "gioiTinh_label";
            gioiTinh_label.Size = new Size(75, 23);
            gioiTinh_label.TabIndex = 81;
            gioiTinh_label.Text = "Giới tính";
            // 
            // khoa_label
            // 
            khoa_label.AutoSize = true;
            khoa_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            khoa_label.Location = new Point(12, 104);
            khoa_label.Margin = new Padding(0);
            khoa_label.Name = "khoa_label";
            khoa_label.Size = new Size(122, 23);
            khoa_label.TabIndex = 79;
            khoa_label.Text = "Loại nhân viên";
            // 
            // txtSoDT
            // 
            txtSoDT.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoDT.Location = new Point(294, 58);
            txtSoDT.Margin = new Padding(2, 2, 2, 2);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(178, 30);
            txtSoDT.TabIndex = 86;
            // 
            // sdt_label
            // 
            sdt_label.AutoSize = true;
            sdt_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sdt_label.Location = new Point(294, 27);
            sdt_label.Margin = new Padding(0);
            sdt_label.Name = "sdt_label";
            sdt_label.Size = new Size(111, 23);
            sdt_label.TabIndex = 85;
            sdt_label.Text = "Số điện thoại";
            // 
            // cbbLoaiNV
            // 
            cbbLoaiNV.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbLoaiNV.FormattingEnabled = true;
            cbbLoaiNV.Location = new Point(12, 135);
            cbbLoaiNV.Margin = new Padding(2, 2, 2, 2);
            cbbLoaiNV.Name = "cbbLoaiNV";
            cbbLoaiNV.Size = new Size(213, 31);
            cbbLoaiNV.TabIndex = 88;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(12, 215);
            txtDiaChi.Margin = new Padding(2, 2, 2, 2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(725, 30);
            txtDiaChi.TabIndex = 90;
            // 
            // diaChi_label
            // 
            diaChi_label.AutoSize = true;
            diaChi_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diaChi_label.Location = new Point(12, 184);
            diaChi_label.Margin = new Padding(0);
            diaChi_label.Name = "diaChi_label";
            diaChi_label.Size = new Size(62, 23);
            diaChi_label.TabIndex = 89;
            diaChi_label.Text = "Địa chỉ";
            // 
            // ngaySinh_label
            // 
            ngaySinh_label.AutoSize = true;
            ngaySinh_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ngaySinh_label.Location = new Point(294, 104);
            ngaySinh_label.Margin = new Padding(0);
            ngaySinh_label.Name = "ngaySinh_label";
            ngaySinh_label.Size = new Size(87, 23);
            ngaySinh_label.TabIndex = 91;
            ngaySinh_label.Text = "Ngày sinh";
            // 
            // mcNgaySinh
            // 
            mcNgaySinh.CalendarFont = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcNgaySinh.CustomFormat = "dd/MM/yyyy";
            mcNgaySinh.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcNgaySinh.Format = DateTimePickerFormat.Custom;
            mcNgaySinh.Location = new Point(294, 135);
            mcNgaySinh.Margin = new Padding(2, 2, 2, 2);
            mcNgaySinh.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            mcNgaySinh.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            mcNgaySinh.Name = "mcNgaySinh";
            mcNgaySinh.Size = new Size(178, 30);
            mcNgaySinh.TabIndex = 92;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DarkTurquoise;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Transparent;
            btnThem.Location = new Point(800, 188);
            btnThem.Margin = new Padding(2, 2, 2, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(148, 40);
            btnThem.TabIndex = 93;
            btnThem.Text = "Thêm nhân viên";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ActiveBorder;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Transparent;
            btnXoa.Location = new Point(800, 136);
            btnXoa.Margin = new Padding(2, 2, 2, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(148, 40);
            btnXoa.TabIndex = 94;
            btnXoa.Text = "Xóa nhân viên";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.DarkTurquoise;
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.Transparent;
            btnCapNhat.Location = new Point(800, 80);
            btnCapNhat.Margin = new Padding(2, 2, 2, 2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(148, 40);
            btnCapNhat.TabIndex = 95;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.DarkTurquoise;
            btnTraCuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.ForeColor = Color.Transparent;
            btnTraCuu.Location = new Point(443, 81);
            btnTraCuu.Margin = new Padding(2, 2, 2, 2);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(86, 40);
            btnTraCuu.TabIndex = 44;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            // 
            // info_panel
            // 
            info_panel.Controls.Add(lbEmail);
            info_panel.Controls.Add(txtEmail);
            info_panel.Controls.Add(khoa_label);
            info_panel.Controls.Add(gioiTinh_label);
            info_panel.Controls.Add(cbbGioiTinh);
            info_panel.Controls.Add(btnCapNhat);
            info_panel.Controls.Add(hoTen_label);
            info_panel.Controls.Add(btnXoa);
            info_panel.Controls.Add(txtHoTen);
            info_panel.Controls.Add(btnThem);
            info_panel.Controls.Add(sdt_label);
            info_panel.Controls.Add(mcNgaySinh);
            info_panel.Controls.Add(txtSoDT);
            info_panel.Controls.Add(ngaySinh_label);
            info_panel.Controls.Add(txtDiaChi);
            info_panel.Controls.Add(cbbLoaiNV);
            info_panel.Controls.Add(diaChi_label);
            info_panel.Location = new Point(15, 473);
            info_panel.Margin = new Padding(0);
            info_panel.Name = "info_panel";
            info_panel.Size = new Size(964, 249);
            info_panel.TabIndex = 101;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(551, 104);
            lbEmail.Margin = new Padding(0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(51, 23);
            lbEmail.TabIndex = 96;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(551, 135);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 30);
            txtEmail.TabIndex = 97;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(info_panel);
            Controls.Add(dgvDSNhanVien);
            Controls.Add(btnTraCuu);
            Controls.Add(txtMaNV);
            Controls.Add(search_student_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "QuanLyNhanVien";
            Size = new Size(996, 731);
            ((System.ComponentModel.ISupportInitialize)dgvDSNhanVien).EndInit();
            info_panel.ResumeLayout(false);
            info_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Label search_student_label;
        private DataGridView dgvDSNhanVien;
        private TextBox txtHoTen;
        private Label hoTen_label;
        private ComboBox cbbGioiTinh;
        private Label gioiTinh_label;
        private Label khoa_label;
        private Label tinhTrang_label;
        private TextBox txtSoDT;
        private Label sdt_label;
        private ComboBox tinhTrang_comboBox;
        private ComboBox cbbLoaiNV;
        private TextBox txtDiaChi;
        private Label diaChi_label;
        private Label ngaySinh_label;
        private DateTimePicker mcNgaySinh;
        private Button btnThem;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnTraCuu;
        private Panel info_panel;
        private Label lbEmail;
        private TextBox txtEmail;
    }
}
