namespace BTL_WINFORM
{
    partial class AdminDashboardForm
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
            Panel panel2;
            Panel panel1;
            panel7 = new Panel();
            plotViewBarChart = new OxyPlot.WindowsForms.PlotView();
            panel6 = new Panel();
            plotViewDoughnutChart = new OxyPlot.WindowsForms.PlotView();
            panel5 = new Panel();
            label3 = new Label();
            lblTotalMoney = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            label2 = new Label();
            lblCustomer = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            lblStaff = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(17, 236);
            panel2.Name = "panel2";
            panel2.Size = new Size(1214, 585);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel7
            // 
            panel7.Controls.Add(plotViewBarChart);
            panel7.Location = new Point(581, 24);
            panel7.Name = "panel7";
            panel7.Size = new Size(618, 542);
            panel7.TabIndex = 1;
            // 
            // plotViewBarChart
            // 
            plotViewBarChart.Location = new Point(15, 31);
            plotViewBarChart.Name = "plotViewBarChart";
            plotViewBarChart.PanCursor = Cursors.Hand;
            plotViewBarChart.Size = new Size(584, 508);
            plotViewBarChart.TabIndex = 0;
            plotViewBarChart.Text = "plotView2";
            plotViewBarChart.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewBarChart.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewBarChart.ZoomVerticalCursor = Cursors.SizeNS;
            plotViewBarChart.Click += plotViewBarChart_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(plotViewDoughnutChart);
            panel6.Location = new Point(18, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(557, 542);
            panel6.TabIndex = 0;
            // 
            // plotViewDoughnutChart
            // 
            plotViewDoughnutChart.ForeColor = Color.Red;
            plotViewDoughnutChart.Location = new Point(3, 31);
            plotViewDoughnutChart.Name = "plotViewDoughnutChart";
            plotViewDoughnutChart.PanCursor = Cursors.Hand;
            plotViewDoughnutChart.Size = new Size(551, 508);
            plotViewDoughnutChart.TabIndex = 0;
            plotViewDoughnutChart.Text = "plotView1";
            plotViewDoughnutChart.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewDoughnutChart.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewDoughnutChart.ZoomVerticalCursor = Cursors.SizeNS;
            plotViewDoughnutChart.Click += plotViewDoughnutChart_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(17, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1214, 216);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 192, 128);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lblTotalMoney);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(851, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(329, 164);
            panel5.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.White;
            label3.Location = new Point(149, 13);
            label3.Name = "label3";
            label3.Size = new Size(128, 31);
            label3.TabIndex = 4;
            label3.Text = "Doanh thu";
            // 
            // lblTotalMoney
            // 
            lblTotalMoney.AutoSize = true;
            lblTotalMoney.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTotalMoney.Location = new Point(149, 53);
            lblTotalMoney.Name = "lblTotalMoney";
            lblTotalMoney.Size = new Size(128, 50);
            lblTotalMoney.TabIndex = 1;
            lblTotalMoney.Text = "label3";
            lblTotalMoney.Click += lblTotalMoney_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icon_totaltoday;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 161);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(lblCustomer);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(459, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 164);
            panel4.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.White;
            label2.Location = new Point(151, 16);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 3;
            label2.Text = "Khách hàng";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCustomer.Location = new Point(161, 66);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(128, 50);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "label2";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icon_customer;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 158);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblStaff);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(52, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 164);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 16);
            label1.Name = "label1";
            label1.Size = new Size(119, 31);
            label1.TabIndex = 2;
            label1.Text = "nhân viên";
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblStaff.Location = new Point(128, 66);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(128, 50);
            lblStaff.TabIndex = 1;
            lblStaff.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_cashiers;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboardForm";
            Size = new Size(1260, 841);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel7;
        private Panel panel6;
        private OxyPlot.WindowsForms.PlotView plotViewBarChart;
        private OxyPlot.WindowsForms.PlotView plotViewDoughnutChart;
        private Panel panel3;
        private Label label1;
        private Label lblStaff;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label2;
        private Label lblCustomer;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Label label3;
        private Label lblTotalMoney;
        private PictureBox pictureBox3;
    }
}
