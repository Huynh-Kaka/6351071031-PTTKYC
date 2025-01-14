using BTL_WINFORM.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Annotations;
using OxyPlot.Axes;



namespace BTL_WINFORM
{
    public partial class AdminDashboardForm : UserControl
    {
        private readonly MyDbContext _context;
        public AdminDashboardForm()
        {
            InitializeComponent();
            _context = new MyDbContext();
            LoadStatistics();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            // Các thống kê khác
            lblStaff.Text = _context.Employees.Count().ToString();
            lblCustomer.Text = _context.Customers.Count().ToString();
            decimal totalRevenue = _context.Invoices.Sum(i => (decimal?)i.TotalAmount) ?? 0;
            lblTotalMoney.Text = totalRevenue.ToString("C");

            // Hiển thị thống kê trên biểu đồ
            LoadDoughnutChart();
            LoadBarChart();
        }

        private void uiBarChart1_Click(object sender, EventArgs e)
        {

        }

        private void LoadDoughnutChart()
        {
            var productCategoryData = _context.Products
                .GroupBy(p => p.Category.CategoryName)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    ProductCount = g.Count()
                })
                .ToList();

            // Tạo PlotModel cho biểu đồ Doughnut
            var plotModel = new PlotModel { Title = "Số lượng sản phẩm theo loại" };
            var pieSeries = new PieSeries
            {
                AngleSpan = 360,
                StartAngle = 0,
                InsideLabelPosition = 0.5,
                TextColor = OxyColors.Black
            };

            // Thêm các phần tử vào PieSeries
            foreach (var data in productCategoryData)
            {
                pieSeries.Slices.Add(new PieSlice(data.CategoryName, data.ProductCount)
                {
                    IsExploded = true // Chỉ dùng IsExploded thay vì ExplodedDistance
                });
            }

            plotModel.Series.Add(pieSeries);

            // Gán PlotModel cho PlotView
            plotViewDoughnutChart.Model = plotModel;
        }


        private List<dynamic> salesData;
        private void LoadBarChart()
        {
            // Truy vấn dữ liệu từ InvoiceDetails và Products
            var salesData = _context.InvoiceDetails
                .GroupBy(id => id.Product.ProductName)
                .Select(g => new
                {
                    ProductName = g.Key,
                    QuantitySold = g.Sum(id => id.Quantity)
                })
                .ToList();

            // Tạo PlotModel cho biểu đồ Bar
            var plotModel = new PlotModel { Title = "Số lượng sản phẩm đã bán" };

            // Tạo BarSeries và thêm dữ liệu
            var barSeries = new BarSeries
            {
                Title = "Sản phẩm",
                StrokeThickness = 1,
                FillColor = OxyColors.SkyBlue // Chọn màu cho các cột
            };

            // Thêm dữ liệu vào BarSeries
            foreach (var data in salesData)
            {
                barSeries.Items.Add(new BarItem(data.QuantitySold));
            }

            // Thêm nhãn sản phẩm vào trục Y (CategoryAxis)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left, // Nhãn sản phẩm ở bên trái
                ItemsSource = salesData.Select(data => data.ProductName).ToList(),
                Title = "Tên sản phẩm"
            };

            // Thêm trục số liệu (LinearAxis) cho trục X
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom, // Hiển thị trục số ở dưới
                Minimum = 0,
                Title = "Số lượng bán"
            };

            // Thêm trục và series vào PlotModel
            plotModel.Axes.Add(categoryAxis);
            plotModel.Axes.Add(valueAxis);
            plotModel.Series.Add(barSeries);

            // Gán PlotModel cho PlotView
            plotViewBarChart.Model = plotModel;
            plotViewBarChart.InvalidatePlot(true); // Yêu cầu vẽ lại biểu đồ
        }



        private void plotViewBarChart_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void lblTotalMoney_Click(object sender, EventArgs e)
        {

        }

        private void plotViewDoughnutChart_Click(object sender, EventArgs e)
        {

        }

        private void plotViewBarChart_Click(object sender, EventArgs e)
        {

        }
    }

}

