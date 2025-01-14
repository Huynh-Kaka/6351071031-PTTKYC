
using BTL_WINFORM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using BTL_WINFORM.Models.Entities;
using Sunny.UI.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTL_WINFORM
{
    public partial class fLogin : Form
    {
        private readonly MyDbContext _context;
        //List<Account> acc;
        public fLogin()
        {
            InitializeComponent();

            _context = new MyDbContext();
            //this.Size = new Size(863, 526); // Kích thước cố định
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string User = txtUsername.Text;
            string Password = txtPassword.Text;

            var account = _context.Account.FirstOrDefault(u => u.Username == User && u.Password == Password);
            if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Các trường không thể để trống.");
                return;
            }
            if (account == null)
            {
                MessageBox.Show("Sai tài khoan hoac mat khau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (account.Role == 1)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Username= txtUsername.Text;
                    adminForm.ShowDialog();
                    Application.Exit();
                }
                else if (account.Role == 2)
                {
                    MenuBanForm menuBanForm = new MenuBanForm();
                    menuBanForm.UsernameMenu= txtUsername.Text.Trim();
                    menuBanForm.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Vai tro khong hop le .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void lbldangKy_Click(object sender, EventArgs e)
        {
            DangKyForm dangKyForm = new DangKyForm();
            this.Hide();
            dangKyForm.ShowDialog();
          
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar= false;    
            }
        }
    }
}
