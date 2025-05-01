namespace ACCI_CertificationExaminationCenter
{
    partial class QuanLyLichThi
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            btnTraCuu = new Button();
            txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            search_student_label = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            textBox1 = new TextBox();
            gioiTinh_label = new Label();
            cbbGioiTinh = new ComboBox();
            hoTen_label = new Label();
            btnXoa = new Button();
            label1 = new Label();
            khoa_label = new Label();
            btnCapNhat = new Button();
            btnThem = new Button();
            sdt_label = new Label();
            txtSoDT = new TextBox();
            label3 = new Label();
            txtTraCuuSoDT = new Guna.UI2.WinForms.Guna2TextBox();
            info_panel = new Panel();
            dgvDSNhanVien = new DataGridView();
            mcNgaySinh = new DateTimePicker();
            ngaySinh_label = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            dateTimePicker1 = new DateTimePicker();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(494, 125);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 120;
            label2.Text = "Thời gian thi:";
            label2.Click += label2_Click;
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.DarkTurquoise;
            btnTraCuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.ForeColor = Color.Transparent;
            btnTraCuu.Location = new Point(895, 77);
            btnTraCuu.Margin = new Padding(2);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(86, 40);
            btnTraCuu.TabIndex = 118;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            // 
            // txtMaNV
            // 
            txtMaNV.BorderRadius = 20;
            txtMaNV.CustomizableEdges = customizableEdges31;
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
            txtMaNV.Location = new Point(131, 76);
            txtMaNV.Margin = new Padding(4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "";
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges32;
            txtMaNV.Size = new Size(235, 32);
            txtMaNV.TabIndex = 117;
            txtMaNV.TextChanged += txtMaNV_TextChanged;
            // 
            // search_student_label
            // 
            search_student_label.AutoSize = true;
            search_student_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_student_label.Location = new Point(17, 85);
            search_student_label.Margin = new Padding(0);
            search_student_label.Name = "search_student_label";
            search_student_label.Size = new Size(95, 23);
            search_student_label.TabIndex = 116;
            search_student_label.Text = "Mã lịch thi:";
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(2, 57);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(996, 13);
            guna2Separator1.TabIndex = 115;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(776, 37);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 30);
            textBox1.TabIndex = 98;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // gioiTinh_label
            // 
            gioiTinh_label.AutoSize = true;
            gioiTinh_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gioiTinh_label.Location = new Point(510, 6);
            gioiTinh_label.Margin = new Padding(0);
            gioiTinh_label.Name = "gioiTinh_label";
            gioiTinh_label.Size = new Size(113, 23);
            gioiTinh_label.TabIndex = 81;
            gioiTinh_label.Text = "Loại đánh giá";
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGioiTinh.Location = new Point(510, 36);
            cbbGioiTinh.Margin = new Padding(2);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(186, 31);
            cbbGioiTinh.TabIndex = 82;
            // 
            // hoTen_label
            // 
            hoTen_label.AutoSize = true;
            hoTen_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoTen_label.Location = new Point(4, 6);
            hoTen_label.Margin = new Padding(0);
            hoTen_label.Name = "hoTen_label";
            hoTen_label.Size = new Size(76, 23);
            hoTen_label.TabIndex = 83;
            hoTen_label.Text = "Ngày thi";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ActiveBorder;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Transparent;
            btnXoa.Location = new Point(396, 86);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(148, 40);
            btnXoa.TabIndex = 94;
            btnXoa.Text = "Xóa lịch thi";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 12);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 114;
            label1.Text = "Quản lý lịch thi";
            // 
            // khoa_label
            // 
            khoa_label.AutoSize = true;
            khoa_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            khoa_label.Location = new Point(776, 6);
            khoa_label.Margin = new Padding(0);
            khoa_label.Name = "khoa_label";
            khoa_label.Size = new Size(128, 23);
            khoa_label.TabIndex = 79;
            khoa_label.Text = "Số lượng tối đa";
            khoa_label.Click += khoa_label_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.DarkTurquoise;
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.Transparent;
            btnCapNhat.Location = new Point(590, 86);
            btnCapNhat.Margin = new Padding(2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(148, 40);
            btnCapNhat.TabIndex = 95;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DarkTurquoise;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Transparent;
            btnThem.Location = new Point(193, 86);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(148, 40);
            btnThem.TabIndex = 93;
            btnThem.Text = "Thêm lịch thi";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // sdt_label
            // 
            sdt_label.AutoSize = true;
            sdt_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sdt_label.Location = new Point(257, 6);
            sdt_label.Margin = new Padding(0);
            sdt_label.Name = "sdt_label";
            sdt_label.Size = new Size(106, 23);
            sdt_label.TabIndex = 85;
            sdt_label.Text = "Thời gian thi";
            sdt_label.Click += this.sdt_label_Click;
            // 
            // txtSoDT
            // 
            txtSoDT.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoDT.Location = new Point(257, 33);
            txtSoDT.Margin = new Padding(2);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(178, 30);
            txtSoDT.TabIndex = 86;
            txtSoDT.TextChanged += txtSoDT_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(494, 85);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 123;
            label3.Text = "Loại đánh giá:";
            label3.Click += label3_Click;
            // 
            // txtTraCuuSoDT
            // 
            txtTraCuuSoDT.BorderRadius = 20;
            txtTraCuuSoDT.CustomizableEdges = customizableEdges33;
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
            txtTraCuuSoDT.Location = new Point(615, 116);
            txtTraCuuSoDT.Margin = new Padding(4);
            txtTraCuuSoDT.Name = "txtTraCuuSoDT";
            txtTraCuuSoDT.PlaceholderText = "";
            txtTraCuuSoDT.SelectedText = "";
            txtTraCuuSoDT.ShadowDecoration.CustomizableEdges = customizableEdges34;
            txtTraCuuSoDT.Size = new Size(235, 32);
            txtTraCuuSoDT.TabIndex = 122;
            txtTraCuuSoDT.TextChanged += txtTraCuuSoDT_TextChanged;
            // 
            // info_panel
            // 
            info_panel.Controls.Add(dateTimePicker1);
            info_panel.Controls.Add(textBox1);
            info_panel.Controls.Add(khoa_label);
            info_panel.Controls.Add(gioiTinh_label);
            info_panel.Controls.Add(cbbGioiTinh);
            info_panel.Controls.Add(btnCapNhat);
            info_panel.Controls.Add(hoTen_label);
            info_panel.Controls.Add(btnXoa);
            info_panel.Controls.Add(btnThem);
            info_panel.Controls.Add(sdt_label);
            info_panel.Controls.Add(txtSoDT);
            info_panel.Location = new Point(17, 572);
            info_panel.Margin = new Padding(0);
            info_panel.Name = "info_panel";
            info_panel.Size = new Size(964, 146);
            info_panel.TabIndex = 121;
            // 
            // dgvDSNhanVien
            // 
            dgvDSNhanVien.AllowUserToResizeRows = false;
            dgvDSNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSNhanVien.BackgroundColor = Color.Azure;
            dgvDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
            dgvDSNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSNhanVien.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvDSNhanVien.Location = new Point(17, 162);
            dgvDSNhanVien.Margin = new Padding(0);
            dgvDSNhanVien.MultiSelect = false;
            dgvDSNhanVien.Name = "dgvDSNhanVien";
            dgvDSNhanVien.RowHeadersVisible = false;
            dgvDSNhanVien.RowHeadersWidth = 82;
            dgvDSNhanVien.Size = new Size(964, 397);
            dgvDSNhanVien.TabIndex = 119;
            // 
            // mcNgaySinh
            // 
            mcNgaySinh.CalendarFont = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcNgaySinh.CustomFormat = "dd/MM/yyyy";
            mcNgaySinh.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcNgaySinh.Format = DateTimePickerFormat.Custom;
            mcNgaySinh.Location = new Point(131, 118);
            mcNgaySinh.Margin = new Padding(2);
            mcNgaySinh.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            mcNgaySinh.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            mcNgaySinh.Name = "mcNgaySinh";
            mcNgaySinh.Size = new Size(235, 30);
            mcNgaySinh.TabIndex = 126;
            // 
            // ngaySinh_label
            // 
            ngaySinh_label.AutoSize = true;
            ngaySinh_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ngaySinh_label.Location = new Point(17, 125);
            ngaySinh_label.Margin = new Padding(0);
            ngaySinh_label.Name = "ngaySinh_label";
            ngaySinh_label.Size = new Size(80, 23);
            ngaySinh_label.TabIndex = 125;
            ngaySinh_label.Text = "Ngày thi:";
            ngaySinh_label.Click += ngaySinh_label_Click;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 20;
            guna2TextBox1.CustomizableEdges = customizableEdges35;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2TextBox1.HoverState.BorderColor = Color.Gray;
            guna2TextBox1.IconLeftOffset = new Point(10, 0);
            guna2TextBox1.IconRight = Properties.Resources.close__1_;
            guna2TextBox1.IconRightOffset = new Point(10, 0);
            guna2TextBox1.Location = new Point(615, 76);
            guna2TextBox1.Margin = new Padding(4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges36;
            guna2TextBox1.Size = new Size(235, 32);
            guna2TextBox1.TabIndex = 127;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(4, 33);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(184, 30);
            dateTimePicker1.TabIndex = 128;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã lịch thi";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ngày thi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Thời gian thi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "SLg tối đa";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "SLg đã đăng ký";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Loại đánh giá";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // QuanLyLichThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2TextBox1);
            Controls.Add(mcNgaySinh);
            Controls.Add(ngaySinh_label);
            Controls.Add(label2);
            Controls.Add(btnTraCuu);
            Controls.Add(txtMaNV);
            Controls.Add(search_student_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtTraCuuSoDT);
            Controls.Add(info_panel);
            Controls.Add(dgvDSNhanVien);
            Margin = new Padding(0);
            Name = "QuanLyLichThi";
            Size = new Size(1001, 731);
            info_panel.ResumeLayout(false);
            info_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnTraCuu;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Label search_student_label;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private TextBox textBox1;
        private Label gioiTinh_label;
        private ComboBox cbbGioiTinh;
        private Label hoTen_label;
        private Button btnXoa;
        private Label label1;
        private Label khoa_label;
        private Button btnCapNhat;
        private Button btnThem;
        private Label sdt_label;
        private TextBox txtSoDT;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTraCuuSoDT;
        private Panel info_panel;
        private DataGridView dgvDSNhanVien;
        private DateTimePicker mcNgaySinh;
        private Label ngaySinh_label;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
