using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SmartInventoryApp.Entity;
using SmartInventoryApp.Events;
using SmartInventoryApp.SmartInventoryContext;
using System.Data;

namespace SmartInventoryApp
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }
        private void LoadProducts()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS01;Initial Catalog=SmartInventoryDB;Integrated Security=True;Encrypt=False"; 
            string query = "SELECT * FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable productsTable = new DataTable();
                            adapter.Fill(productsTable);

                            dataGridViewProducts.DataSource = productsTable;
                            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            StyleDataGridView(dataGridViewProducts);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product Name is required.");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter a valid positive price.");
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Stock must be a non-negative integer.");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!ValidateInput()) return;
            using (var context = new SmartInventoryDBContext())
            {
                context.Database.ExecuteSqlRaw(
            "EXEC AddProduct @ProductName, @Price, @Stock",
            new SqlParameter("@ProductName", txtProductName.Text),
            new SqlParameter("@Price", decimal.Parse(txtPrice.Text)),
            new SqlParameter("@Stock", int.Parse(txtStock.Text))
        );
            }

            LoadProducts();
            DataRefreshManager.NotifyDataChanged();
            MessageBox.Show("Product added successfully!");
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new SmartInventoryDBContext())
            {
                int productId = int.Parse(dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value.ToString());
                var product = context.Products.FirstOrDefault(p => p.ProductID == productId);

                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                    LoadProducts();
                    DataRefreshManager.NotifyDataChanged();
                    MessageBox.Show("Product deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void RefreshPageData()
        {
            LoadProducts();

        }
        private void ApplyGlobalStyles(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                childControl.Font = new Font("Segoe UI", 10);
                ApplyGlobalStyles(childControl); 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataRefreshManager.OnDataChanged += RefreshPageData;
            LoadProducts();
            ApplyGlobalStyles(this);
            AddToolTips();
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewProducts.CurrentCell?.RowIndex ?? -1;
            if (rowIndex >= 0)
            {
                try
                {
                    using (var context = new SmartInventoryDBContext())
                    {
                        var row = dataGridViewProducts.Rows[rowIndex];

                        if (row.Cells["ProductId"].Value == null ||
                            string.IsNullOrWhiteSpace(row.Cells["ProductName"].Value?.ToString()) ||
                            string.IsNullOrWhiteSpace(row.Cells["Price"].Value?.ToString()) ||
                            string.IsNullOrWhiteSpace(row.Cells["Stock"].Value?.ToString()))
                        {
                            MessageBox.Show("Please ensure all fields are filled correctly.");
                            return;
                        }

                        int productId = int.Parse(row.Cells["ProductId"].Value.ToString());
                        var product = context.Products.FirstOrDefault(p => p.ProductID == productId);

                        if (product != null)
                        {
                            string productName = row.Cells["ProductName"].Value.ToString();
                            decimal price = decimal.Parse(row.Cells["Price"].Value.ToString());
                            int stock = int.Parse(row.Cells["Stock"].Value.ToString());

                            context.Database.ExecuteSqlRaw(
                              "EXEC UpdateProduct @ProductId, @ProductName, @Price, @Stock",
                                new SqlParameter("@ProductId", productId),
                                new SqlParameter("@ProductName", productName),
                                new SqlParameter("@Price", price),
                                new SqlParameter("@Stock", stock)
                            );
                            DataRefreshManager.NotifyDataChanged();

                            MessageBox.Show("Product updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Product not found in the database.");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter valid numeric values for Price and Stock.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row for update.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new SmartInventoryDBContext())
            {
                var query = txtSearch.Text.ToLower();
                var filteredProducts = context.Products
                    .Where(p => p.ProductName.ToLower().Contains(query))
                    .ToList();

                dataGridViewProducts.DataSource = filteredProducts;
            }
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataRefreshManager.OnDataChanged -= RefreshPageData;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainDashBoard = new MainDashBoard();
            mainDashBoard.Show();
            this.Hide();

        }

        private void AddToolTips()
        {
            ToolTip tooltip = new ToolTip();

            tooltip.SetToolTip(btnAdd, "Click to add a new product.");
            tooltip.SetToolTip(btnUpdate, "Click to update ProductName, Price, Stock for the selected product.");
            tooltip.SetToolTip(btnDelete, "Click to Delete a  product.");
        }

    }
}
