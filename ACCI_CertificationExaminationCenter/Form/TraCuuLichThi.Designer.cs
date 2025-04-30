namespace ACCI_CertificationExaminationCenter
{
    partial class TraCuuLichThi
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
            dgvDSLichThi = new DataGridView();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            tt_kh_title_label = new Label();
            btnXacNhan = new Button();
            btnTroVe = new Button();
            txtTimNgayThi = new Guna.UI2.WinForms.Guna2TextBox();
            txtTimGioThi = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label3 = new Label();
            cbTimLoaiDanhGia = new ComboBox();
            btnTraCuu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSLichThi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(325, 59);
            label1.TabIndex = 1;
            label1.Text = "Tra cứu lịch thi";
            // 
            // dgvDSLichThi
            // 
            dgvDSLichThi.AllowUserToAddRows = false;
            dgvDSLichThi.AllowUserToDeleteRows = false;
            dgvDSLichThi.AllowUserToResizeRows = false;
            dgvDSLichThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSLichThi.BackgroundColor = Color.White;
            dgvDSLichThi.BorderStyle = BorderStyle.Fixed3D;
            dgvDSLichThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLichThi.Location = new Point(25, 228);
            dgvDSLichThi.Margin = new Padding(0);
            dgvDSLichThi.MultiSelect = false;
            dgvDSLichThi.Name = "dgvDSLichThi";
            dgvDSLichThi.ReadOnly = true;
            dgvDSLichThi.RowHeadersVisible = false;
            dgvDSLichThi.RowHeadersWidth = 82;
            dgvDSLichThi.Size = new Size(1578, 749);
            dgvDSLichThi.TabIndex = 5;
            dgvDSLichThi.CellClick += dgvDSLichThi_CellClick;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 100);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1620, 21);
            guna2Separator1.TabIndex = 6;
            // 
            // tt_kh_title_label
            // 
            tt_kh_title_label.AutoSize = true;
            tt_kh_title_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tt_kh_title_label.Location = new Point(25, 151);
            tt_kh_title_label.Margin = new Padding(0);
            tt_kh_title_label.Name = "tt_kh_title_label";
            tt_kh_title_label.Size = new Size(129, 37);
            tt_kh_title_label.TabIndex = 7;
            tt_kh_title_label.Text = "Ngày thi:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.MediumTurquoise;
            btnXacNhan.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = Color.Transparent;
            btnXacNhan.Location = new Point(820, 1029);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(322, 78);
            btnXacNhan.TabIndex = 28;
            btnXacNhan.Text = "Xác nhận chọn";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = SystemColors.ActiveBorder;
            btnTroVe.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTroVe.ForeColor = Color.Transparent;
            btnTroVe.Location = new Point(478, 1029);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(322, 78);
            btnTroVe.TabIndex = 29;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // txtTimNgayThi
            // 
            txtTimNgayThi.BorderRadius = 20;
            txtTimNgayThi.CustomizableEdges = customizableEdges1;
            txtTimNgayThi.DefaultText = "";
            txtTimNgayThi.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimNgayThi.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimNgayThi.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimNgayThi.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimNgayThi.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimNgayThi.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimNgayThi.HoverState.BorderColor = Color.Gray;
            txtTimNgayThi.IconLeftOffset = new Point(10, 0);
            txtTimNgayThi.IconRight = Properties.Resources.close__1_;
            txtTimNgayThi.IconRightOffset = new Point(10, 0);
            txtTimNgayThi.Location = new Point(160, 142);
            txtTimNgayThi.Margin = new Padding(7);
            txtTimNgayThi.Name = "txtTimNgayThi";
            txtTimNgayThi.PlaceholderText = "";
            txtTimNgayThi.SelectedText = "";
            txtTimNgayThi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTimNgayThi.Size = new Size(265, 51);
            txtTimNgayThi.TabIndex = 33;
            txtTimNgayThi.TextOffset = new Point(10, 0);
            txtTimNgayThi.IconRightClick += txtTimNgayThi_IconRightClick;
            // 
            // txtTimGioThi
            // 
            txtTimGioThi.BorderRadius = 20;
            txtTimGioThi.CustomizableEdges = customizableEdges3;
            txtTimGioThi.DefaultText = "";
            txtTimGioThi.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimGioThi.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimGioThi.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimGioThi.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimGioThi.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimGioThi.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimGioThi.HoverState.BorderColor = Color.Gray;
            txtTimGioThi.IconLeftOffset = new Point(10, 0);
            txtTimGioThi.IconRight = Properties.Resources.close__1_;
            txtTimGioThi.IconRightOffset = new Point(10, 0);
            txtTimGioThi.Location = new Point(614, 142);
            txtTimGioThi.Margin = new Padding(7);
            txtTimGioThi.Name = "txtTimGioThi";
            txtTimGioThi.PlaceholderText = "";
            txtTimGioThi.SelectedText = "";
            txtTimGioThi.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTimGioThi.Size = new Size(171, 51);
            txtTimGioThi.TabIndex = 35;
            txtTimGioThi.TextOffset = new Point(10, 0);
            txtTimGioThi.IconRightClick += txtTimGioThi_IconRightClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(500, 151);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(107, 37);
            label2.TabIndex = 34;
            label2.Text = "Giờ thi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(860, 151);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(187, 37);
            label3.TabIndex = 36;
            label3.Text = "Loại đánh giá:";
            // 
            // cbTimLoaiDanhGia
            // 
            cbTimLoaiDanhGia.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTimLoaiDanhGia.FormattingEnabled = true;
            cbTimLoaiDanhGia.Items.AddRange(new object[] { "Tất cả", "Ngoại ngữ", "Tin học" });
            cbTimLoaiDanhGia.Location = new Point(1050, 144);
            cbTimLoaiDanhGia.Name = "cbTimLoaiDanhGia";
            cbTimLoaiDanhGia.Size = new Size(244, 45);
            cbTimLoaiDanhGia.TabIndex = 37;
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.MediumTurquoise;
            btnTraCuu.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.ForeColor = Color.Transparent;
            btnTraCuu.Location = new Point(1372, 130);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(231, 78);
            btnTraCuu.TabIndex = 38;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // TraCuuLichThi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1624, 1138);
            Controls.Add(btnTraCuu);
            Controls.Add(cbTimLoaiDanhGia);
            Controls.Add(label3);
            Controls.Add(txtTimGioThi);
            Controls.Add(label2);
            Controls.Add(txtTimNgayThi);
            Controls.Add(btnTroVe);
            Controls.Add(btnXacNhan);
            Controls.Add(tt_kh_title_label);
            Controls.Add(guna2Separator1);
            Controls.Add(dgvDSLichThi);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "TraCuuLichThi";
            StartPosition = FormStartPosition.CenterScreen;
            Load += TraCuuLichThi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSLichThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDSLichThi;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label tt_kh_title_label;
        private TextBox search_textBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label exams_label;
        private Button btnXacNhan;
        private Button btnTroVe;
        private Guna.UI2.WinForms.Guna2TextBox txtTimNgayThi;
        private Guna.UI2.WinForms.Guna2TextBox txtTimGioThi;
        private Label label2;
        private Label label3;
        private ComboBox cbTimLoaiDanhGia;
        private Button btnTraCuu;
    }
}
