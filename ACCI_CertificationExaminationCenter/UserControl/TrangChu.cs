using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCI_CertificationExaminationCenter
{
    public partial class TrangChu : UserControl
    {
        private MainForm mainForm;

        public TrangChu(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;

            if (mainForm.vaiTro == "Tiếp nhận")
            {
                panelNhanVienTiepNhan.Visible = true;
                panelNhanVienKeToan.Visible = false;
                panelNhanVienNhapLieu.Visible = false;
                panelQuanLy.Visible = false;
            }
            else if (mainForm.vaiTro == "Kế toán")
            {
                panelNhanVienTiepNhan.Visible = false;
                panelNhanVienKeToan.Visible = true;
                panelNhanVienNhapLieu.Visible = false;
                panelQuanLy.Visible = false;
            }
            else if (mainForm.vaiTro == "Nhập liệu")
            {
                panelNhanVienTiepNhan.Visible = false;
                panelNhanVienKeToan.Visible = false;
                panelNhanVienNhapLieu.Visible = true;
                panelQuanLy.Visible = false;
            }
            else if (mainForm.vaiTro == "Quản lý")
            {
                panelNhanVienTiepNhan.Visible = false;
                panelNhanVienKeToan.Visible = false;
                panelNhanVienNhapLieu.Visible = false;
                panelQuanLy.Visible = true;
            }
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            lTieuDe.Location = bg_pictureBox.PointToClient(lTieuDe.PointToScreen(Point.Empty));
            lNgayThangNam.Location = bg_pictureBox.PointToClient(lNgayThangNam.PointToScreen(Point.Empty));
            lTieuDe.Parent = bg_pictureBox;
            lNgayThangNam.Parent = bg_pictureBox;
            lTieuDe.BackColor = Color.Transparent;
            lNgayThangNam.BackColor = Color.Transparent;
            lTieuDe.Text = "Xin chào, " + mainForm.tenDangNhap;
            string dayOfWeek = DateTime.Now.ToString("dddd");
            if (dayOfWeek == "Monday") dayOfWeek = "Thứ 2";
            else if (dayOfWeek == "Tuesday") dayOfWeek = "Thứ 3";
            else if (dayOfWeek == "Wednesday") dayOfWeek = "Thứ 4";
            else if (dayOfWeek == "Thursday") dayOfWeek = "Thứ 5";
            else if (dayOfWeek == "Friday") dayOfWeek = "Thứ 6";
            else if (dayOfWeek == "Saturday") dayOfWeek = "Thứ 7";
            else if (dayOfWeek == "Sunday") dayOfWeek = "Chủ nhật";
            lNgayThangNam.Text = dayOfWeek + ", " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        // Nhân viên tiếp nhận
        private void panelDangKyThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Register");
            mainForm.LoadControl(new LapPhieuDangKy(mainForm));
        }

        private void pbDangKyThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Register");
            mainForm.LoadControl(new LapPhieuDangKy(mainForm));
        }

        private void lDangKyThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Register");
            mainForm.LoadControl(new LapPhieuDangKy(mainForm));
        }

        private void panelXuatPhieuDk_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("XuatPhieuDK");
            mainForm.LoadControl(new RegisterDetailsFormControl(mainForm));
        }

        private void pbXuatPhieuDk_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("XuatPhieuDK");
            mainForm.LoadControl(new RegisterDetailsFormControl(mainForm));
        }

        private void lXuatPhieuDk_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("XuatPhieuDK");
            mainForm.LoadControl(new RegisterDetailsFormControl(mainForm));
        }

        private void panelGiaHanNgayThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("GiaHanNgayThi");
            mainForm.LoadControl(new GiaHanNgayThi(mainForm));
        }

        private void pbGiaHanNgayThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("GiaHanNgayThi");
            mainForm.LoadControl(new GiaHanNgayThi(mainForm));
        }

        private void lGiaHanNgayThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("GiaHanNgayThi");
            mainForm.LoadControl(new GiaHanNgayThi(mainForm));
        }

        private void panelCapChungChi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Certificate");
            mainForm.LoadControl(new CapNhatNhanChungChi(mainForm));
        }

        private void pbCapChungChi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Certificate");
            mainForm.LoadControl(new CapNhatNhanChungChi(mainForm));
        }

        private void lCapChungChi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("Certificate");
            mainForm.LoadControl(new CapNhatNhanChungChi(mainForm));
        }

        private void tn_panelLenLichPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("LenLichPhongThi");
            mainForm.LoadControl(new LenLichVaXepPhongThi(mainForm));
        }

        private void tn_pbLenLichPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("LenLichPhongThi");
            mainForm.LoadControl(new LenLichVaXepPhongThi(mainForm));
        }

        private void tn_lLenLichPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("LenLichPhongThi");
            mainForm.LoadControl(new LenLichVaXepPhongThi(mainForm));
        }

        private void tn_panelCapNhatPhieuDuThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        private void tn_pbCapNhatPhieuDuThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        private void tn_lCapNhatPhieuDuThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        // Nhân viên kế toán
        private void panelLapHoaDon_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("LapHoaDon");
            mainForm.LoadControl(new LapHoaDonDangKy(mainForm));
        }

        private void pbLapHoaDon_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("LapHoaDon");
            mainForm.LoadControl(new LapHoaDonDangKy(mainForm));
        }

        private void lLapHoaDon_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("LapHoaDon");
            mainForm.LoadControl(new LapHoaDonDangKy(mainForm));
        }

        private void panelThanhToanDangKy_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ThanhToanDangKy");
            mainForm.LoadControl(new ThanhToanPhieuDangKy(mainForm));
        }

        private void pbThanhToanDangKy_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ThanhToanDangKy");
            mainForm.LoadControl(new ThanhToanPhieuDangKy(mainForm));
        }

        private void lThanhToanDangKy_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ThanhToanDangKy");
            mainForm.LoadControl(new ThanhToanPhieuDangKy(mainForm));
        }

        private void panelThanhToanGiaHan_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ThanhToanGiaHan");
            mainForm.LoadControl(new ThanhToanPhieuGiaHan(mainForm));
        }

        private void pbThanhToanGiaHan_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ThanhToanGiaHan");
            mainForm.LoadControl(new ThanhToanPhieuGiaHan(mainForm));
        }

        private void lThanhToanGiaHan_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ThanhToanGiaHan");
            mainForm.LoadControl(new ThanhToanPhieuGiaHan(mainForm));
        }

        private void panelXuatHoaDon_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("XuatHoaDon");
            mainForm.LoadControl(new XuatHoaDonThanhToan(mainForm));
        }

        private void pbXuatHoaDon_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("XuatHoaDon");
            mainForm.LoadControl(new XuatHoaDonThanhToan(mainForm));
        }

        private void lXuatHoaDon_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("XuatHoaDon");
            mainForm.LoadControl(new XuatHoaDonThanhToan(mainForm));
        }

        private void kt_panelLenLichPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("LenLichPhongThi");
            mainForm.LoadControl(new LenLichVaXepPhongThi(mainForm));
        }

        private void kt_pbLenLichPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("LenLichPhongThi");
            mainForm.LoadControl(new LenLichVaXepPhongThi(mainForm));
        }

        private void kt_lLenLichPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("LenLichPhongThi");
            mainForm.LoadControl(new LenLichVaXepPhongThi(mainForm));
        }

        private void kt_panelCapNhatPhieuDuThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        private void kt_pbCapNhatPhieuDuThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        private void kt_lCapNhatPhieuDuThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        // Nhân viên nhập liệu
        private void panelNhapKetQuaThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ExamineeResults");
            mainForm.LoadControl(new NhapKetQuaThi(mainForm));
        }

        private void pbNhapKetQuaThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ExamineeResults");
            mainForm.LoadControl(new NhapKetQuaThi(mainForm));
        }

        private void lNhapKetQuaThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("ExamineeResults");
            mainForm.LoadControl(new NhapKetQuaThi(mainForm));
        }

        private void nl_panelLenLichPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        private void nl_pbLenLichPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        private void nl_lLenLichPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        private void nl_panelCapNhatPhieuDuThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        private void nl_pbCapNhatPhieuDuThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        private void nl_lCapNhatPhieuDuThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("CapNhatPhieuDuThi");
            mainForm.LoadControl(new CapNhatTrangThaiPhieuDuThi(mainForm));
        }

        // Quản lý
        private void panelQLNhanVien_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLNhanVien");
            mainForm.LoadControl(new QuanLyNhanVien(mainForm));
        }

        private void pbQLNhanVien_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLNhanVien");
            mainForm.LoadControl(new QuanLyNhanVien(mainForm));
        }

        private void lQLNhanVien_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLNhanVien");
            mainForm.LoadControl(new QuanLyNhanVien(mainForm));
        }

        private void panelQLKhachHang_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLKhachHang");
            mainForm.LoadControl(new QuanLyKhachHang(mainForm));
        }

        private void pbQLKhachHang_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLKhachHang");
            mainForm.LoadControl(new QuanLyKhachHang(mainForm));
        }

        private void lQLKhachHang_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLKhachHang");
            mainForm.LoadControl(new QuanLyKhachHang(mainForm));
        }

        private void panelQLLichThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLLichThi");
            mainForm.LoadControl(new QuanLyLichThi(mainForm));
        }

        private void pbQLLichThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLLichThi");
            mainForm.LoadControl(new QuanLyLichThi(mainForm));
        }

        private void lQLLichThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLLichThi");
            mainForm.LoadControl(new QuanLyLichThi(mainForm));
        }

        private void panelQLPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLPhongThi");
            mainForm.LoadControl(new QuanLyPhongThi(mainForm));
        }

        private void pbQLPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLPhongThi");
            mainForm.LoadControl(new QuanLyPhongThi(mainForm));
        }

        private void lQLPhongThi_Click(object sender, EventArgs e)
        {
            mainForm.UpdateStatus("QLPhongThi");
            mainForm.LoadControl(new QuanLyPhongThi(mainForm));
        }

        // Interact effects
        private void panelDangKyThi_MouseEnter(object sender, EventArgs e)
        {
            panelDangKyThi.FillColor = Color.PowderBlue;
        }

        private void panelDangKyThi_MouseLeave(object sender, EventArgs e)
        {
            panelDangKyThi.FillColor = Color.LightCyan;
        }

        private void pbDangKyThi_MouseEnter(object sender, EventArgs e)
        {
            panelDangKyThi.FillColor = Color.PowderBlue;
        }

        private void pbDangKyThi_MouseLeave(object sender, EventArgs e)
        {
            panelDangKyThi.FillColor = Color.LightCyan;
        }

        private void lDangKyThi_MouseEnter(object sender, EventArgs e)
        {
            panelDangKyThi.FillColor = Color.PowderBlue;
        }

        private void lDangKyThi_MouseLeave(object sender, EventArgs e)
        {
            panelDangKyThi.FillColor = Color.LightCyan;
        }

        private void panelXuatPhieuDk_MouseEnter(object sender, EventArgs e)
        {
            panelXuatPhieuDk.FillColor = Color.PowderBlue;
        }

        private void panelXuatPhieuDk_MouseLeave(object sender, EventArgs e)
        {
            panelXuatPhieuDk.FillColor = Color.LightCyan;
        }

        private void pbXuatPhieuDk_MouseEnter(object sender, EventArgs e)
        {
            panelXuatPhieuDk.FillColor = Color.PowderBlue;
        }

        private void pbXuatPhieuDk_MouseLeave(object sender, EventArgs e)
        {
            panelXuatPhieuDk.FillColor = Color.LightCyan;
        }

        private void lXuatPhieuDk_MouseEnter(object sender, EventArgs e)
        {
            panelXuatPhieuDk.FillColor = Color.PowderBlue;
        }

        private void lXuatPhieuDk_MouseLeave(object sender, EventArgs e)
        {
            panelXuatPhieuDk.FillColor = Color.LightCyan;
        }

        private void panelGiaHanNgayThi_MouseEnter(object sender, EventArgs e)
        {
            panelGiaHanNgayThi.FillColor = Color.PowderBlue;
        }

        private void panelGiaHanNgayThi_MouseLeave(object sender, EventArgs e)
        {
            panelGiaHanNgayThi.FillColor = Color.LightCyan;
        }

        private void pbGiaHanNgayThi_MouseEnter(object sender, EventArgs e)
        {
            panelGiaHanNgayThi.FillColor = Color.PowderBlue;
        }

        private void pbGiaHanNgayThi_MouseLeave(object sender, EventArgs e)
        {
            panelGiaHanNgayThi.FillColor = Color.LightCyan;
        }

        private void lGiaHanNgayThi_MouseEnter(object sender, EventArgs e)
        {
            panelGiaHanNgayThi.FillColor = Color.PowderBlue;
        }

        private void lGiaHanNgayThi_MouseLeave(object sender, EventArgs e)
        {
            panelGiaHanNgayThi.FillColor = Color.LightCyan;
        }

        private void panelCapChungChi_MouseEnter(object sender, EventArgs e)
        {
            panelCapChungChi.FillColor = Color.PowderBlue;
        }

        private void panelCapChungChi_MouseLeave(object sender, EventArgs e)
        {
            panelCapChungChi.FillColor = Color.LightCyan;
        }

        private void pbCapChungChi_MouseEnter(object sender, EventArgs e)
        {
            panelCapChungChi.FillColor = Color.PowderBlue;
        }

        private void pbCapChungChi_MouseLeave(object sender, EventArgs e)
        {
            panelCapChungChi.FillColor = Color.LightCyan;
        }

        private void lCapChungChi_MouseEnter(object sender, EventArgs e)
        {
            panelCapChungChi.FillColor = Color.PowderBlue;
        }

        private void lCapChungChi_MouseLeave(object sender, EventArgs e)
        {
            panelCapChungChi.FillColor = Color.LightCyan;
        }

        private void tn_panelLenLichPhongThi_MouseEnter(object sender, EventArgs e)
        {
            tn_panelLenLichPhongThi.FillColor = Color.PowderBlue;
        }

        private void tn_panelLenLichPhongThi_MouseLeave(object sender, EventArgs e)
        {
            tn_panelLenLichPhongThi.FillColor = Color.LightCyan;
        }

        private void tn_pbLenLichPhongThi_MouseEnter(object sender, EventArgs e)
        {
            tn_panelLenLichPhongThi.FillColor = Color.PowderBlue;
        }

        private void tn_pbLenLichPhongThi_MouseLeave(object sender, EventArgs e)
        {
            tn_panelLenLichPhongThi.FillColor = Color.LightCyan;
        }

        private void tn_lLenLichPhongThi_MouseEnter(object sender, EventArgs e)
        {
            tn_panelLenLichPhongThi.FillColor = Color.PowderBlue;
        }

        private void tn_lLenLichPhongThi_MouseLeave(object sender, EventArgs e)
        {
            tn_panelLenLichPhongThi.FillColor = Color.LightCyan;
        }

        private void tn_panelCapNhatPhieuDuThi_MouseEnter(object sender, EventArgs e)
        {
            tn_panelCapNhatPhieuDuThi.FillColor = Color.PowderBlue;
        }

        private void tn_panelCapNhatPhieuDuThi_MouseLeave(object sender, EventArgs e)
        {
            tn_panelCapNhatPhieuDuThi.FillColor = Color.LightCyan;
        }

        private void tn_pbCapNhatPhieuDuThi_MouseEnter(object sender, EventArgs e)
        {
            tn_panelCapNhatPhieuDuThi.FillColor = Color.PowderBlue;
        }

        private void tn_pbCapNhatPhieuDuThi_MouseLeave(object sender, EventArgs e)
        {
            tn_panelCapNhatPhieuDuThi.FillColor = Color.LightCyan;
        }

        private void tn_lCapNhatPhieuDuThi_MouseEnter(object sender, EventArgs e)
        {
            tn_panelCapNhatPhieuDuThi.FillColor = Color.PowderBlue;
        }

        private void tn_lCapNhatPhieuDuThi_MouseLeave(object sender, EventArgs e)
        {
            tn_panelCapNhatPhieuDuThi.FillColor = Color.LightCyan;
        }

        private void panelLapHoaDon_MouseEnter(object sender, EventArgs e)
        {
            panelLapHoaDon.FillColor = Color.PowderBlue;
        }

        private void panelLapHoaDon_MouseLeave(object sender, EventArgs e)
        {
            panelLapHoaDon.FillColor = Color.LightCyan;
        }

        private void pbLapHoaDon_MouseEnter(object sender, EventArgs e)
        {
            panelLapHoaDon.FillColor = Color.PowderBlue;
        }

        private void pbLapHoaDon_MouseLeave(object sender, EventArgs e)
        {
            panelLapHoaDon.FillColor = Color.LightCyan;
        }

        private void lLapHoaDon_MouseEnter(object sender, EventArgs e)
        {
            panelLapHoaDon.FillColor = Color.PowderBlue;
        }

        private void lLapHoaDon_MouseLeave(object sender, EventArgs e)
        {
            panelLapHoaDon.FillColor = Color.LightCyan;
        }

        private void panelThanhToanDangKy_MouseEnter(object sender, EventArgs e)
        {
            panelThanhToanDangKy.FillColor = Color.PowderBlue;
        }

        private void panelThanhToanDangKy_MouseLeave(object sender, EventArgs e)
        {
            panelThanhToanDangKy.FillColor = Color.LightCyan;
        }

        private void pbThanhToanDangKy_MouseEnter(object sender, EventArgs e)
        {
            panelThanhToanDangKy.FillColor = Color.PowderBlue;
        }

        private void pbThanhToanDangKy_MouseLeave(object sender, EventArgs e)
        {
            panelThanhToanDangKy.FillColor = Color.LightCyan;
        }

        private void lThanhToanDangKy_MouseEnter(object sender, EventArgs e)
        {
            panelThanhToanDangKy.FillColor = Color.PowderBlue;
        }

        private void lThanhToanDangKy_MouseLeave(object sender, EventArgs e)
        {
            panelThanhToanDangKy.FillColor = Color.LightCyan;
        }

        private void panelThanhToanGiaHan_MouseEnter(object sender, EventArgs e)
        {
            panelThanhToanGiaHan.FillColor = Color.PowderBlue;
        }

        private void panelThanhToanGiaHan_MouseLeave(object sender, EventArgs e)
        {
            panelThanhToanGiaHan.FillColor = Color.LightCyan;
        }

        private void pbThanhToanGiaHan_MouseEnter(object sender, EventArgs e)
        {
            panelThanhToanGiaHan.FillColor = Color.PowderBlue;
        }

        private void pbThanhToanGiaHan_MouseLeave(object sender, EventArgs e)
        {
            panelThanhToanGiaHan.FillColor = Color.LightCyan;
        }

        private void lThanhToanGiaHan_MouseEnter(object sender, EventArgs e)
        {
            panelThanhToanGiaHan.FillColor = Color.PowderBlue;
        }

        private void lThanhToanGiaHan_MouseLeave(object sender, EventArgs e)
        {
            panelThanhToanGiaHan.FillColor = Color.LightCyan;
        }

        private void panelXuatHoaDon_MouseEnter(object sender, EventArgs e)
        {
            panelXuatHoaDon.FillColor = Color.PowderBlue;
        }

        private void panelXuatHoaDon_MouseLeave(object sender, EventArgs e)
        {
            panelXuatHoaDon.FillColor = Color.LightCyan;
        }

        private void pbXuatHoaDon_MouseEnter(object sender, EventArgs e)
        {
            panelXuatHoaDon.FillColor = Color.PowderBlue;
        }

        private void pbXuatHoaDon_MouseLeave(object sender, EventArgs e)
        {
            panelXuatHoaDon.FillColor = Color.LightCyan;
        }

        private void lXuatHoaDon_MouseEnter(object sender, EventArgs e)
        {
            panelXuatHoaDon.FillColor = Color.PowderBlue;
        }

        private void lXuatHoaDon_MouseLeave(object sender, EventArgs e)
        {
            panelXuatHoaDon.FillColor = Color.LightCyan;
        }

        private void kt_panelLenLichPhongThi_MouseEnter(object sender, EventArgs e)
        {
            kt_panelLenLichPhongThi.FillColor = Color.PowderBlue;
        }

        private void kt_panelLenLichPhongThi_MouseLeave(object sender, EventArgs e)
        {
            kt_panelLenLichPhongThi.FillColor = Color.LightCyan;
        }

        private void kt_pbLenLichPhongThi_MouseEnter(object sender, EventArgs e)
        {
            kt_panelLenLichPhongThi.FillColor = Color.PowderBlue;
        }

        private void kt_pbLenLichPhongThi_MouseLeave(object sender, EventArgs e)
        {
            kt_panelLenLichPhongThi.FillColor = Color.LightCyan;
        }

        private void kt_lLenLichPhongThi_MouseEnter(object sender, EventArgs e)
        {
            kt_panelLenLichPhongThi.FillColor = Color.PowderBlue;
        }

        private void kt_lLenLichPhongThi_MouseLeave(object sender, EventArgs e)
        {
            kt_panelLenLichPhongThi.FillColor = Color.LightCyan;
        }

        private void kt_panelCapNhatPhieuDuThi_MouseEnter(object sender, EventArgs e)
        {
            kt_panelCapNhatPhieuDuThi.FillColor = Color.PowderBlue;
        }

        private void kt_panelCapNhatPhieuDuThi_MouseLeave(object sender, EventArgs e)
        {
            kt_panelCapNhatPhieuDuThi.FillColor = Color.LightCyan;
        }

        private void kt_pbCapNhatPhieuDuThi_MouseEnter(object sender, EventArgs e)
        {
            kt_panelCapNhatPhieuDuThi.FillColor = Color.PowderBlue;
        }

        private void kt_pbCapNhatPhieuDuThi_MouseLeave(object sender, EventArgs e)
        {
            kt_panelCapNhatPhieuDuThi.FillColor = Color.LightCyan;
        }

        private void kt_lCapNhatPhieuDuThi_MouseEnter(object sender, EventArgs e)
        {
            kt_panelCapNhatPhieuDuThi.FillColor = Color.PowderBlue;
        }

        private void kt_lCapNhatPhieuDuThi_MouseLeave(object sender, EventArgs e)
        {
            kt_panelCapNhatPhieuDuThi.FillColor = Color.LightCyan;
        }

        private void panelNhapKetQuaThi_MouseEnter(object sender, EventArgs e)
        {
            panelNhapKetQuaThi.FillColor = Color.PowderBlue;
        }

        private void panelNhapKetQuaThi_MouseLeave(object sender, EventArgs e)
        {
            panelNhapKetQuaThi.FillColor = Color.LightCyan;
        }

        private void pbNhapKetQuaThi_MouseEnter(object sender, EventArgs e)
        {
            panelNhapKetQuaThi.FillColor = Color.PowderBlue;
        }

        private void pbNhapKetQuaThi_MouseLeave(object sender, EventArgs e)
        {
            panelNhapKetQuaThi.FillColor = Color.LightCyan;
        }

        private void lNhapKetQuaThi_MouseEnter(object sender, EventArgs e)
        {
            panelNhapKetQuaThi.FillColor = Color.PowderBlue;
        }

        private void lNhapKetQuaThi_MouseLeave(object sender, EventArgs e)
        {
            panelNhapKetQuaThi.FillColor = Color.LightCyan;
        }

        private void nl_panelLenLichPhongThi_MouseEnter(object sender, EventArgs e)
        {
            nl_panelLenLichPhongThi.FillColor = Color.PowderBlue;
        }

        private void nl_panelLenLichPhongThi_MouseLeave(object sender, EventArgs e)
        {
            nl_panelLenLichPhongThi.FillColor = Color.LightCyan;
        }

        private void nl_pbLenLichPhongThi_MouseEnter(object sender, EventArgs e)
        {
            nl_panelLenLichPhongThi.FillColor = Color.PowderBlue;
        }

        private void nl_pbLenLichPhongThi_MouseLeave(object sender, EventArgs e)
        {
            nl_panelLenLichPhongThi.FillColor = Color.LightCyan;
        }

        private void nl_lLenLichPhongThi_MouseEnter(object sender, EventArgs e)
        {
            nl_panelLenLichPhongThi.FillColor = Color.PowderBlue;
        }

        private void nl_lLenLichPhongThi_MouseLeave(object sender, EventArgs e)
        {
            nl_panelLenLichPhongThi.FillColor = Color.LightCyan;
        }

        private void nl_panelCapNhatPhieuDuThi_MouseEnter(object sender, EventArgs e)
        {
            nl_panelCapNhatPhieuDuThi.FillColor = Color.PowderBlue;
        }

        private void nl_panelCapNhatPhieuDuThi_MouseLeave(object sender, EventArgs e)
        {
            nl_panelCapNhatPhieuDuThi.FillColor = Color.LightCyan;
        }

        private void nl_pbCapNhatPhieuDuThi_MouseEnter(object sender, EventArgs e)
        {
            nl_panelCapNhatPhieuDuThi.FillColor = Color.PowderBlue;
        }

        private void nl_pbCapNhatPhieuDuThi_MouseLeave(object sender, EventArgs e)
        {
            nl_panelCapNhatPhieuDuThi.FillColor = Color.LightCyan;
        }

        private void nl_lCapNhatPhieuDuThi_MouseEnter(object sender, EventArgs e)
        {
            nl_panelCapNhatPhieuDuThi.FillColor = Color.PowderBlue;
        }

        private void nl_lCapNhatPhieuDuThi_MouseLeave(object sender, EventArgs e)
        {
            nl_panelCapNhatPhieuDuThi.FillColor = Color.LightCyan;
        }

        private void panelQLNhanVien_MouseEnter(object sender, EventArgs e)
        {
            panelQLNhanVien.FillColor = Color.PowderBlue;
        }

        private void panelQLNhanVien_MouseLeave(object sender, EventArgs e)
        {
            panelQLNhanVien.FillColor = Color.LightCyan;
        }

        private void pbQLNhanVien_MouseEnter(object sender, EventArgs e)
        {
            panelQLNhanVien.FillColor = Color.PowderBlue;
        }

        private void pbQLNhanVien_MouseLeave(object sender, EventArgs e)
        {
            panelQLNhanVien.FillColor = Color.LightCyan;
        }

        private void lQLNhanVien_MouseEnter(object sender, EventArgs e)
        {
            panelQLNhanVien.FillColor = Color.PowderBlue;
        }

        private void lQLNhanVien_MouseLeave(object sender, EventArgs e)
        {
            panelQLNhanVien.FillColor = Color.LightCyan;
        }

        private void panelQLKhachHang_MouseEnter(object sender, EventArgs e)
        {
            panelQLKhachHang.FillColor = Color.PowderBlue;
        }

        private void panelQLKhachHang_MouseLeave(object sender, EventArgs e)
        {
            panelQLKhachHang.FillColor = Color.LightCyan;
        }

        private void pbQLKhachHang_MouseEnter(object sender, EventArgs e)
        {
            panelQLKhachHang.FillColor = Color.PowderBlue;
        }

        private void pbQLKhachHang_MouseLeave(object sender, EventArgs e)
        {
            panelQLKhachHang.FillColor = Color.LightCyan;
        }

        private void lQLKhachHang_MouseEnter(object sender, EventArgs e)
        {
            panelQLKhachHang.FillColor = Color.PowderBlue;
        }

        private void lQLKhachHang_MouseLeave(object sender, EventArgs e)
        {
            panelQLKhachHang.FillColor = Color.LightCyan;
        }

        private void panelQLLichThi_MouseEnter(object sender, EventArgs e)
        {
            panelQLLichThi.FillColor = Color.PowderBlue;
        }

        private void panelQLLichThi_MouseLeave(object sender, EventArgs e)
        {
            panelQLLichThi.FillColor = Color.LightCyan;
        }

        private void pbQLLichThi_MouseEnter(object sender, EventArgs e)
        {
            panelQLLichThi.FillColor = Color.PowderBlue;
        }

        private void pbQLLichThi_MouseLeave(object sender, EventArgs e)
        {
            panelQLLichThi.FillColor = Color.LightCyan;
        }

        private void lQLLichThi_MouseEnter(object sender, EventArgs e)
        {
            panelQLLichThi.FillColor = Color.PowderBlue;
        }

        private void lQLLichThi_MouseLeave(object sender, EventArgs e)
        {
            panelQLLichThi.FillColor = Color.LightCyan;
        }

        private void panelQLPhongThi_MouseEnter(object sender, EventArgs e)
        {
            panelQLPhongThi.FillColor = Color.PowderBlue;
        }

        private void panelQLPhongThi_MouseLeave(object sender, EventArgs e)
        {
            panelQLPhongThi.FillColor = Color.LightCyan;
        }

        private void pbQLPhongThi_MouseEnter(object sender, EventArgs e)
        {
            panelQLPhongThi.FillColor = Color.PowderBlue;
        }

        private void pbQLPhongThi_MouseLeave(object sender, EventArgs e)
        {
            panelQLPhongThi.FillColor = Color.LightCyan;
        }

        private void lQLPhongThi_MouseEnter(object sender, EventArgs e)
        {
            panelQLPhongThi.FillColor = Color.PowderBlue;
        }

        private void lQLPhongThi_MouseLeave(object sender, EventArgs e)
        {
            panelQLPhongThi.FillColor = Color.LightCyan;
        }
    }
}
