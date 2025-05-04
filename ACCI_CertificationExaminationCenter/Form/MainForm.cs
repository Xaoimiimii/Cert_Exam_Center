namespace ACCI_CertificationExaminationCenter
{
    public partial class MainForm : Form, ILogoutable
    {
        public event Action LogoutRequested;
        bool menuExpand = false;
        bool paymentExpand = false;
        public bool isInDashboard = false;
        public bool isInRegister = false;
        public bool isInExamineeResults = false;
        public bool isInCertificate = false;
        public bool isInXuatPhieuDK = false;
        public bool isInGiaHanNgayThi = false;
        public bool isInLapHoaDon = false;
        public bool isInThanhToanDangKy = false;
        public bool isInThanhToanGiaHan = false;
        public bool isInXuatHoaDon = false;
        public bool isInLenLichPhongThi = false;
        public bool isInQLKhachHang = false;
        public bool isInQLLichThi = false;
        public bool isInQLPhongThi = false;
        public bool isInQLNhanVien = false;
        public bool isInCapNhatPhieuDuThi = false;
        public string tenDangNhap;
        public string vaiTro;

        public MainForm(string username, string role)
        {
            InitializeComponent();
            this.tenDangNhap = username;
            this.vaiTro = role;
            LoadControl(new TrangChu(this));
            UpdateStatus("Dashboard");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (vaiTro == "Tiếp nhận")
            {
                out_menu_flowLayoutPanel.Margin = new Padding(0, 320, 0, 0);
                register_menu_flowLayoutPanel.Visible = true;
                panelXuatPhieuDK.Visible = true;
                panelGiaHanNgayThi.Visible = true;
                certificate_menu_flowLayoutPanel.Visible = true;

                panelLapHoaDon.Visible = false;
                panelThanhToanDangKy.Visible = false;
                panelThanhToanGiaHan.Visible = false;
                panelXuatHoaDon.Visible = false;

                results_menu_flowLayoutPanel.Visible = false;

                panelQLKhachHang.Visible = false;
                panelQLLichThi.Visible = false;
                panelQLPhongThi.Visible = false;
                panelQLNhanVien.Visible = false;

                panelLenLichPhongThi.Visible = true;
                panelCapNhatPhieuDuThi.Visible = true;

            }
            else if (vaiTro == "Kế toán")
            {
                out_menu_flowLayoutPanel.Margin = new Padding(0, 320, 0, 0);
                register_menu_flowLayoutPanel.Visible = false;
                panelXuatPhieuDK.Visible = false;
                panelGiaHanNgayThi.Visible = false;
                certificate_menu_flowLayoutPanel.Visible = false;

                panelLapHoaDon.Visible = true;
                panelThanhToanDangKy.Visible = true;
                panelThanhToanGiaHan.Visible = true;
                panelXuatHoaDon.Visible = true;

                results_menu_flowLayoutPanel.Visible = false;

                panelQLKhachHang.Visible = false;
                panelQLLichThi.Visible = false;
                panelQLPhongThi.Visible = false;
                panelQLNhanVien.Visible = false;

                panelLenLichPhongThi.Visible = true;
                panelCapNhatPhieuDuThi.Visible = true;

            }
            else if (vaiTro == "Nhập liệu")
            {
                out_menu_flowLayoutPanel.Margin = new Padding(0, 520, 0, 0);
                register_menu_flowLayoutPanel.Visible = false;
                panelXuatPhieuDK.Visible = false;
                panelGiaHanNgayThi.Visible = false;
                certificate_menu_flowLayoutPanel.Visible = false;

                panelLapHoaDon.Visible = false;
                panelThanhToanDangKy.Visible = false;
                panelThanhToanGiaHan.Visible = false;
                panelXuatHoaDon.Visible = false;

                results_menu_flowLayoutPanel.Visible = true;

                panelQLKhachHang.Visible = false;
                panelQLLichThi.Visible = false;
                panelQLPhongThi.Visible = false;
                panelQLNhanVien.Visible = false;

                panelLenLichPhongThi.Visible = true;
                panelCapNhatPhieuDuThi.Visible = true;
            }
            else if (vaiTro == "Quản lý")
            {
                out_menu_flowLayoutPanel.Margin = new Padding(0, 480, 0, 0);
                register_menu_flowLayoutPanel.Visible = false;
                panelXuatPhieuDK.Visible = false;
                panelGiaHanNgayThi.Visible = false;
                certificate_menu_flowLayoutPanel.Visible = false;

                panelLapHoaDon.Visible = false;
                panelThanhToanDangKy.Visible = false;
                panelThanhToanGiaHan.Visible = false;
                panelXuatHoaDon.Visible = false;

                results_menu_flowLayoutPanel.Visible = false;

                panelQLKhachHang.Visible = true;
                panelQLLichThi.Visible = true;
                panelQLPhongThi.Visible = true;
                panelQLNhanVien.Visible = true;

                panelLenLichPhongThi.Visible = false;
                panelCapNhatPhieuDuThi.Visible = false;
            }
        }

        public void LoadControl(UserControl control)
        {
            main_panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            main_panel.Controls.Add(control);
        }

        public void UpdateStatus(string currentActivity)
        {
            isInDashboard = false;
            isInRegister = false;
            isInExamineeResults = false;
            isInCertificate = false;
            isInXuatPhieuDK = false;
            isInGiaHanNgayThi = false;
            isInLapHoaDon = false;
            isInThanhToanDangKy = false;
            isInThanhToanGiaHan = false;
            isInXuatHoaDon = false;
            isInLenLichPhongThi = false;
            isInQLKhachHang = false;
            isInQLLichThi = false;
            isInQLPhongThi = false;
            isInQLNhanVien = false;
            isInCapNhatPhieuDuThi = false;


            dashboard_menu_pictureBox.Image = Properties.Resources.dashboard_white;
            register_menu_pictureBox.Image = Properties.Resources.register_white;
            results_menu_pictureBox.Image = Properties.Resources.grade_white;
            certificate_menu_pictureBox.Image = Properties.Resources.cert_white;
            pcGiaHanNgayThi.Image = Properties.Resources.calen_white;
            pxXuatPhieuDangKy.Image = Properties.Resources.printer__1_;
            pcLapHoaDon.Image = Properties.Resources.file__1_;
            pcThanhToanDangKy.Image = Properties.Resources.wallet__2_;
            pcThanhToanGiaHan.Image = Properties.Resources.pay_day__1_;
            pcXuatHoaDon.Image = Properties.Resources.printer__1_;
            pcLenLichPhongThi.Image = Properties.Resources.calendar__3_;
            pcQLKhachHang.Image = Properties.Resources.customer__1_;
            pcQLLichThi.Image = Properties.Resources.calen_white;
            pcQLPhongThi.Image = Properties.Resources.open_door__1_;
            pcQLNhanVien.Image = Properties.Resources.man__3_;
            pcCapNhatPhieuDuThi.Image = Properties.Resources.form__1_;

            if (currentActivity == "Dashboard")
            {
                isInDashboard = true;
                dashboard_menu_pictureBox.Image = Properties.Resources.dashboard_green;
            }
            else if (currentActivity == "Register")
            {
                isInRegister = true;
                register_menu_pictureBox.Image = Properties.Resources.register_green;
            }
            else if (currentActivity == "ExamineeResults")
            {
                isInExamineeResults = true;
                results_menu_pictureBox.Image = Properties.Resources.grade_green;
            }
            else if (currentActivity == "Certificate")
            {
                isInCertificate = true;
                certificate_menu_pictureBox.Image = Properties.Resources.cert_green;
            }
            else if (currentActivity == "GiaHanNgayThi")
            {
                isInGiaHanNgayThi = true;
                pcGiaHanNgayThi.Image = Properties.Resources.calen_green;
            }
            else if (currentActivity == "XuatPhieuDK")
            {
                isInXuatPhieuDK = true;
                pxXuatPhieuDangKy.Image = Properties.Resources.printer__2_;
            }
            else if (currentActivity == "LapHoaDon")
            {
                isInLapHoaDon = true;
                pcLapHoaDon.Image = Properties.Resources.file__2_;
            }
            else if (currentActivity == "ThanhToanDangKy")
            {
                isInThanhToanDangKy = true;
                pcThanhToanDangKy.Image = Properties.Resources.wallet__3_;
            }
            else if (currentActivity == "ThanhToanGiaHan")
            {
                isInThanhToanGiaHan = true;
                pcThanhToanGiaHan.Image = Properties.Resources.pay_day__2_;
            }
            else if (currentActivity == "XuatHoaDon")
            {
                isInXuatHoaDon = true;
                pcXuatHoaDon.Image = Properties.Resources.printer__2_;
            }
            else if (currentActivity == "LenLichPhongThi")
            {
                isInLenLichPhongThi = true;
                pcLenLichPhongThi.Image = Properties.Resources.calendar__4_;
            }
            else if (currentActivity == "QLKhachHang")
            {
                isInQLKhachHang = true;
                pcQLKhachHang.Image = Properties.Resources.customer__2_;
            }
            else if (currentActivity == "QLLichThi")
            {
                isInQLLichThi = true;
                pcQLLichThi.Image = Properties.Resources.calen_green;
            }
            else if (currentActivity == "QLPhongThi")
            {
                isInQLPhongThi = true;
                pcQLPhongThi.Image = Properties.Resources.open_door__2_;
            }
            else if (currentActivity == "QLNhanVien")
            {
                isInQLNhanVien = true;
                pcQLNhanVien.Image = Properties.Resources.man__4_;
            }
            else if (currentActivity == "CapNhatPhieuDuThi")
            {
                isInCapNhatPhieuDuThi = true;
                pcCapNhatPhieuDuThi.Image = Properties.Resources.form__2_;
            }
        }

        public void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                thanhDieuHuong.Width -= 20;
                if (thanhDieuHuong.Width <= 98)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
            else
            {
                thanhDieuHuong.Width += 20;
                if (thanhDieuHuong.Width >= 420)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
        }

        public void paymentTransition_Tick(object sender, EventArgs e)
        {
            //if (paymentExpand)
            //{
            //    payment_menu_group_flowLayoutPanel.Height -= 10;
            //    if (payment_menu_group_flowLayoutPanel.Height <= 80)
            //    {
            //        paymentTransition.Stop();
            //        paymentExpand = false;
            //    }
            //}
            //else
            //{
            //    if (menuExpand)
            //    {
            //        payment_register_menu_pictureBox.Margin = new Padding(76, 24, 3, 3);
            //        payment_extensive_menu_pictureBox.Margin = new Padding(76, 24, 3, 3);
            //    }
            //    else
            //    {
            //        payment_register_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            //        payment_extensive_menu_pictureBox.Margin = new Padding(32, 24, 3, 3);
            //    }
            //    payment_menu_group_flowLayoutPanel.Height += 10;
            //    if (payment_menu_group_flowLayoutPanel.Height >= 240)
            //    {
            //        paymentTransition.Stop();
            //        paymentExpand = true;
            //    }
            //}
        }

        public void show_menu_pictureBox_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            show_menu_pictureBox.Visible = false;
        }

        public void close_menu_pictureBox_Click(object sender, EventArgs e)
        {
            show_menu_pictureBox.Visible = true;
            menuTransition.Start();

            if (paymentExpand)
            {
                paymentTransition.Start();
            }
        }

        public void payment_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            paymentTransition.Start();
        }

        public void payment_menu_pictureBox_Click(object sender, EventArgs e)
        {
            paymentTransition.Start();
        }

        public void payment_menu_label_Click(object sender, EventArgs e)
        {
            paymentTransition.Start();
        }

        public void dashboard_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            UpdateStatus("Dashboard");
            LoadControl(new TrangChu(this));
        }

        public void dashboard_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            UpdateStatus("Dashboard");
            LoadControl(new TrangChu(this));
        }

        public void dashboard_menu_label_Click(object sender, EventArgs e)
        {
            if (isInDashboard)
            {
                return;
            }
            UpdateStatus("Dashboard");
            LoadControl(new TrangChu(this));
        }

        public void register_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInRegister)
            {
                return;
            }
            UpdateStatus("Register");
            LoadControl(new LapPhieuDangKy(this));
        }

        public void register_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInRegister)
            {
                return;
            }
            UpdateStatus("Register");
            LoadControl(new LapPhieuDangKy(this));
        }

        public void register_menu_label_Click(object sender, EventArgs e)
        {
            if (isInRegister)
            {
                return;
            }
            UpdateStatus("Register");
            LoadControl(new LapPhieuDangKy(this));
        }

        public void results_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInExamineeResults)
            {
                return;
            }
            UpdateStatus("ExamineeResults");
            LoadControl(new NhapKetQuaThi(this));
        }

        public void results_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInExamineeResults)
            {
                return;
            }
            UpdateStatus("ExamineeResults");
            LoadControl(new NhapKetQuaThi(this));
        }

        public void results_menu_label_Click(object sender, EventArgs e)
        {
            if (isInExamineeResults)
            {
                return;
            }
            UpdateStatus("ExamineeResults");
            LoadControl(new NhapKetQuaThi(this));
        }

        public void certificate_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            if (isInCertificate)
            {
                return;
            }
            UpdateStatus("Certificate");
            LoadControl(new CapNhatNhanChungChi(this));
        }

        public void certificate_menu_pictureBox_Click(object sender, EventArgs e)
        {
            if (isInCertificate)
            {
                return;
            }
            UpdateStatus("Certificate");
            LoadControl(new CapNhatNhanChungChi(this));
        }

        public void certificate_menu_label_Click(object sender, EventArgs e)
        {
            if (isInCertificate)
            {
                return;
            }
            UpdateStatus("Certificate");
            LoadControl(new CapNhatNhanChungChi(this));
        }

        private void panelXuatPhieuDK_Click(object sender, EventArgs e)
        {
            if (isInXuatPhieuDK) return;
            UpdateStatus("XuatPhieuDK");
            LoadControl(new RegisterDetailsFormControl(this));
        }

        private void lXuatPhieuDK_Click(object sender, EventArgs e)
        {
            if (isInXuatPhieuDK) return;
            UpdateStatus("XuatPhieuDK");
            LoadControl(new RegisterDetailsFormControl(this));
        }

        private void pxXuatPhieuDangKy_Click(object sender, EventArgs e)
        {
            if (isInXuatPhieuDK) return;
            UpdateStatus("XuatPhieuDK");
            LoadControl(new RegisterDetailsFormControl(this));
        }

        private void panelGiaHanNgayThi_Click(object sender, EventArgs e)
        {
            if (isInGiaHanNgayThi) return;
            UpdateStatus("GiaHanNgayThi");
            LoadControl(new GiaHanNgayThi(this));
        }

        private void lGiaHanNgayThi_Click(object sender, EventArgs e)
        {
            if (isInGiaHanNgayThi) return;
            UpdateStatus("GiaHanNgayThi");
            LoadControl(new GiaHanNgayThi(this));
        }

        private void pcGiaHanNgayThi_Click(object sender, EventArgs e)
        {
            if (isInGiaHanNgayThi) return;
            UpdateStatus("GiaHanNgayThi");
            LoadControl(new GiaHanNgayThi(this));
        }

        private void panelLapHoaDon_Click(object sender, EventArgs e)
        {
            if (isInLapHoaDon) return;
            UpdateStatus("LapHoaDon");
            LoadControl(new LapHoaDonDangKy(this));
        }

        private void lLapHoaDon_Click(object sender, EventArgs e)
        {
            if (isInLapHoaDon) return;
            UpdateStatus("LapHoaDon");
            LoadControl(new LapHoaDonDangKy(this));
        }

        private void pcLapHoaDon_Click(object sender, EventArgs e)
        {
            if (isInLapHoaDon) return;
            UpdateStatus("LapHoaDon");
            LoadControl(new LapHoaDonDangKy(this));
        }

        private void panelThanhToanDangKy_Click(object sender, EventArgs e)
        {
            if (isInThanhToanDangKy) return;
            UpdateStatus("ThanhToanDangKy");
            LoadControl(new ThanhToanPhieuDangKy(this));
        }

        private void lThanhToanDangKy_Click(object sender, EventArgs e)
        {
            if (isInThanhToanDangKy) return;
            UpdateStatus("ThanhToanDangKy");
            LoadControl(new ThanhToanPhieuDangKy(this));
        }

        private void pcThanhToanDangKy_Click(object sender, EventArgs e)
        {
            if (isInThanhToanDangKy) return;
            UpdateStatus("ThanhToanDangKy");
            LoadControl(new ThanhToanPhieuDangKy(this));
        }

        private void panelThanhToanGiaHan_Click(object sender, EventArgs e)
        {
            if (isInThanhToanGiaHan) return;
            UpdateStatus("ThanhToanGiaHan");
            LoadControl(new ThanhToanPhieuGiaHan(this));
        }

        private void lThanhToanGiaHan_Click(object sender, EventArgs e)
        {
            if (isInThanhToanGiaHan) return;
            UpdateStatus("ThanhToanGiaHan");
            LoadControl(new ThanhToanPhieuGiaHan(this));
        }

        private void pcThanhToanGiaHan_Click(object sender, EventArgs e)
        {
            if (isInThanhToanGiaHan) return;
            UpdateStatus("ThanhToanGiaHan");
            LoadControl(new ThanhToanPhieuGiaHan(this));
        }

        private void panelXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (isInXuatHoaDon) return;
            UpdateStatus("XuatHoaDon");
            LoadControl(new XuatHoaDonThanhToan(this));
        }

        private void lXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (isInXuatHoaDon) return;
            UpdateStatus("XuatHoaDon");
            LoadControl(new XuatHoaDonThanhToan(this));
        }

        private void pcXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (isInXuatHoaDon) return;
            UpdateStatus("XuatHoaDon");
            LoadControl(new XuatHoaDonThanhToan(this));
        }

        private void panelLenLichPhongThi_Click(object sender, EventArgs e)
        {
            if (isInLenLichPhongThi) return;
            UpdateStatus("LenLichPhongThi");
            LoadControl(new LenLichVaXepPhongThi(this));
        }

        private void lLenLichPhongThi_Click(object sender, EventArgs e)
        {
            if (isInLenLichPhongThi) return;
            UpdateStatus("LenLichPhongThi");
            LoadControl(new LenLichVaXepPhongThi(this));
        }

        private void pcLenLichPhongThi_Click(object sender, EventArgs e)
        {
            if (isInLenLichPhongThi) return;
            UpdateStatus("LenLichPhongThi");
            LoadControl(new LenLichVaXepPhongThi(this));
        }

        private void panelQLNhanVien_Click(object sender, EventArgs e)
        {
            if (isInQLNhanVien) return;
            UpdateStatus("QLNhanVien");
            LoadControl(new QuanLyNhanVien(this));
        }

        private void lQLNhanVien_Click(object sender, EventArgs e)
        {
            if (isInQLNhanVien) return;
            UpdateStatus("QLNhanVien");
            LoadControl(new QuanLyNhanVien(this));
        }

        private void pcQLNhanVien_Click(object sender, EventArgs e)
        {
            if (isInQLNhanVien) return;
            UpdateStatus("QLNhanVien");
            LoadControl(new QuanLyNhanVien(this));
        }

        private void panelQLLichThi_Click(object sender, EventArgs e)
        {
            if (isInQLLichThi) return;
            UpdateStatus("QLLichThi");
            LoadControl(new QuanLyLichThi(this));
        }

        private void lQLLichThi_Click(object sender, EventArgs e)
        {
            if (isInQLLichThi) return;
            UpdateStatus("QLLichThi");
            LoadControl(new QuanLyLichThi(this));
        }

        private void pcQLLichThi_Click(object sender, EventArgs e)
        {
            if (isInQLLichThi) return;
            UpdateStatus("QLLichThi");
            LoadControl(new QuanLyLichThi(this));
        }

        private void panelQLPhongThi_Click(object sender, EventArgs e)
        {
            if (isInQLPhongThi) return;
            UpdateStatus("QLPhongThi");
            LoadControl(new QuanLyPhongThi(this));
        }

        private void lQLPhongThi_Click(object sender, EventArgs e)
        {
            if (isInQLPhongThi) return;
            UpdateStatus("QLPhongThi");
            LoadControl(new QuanLyPhongThi(this));
        }

        private void pcQLPhongThi_Click(object sender, EventArgs e)
        {
            if (isInQLPhongThi) return;
            UpdateStatus("QLPhongThi");
            LoadControl(new QuanLyPhongThi(this));
        }

        private void panelQLKhachHang_Click(object sender, EventArgs e)
        {
            if (isInQLKhachHang) return;
            UpdateStatus("QLKhachHang");
            LoadControl(new QuanLyKhachHang(this));
        }

        private void lQLKhachHang_Click(object sender, EventArgs e)
        {
            if (isInQLKhachHang) return;
            UpdateStatus("QLKhachHang");
            LoadControl(new QuanLyKhachHang(this));
        }

        private void pcQLKhachHang_Click(object sender, EventArgs e)
        {
            if (isInQLKhachHang) return;
            UpdateStatus("QLKhachHang");
            LoadControl(new QuanLyKhachHang(this));
        }

        private void panelCapNhatPhieuDuThi_Click(object sender, EventArgs e)
        {
            if (isInCapNhatPhieuDuThi) return;
            UpdateStatus("CapNhatPhieuDuThi");
            LoadControl(new CapNhatTrangThaiPhieuDuThi(this));
        }

        private void lCapNhatTrangThaiPhieuDuThi_Click(object sender, EventArgs e)
        {
            if (isInCapNhatPhieuDuThi) return;
            UpdateStatus("CapNhatPhieuDuThi");
            LoadControl(new CapNhatTrangThaiPhieuDuThi(this));
        }

        private void pcCapNhatPhieuDuThi_Click(object sender, EventArgs e)
        {
            if (isInCapNhatPhieuDuThi) return;
            UpdateStatus("CapNhatPhieuDuThi");
            LoadControl(new CapNhatTrangThaiPhieuDuThi(this));
        }

        public void out_menu_flowLayoutPanel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogoutRequested?.Invoke();
                this.Close();
            }
        }

        public void out_menu_pictureBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogoutRequested?.Invoke();
                this.Close();
            }
        }

        public void out_menu_label_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogoutRequested?.Invoke();
                this.Close();
            }
        }
    }
}
