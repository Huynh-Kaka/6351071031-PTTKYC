using BTL_WINFORM.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_WINFORM
{
    public partial class AdminVoucherForm : UserControl
    {
        private readonly MyDbContext _context;
        public AdminVoucherForm()
        {
            InitializeComponent();
            _context = new MyDbContext();
            cbxLoaiGiamGia.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uiPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào cho "Số lần tối đa sử dụng"
                if (!int.TryParse(txtSoLanToiDaSuDung.Text, out int soLanToiDaSuDung))
                {
                    MessageBox.Show("Số lần tối đa sử dụng phải là một số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng Voucher từ dữ liệu người dùng nhập
                var voucher = new Voucher
                {
                    Id = Guid.NewGuid(),
                    MaVoucher = txtMaVoucher.Text,
                    LoaiGiamGia = cbxLoaiGiamGia.SelectedItem.ToString() == "Phần trăm" ? 'P' : 'F',
                    GiaTriGiam = decimal.Parse(txtGiaTriGiam.Text),
                    NgayBatDau = dtpNgayBatDau.Value,
                    NgayHetHan = dtpNgayHetHan.Value,
                    SoLanToiDaSuDung = soLanToiDaSuDung, // Sử dụng giá trị đã kiểm tra
                    SoLanDaSuDung = 0, // Mặc định là 0
                    GiaTriDonHangToiThieu = string.IsNullOrWhiteSpace(txtGiaTriDonHangToiThieu.Text)
                                            ? (decimal?)null
                                            : decimal.Parse(txtGiaTriDonHangToiThieu.Text),
                    TrangThai = chkTrangThaiHD.Checked
                };

                if (!ValidateVoucher(voucher))
                {
                    return;
                }

                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrWhiteSpace(voucher.MaVoucher))
                {
                    MessageBox.Show("Mã Voucher không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (voucher.NgayHetHan < voucher.NgayBatDau)
                {
                    MessageBox.Show("Ngày hết hạn phải lớn hơn hoặc bằng ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lưu Voucher vào cơ sở dữ liệu
                _context.Vouchers.Add(voucher);
                _context.SaveChanges();

                MessageBox.Show("Lưu Voucher thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); // Xóa dữ liệu sau khi lưu thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearForm()
        {
            txtMaVoucher.Clear();
            txtGiaTriGiam.Clear();
            txtSoLanToiDaSuDung.Clear();
            txtGiaTriDonHangToiThieu.Clear();
            cbxLoaiGiamGia.SelectedIndex = 0;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now;
            chkTrangThaiHD.Checked = true;
        }
        private bool ValidateVoucher(Voucher voucher)
        {
            if (voucher.LoaiGiamGia == 'P')
            {
                if (voucher.GiaTriGiam < 0 || voucher.GiaTriGiam > 99 || voucher.GiaTriGiam != Math.Floor(voucher.GiaTriGiam))
                {
                    MessageBox.Show("Giá trị giảm phải là số nguyên từ 0 đến 99 khi chọn loại giảm giá là Phần trăm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (voucher.LoaiGiamGia == 'F')
            {
                if (voucher.GiaTriGiam < 0)
                {
                    MessageBox.Show("Giá trị giảm không được là số âm khi chọn loại giảm giá là Tiền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiPanel3_Click(object sender, EventArgs e)
        {

        }
    }
}
