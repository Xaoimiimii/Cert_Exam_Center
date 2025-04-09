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
            label1 = new Label();
            monthCalendar = new MonthCalendar();
            exams_dataGridView = new DataGridView();
            MaLichThi = new DataGridViewTextBoxColumn();
            NgayThi = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            LoaiChungChi = new DataGridViewTextBoxColumn();
            SoLuongToiDa = new DataGridViewTextBoxColumn();
            SoLuongDaDK = new DataGridViewTextBoxColumn();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            tt_kh_title_label = new Label();
            exams_label = new Label();
            select_exam_button = new Button();
            cancel_button = new Button();
            search_date_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
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
            // monthCalendar
            // 
            monthCalendar.BackColor = Color.White;
            monthCalendar.ForeColor = Color.PaleTurquoise;
            monthCalendar.Location = new Point(25, 277);
            monthCalendar.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.ShowToday = false;
            monthCalendar.ShowTodayCircle = false;
            monthCalendar.TabIndex = 2;
            monthCalendar.TitleBackColor = Color.PaleTurquoise;
            monthCalendar.TrailingForeColor = Color.MediumTurquoise;
            // 
            // exams_dataGridView
            // 
            exams_dataGridView.AllowUserToAddRows = false;
            exams_dataGridView.AllowUserToDeleteRows = false;
            exams_dataGridView.AllowUserToResizeRows = false;
            exams_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            exams_dataGridView.BackgroundColor = Color.White;
            exams_dataGridView.BorderStyle = BorderStyle.None;
            exams_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            exams_dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaLichThi, NgayThi, ThoiGian, LoaiChungChi, SoLuongToiDa, SoLuongDaDK });
            exams_dataGridView.Location = new Point(420, 210);
            exams_dataGridView.Margin = new Padding(0);
            exams_dataGridView.MultiSelect = false;
            exams_dataGridView.Name = "exams_dataGridView";
            exams_dataGridView.ReadOnly = true;
            exams_dataGridView.RowHeadersVisible = false;
            exams_dataGridView.RowHeadersWidth = 82;
            exams_dataGridView.Size = new Size(1162, 767);
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
            tt_kh_title_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tt_kh_title_label.Location = new Point(25, 135);
            tt_kh_title_label.Margin = new Padding(0);
            tt_kh_title_label.Name = "tt_kh_title_label";
            tt_kh_title_label.Size = new Size(225, 45);
            tt_kh_title_label.TabIndex = 7;
            tt_kh_title_label.Text = "Chọn ngày thi";
            // 
            // exams_label
            // 
            exams_label.AutoSize = true;
            exams_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exams_label.Location = new Point(420, 135);
            exams_label.Margin = new Padding(0);
            exams_label.Name = "exams_label";
            exams_label.Size = new Size(279, 45);
            exams_label.TabIndex = 12;
            exams_label.Text = "Danh sách lịch thi";
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
            // search_date_guna2TextBox
            // 
            search_date_guna2TextBox.BorderRadius = 20;
            search_date_guna2TextBox.CustomizableEdges = customizableEdges1;
            search_date_guna2TextBox.DefaultText = "";
            search_date_guna2TextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_date_guna2TextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_date_guna2TextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_date_guna2TextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_date_guna2TextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search_date_guna2TextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_date_guna2TextBox.HoverState.BorderColor = Color.Gray;
            search_date_guna2TextBox.IconLeft = Properties.Resources.search;
            search_date_guna2TextBox.IconLeftOffset = new Point(10, 0);
            search_date_guna2TextBox.IconRight = Properties.Resources.close__1_;
            search_date_guna2TextBox.IconRightOffset = new Point(10, 0);
            search_date_guna2TextBox.Location = new Point(25, 210);
            search_date_guna2TextBox.Margin = new Padding(7);
            search_date_guna2TextBox.Name = "search_date_guna2TextBox";
            search_date_guna2TextBox.PlaceholderText = "";
            search_date_guna2TextBox.SelectedText = "";
            search_date_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_date_guna2TextBox.Size = new Size(327, 51);
            search_date_guna2TextBox.TabIndex = 33;
            // 
            // SelectExamControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(search_date_guna2TextBox);
            Controls.Add(cancel_button);
            Controls.Add(select_exam_button);
            Controls.Add(exams_label);
            Controls.Add(tt_kh_title_label);
            Controls.Add(guna2Separator1);
            Controls.Add(exams_dataGridView);
            Controls.Add(monthCalendar);
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
        private MonthCalendar monthCalendar;
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
        private Guna.UI2.WinForms.Guna2TextBox search_date_guna2TextBox;
    }
}
