using SmartInventoryApp.Events;
using SmartInventoryApp.SmartInventoryContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartInventoryApp
{
    public partial class MainDashBoard : Form
    {
        public MainDashBoard()
        {
            InitializeComponent();
        }

        private void LoadSummaryData()
        {
            using (var context = new SmartInventoryDBContext())
            {
                int totalProducts = context.Products.Count();

                decimal totalInventoryValue = context.Products
                    .Sum(p => p.Price * p.Stock);

                int lowStockCount = context.Products
                    .Count(p => p.Stock < 10);

                lblTotalProducts.Text = totalProducts.ToString();
                lblInventoryValue.Text = totalInventoryValue.ToString("C");
                lblLowStock.Text = lowStockCount.ToString();
            }
        }

        private void StyleDataGridView(DataGridView gridView)
        {
            gridView.BackgroundColor = Color.White;
            gridView.BorderStyle = BorderStyle.Fixed3D;

            gridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            gridView.DefaultCellStyle.ForeColor = Color.Black;
            gridView.DefaultCellStyle.BackColor = Color.White;
            gridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(169, 208, 245);
            gridView.DefaultCellStyle.SelectionForeColor = Color.Black;

            gridView.EnableHeadersVisualStyles = false;
            gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(72, 84, 96);
            gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);

            gridView.RowTemplate.Height = 40;
            gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }
        private void LoadLastAddedProducts()
        {
            using (var context = new SmartInventoryDBContext())
            {
                var lastProducts = context.Products
                    .OrderByDescending(p => p.CreatedDate)
                    .Select(p => new
                    {
                        p.ProductID,
                        p.ProductName,
                        p.Price,
                        p.Stock,
                        p.CreatedDate
                    })
                    .Take(10)
                    .ToList();
                StyleDataGridView(dgvLastProducts);

                dgvLastProducts.DataSource = lastProducts;
            }
        }

        private void LoadFinancialData()
        {
            using (var context = new SmartInventoryDBContext())
            {
                decimal totalSales = context.Sales
                    .Sum(s => s.TotalAmount);

                decimal totalPurchases = context.Purchases
                    .Sum(p => p.TotalCost);

                var topSellingProducts = context.Sales
                    .GroupBy(s => s.ProductID)
                    .Select(g => new
                    {
                        ProductId = g.Key,
                        TotalSold = g.Sum(s => s.Quantity)
                    })
                    .OrderByDescending(g => g.TotalSold)
                    .Take(5)
                    .ToList();
                StyleDataGridView(dgvTopSellingProducts);

                lblTotalSales.Text = totalSales.ToString("C");
                lblTotalPurchases.Text = totalPurchases.ToString("C");
                dgvTopSellingProducts.DataSource = topSellingProducts;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var productsForm = new ProductsForm();
            this.Hide();
            productsForm.Show();
        }

        private void btnManufacture_Click(object sender, EventArgs e)
        {
            var manufactureForm = new ManufactureProductForm();

            this.Hide();
            manufactureForm.Show();
        }



        private void MainDashBoard_Load(object sender, EventArgs e)
        {
            DataRefreshManager.OnDataChanged -= RefreshPageData;
            LoadSummaryData();
            LoadLastAddedProducts();
            LoadFinancialData();
        }
        private void RefreshPageData()
        {
            LoadSummaryData();
            LoadLastAddedProducts();
            LoadFinancialData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sales = new Sales_Page();
            this.Hide();
            sales.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var report = new Report();
            this.Hide();
            report.Show();
        }

        private void lblInventoryValue_Click(object sender, EventArgs e)
        {

        }
    }
}
