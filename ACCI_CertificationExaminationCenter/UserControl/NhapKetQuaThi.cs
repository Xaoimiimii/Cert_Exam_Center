﻿using System;
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
using ACCI_CertificationExaminationCenter.BUS;

namespace ACCI_CertificationExaminationCenter
{
    public partial class NhapKetQuaThi : UserControl
    {
        private MainForm mainForm;

        public NhapKetQuaThi(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            panelKetQua.Visible = false;
            panelNhapKetQua.Visible = false;
        }

        private void btnThemKetQua_Click(object sender, EventArgs e)
        {
            panelNhapKetQua.Visible = true;
        }

        private void ExamineeResultsControl_Load(object sender, EventArgs e)
        {

        }

        private void XoaThongTin()
        {
            lbHoTen.Text = "Họ tên thí sinh";
            lbSoBaoDanh.Text = "";
            lbGioiTinh.Text = "";
            lbSoDT.Text = "";
            lbNgayThi.Text = "";
            lbGioThi.Text = "";
            lbLoai.Text = "";
            lbTrangThai.Text = "";
        }

        private void XoaKetQua()
        {
            txtDiem.Text = "";
            capChungChi_checkBox.CheckState = CheckState.Unchecked;
            txtNgayCap.Text = "";
        }

        private void HienThiTB(string ThongBao)
        {
            MessageBox.Show(ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTraCuuSBD_Click(object sender, EventArgs e)
        {
            string soBaoDanh = txtTimSBD.Text.Trim();
            if (string.IsNullOrEmpty(soBaoDanh))
            {
                XoaThongTin();
                HienThiTB("Số báo danh không được để trống! Vui lòng nhập lại!");
                return;
            }
            else if (soBaoDanh.Length != 8)
            {
                XoaThongTin();
                HienThiTB("Số báo danh phải đủ 8 kí tự!");
                return;
            }
            else if (!Regex.IsMatch(soBaoDanh, @"^[a-zA-Z0-9]+$"))
            {
                XoaThongTin();
                HienThiTB("Số báo danh không được có ký tự đặc biệt!");
                return;
            }

            DataTable dt = ChiTietLanThi_BUS.LayTTChiTietLanThi(soBaoDanh);

            if (dt.Rows.Count > 0)
            {
                panelKetQua.Visible = true;
                panelNhapKetQua.Visible = false;

                DataRow row = dt.Rows[0];

                lbHoTen.Text = row["HoTen"].ToString();
                lbSoBaoDanh.Text = row["SoBaoDanh"].ToString();
                lbGioiTinh.Text = row["GioiTinh"].ToString();
                lbSoDT.Text = row["SoDienThoai"].ToString();
                lbNgayThi.Text = Convert.ToDateTime(row["NgayThi"]).ToString("dd/MM/yyyy");
                lbGioThi.Text = TimeOnly.FromTimeSpan((TimeSpan)row["ThoiGianThi"]).ToString("HH:mm");
                lbLoai.Text = row["LoaiDanhGia"].ToString();
                lbTrangThai.Text = row["TrangThai"].ToString();
            }
            else
            {
                XoaThongTin();
                HienThiTB("Không tìm thấy thông tin cho số báo danh này!");
                return;
            }
        }

        private void btnLuuKetQua_Click(object sender, EventArgs e)
        {
            string soBaoDanh = lbSoBaoDanh.Text.Trim();
            string inputNgayCap = txtNgayCap.Text.Trim();
            string inputDiem = txtDiem.Text.Trim();

            
            if (string.IsNullOrEmpty(soBaoDanh))
            {
                HienThiTB("Số báo danh chưa được nhập!");
                return;
            }

            if (!capChungChi_checkBox.Checked && !string.IsNullOrEmpty(inputNgayCap))
            {
                HienThiTB("Ô 'Cấp chứng chỉ' chưa được tick!");
                return;
            }

            if (capChungChi_checkBox.Checked && string.IsNullOrEmpty(inputNgayCap))
            {
                HienThiTB("Chưa nhập ngày cấp chứng chỉ!");
                return;
            }

            if (!int.TryParse(inputDiem, out int diemThi))
            {
                HienThiTB("Điểm thi không hợp lệ! Vui lòng nhập số nguyên.");
                return;
            }

            if (diemThi < 0 || diemThi > 100)
            {
                HienThiTB("Điểm thi không hợp lệ! Vui lòng nhập trong khoảng 0–100.");
                return;
            }

            if (lbTrangThai.Text.Trim() != "Hoàn thành bài thi")
            {
                HienThiTB("Số báo danh này chưa hoàn thành bài thi!");
                return;
            }

            try
            {
                KetQuaThi_BUS bus = new KetQuaThi_BUS();
                string nhanVienNhap = mainForm.tenDangNhap;

                if (capChungChi_checkBox.Checked)
                {
                    if (!DateTime.TryParseExact(inputNgayCap, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime ngayNhanChungChi))
                    {
                        HienThiTB("Ngày cấp không hợp lệ! Vui lòng nhập đúng định dạng dd/MM/yyyy.");
                        return;
                    }

                    bus.ThemKetQuaThi(soBaoDanh, diemThi, ngayNhanChungChi, nhanVienNhap);
                }
                else
                {
                    bus.ThemKetQuaThi(soBaoDanh, diemThi, null, nhanVienNhap);
                }

                XoaKetQua();
                panelNhapKetQua.Visible = false;
                XoaThongTin();
                panelKetQua.Visible = false;

                HienThiTB("Thêm kết quả thi thành công!");
            }
            catch (Exception ex)
            {
                XoaKetQua();
                panelNhapKetQua.Visible = false;
                XoaThongTin();
                panelKetQua.Visible = false;
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
