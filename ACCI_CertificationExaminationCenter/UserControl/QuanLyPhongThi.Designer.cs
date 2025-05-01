using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace ACCI_CertificationExaminationCenter
{
    partial class QuanLyPhongThi
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
            txtMaPhongThi = new Guna.UI2.WinForms.Guna2TextBox();
            search_student_label = new Label();
            dgvDSPhongThi = new DataGridView();
            gioiTinh_label = new Label();
            txtViTriPhongThi = new TextBox();
            lbViTri = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnTraCuu = new Button();
            info_panel = new Panel();
            numSoLuongToiDa = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhongThi).BeginInit();
            info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongToiDa).BeginInit();
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
            label1.Size = new Size(391, 59);
            label1.TabIndex = 9;
            label1.Text = "Quản lý phòng thi";
            // 
            // txtMaPhongThi
            // 
            txtMaPhongThi.BorderRadius = 20;
            txtMaPhongThi.CustomizableEdges = customizableEdges5;
            txtMaPhongThi.DefaultText = "";
            txtMaPhongThi.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaPhongThi.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaPhongThi.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaPhongThi.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaPhongThi.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaPhongThi.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaPhongThi.HoverState.BorderColor = Color.Gray;
            txtMaPhongThi.IconLeftOffset = new Point(10, 0);
            txtMaPhongThi.IconRight = Properties.Resources.close__1_;
            txtMaPhongThi.IconRightOffset = new Point(10, 0);
            txtMaPhongThi.Location = new Point(223, 138);
            txtMaPhongThi.Margin = new Padding(6, 6, 6, 6);
            txtMaPhongThi.Name = "txtMaPhongThi";
            txtMaPhongThi.PlaceholderText = "";
            txtMaPhongThi.SelectedText = "";
            txtMaPhongThi.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMaPhongThi.Size = new Size(460, 51);
            txtMaPhongThi.TabIndex = 43;
            // 
            // search_student_label
            // 
            search_student_label.AutoSize = true;
            search_student_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_student_label.Location = new Point(24, 142);
            search_student_label.Margin = new Padding(0);
            search_student_label.Name = "search_student_label";
            search_student_label.Size = new Size(183, 37);
            search_student_label.TabIndex = 42;
            search_student_label.Text = "Mã phòng thi";
            // 
            // dgvDSPhongThi
            // 
            dgvDSPhongThi.AllowUserToResizeRows = false;
            dgvDSPhongThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhongThi.BackgroundColor = Color.Azure;
            dgvDSPhongThi.BorderStyle = BorderStyle.Fixed3D;
            dgvDSPhongThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhongThi.Location = new Point(24, 213);
            dgvDSPhongThi.Margin = new Padding(0);
            dgvDSPhongThi.MultiSelect = false;
            dgvDSPhongThi.Name = "dgvDSPhongThi";
            dgvDSPhongThi.RowHeadersVisible = false;
            dgvDSPhongThi.RowHeadersWidth = 82;
            dgvDSPhongThi.Size = new Size(1566, 578);
            dgvDSPhongThi.TabIndex = 45;
            // 
            // gioiTinh_label
            // 
            gioiTinh_label.AutoSize = true;
            gioiTinh_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gioiTinh_label.Location = new Point(904, 70);
            gioiTinh_label.Margin = new Padding(0);
            gioiTinh_label.Name = "gioiTinh_label";
            gioiTinh_label.Size = new Size(320, 37);
            gioiTinh_label.TabIndex = 81;
            gioiTinh_label.Text = "Số lượng tham gia tối đa";
            // 
            // txtViTriPhongThi
            // 
            txtViTriPhongThi.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtViTriPhongThi.Location = new Point(49, 122);
            txtViTriPhongThi.Name = "txtViTriPhongThi";
            txtViTriPhongThi.Size = new Size(607, 43);
            txtViTriPhongThi.TabIndex = 86;
            // 
            // lbViTri
            // 
            lbViTri.AutoSize = true;
            lbViTri.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbViTri.Location = new Point(49, 70);
            lbViTri.Margin = new Padding(0);
            lbViTri.Name = "lbViTri";
            lbViTri.Size = new Size(75, 37);
            lbViTri.TabIndex = 85;
            lbViTri.Text = "Vị trí";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DarkTurquoise;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Transparent;
            btnThem.Location = new Point(49, 243);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(351, 87);
            btnThem.TabIndex = 93;
            btnThem.Text = "Thêm phòng thi";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ActiveBorder;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Transparent;
            btnXoa.Location = new Point(609, 243);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(351, 87);
            btnXoa.TabIndex = 94;
            btnXoa.Text = "Xóa phòng thi";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += alter_button_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.DarkTurquoise;
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.Transparent;
            btnCapNhat.Location = new Point(1154, 243);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(351, 87);
            btnCapNhat.TabIndex = 95;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.DarkTurquoise;
            btnTraCuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.ForeColor = Color.Transparent;
            btnTraCuu.Location = new Point(726, 127);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(185, 70);
            btnTraCuu.TabIndex = 44;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            // 
            // info_panel
            // 
            info_panel.Controls.Add(numSoLuongToiDa);
            info_panel.Controls.Add(gioiTinh_label);
            info_panel.Controls.Add(btnCapNhat);
            info_panel.Controls.Add(btnXoa);
            info_panel.Controls.Add(btnThem);
            info_panel.Controls.Add(lbViTri);
            info_panel.Controls.Add(txtViTriPhongThi);
            info_panel.Location = new Point(24, 799);
            info_panel.Margin = new Padding(0);
            info_panel.Name = "info_panel";
            info_panel.Size = new Size(1566, 354);
            info_panel.TabIndex = 101;
            // 
            // numSoLuongToiDa
            // 
            numSoLuongToiDa.BackColor = Color.Transparent;
            numSoLuongToiDa.BorderColor = Color.Silver;
            numSoLuongToiDa.BorderRadius = 10;
            numSoLuongToiDa.CustomizableEdges = customizableEdges7;
            numSoLuongToiDa.Font = new Font("Segoe UI", 9F);
            numSoLuongToiDa.Location = new Point(904, 122);
            numSoLuongToiDa.Margin = new Padding(5, 6, 5, 6);
            numSoLuongToiDa.Name = "numSoLuongToiDa";
            numSoLuongToiDa.ShadowDecoration.CustomizableEdges = customizableEdges8;
            numSoLuongToiDa.Size = new Size(327, 48);
            numSoLuongToiDa.TabIndex = 96;
            numSoLuongToiDa.UpDownButtonFillColor = Color.DarkTurquoise;
            // 
            // QuanLyPhongThi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(info_panel);
            Controls.Add(dgvDSPhongThi);
            Controls.Add(btnTraCuu);
            Controls.Add(txtMaPhongThi);
            Controls.Add(search_student_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "QuanLyPhongThi";
            Size = new Size(1618, 1170);
            ((System.ComponentModel.ISupportInitialize)dgvDSPhongThi).EndInit();
            info_panel.ResumeLayout(false);
            info_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongToiDa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhongThi;
        private Label search_student_label;
        private DataGridView dgvDSPhongThi;
        private Label gioiTinh_label;
        private Label tinhTrang_label;
        private TextBox txtViTriPhongThi;
        private Label lbViTri;
        private ComboBox tinhTrang_comboBox;
        private Button btnThem;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnTraCuu;
        private Panel info_panel;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuongToiDa;
    }
}
