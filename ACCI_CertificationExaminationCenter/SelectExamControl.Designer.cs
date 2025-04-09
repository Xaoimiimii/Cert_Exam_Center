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
            search_textBox = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            exams_label = new Label();
            select_exam_button = new Button();
            cancel_button = new Button();
            ((System.ComponentModel.ISupportInitialize)exams_dataGridView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(310, 59);
            label1.TabIndex = 1;
            label1.Text = "Tra cứu lịch thi";
            // 
            // monthCalendar
            // 
            monthCalendar.BackColor = Color.White;
            monthCalendar.ForeColor = Color.PaleTurquoise;
            monthCalendar.Location = new Point(25, 295);
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
            // search_textBox
            // 
            search_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_textBox.Location = new Point(41, 3);
            search_textBox.MaxLength = 10;
            search_textBox.Name = "search_textBox";
            search_textBox.Size = new Size(286, 43);
            search_textBox.TabIndex = 10;
            search_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(search_textBox);
            flowLayoutPanel1.Location = new Point(25, 210);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(330, 50);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.find;
            pictureBox1.Location = new Point(3, 9);
            pictureBox1.Margin = new Padding(3, 9, 3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // SelectExamControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cancel_button);
            Controls.Add(select_exam_button);
            Controls.Add(exams_label);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tt_kh_title_label);
            Controls.Add(guna2Separator1);
            Controls.Add(exams_dataGridView);
            Controls.Add(monthCalendar);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "SelectExamControl";
            Size = new Size(1620, 1209);
            ((System.ComponentModel.ISupportInitialize)exams_dataGridView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
