namespace BTL_WINFORM.Forms
{
    partial class DangKyForm
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
            components = new System.ComponentModel.Container();
            btnSignIn = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            label5 = new Label();
            txtConfirmPassword = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            chkShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(255, 224, 192);
            btnSignIn.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignIn.Location = new Point(506, 423);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(255, 54);
            btnSignIn.TabIndex = 28;
            btnSignIn.Text = "Đăng Ký";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(507, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(283, 27);
            txtPassword.TabIndex = 26;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(508, 231);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 25;
            label4.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(505, 179);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(283, 27);
            txtUsername.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(507, 148);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 23;
            label3.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(578, 9);
            label2.Name = "label2";
            label2.Size = new Size(150, 50);
            label2.TabIndex = 22;
            label2.Text = "ĐĂNG KÝ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_removebg_preview__2_;
            pictureBox1.Location = new Point(-49, -39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(634, 601);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(506, 92);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(283, 27);
            txtUser.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(506, 61);
            label5.Name = "label5";
            label5.Size = new Size(50, 28);
            label5.TabIndex = 32;
            label5.Text = "Tên:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(507, 355);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(283, 27);
            txtConfirmPassword.TabIndex = 34;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(506, 324);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 35;
            label1.Text = "NHẬP LẠI MẬT KHẨU:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(508, 295);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(127, 24);
            chkShowPassword.TabIndex = 36;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // DangKyForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(853, 515);
            Controls.Add(chkShowPassword);
            Controls.Add(label1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtUser);
            Controls.Add(label5);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "DangKyForm";
            Text = "DangKyForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSignIn;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtUser;
        private Label label5;
        private TextBox txtConfirmPassword;
        private Label label1;
        private ErrorProvider errorProvider1;
        private CheckBox chkShowPassword;
    }
}