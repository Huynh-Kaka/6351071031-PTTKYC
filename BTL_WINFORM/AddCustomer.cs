using BTL_WINFORM.Forms;
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
    public partial class AddCustomer : UserControl
    {
        private readonly MyDbContext _context;
        public AddCustomer()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }



        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBanForm menuBanForm = new MenuBanForm();
            menuBanForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường dữ liệu có hợp lệ không
                if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtPhone.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng Customer mới
                var newCustomer = new Customer
                {
                    FullName = txtFullName.Text,
                    Phone = txtPhone.Text,
                    // Thêm các thông tin khác nếu có
                };

                // Thêm khách hàng vào cơ sở dữ liệu
                _context.Customers.Add(newCustomer);
                _context.SaveChanges();

                // Hiển thị thông báo thành công
                MessageBox.Show("Khách hàng đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi lưu thành công, bạn có thể làm gì đó như đóng form hoặc reset các trường nhập liệu
                //ResetForm(); // Nếu muốn reset các trường
                MenuBanForm menuBanForm = new MenuBanForm();
                menuBanForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm ResetForm để làm trống các trường nhập liệu
        //private void ResetForm()
        //{
        //    txtFullName.Clear();
        //    txtPhone.Clear();
        //    // Thêm các trường khác nếu cần
        //}

    }
}
