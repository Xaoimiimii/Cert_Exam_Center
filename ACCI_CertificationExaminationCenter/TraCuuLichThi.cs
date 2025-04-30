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
using ACCI_CertificationExaminationCenter.BUS;

namespace ACCI_CertificationExaminationCenter
{
    public partial class TraCuuLichThi : Form
    {
        private LichThi_BUS bus = new LichThi_BUS();
        private DataTable LichThiDaChon;

        public TraCuuLichThi()
        {
            InitializeComponent();
        }

        public DataTable LayLichThiDaChon()
        {
            return LichThiDaChon;
        }

        public void TraCuuLichThiTheoNgayGioLoai()
        {
            DateOnly? ngayThi = null;
            TimeOnly? thoiGianThi = null;
            string? loaiDanhGia = null;


            string ngayNhap = txtTimNgayThi.Text.Trim();
            if (!string.IsNullOrEmpty(ngayNhap))
            {
                if (DateOnly.TryParseExact(ngayNhap, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly parsedNgayThi))
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
                if (TimeOnly.TryParse(gioNhap, out TimeOnly parsedGioThi))
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


            DataTable dtLichThi = bus.LayTTLichThi(ngayThi, thoiGianThi, loaiDanhGia);

            if (dtLichThi != null && dtLichThi.Rows.Count > 0)
            {
                dgvDSLichThi.DataSource = dtLichThi;
                dgvDSLichThi.Columns["NgayThi"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            else
            {
                MessageBox.Show("Không tìm thấy lịch thi nào phù hợp!");
            }
        }


        public void TraCuuLichThi_Load(object sender, EventArgs e)
        {
            DataTable dsLichThi = bus.LayDSLichThi();
            dgvDSLichThi.DataSource = dsLichThi;
            dgvDSLichThi.Columns["NgayThi"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        public void dgvDSLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string selectedMaLichThi = dgvDSLichThi.Rows[e.RowIndex].Cells[0].Value.ToString();
            LichThiDaChon = bus.LayTTLichThi(selectedMaLichThi);
        }

        public void btnTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuLichThiTheoNgayGioLoai();
        }

        public void btnXacNhan_Click(object sender, EventArgs e)
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

        public void btnTroVe_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void txtTimNgayThi_IconRightClick(object sender, EventArgs e)
        {
            txtTimNgayThi.Text = string.Empty;
            TraCuuLichThiTheoNgayGioLoai();
        }

        public void txtTimGioThi_IconRightClick(object sender, EventArgs e)
        {
            txtTimGioThi.Text = string.Empty;
            TraCuuLichThiTheoNgayGioLoai();
        }
    }
}
