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
    public partial class UpdateCertificateStatusControl : UserControl
    {
        private MainForm mainForm;
        private KetQuaThi_BUS bus = new KetQuaThi_BUS();
        private ChiTietKiThi_BUS bus1 = new ChiTietKiThi_BUS();

        public UpdateCertificateStatusControl(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }


        public void HienThiTB (string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void insert_result_button_Click(object sender, EventArgs e)
        {
            string sbd = search_sbd_guna2TextBox.Text.Trim();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật trạng thái nhận chứng chỉ cho SBD: " + sbd + "?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bus.CapNhatTrangThaiNhan(sbd);
                    find_sbd_button_Click(sender,e);
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

        private void find_sbd_button_Click(object sender, EventArgs e)
        {
            string sbd = search_sbd_guna2TextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(sbd))
            {
                // Nếu ô tìm kiếm rỗng, làm trống các label
                label3.Text = "Họ tên thí sinh";
                found_sbd_label.Text = "";
                found_gender_label.Text = "";
                found_sdt_label.Text = "";
                found_date_label.Text = "";
                found_type_label.Text = "";
                found_status_label.Text = "";
                return; 
            }
            try
            {
                DataTable dt = bus1.LayChiTietKiThi(sbd);

                    DataRow row = dt.Rows[0];
                    label3.Text = row["HoTen"].ToString();
                    found_sbd_label.Text = row["SoBaoDanh"].ToString();
                    found_gender_label.Text = row["GioiTinh"].ToString();
                    found_sdt_label.Text = row["SoDienThoai"].ToString();
                    found_date_label.Text = Convert.ToDateTime(row["NgayThi"]).ToString("dd/MM/yyyy");
                    found_type_label.Text = row["LoaiDanhGia"].ToString();
                    found_status_label.Text = (Convert.ToBoolean(row["DaNhanChungChi"])) ? "Đã nhận" : "Chưa nhận";
            }
            catch (Exception ex)
            {
                HienThiTB ("Lỗi: " + ex.Message);
                label3.Text = "Họ tên thí sinh";
                found_sbd_label.Text = "";
                found_gender_label.Text = "";
                found_sdt_label.Text = "";
                found_date_label.Text = "";
                found_type_label.Text = "";
                found_status_label.Text = "";
                return;
            }
        }
    }
}
