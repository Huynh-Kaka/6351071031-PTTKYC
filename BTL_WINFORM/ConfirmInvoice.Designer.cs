namespace BTL_WINFORM
{
    partial class ConfirmInvoice
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
            panel1 = new Panel();
            txtfinalAmount = new TextBox();
            label3 = new Label();
            txtVoucher = new TextBox();
            label1 = new Label();
            btnThoat = new Button();
            txtTienKhach = new TextBox();
            btnConfirm = new Button();
            txtTotalAmount = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtTienThua = new TextBox();
            cbxPaymentMethod = new ComboBox();
            label5 = new Label();
            txtOrderID = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtfinalAmount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtVoucher);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(txtTienKhach);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(txtTotalAmount);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtTienThua);
            panel1.Controls.Add(cbxPaymentMethod);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtOrderID);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(56, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 617);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtfinalAmount
            // 
            txtfinalAmount.Font = new Font("Segoe UI", 10.8F);
            txtfinalAmount.Location = new Point(276, 311);
            txtfinalAmount.Name = "txtfinalAmount";
            txtfinalAmount.Size = new Size(210, 31);
            txtfinalAmount.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(87, 317);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 22;
            label3.Text = "Tổng thanh toán";
            // 
            // txtVoucher
            // 
            txtVoucher.Font = new Font("Segoe UI", 10.8F);
            txtVoucher.Location = new Point(276, 264);
            txtVoucher.Name = "txtVoucher";
            txtVoucher.Size = new Size(210, 31);
            txtVoucher.TabIndex = 21;
            //txtVoucher.TextChanged += txtVoucher_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(86, 267);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 20;
            label1.Text = "Voucher";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 128, 128);
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(467, 552);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(121, 47);
            btnThoat.TabIndex = 19;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTienKhach
            // 
            txtTienKhach.Font = new Font("Segoe UI", 10.8F);
            txtTienKhach.Location = new Point(276, 434);
            txtTienKhach.Name = "txtTienKhach";
            txtTienKhach.Size = new Size(210, 31);
            txtTienKhach.TabIndex = 18;
            txtTienKhach.TextChanged += txtTienKhach_TextChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(128, 255, 128);
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(318, 552);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(111, 47);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 10.8F);
            txtTotalAmount.Location = new Point(276, 202);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(210, 31);
            txtTotalAmount.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(55, 440);
            label8.Name = "label8";
            label8.Size = new Size(131, 25);
            label8.TabIndex = 17;
            label8.Text = "Tiền khách đưa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(87, 208);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 15;
            label7.Text = "Tổng tiền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(147, 28);
            label6.Name = "label6";
            label6.Size = new Size(263, 38);
            label6.TabIndex = 14;
            label6.Text = " Xác nhận hóa đơn";
            // 
            // txtTienThua
            // 
            txtTienThua.Font = new Font("Segoe UI", 10.8F);
            txtTienThua.Location = new Point(276, 492);
            txtTienThua.Name = "txtTienThua";
            txtTienThua.Size = new Size(210, 31);
            txtTienThua.TabIndex = 8;
            // 
            // cbxPaymentMethod
            // 
            cbxPaymentMethod.Font = new Font("Segoe UI", 10.8F);
            cbxPaymentMethod.FormattingEnabled = true;
            cbxPaymentMethod.Location = new Point(276, 379);
            cbxPaymentMethod.Name = "cbxPaymentMethod";
            cbxPaymentMethod.Size = new Size(210, 33);
            cbxPaymentMethod.TabIndex = 13;
            cbxPaymentMethod.SelectedIndexChanged += cbxPaymentMethodd_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(54, 498);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 4;
            label5.Text = "Tiền Thừa";
            // 
            // txtOrderID
            // 
            txtOrderID.Font = new Font("Segoe UI", 10.8F);
            txtOrderID.Location = new Point(276, 151);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(210, 31);
            txtOrderID.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(54, 387);
            label4.Name = "label4";
            label4.Size = new Size(206, 25);
            label4.TabIndex = 3;
            label4.Text = "Phương thức thanh toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(55, 151);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã đơn hàng";
            // 
            // ConfirmInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 623);
            Controls.Add(panel1);
            Name = "ConfirmInvoice";
            Text = "ComfirmInvoice";
            Load += ConfirmInvoice_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbxPaymentMethod;
        private TextBox txtOrderID;
        private TextBox txtTienThua;
        private Button btnConfirm;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button btnThoat;
        private TextBox txtTienKhach;
        private TextBox txtTotalAmount;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtVoucher;
        private Label label1;
        private TextBox txtfinalAmount;
        private Label label3;
    }
}