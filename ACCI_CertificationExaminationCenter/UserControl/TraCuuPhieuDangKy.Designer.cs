namespace ACCI_CertificationExaminationCenter
{
    partial class SelectRegisterFormControl
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
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            tt_kh_title_label = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            kh_fullname_panel = new Panel();
            kh_fullname_textBox = new TextBox();
            kh_fullname_title_label = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            select_exam_button = new Button();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            dataGridView1 = new DataGridView();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            Sdt = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            button1 = new Button();
            kh_fullname_panel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(475, 59);
            label1.TabIndex = 2;
            label1.Text = "Tra cứu phiếu đăng ký";
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 99);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1620, 21);
            guna2Separator1.TabIndex = 34;
            // 
            // tt_kh_title_label
            // 
            tt_kh_title_label.AutoSize = true;
            tt_kh_title_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tt_kh_title_label.Location = new Point(24, 134);
            tt_kh_title_label.Margin = new Padding(0);
            tt_kh_title_label.Name = "tt_kh_title_label";
            tt_kh_title_label.Size = new Size(324, 45);
            tt_kh_title_label.TabIndex = 35;
            tt_kh_title_label.Text = "Phương thức tra cứu";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 10.125F);
            radioButton1.Location = new Point(41, 211);
            radioButton1.Margin = new Padding(5, 5, 5, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(27, 26);
            radioButton1.TabIndex = 36;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10.125F);
            radioButton2.Location = new Point(762, 211);
            radioButton2.Margin = new Padding(5, 5, 5, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(27, 26);
            radioButton2.TabIndex = 37;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // kh_fullname_panel
            // 
            kh_fullname_panel.Controls.Add(kh_fullname_textBox);
            kh_fullname_panel.Controls.Add(kh_fullname_title_label);
            kh_fullname_panel.Location = new Point(98, 211);
            kh_fullname_panel.Name = "kh_fullname_panel";
            kh_fullname_panel.Size = new Size(520, 61);
            kh_fullname_panel.TabIndex = 38;
            // 
            // kh_fullname_textBox
            // 
            kh_fullname_textBox.Dock = DockStyle.Fill;
            kh_fullname_textBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kh_fullname_textBox.Location = new Point(236, 0);
            kh_fullname_textBox.Name = "kh_fullname_textBox";
            kh_fullname_textBox.Size = new Size(284, 43);
            kh_fullname_textBox.TabIndex = 1;
            // 
            // kh_fullname_title_label
            // 
            kh_fullname_title_label.AutoSize = true;
            kh_fullname_title_label.Dock = DockStyle.Left;
            kh_fullname_title_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kh_fullname_title_label.Location = new Point(0, 0);
            kh_fullname_title_label.Name = "kh_fullname_title_label";
            kh_fullname_title_label.Size = new Size(236, 37);
            kh_fullname_title_label.TabIndex = 0;
            kh_fullname_title_label.Text = "Mã phiếu đăng ký";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(819, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 61);
            panel1.TabIndex = 39;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(178, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 43);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 37);
            label2.TabIndex = 0;
            label2.Text = "Số điện thoại";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(1254, 211);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 61);
            panel2.TabIndex = 40;
            panel2.Paint += panel2_Paint;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(122, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 43);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 37);
            label3.TabIndex = 0;
            label3.Text = "Ngày thi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 475);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(378, 45);
            label4.TabIndex = 41;
            label4.Text = "Thông tin phiếu đăng ký";
            // 
            // guna2Separator2
            // 
            guna2Separator2.FillThickness = 2;
            guna2Separator2.Location = new Point(0, 437);
            guna2Separator2.Margin = new Padding(0);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(1620, 21);
            guna2Separator2.TabIndex = 42;
            guna2Separator2.Click += guna2Separator2_Click;
            // 
            // select_exam_button
            // 
            select_exam_button.BackColor = Color.MediumTurquoise;
            select_exam_button.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            select_exam_button.ForeColor = Color.Transparent;
            select_exam_button.Location = new Point(713, 323);
            select_exam_button.Name = "select_exam_button";
            select_exam_button.Size = new Size(213, 78);
            select_exam_button.TabIndex = 63;
            select_exam_button.Text = "Tra cứu";
            select_exam_button.UseVisualStyleBackColor = false;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(dataGridView1);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(42, 533);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.DimGray;
            guna2ShadowPanel1.ShadowShift = 16;
            guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            guna2ShadowPanel1.Size = new Size(1534, 477);
            guna2ShadowPanel1.TabIndex = 64;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 46;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { HoTen, NgaySinh, GioiTinh, Sdt, Email, DiaChi });
            dataGridView1.GridColor = Color.PowderBlue;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1514, 430);
            dataGridView1.TabIndex = 0;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Mã phiếu đăng ký";
            HoTen.MinimumWidth = 10;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.HeaderText = "Ngày thi";
            NgaySinh.MinimumWidth = 10;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Thời gian thi";
            GioiTinh.MinimumWidth = 10;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // Sdt
            // 
            Sdt.HeaderText = "Loại ĐGNL";
            Sdt.MinimumWidth = 10;
            Sdt.Name = "Sdt";
            Sdt.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Số điện thoại";
            Email.MinimumWidth = 10;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Tình trạng";
            DiaChi.MinimumWidth = 10;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(713, 1045);
            button1.Name = "button1";
            button1.Size = new Size(213, 78);
            button1.TabIndex = 65;
            button1.Text = "Hoàn thành";
            button1.UseVisualStyleBackColor = false;
            // 
            // SelectRegisterFormControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(select_exam_button);
            Controls.Add(guna2Separator2);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(kh_fullname_panel);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(tt_kh_title_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "SelectRegisterFormControl";
            Size = new Size(1620, 1170);
            kh_fullname_panel.ResumeLayout(false);
            kh_fullname_panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label tt_kh_title_label;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel kh_fullname_panel;
        private TextBox kh_fullname_textBox;
        private Label kh_fullname_title_label;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Button select_exam_button;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Sdt;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
        private Button button1;
    }
}
