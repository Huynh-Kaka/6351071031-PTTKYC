namespace BTL_WINFORM
{
    partial class AdminCategory
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
            btnDelete = new Button();
            btnAdd = new Button();
            label10 = new Label();
            btnUpdate = new Button();
            txtCategoryID = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            panel2 = new Panel();
            label7 = new Label();
            lblSoSP = new Label();
            txtCategoryName = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            dgvDataCategory = new DataGridView();
            panel1 = new Panel();
            txtTimkiem = new Sunny.UI.UITextBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataCategory).BeginInit();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(815, 20);
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
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label10.Location = new Point(722, 30);
            label10.Name = "label10";
            label10.Size = new Size(91, 28);
            label10.TabIndex = 0;
            label10.Text = "Tìm kiếm";
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(593, 20);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtCategoryID
            // 
            txtCategoryID.BackColor = Color.White;
            txtCategoryID.ForeColor = SystemColors.ActiveCaptionText;
            txtCategoryID.Location = new Point(294, 68);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(192, 27);
            txtCategoryID.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(247, 70);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 13;
            label2.Text = "ID:";
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(353, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 60);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblSoSP);
            panel2.Controls.Add(txtCategoryName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtCategoryID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(23, 485);
            panel2.Name = "panel2";
            panel2.Size = new Size(1208, 244);
            panel2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(78, 11);
            label7.Name = "label7";
            label7.Size = new Size(166, 23);
            label7.TabIndex = 7;
            label7.Text = "phân loại sản phẩm";
            // 
            // lblSoSP
            // 
            lblSoSP.AutoSize = true;
            lblSoSP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSoSP.ForeColor = SystemColors.ActiveCaptionText;
            lblSoSP.Location = new Point(50, 11);
            lblSoSP.Name = "lblSoSP";
            lblSoSP.Size = new Size(40, 23);
            lblSoSP.TabIndex = 6;
            lblSoSP.Text = "100";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = Color.White;
            txtCategoryName.ForeColor = SystemColors.ActiveCaptionText;
            txtCategoryName.Location = new Point(697, 68);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(192, 27);
            txtCategoryName.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(19, 11);
            label5.Name = "label5";
            label5.Size = new Size(36, 23);
            label5.TabIndex = 5;
            label5.Text = "Có:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnAdd);
            panel3.Location = new Point(17, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(1178, 100);
            panel3.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(566, 70);
            label6.Name = "label6";
            label6.Size = new Size(133, 21);
            label6.TabIndex = 21;
            label6.Text = "Tên phân loại:";
            // 
            // dgvDataCategory
            // 
            dgvDataCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataCategory.Location = new Point(20, 76);
            dgvDataCategory.Name = "dgvDataCategory";
            dgvDataCategory.RowHeadersWidth = 51;
            dgvDataCategory.Size = new Size(1178, 380);
            dgvDataCategory.TabIndex = 2;
            dgvDataCategory.CellClick += dgvDataCategory_CellClick;
            dgvDataCategory.MouseUp += dgvDataCategory_MouseUp;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtTimkiem);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dgvDataCategory);
            panel1.Location = new Point(20, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 468);
            panel1.TabIndex = 2;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimkiem.Location = new Point(820, 26);
            txtTimkiem.Margin = new Padding(4, 5, 4, 5);
            txtTimkiem.MinimumSize = new Size(1, 16);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Padding = new Padding(5);
            txtTimkiem.Radius = 30;
            txtTimkiem.RectColor = Color.FromArgb(255, 192, 128);
            txtTimkiem.ShowText = false;
            txtTimkiem.Size = new Size(250, 37);
            txtTimkiem.TabIndex = 12;
            txtTimkiem.TextAlignment = ContentAlignment.MiddleLeft;
            txtTimkiem.Watermark = "";
            txtTimkiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 1;
            label1.Text = "Data of Category";
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
            // AdminCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminCategory";
            Size = new Size(1250, 740);
            Load += AdminCategory_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDataCategory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnDelete;
        private Button btnAdd;
        private Panel panel4;
        private Label label10;
        private Button btnUpdate;
        private TextBox txtCategoryID;
        private Label label2;
        private Button btnSave;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvDataCategory;
        private Panel panel1;
        private Label label1;
        private TextBox txtCategoryName;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label7;
        private Label lblSoSP;
        private Label label5;
        private Sunny.UI.UITextBox txtTimkiem;
    }
}
