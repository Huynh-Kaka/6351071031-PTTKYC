

namespace BTL_WINFORM
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnSignIn = new Button();
            chkShowPassword = new CheckBox();
            txtPassword = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbldangKy = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(255, 224, 192);
            btnSignIn.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignIn.Location = new Point(531, 368);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(240, 43);
            btnSignIn.TabIndex = 17;
            btnSignIn.Text = "Đăng nhập";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            chkShowPassword.Location = new Point(514, 319);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(150, 27);
            chkShowPassword.TabIndex = 16;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(509, 280);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(283, 27);
            txtPassword.TabIndex = 15;
            txtPassword.Text = "123";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(509, 247);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 14;
            label4.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(514, 184);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(283, 27);
            txtUsername.TabIndex = 13;
            txtUsername.Text = "huynh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(514, 143);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 12;
            label3.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(562, 46);
            label2.Name = "label2";
            label2.Size = new Size(195, 41);
            label2.TabIndex = 11;
            label2.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_removebg_preview__2_;
            pictureBox1.Location = new Point(-37, -45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(593, 575);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(531, 414);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 20;
            label1.Text = "Bạn chưa có tài khoản?";
            label1.Click += label1_Click;
            // 
            // lbldangKy
            // 
            lbldangKy.AutoSize = true;
            lbldangKy.ForeColor = Color.FromArgb(255, 192, 128);
            lbldangKy.Location = new Point(694, 414);
            lbldangKy.Name = "lbldangKy";
            lbldangKy.Size = new Size(63, 20);
            lbldangKy.TabIndex = 21;
            lbldangKy.Text = "Đăng ký";
            lbldangKy.Click += lbldangKy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(845, 479);
            Controls.Add(lbldangKy);
            Controls.Add(label1);
            Controls.Add(btnSignIn);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "fLogin";
            Text = "Đăng nhập";
            Load += fLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            // Implement the logic for loading the form
        }

        #endregion

        private Button btnSignIn;
        private CheckBox chkShowPassword;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbldangKy;
        private ErrorProvider errorProvider1;
    }
}
