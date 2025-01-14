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

namespace BTL_WINFORM.Forms
{
    public partial class DangKyForm : Form
    {
        private readonly MyDbContext _context;
        public DangKyForm()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }
        private void DangKy()
        {
            string userName = txtUsername.Text.Trim();
            string userPassword = txtPassword.Text.Trim();

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsPasswordMatch())
            {
                return;
            }

            try
            {
                // Kiểm tra username đã tồn tại
                var existingUser = _context.Account.FirstOrDefault(a => a.Username == userName);
                if (existingUser != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm tài khoản mới với role mặc định là 2
                var newAccount = new Account
                {
                    Username = userName,
                    Password = userPassword,
                    Role = 2 // Mặc định là khách hàng
                };

                _context.Account.Add(newAccount);
                _context.SaveChanges();

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fLogin login = new fLogin();
                this.Hide();
                login.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng ký: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            DangKy();
            this .Close();
        }

        private bool IsPasswordMatch()
        {
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                // Hiển thị mật khẩu
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Ẩn mật khẩu
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
