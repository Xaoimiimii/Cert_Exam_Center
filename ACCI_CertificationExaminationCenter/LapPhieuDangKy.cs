using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public LapPhieuDangKy(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            lblMaPhieuDK.Text = phieuDK_BUS.ThemPhieuDK();
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

        private void HienThiTB(string ThongBao)
        {
            MessageBox.Show(ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ThayDoiThongTinKH(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string noiDungMoi = textBox.Text;
                lblTBTraCuuKH.Visible = false;
                lblTBThemKH.Visible = false;
                lblTBThemTS.Visible = false;
            }
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
                DataTable dt = KhachHang_BUS.LayTTKH(txtThemSDTKH.Text, txtThemEmailKH.Text);

                if (dt.Rows.Count > 0)
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
    }
}
