using BTL_WINFORM.Forms;
using BTL_WINFORM.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;



namespace BTL_WINFORM
{
    public partial class ConfirmInvoice : Form
    {
        private readonly MyDbContext _context;

        public int OrderIDInvoice { get; set; }

        //public string TotalPriceInVoice {  get; set; }
        public DateTime OrderDateInvoice { get; set; }




        public ConfirmInvoice()
        {
            InitializeComponent();
            _context = new MyDbContext();
            cbxPaymentMethod.Items.Add("Chuyển Khoản");
            cbxPaymentMethod.Items.Add("Tiền Mặt");


            // Thiết lập giá trị mặc định và kích hoạt sự kiện
            cbxPaymentMethod.SelectedIndex = 1;
            this.FormClosing += new FormClosingEventHandler(ConfirmInvoice_FormClosing);
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Xóa dữ liệu của các biến khi đóng form
          
            OrderIDInvoice =0;

            // Thông báo có thể hiển thị nếu cần
          
        }

        private void ConfirmInvoice_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            // Lấy OrderID từ biến OrderIDInvoice
            int id = OrderIDInvoice;
            txtOrderID.Text = id.ToString();

            // Tìm đơn hàng dựa trên OrderID
            var order = _context.Orders
                                .FirstOrDefault(o => o.OrderID == id);  // Điều chỉnh điều kiện tìm kiếm nếu cần

            if (order != null)
            {
                // Lấy ngày hóa đơn từ OrderDate
                DateTime orderDate = order.OrderDate;
                //txtInvoiceDate.Text = orderDate.ToString("dd/MM/yyyy HH:mm:ss");

                // Tính tổng tiền từ chi tiết đơn hàng
                decimal totalAmount = _context.OrderDetails
                                      .Where(od => od.OrderID == id)  // Lọc theo OrderID
                                      .Join(_context.Products,  // JOIN với bảng Product
                                            od => od.ProductID,   // Khóa ngoại trong OrderDetails
                                            p => p.ProductID,     // Khóa chính trong Product
                                            (od, p) => od.Quantity * p.Price)  // Nhân số lượng với giá
                                      .Sum(); // Tính tổng tiền // Tính tổng tiền (Số lượng * Giá)

                // Gán giá trị tổng tiền vào txtTotalAmount với định dạng tiền tệ
                txtTotalAmount.Text = totalAmount.ToString("C", new CultureInfo("vi-VN"));
            }
            else
            {
                MessageBox.Show("Không tìm thấy đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cbxPaymentMethodd_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra phương thức thanh toán
            if (cbxPaymentMethod.SelectedIndex == 1) // 1: Tiền Mặt
            {
                // Hiển thị các TextBox cho Tiền Khách và Tiền Thừa
                txtTienKhach.Visible = true;
                txtTienThua.Visible = true;

                // Đặt mặc định giá trị cho Tiền Khách
                txtTienKhach.Text = "0";
                txtTienThua.Text = "0";
            }
            else if (cbxPaymentMethod.SelectedIndex == 0) // 0: Chuyển Khoản
            {
                // Ẩn các TextBox cho Tiền Khách và Tiền Thừa
                txtTienKhach.Visible = false;
                txtTienThua.Visible = false;

                // Xóa giá trị khi không sử dụng
                txtTienKhach.Text = "";
                txtTienThua.Text = "";
            }
        }


        private void txtTienKhach_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTienKhach.Text, out decimal tienKhach) && decimal.TryParse(txtTotalAmount.Text, NumberStyles.Currency, new CultureInfo("vi-VN"), out decimal tongTien))
            {
                // Tính tiền thừa
                decimal tienThua = tienKhach - tongTien;

                // Hiển thị tiền thừa
                txtTienThua.Text = tienThua.ToString("C", new CultureInfo("vi-VN"));
            }
            else
            {
                txtTienThua.Text = "0"; // Đặt mặc định nếu không hợp lệ
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        private void ConfirmInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reset giá trị của các biến
            OrderIDInvoice = 0; // hoặc đặt lại thành giá trị mặc định
            OrderDateInvoice = default(DateTime); // Hoặc có thể dùng DateTime.MinValue nếu muốn
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmInvoicehihi(); // Gọi hàm xử lý xác nhận hóa đơn
        }
        //private decimal ApplyVoucher(string voucherCode, decimal totalAmount)
        //{
        //    // Lấy voucher từ cơ sở dữ liệu
        //    var voucher = _context.Vouchers
        //                    .FirstOrDefault(v => v.MaVoucher == voucherCode
        //                    && v.TrangThai == true
        //                    && v.NgayBatDau <= DateTime.Now
        //                    && v.NgayHetHan >= DateTime.Now
        //                    && v.GiaTriDonHangToiThieu <= totalAmount
        //                    && v.LoaiGiamGia == 'P');  // So sánh đúng kiểu char

