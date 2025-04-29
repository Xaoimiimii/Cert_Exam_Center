namespace ACCI_CertificationExaminationCenter
{
    partial class SelectExamControl
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
            exams_dataGridView = new DataGridView();
            MaLichThi = new DataGridViewTextBoxColumn();
            NgayThi = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            LoaiChungChi = new DataGridViewTextBoxColumn();
            SoLuongToiDa = new DataGridViewTextBoxColumn();
            SoLuongDaDK = new DataGridViewTextBoxColumn();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            tt_kh_title_label = new Label();
            select_exam_button = new Button();
            cancel_button = new Button();
            ngayThi_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            thoiGianThi_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)exams_dataGridView).BeginInit();
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
            // exams_dataGridView
            // 
            exams_dataGridView.AllowUserToAddRows = false;
            exams_dataGridView.AllowUserToDeleteRows = false;
            exams_dataGridView.AllowUserToResizeRows = false;
            exams_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            exams_dataGridView.BackgroundColor = Color.White;
            exams_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            exams_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            exams_dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaLichThi, NgayThi, ThoiGian, LoaiChungChi, SoLuongToiDa, SoLuongDaDK });
            exams_dataGridView.Location = new Point(25, 228);
            exams_dataGridView.Margin = new Padding(0);
            exams_dataGridView.MultiSelect = false;
            exams_dataGridView.Name = "exams_dataGridView";
            exams_dataGridView.ReadOnly = true;
            exams_dataGridView.RowHeadersVisible = false;
            exams_dataGridView.RowHeadersWidth = 82;
            exams_dataGridView.Size = new Size(1578, 749);
            exams_dataGridView.TabIndex = 5;
            // 
            // MaLichThi
            // 
            MaLichThi.HeaderText = "Mã lịch thi";
            MaLichThi.MinimumWidth = 10;
            MaLichThi.Name = "MaLichThi";
            MaLichThi.ReadOnly = true;
            // 
            // NgayThi
            // 
            NgayThi.HeaderText = "Ngày thi";
            NgayThi.MinimumWidth = 10;
            NgayThi.Name = "NgayThi";
            NgayThi.ReadOnly = true;
            // 
            // ThoiGian
            // 
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.MinimumWidth = 10;
            ThoiGian.Name = "ThoiGian";
            ThoiGian.ReadOnly = true;
            // 
            // LoaiChungChi
            // 
            LoaiChungChi.HeaderText = "Loại";
            LoaiChungChi.MinimumWidth = 10;
            LoaiChungChi.Name = "LoaiChungChi";
            LoaiChungChi.ReadOnly = true;
            // 
            // SoLuongToiDa
            // 
            SoLuongToiDa.HeaderText = "Slg tối đa";
            SoLuongToiDa.MinimumWidth = 10;
            SoLuongToiDa.Name = "SoLuongToiDa";
            SoLuongToiDa.ReadOnly = true;
            // 
            // SoLuongDaDK
            // 
            SoLuongDaDK.FillWeight = 120F;
            SoLuongDaDK.HeaderText = "Slg đã đăng ký";
            SoLuongDaDK.MinimumWidth = 10;
            SoLuongDaDK.Name = "SoLuongDaDK";
            SoLuongDaDK.ReadOnly = true;
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
            // select_exam_button
            // 
            select_exam_button.BackColor = Color.MediumTurquoise;
            select_exam_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            select_exam_button.ForeColor = Color.Transparent;
            select_exam_button.Location = new Point(820, 1029);
            select_exam_button.Name = "select_exam_button";
            select_exam_button.Size = new Size(322, 78);
            select_exam_button.TabIndex = 28;
            select_exam_button.Text = "Xác nhận chọn";
            select_exam_button.UseVisualStyleBackColor = false;
            // 
            // cancel_button
            // 
            cancel_button.BackColor = SystemColors.ActiveBorder;
            cancel_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_button.ForeColor = Color.Transparent;
            cancel_button.Location = new Point(478, 1029);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(322, 78);
            cancel_button.TabIndex = 29;
            cancel_button.Text = "Trở về";
            cancel_button.UseVisualStyleBackColor = false;
            // 
            // ngayThi_guna2TextBox
            // 
            ngayThi_guna2TextBox.BorderRadius = 20;
            ngayThi_guna2TextBox.CustomizableEdges = customizableEdges1;
            ngayThi_guna2TextBox.DefaultText = "";
            ngayThi_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            ngayThi_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            ngayThi_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            ngayThi_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            ngayThi_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ngayThi_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayThi_guna2TextBox.HoverState.BorderColor = Color.Gray;
            ngayThi_guna2TextBox.IconLeftOffset = new Point(10, 0);
            ngayThi_guna2TextBox.IconRight = Properties.Resources.close__1_;
            ngayThi_guna2TextBox.IconRightOffset = new Point(10, 0);
            ngayThi_guna2TextBox.Location = new Point(160, 142);
            ngayThi_guna2TextBox.Margin = new Padding(7);
            ngayThi_guna2TextBox.Name = "ngayThi_guna2TextBox";
            ngayThi_guna2TextBox.PlaceholderText = "";
            ngayThi_guna2TextBox.SelectedText = "";
            ngayThi_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ngayThi_guna2TextBox.Size = new Size(265, 51);
            ngayThi_guna2TextBox.TabIndex = 33;
            ngayThi_guna2TextBox.TextOffset = new Point(10, 0);
            // 
            // thoiGianThi_guna2TextBox
            // 
            thoiGianThi_guna2TextBox.BorderRadius = 20;
            thoiGianThi_guna2TextBox.CustomizableEdges = customizableEdges3;
            thoiGianThi_guna2TextBox.DefaultText = "";
            thoiGianThi_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            thoiGianThi_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            thoiGianThi_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            thoiGianThi_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            thoiGianThi_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            thoiGianThi_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thoiGianThi_guna2TextBox.HoverState.BorderColor = Color.Gray;
            thoiGianThi_guna2TextBox.IconLeftOffset = new Point(10, 0);
            thoiGianThi_guna2TextBox.IconRight = Properties.Resources.close__1_;
            thoiGianThi_guna2TextBox.IconRightOffset = new Point(10, 0);
            thoiGianThi_guna2TextBox.Location = new Point(614, 142);
            thoiGianThi_guna2TextBox.Margin = new Padding(7);
            thoiGianThi_guna2TextBox.Name = "thoiGianThi_guna2TextBox";
            thoiGianThi_guna2TextBox.PlaceholderText = "";
            thoiGianThi_guna2TextBox.SelectedText = "";
            thoiGianThi_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            thoiGianThi_guna2TextBox.Size = new Size(171, 51);
            thoiGianThi_guna2TextBox.TabIndex = 35;
            thoiGianThi_guna2TextBox.TextOffset = new Point(10, 0);
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
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1050, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 45);
            comboBox1.TabIndex = 37;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1372, 130);
            button1.Name = "button1";
            button1.Size = new Size(231, 78);
            button1.TabIndex = 38;
            button1.Text = "Tra cứu";
            button1.UseVisualStyleBackColor = false;
            // 
            // SelectExamControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(thoiGianThi_guna2TextBox);
            Controls.Add(label2);
            Controls.Add(ngayThi_guna2TextBox);
            Controls.Add(cancel_button);
            Controls.Add(select_exam_button);
            Controls.Add(tt_kh_title_label);
            Controls.Add(guna2Separator1);
            Controls.Add(exams_dataGridView);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "SelectExamControl";
            Size = new Size(1620, 1169);
            ((System.ComponentModel.ISupportInitialize)exams_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView exams_dataGridView;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label tt_kh_title_label;
        private TextBox search_textBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label exams_label;
        private Button select_exam_button;
        private DataGridViewTextBoxColumn MaLichThi;
        private DataGridViewTextBoxColumn NgayThi;
        private DataGridViewTextBoxColumn ThoiGian;
        private DataGridViewTextBoxColumn LoaiChungChi;
        private DataGridViewTextBoxColumn SoLuongToiDa;
        private DataGridViewTextBoxColumn SoLuongDaDK;
        private Button cancel_button;
        private Guna.UI2.WinForms.Guna2TextBox ngayThi_guna2TextBox;
        private Guna.UI2.WinForms.Guna2TextBox thoiGianThi_guna2TextBox;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
    }
}
