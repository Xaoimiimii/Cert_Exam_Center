using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCI_CertificationExaminationCenter
{
    public partial class LapPhieuDangKy : UserControl
    {
        private MainForm mainForm;
        private PhieuDangKy_BUS phieuDK_BUS = new PhieuDangKy_BUS("NV000001");
        private KhachHang_BUS khachHang_BUS = new KhachHang_BUS();
        private string MaKhachHang = "";
        private string DiaChiKHBD = "";
        private string TenDonViBD = "";

        public LapPhieuDangKy(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            lblMaPhieuDK.Text = phieuDK_BUS.ThemPhieuDK();
        }

        public void Reload()
        {
            Control parent = this.Parent;
            if (parent != null)
            {
                bool autoScrollEnabled = false;

                if (parent is ScrollableControl scrollable)
                {
                    autoScrollEnabled = scrollable.AutoScroll;
                }

                parent.Controls.Clear();

                LapPhieuDangKy newControl = new LapPhieuDangKy(this.mainForm);
                newControl.Dock = DockStyle.Fill; // Đảm bảo chiếm toàn bộ panel

                parent.Controls.Add(newControl);

                // Bật lại AutoScroll nếu cần
                if (parent is ScrollableControl scrollParent)
                {
                    scrollParent.AutoScroll = autoScrollEnabled;
                }
            }
            else
            {
                MessageBox.Show("Không thể reload vì không tìm thấy Parent.");
            }
        }


        private void HienThiDongTBTTKH(string ThongBao, int tabIndex, int status)
        {
            if (tabIndex == 0)
            {
                lblTBTraCuuKH.Text = ThongBao;
                lblTBTraCuuKH.Visible = true;
            }
            else if (tabIndex == 1)
            {
                lblTBThemKH.Text = ThongBao;
                lblTBThemKH.Visible = true;
                if (status == 1)
                    lblTBThemKH.ForeColor = Color.MediumSeaGreen;
                else
                    lblTBThemKH.ForeColor = Color.Red;
            }

        }

        private void HienThiDongTBTTTS(string ThongBao)
        {
            lblTBThemTS.Visible = true;
            lblTBThemTS.Text = ThongBao;
            lblTBThemTS.ForeColor = Color.Red;
        }

        private void HienThiTB(string ThongBao)
        {
            MessageBox.Show(ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ThongTinKhachHang_Load(DataTable KhachHang)
        {
            txtTraCuuHoTenKH.Text = KhachHang.Rows[0]["HoTen"].ToString();
            txtTraCuuSDTKH.Text = KhachHang.Rows[0]["SoDienThoai"].ToString();
            txtTraCuuEmailKH.Text = KhachHang.Rows[0]["Email"].ToString();
            txtTraCuuDiaChiKH.Text = KhachHang.Rows[0]["DiaChi"].ToString();
            txtTraCuuTenDonVi.Text = KhachHang.Rows[0]["TenDonVi"].ToString();
            cbbTraCuuGioiTinhKH.Text = KhachHang.Rows[0]["GioiTinh"].ToString();
        }

        private bool KiemTraThongTinKH()
        {
            string hoTen = txtThemHoTenKH.Text.Trim();
            string gioiTinh = cbbThemGioiTinhKH.Text.Trim();
            string email = txtThemEmailKH.Text.Trim();
            string sdt = txtThemSDTKH.Text.Trim();
            string diaChi = txtThemDiaChiKH.Text.Trim();
            string thongBao = "";

            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(gioiTinh) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(diaChi))
            {
                //thongBao = "Vui lòng điền đầy đủ các thông tin (trừ Tên đơn vị).";
                //HienThiTB(thongBao);
                return true;
            }

            // Họ tên không chứa số hoặc ký tự đặc biệt
            if (!Regex.IsMatch(hoTen, @"^[a-zA-ZÀ-ỹ\s]+$"))
            {
                //thongBao = "Họ tên không được chứa số hoặc ký tự đặc biệt.";
                //HienThiTB(thongBao);
                return true;
            }

            // Email đúng định dạng
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                //thongBao = "Email không đúng định dạng.";
                //HienThiTB(thongBao);
                return true;
            }

            // SĐT đúng định dạng 10 số
            if (!Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                //thongBao = "Số điện thoại phải gồm đúng 10 chữ số.";
                //HienThiTB(thongBao);
                return true;
            }

            return false; // Hợp lệ
        }

        private bool KiemTraThongTinTS()
        {
            string hoTen = txtHoTenTS.Text.Trim();
            DateTime ngaySinh = dtpNgaySinhTS.Value;
            string gioiTinh = cbbGioiTinhTS.Text.Trim();
            string email = txtEmailTS.Text.Trim();
            string sdt = txtSDTTS.Text.Trim();
            string diaChi = txtDiaChiTS.Text.Trim();
            string thongBao = "";

            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(hoTen) || ngaySinh == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(gioiTinh) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(diaChi))
            {
                //thongBao = "Vui lòng điền đầy đủ các thông tin (trừ Tên đơn vị).";
                //HienThiTB(thongBao);
                return true;
            }

            // Họ tên không chứa số hoặc ký tự đặc biệt
            if (!Regex.IsMatch(hoTen, @"^[a-zA-ZÀ-ỹ\s]+$"))
            {
                //thongBao = "Họ tên không được chứa số hoặc ký tự đặc biệt.";
                //HienThiTB(thongBao);
                return true;
            }

            // Email đúng định dạng
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                //thongBao = "Email không đúng định dạng.";
                //HienThiTB(thongBao);
                return true;
            }

            // SĐT đúng định dạng 10 số
            if (!Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                //thongBao = "Số điện thoại phải gồm đúng 10 chữ số.";
                //HienThiTB(thongBao);
                return true;
            }

            return false; // Hợp lệ
        }

        private void btnTraCuuKH_Click(object sender, EventArgs e)
        {
            string sdt = txtTimSDTKH.Text.Trim();
            string email = txtTimEmailKH.Text.Trim();
            bool FormatError = false;
            string ThongBao = "";

            MaKhachHang = "";
            txtTraCuuHoTenKH.Text = "";
            txtTraCuuSDTKH.Text = "";
            txtTraCuuEmailKH.Text = "";
            txtTraCuuDiaChiKH.Text = "";
            txtTraCuuTenDonVi.Text = "";
            cbbTraCuuGioiTinhKH.Text = "";
            DiaChiKHBD = "";
            TenDonViBD = "";

            lblTBTraCuuKH.Visible = false;

            if (string.IsNullOrWhiteSpace(sdt) && string.IsNullOrWhiteSpace(email))
            {
                ThongBao = "Vui lòng nhập ít nhất một trong hai: SĐT hoặc Email.";
                FormatError = true;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(sdt) && !Regex.IsMatch(sdt, @"^\d{10}$"))
                {
                    ThongBao = "Số điện thoại không đúng định dạng (10 chữ số).";
                    FormatError = true;
                }
                else if (!string.IsNullOrWhiteSpace(email) && !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    ThongBao = "Email không đúng định dạng.";
                    FormatError = true;
                }
            }

            if (FormatError)
            {
                HienThiDongTBTTKH(ThongBao, tctThongTinKH.SelectedIndex, 0);
            }
            else
            {
                DataTable dt = KhachHang_BUS.LayTTKH(txtTimSDTKH.Text, txtTimEmailKH.Text);

                if (dt.Rows.Count > 0)
                {
                    MaKhachHang = dt.Rows[0]["MaKhachHang"].ToString();
                    ThongTinKhachHang_Load(dt);
                    DiaChiKHBD = dt.Rows[0]["DiaChi"].ToString();
                    TenDonViBD = dt.Rows[0]["TenDonVi"].ToString();
                }
                else
                {
                    HienThiTB("Không tìm thấy thông tin khách hàng");
                }
            }
            return;
        }

        private void btnKiemTraKH_Click(object sender, EventArgs e)
        {
            bool FormatError = KiemTraThongTinKH();
            string ThongBao = "";

            if (FormatError)
            {
                ThongBao = "Thông tin chưa đúng định dạng.";
                HienThiDongTBTTKH(ThongBao, tctThongTinKH.SelectedIndex, 0);
            }
            else
            {
                DataTable dt1 = KhachHang_BUS.LayTTKH(txtThemSDTKH.Text, "");
                DataTable dt2 = KhachHang_BUS.LayTTKH("", txtThemEmailKH.Text);

                if (dt1.Rows.Count > 0 || dt2.Rows.Count > 0)
                {
                    ThongBao = "Thông tin số điện thoại/email đã bị trùng.";
                    HienThiTB(ThongBao);
                }
                else
                {
                    ThongBao = "Thông tin hợp lệ!";
                    HienThiDongTBTTKH(ThongBao, tctThongTinKH.SelectedIndex, 1);
                }
            }
            return;
        }

        private void btnTraCuuLichThi_Click(object sender, EventArgs e)
        {
            txtMaLichThi.Text = "";
            TraCuuLichThi form = new TraCuuLichThi();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LichThi_BUS lichThi = form.LichThiDaChon;
                txtMaLichThi.Text = lichThi.MaLichThi;
                txtNgayThi.Text = lichThi.NgayThi.ToString("dd/MM/yyyy");
                txtThoiGianThi.Text = lichThi.ThoiGianThi.ToString(@"hh\:mm");
                txtLoaiDGNL.Text = lichThi.LoaiDanhGia;
            }
        }

        private void btnThemTS_Click(object sender, EventArgs e)
        {
            lblTBThemTS.Visible = false;
            bool FormatError = KiemTraThongTinTS();
            string ThongBao = "";

            if (FormatError)
            {
                ThongBao = "Thông tin chưa đúng định dạng.";
                HienThiDongTBTTTS(ThongBao);
            }
            else
            {
                if (ThiSinh_BUS.KTraEmailThiSinh(lblMaPhieuDK.Text, txtEmailTS.Text) == true)
                {
                    ThongBao = "Thông tin email đã bị trùng.";
                    HienThiTB(ThongBao);
                }
                else
                {
                    ThiSinh_BUS ThiSinh = new ThiSinh_BUS(lblMaPhieuDK.Text, txtHoTenTS.Text, cbbGioiTinhTS.Text, txtSDTTS.Text, txtEmailTS.Text, txtDiaChiTS.Text, dtpNgaySinhTS.Value.Date);
                    ThiSinh.ThemThiSinh();
                    DataTable dt = ThiSinh_BUS.LayDSThiSinhDK(lblMaPhieuDK.Text);
                    dgvThiSinh.AutoGenerateColumns = false;
                    dgvThiSinh.DataSource = dt;
                }
            }
            return;
        }

        private void btnXoaTS_Click(object sender, EventArgs e)
        {
            if (dgvThiSinh.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvThiSinh.SelectedRows[0];

                string email = selectedRow.Cells["Email"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Bạn có muốn xóa thí sinh này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    ThiSinh_BUS.XoaThiSinh(lblMaPhieuDK.Text, email);
                    DataTable dt = ThiSinh_BUS.LayDSThiSinhDK(lblMaPhieuDK.Text);
                    dgvThiSinh.AutoGenerateColumns = false;
                    dgvThiSinh.DataSource = dt;
                }
            }
        }

        private void btnTaoPDK_Click(object sender, EventArgs e)
        {
            if (dgvThiSinh.Rows.Count > 0 && txtMaLichThi.Text != "")
            {
               if (tctThongTinKH.SelectedIndex == 0)
                {
                    if (MaKhachHang != "")
                    {
                        if (DiaChiKHBD != txtTraCuuDiaChiKH.Text || TenDonViBD != txtTraCuuTenDonVi.Text)
                        {
                            KhachHang_BUS.CapNhatTTKH(MaKhachHang, txtTraCuuDiaChiKH.Text, txtTraCuuTenDonVi.Text);
                        }

                        string ketQua = PhieuDangKy_BUS.DangKyLichThi(lblMaPhieuDK.Text, txtMaLichThi.Text);
                        if (ketQua == "OK")
                        {
                            PhieuDangKy_BUS.CapNhatMaKH(lblMaPhieuDK.Text, MaKhachHang);
                            HienThiTB("Đăng ký thành công");
                            Reload();
                        }
                        else
                            HienThiTB(ketQua);
                    }
                    else
                        HienThiTB("Thông tin khách hàng không được để trống.");
                }
                else if (tctThongTinKH.SelectedIndex > 0)
                {
                    bool FormatError = KiemTraThongTinKH();
                    string ThongBao = "";

                    if (FormatError)
                    {
                        ThongBao = "Thông tin chưa đúng định dạng.";
                        HienThiDongTBTTKH(ThongBao, tctThongTinKH.SelectedIndex, 0);
                    }
                    else
                    {
                        // Kiểm tra trùng email và số điện thoại
                        DataTable dt1 = KhachHang_BUS.LayTTKH(txtThemSDTKH.Text, "");
                        DataTable dt2 = KhachHang_BUS.LayTTKH("", txtThemEmailKH.Text);

                        HienThiTB(dt2.Rows.Count.ToString());

                        if (dt1.Rows.Count > 0 || dt2.Rows.Count > 0)
                        {
                            ThongBao = "Thông tin số điện thoại/email đã bị trùng.";
                            HienThiTB(ThongBao);
                        }
                        else
                        {
                            ThongBao = "Thông tin hợp lệ!";
                            HienThiDongTBTTKH(ThongBao, tctThongTinKH.SelectedIndex, 1);

                            string ketQua = PhieuDangKy_BUS.DangKyLichThi(lblMaPhieuDK.Text, txtMaLichThi.Text);
                            if (ketQua == "OK")
                            {
                                KhachHang_BUS khachHang = new KhachHang_BUS(txtThemHoTenKH.Text, cbbThemGioiTinhKH.Text, txtThemSDTKH.Text, txtThemEmailKH.Text, txtThemDiaChiKH.Text, txtThemDonVi.Text);
                                MaKhachHang = khachHang.ThemKH();
                                PhieuDangKy_BUS.CapNhatMaKH(lblMaPhieuDK.Text, MaKhachHang);
                                HienThiTB("Đăng ký thành công");
                                Reload();
                            }
                            else
                            {
                                HienThiTB(ketQua);
                            }
                        }
                    }
                }
            }
            else
            {
                string ThongBao = "Hãy thêm thí sinh/chọn lịch thi trước.";
                HienThiTB(ThongBao);
            }
        }
    }
}
