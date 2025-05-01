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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            label2 = new Label();
            btnTraCuu = new Button();
            info_panel = new Panel();
            lbEmail = new Label();
            txtEmail = new TextBox();
            txtTraCuuSoDT = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDSNhanVien).BeginInit();
            info_panel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 98);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1618, 21);
            guna2Separator1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 26);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(389, 59);
            label1.TabIndex = 9;
            label1.Text = "Quản lý nhân viên";
            // 
            // txtMaNV
            // 
            txtMaNV.BorderRadius = 20;
            txtMaNV.CustomizableEdges = customizableEdges9;
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
            txtMaNV.Location = new Point(223, 138);
            txtMaNV.Margin = new Padding(6, 6, 6, 6);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "";
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtMaNV.Size = new Size(460, 51);
            txtMaNV.TabIndex = 43;
            // 
            // search_student_label
            // 
            search_student_label.AutoSize = true;
            search_student_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_student_label.Location = new Point(24, 142);
            search_student_label.Margin = new Padding(0);
            search_student_label.Name = "search_student_label";
            search_student_label.Size = new Size(190, 37);
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
            dgvDSNhanVien.Location = new Point(24, 213);
            dgvDSNhanVien.Margin = new Padding(0);
            dgvDSNhanVien.MultiSelect = false;
            dgvDSNhanVien.Name = "dgvDSNhanVien";
            dgvDSNhanVien.RowHeadersVisible = false;
            dgvDSNhanVien.RowHeadersWidth = 82;
            dgvDSNhanVien.Size = new Size(1566, 525);
            dgvDSNhanVien.TabIndex = 45;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(20, 93);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(344, 43);
            txtHoTen.TabIndex = 84;
            // 
            // hoTen_label
            // 
            hoTen_label.AutoSize = true;
            hoTen_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoTen_label.Location = new Point(20, 43);
            hoTen_label.Margin = new Padding(0);
            hoTen_label.Name = "hoTen_label";
            hoTen_label.Size = new Size(100, 37);
            hoTen_label.TabIndex = 83;
            hoTen_label.Text = "Họ tên";
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGioiTinh.Location = new Point(895, 94);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(300, 45);
            cbbGioiTinh.TabIndex = 82;
            // 
            // gioiTinh_label
            // 
            gioiTinh_label.AutoSize = true;
            gioiTinh_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gioiTinh_label.Location = new Point(895, 43);
            gioiTinh_label.Margin = new Padding(0);
            gioiTinh_label.Name = "gioiTinh_label";
            gioiTinh_label.Size = new Size(123, 37);
            gioiTinh_label.TabIndex = 81;
            gioiTinh_label.Text = "Giới tính";
            // 
            // khoa_label
            // 
            khoa_label.AutoSize = true;
            khoa_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            khoa_label.Location = new Point(20, 166);
            khoa_label.Margin = new Padding(0);
            khoa_label.Name = "khoa_label";
            khoa_label.Size = new Size(194, 37);
            khoa_label.TabIndex = 79;
            khoa_label.Text = "Loại nhân viên";
            // 
            // txtSoDT
            // 
            txtSoDT.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoDT.Location = new Point(478, 93);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(287, 43);
            txtSoDT.TabIndex = 86;
            // 
            // sdt_label
            // 
            sdt_label.AutoSize = true;
            sdt_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sdt_label.Location = new Point(478, 43);
            sdt_label.Margin = new Padding(0);
            sdt_label.Name = "sdt_label";
            sdt_label.Size = new Size(178, 37);
            sdt_label.TabIndex = 85;
            sdt_label.Text = "Số điện thoại";
            // 
            // cbbLoaiNV
            // 
            cbbLoaiNV.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbLoaiNV.FormattingEnabled = true;
            cbbLoaiNV.Location = new Point(20, 216);
            cbbLoaiNV.Name = "cbbLoaiNV";
            cbbLoaiNV.Size = new Size(344, 45);
            cbbLoaiNV.TabIndex = 88;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(20, 344);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(1176, 43);
            txtDiaChi.TabIndex = 90;
            // 
            // diaChi_label
            // 
            diaChi_label.AutoSize = true;
            diaChi_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diaChi_label.Location = new Point(20, 294);
            diaChi_label.Margin = new Padding(0);
            diaChi_label.Name = "diaChi_label";
            diaChi_label.Size = new Size(100, 37);
            diaChi_label.TabIndex = 89;
            diaChi_label.Text = "Địa chỉ";
            // 
            // ngaySinh_label
            // 
            ngaySinh_label.AutoSize = true;
            ngaySinh_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ngaySinh_label.Location = new Point(478, 166);
            ngaySinh_label.Margin = new Padding(0);
            ngaySinh_label.Name = "ngaySinh_label";
            ngaySinh_label.Size = new Size(140, 37);
            ngaySinh_label.TabIndex = 91;
            ngaySinh_label.Text = "Ngày sinh";
            // 
            // mcNgaySinh
            // 
            mcNgaySinh.CalendarFont = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcNgaySinh.CustomFormat = "dd/MM/yyyy";
            mcNgaySinh.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcNgaySinh.Format = DateTimePickerFormat.Custom;
            mcNgaySinh.Location = new Point(478, 216);
            mcNgaySinh.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            mcNgaySinh.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            mcNgaySinh.Name = "mcNgaySinh";
            mcNgaySinh.Size = new Size(287, 43);
            mcNgaySinh.TabIndex = 92;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DarkTurquoise;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Transparent;
            btnThem.Location = new Point(1300, 301);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(240, 64);
            btnThem.TabIndex = 93;
            btnThem.Text = "Thêm nhân viên";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ActiveBorder;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Transparent;
            btnXoa.Location = new Point(1300, 218);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(240, 64);
            btnXoa.TabIndex = 94;
            btnXoa.Text = "Xóa nhân viên";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.DarkTurquoise;
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.Transparent;
            btnCapNhat.Location = new Point(1300, 128);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(240, 64);
            btnCapNhat.TabIndex = 95;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(743, 142);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(73, 37);
            label2.TabIndex = 97;
            label2.Text = "SĐT:";
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.DarkTurquoise;
            btnTraCuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.ForeColor = Color.Transparent;
            btnTraCuu.Location = new Point(1451, 130);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(140, 64);
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
            info_panel.Location = new Point(24, 757);
            info_panel.Margin = new Padding(0);
            info_panel.Name = "info_panel";
            info_panel.Size = new Size(1566, 399);
            info_panel.TabIndex = 101;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(895, 166);
            lbEmail.Margin = new Padding(0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(83, 37);
            lbEmail.TabIndex = 96;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(895, 216);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 43);
            txtEmail.TabIndex = 97;
            // 
            // txtTraCuuSoDT
            // 
            txtTraCuuSoDT.BorderRadius = 20;
            txtTraCuuSoDT.CustomizableEdges = customizableEdges11;
            txtTraCuuSoDT.DefaultText = "";
            txtTraCuuSoDT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTraCuuSoDT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTraCuuSoDT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTraCuuSoDT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTraCuuSoDT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTraCuuSoDT.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTraCuuSoDT.HoverState.BorderColor = Color.Gray;
            txtTraCuuSoDT.IconLeftOffset = new Point(10, 0);
            txtTraCuuSoDT.IconRight = Properties.Resources.close__1_;
            txtTraCuuSoDT.IconRightOffset = new Point(10, 0);
            txtTraCuuSoDT.Location = new Point(829, 138);
            txtTraCuuSoDT.Margin = new Padding(6, 6, 6, 6);
            txtTraCuuSoDT.Name = "txtTraCuuSoDT";
            txtTraCuuSoDT.PlaceholderText = "";
            txtTraCuuSoDT.SelectedText = "";
            txtTraCuuSoDT.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtTraCuuSoDT.Size = new Size(481, 51);
            txtTraCuuSoDT.TabIndex = 102;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtTraCuuSoDT);
            Controls.Add(info_panel);
            Controls.Add(label2);
            Controls.Add(dgvDSNhanVien);
            Controls.Add(btnTraCuu);
            Controls.Add(txtMaNV);
            Controls.Add(search_student_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "QuanLyNhanVien";
            Size = new Size(1618, 1170);
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
        private Label label2;
        private Button btnTraCuu;
        private Panel info_panel;
        private Guna.UI2.WinForms.Guna2TextBox txtTraCuuSoDT;
        private Label lbEmail;
        private TextBox txtEmail;
    }
}
