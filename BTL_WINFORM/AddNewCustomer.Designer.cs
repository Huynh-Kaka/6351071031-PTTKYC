﻿namespace BTL_WINFORM
{
    partial class AddNewCustomer
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
            panel3 = new Panel();
            btnOut = new Sunny.UI.UIButton();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSave = new Sunny.UI.UIButton();
            label3 = new Label();
            txtFullName = new Sunny.UI.UITextBox();
            txtPhone = new Sunny.UI.UITextBox();
            label2 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnOut);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtFullName);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 426);
            panel3.TabIndex = 10;
            panel3.Paint += panel3_Paint;
            // 
            // btnOut
            // 
            btnOut.FillColor = Color.LimeGreen;
            btnOut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnOut.Location = new Point(548, 308);
            btnOut.MinimumSize = new Size(1, 1);
            btnOut.Name = "btnOut";
            btnOut.Radius = 30;
            btnOut.Size = new Size(125, 44);
            btnOut.TabIndex = 1;
            btnOut.Text = "Thoát";
            btnOut.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnOut.Click += btnOut_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 143);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(129, 42);
            label1.Name = "label1";
            label1.Size = new Size(310, 32);
            label1.TabIndex = 1;
            label1.Text = "Thông tin khách hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_staff;
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.FillColor = Color.Brown;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSave.Location = new Point(369, 308);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 30;
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Lưu";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(192, 64, 0);
            label3.Location = new Point(441, 160);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 4;
            label3.Text = "SĐT:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtFullName.Location = new Point(25, 193);
            txtFullName.Margin = new Padding(4, 5, 4, 5);
            txtFullName.MinimumSize = new Size(1, 16);
            txtFullName.Name = "txtFullName";
            txtFullName.Padding = new Padding(5);
            txtFullName.Radius = 30;
            txtFullName.RectColor = Color.FromArgb(255, 192, 128);
            txtFullName.ShowText = false;
            txtFullName.Size = new Size(250, 37);
            txtFullName.TabIndex = 3;
            txtFullName.TextAlignment = ContentAlignment.MiddleLeft;
            txtFullName.Watermark = "";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPhone.Location = new Point(423, 193);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.MinimumSize = new Size(1, 16);
            txtPhone.Name = "txtPhone";
            txtPhone.Padding = new Padding(5);
            txtPhone.Radius = 30;
            txtPhone.RectColor = Color.FromArgb(255, 192, 128);
            txtPhone.ShowText = false;
            txtPhone.Size = new Size(250, 37);
            txtPhone.TabIndex = 5;
            txtPhone.TextAlignment = ContentAlignment.MiddleLeft;
            txtPhone.Watermark = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(38, 160);
            label2.Name = "label2";
            label2.Size = new Size(49, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên:";
            // 
            // AddNewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Name = "AddNewCustomer";
            Text = "AddNewCustomer";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Sunny.UI.UIButton btnOut;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Sunny.UI.UIButton btnSave;
        private Label label3;
        private Sunny.UI.UITextBox txtFullName;
        private Sunny.UI.UITextBox txtPhone;
        private Label label2;
    }
}