using BTL_WINFORM.Models.Entities;
using Microsoft.EntityFrameworkCore;
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
using System.Xml.Linq;

namespace BTL_WINFORM
{
    public partial class AdminAddProductsForm : UserControl
    {
        private readonly MyDbContext _context;
        public AdminAddProductsForm()
        {
            InitializeComponent();
            _context = new MyDbContext();

            LoadData();

            txtIDProduct.ReadOnly = true;
            txtIDProduct.Enabled = false;


            nudPrice.Minimum = 0; // Đặt giá trị tối thiểu là 0
            nudPrice.Maximum = 1000000; // Đặt giá trị tối đa (ở đây là 1 triệu)

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            cbCategory.SelectedIndex = 0;


        }
        private void FormatDataGridView()
        {
            dgvDataProduct.Columns["ProductID"].HeaderText = "ID Sản Phẩm";
            dgvDataProduct.Columns["ProductName"].HeaderText = "Tên Sản Phẩm";
            dgvDataProduct.Columns["CategoryName"].HeaderText = "Danh Mục";
            dgvDataProduct.Columns["Price"].HeaderText = "Giá";

            //dgvDataProduct.Columns["Description"].HeaderText = "Mô Tả";
            dgvDataProduct.Columns["Image"].HeaderText = "Hình Ảnh";

            dgvDataProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataProduct.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void AdminAddProductsForm_Load(object sender, EventArgs e)
        {
            TinhTongSP();
            LoadCategories();
        }
        private void LoadData()
        {
            btnSave.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            try
            {
                var productList = _context.Products
                    .Select(p => new
                    {
                        p.ProductID,
                        p.ProductName,
                        CategoryName = p.Category.CategoryName, // Lấy tên danh mục từ liên kết với bảng Categories
                        p.Price,
                        //p.Quantity,
                        //p.Description,
                        Image = string.IsNullOrEmpty(p.Image) ? "NoImage.png" : p.Image
                    }).ToList();

                dgvDataProduct.DataSource = productList;
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
            LoadCategories();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text.ToLower();

            // Nếu searchTerm trống, tải lại toàn bộ dữ liệu
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadData(); // Tải lại tất cả dữ liệu nếu không có từ khóa tìm kiếm
                return;
            }

            try
            {
                // Tìm kiếm theo các trường được hiển thị trong LoadData (ProductName, CategoryName, Price)
                var filteredList = _context.Products
                    .Where(p => p.ProductName.ToLower().Contains(searchTerm) ||   // Tìm kiếm theo tên sản phẩm
                                p.Category.CategoryName.ToLower().Contains(searchTerm) || // Tìm kiếm theo tên danh mục
                                p.Price.ToString().Contains(searchTerm))  // Tìm kiếm theo giá sản phẩm (nếu cần)
                    .Select(p => new
                    {
                        p.ProductID,
                        p.ProductName,
                        CategoryName = p.Category.CategoryName,
                        p.Price,
                        p.Image
                    })
                    .ToList(); // Lấy danh sách sản phẩm phù hợp từ cơ sở dữ liệu

                // Cập nhật dữ liệu vào DataGridView
                dgvDataProduct.DataSource = filteredList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            var categories = _context.Categories.ToList();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "CategoryName"; // Hiển thị tên danh mục
            cbCategory.ValueMember = "CategoryID";    // Lưu ID của danh mục
        }





        private void dgvDataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private string SaveImage(string sourceFilePath)
        {
            try
            {
                // Xác định thư mục lưu ảnh
                string directory = Path.Combine(Application.StartupPath, "img");

                // Kiểm tra nếu thư mục img không tồn tại thì tạo mới
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Lấy tên tệp ảnh từ đường dẫn
                string fileName = Path.GetFileName(sourceFilePath);

                // Tạo đường dẫn mới để lưu ảnh vào thư mục img
                string destinationFilePath = Path.Combine(directory, fileName);

                // Sao chép tệp ảnh vào thư mục img
                File.Copy(sourceFilePath, destinationFilePath, true); // true để ghi đè nếu tệp đã tồn tại

                return destinationFilePath; // Trả về đường dẫn ảnh đã lưu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void add()
        {
            try
            {
                // Kiểm tra nếu ComboBox không có giá trị nào
                if (cbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int categoryId = (int)cbCategory.SelectedValue;
                string productName = txtProductName.Text.Trim();
                decimal price = nudPrice.Value;

                if (string.IsNullOrEmpty(productName))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh cho sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string imagePath = lbltenanh.Text;

                var product = new Product
                {
                    ProductName = productName,
                    CategoryID = categoryId,
                    Price = price,
                    Image = imagePath
                };

                _context.Products.Add(product);
                _context.SaveChanges();

                LoadData();

                MessageBox.Show("Sản phẩm đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            add();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Có", gọi hàm xóa
                DeleteProduct();
            }
            else
            {
                // Nếu người dùng chọn "Không", tải lại dữ liệu
                LoadData();
            }
        }



        private void Clear()
        {
            try
            {
                // Xóa nội dung của các TextBox
                txtIDProduct.Clear();
                txtProductName.Clear();

                // Đặt lại giá trị mặc định cho ComboBox (chọn mục đầu tiên nếu có)
                if (cbCategory.Items.Count > 0)
                {
                    cbCategory.SelectedIndex = 1;
                }

                // Đặt lại giá trị mặc định cho NumericUpDown
                nudPrice.Value = nudPrice.Minimum;

                // Đặt lại hình ảnh về mặc định
                pictureBox1.Image = Properties.Resources.login_background; // Đặt hình ảnh mặc định
                lbltenanh.Text = string.Empty;

                // Vô hiệu hóa các nút Update và Delete
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                // Hiển thị thông báo thành công (tùy chọn)
                MessageBox.Show("Đã đặt lại các trường dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnaddpicter_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở hộp thoại chọn tệp hình ảnh
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn tệp hình ảnh đã chọn
                    string sourceFilePath = openFileDialog.FileName;

                    // Lưu ảnh vào thư mục img và lấy đường dẫn mới
                    string imagePath = SaveImage(sourceFilePath);

                    if (imagePath != null)
                    {
                        // Hiển thị tên ảnh lên lbltenanh
                        lbltenanh.Text = Path.GetFileName(imagePath);

                        // Hiển thị ảnh lên pictureBox1
                        pictureBox1.Image = Image.FromFile(imagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Tùy chọn để điều chỉnh kích thước ảnh hiển thị trong PictureBox
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDataProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDataProduct.Rows[e.RowIndex];

                txtIDProduct.Text = row.Cells["ProductID"].Value?.ToString() ?? string.Empty;
                txtProductName.Text = row.Cells["ProductName"].Value?.ToString() ?? string.Empty;

                // Kiểm tra giá trị null trước khi gán
                string categoryName = row.Cells["CategoryName"].Value?.ToString();
                var selectedCategory = _context.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
                if (selectedCategory != null)
                {
                    cbCategory.SelectedItem = selectedCategory;
                }

                // Kiểm tra nếu giá trị null hoặc không thể chuyển đổi
                decimal price;
                if (decimal.TryParse(row.Cells["Price"].Value?.ToString(), out price))
                {
                    nudPrice.Value = price;
                }
                else
                {
                    nudPrice.Value = nudPrice.Minimum;
                }

                lbltenanh.Text = row.Cells["Image"].Value?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(lbltenanh.Text) && File.Exists(lbltenanh.Text))
                {
                    pictureBox1.Image = Image.FromFile(lbltenanh.Text);
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.login_background;
                }
            }
        }



        private void dgvDataProduct_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Kiểm tra nếu người dùng click phải vào một dòng
                var hti = dgvDataProduct.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dgvDataProduct.ClearSelection();
                    dgvDataProduct.Rows[hti.RowIndex].Selected = true;

                    // Hiển thị menu chuột phải
                    cntRemoOrUpdate.Show(dgvDataProduct, new Point(e.X, e.Y));
                }
            }
        }
        private void UpdateProduct()
        {
        
            try
            {
                int productId = Convert.ToInt32(txtIDProduct.Text);
                var product = _context.Products.FirstOrDefault(p => p.ProductID == productId);

                if (product == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật thông tin sản phẩm
                product.ProductName = txtProductName.Text;
                product.Price = decimal.Parse(nudPrice.Text);
               

                // Kiểm tra và cập nhật Category
                if (cbCategory.SelectedItem != null)
                {
                    int selectedCategoryId = Convert.ToInt32(cbCategory.SelectedValue);
                    var category = _context.Categories.FirstOrDefault(c => c.CategoryID == selectedCategoryId);

                    if (category != null)
                    {
                        product.Category = category; // Gán danh mục mới
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy danh mục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // Lưu thay đổi
                _context.SaveChanges();

                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Hàm này để refresh lại giao diện nếu cần
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteProduct()
        {
            try
            {
                if (string.IsNullOrEmpty(txtIDProduct.Text))
                {
                    MessageBox.Show("Không có sản phẩm nào được chọn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int productId = int.Parse(txtIDProduct.Text);

                // Tìm sản phẩm cần xóa
                var product = _context.Products.FirstOrDefault(p => p.ProductID == productId);
                if (product == null)
                {
                    MessageBox.Show("Sản phẩm không tồn tại hoặc đã bị xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xóa sản phẩm
                _context.Products.Remove(product);
                _context.SaveChanges();
                LoadData(); // Làm mới dữ liệu trong DataGridView
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("ID sản phẩm không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cntRemoOrUpdate_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Update")
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = false;// Hiển thị nút Cập nhật
            }
            else if (e.ClickedItem.Text == "Delete")
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = false;//  Hiển thị nút Cập nhật
            }
        }

        public void TinhTongSP()
        {
            int totalProducts = _context.Products.Count();

            // Hiển thị tổng số sản phẩm lên lblSo
            lblSoSP.Text = totalProducts.ToString();
        }
    }
}
