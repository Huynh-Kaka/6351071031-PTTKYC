namespace BTL_WINFORM
{
    partial class AdminAddProductsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            dgvDataProduct = new DataGridView();
            panel2 = new Panel();
            btnaddpicter = new Button();
            cbCategory = new ComboBox();
            nudPrice = new NumericUpDown();
            panel4 = new Panel();
            label7 = new Label();
            lblSoSP = new Label();
            label5 = new Label();
            txtTimKiem = new TextBox();
            label10 = new Label();
            lbltenanh = new Label();
            txtIDProduct = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnSave = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            txtProductName = new TextBox();
            cntRemoOrUpdate = new ContextMenuStrip(components);
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataProduct).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            cntRemoOrUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvDataProduct);
            panel1.Location = new Point(19, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 414);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(29, 16);
            label1.Name = "label1";
            label1.Size = new Size(174, 23);
            label1.TabIndex = 1;
            label1.Text = "Data of Products";
            // 
            // dgvDataProduct
            // 
            dgvDataProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataProduct.Location = new Point(20, 42);
            dgvDataProduct.Name = "dgvDataProduct";
            dgvDataProduct.RowHeadersWidth = 51;
            dgvDataProduct.Size = new Size(1178, 358);
            dgvDataProduct.TabIndex = 2;
            dgvDataProduct.CellClick += dgvDataProduct_CellClick;
            dgvDataProduct.CellContentClick += dgvDataProduct_CellContentClick;
            dgvDataProduct.MouseUp += dgvDataProduct_MouseUp;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnaddpicter);
            panel2.Controls.Add(cbCategory);
            panel2.Controls.Add(nudPrice);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lbltenanh);
            panel2.Controls.Add(txtIDProduct);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtProductName);
            panel2.Location = new Point(22, 455);
            panel2.Name = "panel2";
            panel2.Size = new Size(1208, 282);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnaddpicter
            // 
            btnaddpicter.BackColor = Color.FromArgb(128, 255, 128);
            btnaddpicter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnaddpicter.Location = new Point(1067, 139);
            btnaddpicter.Name = "btnaddpicter";
            btnaddpicter.Size = new Size(106, 29);
            btnaddpicter.TabIndex = 32;
            btnaddpicter.Text = "add img";
            btnaddpicter.UseVisualStyleBackColor = false;
            btnaddpicter.Click += btnaddpicter_Click;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(845, 33);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 31;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(846, 84);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(150, 27);
            nudPrice.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lblSoSP);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtTimKiem);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(13, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(329, 125);
            panel4.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(74, 76);
            label7.Name = "label7";
            label7.Size = new Size(87, 23);
            label7.TabIndex = 4;
            label7.Text = "sản phẩm";
            // 
            // lblSoSP
            // 
            lblSoSP.AutoSize = true;
            lblSoSP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSoSP.ForeColor = SystemColors.ActiveCaptionText;
            lblSoSP.Location = new Point(46, 76);
            lblSoSP.Name = "lblSoSP";
            lblSoSP.Size = new Size(40, 23);
            lblSoSP.TabIndex = 3;
            lblSoSP.Text = "100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(15, 76);
            label5.Name = "label5";
            label5.Size = new Size(36, 23);
            label5.TabIndex = 2;
            label5.Text = "Có:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(15, 39);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(294, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(192, 255, 255);
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label10.Location = new Point(15, 11);
            label10.Name = "label10";
            label10.Size = new Size(84, 25);
            label10.TabIndex = 0;
            label10.Text = "Tìm kiếm";
            // 
            // lbltenanh
            // 
            lbltenanh.AutoSize = true;
            lbltenanh.BackColor = Color.FromArgb(192, 255, 192);
            lbltenanh.ForeColor = Color.FromArgb(64, 64, 64);
            lbltenanh.Location = new Point(1090, 103);
            lbltenanh.Name = "lbltenanh";
            lbltenanh.Size = new Size(58, 20);
            lbltenanh.TabIndex = 28;
            lbltenanh.Text = "ten anh";
            // 
            // txtIDProduct
            // 
            txtIDProduct.BackColor = Color.White;
            txtIDProduct.ForeColor = SystemColors.ActiveCaptionText;
            txtIDProduct.Location = new Point(525, 28);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.Size = new Size(192, 27);
            txtIDProduct.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(378, 40);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 13;
            label2.Text = "Product ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_Cafe;
            pictureBox1.Location = new Point(1067, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnAdd);
            panel3.Location = new Point(13, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(1178, 103);
            panel3.TabIndex = 12;
            panel3.Click += panel3_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(333, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 60);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(863, 20);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(512, 20);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(678, 20);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(149, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 60);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(751, 84);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 17;
            label4.Text = "Price $:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(378, 84);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 15;
            label3.Text = "Product Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(751, 40);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 21;
            label6.Text = "Type:";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.White;
            txtProductName.ForeColor = SystemColors.ActiveCaptionText;
            txtProductName.Location = new Point(525, 78);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(192, 27);
            txtProductName.TabIndex = 16;
            // 
            // cntRemoOrUpdate
            // 
            cntRemoOrUpdate.ImageScalingSize = new Size(20, 20);
            cntRemoOrUpdate.Items.AddRange(new ToolStripItem[] { updateToolStripMenuItem, deleteToolStripMenuItem1 });
            cntRemoOrUpdate.Name = "contextMenuStrip";
            cntRemoOrUpdate.Size = new Size(128, 52);
            cntRemoOrUpdate.ItemClicked += cntRemoOrUpdate_ItemClicked;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(127, 24);
            updateToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(127, 24);
            deleteToolStripMenuItem1.Text = "Delete";
            // 
            // AdminAddProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddProductsForm";
            Size = new Size(1250, 740);
            Load += AdminAddProductsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataProduct).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            cntRemoOrUpdate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvDataProduct;
        private Label label1;
        private Panel panel3;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label label4;
        private TextBox txtProductName;
        private Label label3;
        private TextBox txtIDProduct;
        private Label label2;
        private Label label6;
        private PictureBox pictureBox1;
        private Label lbltenanh;
        private Panel panel4;
        private TextBox txtTimKiem;
        private Label label10;
        private ComboBox cbCategory;
        private NumericUpDown nudPrice;
        private Button btnaddpicter;
        private ContextMenuStrip cntRemoOrUpdate;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private Button btnSave;
        private Label label7;
        private Label lblSoSP;
        private Label label5;
    }
}
