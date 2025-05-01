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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            search_student_guna2TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            search_student_label = new Label();
            student_dataGridView = new DataGridView();
            gioiTinh_label = new Label();
            txtViTri = new TextBox();
            lbViTri = new Label();
            add_button = new Button();
            alter_button = new Button();
            confirm_button = new Button();
            search_student_button = new Button();
            info_panel = new Panel();
            numSoLuongToiDa = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)student_dataGridView).BeginInit();
            info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongToiDa).BeginInit();
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
            label1.Size = new Size(246, 37);
            label1.TabIndex = 9;
            label1.Text = "Quản lý phòng thi";
            // 
            // search_student_guna2TextBox
            // 
            search_student_guna2TextBox.BorderRadius = 20;
            search_student_guna2TextBox.CustomizableEdges = customizableEdges1;
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
            search_student_guna2TextBox.Margin = new Padding(4);
            search_student_guna2TextBox.Name = "search_student_guna2TextBox";
            search_student_guna2TextBox.PlaceholderText = "";
            search_student_guna2TextBox.SelectedText = "";
            search_student_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
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
            search_student_label.Size = new Size(115, 23);
            search_student_label.TabIndex = 42;
            search_student_label.Text = "Mã phòng thi";
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
            // gioiTinh_label
            // 
            gioiTinh_label.AutoSize = true;
            gioiTinh_label.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gioiTinh_label.Location = new Point(556, 44);
            gioiTinh_label.Margin = new Padding(0);
            gioiTinh_label.Name = "gioiTinh_label";
            gioiTinh_label.Size = new Size(201, 23);
            gioiTinh_label.TabIndex = 81;
            gioiTinh_label.Text = "Số lượng tham gia tối đa";
            // 
            // txtViTri
            // 
            txtViTri.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtViTri.Location = new Point(201, 76);
            txtViTri.Margin = new Padding(2);
            txtViTri.Name = "txtViTri";
            txtViTri.Size = new Size(204, 30);
            txtViTri.TabIndex = 86;
            // 
            // lbViTri
            // 
            lbViTri.AutoSize = true;
            lbViTri.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbViTri.Location = new Point(282, 45);
            lbViTri.Margin = new Padding(0);
            lbViTri.Name = "lbViTri";
            lbViTri.Size = new Size(46, 23);
            lbViTri.TabIndex = 85;
            lbViTri.Text = "Vị trí";
            // 
            // add_button
            // 
            add_button.BackColor = Color.DarkTurquoise;
            add_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(30, 152);
            add_button.Margin = new Padding(2);
            add_button.Name = "add_button";
            add_button.Size = new Size(216, 40);
            add_button.TabIndex = 93;
            add_button.Text = "Thêm phòng thi";
            add_button.UseVisualStyleBackColor = false;
            // 
            // alter_button
            // 
            alter_button.BackColor = SystemColors.ActiveBorder;
            alter_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alter_button.ForeColor = Color.Transparent;
            alter_button.Location = new Point(375, 152);
            alter_button.Margin = new Padding(2);
            alter_button.Name = "alter_button";
            alter_button.Size = new Size(216, 40);
            alter_button.TabIndex = 94;
            alter_button.Text = "Xóa phòng thi";
            alter_button.UseVisualStyleBackColor = false;
            alter_button.Click += alter_button_Click;
            // 
            // confirm_button
            // 
            confirm_button.BackColor = Color.DarkTurquoise;
            confirm_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_button.ForeColor = Color.Transparent;
            confirm_button.Location = new Point(710, 152);
            confirm_button.Margin = new Padding(2);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(216, 40);
            confirm_button.TabIndex = 95;
            confirm_button.Text = "Cập nhật";
            confirm_button.UseVisualStyleBackColor = false;
            // 
            // search_student_button
            // 
            search_student_button.BackColor = Color.DarkTurquoise;
            search_student_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_student_button.ForeColor = Color.Transparent;
            search_student_button.Location = new Point(448, 87);
            search_student_button.Margin = new Padding(2);
            search_student_button.Name = "search_student_button";
            search_student_button.Size = new Size(86, 31);
            search_student_button.TabIndex = 44;
            search_student_button.Text = "Tra cứu";
            search_student_button.UseVisualStyleBackColor = false;
            // 
            // info_panel
            // 
            info_panel.Controls.Add(numSoLuongToiDa);
            info_panel.Controls.Add(gioiTinh_label);
            info_panel.Controls.Add(confirm_button);
            info_panel.Controls.Add(alter_button);
            info_panel.Controls.Add(add_button);
            info_panel.Controls.Add(lbViTri);
            info_panel.Controls.Add(txtViTri);
            info_panel.Location = new Point(15, 419);
            info_panel.Margin = new Padding(0);
            info_panel.Name = "info_panel";
            info_panel.Size = new Size(964, 211);
            info_panel.TabIndex = 101;
            // 
            // numSoLuongToiDa
            // 
            numSoLuongToiDa.BackColor = Color.Transparent;
            numSoLuongToiDa.BorderColor = Color.Black;
            numSoLuongToiDa.BorderRadius = 10;
            numSoLuongToiDa.CustomizableEdges = customizableEdges3;
            numSoLuongToiDa.Font = new Font("Segoe UI", 9F);
            numSoLuongToiDa.Location = new Point(556, 76);
            numSoLuongToiDa.Margin = new Padding(3, 4, 3, 4);
            numSoLuongToiDa.Name = "numSoLuongToiDa";
            numSoLuongToiDa.ShadowDecoration.CustomizableEdges = customizableEdges4;
            numSoLuongToiDa.Size = new Size(201, 30);
            numSoLuongToiDa.TabIndex = 96;
            numSoLuongToiDa.UpDownButtonFillColor = Color.DarkTurquoise;
            // 
            // QuanLyPhongThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(info_panel);
            Controls.Add(student_dataGridView);
            Controls.Add(search_student_button);
            Controls.Add(search_student_guna2TextBox);
            Controls.Add(search_student_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "QuanLyPhongThi";
            Size = new Size(996, 731);
            ((System.ComponentModel.ISupportInitialize)student_dataGridView).EndInit();
            info_panel.ResumeLayout(false);
            info_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongToiDa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox search_student_guna2TextBox;
        private Label search_student_label;
        private DataGridView student_dataGridView;
        private Label gioiTinh_label;
        private Label tinhTrang_label;
        private TextBox txtViTri;
        private Label lbViTri;
        private ComboBox tinhTrang_comboBox;
        private Button add_button;
        private Button alter_button;
        private Button confirm_button;
        private Button search_student_button;
        private Panel info_panel;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuongToiDa;
    }
}
