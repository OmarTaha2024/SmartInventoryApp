using OfficeOpenXml;
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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void LoadReportTypes()
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("Sales Report");
            cmbReportType.Items.Add("Top-Selling Products");
            cmbReportType.Items.Add("Purchases Report");
            cmbReportType.Items.Add("Low Stock Products");
        }

        private void Report_Load(object sender, EventArgs e)
        {
            LoadReportTypes();
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
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a report type.");
                return;
            }

            using (var context = new SmartInventoryDBContext())
            {
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                if(startDate > endDate)
                {
                    MessageBox.Show("Please select a Real Date");
                    return;
                }
                StyleDataGridView(dataGridViewReport);
                switch (cmbReportType.SelectedItem.ToString())
                {
                    case "Sales Report":
                        var salesReport = context.Sales
                            .Where(s => s.SaleDate >= startDate && s.SaleDate <= endDate)
                            .Select(s => new
                            {
                                s.SaleID,
                                ProductName = s.Product.ProductName,
                                s.Quantity,
                                s.TotalAmount,
                                s.SaleDate
                            })
                            .ToList();

                        dataGridViewReport.DataSource = salesReport;
                        break;

                    case "Top-Selling Products":
                        var topSellingProducts = context.Sales
                            .GroupBy(s => s.Product.ProductName)
                            .Select(g => new
                            {
                                ProductName = g.Key,
                                TotalSold = g.Sum(s => s.Quantity),
                                TotalRevenue = g.Sum(s => s.TotalAmount)
                            })
                            .OrderByDescending(g => g.TotalSold)
                            .Take(5)
                            .ToList();

                        dataGridViewReport.DataSource = topSellingProducts;
                        break;

                    case "Purchases Report":
                        var purchasesReport = context.Purchases
                            .Where(p => p.PurchaseDate >= startDate && p.PurchaseDate <= endDate)
                            .Select(p => new
                            {
                                p.PurchaseID,
                                ProductName = p.Product.ProductName,
                                p.Quantity,
                                p.TotalCost,
                                p.PurchaseDate
                            })
                            .ToList();

                        dataGridViewReport.DataSource = purchasesReport;
                        break;

                    case "Low Stock Products":
                        var lowStockProducts = context.Products
                            .Where(p => p.Stock < 10)
                            .Select(p => new
                            {
                                p.ProductID,
                                p.ProductName,
                                p.Stock
                            })
                            .ToList();

                        dataGridViewReport.DataSource = lowStockProducts;
                        break;

                    default:
                        MessageBox.Show("Invalid report type selected.");
                        break;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainDashBoard = new MainDashBoard();
            mainDashBoard.Show();
            this.Hide();
        }

        private void ExportToCsv()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files|*.csv",
                Title = "Save Report"
            };


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (dataGridViewReport.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewColumn column in dataGridViewReport.Columns)
                    {
                        writer.Write(column.HeaderText + ",");
                    }
                    writer.WriteLine();

                    foreach (DataGridViewRow row in dataGridViewReport.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                writer.Write(cell.Value + ",");
                            }
                            writer.WriteLine();
                        }
                    }
                }

                MessageBox.Show("Report exported successfully!");
            }
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            ExportToCsv();
        }

        private void ExportToExcel()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save Report"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                if (dataGridViewReport.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Report");

                    
                    for (int col = 0; col < dataGridViewReport.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridViewReport.Columns[col].HeaderText;
                    }

                    // Write rows
                    for (int row = 0; row < dataGridViewReport.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridViewReport.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewReport.Rows[row].Cells[col].Value;
                        }
                    }

                    package.SaveAs(new FileInfo(saveFileDialog.FileName));
                    MessageBox.Show("Report exported successfully!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
