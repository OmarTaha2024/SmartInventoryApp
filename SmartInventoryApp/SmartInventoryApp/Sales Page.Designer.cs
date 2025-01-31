namespace SmartInventoryApp
{
    partial class Sales_Page
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbProducts = new ComboBox();
            Products = new Label();
            label1 = new Label();
            label2 = new Label();
            txtTotalAmount = new TextBox();
            txtQuantity = new TextBox();
            dtpSaleDate = new DateTimePicker();
            label3 = new Label();
            btnUpdateSale = new Button();
            btnAddSale = new Button();
            btnSearchSales = new Button();
            txtSearchName = new TextBox();
            label4 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            btnBack = new Button();
            dataGridViewSales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            SuspendLayout();
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(42, 353);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(151, 28);
            cmbProducts.TabIndex = 1;
            // 
            // Products
            // 
            Products.AutoSize = true;
            Products.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Products.Location = new Point(42, 330);
            Products.Name = "Products";
            Products.Size = new Size(71, 20);
            Products.TabIndex = 2;
            Products.Text = "Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(42, 453);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 3;
            label1.Text = "TotalAmount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(42, 392);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Quantity";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(42, 476);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(149, 27);
            txtTotalAmount.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(42, 415);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(148, 27);
            txtQuantity.TabIndex = 6;
            // 
            // dtpSaleDate
            // 
            dtpSaleDate.Location = new Point(42, 529);
            dtpSaleDate.Name = "dtpSaleDate";
            dtpSaleDate.Size = new Size(250, 27);
            dtpSaleDate.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(42, 506);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "SaleDate";
            // 
            // btnUpdateSale
            // 
            btnUpdateSale.Location = new Point(673, 352);
            btnUpdateSale.Name = "btnUpdateSale";
            btnUpdateSale.Size = new Size(94, 29);
            btnUpdateSale.TabIndex = 9;
            btnUpdateSale.Text = "Save";
            btnUpdateSale.UseVisualStyleBackColor = true;
            btnUpdateSale.Click += btnUpdateSale_Click;
            // 
            // btnAddSale
            // 
            btnAddSale.Location = new Point(96, 593);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(94, 29);
            btnAddSale.TabIndex = 10;
            btnAddSale.Text = "Add Sale";
            btnAddSale.UseVisualStyleBackColor = true;
            btnAddSale.Click += btnAddSale_Click;
            // 
            // btnSearchSales
            // 
            btnSearchSales.Location = new Point(881, 282);
            btnSearchSales.Name = "btnSearchSales";
            btnSearchSales.Size = new Size(94, 29);
            btnSearchSales.TabIndex = 11;
            btnSearchSales.Text = "Search";
            btnSearchSales.UseVisualStyleBackColor = true;
            btnSearchSales.Click += btnSearchSales_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(818, 51);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(179, 27);
            txtSearchName.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(818, 12);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 13;
            label4.Text = "SearchName";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(818, 220);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 14;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(818, 135);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(818, 182);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 16;
            label5.Text = "EndDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(818, 100);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 17;
            label6.Text = "StartDate";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(974, 593);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.BackgroundColor = Color.White;
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridViewSales.Location = new Point(42, 12);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.RowHeadersWidth = 51;
            dataGridViewSales.Size = new Size(725, 299);
            dataGridViewSales.TabIndex = 19;
            // 
            // Sales_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(1107, 649);
            Controls.Add(dataGridViewSales);
            Controls.Add(btnBack);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpStartDate);
            Controls.Add(dtpEndDate);
            Controls.Add(label4);
            Controls.Add(txtSearchName);
            Controls.Add(btnSearchSales);
            Controls.Add(btnAddSale);
            Controls.Add(btnUpdateSale);
            Controls.Add(label3);
            Controls.Add(dtpSaleDate);
            Controls.Add(txtQuantity);
            Controls.Add(txtTotalAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Products);
            Controls.Add(cmbProducts);
            Name = "Sales_Page";
            Text = "Sales Page";
            Load += Sales_Page_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbProducts;
        private Label Products;
        private Label label1;
        private Label label2;
        private TextBox txtTotalAmount;
        private TextBox txtQuantity;
        private DateTimePicker dtpSaleDate;
        private Label label3;
        private Button btnUpdateSale;
        private Button btnAddSale;
        private Button btnSearchSales;
        private TextBox txtSearchName;
        private Label label4;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label5;
        private Label label6;
        private Button btnBack;
        private DataGridView dataGridViewSales;
    }
}