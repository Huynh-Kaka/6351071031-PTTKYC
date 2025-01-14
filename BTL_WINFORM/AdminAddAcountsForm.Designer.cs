namespace BTL_WINFORM
{
    partial class AdminAddAcountsForm
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
            panel4 = new Panel();
            label5 = new Label();
            txtAccountID = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            cbxRole = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnSave = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panel2 = new Panel();
            dgvAccounts = new DataGridView();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 704);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtAccountID);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtUserName);
            panel4.Controls.Add(cbxRole);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtPassword);
            panel4.Location = new Point(18, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 256);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(5, 18);
            label5.Name = "label5";
            label5.Size = new Size(96, 24);
            label5.TabIndex = 10;
            label5.Text = "Account ID:";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(113, 15);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(151, 27);
            txtAccountID.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(5, 73);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(113, 73);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(151, 27);
            txtUserName.TabIndex = 3;
            // 
            // cbxRole
            // 
            cbxRole.FormattingEnabled = true;
            cbxRole.Location = new Point(113, 195);
            cbxRole.Name = "cbxRole";
            cbxRole.Size = new Size(151, 28);
            cbxRole.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(5, 131);
            label3.Name = "label3";
            label3.Size = new Size(87, 24);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(44, 195);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 6;
            label4.Text = "Role:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(113, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(151, 27);
            txtPassword.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_admin;
            pictureBox1.Location = new Point(101, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnDelete);
            panel3.Location = new Point(18, 413);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 288);
            panel3.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(29, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(67, 60);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(186, 115);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(97, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(52, 60);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(186, 20);
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
            btnDelete.Location = new Point(29, 115);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvAccounts);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(397, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 704);
            panel2.TabIndex = 1;
            // 
            // dgvAccounts
            // 
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(22, 58);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.RowHeadersWidth = 51;
            dgvAccounts.Size = new Size(789, 628);
            dgvAccounts.TabIndex = 1;
            dgvAccounts.CellClick += dgvAccounts_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 13);
            label1.Name = "label1";
            label1.Size = new Size(143, 23);
            label1.TabIndex = 0;
            label1.Text = "Data of Users";
            // 
            // AdminAddAcountsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddAcountsForm";
            Size = new Size(1250, 740);
            Load += AdminAddAcountsForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dgvAccounts;
        private BindingSource bindingSource1;
        private TextBox txtUserName;
        private Label label2;
        private Label label4;
        private TextBox txtPassword;
        private Label label3;
        private Panel panel3;
        private ComboBox cbxRole;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label5;
        private TextBox txtAccountID;
        private Button btnSave;
    }
}
