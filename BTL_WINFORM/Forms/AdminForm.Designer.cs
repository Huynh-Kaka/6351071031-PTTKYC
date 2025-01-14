namespace BTL_WINFORM.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panel1 = new Panel();
            pixClose = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnAccount = new Button();
            btnCategory = new Button();
            btnVoucher = new Button();
            btnMenu = new Button();
            btnLogout = new Button();
            btnStaff = new Button();
            btnAddProduct = new Button();
            btnDashboard = new Button();
            label4 = new Label();
            label3 = new Label();
            lblTen = new Label();
            pictureBox2 = new PictureBox();
            panelData = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pixClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pixClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1550, 59);
            panel1.TabIndex = 0;
            // 
            // pixClose
            // 
            pixClose.Image = Properties.Resources.icon_X;
            pixClose.Location = new Point(1457, 3);
            pixClose.Name = "pixClose";
            pixClose.Size = new Size(40, 40);
            pixClose.SizeMode = PictureBoxSizeMode.Zoom;
            pixClose.TabIndex = 2;
            pixClose.TabStop = false;
            pixClose.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_Cafe;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(64, 3);
            label1.Name = "label1";
            label1.Size = new Size(254, 40);
            label1.TabIndex = 0;
            label1.Text = "Mornin Cafe";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(btnAccount);
            panel2.Controls.Add(btnCategory);
            panel2.Controls.Add(btnVoucher);
            panel2.Controls.Add(btnMenu);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnStaff);
            panel2.Controls.Add(btnAddProduct);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblTen);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 841);
            panel2.TabIndex = 1;
            // 
            // btnAccount
            // 
            btnAccount.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccount.ForeColor = Color.White;
            btnAccount.Image = Properties.Resources.image_removebg_preview__1_;
            btnAccount.Location = new Point(46, 431);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(204, 45);
            btnAccount.TabIndex = 12;
            btnAccount.Text = "Tài khoản";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnCategory
            // 
            btnCategory.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnCategory.Image = Properties.Resources.image_removebg_preview__1_;
            btnCategory.Location = new Point(46, 354);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(204, 45);
            btnCategory.TabIndex = 11;
            btnCategory.Text = "Loại sản phẩm";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnVoucher
            // 
            btnVoucher.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoucher.ForeColor = Color.White;
            btnVoucher.Image = Properties.Resources.image_removebg_preview__1_;
            btnVoucher.Location = new Point(46, 589);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(204, 45);
            btnVoucher.TabIndex = 10;
            btnVoucher.Text = "Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            btnVoucher.Click += btnVoucher_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnMenu.Image = Properties.Resources.image_removebg_preview__1_;
            btnMenu.Location = new Point(46, 661);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(204, 45);
            btnMenu.TabIndex = 9;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 192, 128);
            btnLogout.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(46, 764);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(226, 52);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "   Đăng xuất";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnStaff.Image = Properties.Resources.image_removebg_preview__1_;
            btnStaff.Location = new Point(46, 507);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(204, 45);
            btnStaff.TabIndex = 7;
            btnStaff.Text = "Nhân viên ";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAddProduct.Image = Properties.Resources.image_removebg_preview__1_;
            btnAddProduct.Location = new Point(46, 270);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(204, 45);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "Sản phẩm";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDashboard.Image = Properties.Resources.image_removebg_preview__1_;
            btnDashboard.Location = new Point(46, 195);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(204, 45);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Thống kê";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(151, 120);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 5;
            label4.Text = "ADMIN";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(63, 120);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 4;
            label3.Text = "Chức năng";
            // 
            // lblTen
            // 
            lblTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTen.Location = new Point(99, 85);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(109, 25);
            lblTen.TabIndex = 3;
            lblTen.Text = "ADMIN'KAKA";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icon_admin;
            pictureBox2.Location = new Point(83, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panelData
            // 
            panelData.Dock = DockStyle.Fill;
            panelData.Location = new Point(290, 59);
            panelData.Name = "panelData";
            panelData.Size = new Size(1260, 841);
            panelData.TabIndex = 2;
            panelData.Paint += panelData_Paint;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1550, 900);
            Controls.Add(panelData);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            Text = "MenuForm";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pixClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblTen;
        private PictureBox pictureBox2;
        private Button btnDashboard;
        private Label label4;
        private Label label3;
        private Button btnMenu;
        private Button btnLogout;
        private Button btnStaff;
        private Button btnAddProduct;
        private PictureBox pixClose;
        private Panel panelData;
        private Button btnVoucher;
        private Button btnCategory;
        private Button btnAccount;
    }
}