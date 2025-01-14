using BTL_WINFORM.Models.Entities;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTL_WINFORM.Forms
{
    public partial class AdminForm : Form
    {
        public string Username { get; set; }
        public AdminForm()
        {
            //lblTen.Text = user;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void adminAddProductsForm1_Load(object sender, EventArgs e)
        {


        }

        private void adminAddProductsForm1_Load_1(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
        //    adminDashboardForm.Dock = DockStyle.Fill;
        //    panelData.Controls.Clear();


        //    panelData.Controls.Add(adminDashboardForm);


        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    // Tạo một instance của UserControl sản phẩm
        //    AdminAddProductsForm sanphamForm = new AdminAddProductsForm();

        //    // Đặt Dock để UserControl chiếm toàn bộ Panel1
        //    sanphamForm.Dock = DockStyle.Fill;

        //    // Thêm UserControl vào Panel1 và hiển thị
        //    panelData.Controls.Clear(); // Xóa các control cũ trong Panel1 nếu có
        //    panelData.Controls.Add(sanphamForm);
        //}

        //private void button3_Click(object sender, EventArgs e)

        //{

        //    // Tạo một instance của UserControl sản phẩm
        //    AdminStaffForm staffForm = new AdminStaffForm();

        //    // Đặt Dock để UserControl chiếm toàn bộ Panel1
        //    staffForm.Dock = DockStyle.Fill;

        //    // Thêm UserControl vào Panel1 và hiển thị
        //    panelData.Controls.Clear(); // Xóa các control cũ trong Panel1 nếu có
        //    panelData.Controls.Add(staffForm);
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    //MenuForm menuForm = new MenuForm();
        //    //menuForm.ShowDialog();
        //    //Application.Exit();
        //    MenuBanForm menuBanForm = new MenuBanForm();
        //    menuBanForm.ShowDialog();
        //    Application.Exit();

        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    fLogin fLogin = new fLogin();
        //    this.Hide();
        //    fLogin.ShowDialog();
        //}

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuBanForm menuBanForm = new MenuBanForm();
            menuBanForm.UsernameMenu=Username;
            menuBanForm.ShowDialog();
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
            adminDashboardForm.Dock = DockStyle.Fill;
            panelData.Controls.Clear();


            panelData.Controls.Add(adminDashboardForm);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AdminAddProductsForm sanphamForm = new AdminAddProductsForm();

            // Đặt Dock để UserControl chiếm toàn bộ Panel1
            sanphamForm.Dock = DockStyle.Fill;

            // Thêm UserControl vào Panel1 và hiển thị
            panelData.Controls.Clear(); // Xóa các control cũ trong Panel1 nếu có
            panelData.Controls.Add(sanphamForm);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

            AdminStaffForm staffForm = new AdminStaffForm();
            staffForm.Dock = DockStyle.Fill;
            staffForm.UsernameStaff = Username;
            panelData.Controls.Clear(); 
            panelData.Controls.Add(staffForm);
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            AdminVoucherForm voucherForm = new AdminVoucherForm();
            voucherForm.Dock = DockStyle.Fill;
            panelData.Controls.Clear();
            panelData.Controls.Add(voucherForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox xác nhận
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại xác nhận
            if (dialogResult == DialogResult.Yes)
            {
                // Đóng form hiện tại (nếu bạn muốn đăng xuất từ form hiện tại)
                this.Hide();

                // Hiển thị lại form đăng nhập (giả sử form đăng nhập có tên là LoginForm)
                fLogin fLogin= new fLogin();

                fLogin.ShowDialog();
                Application.Exit();

            }
            else
            {
                // Nếu người dùng chọn "No", không làm gì cả
                return;
            }
        }


        private void panelData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);
            lblTen.Text = Username;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {

            AdminCategory adminCategory = new AdminCategory();

            // Đặt Dock để UserControl chiếm toàn bộ Panel1
            adminCategory.Dock = DockStyle.Fill;

            // Thêm UserControl vào Panel1 và hiển thị
            panelData.Controls.Clear(); // Xóa các control cũ trong Panel1 nếu có
            panelData.Controls.Add(adminCategory);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AdminAddAcountsForm adminAddUserForm = new AdminAddAcountsForm();
            adminAddUserForm.Dock = DockStyle.Fill;

            // Thêm UserControl vào Panel1 và hiển thị
            panelData.Controls.Clear(); // Xóa các control cũ trong Panel1 nếu có
            panelData.Controls.Add(adminAddUserForm);
        }


        
    }
}