        //    if (voucher != null)
        //    {
        //        // Kiểm tra giá trị đơn hàng tối thiểu
        //        if (voucher.GiaTriDonHangToiThieu > 0 && totalAmount < voucher.GiaTriDonHangToiThieu)
        //        {
        //            MessageBox.Show("Giá trị đơn hàng không đủ để áp dụng voucher.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return totalAmount;
        //        }

        //        // Kiểm tra số lần sử dụng của voucher
        //        if (voucher.SoLanDaSuDung >= voucher.SoLanToiDaSuDung)
        //        {
        //            MessageBox.Show("Voucher đã hết lượt sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return totalAmount;
        //        }

        //        // Tính giảm giá
        //        decimal discountAmount = 0;
        //        if (voucher.LoaiGiamGia == 'P') // Giảm theo phần trăm
        //        {
        //            discountAmount = (voucher.GiaTriGiam / 100) * totalAmount;
        //        }
        //        else if (voucher.LoaiGiamGia == 'F') // Giảm theo số tiền cố định
        //        {
        //            discountAmount = voucher.GiaTriGiam;
        //        }

        //        // Tính tổng tiền sau khi giảm
        //        decimal finalAmount = totalAmount - discountAmount;

        //        // Cập nhật số lần sử dụng của voucher
        //        voucher.SoLanDaSuDung++;
        //        _context.SaveChanges();

        //        MessageBox.Show($"Giảm giá thành công. Tổng tiền sau khi giảm: {finalAmount.ToString("C", new CultureInfo("vi-VN"))}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return finalAmount;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Voucher không hợp lệ hoặc không còn hiệu lực.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return totalAmount; // Trả về tổng tiền không giảm giá
        //    }
        //}

        //private void ConfirmInvoicehihi()
        //{
        //    try
        //    {
        //        // Lấy OrderID từ form ConfirmInvoice
        //        int orderIDs = OrderIDInvoice; // OrderID đã được truyền từ form trước

        //        // Tìm đơn hàng dựa trên OrderID
        //        var order = _context.Orders.FirstOrDefault(o => o.OrderID == orderIDs);
        //        if (order == null)
        //        {
        //            MessageBox.Show("Không tìm thấy đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Tính tổng tiền của hóa đơn từ OrderDetails
        //        decimal totalAmount = _context.OrderDetails
        //                        .Where(od => od.OrderID == orderIDs)  // Lọc theo OrderID
        //                        .Join(_context.Products,  // JOIN với bảng Product
        //                              od => od.ProductID,   // Khóa ngoại trong OrderDetails
        //                              p => p.ProductID,     // Khóa chính trong Product
        //                              (od, p) => od.Quantity * p.Price)  // Nhân số lượng với giá
        //                        .Sum();

        //        // Lấy mã voucher từ txtVoucher
        //        string voucherCode = txtVoucher.Text.Trim();
        //        decimal finalAmount = ApplyVoucher(voucherCode, totalAmount); // Gọi hàm xử lý voucher

        //        // Tạo một đối tượng hóa đơn (Invoice)
        //        var invoice = new Invoice
        //        {
        //            OrderID = order.OrderID,
        //            InvoiceDate = DateTime.Now,
        //            PaymentMethod = cbxPaymentMethod.SelectedIndex == 1 ? true : false, // true: Tiền mặt, false: Chuyển khoản
        //                                                                                // 1: Tiền mặt, 0: Chuyển khoản
        //            TotalAmount = finalAmount
        //        };

