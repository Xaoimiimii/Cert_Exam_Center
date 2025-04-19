namespace ACCI_CertificationExaminationCenter
{
    partial class QuanLyNhanVien : UserControl
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
            lbQuanLyNhanVien = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            pnlChinhSuaThongTin = new Guna.UI2.WinForms.Guna2ShadowPanel();
            payment_extend_label = new Label();
            payment_extend_pictureBox = new PictureBox();
            pnlXoaNhanVien = new Guna.UI2.WinForms.Guna2ShadowPanel();
            payment_register_label = new Label();
            payment_register_pictureBox = new PictureBox();
            pnlThemNhanVien = new Guna.UI2.WinForms.Guna2ShadowPanel();
            register_label = new Label();
            register_pictureBox = new PictureBox();
            bg_pictureBox = new PictureBox();
            pnlTraCuuNhanVien = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnTraCuu = new Label();
            pictureBox1 = new PictureBox();
            pnlChinhSuaThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payment_extend_pictureBox).BeginInit();
            pnlXoaNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payment_register_pictureBox).BeginInit();
            pnlThemNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)register_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg_pictureBox).BeginInit();
            pnlTraCuuNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbQuanLyNhanVien
            // 
            lbQuanLyNhanVien.AutoSize = true;
            lbQuanLyNhanVien.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQuanLyNhanVien.Location = new Point(15, 16);
            lbQuanLyNhanVien.Margin = new Padding(2, 0, 2, 0);
            lbQuanLyNhanVien.Name = "lbQuanLyNhanVien";
            lbQuanLyNhanVien.Size = new Size(245, 37);
            lbQuanLyNhanVien.TabIndex = 1;
            lbQuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(0, 62);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(997, 13);
            guna2Separator1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 317);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 37);
            label1.TabIndex = 34;
            label1.Text = "Bạn muốn làm gì?";
            // 
            // pnlChinhSuaThongTin
            // 
            pnlChinhSuaThongTin.BackColor = Color.Transparent;
            pnlChinhSuaThongTin.Controls.Add(payment_extend_label);
            pnlChinhSuaThongTin.Controls.Add(payment_extend_pictureBox);
            pnlChinhSuaThongTin.FillColor = Color.LightCyan;
            pnlChinhSuaThongTin.Location = new Point(674, 537);
            pnlChinhSuaThongTin.Margin = new Padding(0);
            pnlChinhSuaThongTin.Name = "pnlChinhSuaThongTin";
            pnlChinhSuaThongTin.Radius = 10;
            pnlChinhSuaThongTin.ShadowColor = Color.DimGray;
            pnlChinhSuaThongTin.ShadowShift = 10;
            pnlChinhSuaThongTin.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            pnlChinhSuaThongTin.Size = new Size(295, 153);
            pnlChinhSuaThongTin.TabIndex = 33;
            pnlChinhSuaThongTin.Click += pnlChinhSuaThongTin_Click;
            // 
            // payment_extend_label
            // 
            payment_extend_label.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_extend_label.ForeColor = Color.Black;
            payment_extend_label.Location = new Point(5, 91);
            payment_extend_label.Margin = new Padding(0);
            payment_extend_label.Name = "payment_extend_label";
            payment_extend_label.Size = new Size(280, 40);
            payment_extend_label.TabIndex = 1;
            payment_extend_label.Text = "Chỉnh sửa thông tin";
            payment_extend_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // payment_extend_pictureBox
            // 
            payment_extend_pictureBox.Image = Properties.Resources.edit__1_;
            payment_extend_pictureBox.InitialImage = Properties.Resources.edit__1_;
            payment_extend_pictureBox.Location = new Point(117, 25);
            payment_extend_pictureBox.Margin = new Padding(0);
            payment_extend_pictureBox.Name = "payment_extend_pictureBox";
            payment_extend_pictureBox.Size = new Size(62, 62);
            payment_extend_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            payment_extend_pictureBox.TabIndex = 0;
            payment_extend_pictureBox.TabStop = false;
            // 
            // pnlXoaNhanVien
            // 
            pnlXoaNhanVien.BackColor = Color.Transparent;
            pnlXoaNhanVien.Controls.Add(payment_register_label);
            pnlXoaNhanVien.Controls.Add(payment_register_pictureBox);
            pnlXoaNhanVien.FillColor = Color.LightCyan;
            pnlXoaNhanVien.Location = new Point(354, 537);
            pnlXoaNhanVien.Margin = new Padding(0);
            pnlXoaNhanVien.Name = "pnlXoaNhanVien";
            pnlXoaNhanVien.Radius = 10;
            pnlXoaNhanVien.ShadowColor = Color.DimGray;
            pnlXoaNhanVien.ShadowShift = 10;
            pnlXoaNhanVien.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            pnlXoaNhanVien.Size = new Size(295, 153);
            pnlXoaNhanVien.TabIndex = 32;
            pnlXoaNhanVien.Click += pnlXoaNhanVien_Click;
            // 
            // payment_register_label
            // 
            payment_register_label.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_register_label.ForeColor = Color.Black;
            payment_register_label.Location = new Point(5, 91);
            payment_register_label.Margin = new Padding(0);
            payment_register_label.Name = "payment_register_label";
            payment_register_label.Size = new Size(282, 40);
            payment_register_label.TabIndex = 1;
            payment_register_label.Text = "Xóa nhân viên";
            payment_register_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // payment_register_pictureBox
            // 
            payment_register_pictureBox.Image = Properties.Resources.delete;
            payment_register_pictureBox.InitialImage = Properties.Resources.delete;
            payment_register_pictureBox.Location = new Point(117, 25);
            payment_register_pictureBox.Margin = new Padding(0);
            payment_register_pictureBox.Name = "payment_register_pictureBox";
            payment_register_pictureBox.Size = new Size(62, 62);
            payment_register_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            payment_register_pictureBox.TabIndex = 0;
            payment_register_pictureBox.TabStop = false;
            // 
            // pnlThemNhanVien
            // 
            pnlThemNhanVien.BackColor = Color.Transparent;
            pnlThemNhanVien.Controls.Add(register_label);
            pnlThemNhanVien.Controls.Add(register_pictureBox);
            pnlThemNhanVien.FillColor = Color.LightCyan;
            pnlThemNhanVien.Location = new Point(34, 537);
            pnlThemNhanVien.Margin = new Padding(0);
            pnlThemNhanVien.Name = "pnlThemNhanVien";
            pnlThemNhanVien.Radius = 10;
            pnlThemNhanVien.ShadowColor = Color.DimGray;
            pnlThemNhanVien.ShadowShift = 10;
            pnlThemNhanVien.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            pnlThemNhanVien.Size = new Size(295, 153);
            pnlThemNhanVien.TabIndex = 31;
            pnlThemNhanVien.Click += pnlThemNhanVien_Click;
            // 
            // register_label
            // 
            register_label.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_label.ForeColor = Color.Black;
            register_label.Location = new Point(5, 91);
            register_label.Margin = new Padding(0);
            register_label.Name = "register_label";
            register_label.Size = new Size(281, 40);
            register_label.TabIndex = 1;
            register_label.Text = "Thêm nhân viên";
            register_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // register_pictureBox
            // 
            register_pictureBox.Image = Properties.Resources.add1;
            register_pictureBox.Location = new Point(117, 25);
            register_pictureBox.Margin = new Padding(0);
            register_pictureBox.Name = "register_pictureBox";
            register_pictureBox.Size = new Size(62, 62);
            register_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            register_pictureBox.TabIndex = 0;
            register_pictureBox.TabStop = false;
            // 
            // bg_pictureBox
            // 
            bg_pictureBox.Image = Properties.Resources.vecteezy_creative_story_package_background_colorful_bright_green_22666933;
            bg_pictureBox.Location = new Point(0, 62);
            bg_pictureBox.Margin = new Padding(0);
            bg_pictureBox.Name = "bg_pictureBox";
            bg_pictureBox.Size = new Size(997, 212);
            bg_pictureBox.TabIndex = 35;
            bg_pictureBox.TabStop = false;
            // 
            // pnlTraCuuNhanVien
            // 
            pnlTraCuuNhanVien.BackColor = Color.Transparent;
            pnlTraCuuNhanVien.Controls.Add(btnTraCuu);
            pnlTraCuuNhanVien.Controls.Add(pictureBox1);
            pnlTraCuuNhanVien.FillColor = Color.LightCyan;
            pnlTraCuuNhanVien.Location = new Point(354, 359);
            pnlTraCuuNhanVien.Margin = new Padding(0);
            pnlTraCuuNhanVien.Name = "pnlTraCuuNhanVien";
            pnlTraCuuNhanVien.Radius = 10;
            pnlTraCuuNhanVien.ShadowColor = Color.DimGray;
            pnlTraCuuNhanVien.ShadowShift = 10;
            pnlTraCuuNhanVien.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            pnlTraCuuNhanVien.Size = new Size(295, 153);
            pnlTraCuuNhanVien.TabIndex = 33;
            pnlTraCuuNhanVien.Click += pnlTraCuuNhanVien_Click;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.ForeColor = Color.Black;
            btnTraCuu.Location = new Point(5, 91);
            btnTraCuu.Margin = new Padding(0);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(282, 40);
            btnTraCuu.TabIndex = 1;
            btnTraCuu.Text = "Tra cứu nhân viên";
            btnTraCuu.TextAlign = ContentAlignment.MiddleCenter;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search_interface_symbol;
            pictureBox1.InitialImage = Properties.Resources.delete;
            pictureBox1.Location = new Point(117, 25);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlTraCuuNhanVien);
            Controls.Add(bg_pictureBox);
            Controls.Add(label1);
            Controls.Add(pnlChinhSuaThongTin);
            Controls.Add(pnlXoaNhanVien);
            Controls.Add(pnlThemNhanVien);
            Controls.Add(guna2Separator1);
            Controls.Add(lbQuanLyNhanVien);
            DoubleBuffered = true;
            Margin = new Padding(0);
            Name = "QuanLyNhanVien";
            Size = new Size(998, 731);
            Load += QuanLyNhanVien_Load;
            pnlChinhSuaThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)payment_extend_pictureBox).EndInit();
            pnlXoaNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)payment_register_pictureBox).EndInit();
            pnlThemNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)register_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg_pictureBox).EndInit();
            pnlTraCuuNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbQuanLyNhanVien;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Panel insert_result_panel;
        private Panel card_panel;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlChinhSuaThongTin;
        private Label payment_extend_label;
        private PictureBox payment_extend_pictureBox;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlXoaNhanVien;
        private Label payment_register_label;
        private PictureBox payment_register_pictureBox;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlThemNhanVien;
        private Label register_label;
        private PictureBox register_pictureBox;
        private PictureBox bg_pictureBox;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlTraCuuNhanVien;
        private Label btnTraCuu;
        private PictureBox pictureBox1;
    }
}
