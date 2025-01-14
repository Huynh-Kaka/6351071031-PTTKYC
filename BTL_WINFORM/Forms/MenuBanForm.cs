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

using System.Globalization;

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BTL_WINFORM.Forms
{
    public partial class MenuBanForm : Form
    {
        private readonly MyDbContext _context;
        public string UsernameMenu { get; set; }
        public MenuBanForm()
        {
            InitializeComponent();
            _context = new MyDbContext();
            this.StartPosition = FormStartPosition.CenterScreen;


            LoadTable();
        }
        private void MenuBanForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToComboBox();
            LoadProductsToComboBox();
            LoadCustomerComboBox();
            LoadColumnsToDataGridView();
            ClearDataGridView();
            LoadcboSwitchTable();
            LoadcbxMergeTable();
            dgvDetails.CellContentClick += dgvDetails_CellContentClick;
        }

        public void LoadTable()
        {
            // Lấy danh sách bàn từ cơ sở dữ liệu
            var tables = TableService.Instance.GetAllTables();

            // Xóa các nút cũ trên FlowLayoutPanel
            flpTableLists.Controls.Clear();

            // Tạo nút cho từng bàn và thêm vào FlowLayoutPanel
            tables.ForEach(t =>
            {
                var btn = BuildTableButton(t);
                flpTableLists.Controls.Add(btn);
            });
            flpTableLists.AutoScroll = true;
            // Điều chỉnh cách hiển thị các bàn trên dòng
            flpTableLists.FlowDirection = FlowDirection.LeftToRight; // Các bàn được xếp theo dòng ngang
            //flpTableLists.WrapContents = true; // Cho phép tự động xuống dòng khi đầy
        }

        private Button selectedTableButton = null;

        private Button BuildTableButton(Table table)
        {
            Button btn = new Button
            {
                Width = 100,
                Height = 120,
                BackColor = table.Status ? Color.LightGreen : Color.LightCoral, // Màu nền ban đầu
                Tag = table
            };

            // Tạo PictureBox và Label như trước
            PictureBox pbx = new PictureBox
            {
                Image = Properties.Resources.icon_Cafe,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(80, 50),
                Location = new Point((btn.Width - 80) / 2, 5)
            };
            btn.Controls.Add(pbx);

            Label lblTableName = new Label
            {
                Text = table.TableName,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(0, 60),
                Width = btn.Width,
                Height = 20,
                BackColor = Color.Transparent
            };
            btn.Controls.Add(lblTableName);

            Label lblStatus = new Label
            {
                Text = table.Status ? "Trống" : "Đang sử dụng",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 8, FontStyle.Regular),
                Location = new Point(0, 80),
                Width = btn.Width,
                Height = 15,
                BackColor = Color.Transparent
            };
            btn.Controls.Add(lblStatus);

            // Gắn sự kiện Click
            btn.Click += (s, e) =>
            {
                HandleTableButtonClick(btn, table);
            };

            return btn;
        }

        private void HandleTableButtonClick(Button clickedButton, Table table)
        {
            ClearDataGridView();
            btnBanSo.Text = table.TableName;
            btnBanSo.Tag = table;

            // Nếu bàn đã được chọn và đặt rồi, hiển thị thông tin đặt món
            if (selectedTableButton == clickedButton)
            {
                //DisplayOrderDetails(table);
                ShowBillInfoOfTable(table.TableID); // Hàm hiển thị thông tin đặt món

                return;
            }

            // Đổi màu nút bàn hiện tại thành màu hồng
            clickedButton.BackColor = Color.LightCoral;

            // Cập nhật trạng thái bàn trong cơ sở dữ liệu
            table.Status = false; // Đặt trạng thái "Đã đặt"
            _context.Tables.Update(table);
            _context.SaveChanges();

            // Cập nhật Label trạng thái
            var lblStatus = clickedButton.Controls
                .OfType<Label>()
                .FirstOrDefault(l => l.Text == "Trống" || l.Text == "Đang sử dụng");
            if (lblStatus != null)
            {
                lblStatus.Text = "Đang sử dụng";
            }

            // Cập nhật bàn đang được chọn
            selectedTableButton = clickedButton;



        }

        // Hàm hiển thị thông tin đặt món (tùy chỉnh theo yêu cầu)
        //private void DisplayOrderDetails(Table table)
        //{


        //}





        public class TableService
        {
            private static TableService _instance;
            public static TableService Instance => _instance ?? (_instance = new TableService());

            private TableService() { }

            public List<Table> GetAllTables()
            {
                using (var context = new MyDbContext())
                {
                    return context.Tables.ToList();
                }
            }
        }



        //private void UpdateSelectedTableButton(Table selectedTable)
        //{
        //    if (selectedTable == null)
        //    {
        //        MessageBox.Show("Không tìm thấy thông tin bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        // Cập nhật trạng thái bàn trong cơ sở dữ liệu
        //        selectedTable.Status = false; // Đặt bàn thành "Đang sử dụng"
        //        _context.Tables.Update(selectedTable);
        //        _context.SaveChanges();

        //        // Tìm nút tương ứng trong FlowLayoutPanel
        //        var btn = flpTableLists.Controls
        //            .OfType<Button>()
        //            .FirstOrDefault(b => b.Tag == selectedTable);

        //        if (btn != null)
        //        {
        //            // Cập nhật màu nền và trạng thái hiển thị
        //            btn.BackColor = Color.DarkRed; // Màu đậm hơn
        //            var lblStatus = btn.Controls
        //                .OfType<Label>()
        //                .FirstOrDefault(l => l.Text == "Trống" || l.Text == "Đang sử dụng");
        //            if (lblStatus != null)
        //            {
        //                lblStatus.Text = "Đang sử dụng";
        //            }
        //        }

        //        MessageBox.Show($"Bàn {selectedTable.TableName} đã được đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        btnBanSo.Text = selectedTable.TableName;

        //        // Gắn thêm tag nếu cần lưu thông tin bàn
        //        btnBanSo.Tag = selectedTable;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi cập nhật bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        private void LoadProductsToComboBox(int? categoryId = null)
        {
            try
            {
                List<Product> products;

                // Nếu categoryId là null hoặc bằng 0, lấy tất cả sản phẩm
                if (categoryId == null || categoryId == 0)
                {
                    products = _context.Products.ToList();
                }
                else
                {
                    // Lọc sản phẩm theo danh mục
                    products = _context.Products.Where(p => p.CategoryID == categoryId).ToList();
                }

                if (products != null && products.Any())
                {
                    // Gán danh sách sản phẩm vào ComboBox
                    cbxMon.DataSource = products;
                    cbxMon.DisplayMember = "ProductName";
                    cbxMon.ValueMember = "ProductID";
                }
                else
                {
                    cbxMon.DataSource = null;
                    MessageBox.Show("Không có sản phẩm nào trong danh mục này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategoriesToComboBox()
        {
            try
            {
                // Lấy danh sách danh mục từ cơ sở dữ liệu
                var categories = _context.Categories.ToList();

                if (categories != null && categories.Any())
                {
                    // Thêm một mục "Tất cả" vào đầu danh sách


                    // Gán danh sách danh mục vào ComboBox
                    cboCategory.DataSource = categories;
                    cboCategory.DisplayMember = "CategoryName";
                    cboCategory.ValueMember = "CategoryID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomerComboBox()
        {
            try
            {
                // Lấy tất cả dữ liệu khách hàng từ cơ sở dữ liệu
                var customers = _context.Customers.ToList();

                // Đặt ComboBox để hiển thị tên khách hàng
                cbxCustomer.DisplayMember = "FullName";  // Hiển thị tên khách hàng
                cbxCustomer.ValueMember = "CustomerID";  // Giá trị sẽ là CustomerID

                // Gán danh sách khách hàng vào ComboBox
                cbxCustomer.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadcboSwitchTable()
        {
            try
            {
                // Lấy danh sách bàn từ cơ sở dữ liệu mà không theo dõi đối tượng
                var tables = _context.Tables.AsNoTracking().ToList();

                // Kiểm tra xem có bảng nào trong hệ thống không
                if (tables != null && tables.Any())
                {
                    // Gán danh sách bàn vào ComboBox cboSwitchTable
                    cboSwitchTable.DataSource = tables;
                    cboSwitchTable.DisplayMember = "TableName";  // Hiển thị tên bàn
                    cboSwitchTable.ValueMember = "TableID";  // Giá trị sẽ là TableID
                }
                else
                {
                    cboSwitchTable.DataSource = null;
                    MessageBox.Show("Không có bàn nào trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadcbxMergeTable()
        {
            try
            {
                // Lấy danh sách bàn từ cơ sở dữ liệu mà không theo dõi đối tượng
                var tables = _context.Tables.AsNoTracking().ToList();

                // Kiểm tra xem có bảng nào trong hệ thống không
                if (tables != null && tables.Any())
                {
                    // Gán danh sách bàn vào ComboBox cbxMergeTable
                    cbxMergeTable.DataSource = tables;
                    cbxMergeTable.DisplayMember = "TableName";  // Hiển thị tên bàn
                    cbxMergeTable.ValueMember = "TableID";  // Giá trị sẽ là TableID
                }
                else
                {
                    cbxMergeTable.DataSource = null;
                    MessageBox.Show("Không có bàn nào trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {
            // Không có xử lý ở đây
        }



        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedValue is int selectedCategoryId)
            {
                // Tải sản phẩm theo danh mục được chọn
                LoadProductsToComboBox(selectedCategoryId);
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {

        }

        private void btnMergeTable_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng được chọn trong DataGridView
            if (dgvDetails.SelectedRows.Count > 0)
            {
                // Xác nhận xóa sản phẩm
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Duyệt qua các dòng đã chọn
                    foreach (DataGridViewRow row in dgvDetails.SelectedRows)
                    {
                        // Lấy thông tin đơn hàng và chi tiết đơn hàng từ DataGridView
                        int orderId = Convert.ToInt32(row.Cells["OrderID"].Value);
                        string productName = row.Cells["ProductName"].Value.ToString();

                        // Lấy chi tiết đơn hàng từ CSDL
                        var orderDetail = _context.OrderDetails
                                                   .FirstOrDefault(od => od.OrderID == orderId && od.Product.ProductName == productName);

                        if (orderDetail != null)
                        {
                            // Xóa chi tiết đơn hàng trong CSDL
                            _context.OrderDetails.Remove(orderDetail);
                            _context.SaveChanges(); // Cập nhật CSDL

                            // Xóa dòng khỏi DataGridView
                            dgvDetails.Rows.Remove(row);
                        }
                    }

                    // Tính lại tổng tiền sau khi xóa
                    decimal totalPrice = 0;
                    foreach (DataGridViewRow row in dgvDetails.Rows)
                    {
                        totalPrice += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                    }
                    txtTotalPrice.Text = totalPrice.ToString("C", new CultureInfo("vi-VN"));
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (selectedTableButton == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxMon.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một món ăn để thêm vào bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedTable = (Table)selectedTableButton.Tag;
                var selectedProductId = (int)cbxMon.SelectedValue;

                // Lấy thông tin sản phẩm từ cơ sở dữ liệu
                var selectedProduct = _context.Products.FirstOrDefault(p => p.ProductID == selectedProductId);
                if (selectedProduct == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy thông tin Customer từ ComboBox
                var selectedCustomerId = (int)cbxCustomer.SelectedValue;

                // Lấy AccountID từ nhân viên đã đăng nhập (sử dụng UsernameMenu)
                var loggedInAccount = _context.Account.FirstOrDefault(a => a.Username == UsernameMenu);
                if (loggedInAccount == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin tài khoản nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra xem có đơn hàng nào chưa thanh toán cho bàn này không
                var currentOrder = _context.Orders
                    .FirstOrDefault(o => o.TableID == selectedTable.TableID && o.CustomerID == selectedCustomerId && !_context.Invoices
                    .Any(i => i.OrderID == o.OrderID)); // Kiểm tra hóa đơn chưa có

                // Nếu chưa có đơn hàng, tạo đơn hàng mới
                if (currentOrder == null)
                {
                    currentOrder = new Order
                    {
                        TableID = selectedTable.TableID,
                        CustomerID = selectedCustomerId,
                        AccountID = loggedInAccount.AccountID, // Lấy AccountID của nhân viên đăng nhập
                        Account = loggedInAccount,
                        OrderDate = DateTime.Now
                    };

                    _context.Orders.Add(currentOrder);
                    _context.SaveChanges();
                }

                // Tìm hoặc tạo chi tiết đơn hàng
                var orderDetail = _context.OrderDetails
                    .FirstOrDefault(od => od.OrderID == currentOrder.OrderID && od.ProductID == selectedProductId);

                if (orderDetail != null)
                {
                    // Nếu món đã tồn tại trong đơn hàng, tăng số lượng
                    int num = (int)numSoLuong.Value;
                    orderDetail.Quantity += num;
                }
                else
                {
                    // Nếu món chưa có trong đơn hàng, tạo mới
                    orderDetail = new OrderDetail
                    {
                        OrderID = currentOrder.OrderID,
                        ProductID = selectedProductId,
                        Quantity = 1
                    };
                    _context.OrderDetails.Add(orderDetail);
                }

                // Lưu thay đổi vào cơ sở dữ liệu
                _context.SaveChanges();

                // Tính tổng tiền cho món ăn (số lượng * giá sản phẩm)
                decimal totalProductPrice = orderDetail.Quantity * selectedProduct.Price;

                MessageBox.Show($"Thêm món {selectedProduct.ProductName} thành công!\nSố lượng: {orderDetail.Quantity}\nTổng tiền: {totalProductPrice:C}",
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại thông tin hóa đơn
                ShowBillInfoOfTable(selectedTable.TableID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadColumnsToDataGridView()
        {
            // Kiểm tra nếu DataGridView đã có cột, nếu chưa thì tạo mới
            if (dgvDetails.Columns.Count == 0)
            {
                dgvDetails.Columns.Add("OrderID", "ID Đơn Hàng");
                dgvDetails.Columns.Add("ProductName", "Tên Món");
                dgvDetails.Columns.Add("UnitPrice", "Đơn Giá");


                dgvDetails.Columns.Add("Quantity", "Số Lượng");


                dgvDetails.Columns.Add("TotalAmount", "Thành Tiền");

                // Thêm cột cho nút Cộng và Trừ

                DataGridViewButtonColumn btnDecrease = new DataGridViewButtonColumn();
                btnDecrease.Name = "Decrease";
                btnDecrease.HeaderText = "-";
                btnDecrease.Text = "-";
                btnDecrease.UseColumnTextForButtonValue = true;
                dgvDetails.Columns.Add(btnDecrease);

                DataGridViewButtonColumn btnIncrease = new DataGridViewButtonColumn();
                btnIncrease.Name = "Increase";
                btnIncrease.HeaderText = "+";
                btnIncrease.Text = "+";
                btnIncrease.UseColumnTextForButtonValue = true;
                dgvDetails.Columns.Add(btnIncrease);


            }

            dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn vào nút Cộng hoặc Trừ
            if (e.ColumnIndex == dgvDetails.Columns["Increase"].Index || e.ColumnIndex == dgvDetails.Columns["Decrease"].Index)
            {
                // Lấy dòng hiện tại
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    // Lấy giá trị cột Số Lượng
                    int quantity = Convert.ToInt32(dgvDetails.Rows[rowIndex].Cells["Quantity"].Value);
                    decimal unitPrice = Convert.ToDecimal(dgvDetails.Rows[rowIndex].Cells["UnitPrice"].Value);

                    // Cộng hoặc Trừ số lượng
                    if (e.ColumnIndex == dgvDetails.Columns["Increase"].Index)
                    {
                        quantity++;
                    }
                    else if (e.ColumnIndex == dgvDetails.Columns["Decrease"].Index && quantity > 0)
                    {
                        quantity--;
                    }

                    // Cập nhật lại số lượng
                    dgvDetails.Rows[rowIndex].Cells["Quantity"].Value = quantity;

                    // Tính lại Thành Tiền
                    decimal totalAmount = unitPrice * quantity;
                    dgvDetails.Rows[rowIndex].Cells["TotalAmount"].Value = totalAmount;

                    // Tính lại tổng tiền của tất cả các món
                    decimal totalPrice = 0;
                    foreach (DataGridViewRow row in dgvDetails.Rows)
                    {
                        totalPrice += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                    }
                    txtTotalPrice.Text = totalPrice.ToString("C", new CultureInfo("vi-VN"));
                }
            }
        }


        private void ShowBillInfoOfTable(int tableId)
        {
            // Lấy thông tin của bàn từ bảng Tables
            var table = _context.Tables.FirstOrDefault(t => t.TableID == tableId);

            // Kiểm tra nếu không có bàn với TableID tương ứng
            if (table == null)
            {
                MessageBox.Show("Bàn không tồn tại.");
                return;
            }
            var selectedCustomerId = (int)cbxCustomer.SelectedValue;

            // Kiểm tra trạng thái bàn
            if (table.Status == true) // Nếu bàn trống (Status = true)
            {
                var loggedInAccount = _context.Account.FirstOrDefault(a => a.Username == UsernameMenu);
                if (loggedInAccount == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản đăng nhập.");
                    return; // Dừng thực hiện nếu không có tài khoản
                }

                var newOrder = new Order
                {
                    TableID = tableId,
                    CustomerID = selectedCustomerId,
                    AccountID = loggedInAccount.AccountID,
                    Account = loggedInAccount,
                    OrderDate = DateTime.Now, // Ngày tạo đơn hàng

                };

                // Thêm vào cơ sở dữ liệu
                _context.Orders.Add(newOrder);
                _context.SaveChanges();

                ;


                table.Status = false; // Đặt bàn thành "đã đặt"
                _context.SaveChanges();

                MessageBox.Show($"Hóa đơn mới đã được tạo cho bàn {table.TableName}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Dừng hàm để không thực hiện các câu lệnh tiếp theo
                return;
            }

            // Lấy danh sách đơn hàng của bàn với TableID
            var orders = _context.Orders
                                 .Where(o => o.TableID == tableId)
                                 .Include(o => o.OrderDetails) // Bao gồm chi tiết đơn hàng
                                 .ThenInclude(od => od.Product) // Bao gồm sản phẩm trong OrderDetail
                                 .ToList();

            // Kiểm tra nếu không có đơn hàng nào cho bàn này
            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("Không có đơn hàng nào cho bàn này.");
                return; // Dừng hàm nếu không có đơn hàng
            }

            // Clear DataGridView trước khi thêm dữ liệu mới
            dgvDetails.Rows.Clear();
            decimal totalPrice = 0;

            // Duyệt qua các đơn hàng để lấy thông tin chi tiết đơn hàng
            foreach (var order in orders)
            {
                // Duyệt qua các chi tiết đơn hàng và thêm vào DataGridView
                foreach (var orderDetail in order.OrderDetails)
                {
                    // Tính thành tiền (Giá x Số lượng)
                    decimal totalAmount = orderDetail.Product.Price * orderDetail.Quantity;

                    totalPrice += totalAmount;

                    // Thêm một dòng mới vào DataGridView
                    dgvDetails.Rows.Add(
                        order.OrderID,              // Mã Đơn Hàng
                        orderDetail.Product.ProductName,   // Tên Sản Phẩm
                        orderDetail.Product.Price,          // Đơn Giá
                        orderDetail.Quantity,       // Số Lượng
                        totalAmount                 // Thành Tiền
                    );
                }
            }

            // Hiển thị tổng tiền
            txtTotalPrice.Text = totalPrice.ToString("C", new CultureInfo("vi-VN"));
        }






        private void ClearDataGridView()
        {
            // Xóa hết các dòng trong DataGridView
            dgvDetails.Rows.Clear();
        }
















        //private decimal CalculateTotalPrice()
        //{


        //}

        private DateTime timeOfClick;
        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy số bàn từ chuỗi btnBanSo.Text (giả sử chuỗi có dạng "Bàn 10")
                string tableText = btnBanSo.Text;
                int tableID = 0;

                // Tách số bàn từ chuỗi
                if (int.TryParse(new string(tableText.Where(char.IsDigit).ToArray()), out tableID))
                {
                    // Sử dụng _context thay vì tạo mới QLquancafeContext
                    var order = _context.Orders
                        .FirstOrDefault(o => o.TableID == tableID && o.Table.Status == false); // Kiểm tra bàn đã đặt và chưa thanh toán

                    if (order == null)
                    {
                        MessageBox.Show("Bàn này chưa có hóa đơn hoặc hóa đơn đã thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Truyền OrderID và InvoiceID sang form ConfirmInvoice
                    ConfirmInvoice confirmInvoiceForm = new ConfirmInvoice();
                    confirmInvoiceForm.OrderIDInvoice = order.OrderID;
                    //confirmInvoiceForm.TotalPriceInVoice = txtTotalPrice.Text;
                    timeOfClick = DateTime.Now;

                    confirmInvoiceForm.OrderDateInvoice = timeOfClick;

                    // Mở form ConfirmInvoice
                    confirmInvoiceForm.ShowDialog();
                    Application.Exit();


                }
                else
                {
                    MessageBox.Show("Thông tin bàn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer();
            addNewCustomer.ShowDialog();

            Application.Exit();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại xác nhận
            if (dialogResult == DialogResult.Yes)
            {
                // Đóng form hiện tại (nếu bạn muốn đăng xuất từ form hiện tại)
                this.Hide();

                // Hiển thị lại form đăng nhập (giả sử form đăng nhập có tên là LoginForm)
                fLogin fLogin = new fLogin();

                fLogin.ShowDialog();
                Application.Exit();

            }
            else
            {
                // Nếu người dùng chọn "No", không làm gì cả
                return;
            }
        }
    }
}
