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
    public partial class ManufactureProductForm : Form
    {
        public ManufactureProductForm()
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
        private void LoadPurchases()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS01;Initial Catalog=SmartInventoryDB;Integrated Security=True;Encrypt=False"; 
            string query = "SELECT  Purchases.PurchaseID, Purchases.ProductID, Products.ProductName, Purchases.SupplierID,Suppliers.SupplierName, Purchases.Quantity, Purchases.TotalCost, Purchases.PurchaseDate\r\nFROM     Products INNER JOIN\r\n                  Purchases ON Products.ProductID = Purchases.ProductID INNER JOIN\r\n                  Suppliers ON Purchases.SupplierID = Suppliers.SupplierID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable purchasesTable = new DataTable();
                            adapter.Fill(purchasesTable);
                            StyleDataGridView(dataGridViewPurchases);
                            dataGridViewPurchases.DataSource = purchasesTable;
                            dataGridViewPurchases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadProductsAndSuppliers()
        {
            using (var context = new SmartInventoryDBContext())
            {
                cmbProducts.DataSource = context.Products.ToList();
                cmbProducts.DisplayMember = "ProductName";
                cmbProducts.ValueMember = "ProductId";

                cmbSuppliers.DataSource = context.Suppliers.ToList();
                cmbSuppliers.DisplayMember = "SupplierName";
                cmbSuppliers.ValueMember = "SupplierId";
            }
        }

        private void ManufactureProductForm_Load(object sender, EventArgs e)
        {
            LoadPurchases();
            LoadProductsAndSuppliers();
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0 ||
        !decimal.TryParse(txtTotalCost.Text, out decimal totalCost) || totalCost <= 0)
            {
                MessageBox.Show("Please enter valid quantity and total cost.");
                return;
            }

            using (var context = new SmartInventoryDBContext())
            {
                var newPurchase = new Purchase
                {
                    ProductID = (int)cmbProducts.SelectedValue,
                    SupplierID = (int)cmbSuppliers.SelectedValue,
                    Quantity = quantity,
                    TotalCost = totalCost,
                    PurchaseDate = dtpPurchaseDate.Value
                };

                context.Purchases.Add(newPurchase);
                context.SaveChanges();
            }

            LoadPurchases();
            DataRefreshManager.NotifyDataChanged();
            MessageBox.Show("Purchase added successfully!");
        }

        private void btnUpdatePurchase_Click(object sender, EventArgs e)
        {
            if (dataGridViewPurchases.SelectedRows.Count > 0)
            {
                using (var context = new SmartInventoryDBContext())
                {
                    int purchaseId = Convert.ToInt32(dataGridViewPurchases.SelectedRows[0].Cells["PurchaseID"].Value);

                    var purchase = context.Purchases.FirstOrDefault(p => p.PurchaseID == purchaseId);

                    if (purchase != null)
                    {
                        int productId = Convert.ToInt32(dataGridViewPurchases.SelectedRows[0].Cells["ProductID"].Value);
                        var product = context.Products.FirstOrDefault(p => p.ProductID == productId);

                        int supplierId = Convert.ToInt32(dataGridViewPurchases.SelectedRows[0].Cells["SupplierID"].Value);
                        var supplier = context.Suppliers.FirstOrDefault(s => s.SupplierID == supplierId);

                        if (product != null && supplier != null)
                        {

                            purchase.ProductID = productId;
                            purchase.SupplierID = supplierId;
                            purchase.Quantity = Convert.ToInt32(dataGridViewPurchases.SelectedRows[0].Cells["Quantity"].Value); ;
                            purchase.PurchaseDate = Convert.ToDateTime(dataGridViewPurchases.SelectedRows[0].Cells["PurchaseDate"].Value);
                            purchase.TotalCost = purchase.Quantity * product.Price;
                            dataGridViewPurchases.SelectedRows[0].Cells["TotalCost"].Value = purchase.TotalCost;


                            context.SaveChanges();
                            LoadPurchases();

                            MessageBox.Show("Purchase updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid product or supplier. Please verify the selection.");
                        }

                    }

                    else
                    {
                        MessageBox.Show("Purchase not found!");
                    }

                    LoadPurchases();
                }
            }
            else
            {
                MessageBox.Show("Please select a purchase to update!");
            }
        }

        private void btnSearchPurchases_Click(object sender, EventArgs e)
        {
            using (var context = new SmartInventoryDBContext())
            {
                var query = context.Purchases.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    query = query.Where(p => p.Product.ProductName.Contains(txtSearch.Text) ||
                                             p.Supplier.SupplierName.Contains(txtSearch.Text));
                }

                var filteredPurchases = query
                    .Select(p => new
                    {
                        p.PurchaseID,
                        ProductName = p.Product.ProductName,
                        SupplierName = p.Supplier.SupplierName,
                        p.Quantity,
                        p.TotalCost,
                        p.PurchaseDate
                    })
                    .ToList();

                dataGridViewPurchases.DataSource = filteredPurchases;
            }
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            DataRefreshManager.OnDataChanged += RefreshPageData;

            LoadPurchases();
            LoadProductsAndSuppliers();
        }

        private void RefreshPageData()
        {
            LoadPurchases();
        }

        private void ManufactureProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataRefreshManager.OnDataChanged -= RefreshPageData;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainDashBoard = new MainDashBoard();
            mainDashBoard.Show();
            this.Hide();
        }
    }
}

