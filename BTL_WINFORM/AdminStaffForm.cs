using BTL_WINFORM.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_WINFORM
{
    public partial class AdminStaffForm : UserControl
    {
        private readonly MyDbContext _context;
        public string UsernameStaff { get; set; }
        public AdminStaffForm()
        {
            InitializeComponent();
            _context = new MyDbContext();
            txtIDStaff.ReadOnly = true;
            txtIDStaff.Enabled = false;
            LoadData();
        }
        private void AdminStaffForm_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            LoadAccountData();
            cmbAccount.Visible = false;
            lblAccountID.Visible = false;
        }
        private void FormatDataGridView()
        {
            dgvDataStaff.Columns["EmployeeID"].HeaderText = "ID Nhân Viên";
            dgvDataStaff.Columns["FullName"].HeaderText = "Họ và Tên";
            dgvDataStaff.Columns["Username"].HeaderText = "Tài Khoản";
            dgvDataStaff.Columns["Role"].HeaderText = "Vai Trò";
            dgvDataStaff.Columns["Position"].HeaderText = "Chức Vụ";
            dgvDataStaff.Columns["DateOfJoining"].HeaderText = "Ngày Vào Làm";
            dgvDataStaff.Columns["Status"].HeaderText = "Trạng Thái";
            dgvDataStaff.Columns["Salary"].HeaderText = "Lương";

            dgvDataStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataStaff.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void LoadData()
        {
            try
            {
                var staffList = (from emp in _context.Employees
                                 join acc in _context.Account
                                 on emp.AccountID equals acc.AccountID
                                 select new
                                 {
                                     emp.EmployeeID,
                                     emp.FullName,
                                     acc.Username,
                                     acc.Role,
                                     emp.Position,
                                     emp.DateOfJoining,
                                     emp.Status,
                                     emp.Salary
                                 }).ToList();

                dgvDataStaff.DataSource = staffList;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }




        private void addStaff()
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string fullName = txtFullName.Text;
                string username = fullName; // Tên đăng nhập là tên của nhân viên
                string position = txtPosition.Text;
                DateTime dateOfJoining = dtpDateOfJoining.Value; // Giả sử có DateTimePicker
                string status = cmbStatus.SelectedItem?.ToString(); // Giả sử có combobox chọn trạng thái
                string salaryText = txtSalary.Text; // Lấy lương từ TextBox

                // Kiểm tra nếu bất kỳ trường nào còn trống
                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(position) ||
                    string.IsNullOrEmpty(status) || string.IsNullOrEmpty(salaryText))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Kiểm tra nếu giá trị lương hợp lệ
                if (!decimal.TryParse(salaryText, out decimal salary) || salary <= 0)
                {
                    MessageBox.Show("Lương không hợp lệ!");
                    return;
                }

                // Kiểm tra nếu username đã tồn tại trong hệ thống
                var existingAccount = _context.Account.FirstOrDefault(acc => acc.Username == username);
                if (existingAccount != null)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                    return;
                }

                // Tạo tài khoản mới cho nhân viên
                var newAccount = new Account
                {
                    Username = username,
                    Password = "123", // Mật khẩu mặc định là 123
                    Role = 2
                };

                // Lưu tài khoản vào cơ sở dữ liệu
                _context.Account.Add(newAccount);
                _context.SaveChanges(); // Lưu tài khoản vào cơ sở dữ liệu trước khi thêm nhân viên

                // Tạo đối tượng nhân viên mới
                var newEmployee = new Employee
                {
                    FullName = fullName,
                    AccountID = newAccount.AccountID, // Lưu AccountID vào nhân viên
                    Position = position,
                    DateOfJoining = dateOfJoining,
                    Status = status,
                    Salary = salary,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                // Thêm nhân viên vào context và lưu thay đổi vào cơ sở dữ liệu
                _context.Employees.Add(newEmployee);
                _context.SaveChanges(); // Lưu nhân viên vào cơ sở dữ liệu

                // Tải lại dữ liệu và thông báo thành công
                LoadData();
                MessageBox.Show("Thêm nhân viên và tài khoản thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên và tài khoản: {ex.Message}");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearStaff();
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            addStaff();
        }

        private void UpdateStaff()
        {
            try
            {
                // Lấy ID nhân viên từ TextBox (đã chọn từ DataGridView)
                if (!int.TryParse(txtIDStaff.Text, out int employeeID))
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật.");
                    return;
                }

                // Tìm nhân viên cần cập nhật trong cơ sở dữ liệu
                var employee = _context.Employees.FirstOrDefault(emp => emp.EmployeeID == employeeID);
                if (employee == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên để cập nhật.");
                    return;
                }

                // Kiểm tra tài khoản đã được sử dụng chưa
                var selectedAccountID = (int)cmbAccount.SelectedValue; // Lấy AccountID từ ComboBox
                var existingEmployee = _context.Employees.FirstOrDefault(emp => emp.AccountID == selectedAccountID);

                if (existingEmployee != null && existingEmployee.EmployeeID != employeeID)
                {
                    // Nếu tài khoản đã được sử dụng và không phải nhân viên hiện tại
                    MessageBox.Show("Tài khoản này đã được sử dụng cho nhân viên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật thông tin nhân viên
                employee.FullName = txtFullName.Text;
                employee.Position = txtPosition.Text;
                employee.DateOfJoining = dtpDateOfJoining.Value;
                employee.Status = cmbStatus.SelectedItem?.ToString();

                // Kiểm tra và cập nhật lương
                if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary <= 0)
                {
                    MessageBox.Show("Lương không hợp lệ!");
                    return;
                }
                employee.Salary = salary;

                // Cập nhật thời gian
                employee.UpdatedAt = DateTime.Now;

                // Cập nhật tài khoản nếu người dùng sửa
                var account = _context.Account.FirstOrDefault(acc => acc.AccountID == selectedAccountID);
                if (account != null)
                {
                    account.Username = txtFullName.Text; // Cập nhật tên tài khoản nếu cần
                    _context.SaveChanges();
                }

                // Lưu thay đổi vào cơ sở dữ liệu
                _context.SaveChanges();

                // Tải lại dữ liệu và thông báo thành công
                LoadData();
                MessageBox.Show("Cập nhật thông tin nhân viên và tài khoản thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật thông tin nhân viên: {ex.Message}");
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStaff();
            clearStaff();
        }
        private void DeleteStaff()
        {
            if (dgvDataStaff.CurrentRow == null || dgvDataStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvDataStaff.CurrentRow.Cells["EmployeeID"].Value.ToString(), out int employeeID))
            {
                MessageBox.Show("ID nhân viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedUsername = dgvDataStaff.CurrentRow.Cells["Username"].Value.ToString();
            if (selectedUsername == UsernameStaff)
            {
                MessageBox.Show("Bạn không thể xóa tài khoản đang đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                var employee = _context.Employees.FirstOrDefault(emp => emp.EmployeeID == employeeID);
                if (employee == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xóa nhân viên trước
                _context.Employees.Remove(employee);

                // Sau đó xóa tài khoản của nhân viên
                var account = _context.Account.FirstOrDefault(acc => acc.AccountID == employee.AccountID);
                if (account != null)
                {
                    _context.Account.Remove(account);
                }

                // Lưu các thay đổi vào cơ sở dữ liệu
                _context.SaveChanges();

                // Tải lại dữ liệu và thông báo thành công
                LoadData();
                MessageBox.Show("Xóa nhân viên và tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Có", gọi hàm xóa
                DeleteStaff();
            }
            else
            {
                // Nếu người dùng chọn "Không", tải lại dữ liệu
                LoadData();
            }
        }

        private void clearStaff()
        {
            // Xóa nội dung trong các TextBox
            txtIDStaff.Clear();
            txtFullName.Clear();
            txtPosition.Clear();
            txtSalary.Clear();

            // Reset giá trị ComboBox về trạng thái mặc định
            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = 0; // Chọn mục đầu tiên nếu có
            }
            else
            {
                cmbStatus.SelectedItem = null; // Nếu không có mục, để trống
            }

            // Đặt DateTimePicker về ngày hiện tại
            dtpDateOfJoining.Value = DateTime.Now;

            // Ẩn nút Lưu (nếu có liên quan)
            btnSave.Visible = false;



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearStaff();
            MessageBox.Show("Đã xóa dữ liệu trên các trường");
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtTimkiem.Text.ToLower();
            var filteredList = (from emp in _context.Employees
                                join acc in _context.Account
                                on emp.AccountID equals acc.AccountID
                                where emp.FullName.ToLower().Contains(searchTerm) ||
                                      acc.Username.ToLower().Contains(searchTerm) ||
                                      emp.Status.ToLower().Contains(searchTerm)
                                select new
                                {
                                    emp.EmployeeID,
                                    emp.FullName,
                                    acc.Username,
                                    //acc.AccountID,
                                    acc.Role,
                                    emp.Position,
                                    emp.DateOfJoining,
                                    emp.Status,
                                    emp.Salary
                                }).ToList();

            dgvDataStaff.DataSource = filteredList;
        }

        private void dgvDataStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng được nhấp có hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgvDataStaff.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ dòng vào các ô nhập liệu
                txtIDStaff.Text = row.Cells["EmployeeID"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtPosition.Text = row.Cells["Position"].Value?.ToString();
                cmbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
                txtSalary.Text = row.Cells["Salary"].Value?.ToString();

                // Kiểm tra và hiển thị giá trị của cột DateOfJoining
                if (row.Cells["DateOfJoining"].Value != null)
                {
                    if (DateTime.TryParse(row.Cells["DateOfJoining"].Value.ToString(), out DateTime date))
                    {
                        dtpDateOfJoining.Value = date;
                    }
                }

                if (e.ColumnIndex == dgvDataStaff.Columns["Username"].Index)
                {
                    // Hiển thị ComboBox để sửa tài khoản
                    cmbAccount.Visible = true;
                    lblAccountID.Visible = true;

                    // Thiết lập giá trị cho ComboBox cmbAccount dựa trên giá trị tài khoản trong dòng đã chọn
                    cmbAccount.SelectedItem = row.Cells["Username"].Value?.ToString();
                }
                else
                {
                    // Ẩn ComboBox nếu người dùng không nhấp vào cột "Username"
                    cmbAccount.Visible = false;
                    lblAccountID.Visible = false;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Có", gọi hàm xóa
                DeleteStaff();
            }
            else
            {
                // Nếu người dùng chọn "Không", tải lại dữ liệu
                LoadData();
            }
        }


        private void LoadAccountData()
        {
            try
            {
                // Lấy danh sách tài khoản từ cơ sở dữ liệu
                var accountList = _context.Account.ToList();

                // Đặt dữ liệu vào ComboBox
                cmbAccount.DataSource = accountList;

                // Chỉ định trường hiển thị (Username) và trường giá trị (AccountID)
                cmbAccount.DisplayMember = "Username";  // Tên hiển thị trong ComboBox
                cmbAccount.ValueMember = "AccountID";  // Giá trị được lưu trong ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải tài khoản: {ex.Message}");
            }
        }

        private void đổiAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            
        }
    }
}
