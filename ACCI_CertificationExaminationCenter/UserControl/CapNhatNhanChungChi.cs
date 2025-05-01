using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACCI_CertificationExaminationCenter.BUS;

namespace ACCI_CertificationExaminationCenter
{
    public partial class CapNhatNhanChungChi : UserControl
    {
        private MainForm mainForm;
        private PhieuDuThi_BUS bus = new PhieuDuThi_BUS();

        public CapNhatNhanChungChi(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            panelKetQua.Visible = false;
            btnCapNhat.Visible = false;
        }


        public void HienThiTB(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string sbd = txtTimSBD.Text.Trim();
            string nhanVienCapNhat = mainForm.tenDangNhap;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật trạng thái nhận chứng chỉ cho SBD: " + sbd + "?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bus.CapNhatTrangThai(sbd, "Đã nhận bằng", nhanVienCapNhat);
                    btnTraCuuSBD_Click(sender, e);
                    HienThiTB("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    HienThiTB("Lỗi: " + ex.Message);
                }
            }
            else
            {
                HienThiTB("Cập nhật bị hủy bỏ.");
            }
        }

        private void btnTraCuuSBD_Click(object sender, EventArgs e)
        {
            string sbd = txtTimSBD.Text.Trim();
            if (string.IsNullOrWhiteSpace(sbd))
            {
                // Nếu ô tìm kiếm rỗng, làm trống các label
                XoaThongTin();
                panelKetQua.Visible = false;
                btnCapNhat.Visible = false;
                return;
            }
            try
            {
                panelKetQua.Visible = false;
                btnCapNhat.Visible = false;
                DataTable dt = ChiTietLanThi_BUS.LayTTChiTietLanThi(sbd);

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

                    panelKetQua.Visible = true;
                    btnCapNhat.Visible = true;
                }
                else
                {
                    HienThiTB("Không tìm thấy thông tin cho số báo danh này!");
                    return;
                }

            }
            catch (Exception ex)
            {
                HienThiTB("Lỗi: " + ex.Message);
                XoaThongTin();
                panelKetQua.Visible = false;
                btnCapNhat.Visible = false;
                return;
            }
        }
    }
}