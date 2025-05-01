namespace ACCI_CertificationExaminationCenter
{
    partial class LenLichVaXepPhongThi
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
            label5 = new Label();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            mcNgaySinh = new DateTimePicker();
            tt_kh_title_label = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            button2 = new Button();
            exams_dataGridView = new DataGridView();
            MaLichThi = new DataGridViewTextBoxColumn();
            NgayThi = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            LoaiChungChi = new DataGridViewTextBoxColumn();
            SoLuongToiDa = new DataGridViewTextBoxColumn();
            SoLuongDaDK = new DataGridViewTextBoxColumn();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            panel4 = new Panel();
            comboBox2 = new ComboBox();
            label6 = new Label();
            button4 = new Button();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exams_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 37);
            label5.TabIndex = 0;
            label5.Text = "Đến ngày";
            // 
            // panel3
            // 
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(562, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(439, 61);
            panel3.TabIndex = 81;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(136, 0);
            dateTimePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 43);
            dateTimePicker1.TabIndex = 128;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1300, 973);
            button1.Name = "button1";
            button1.Size = new Size(276, 78);
            button1.TabIndex = 80;
            button1.Text = "Thêm phân công";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // guna2Separator2
            // 
            guna2Separator2.FillThickness = 2;
            guna2Separator2.Location = new Point(0, 870);
            guna2Separator2.Margin = new Padding(0);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(1620, 21);
            guna2Separator2.TabIndex = 77;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 909);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(388, 45);
            label4.TabIndex = 76;
            label4.Text = "Chi tiết phân công coi thi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 37);
            label3.TabIndex = 0;
            label3.Text = "Từ ngày";
            // 
            // panel2
            // 
            panel2.Controls.Add(mcNgaySinh);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(42, 209);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 61);
            panel2.TabIndex = 75;
            // 
            // mcNgaySinh
            // 
            mcNgaySinh.CalendarFont = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcNgaySinh.CustomFormat = "dd/MM/yyyy";
            mcNgaySinh.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcNgaySinh.Format = DateTimePickerFormat.Custom;
            mcNgaySinh.Location = new Point(125, 0);
            mcNgaySinh.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            mcNgaySinh.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            mcNgaySinh.Name = "mcNgaySinh";
            mcNgaySinh.Size = new Size(296, 43);
            mcNgaySinh.TabIndex = 127;
            // 
            // tt_kh_title_label
            // 
            tt_kh_title_label.AutoSize = true;
            tt_kh_title_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tt_kh_title_label.Location = new Point(42, 134);
            tt_kh_title_label.Margin = new Padding(0);
            tt_kh_title_label.Name = "tt_kh_title_label";
            tt_kh_title_label.Size = new Size(269, 45);
            tt_kh_title_label.TabIndex = 70;
            tt_kh_title_label.Text = "Thông tin lịch thi";
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 100);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1620, 21);
            guna2Separator1.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(533, 59);
            label1.TabIndex = 68;
            label1.Text = "Lên lịch và xếp phòng thi";
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(1063, 188);
            button2.Name = "button2";
            button2.Size = new Size(171, 78);
            button2.TabIndex = 82;
            button2.Text = "Tìm";
            button2.UseVisualStyleBackColor = false;
            // 
            // exams_dataGridView
            // 
            exams_dataGridView.AllowUserToAddRows = false;
            exams_dataGridView.AllowUserToDeleteRows = false;
            exams_dataGridView.AllowUserToResizeRows = false;
            exams_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            exams_dataGridView.BackgroundColor = Color.Azure;
            exams_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            exams_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            exams_dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaLichThi, NgayThi, ThoiGian, LoaiChungChi, SoLuongToiDa, SoLuongDaDK });
            exams_dataGridView.Location = new Point(42, 293);
            exams_dataGridView.Margin = new Padding(0);
            exams_dataGridView.MultiSelect = false;
            exams_dataGridView.Name = "exams_dataGridView";
            exams_dataGridView.ReadOnly = true;
            exams_dataGridView.RowHeadersVisible = false;
            exams_dataGridView.RowHeadersWidth = 82;
            exams_dataGridView.Size = new Size(1534, 556);
            exams_dataGridView.TabIndex = 83;
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
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(1373, 188);
            button3.Name = "button3";
            button3.Size = new Size(203, 78);
            button3.TabIndex = 84;
            button3.Text = "Phân công";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView1.Location = new Point(42, 1099);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1534, 475);
            dataGridView1.TabIndex = 85;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 58.2633057F;
            dataGridViewTextBoxColumn1.HeaderText = "Mã lịch thi";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 58.2633057F;
            dataGridViewTextBoxColumn2.HeaderText = "Mã phòng";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.FillWeight = 58.2633057F;
            dataGridViewTextBoxColumn3.HeaderText = "Vị trí";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn4.HeaderText = "Slg tối đa";
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 160;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.FillWeight = 50F;
            dataGridViewTextBoxColumn5.HeaderText = "Mã NV coi thi";
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.FillWeight = 69.91596F;
            dataGridViewTextBoxColumn6.HeaderText = "Tên NV coi thi";
            dataGridViewTextBoxColumn6.MinimumWidth = 10;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(42, 984);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 61);
            panel1.TabIndex = 76;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.Font = new Font("Segoe UI", 10.125F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(137, 0);
            comboBox1.Margin = new Padding(5, 5, 5, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(393, 45);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 37);
            label2.TabIndex = 0;
            label2.Text = "Phòng thi";
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(661, 984);
            panel4.Name = "panel4";
            panel4.Size = new Size(530, 61);
            panel4.TabIndex = 77;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.Font = new Font("Segoe UI", 10.125F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(142, 0);
            comboBox2.Margin = new Padding(5, 5, 5, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(388, 45);
            comboBox2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(142, 37);
            label6.TabIndex = 0;
            label6.Text = "Nhân viên";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(680, 1606);
            button4.Name = "button4";
            button4.Size = new Size(276, 78);
            button4.TabIndex = 86;
            button4.Text = "Xóa phân công";
            button4.UseVisualStyleBackColor = false;
            // 
            // LenLichVaXepPhongThi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(button4);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(exams_dataGridView);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(guna2Separator2);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(tt_kh_title_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "LenLichVaXepPhongThi";
            Size = new Size(1620, 1712);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)exams_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Panel panel3;
        private Button button1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label tt_kh_title_label;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Button button2;
        private DataGridView exams_dataGridView;
        private DataGridViewTextBoxColumn MaLichThi;
        private DataGridViewTextBoxColumn NgayThi;
        private DataGridViewTextBoxColumn ThoiGian;
        private DataGridViewTextBoxColumn LoaiChungChi;
        private DataGridViewTextBoxColumn SoLuongToiDa;
        private DataGridViewTextBoxColumn SoLuongDaDK;
        private Button button3;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Panel panel4;
        private ComboBox comboBox2;
        private Label label6;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker mcNgaySinh;
    }
}
