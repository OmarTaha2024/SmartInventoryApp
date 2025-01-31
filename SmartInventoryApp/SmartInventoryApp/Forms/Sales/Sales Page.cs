using Microsoft.Data.SqlClient;
using SmartInventoryApp.Entity;
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
    public partial class Sales_Page : Form
    {
        public Sales_Page()
        {
            InitializeComponent();
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
        private void LoadSales()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS01;Initial Catalog=SmartInventoryDB;Integrated Security=True;Encrypt=False"; 
            string query = @"
              SELECT  
            Sales.SaleID, 
            Sales.ProductID, 
            Products.ProductName, 
            Sales.Quantity, 
            Sales.TotalAmount, 
            Sales.SaleDate
            FROM Products 
            INNER JOIN Sales ON Products.ProductID = Sales.ProductID
            ORDER BY Products.ProductName ASC;
                ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable salesTable = new DataTable();
                            adapter.Fill(salesTable);
                            StyleDataGridView(dataGridViewSales);
                            dataGridViewSales.DataSource = salesTable;
                            dataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void LoadProducts()
        {
            using (var context = new SmartInventoryDBContext())
            {
                cmbProducts.DataSource = context.Products.ToList();
                cmbProducts.DisplayMember = "ProductName";
                cmbProducts.ValueMember = "ProductId";
            }
        }
        private void ClearInputSaleFields()
        {
            txtQuantity.Text = "";
            

            txtQuantity.Focus();
        }
        private void btnAddSale_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            if (cmbProducts.SelectedValue == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            int productId = (int)cmbProducts.SelectedValue;

            using (var context = new SmartInventoryDBContext())
            {
                var product = context.Products.FirstOrDefault(p => p.ProductID == productId);

                if (product == null)
                {
                    MessageBox.Show("Selected product not found in the database.");
                    return;
                }

                if (product.Stock < quantity)
                {
                    MessageBox.Show("Insufficient stock available!");
                    return;
                }

                product.Stock -= quantity;
                context.SaveChanges(); 

                decimal totalAmount = quantity * product.Price;

                var newSale = new Sale
                {
                    ProductID = productId,
                    Quantity = quantity,
                    TotalAmount = totalAmount,
                    SaleDate = dtpSaleDate.Value
                };

                context.Sales.Add(newSale);
                context.SaveChanges(); 
            }

            LoadSales();
            DataRefreshManager.NotifyDataChanged();
            MessageBox.Show("Sale added successfully!");
            ClearInputSaleFields();
        }

        private void btnUpdateSale_Click(object sender, EventArgs e)
        {
            if (dataGridViewSales.SelectedRows.Count > 0)
            {
                using (var context = new SmartInventoryDBContext())
                {
                    int saleId = Convert.ToInt32(dataGridViewSales.SelectedRows[0].Cells["SaleId"].Value);

               
                    var sale = context.Sales.FirstOrDefault(s => s.SaleID == saleId);

                    if (sale != null)
                    {
                        int productID = Convert.ToInt32( dataGridViewSales.SelectedRows[0].Cells["ProductID"].Value);

                        var product = context.Products.FirstOrDefault(p => p.ProductID == productID);

                        if (product != null)
                        {
                            sale.ProductID = product.ProductID;
                            sale.Quantity = Convert.ToInt32(dataGridViewSales.SelectedRows[0].Cells["Quantity"].Value);
                            sale.SaleDate = Convert.ToDateTime(dataGridViewSales.SelectedRows[0].Cells["SaleDate"].Value);

                            sale.TotalAmount = sale.Quantity * product.Price;
                            dataGridViewSales.SelectedRows[0].Cells["TotalAmount"].Value = sale.TotalAmount;

                            context.SaveChanges();
                            MessageBox.Show("Sale updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show($"Product not found!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sale not found!");
                    }

                }

                LoadSales();
            }
            else
            {
                MessageBox.Show("Please select a sale to update!");
            }
        }

        private void Sales_Page_Load(object sender, EventArgs e)
        {
            LoadSales();
            LoadProducts();
        }

        private void btnSearchSales_Click(object sender, EventArgs e)
        {
            using (var context = new SmartInventoryDBContext())
            {
                var query = context.Sales.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtSearchName.Text))
                {
                    query = query.Where(s => s.Product.ProductName.Contains(txtSearchName.Text));
                }

                else if (dtpStartDate.Value <= dtpEndDate.Value)
                {
                    query = query.Where(s => s.SaleDate >= dtpStartDate.Value && s.SaleDate <= dtpEndDate.Value);
                }

                var filteredSales = query
                    .Select(s => new
                    {
                        s.SaleID,
                        ProductName = s.Product.ProductName,
                        s.Quantity,
                        s.TotalAmount,
                        s.SaleDate
                    })
                    .ToList();

                dataGridViewSales.DataSource = filteredSales;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainDashBoard = new MainDashBoard();
            mainDashBoard.Show();
            this.Hide();
        }
    }
    }

