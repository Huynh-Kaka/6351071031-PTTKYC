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
    public partial class AdminAddAcountsForm : UserControl
    {
        private readonly MyDbContext _context;
        public AdminAddAcountsForm()
        {
            InitializeComponent();
            _context = new MyDbContext();
            txtAccountID.ReadOnly = true;
            txtAccountID.Enabled = true;
            LoadData();
        }
        private void AdminAddAcountsForm_Load(object sender, EventArgs e)
        {
            cbxRole.Items.Add("1 - Admin");
            cbxRole.Items.Add("2 - Staff");


        }
        private void LoadData()
        {
            try
            {
                var accountList = _context.Account
                    .Select(a => new
                    {
                        a.AccountID,
                        a.Username,
                        a.Password,
                        a.Role
                    }).ToList();

                dgvAccounts.DataSource = accountList;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            dgvAccounts.Columns["AccountID"].HeaderText = "ID Tài Khoản";
            dgvAccounts.Columns["Username"].HeaderText = "Tên Tài Khoản";
            dgvAccounts.Columns["Password"].HeaderText = "Mật khẩu";
            dgvAccounts.Columns["Role"].HeaderText = "Quyền";
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.DefaultCellStyle.ForeColor = Color.Black;
        }


        private void AddAccount()
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Trích xuất số (1 hoặc 2) từ chuỗi trong ComboBox
            int role = 0;
            if (cbxRole.SelectedItem != null)
            {
                var selectedRole = cbxRole.SelectedItem.ToString();
                role = int.Parse(selectedRole.Split('-')[0].Trim()); // Lấy phần số 1 hoặc 2
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || role == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var account = new Account
                {
                    Username = username,
                    Password = password,
                    Role = role
                };

                _context.Account.Add(account);
                _context.SaveChanges();

                LoadData();
                MessageBox.Show("Tài khoản đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            clearAccount();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddAccount();
        }
        private void UpdateAccount()
        {
            int accountId = int.Parse(txtAccountID.Text);
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Trích xuất số (1 hoặc 2) từ chuỗi trong ComboBox
            int role = 0;
            if (cbxRole.SelectedItem != null)
            {
                var selectedRole = cbxRole.SelectedItem.ToString();
                role = int.Parse(selectedRole.Split('-')[0].Trim()); // Lấy phần số 1 hoặc 2
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || role == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var account = _context.Account.FirstOrDefault(a => a.AccountID == accountId);
                if (account != null)
                {
                    account.Username = username;
                    account.Password = password;
                    account.Role = role;
                    _context.SaveChanges();

                    LoadData();
                    MessageBox.Show("Cập nhật tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
            clearAccount();
        }
        private void DeleteAccount()
        {
            int accountId = int.Parse(txtAccountID.Text);

            try
            {
                var account = _context.Account.FirstOrDefault(a => a.AccountID == accountId);
                if (account != null)
                {
                    _context.Account.Remove(account);
                    _context.SaveChanges();

                    LoadData();
                    MessageBox.Show("Tài khoản đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearAccount();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteAccount();
            }
            else
            {
                LoadData();
            }
        }
        private void clearAccount()
        {
            txtAccountID.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            cbxRole.SelectedIndex = -1;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAccount();


            MessageBox.Show("Đã xóa ra khỏi trường dữ liệu");
        }
        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvAccounts.Rows[e.RowIndex];
                txtAccountID.Text = row.Cells["AccountID"].Value?.ToString() ?? string.Empty;
                txtUserName.Text = row.Cells["Username"].Value?.ToString() ?? string.Empty;
                txtPassword.Text = row.Cells["Password"].Value?.ToString() ?? string.Empty;

                // Lấy giá trị role (1 hoặc 2) từ DataGridView và chọn item trong ComboBox
                int role = Convert.ToInt32(row.Cells["Role"].Value);
                if (role == 1)
                {
                    cbxRole.SelectedItem = "1 - Admin";  // Chọn "1 - Admin" nếu role = 1
                }
                else if (role == 2)
                {
                    cbxRole.SelectedItem = "2 - Staff";  // Chọn "2 - Staff" nếu role = 2
                }
                else
                {
                    cbxRole.SelectedIndex = -1;  // Không chọn gì nếu role không phải 1 hoặc 2
                }
            }
        }

    }
}
