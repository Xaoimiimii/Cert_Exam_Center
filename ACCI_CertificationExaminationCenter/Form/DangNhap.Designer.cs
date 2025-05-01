namespace ACCI_CertificationExaminationCenter
{
    partial class DangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            btnDangNhap = new Button();
            panel1 = new Panel();
            txtTenDangNhap = new TextBox();
            username_label = new Label();
            panel2 = new Panel();
            txtMatKhau = new TextBox();
            label1 = new Label();
            lACCI = new Label();
            lName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2148178670;
            pictureBox1.Location = new Point(-700, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1725, 1280);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.AutoRoundedCorners = true;
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(btnDangNhap);
            guna2Panel1.Controls.Add(panel1);
            guna2Panel1.Controls.Add(panel2);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(1028, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(698, 1210);
            guna2Panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 185);
            label2.Name = "label2";
            label2.Size = new Size(247, 59);
            label2.TabIndex = 10;
            label2.Text = "Đăng nhập";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.LightCyan;
            btnDangNhap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(145, 658);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(422, 76);
            btnDangNhap.TabIndex = 9;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(username_label);
            panel1.Location = new Point(81, 315);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 126);
            panel1.TabIndex = 7;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(0, 50);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(554, 50);
            txtTenDangNhap.TabIndex = 1;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_label.Location = new Point(0, 0);
            username_label.Name = "username_label";
            username_label.Size = new Size(245, 45);
            username_label.TabIndex = 0;
            username_label.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(81, 481);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 120);
            panel2.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(0, 50);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(554, 50);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 45);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu:";
            // 
            // lACCI
            // 
            lACCI.AutoSize = true;
            lACCI.BackColor = Color.White;
            lACCI.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lACCI.ForeColor = Color.White;
            lACCI.Location = new Point(35, 950);
            lACCI.Name = "lACCI";
            lACCI.Size = new Size(268, 128);
            lACCI.TabIndex = 11;
            lACCI.Text = "ACCI";
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.BackColor = Color.Transparent;
            lName.Font = new Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lName.ForeColor = Color.White;
            lName.Location = new Point(35, 1078);
            lName.Name = "lName";
            lName.Size = new Size(924, 78);
            lName.TabIndex = 11;
            lName.Text = "Trung tâm tổ chức thi chứng chỉ";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1724, 1209);
            Controls.Add(lName);
            Controls.Add(lACCI);
            Controls.Add(guna2Panel1);
            Controls.Add(pictureBox1);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label2;
        private Button btnDangNhap;
        private Panel panel1;
        private TextBox txtTenDangNhap;
        private Label username_label;
        private Panel panel2;
        private TextBox txtMatKhau;
        private Label label1;
        private Label lACCI;
        private Label lName;
    }
}