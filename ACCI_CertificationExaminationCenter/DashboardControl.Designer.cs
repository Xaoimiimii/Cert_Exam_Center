using System.Windows.Forms;

namespace ACCI_CertificationExaminationCenter
{
    partial class DashboardControl
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
            hello_label = new Label();
            register_pictureBox = new PictureBox();
            register_label = new Label();
            register_guna2ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            payment_register_guna2ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            payment_register_label = new Label();
            payment_register_pictureBox = new PictureBox();
            extend_guna2ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            extend_label = new Label();
            extend_pictureBox = new PictureBox();
            payment_extend_guna2ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            payment_extend_label = new Label();
            payment_extend_pictureBox = new PictureBox();
            results_guna2ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            results_label = new Label();
            result_pictureBox = new PictureBox();
            certificate_guna2ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            certificate_label = new Label();
            certificate_pictureBox = new PictureBox();
            bg_pictureBox = new PictureBox();
            date_label = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)register_pictureBox).BeginInit();
            register_guna2ShadowPanel.SuspendLayout();
            payment_register_guna2ShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payment_register_pictureBox).BeginInit();
            extend_guna2ShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)extend_pictureBox).BeginInit();
            payment_extend_guna2ShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payment_extend_pictureBox).BeginInit();
            results_guna2ShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)result_pictureBox).BeginInit();
            certificate_guna2ShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)certificate_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // hello_label
            // 
            hello_label.AutoSize = true;
            hello_label.BackColor = Color.Transparent;
            hello_label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hello_label.Location = new Point(41, 97);
            hello_label.Margin = new Padding(0);
            hello_label.Name = "hello_label";
            hello_label.Size = new Size(459, 86);
            hello_label.TabIndex = 2;
            hello_label.Text = "Xin chào, user";
            // 
            // register_pictureBox
            // 
            register_pictureBox.Image = Properties.Resources.register_black_128;
            register_pictureBox.Location = new Point(190, 40);
            register_pictureBox.Margin = new Padding(0);
            register_pictureBox.Name = "register_pictureBox";
            register_pictureBox.Size = new Size(100, 100);
            register_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            register_pictureBox.TabIndex = 0;
            register_pictureBox.TabStop = false;
            register_pictureBox.Click += register_pictureBox_Click;
            register_pictureBox.MouseEnter += register_pictureBox_MouseEnter;
            register_pictureBox.MouseLeave += register_pictureBox_MouseLeave;
            // 
            // register_label
            // 
            register_label.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_label.ForeColor = Color.Black;
            register_label.Location = new Point(8, 145);
            register_label.Margin = new Padding(0);
            register_label.Name = "register_label";
            register_label.Size = new Size(456, 64);
            register_label.TabIndex = 1;
            register_label.Text = "Đăng ký thi chứng chỉ";
            register_label.TextAlign = ContentAlignment.MiddleCenter;
            register_label.Click += register_label_Click;
            register_label.MouseEnter += register_label_MouseEnter;
            register_label.MouseLeave += register_label_MouseLeave;
            // 
            // register_guna2ShadowPanel
            // 
            register_guna2ShadowPanel.BackColor = Color.Transparent;
            register_guna2ShadowPanel.Controls.Add(register_label);
            register_guna2ShadowPanel.Controls.Add(register_pictureBox);
            register_guna2ShadowPanel.FillColor = Color.LightCyan;
            register_guna2ShadowPanel.Location = new Point(50, 500);
            register_guna2ShadowPanel.Margin = new Padding(0);
            register_guna2ShadowPanel.Name = "register_guna2ShadowPanel";
            register_guna2ShadowPanel.Radius = 10;
            register_guna2ShadowPanel.ShadowColor = Color.DimGray;
            register_guna2ShadowPanel.ShadowShift = 10;
            register_guna2ShadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            register_guna2ShadowPanel.Size = new Size(480, 245);
            register_guna2ShadowPanel.TabIndex = 4;
            register_guna2ShadowPanel.Click += register_guna2ShadowPanel_Click;
            register_guna2ShadowPanel.MouseEnter += register_guna2ShadowPanel_MouseEnter;
            register_guna2ShadowPanel.MouseLeave += register_guna2ShadowPanel_MouseLeave;
            // 
            // payment_register_guna2ShadowPanel
            // 
            payment_register_guna2ShadowPanel.BackColor = Color.Transparent;
            payment_register_guna2ShadowPanel.Controls.Add(payment_register_label);
            payment_register_guna2ShadowPanel.Controls.Add(payment_register_pictureBox);
            payment_register_guna2ShadowPanel.FillColor = Color.LightCyan;
            payment_register_guna2ShadowPanel.Location = new Point(570, 500);
            payment_register_guna2ShadowPanel.Margin = new Padding(0);
            payment_register_guna2ShadowPanel.Name = "payment_register_guna2ShadowPanel";
            payment_register_guna2ShadowPanel.Radius = 10;
            payment_register_guna2ShadowPanel.ShadowColor = Color.DimGray;
            payment_register_guna2ShadowPanel.ShadowShift = 10;
            payment_register_guna2ShadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            payment_register_guna2ShadowPanel.Size = new Size(480, 245);
            payment_register_guna2ShadowPanel.TabIndex = 5;
            payment_register_guna2ShadowPanel.MouseEnter += payment_register_guna2ShadowPanel_MouseEnter;
            payment_register_guna2ShadowPanel.MouseLeave += payment_register_guna2ShadowPanel_MouseLeave;
            // 
            // payment_register_label
            // 
            payment_register_label.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_register_label.ForeColor = Color.Black;
            payment_register_label.Location = new Point(8, 145);
            payment_register_label.Margin = new Padding(0);
            payment_register_label.Name = "payment_register_label";
            payment_register_label.Size = new Size(459, 64);
            payment_register_label.TabIndex = 1;
            payment_register_label.Text = "Thanh toán đăng ký thi";
            payment_register_label.TextAlign = ContentAlignment.MiddleCenter;
            payment_register_label.MouseEnter += payment_register_label_MouseEnter;
            payment_register_label.MouseLeave += payment_register_label_MouseLeave;
            // 
            // payment_register_pictureBox
            // 
            payment_register_pictureBox.Image = Properties.Resources.pay_regis_black_128;
            payment_register_pictureBox.Location = new Point(190, 40);
            payment_register_pictureBox.Margin = new Padding(0);
            payment_register_pictureBox.Name = "payment_register_pictureBox";
            payment_register_pictureBox.Size = new Size(100, 100);
            payment_register_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            payment_register_pictureBox.TabIndex = 0;
            payment_register_pictureBox.TabStop = false;
            payment_register_pictureBox.MouseEnter += payment_register_pictureBox_MouseEnter;
            payment_register_pictureBox.MouseLeave += payment_register_pictureBox_MouseLeave;
            // 
            // extend_guna2ShadowPanel
            // 
            extend_guna2ShadowPanel.BackColor = Color.Transparent;
            extend_guna2ShadowPanel.Controls.Add(extend_label);
            extend_guna2ShadowPanel.Controls.Add(extend_pictureBox);
            extend_guna2ShadowPanel.FillColor = Color.LightCyan;
            extend_guna2ShadowPanel.Location = new Point(50, 785);
            extend_guna2ShadowPanel.Margin = new Padding(0);
            extend_guna2ShadowPanel.Name = "extend_guna2ShadowPanel";
            extend_guna2ShadowPanel.Radius = 10;
            extend_guna2ShadowPanel.ShadowColor = Color.DimGray;
            extend_guna2ShadowPanel.ShadowShift = 10;
            extend_guna2ShadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            extend_guna2ShadowPanel.Size = new Size(480, 245);
            extend_guna2ShadowPanel.TabIndex = 6;
            extend_guna2ShadowPanel.MouseEnter += extend_guna2ShadowPanel_MouseEnter;
            extend_guna2ShadowPanel.MouseLeave += extend_guna2ShadowPanel_MouseLeave;
            // 
            // extend_label
            // 
            extend_label.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            extend_label.ForeColor = Color.Black;
            extend_label.Location = new Point(8, 145);
            extend_label.Margin = new Padding(0);
            extend_label.Name = "extend_label";
            extend_label.Size = new Size(456, 64);
            extend_label.TabIndex = 1;
            extend_label.Text = "Gia hạn thi";
            extend_label.TextAlign = ContentAlignment.MiddleCenter;
            extend_label.MouseEnter += extend_label_MouseEnter;
            extend_label.MouseLeave += extend_label_MouseLeave;
            // 
            // extend_pictureBox
            // 
            extend_pictureBox.Image = Properties.Resources.calendar_black_128;
            extend_pictureBox.Location = new Point(190, 40);
            extend_pictureBox.Margin = new Padding(0);
            extend_pictureBox.Name = "extend_pictureBox";
            extend_pictureBox.Size = new Size(100, 100);
            extend_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            extend_pictureBox.TabIndex = 0;
            extend_pictureBox.TabStop = false;
            extend_pictureBox.MouseEnter += extend_pictureBox_MouseEnter;
            extend_pictureBox.MouseLeave += extend_pictureBox_MouseLeave;
            // 
            // payment_extend_guna2ShadowPanel
            // 
            payment_extend_guna2ShadowPanel.BackColor = Color.Transparent;
            payment_extend_guna2ShadowPanel.Controls.Add(payment_extend_label);
            payment_extend_guna2ShadowPanel.Controls.Add(payment_extend_pictureBox);
            payment_extend_guna2ShadowPanel.FillColor = Color.LightCyan;
            payment_extend_guna2ShadowPanel.Location = new Point(1090, 500);
            payment_extend_guna2ShadowPanel.Margin = new Padding(0);
            payment_extend_guna2ShadowPanel.Name = "payment_extend_guna2ShadowPanel";
            payment_extend_guna2ShadowPanel.Radius = 10;
            payment_extend_guna2ShadowPanel.ShadowColor = Color.DimGray;
            payment_extend_guna2ShadowPanel.ShadowShift = 10;
            payment_extend_guna2ShadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            payment_extend_guna2ShadowPanel.Size = new Size(480, 245);
            payment_extend_guna2ShadowPanel.TabIndex = 7;
            payment_extend_guna2ShadowPanel.MouseEnter += payment_extend_guna2ShadowPanel_MouseEnter;
            payment_extend_guna2ShadowPanel.MouseLeave += payment_extend_guna2ShadowPanel_MouseLeave;
            // 
            // payment_extend_label
            // 
            payment_extend_label.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_extend_label.ForeColor = Color.Black;
            payment_extend_label.Location = new Point(8, 145);
            payment_extend_label.Margin = new Padding(0);
            payment_extend_label.Name = "payment_extend_label";
            payment_extend_label.Size = new Size(455, 64);
            payment_extend_label.TabIndex = 1;
            payment_extend_label.Text = "Thanh toán gia hạn";
            payment_extend_label.TextAlign = ContentAlignment.MiddleCenter;
            payment_extend_label.MouseEnter += payment_extend_label_MouseEnter;
            payment_extend_label.MouseLeave += payment_extend_label_MouseLeave;
            // 
            // payment_extend_pictureBox
            // 
            payment_extend_pictureBox.Image = Properties.Resources.pay_extend_black_128;
            payment_extend_pictureBox.Location = new Point(190, 40);
            payment_extend_pictureBox.Margin = new Padding(0);
            payment_extend_pictureBox.Name = "payment_extend_pictureBox";
            payment_extend_pictureBox.Size = new Size(100, 100);
            payment_extend_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            payment_extend_pictureBox.TabIndex = 0;
            payment_extend_pictureBox.TabStop = false;
            payment_extend_pictureBox.MouseEnter += payment_extend_pictureBox_MouseEnter;
            payment_extend_pictureBox.MouseLeave += payment_extend_pictureBox_MouseLeave;
            // 
            // results_guna2ShadowPanel
            // 
            results_guna2ShadowPanel.BackColor = Color.Transparent;
            results_guna2ShadowPanel.Controls.Add(results_label);
            results_guna2ShadowPanel.Controls.Add(result_pictureBox);
            results_guna2ShadowPanel.FillColor = Color.LightCyan;
            results_guna2ShadowPanel.Location = new Point(570, 785);
            results_guna2ShadowPanel.Margin = new Padding(0);
            results_guna2ShadowPanel.Name = "results_guna2ShadowPanel";
            results_guna2ShadowPanel.Radius = 10;
            results_guna2ShadowPanel.ShadowColor = Color.DimGray;
            results_guna2ShadowPanel.ShadowShift = 10;
            results_guna2ShadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            results_guna2ShadowPanel.Size = new Size(480, 245);
            results_guna2ShadowPanel.TabIndex = 8;
            results_guna2ShadowPanel.Click += results_guna2ShadowPanel_Click;
            results_guna2ShadowPanel.MouseEnter += results_guna2ShadowPanel_MouseEnter;
            results_guna2ShadowPanel.MouseLeave += results_guna2ShadowPanel_MouseLeave;
            // 
            // results_label
            // 
            results_label.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            results_label.ForeColor = Color.Black;
            results_label.Location = new Point(8, 145);
            results_label.Margin = new Padding(0);
            results_label.Name = "results_label";
            results_label.Size = new Size(459, 64);
            results_label.TabIndex = 1;
            results_label.Text = "Cập nhật điểm thi";
            results_label.TextAlign = ContentAlignment.MiddleCenter;
            results_label.Click += results_label_Click;
            results_label.MouseEnter += results_label_MouseEnter;
            results_label.MouseLeave += results_label_MouseLeave;
            // 
            // result_pictureBox
            // 
            result_pictureBox.Image = Properties.Resources.grade_black_128;
            result_pictureBox.Location = new Point(190, 40);
            result_pictureBox.Margin = new Padding(0);
            result_pictureBox.Name = "result_pictureBox";
            result_pictureBox.Size = new Size(100, 100);
            result_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            result_pictureBox.TabIndex = 0;
            result_pictureBox.TabStop = false;
            result_pictureBox.Click += result_pictureBox_Click;
            result_pictureBox.MouseEnter += result_pictureBox_MouseEnter;
            result_pictureBox.MouseLeave += result_pictureBox_MouseLeave;
            // 
            // certificate_guna2ShadowPanel
            // 
            certificate_guna2ShadowPanel.BackColor = Color.Transparent;
            certificate_guna2ShadowPanel.Controls.Add(certificate_label);
            certificate_guna2ShadowPanel.Controls.Add(certificate_pictureBox);
            certificate_guna2ShadowPanel.FillColor = Color.LightCyan;
            certificate_guna2ShadowPanel.Location = new Point(1090, 785);
            certificate_guna2ShadowPanel.Margin = new Padding(0);
            certificate_guna2ShadowPanel.Name = "certificate_guna2ShadowPanel";
            certificate_guna2ShadowPanel.Radius = 10;
            certificate_guna2ShadowPanel.ShadowColor = Color.DimGray;
            certificate_guna2ShadowPanel.ShadowShift = 10;
            certificate_guna2ShadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            certificate_guna2ShadowPanel.Size = new Size(480, 245);
            certificate_guna2ShadowPanel.TabIndex = 9;
            certificate_guna2ShadowPanel.Click += certificate_guna2ShadowPanel_Click;
            certificate_guna2ShadowPanel.MouseEnter += certificate_guna2ShadowPanel_MouseEnter;
            certificate_guna2ShadowPanel.MouseLeave += certificate_guna2ShadowPanel_MouseLeave;
            // 
            // certificate_label
            // 
            certificate_label.Font = new Font("Calibri", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            certificate_label.ForeColor = Color.Black;
            certificate_label.Location = new Point(8, 145);
            certificate_label.Margin = new Padding(0);
            certificate_label.Name = "certificate_label";
            certificate_label.Size = new Size(455, 64);
            certificate_label.TabIndex = 1;
            certificate_label.Text = "Cấp chứng chỉ";
            certificate_label.TextAlign = ContentAlignment.MiddleCenter;
            certificate_label.Click += certificate_label_Click;
            certificate_label.MouseEnter += certificate_label_MouseEnter;
            certificate_label.MouseLeave += certificate_label_MouseLeave;
            // 
            // certificate_pictureBox
            // 
            certificate_pictureBox.Image = Properties.Resources.cert_black_128;
            certificate_pictureBox.Location = new Point(190, 40);
            certificate_pictureBox.Margin = new Padding(0);
            certificate_pictureBox.Name = "certificate_pictureBox";
            certificate_pictureBox.Size = new Size(100, 100);
            certificate_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            certificate_pictureBox.TabIndex = 0;
            certificate_pictureBox.TabStop = false;
            certificate_pictureBox.Click += certificate_pictureBox_Click;
            certificate_pictureBox.MouseEnter += certificate_pictureBox_MouseEnter;
            certificate_pictureBox.MouseLeave += certificate_pictureBox_MouseLeave;
            // 
            // bg_pictureBox
            // 
            bg_pictureBox.Image = Properties.Resources.freepik__adjust__6391;
            bg_pictureBox.Location = new Point(0, 0);
            bg_pictureBox.Margin = new Padding(0);
            bg_pictureBox.Name = "bg_pictureBox";
            bg_pictureBox.Size = new Size(1620, 340);
            bg_pictureBox.TabIndex = 10;
            bg_pictureBox.TabStop = false;
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.BackColor = Color.Transparent;
            date_label.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_label.ForeColor = Color.White;
            date_label.Location = new Point(41, 185);
            date_label.Margin = new Padding(0);
            date_label.Name = "date_label";
            date_label.Size = new Size(308, 50);
            date_label.TabIndex = 11;
            date_label.Text = "Thứ tư, 4/9/2025";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 390);
            label1.Name = "label1";
            label1.Size = new Size(375, 59);
            label1.TabIndex = 12;
            label1.Text = "Bạn muốn làm gì?";
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(hello_label);
            Controls.Add(date_label);
            Controls.Add(bg_pictureBox);
            Controls.Add(certificate_guna2ShadowPanel);
            Controls.Add(results_guna2ShadowPanel);
            Controls.Add(payment_extend_guna2ShadowPanel);
            Controls.Add(extend_guna2ShadowPanel);
            Controls.Add(payment_register_guna2ShadowPanel);
            Controls.Add(register_guna2ShadowPanel);
            Margin = new Padding(0);
            Name = "DashboardControl";
            Size = new Size(1620, 1169);
            Load += DashboardControl_Load;
            ((System.ComponentModel.ISupportInitialize)register_pictureBox).EndInit();
            register_guna2ShadowPanel.ResumeLayout(false);
            payment_register_guna2ShadowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)payment_register_pictureBox).EndInit();
            extend_guna2ShadowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)extend_pictureBox).EndInit();
            payment_extend_guna2ShadowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)payment_extend_pictureBox).EndInit();
            results_guna2ShadowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)result_pictureBox).EndInit();
            certificate_guna2ShadowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)certificate_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hello_label;
        private FlowLayoutPanel register_flowLayoutPanel;
        private PictureBox register_pictureBox;
        private Label register_label;
        private Guna.UI2.WinForms.Guna2ShadowPanel register_guna2ShadowPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel payment_register_guna2ShadowPanel;
        private Label payment_register_label;
        private PictureBox payment_register_pictureBox;
        private Guna.UI2.WinForms.Guna2ShadowPanel extend_guna2ShadowPanel;
        private Label extend_label;
        private PictureBox extend_pictureBox;
        private Guna.UI2.WinForms.Guna2ShadowPanel payment_extend_guna2ShadowPanel;
        private Label payment_extend_label;
        private PictureBox payment_extend_pictureBox;
        private Guna.UI2.WinForms.Guna2ShadowPanel results_guna2ShadowPanel;
        private Label results_label;
        private PictureBox result_pictureBox;
        private Guna.UI2.WinForms.Guna2ShadowPanel certificate_guna2ShadowPanel;
        private Label certificate_label;
        private PictureBox certificate_pictureBox;
        private PictureBox bg_pictureBox;
        private Label date_label;
        private Label label1;
    }
}
