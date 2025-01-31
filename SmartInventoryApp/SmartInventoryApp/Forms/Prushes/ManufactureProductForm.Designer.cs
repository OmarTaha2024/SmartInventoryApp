﻿namespace SmartInventoryApp
{
    partial class ManufactureProductForm
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
            dataGridViewPurchases = new DataGridView();
            cmbProducts = new ComboBox();
            cmbSuppliers = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnAddPurchase = new Button();
            txtQuantity = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTotalCost = new TextBox();
            dtpPurchaseDate = new DateTimePicker();
            btnUpdatePurchase = new Button();
            btnSearchPurchases = new Button();
            label6 = new Label();
            txtSearch = new TextBox();
            btnRefreshData = new Button();
            btnBack = new Button();
            txtSupplier = new TextBox();
            label7 = new Label();
            btnAddSupplier = new Button();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchases).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPurchases
            // 
            dataGridViewPurchases.BackgroundColor = Color.WhiteSmoke;
            dataGridViewPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPurchases.Location = new Point(83, 12);
            dataGridViewPurchases.Name = "dataGridViewPurchases";
            dataGridViewPurchases.RowHeadersWidth = 51;
            dataGridViewPurchases.Size = new Size(820, 288);
            dataGridViewPurchases.TabIndex = 0;
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(131, 332);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(250, 28);
            cmbProducts.TabIndex = 1;
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(131, 393);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(250, 28);
            cmbSuppliers.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 393);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 3;
            label1.Text = "Suppliers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(16, 340);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Products:";
            // 
            // btnAddPurchase
            // 
            btnAddPurchase.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddPurchase.Location = new Point(120, 610);
            btnAddPurchase.Name = "btnAddPurchase";
            btnAddPurchase.Size = new Size(137, 30);
            btnAddPurchase.TabIndex = 5;
            btnAddPurchase.Text = "Add Purchase";
            btnAddPurchase.UseVisualStyleBackColor = true;
            btnAddPurchase.Click += btnAddPurchase_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(131, 449);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 27);
            txtQuantity.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SkyBlue;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 452);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SkyBlue;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(1, 561);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 8;
            label4.Text = "Purchase Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SkyBlue;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(8, 509);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Total Cost:";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(131, 502);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.Size = new Size(250, 27);
            txtTotalCost.TabIndex = 11;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Location = new Point(131, 556);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(250, 27);
            dtpPurchaseDate.TabIndex = 12;
            // 
            // btnUpdatePurchase
            // 
            btnUpdatePurchase.Location = new Point(663, 335);
            btnUpdatePurchase.Name = "btnUpdatePurchase";
            btnUpdatePurchase.Size = new Size(91, 30);
            btnUpdatePurchase.TabIndex = 13;
            btnUpdatePurchase.Text = "Save";
            btnUpdatePurchase.UseVisualStyleBackColor = true;
            btnUpdatePurchase.Click += btnUpdatePurchase_Click;
            // 
            // btnSearchPurchases
            // 
            btnSearchPurchases.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearchPurchases.Location = new Point(770, 683);
            btnSearchPurchases.Name = "btnSearchPurchases";
            btnSearchPurchases.Size = new Size(94, 29);
            btnSearchPurchases.TabIndex = 14;
            btnSearchPurchases.Text = "Search";
            btnSearchPurchases.UseVisualStyleBackColor = true;
            btnSearchPurchases.Click += btnSearchPurchases_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SkyBlue;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(719, 620);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 15;
            label6.Text = "Search Purchases";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(719, 650);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(184, 27);
            txtSearch.TabIndex = 17;
            // 
            // btnRefreshData
            // 
            btnRefreshData.Location = new Point(820, 336);
            btnRefreshData.Name = "btnRefreshData";
            btnRefreshData.Size = new Size(98, 29);
            btnRefreshData.TabIndex = 18;
            btnRefreshData.Text = "Refresh";
            btnRefreshData.UseVisualStyleBackColor = true;
            btnRefreshData.Click += btnRefreshData_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(8, 683);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(663, 414);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(250, 27);
            txtSupplier.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SkyBlue;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(663, 391);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 21;
            label7.Text = "Supplier";
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddSupplier.Location = new Point(711, 561);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(137, 30);
            btnAddSupplier.TabIndex = 22;
            btnAddSupplier.Text = "Add Supplier";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(663, 528);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 23;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(663, 471);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SkyBlue;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(663, 448);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 25;
            label8.Text = "Phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.SkyBlue;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(663, 505);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 26;
            label9.Text = "Address";
            // 
            // ManufactureProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1006, 724);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(btnAddSupplier);
            Controls.Add(label7);
            Controls.Add(txtSupplier);
            Controls.Add(btnBack);
            Controls.Add(btnRefreshData);
            Controls.Add(txtSearch);
            Controls.Add(label6);
            Controls.Add(btnSearchPurchases);
            Controls.Add(btnUpdatePurchase);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(txtTotalCost);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(btnAddPurchase);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbSuppliers);
            Controls.Add(cmbProducts);
            Controls.Add(dataGridViewPurchases);
            Name = "ManufactureProductForm";
            Text = "PrushesForm";
            FormClosed += ManufactureProductForm_FormClosed;
            Load += ManufactureProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPurchases;
        private ComboBox cmbProducts;
        private ComboBox cmbSuppliers;
        private Label label1;
        private Label label2;
        private Button btnAddPurchase;
        private TextBox txtQuantity;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTotalCost;
        private DateTimePicker dtpPurchaseDate;
        private Button btnUpdatePurchase;
        private Button btnSearchPurchases;
        private Label label6;
        private TextBox txtSearch;
        private Button btnRefreshData;
        private Button btnBack;
        private TextBox txtSupplier;
        private Label label7;
        private Button btnAddSupplier;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Label label8;
        private Label label9;
    }
}