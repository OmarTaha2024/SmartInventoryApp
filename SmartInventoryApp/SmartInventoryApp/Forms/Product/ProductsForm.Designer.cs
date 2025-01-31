namespace SmartInventoryApp
{
    partial class ProductsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridViewProducts = new DataGridView();
            btnRefresh = new Button();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtProductName = new TextBox();
            btnSearch = new Button();
            ProductName = new Label();
            btnBack = new Button();
            button1 = new Button();
            button2 = new Button();
            cmbProducts = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(415, 562);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(291, 562);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(167, 562);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(62, 510);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 5;
            label1.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(62, 448);
            label2.Name = "label2";
            label2.Size = new Size(49, 23);
            label2.TabIndex = 6;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(33, 391);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 7;
            label3.Text = "Product Name\n";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(42, 12);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(629, 355);
            dataGridViewProducts.TabIndex = 8;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(721, 338);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(141, 29);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh Data";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(189, 503);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(189, 27);
            txtStock.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(189, 445);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(189, 27);
            txtPrice.TabIndex = 11;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(189, 391);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(189, 27);
            txtProductName.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.Location = new Point(897, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(74, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.BackColor = Color.RoyalBlue;
            ProductName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ProductName.Location = new Point(721, 44);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(120, 23);
            ProductName.TabIndex = 15;
            ProductName.Text = "ProductName";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(12, 587);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(415, 562);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDelete_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(167, 562);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnAdd_Click;
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(721, 77);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(151, 28);
            cmbProducts.TabIndex = 17;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1003, 628);
            Controls.Add(cmbProducts);
            Controls.Add(btnBack);
            Controls.Add(ProductName);
            Controls.Add(btnSearch);
            Controls.Add(txtProductName);
            Controls.Add(txtPrice);
            Controls.Add(txtStock);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridViewProducts);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "ProductsForm";
            Text = "ProductsForm";
            FormClosed += ProductsForm_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTestConnection;
        private Button btnDelete;
        private Button btnUpdate;
        private Button button3;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridViewProducts;
        private Button btnRefresh;
        private TextBox txtStock;
        private TextBox txtPrice;
        private TextBox txtProductName;
        private Button btnSearch;
        private Label ProductName;
        private Button btnBack;
        private Button button1;
        private Button button2;
        private ComboBox cmbProducts;
    }
}
