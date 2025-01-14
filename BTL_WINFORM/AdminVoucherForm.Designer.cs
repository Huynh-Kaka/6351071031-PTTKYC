namespace BTL_WINFORM
{
    partial class AdminVoucherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminVoucherForm));
            uiPanel1 = new Sunny.UI.UIPanel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label12 = new Label();
            dtpNgayHetHan = new DateTimePicker();
            chkTrangThaiHD = new CheckBox();
            dtpNgayBatDau = new DateTimePicker();
            cbxLoaiGiamGia = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtMaVoucher = new TextBox();
            txtGiaTriDonHangToiThieu = new TextBox();
            txtSoLanToiDaSuDung = new TextBox();
            txtGiaTriGiam = new TextBox();
            btnSave = new Button();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.BackColor = Color.White;
            uiPanel1.Controls.Add(label2);
            uiPanel1.Controls.Add(pictureBox2);
            uiPanel1.Controls.Add(label4);
            uiPanel1.Controls.Add(label3);
            uiPanel1.Controls.Add(pictureBox1);
            uiPanel1.FillColor = Color.Bisque;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel1.Location = new Point(18, 11);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(458, 744);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(38, 22);
            label2.Name = "label2";
            label2.Size = new Size(151, 39);
            label2.TabIndex = 5;
            label2.Text = "Voucher";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Bisque;
            pictureBox2.Image = Properties.Resources.icons8_play_100;
            pictureBox2.Location = new Point(145, 558);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Bisque;
            label4.Location = new Point(60, 404);
            label4.Name = "label4";
            label4.Size = new Size(343, 50);
            label4.TabIndex = 1;
            label4.Text = "Chỉnh sửa các quy định, thông số của \r\n                    quán Coffee\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Bisque;
            label3.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 360);
            label3.Name = "label3";
            label3.Size = new Size(224, 31);
            label3.TabIndex = 1;
            label3.Text = "Thay đổi quy định";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(127, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(dtpNgayHetHan);
            panel1.Controls.Add(chkTrangThaiHD);
            panel1.Controls.Add(dtpNgayBatDau);
            panel1.Controls.Add(cbxLoaiGiamGia);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaVoucher);
            panel1.Controls.Add(txtGiaTriDonHangToiThieu);
            panel1.Controls.Add(txtSoLanToiDaSuDung);
            panel1.Controls.Add(txtGiaTriGiam);
            panel1.Controls.Add(btnSave);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(483, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 744);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10.8F);
            label12.Location = new Point(352, 416);
            label12.Name = "label12";
            label12.Size = new Size(120, 21);
            label12.TabIndex = 17;
            label12.Text = "Ngày kết thúc";
            // 
            // dtpNgayHetHan
            // 
            dtpNgayHetHan.Font = new Font("Arial", 10.8F);
            dtpNgayHetHan.Location = new Point(355, 440);
            dtpNgayHetHan.Name = "dtpNgayHetHan";
            dtpNgayHetHan.Size = new Size(310, 28);
            dtpNgayHetHan.TabIndex = 16;
            // 
            // chkTrangThaiHD
            // 
            chkTrangThaiHD.AutoSize = true;
            chkTrangThaiHD.Font = new Font("Arial", 10.8F);
            chkTrangThaiHD.Location = new Point(367, 360);
            chkTrangThaiHD.Name = "chkTrangThaiHD";
            chkTrangThaiHD.Size = new Size(115, 25);
            chkTrangThaiHD.TabIndex = 15;
            chkTrangThaiHD.Text = "Hoạt động";
            chkTrangThaiHD.UseVisualStyleBackColor = true;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Font = new Font("Arial", 10.8F);
            dtpNgayBatDau.Location = new Point(50, 440);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(250, 28);
            dtpNgayBatDau.TabIndex = 14;
            // 
            // cbxLoaiGiamGia
            // 
            cbxLoaiGiamGia.Font = new Font("Arial", 10.8F);
            cbxLoaiGiamGia.FormattingEnabled = true;
            cbxLoaiGiamGia.Items.AddRange(new object[] { "Phần trăm", "Tiền" });
            cbxLoaiGiamGia.Location = new Point(50, 197);
            cbxLoaiGiamGia.Name = "cbxLoaiGiamGia";
            cbxLoaiGiamGia.Size = new Size(247, 29);
            cbxLoaiGiamGia.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10.8F);
            label11.Location = new Point(50, 417);
            label11.Name = "label11";
            label11.Size = new Size(122, 21);
            label11.TabIndex = 12;
            label11.Text = "Ngày bắt đầu:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.8F);
            label10.Location = new Point(367, 334);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 11;
            label10.Text = "Trạng thái";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.8F);
            label9.Location = new Point(49, 334);
            label9.Name = "label9";
            label9.Size = new Size(145, 21);
            label9.TabIndex = 10;
            label9.Text = "Giá trị đơn hàng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F);
            label8.Location = new Point(48, 173);
            label8.Name = "label8";
            label8.Size = new Size(121, 21);
            label8.TabIndex = 9;
            label8.Text = "Loại giảm giá:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F);
            label7.Location = new Point(352, 253);
            label7.Name = "label7";
            label7.Size = new Size(186, 21);
            label7.TabIndex = 8;
            label7.Text = "Số lần tối đa sử dụng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F);
            label6.Location = new Point(47, 252);
            label6.Name = "label6";
            label6.Size = new Size(106, 21);
            label6.TabIndex = 7;
            label6.Text = "Giá trị giảm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F);
            label5.Location = new Point(51, 96);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 6;
            label5.Text = "Mã voucher:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(50, 22);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 5;
            label1.Text = "Quy đinh";
            // 
            // txtMaVoucher
            // 
            txtMaVoucher.Font = new Font("Arial", 10.8F);
            txtMaVoucher.Location = new Point(51, 119);
            txtMaVoucher.Name = "txtMaVoucher";
            txtMaVoucher.Size = new Size(247, 28);
            txtMaVoucher.TabIndex = 4;
            // 
            // txtGiaTriDonHangToiThieu
            // 
            txtGiaTriDonHangToiThieu.Font = new Font("Arial", 10.8F);
            txtGiaTriDonHangToiThieu.Location = new Point(50, 357);
            txtGiaTriDonHangToiThieu.Name = "txtGiaTriDonHangToiThieu";
            txtGiaTriDonHangToiThieu.Size = new Size(248, 28);
            txtGiaTriDonHangToiThieu.TabIndex = 3;
            // 
            // txtSoLanToiDaSuDung
            // 
            txtSoLanToiDaSuDung.Font = new Font("Arial", 10.8F);
            txtSoLanToiDaSuDung.Location = new Point(352, 276);
            txtSoLanToiDaSuDung.Name = "txtSoLanToiDaSuDung";
            txtSoLanToiDaSuDung.Size = new Size(203, 28);
            txtSoLanToiDaSuDung.TabIndex = 2;
            // 
            // txtGiaTriGiam
            // 
            txtGiaTriGiam.Font = new Font("Arial", 10.8F);
            txtGiaTriGiam.Location = new Point(48, 276);
            txtGiaTriGiam.Name = "txtGiaTriGiam";
            txtGiaTriGiam.Size = new Size(247, 28);
            txtGiaTriGiam.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(486, 575);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 49);
            btnSave.TabIndex = 0;
            btnSave.Text = "Cập nhật";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AdminVoucherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(uiPanel1);
            Name = "AdminVoucherForm";
            Size = new Size(1259, 840);
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button btnSave;
        private DateTimePicker dtpNgayBatDau;
        private ComboBox cbxLoaiGiamGia;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private TextBox txtMaVoucher;
        private TextBox txtGiaTriDonHangToiThieu;
        private TextBox txtSoLanToiDaSuDung;
        private TextBox txtGiaTriGiam;
        private Label label12;
        private DateTimePicker dtpNgayHetHan;
        private CheckBox chkTrangThaiHD;
    }
}
