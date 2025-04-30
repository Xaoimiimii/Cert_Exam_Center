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
    public partial class ExamineeResultsControl : UserControl
    {
        private MainForm mainForm;

        public ExamineeResultsControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            result_guna2ShadowPanel.Visible = false;
        }

        private void insert_result_button_Click(object sender, EventArgs e)
        {
            result_guna2ShadowPanel.Visible = true;
        }

        private void ExamineeResultsControl_Load(object sender, EventArgs e)
        {

        }

        private void XoaThongTin()
        {
            lbHoTen.Text = "";
            lbSoBaoDanh.Text = "";
            lbGioiTinh.Text = "";
            lbSoDT.Text = "";
            lbNgayThi.Text = "";
            lbGioThi.Text = "";
            lbLoai.Text = "";
            lbTrangThai.Text = "";
        }

        private void HienThiTB(string ThongBao)
        {
            MessageBox.Show(ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void find_sbd_button_Click(object sender, EventArgs e)
        {
            string soBaoDanh = search_sbd_guna2TextBox.Text.Trim();
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
            }


        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDiem.Text.Trim(), out int diemThi))
            {
                
            }
            else
            {
                MessageBox.Show("Điểm thi không hợp lệ! Vui lòng nhập số nguyên.");
            }

        }
    }
}