        //        // Lưu hóa đơn vào bảng Invoices
        //        _context.Invoices.Add(invoice);
        //        _context.SaveChanges(); // Lưu hóa đơn vào cơ sở dữ liệu

        //        // Lưu chi tiết hóa đơn (InvoiceDetails) từ OrderDetails
        //        var orderDetails = _context.OrderDetails.Where(od => od.OrderID == orderIDs).ToList();
        //        foreach (var od in orderDetails)
        //        {
        //            // Lấy giá của sản phẩm từ bảng Products
        //            var productPrice = _context.Products
        //                .Where(p => p.ProductID == od.ProductID)
        //                .Select(p => p.Price)
        //                .FirstOrDefault();

        //            // Tạo hóa đơn chi tiết
        //            var invoiceDetail = new InvoiceDetail
        //            {
        //                InvoiceID = invoice.InvoiceID,
        //                ProductID = od.ProductID,
        //                Quantity = od.Quantity,
        //                UnitPrice = productPrice // Lưu giá từ bảng Products
        //            };

        //            _context.InvoiceDetails.Add(invoiceDetail);
        //        }

        //        // Lưu thay đổi vào cơ sở dữ liệu
        //        _context.SaveChanges(); // Lưu chi tiết hóa đơn

        //        // Xóa các chi tiết đơn hàng sau khi tạo hóa đơn thành công
        //        var orderDetailsToRemove = _context.OrderDetails.Where(od => od.OrderID == orderIDs).ToList();
        //        _context.OrderDetails.RemoveRange(orderDetailsToRemove); // Xóa tất cả chi tiết đơn hàng
        //        _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

        //        MessageBox.Show("Hóa đơn đã được xác nhận và lưu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        // Cập nhật trạng thái bàn sau khi thanh toán (Bàn trống lại)
        //        var table = _context.Tables.FirstOrDefault(t => t.TableID == order.TableID);
        //        if (table != null)
        //        {
        //            table.Status = true; // Bàn trở thành trống
        //            _context.SaveChanges();
        //        }

