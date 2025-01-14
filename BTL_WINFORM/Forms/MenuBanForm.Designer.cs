namespace BTL_WINFORM.Forms
{
    partial class MenuBanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            uiPanel2 = new Sunny.UI.UIPanel();
            dgvDetails = new DataGridView();
            cboCategory = new Sunny.UI.UIComboBox();
            label13 = new Label();
            uiPanel13 = new Sunny.UI.UIPanel();
            btnAddCustomer = new Button();
            label15 = new Label();
            cbxCustomer = new ComboBox();
            btnDeleteProduct = new Sunny.UI.UIButton();
            btnAddProduct = new Sunny.UI.UIButton();
            uiPanel12 = new Sunny.UI.UIPanel();
            btnMergeTable = new Button();
            btnSwitchTable = new Button();
            cbxMergeTable = new ComboBox();
            cboSwitchTable = new ComboBox();
            txtTotalPrice = new TextBox();
            btnPayment = new Sunny.UI.UIButton();
            label16 = new Label();
            btnBanSo = new Label();
            numSoLuong = new NumericUpDown();
            cbxMon = new Sunny.UI.UIComboBox();
            label14 = new Label();
            label1 = new Label();
            uiPanel1 = new Sunny.UI.UIPanel();
            flpTableLists = new FlowLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            uiPanel13.SuspendLayout();
            uiPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1382, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(dgvDetails);
            uiPanel2.Controls.Add(cboCategory);
            uiPanel2.Controls.Add(label13);
            uiPanel2.Controls.Add(uiPanel13);
            uiPanel2.Controls.Add(btnDeleteProduct);
            uiPanel2.Controls.Add(btnAddProduct);
            uiPanel2.Controls.Add(uiPanel12);
            uiPanel2.Controls.Add(btnBanSo);
            uiPanel2.Controls.Add(numSoLuong);
            uiPanel2.Controls.Add(cbxMon);
            uiPanel2.Controls.Add(label14);
            uiPanel2.Controls.Add(label1);
            uiPanel2.Dock = DockStyle.Right;
            uiPanel2.FillColor = Color.White;
            uiPanel2.FillColor2 = Color.Maroon;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel2.Location = new Point(454, 28);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 20;
            uiPanel2.RectColor = Color.Black;
            uiPanel2.Size = new Size(928, 875);
            uiPanel2.TabIndex = 3;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgvDetails
            // 
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Location = new Point(14, 206);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.RowHeadersWidth = 51;
            dgvDetails.Size = new Size(902, 419);
            dgvDetails.TabIndex = 13;
            // 
            // cboCategory
            // 
            cboCategory.DataSource = null;
            cboCategory.FillColor = Color.White;
            cboCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboCategory.ItemHoverColor = Color.Black;
            cboCategory.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboCategory.Location = new Point(14, 85);
            cboCategory.Margin = new Padding(4, 5, 4, 5);
            cboCategory.MinimumSize = new Size(63, 0);
            cboCategory.Name = "cboCategory";
            cboCategory.Padding = new Padding(0, 0, 30, 2);
            cboCategory.Radius = 0;
            cboCategory.RectColor = Color.Maroon;
            cboCategory.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            cboCategory.Size = new Size(177, 36);
            cboCategory.SymbolSize = 24;
            cboCategory.TabIndex = 7;
            cboCategory.TextAlignment = ContentAlignment.MiddleLeft;
            cboCategory.Watermark = "";
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Location = new Point(279, 43);
            label13.Name = "label13";
            label13.Size = new Size(159, 25);
            label13.TabIndex = 6;
            label13.Text = "Các loại đồ uống";
            // 
            // uiPanel13
            // 
            uiPanel13.Controls.Add(btnAddCustomer);
            uiPanel13.Controls.Add(label15);
            uiPanel13.Controls.Add(cbxCustomer);
            uiPanel13.FillColor = Color.White;
            uiPanel13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel13.Location = new Point(0, 131);
            uiPanel13.Margin = new Padding(4, 5, 4, 5);
            uiPanel13.MinimumSize = new Size(1, 1);
            uiPanel13.Name = "uiPanel13";
            uiPanel13.Radius = 0;
            uiPanel13.RectColor = Color.Black;
            uiPanel13.RectSides = ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Bottom;
            uiPanel13.Size = new Size(924, 67);
            uiPanel13.TabIndex = 12;
            uiPanel13.Text = null;
            uiPanel13.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(451, 15);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(214, 41);
            btnAddCustomer.TabIndex = 2;
            btnAddCustomer.Text = "Thêm mới khách hàng";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Location = new Point(33, 23);
            label15.Name = "label15";
            label15.Size = new Size(118, 25);
            label15.TabIndex = 1;
            label15.Text = "Khách hàng";
            // 
            // cbxCustomer
            // 
            cbxCustomer.FormattingEnabled = true;
            cbxCustomer.Location = new Point(167, 20);
            cbxCustomer.Name = "cbxCustomer";
            cbxCustomer.Size = new Size(246, 33);
            cbxCustomer.TabIndex = 0;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.FillColor = Color.FromArgb(192, 64, 0);
            btnDeleteProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDeleteProduct.Location = new Point(821, 71);
            btnDeleteProduct.MinimumSize = new Size(1, 1);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(61, 44);
            btnDeleteProduct.TabIndex = 11;
            btnDeleteProduct.Text = "Xóa";
            btnDeleteProduct.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.FillColor = Color.FromArgb(192, 64, 0);
            btnAddProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnAddProduct.Location = new Point(676, 71);
            btnAddProduct.MinimumSize = new Size(1, 1);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(125, 44);
            btnAddProduct.TabIndex = 10;
            btnAddProduct.Text = "Thêm món";
            btnAddProduct.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // uiPanel12
            // 
            uiPanel12.Controls.Add(btnMergeTable);
            uiPanel12.Controls.Add(btnSwitchTable);
            uiPanel12.Controls.Add(cbxMergeTable);
            uiPanel12.Controls.Add(cboSwitchTable);
            uiPanel12.Controls.Add(txtTotalPrice);
            uiPanel12.Controls.Add(btnPayment);
            uiPanel12.Controls.Add(label16);
            uiPanel12.FillColor = Color.White;
            uiPanel12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel12.Location = new Point(4, 633);
            uiPanel12.Margin = new Padding(4, 5, 4, 5);
            uiPanel12.MinimumSize = new Size(1, 1);
            uiPanel12.Name = "uiPanel12";
            uiPanel12.Radius = 0;
            uiPanel12.RectColor = Color.Black;
            uiPanel12.RectSides = ToolStripStatusLabelBorderSides.Top;
            uiPanel12.Size = new Size(916, 199);
            uiPanel12.TabIndex = 9;
            uiPanel12.Text = null;
            uiPanel12.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnMergeTable
            // 
            btnMergeTable.BackColor = Color.FromArgb(192, 255, 192);
            btnMergeTable.Location = new Point(231, 51);
            btnMergeTable.Name = "btnMergeTable";
            btnMergeTable.Size = new Size(139, 32);
            btnMergeTable.TabIndex = 8;
            btnMergeTable.Text = "Gộp bàn";
            btnMergeTable.UseVisualStyleBackColor = false;
            btnMergeTable.Click += btnMergeTable_Click;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.BackColor = Color.FromArgb(192, 255, 192);
            btnSwitchTable.Location = new Point(29, 51);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(149, 35);
            btnSwitchTable.TabIndex = 7;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = false;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // cbxMergeTable
            // 
            cbxMergeTable.FormattingEnabled = true;
            cbxMergeTable.Location = new Point(219, 12);
            cbxMergeTable.Name = "cbxMergeTable";
            cbxMergeTable.Size = new Size(151, 33);
            cbxMergeTable.TabIndex = 6;
            // 
            // cboSwitchTable
            // 
            cboSwitchTable.FormattingEnabled = true;
            cboSwitchTable.Location = new Point(29, 12);
            cboSwitchTable.Name = "cboSwitchTable";
            cboSwitchTable.Size = new Size(151, 33);
            cboSwitchTable.TabIndex = 5;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(712, 25);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(184, 30);
            txtTotalPrice.TabIndex = 2;
            // 
            // btnPayment
            // 
            btnPayment.FillColor = Color.Brown;
            btnPayment.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnPayment.Location = new Point(755, 80);
            btnPayment.MinimumSize = new Size(1, 1);
            btnPayment.Name = "btnPayment";
            btnPayment.Radius = 20;
            btnPayment.Size = new Size(125, 34);
            btnPayment.TabIndex = 1;
            btnPayment.Text = "Thanh toán";
            btnPayment.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnPayment.Click += btnPayment_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(595, 30);
            label16.Name = "label16";
            label16.Size = new Size(100, 25);
            label16.TabIndex = 0;
            label16.Text = "Tổng tiền:";
            // 
            // btnBanSo
            // 
            btnBanSo.AutoSize = true;
            btnBanSo.BackColor = Color.White;
            btnBanSo.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnBanSo.Location = new Point(790, 28);
            btnBanSo.Name = "btnBanSo";
            btnBanSo.Size = new Size(55, 29);
            btnBanSo.TabIndex = 8;
            btnBanSo.Text = "Bàn";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(576, 85);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(67, 30);
            numSoLuong.TabIndex = 6;
            // 
            // cbxMon
            // 
            cbxMon.DataSource = null;
            cbxMon.FillColor = Color.White;
            cbxMon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxMon.ItemHoverColor = Color.Black;
            cbxMon.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbxMon.Location = new Point(279, 79);
            cbxMon.Margin = new Padding(4, 5, 4, 5);
            cbxMon.MinimumSize = new Size(63, 0);
            cbxMon.Name = "cbxMon";
            cbxMon.Padding = new Padding(0, 0, 30, 2);
            cbxMon.Radius = 0;
            cbxMon.RectColor = Color.Maroon;
            cbxMon.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            cbxMon.Size = new Size(268, 36);
            cbxMon.SymbolSize = 24;
            cbxMon.TabIndex = 5;
            cbxMon.TextAlignment = ContentAlignment.MiddleLeft;
            cbxMon.Watermark = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Location = new Point(562, 43);
            label14.Name = "label14";
            label14.Size = new Size(90, 25);
            label14.TabIndex = 2;
            label14.Text = "Số lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(14, 41);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh mục đồ uống";
            label1.Click += label1_Click;
            // 
            // uiPanel1
            // 
            uiPanel1.BackColor = Color.White;
            uiPanel1.Controls.Add(flpTableLists);
            uiPanel1.Controls.Add(label3);
            uiPanel1.Controls.Add(label2);
            uiPanel1.Controls.Add(pictureBox1);
            uiPanel1.Dock = DockStyle.Left;
            uiPanel1.FillColor = Color.White;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel1.Location = new Point(0, 28);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 20;
            uiPanel1.RectColor = Color.Black;
            uiPanel1.Size = new Size(1382, 875);
            uiPanel1.TabIndex = 2;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // flpTableLists
            // 
            flpTableLists.Location = new Point(12, 119);
            flpTableLists.Name = "flpTableLists";
            flpTableLists.Size = new Size(435, 732);
            flpTableLists.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(441, 25);
            label3.TabIndex = 4;
            label3.Text = "_______________________________________";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(129, 28);
            label2.Name = "label2";
            label2.Size = new Size(254, 40);
            label2.TabIndex = 3;
            label2.Text = "Mornin Cafe";
            label2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.icon_Cafe;
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // MenuBanForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1382, 903);
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuBanForm";
            Text = "Đặt món theo bàn";
            Load += MenuBanForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            uiPanel2.ResumeLayout(false);
            uiPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            uiPanel13.ResumeLayout(false);
            uiPanel13.PerformLayout();
            uiPanel12.ResumeLayout(false);
            uiPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel4;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label14;
        private Label label1;
        private NumericUpDown numSoLuong;
        private Sunny.UI.UIComboBox cbxMon;
        private Sunny.UI.UIPanel uiPanel12;
        private Label btnBanSo;
        private Sunny.UI.UIButton btnPayment;
        private Label label16;
        private Sunny.UI.UIButton btnDeleteProduct;
        private Sunny.UI.UIButton btnAddProduct;
        private TextBox txtTotalPrice;
        private Sunny.UI.UIPanel uiPanel13;
        private Label label9;
        private PictureBox pictureBox7;
        private Sunny.UI.UIPanel uiPanel8;
        private Label label8;
        private PictureBox pictureBox6;
        private Sunny.UI.UIPanel uiPanel7;
        private Label label7;
        private PictureBox pictureBox5;
        private Sunny.UI.UIPanel uiPanel6;
        private Label label5;
        private PictureBox pictureBox4;
        private Sunny.UI.UIPanel uiPanel5;
        private Label label4;
        private PictureBox pictureBox2;
        private Sunny.UI.UIPanel uiPanel3;
        private Label label10;
        private PictureBox pictureBox8;
        private Sunny.UI.UIPanel uiPanel9;
        private Label label11;
        private PictureBox pictureBox9;
        private Sunny.UI.UIPanel uiPanel10;
        private Label label12;
        private PictureBox pictureBox10;
        private Sunny.UI.UIPanel uiPanel11;
        private FlowLayoutPanel flpTableLists;
        private Sunny.UI.UIComboBox cboCategory;
        private Label label13;
        private ComboBox cbxMergeTable;
        private ComboBox cboSwitchTable;
        private Button btnMergeTable;
        private Button btnSwitchTable;
        private DataGridView dgvDetails;
        private Label label15;
        private ComboBox cbxCustomer;
        private Button btnAddCustomer;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}