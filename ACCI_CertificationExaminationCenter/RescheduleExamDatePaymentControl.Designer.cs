namespace ACCI_CertificationExaminationCenter
{
    partial class RescheduleExamDatePaymentControl
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
            label1 = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            label3 = new Label();
            panel1 = new Panel();
            sbd_label = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 9);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(303, 30);
            label1.TabIndex = 4;
            label1.Text = "Thanh toán gia hạn ngày thi";
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 2;
            guna2Separator1.Location = new Point(-5, 39);
            guna2Separator1.Margin = new Padding(0);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(943, 10);
            guna2Separator1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 49);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 51;
            label2.Text = "Đối tượng gia hạn";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(688, 132);
            dataGridView1.TabIndex = 52;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Mã phiếu đăng ký";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Họ tên thí sinh";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Loại đánh giá";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Ngày thi mới";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(727, 129);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(173, 37);
            button1.TabIndex = 53;
            button1.Text = "Xác nhận lập hoá đơn";
            button1.UseVisualStyleBackColor = false;
            // 
            // guna2Separator2
            // 
            guna2Separator2.FillThickness = 2;
            guna2Separator2.Location = new Point(0, 249);
            guna2Separator2.Margin = new Padding(0);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(920, 10);
            guna2Separator2.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 290);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(193, 25);
            label3.TabIndex = 55;
            label3.Text = "Thông tin thanh toán";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(sbd_label);
            panel1.Location = new Point(12, 318);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 100);
            panel1.TabIndex = 56;
            // 
            // sbd_label
            // 
            sbd_label.AutoSize = true;
            sbd_label.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbd_label.Location = new Point(17, 15);
            sbd_label.Margin = new Padding(2, 0, 2, 0);
            sbd_label.Name = "sbd_label";
            sbd_label.Size = new Size(88, 19);
            sbd_label.TabIndex = 57;
            sbd_label.Text = "Số tài khoản:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 58;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 60;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 56);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 19);
            label4.TabIndex = 59;
            label4.Text = "Chủ tài khoản:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(450, 11);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 23);
            textBox3.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(357, 15);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 19);
            label5.TabIndex = 61;
            label5.Text = "Ngân hàng:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(450, 49);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 23);
            textBox4.TabIndex = 60;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(357, 53);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 59;
            label6.Text = "Số tiền :";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(727, 358);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(173, 37);
            button2.TabIndex = 57;
            button2.Text = "In hoá đơn";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(369, 534);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(191, 62);
            button3.TabIndex = 58;
            button3.Text = "Xác nhận thanh toán thành công";
            button3.UseVisualStyleBackColor = false;
            // 
            // RescheduleExamDatePaymentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(920, 617);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(guna2Separator2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RescheduleExamDatePaymentControl";
            Text = "RescheduleExamDatePaymentControl";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Label label3;
        private Panel panel1;
        private Label sbd_label;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label6;
        private Button button2;
        private Button button3;
    }
}