        //        // Đóng form sau khi hoàn thành
        //        MenuBanForm menuBanForm = new MenuBanForm();
        //        menuBanForm.ShowDialog();
        //        Application.Exit();

        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void ConfirmInvoicehihi()
        {
            try
            {
                int orderIDs = OrderIDInvoice;

                var order = _context.Orders.FirstOrDefault(o => o.OrderID == orderIDs);
                if (order == null)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalAmount = _context.OrderDetails
                                .Where(od => od.OrderID == orderIDs)
                                .Join(_context.Products, od => od.ProductID, p => p.ProductID, (od, p) => od.Quantity * p.Price)
                                .Sum();

                string voucherCode = txtVoucher.Text.Trim();
                decimal finalAmount = ApplyVoucher(voucherCode, totalAmount);

                var invoice = new Invoice
                {
                    OrderID = order.OrderID,
                    InvoiceDate = DateTime.Now,
                    PaymentMethod = cbxPaymentMethod.SelectedIndex == 1 ? true : false,
                    TotalAmount = finalAmount
                };

                _context.Invoices.Add(invoice);
                _context.SaveChanges();

                var orderDetails = _context.OrderDetails.Where(od => od.OrderID == orderIDs).ToList();
                var invoiceDetailsList = new List<InvoiceDetail>();  // List to store invoice details

                foreach (var od in orderDetails)
                {
                    var productPrice = _context.Products
                        .Where(p => p.ProductID == od.ProductID)
                        .Select(p => p.Price)
                        .FirstOrDefault();

                    var invoiceDetail = new InvoiceDetail
                    {
                        InvoiceID = invoice.InvoiceID,
                        ProductID = od.ProductID,
                        Quantity = od.Quantity,
                        UnitPrice = productPrice
                    };

                    invoiceDetailsList.Add(invoiceDetail);  // Add to list
                    _context.InvoiceDetails.Add(invoiceDetail);
                }

                _context.SaveChanges();

                var orderDetailsToRemove = _context.OrderDetails.Where(od => od.OrderID == orderIDs).ToList();
                _context.OrderDetails.RemoveRange(orderDetailsToRemove);
                _context.SaveChanges();

                MessageBox.Show("Hóa đơn đã được xác nhận và lưu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var table = _context.Tables.FirstOrDefault(t => t.TableID == order.TableID);
                if (table != null)
                {
                    table.Status = true;
                    _context.SaveChanges();
                }

                // Lưu hóa đơn vào tệp, passing the invoiceDetailsList to GenerateInvoiceContent
                string content = GenerateInvoiceContent(invoice, invoiceDetailsList);
                SaveFileWithTimestamp(content);
                
            

                MenuBanForm menuBanForm = new MenuBanForm();
                menuBanForm.ShowDialog();
                Application.Exit();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private decimal ApplyVoucher(string voucherCode, decimal totalAmount)
        {
            var voucher = _context.Vouchers
                            .FirstOrDefault(v => v.MaVoucher == voucherCode
                            && v.TrangThai == true
                            && v.NgayBatDau <= DateTime.Now
                            && v.NgayHetHan >= DateTime.Now
                            && v.GiaTriDonHangToiThieu <= totalAmount
                            && v.LoaiGiamGia == 'P');

            if (voucher != null)
            {
                if (voucher.GiaTriDonHangToiThieu > 0 && totalAmount < voucher.GiaTriDonHangToiThieu)
                {
                    MessageBox.Show("Giá trị đơn hàng không đủ để áp dụng voucher.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return totalAmount;
                }

                if (voucher.SoLanDaSuDung >= voucher.SoLanToiDaSuDung)
                {
                    MessageBox.Show("Voucher đã hết lượt sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return totalAmount;
                }

                decimal discountAmount = 0;
                if (voucher.LoaiGiamGia == 'P')
                {
                    discountAmount = (voucher.GiaTriGiam / 100) * totalAmount;
                }
                else if (voucher.LoaiGiamGia == 'F')
                {
                    discountAmount = voucher.GiaTriGiam;
                }

                decimal finalAmount = totalAmount - discountAmount;
                voucher.SoLanDaSuDung++;
                _context.SaveChanges();

                MessageBox.Show($"Giảm giá thành công. Tổng tiền sau khi giảm: {finalAmount.ToString("C", new CultureInfo("vi-VN"))}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return finalAmount;
            }
            else
            {
                MessageBox.Show("Voucher không hợp lệ hoặc không còn hiệu lực.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return totalAmount;
            }
        }

        public string GenerateInvoiceContent(Invoice invoice, List<InvoiceDetail> invoiceDetails)
        {
            // Generate the content for the invoice, iterating through the list of InvoiceDetails
            StringBuilder content = new StringBuilder();
            content.AppendLine($"Invoice ID: {invoice.InvoiceID}");
            content.AppendLine($"Order ID: {invoice.OrderID}");
            content.AppendLine($"Invoice Date: {invoice.InvoiceDate}");
            content.AppendLine($"Payment Method: {(invoice.PaymentMethod ? "Cash" : "Bank Transfer")}");
            content.AppendLine($"Total Amount: {invoice.TotalAmount:C}");

            content.AppendLine("Items:");
            foreach (var detail in invoiceDetails)
            {
                content.AppendLine($"Product: {detail.ProductID}, Quantity: {detail.Quantity}, Unit Price: {detail.UnitPrice:C}, Total Price: {detail.TotalPrice:C}");
            }

            return content.ToString();
        }


        private void SaveFileWithTimestamp(string content)
        {
            try
            {
                string folderPath = @"D:\Invoices"; // Đường dẫn thư mục chứa hóa đơn
                Directory.CreateDirectory(folderPath); // Tạo thư mục nếu chưa có
                string fileName = "invoice.txt"; // Tên tệp mặc định
                string filePath = Path.Combine(folderPath, fileName);

                if (File.Exists(filePath))
                {
                    // Thêm ngày giờ vào tên tệp nếu đã tồn tại
                    string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                    string extension = Path.GetExtension(fileName);
                    filePath = Path.Combine(folderPath, $"{fileNameWithoutExtension}_{timestamp}{extension}");
                }

                // Lưu nội dung vào tệp
                File.WriteAllText(filePath, content);

                MessageBox.Show($"Tệp hóa đơn đã được lưu thành công tại: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi lưu tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

    

   
    }
}
