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
    public partial class AdminCategory : UserControl
    {
        private readonly MyDbContext _context;
        public AdminCategory()
        {
            InitializeComponent();
            _context = new MyDbContext();
            LoadData();
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Enabled = false;
        }
        private void LoadData()
        {
            try
            {
                var categoryList = _context.Categories
                    .Select(c => new
                    {
                        c.CategoryID,
                        c.CategoryName
                    }).ToList();

                dgvDataCategory.DataSource = categoryList;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void FormatDataGridView()
        {
            dgvDataCategory.Columns["CategoryID"].HeaderText = "ID Danh Mục";
            dgvDataCategory.Columns["CategoryName"].HeaderText = "Tên Danh Mục";
            dgvDataCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataCategory.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void add()
        {
            string categoryName = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var category = new Category
                {
                    CategoryName = categoryName
                };

                _context.Categories.Add(category);
                _context.SaveChanges();

                LoadData();
                MessageBox.Show("Danh mục đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            add();
        }

        private void update()
        {
            int categoryId = int.Parse(txtCategoryID.Text);
            string categoryName = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var category = _context.Categories.FirstOrDefault(c => c.CategoryID == categoryId);
                if (category != null)
                {
                    category.CategoryName = categoryName;
                    _context.SaveChanges();

                    LoadData();
                    MessageBox.Show("Cập nhật danh mục thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Danh mục không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void deleteCategory()
        {
            // Lấy ID của danh mục từ ô txtCategoryID
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("Vui lòng chọn danh mục để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int categoryId;
            if (!int.TryParse(txtCategoryID.Text, out categoryId))
            {
                MessageBox.Show("ID danh mục không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Tìm danh mục trong cơ sở dữ liệu
                var category = _context.Categories.FirstOrDefault(c => c.CategoryID == categoryId);

                if (category != null)
                {
                    // Xóa danh mục
                    _context.Categories.Remove(category);
                    _context.SaveChanges();

                    // Cập nhật lại dữ liệu
                    LoadData();
                    TinhTongLoaiSP();
                    MessageBox.Show("Danh mục đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Danh mục không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Có", gọi hàm xóa
                deleteCategory();
            }
            else
            {
                // Nếu người dùng chọn "Không", tải lại dữ liệu
                LoadData();
            }
        }

        private void dgvDataCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDataCategory.Rows[e.RowIndex];
                txtCategoryID.Text = row.Cells["CategoryID"].Value?.ToString() ?? string.Empty;
                txtCategoryName.Text = row.Cells["CategoryName"].Value?.ToString() ?? string.Empty;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteCategory();
        }

        private void clear()
        {
            txtCategoryID.Clear();
            txtCategoryName.Clear();
        }

        private void dgvDataCategory_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Kiểm tra nếu người dùng click phải vào một dòng
                var hti = dgvDataCategory.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dgvDataCategory.ClearSelection();
                    dgvDataCategory.Rows[hti.RowIndex].Selected = true;

                    // Hiển thị menu chuột phải
                    contextMenuStrip1.Show(dgvDataCategory, new Point(e.X, e.Y));
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Lấy nội dung từ txtTimKiem
            string searchText = txtTimkiem.Text.Trim().ToLower();

            // Kiểm tra nếu không có gì để tìm kiếm
            if (string.IsNullOrEmpty(searchText))
            {
                // Nếu không có gì, tải lại dữ liệu gốc
                LoadData();
            }
            else
            {
                // Nếu có, thực hiện tìm kiếm và lọc dữ liệu
                var filteredData = _context.Categories.Where(c => c.CategoryName.ToLower().Contains(searchText)).ToList();

                // Hiển thị dữ liệu đã lọc lên DataGridView
                dgvDataCategory.DataSource = filteredData;
            }
        }
        private void TinhTongLoaiSP()
        {
            int totalCategory = _context.Categories.Count();
            lblSoSP.Text = totalCategory.ToString();
        }

        private void AdminCategory_Load(object sender, EventArgs e)
        {
            TinhTongLoaiSP();
        }
    }
}
