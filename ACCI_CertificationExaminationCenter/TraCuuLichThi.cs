using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCI_CertificationExaminationCenter
{
    public partial class TraCuuLichThi : Form
    {
        private LichThi_BUS bus = new LichThi_BUS();
        public LichThi_BUS LichThiDaChon { get; private set; }

        public TraCuuLichThi()
        {
            InitializeComponent();
        }

        private void TraCuuLichThiTheoNgayGioLoai()
        {
            DateTime? ngayThi = null;
            TimeSpan? thoiGianThi = null;
            string? loaiDanhGia = null;


            string ngayNhap = txtTimNgayThi.Text.Trim();
            if (!string.IsNullOrEmpty(ngayNhap))
            {
                if (DateTime.TryParseExact(ngayNhap, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedNgayThi))
                {
                    ngayThi = parsedNgayThi;
                }
                else
                {
                    MessageBox.Show("Ngày nhập không hợp lệ! Vui lòng nhập theo định dạng dd/MM/yyyy");
                    return;
                }
            }


            string gioNhap = txtTimGioThi.Text.Trim();
            if (!string.IsNullOrEmpty(gioNhap))
            {
                if (TimeSpan.TryParse(gioNhap, out TimeSpan parsedGioThi))
                {
                    thoiGianThi = parsedGioThi;
                }
                else
                {
                    MessageBox.Show("Giờ nhập không hợp lệ! Vui lòng nhập theo định dạng HH:mm:ss");
                    return;
                }
            }


            loaiDanhGia = cbTimLoaiDanhGia.SelectedItem?.ToString();
            if (loaiDanhGia == "Tất cả")
            {
                loaiDanhGia = null;
            }


            List<LichThi_BUS> dsLichThi = bus.LayTTLichThi(ngayThi, thoiGianThi, loaiDanhGia);


            if (dsLichThi != null && dsLichThi.Count > 0)
            {
                dgvDSLichThi.DataSource = dsLichThi;
                dgvDSLichThi.Columns["NgayThi"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            else
            {
                MessageBox.Show("Không tìm thấy lịch thi nào phù hợp!");
            }
        }


        private void TraCuuLichThi_Load(object sender, EventArgs e)
        {
            List<LichThi_BUS> dsLichThi = bus.LayDSLichThi();
            dgvDSLichThi.DataSource = dsLichThi;
            dgvDSLichThi.Columns["NgayThi"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgvDSLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string selectedMaLichThi = dgvDSLichThi.Rows[e.RowIndex].Cells[0].Value.ToString();
            LichThiDaChon = bus.LayTTLichThi(selectedMaLichThi).FirstOrDefault();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuLichThiTheoNgayGioLoai();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (LichThiDaChon != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lịch thi!");
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtTimNgayThi_IconRightClick(object sender, EventArgs e)
        {
            txtTimNgayThi.Text = string.Empty;
            TraCuuLichThiTheoNgayGioLoai();
        }

        private void txtTimGioThi_IconRightClick(object sender, EventArgs e)
        {
            txtTimGioThi.Text = string.Empty;
            TraCuuLichThiTheoNgayGioLoai();
        }
    }
}
