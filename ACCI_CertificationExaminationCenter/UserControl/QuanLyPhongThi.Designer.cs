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
            search_student_guna2TextBox.Location = new Point(223, 138);
            search_student_guna2TextBox.Margin = new Padding(6, 6, 6, 6);
            search_student_guna2TextBox.Name = "search_student_guna2TextBox";
            search_student_guna2TextBox.PlaceholderText = "";
            search_student_guna2TextBox.SelectedText = "";
            search_student_guna2TextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_student_guna2TextBox.Size = new Size(460, 51);
            search_student_guna2TextBox.TabIndex = 43;
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
            // student_dataGridView
            // 
            student_dataGridView.AllowUserToResizeRows = false;
            student_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            student_dataGridView.BackgroundColor = Color.Azure;
            student_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            student_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            student_dataGridView.Location = new Point(24, 213);
            student_dataGridView.Margin = new Padding(0);
            student_dataGridView.MultiSelect = false;
            student_dataGridView.Name = "student_dataGridView";
            student_dataGridView.RowHeadersVisible = false;
            student_dataGridView.RowHeadersWidth = 82;
            student_dataGridView.Size = new Size(1566, 499);
            student_dataGridView.TabIndex = 45;
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
            // txtViTri
            // 
            txtViTri.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtViTri.Location = new Point(49, 122);
            txtViTri.Name = "txtViTri";
            txtViTri.Size = new Size(607, 43);
            txtViTri.TabIndex = 86;
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
            // add_button
            // 
            add_button.BackColor = Color.DarkTurquoise;
            add_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.Transparent;
            add_button.Location = new Point(49, 243);
            add_button.Name = "add_button";
            add_button.Size = new Size(351, 87);
            add_button.TabIndex = 93;
            add_button.Text = "Thêm phòng thi";
            add_button.UseVisualStyleBackColor = false;
            // 
            // alter_button
            // 
            alter_button.BackColor = SystemColors.ActiveBorder;
            alter_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alter_button.ForeColor = Color.Transparent;
            alter_button.Location = new Point(609, 243);
            alter_button.Name = "alter_button";
            alter_button.Size = new Size(351, 87);
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
            confirm_button.Location = new Point(1154, 243);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(351, 87);
            confirm_button.TabIndex = 95;
            confirm_button.Text = "Cập nhật";
            confirm_button.UseVisualStyleBackColor = false;
            // 
            // search_student_button
            // 
            search_student_button.BackColor = Color.DarkTurquoise;
            search_student_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_student_button.ForeColor = Color.Transparent;
            search_student_button.Location = new Point(728, 139);
            search_student_button.Name = "search_student_button";
            search_student_button.Size = new Size(140, 50);
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
            info_panel.Location = new Point(24, 733);
            info_panel.Margin = new Padding(0);
            info_panel.Name = "info_panel";
            info_panel.Size = new Size(1566, 420);
            info_panel.TabIndex = 101;
            // 
            // numSoLuongToiDa
            // 
            numSoLuongToiDa.BackColor = Color.Transparent;
            numSoLuongToiDa.BorderColor = Color.Silver;
            numSoLuongToiDa.BorderRadius = 10;
            numSoLuongToiDa.CustomizableEdges = customizableEdges3;
            numSoLuongToiDa.Font = new Font("Segoe UI", 9F);
            numSoLuongToiDa.Location = new Point(904, 122);
            numSoLuongToiDa.Margin = new Padding(5, 6, 5, 6);
            numSoLuongToiDa.Name = "numSoLuongToiDa";
            numSoLuongToiDa.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            Controls.Add(student_dataGridView);
            Controls.Add(search_student_button);
            Controls.Add(search_student_guna2TextBox);
            Controls.Add(search_student_label);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "QuanLyPhongThi";
            Size = new Size(1618, 1170);
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
