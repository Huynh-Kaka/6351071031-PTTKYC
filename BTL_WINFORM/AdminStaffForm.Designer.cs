namespace BTL_WINFORM
{
    partial class AdminStaffForm
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
            panel2 = new Panel();
            txtTimkiem = new Sunny.UI.UITextBox();
            label2 = new Label();
            label1 = new Label();
            dgvDataStaff = new DataGridView();
            panel3 = new Panel();
            cmbAccount = new ComboBox();
            lblAccountID = new Label();
            txtSalary = new TextBox();
            txtPosition = new TextBox();
            label3 = new Label();
            dtpDateOfJoining = new DateTimePicker();
            cmbStatus = new ComboBox();
            label4 = new Label();
            txtIDStaff = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtFullName = new TextBox();
            panel4 = new Panel();
            btnSave = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            đổiAcToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataStaff).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(19, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 103);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTimkiem);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(673, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 75);
            panel2.TabIndex = 4;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(241, 24);
            txtTimkiem.Margin = new Padding(4, 5, 4, 5);
            txtTimkiem.MinimumSize = new Size(1, 16);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Padding = new Padding(5);
            txtTimkiem.Radius = 30;
            txtTimkiem.RectColor = Color.FromArgb(255, 192, 128);
            txtTimkiem.ShowText = false;
            txtTimkiem.Size = new Size(250, 37);
            txtTimkiem.TabIndex = 11;
            txtTimkiem.TextAlignment = ContentAlignment.MiddleLeft;
            txtTimkiem.Watermark = "";
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.White;
            label2.Location = new Point(137, 33);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 3;
            label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(109, 31);
            label1.TabIndex = 0;
            label1.Text = "Staff List";
            // 
            // dgvDataStaff
            // 
            dgvDataStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataStaff.Location = new Point(19, 127);
            dgvDataStaff.Name = "dgvDataStaff";
            dgvDataStaff.RowHeadersWidth = 51;
            dgvDataStaff.Size = new Size(1208, 348);
            dgvDataStaff.TabIndex = 1;
            dgvDataStaff.CellContentClick += dgvDataStaff_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cmbAccount);
            panel3.Controls.Add(lblAccountID);
            panel3.Controls.Add(txtSalary);
            panel3.Controls.Add(txtPosition);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dtpDateOfJoining);
            panel3.Controls.Add(cmbStatus);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtIDStaff);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtFullName);
            panel3.Location = new Point(19, 481);
            panel3.Name = "panel3";
            panel3.Size = new Size(1208, 259);
            panel3.TabIndex = 2;
            // 
            // cmbAccount
            // 
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(1030, 58);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(144, 28);
            cmbAccount.TabIndex = 64;
            // 
            // lblAccountID
            // 
            lblAccountID.AutoSize = true;
            lblAccountID.BackColor = Color.White;
            lblAccountID.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            lblAccountID.ForeColor = SystemColors.ActiveCaptionText;
            lblAccountID.Location = new Point(1030, 34);
            lblAccountID.Name = "lblAccountID";
            lblAccountID.Size = new Size(102, 21);
            lblAccountID.TabIndex = 62;
            lblAccountID.Text = "Acount ID:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(725, 72);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(187, 27);
            txtSalary.TabIndex = 61;
            // 
            // txtPosition
            // 
            txtPosition.BackColor = Color.White;
            txtPosition.ForeColor = SystemColors.ActiveCaptionText;
            txtPosition.Location = new Point(725, 20);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(192, 27);
            txtPosition.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(571, 131);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 59;
            label3.Text = "Ngày vào làm:";
            // 
            // dtpDateOfJoining
            // 
            dtpDateOfJoining.Location = new Point(725, 125);
            dtpDateOfJoining.Name = "dtpDateOfJoining";
            dtpDateOfJoining.Size = new Size(250, 27);
            dtpDateOfJoining.TabIndex = 58;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Hoạt động", "Nghỉ việc" });
            cmbStatus.Location = new Point(285, 128);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(192, 28);
            cmbStatus.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(138, 126);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 56;
            label4.Text = "Hoạt động:";
            // 
            // txtIDStaff
            // 
            txtIDStaff.BackColor = Color.White;
            txtIDStaff.ForeColor = SystemColors.ActiveCaptionText;
            txtIDStaff.Location = new Point(285, 22);
            txtIDStaff.Name = "txtIDStaff";
            txtIDStaff.Size = new Size(192, 27);
            txtIDStaff.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(138, 34);
            label6.Name = "label6";
            label6.Size = new Size(35, 21);
            label6.TabIndex = 48;
            label6.Text = "ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(623, 77);
            label8.Name = "label8";
            label8.Size = new Size(76, 21);
            label8.TabIndex = 52;
            label8.Text = "Lương:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(138, 78);
            label9.Name = "label9";
            label9.Size = new Size(99, 21);
            label9.TabIndex = 50;
            label9.Text = "Họ và tên:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(603, 22);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 53;
            label10.Text = "Chức vụ:";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.ForeColor = SystemColors.ActiveCaptionText;
            txtFullName.Location = new Point(285, 72);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(192, 27);
            txtFullName.TabIndex = 51;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnSave);
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnDelete);
            panel4.Location = new Point(34, 657);
            panel4.Name = "panel4";
            panel4.Size = new Size(1183, 80);
            panel4.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(342, 17);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 60);
            btnSave.TabIndex = 64;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(872, 17);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 63;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(158, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 60);
            btnAdd.TabIndex = 60;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(521, 17);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(687, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 61;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { đổiAcToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(159, 28);
            // 
            // đổiAcToolStripMenuItem
            // 
            đổiAcToolStripMenuItem.Name = "đổiAcToolStripMenuItem";
            đổiAcToolStripMenuItem.Size = new Size(158, 24);
            đổiAcToolStripMenuItem.Text = "Đổi account";
            đổiAcToolStripMenuItem.Click += đổiAcToolStripMenuItem_Click;
            // 
            // AdminStaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(dgvDataStaff);
            Controls.Add(panel1);
            Name = "AdminStaffForm";
            Size = new Size(1250, 740);
            Load += AdminStaffForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataStaff).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvDataStaff;
        private Label label2;
        private Panel panel3;
        private Sunny.UI.UITextBox txtTimkiem;
        private Label label3;
        private DateTimePicker dtpDateOfJoining;
        private ComboBox cmbStatus;
        private Label label4;
        private TextBox txtIDStaff;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtFullName;
        private Panel panel4;
        private Button btnSave;
        private Button btnClear;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtPosition;
        private TextBox txtSalary;
        private Label lblAccountID;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem đổiAcToolStripMenuItem;
        private ComboBox cmbAccount;
    }
}
