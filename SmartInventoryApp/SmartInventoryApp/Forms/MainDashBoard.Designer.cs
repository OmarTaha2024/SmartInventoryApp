namespace SmartInventoryApp
{
    partial class MainDashBoard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTotalProducts = new Label();
            lblInventoryValue = new Label();
            lblLowStock = new Label();
            lblTotalSales = new Label();
            lblTotalPurchases = new Label();
            dgvLastProducts = new DataGridView();
            dgvTopSellingProducts = new DataGridView();
            btnUpdate = new Button();
            btnManufacture = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLastProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopSellingProducts).BeginInit();
            SuspendLayout();
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.BackColor = Color.Peru;
            lblTotalProducts.Location = new Point(80, 34);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(50, 20);
            lblTotalProducts.TabIndex = 0;
            lblTotalProducts.Text = "label1";
            // 
            // lblInventoryValue
            // 
            lblInventoryValue.AutoSize = true;
            lblInventoryValue.BackColor = Color.Peru;
            lblInventoryValue.Location = new Point(272, 34);
            lblInventoryValue.Name = "lblInventoryValue";
            lblInventoryValue.Size = new Size(50, 20);
            lblInventoryValue.TabIndex = 1;
            lblInventoryValue.Text = "label2";
            lblInventoryValue.Click += lblInventoryValue_Click;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.BackColor = Color.Peru;
            lblLowStock.Location = new Point(513, 34);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(50, 20);
            lblLowStock.TabIndex = 2;
            lblLowStock.Text = "label3";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.BackColor = Color.Peru;
            lblTotalSales.Location = new Point(700, 34);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(50, 20);
            lblTotalSales.TabIndex = 3;
            lblTotalSales.Text = "label4";
            // 
            // lblTotalPurchases
            // 
            lblTotalPurchases.AutoSize = true;
            lblTotalPurchases.BackColor = Color.Peru;
            lblTotalPurchases.Location = new Point(876, 34);
            lblTotalPurchases.Name = "lblTotalPurchases";
            lblTotalPurchases.Size = new Size(50, 20);
            lblTotalPurchases.TabIndex = 4;
            lblTotalPurchases.Text = "label5";
            // 
            // dgvLastProducts
            // 
            dgvLastProducts.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLastProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLastProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLastProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLastProducts.Location = new Point(55, 440);
            dgvLastProducts.Name = "dgvLastProducts";
            dgvLastProducts.RowHeadersWidth = 51;
            dgvLastProducts.Size = new Size(710, 222);
            dgvLastProducts.TabIndex = 5;
            // 
            // dgvTopSellingProducts
            // 
            dgvTopSellingProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTopSellingProducts.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTopSellingProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTopSellingProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTopSellingProducts.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTopSellingProducts.Location = new Point(55, 110);
            dgvTopSellingProducts.Name = "dgvTopSellingProducts";
            dgvTopSellingProducts.RowHeadersWidth = 51;
            dgvTopSellingProducts.Size = new Size(290, 210);
            dgvTopSellingProducts.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Peru;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(856, 206);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Product";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnManufacture
            // 
            btnManufacture.BackColor = Color.Peru;
            btnManufacture.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnManufacture.Location = new Point(856, 378);
            btnManufacture.Name = "btnManufacture";
            btnManufacture.Size = new Size(112, 29);
            btnManufacture.TabIndex = 9;
            btnManufacture.Text = "Prushes ";
            btnManufacture.UseVisualStyleBackColor = false;
            btnManufacture.Click += btnManufacture_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(55, 75);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 10;
            label1.Text = "TopSellingProducts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(55, 9);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 11;
            label2.Text = "TotalProducts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(513, 9);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 12;
            label3.Text = "LowStock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(257, 9);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 13;
            label4.Text = "InventoryValue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(689, 9);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 14;
            label5.Text = "TotalSales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(856, 9);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 15;
            label6.Text = "TotalPurchases";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(55, 405);
            label7.Name = "label7";
            label7.Size = new Size(139, 23);
            label7.TabIndex = 16;
            label7.Text = "LastTenProducts";
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(856, 291);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 17;
            button1.Text = "Sales";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Peru;
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExport.Location = new Point(856, 452);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(112, 29);
            btnExport.TabIndex = 18;
            btnExport.Text = "Report";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // MainDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(1039, 710);
            Controls.Add(btnExport);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnManufacture);
            Controls.Add(btnUpdate);
            Controls.Add(dgvTopSellingProducts);
            Controls.Add(dgvLastProducts);
            Controls.Add(lblTotalPurchases);
            Controls.Add(lblTotalSales);
            Controls.Add(lblLowStock);
            Controls.Add(lblInventoryValue);
            Controls.Add(lblTotalProducts);
            Font = new Font("Segoe UI", 9F);
            Name = "MainDashBoard";
            Text = "MainDashBoard";
            Load += MainDashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLastProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopSellingProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalProducts;
        private Label lblInventoryValue;
        private Label lblLowStock;
        private Label lblTotalSales;
        private Label lblTotalPurchases;
        private DataGridView dgvLastProducts;
        private DataGridView dgvTopSellingProducts;
        private Button btnUpdate;
        private Button btnManufacture;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button btnExport;
    }
}