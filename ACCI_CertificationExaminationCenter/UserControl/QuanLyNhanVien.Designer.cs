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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            search_student_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            search_student_label = new Label();
            student_dataGridView = new DataGridView();
            hoTen_textBox = new TextBox();
            hoTen_label = new Label();
            gioiTinh_comboBox = new ComboBox();
            gioiTinh_label = new Label();
            khoa_label = new Label();
            sdt_textBox = new TextBox();
            sdt_label = new Label();
            khoa_comboBox = new ComboBox();
            diaChi_textBox = new TextBox();
            diaChi_label = new Label();
            ngaySinh_label = new Label();
            ngaySinh_dateTimePicker = new DateTimePicker();
            add_button = new Button();
            alter_button = new Button();
            confirm_button = new Button();
            label2 = new Label();
            search_student_button = new Button();
            info_panel = new Panel();
            txtSoDT = new Guna.UI2.WinForms.Guna2TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)student_dataGridView).BeginInit();
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
            // search_student_guna2TextBox
            // 
            search_student_guna2TextBox.BorderRadius = 20;
            search_student_guna2TextBox.CustomizableEdges = customizableEdges5;
            search_student_guna2TextBox.DefaultText = "";
            search_student_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_student_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_student_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_student_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_student_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search_student_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_student_guna2TextBox.HoverState.BorderColor = Color.Gray;
            search_student_guna2TextBox.IconLeftOffset = new Point(10, 0);
            search_student_guna2TextBox.IconRight = Properties.Resources.close__1_;
            search_student_guna2TextBox.IconRightOffset = new Point(10, 0);
            search_student_guna2TextBox.Location = new Point(137, 86);
            search_student_guna2TextBox.Margin = new Padding(4, 4, 4, 4);
            search_student_guna2TextBox.Name = "search_student_guna2TextBox";
            search_student_guna2TextBox.PlaceholderText = "";
            search_student_guna2TextBox.SelectedText = "";
            search_student_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            search_student_guna2TextBox.Size = new Size(283, 32);
            search_student_guna2TextBox.TabIndex = 43;
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
            // student_dataGridView
            // 
            student_dataGridView.AllowUserToResizeRows = false;
            student_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            student_dataGridView.BackgroundColor = Color.Azure;
            student_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            student_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            student_dataGridView.Location = new Point(15, 133);
            student_dataGridView.Margin = new Padding(0);
            student_dataGridView.MultiSelect = false;
            student_dataGridView.Name = "student_dataGridView";
            student_dataGridView.RowHeadersVisible = false;
            student_dataGridView.RowHeadersWidth = 82;
            student_dataGridView.Size = new Size(964, 269);
            student_dataGridView.TabIndex = 45;
            // 
            // hoTen_textBox
            // 
            hoTen_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoTen_textBox.Location = new Point(12, 58);
            hoTen_textBox.Margin = new Padding(2, 2, 2, 2);
            hoTen_textBox.Name = "hoTen_textBox";
            hoTen_textBox.Size = new Size(213, 30);
            hoTen_textBox.TabIndex = 84;
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
            // gioiTinh_comboBox
            // 
            gioiTinh_comboBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gioiTinh_comboBox.FormattingEnabled = true;
            gioiTinh_comboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            gioiTinh_comboBox.Location = new Point(551, 59);
            gioiTinh_comboBox.Margin = new Padding(2, 2, 2, 2);
            gioiTinh_comboBox.Name = "gioiTinh_comboBox";
            gioiTinh_comboBox.Size = new Size(186, 31);
            gioiTinh_comboBox.TabIndex = 82;
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
            // sdt_textBox
            // 
            sdt_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sdt_textBox.Location = new Point(294, 58);
            sdt_textBox.Margin = new Padding(2, 2, 2, 2);
            sdt_textBox.Name = "sdt_textBox";
            sdt_textBox.Size = new Size(178, 30);
            sdt_textBox.TabIndex = 86;
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
            // khoa_comboBox
            // 
            khoa_comboBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khoa_comboBox.FormattingEnabled = true;
            khoa_comboBox.Location = new Point(12, 135);
            khoa_comboBox.Margin = new Padding(2, 2, 2, 2);
            khoa_comboBox.Name = "khoa_comboBox";
            khoa_comboBox.Size = new Size(213, 31);
            khoa_comboBox.TabIndex = 88;
            // 
            // diaChi_textBox
            // 
            diaChi_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diaChi_textBox.Location = new Point(12, 215);
            diaChi_textBox.Margin = new Padding(2, 2, 2, 2);
            diaChi_textBox.Name = "diaChi_textBox";
            diaChi_textBox.Size = new Size(725, 30);
            diaChi_textBox.TabIndex = 90;
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
            // ngaySinh_dateTimePicker
            // 
            ngaySinh_dateTimePicker.CalendarFont = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaySinh_dateTimePicker.CustomFormat = "dd/MM/yyyy";
            ngaySinh_dateTimePicker.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaySinh_dateTimePicker.Format = DateTimePickerFormat.Custom;
            ngaySinh_dateTimePicker.Location = new Point(294, 135);
            ngaySinh_dateTimePicker.Margin = new Padding(2, 2, 2, 2);
            ngaySinh_dateTimePicker.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            ngaySinh_dateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            ngaySinh_dateTimePicker.Name = "ngaySinh_dateTimePicker";
            ngaySinh_dateTimePicker.Size = new Size(178, 30);
            ngaySinh_dateTimePicker.TabIndex = 92;
            // 
            // add_button
            // 
            add_button.BackColor = Color.DarkTurquoise;
            add_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(800, 188);
            add_button.Margin = new Padding(2, 2, 2, 2);
            add_button.Name = "add_button";
            add_button.Size = new Size(148, 40);
            add_button.TabIndex = 93;
            add_button.Text = "Thêm nhân viên";
            add_button.UseVisualStyleBackColor = false;
            // 
            // alter_button
            // 
            alter_button.BackColor = SystemColors.ActiveBorder;
            alter_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alter_button.ForeColor = Color.Transparent;
            alter_button.Location = new Point(800, 136);
            alter_button.Margin = new Padding(2, 2, 2, 2);
            alter_button.Name = "alter_button";
            alter_button.Size = new Size(148, 40);
            alter_button.TabIndex = 94;
            alter_button.Text = "Xóa nhân viên";
            alter_button.UseVisualStyleBackColor = false;
            // 
            // confirm_button
            // 
            confirm_button.BackColor = Color.DarkTurquoise;
            confirm_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_button.ForeColor = Color.Transparent;
            confirm_button.Location = new Point(800, 80);
            confirm_button.Margin = new Padding(2, 2, 2, 2);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(148, 40);
            confirm_button.TabIndex = 95;
            confirm_button.Text = "Cập nhật";
            confirm_button.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(457, 89);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 97;
            label2.Text = "SĐT:";
            // 
            // search_student_button
            // 
            search_student_button.BackColor = Color.DarkTurquoise;
            search_student_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_student_button.ForeColor = Color.Transparent;
            search_student_button.Location = new Point(893, 81);
            search_student_button.Margin = new Padding(2, 2, 2, 2);
            search_student_button.Name = "search_student_button";
            search_student_button.Size = new Size(86, 40);
            search_student_button.TabIndex = 44;
            search_student_button.Text = "Tra cứu";
            search_student_button.UseVisualStyleBackColor = false;
            // 
            // info_panel
            // 
            info_panel.Controls.Add(lbEmail);
            info_panel.Controls.Add(txtEmail);
            info_panel.Controls.Add(khoa_label);
            info_panel.Controls.Add(gioiTinh_label);
            info_panel.Controls.Add(gioiTinh_comboBox);
            info_panel.Controls.Add(confirm_button);
            info_panel.Controls.Add(hoTen_label);
            info_panel.Controls.Add(alter_button);
            info_panel.Controls.Add(hoTen_textBox);
            info_panel.Controls.Add(add_button);
            info_panel.Controls.Add(sdt_label);
            info_panel.Controls.Add(ngaySinh_dateTimePicker);
            info_panel.Controls.Add(sdt_textBox);
            info_panel.Controls.Add(ngaySinh_label);
            info_panel.Controls.Add(diaChi_textBox);
            info_panel.Controls.Add(khoa_comboBox);
            info_panel.Controls.Add(diaChi_label);
            info_panel.Location = new Point(15, 419);
            info_panel.Margin = new Padding(0);
            info_panel.Name = "info_panel";
            info_panel.Size = new Size(964, 304);
            info_panel.TabIndex = 101;
            // 
            // txtSoDT
            // 
            txtSoDT.BorderRadius = 20;
            txtSoDT.CustomizableEdges = customizableEdges7;
            txtSoDT.DefaultText = "";
            txtSoDT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSoDT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSoDT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSoDT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSoDT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSoDT.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoDT.HoverState.BorderColor = Color.Gray;
            txtSoDT.IconLeftOffset = new Point(10, 0);
            txtSoDT.IconRight = Properties.Resources.close__1_;
            txtSoDT.IconRightOffset = new Point(10, 0);
            txtSoDT.Location = new Point(510, 86);
            txtSoDT.Margin = new Padding(4);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.PlaceholderText = "";
            txtSoDT.SelectedText = "";
            txtSoDT.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSoDT.Size = new Size(296, 32);
            txtSoDT.TabIndex = 102;
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
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 30);
            txtEmail.TabIndex = 97;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtSoDT);
            Controls.Add(info_panel);
            Controls.Add(label2);
            Controls.Add(student_dataGridView);
            Controls.Add(search_student_button);
            Controls.Add(search_student_guna2TextBox);
            Controls.Add(search_student_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "QuanLyNhanVien";
            Size = new Size(996, 731);
            ((System.ComponentModel.ISupportInitialize)student_dataGridView).EndInit();
            info_panel.ResumeLayout(false);
            info_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox search_student_guna2TextBox;
        private Label search_student_label;
        private DataGridView student_dataGridView;
        private TextBox hoTen_textBox;
        private Label hoTen_label;
        private ComboBox gioiTinh_comboBox;
        private Label gioiTinh_label;
        private Label khoa_label;
        private Label tinhTrang_label;
        private TextBox sdt_textBox;
        private Label sdt_label;
        private ComboBox tinhTrang_comboBox;
        private ComboBox khoa_comboBox;
        private TextBox diaChi_textBox;
        private Label diaChi_label;
        private Label ngaySinh_label;
        private DateTimePicker ngaySinh_dateTimePicker;
        private Button add_button;
        private Button alter_button;
        private Button confirm_button;
        private Label label2;
        private Button search_student_button;
        private Panel info_panel;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDT;
        private Label lbEmail;
        private TextBox txtEmail;
    }
}
