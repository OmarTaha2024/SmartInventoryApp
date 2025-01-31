namespace SmartInventoryApp
{
    partial class Report
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
            dataGridViewReport = new DataGridView();
            cmbReportType = new ComboBox();
            label1 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnExportReport = new Button();
            btnGenerateReport = new Button();
            btnBack = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.BackgroundColor = SystemColors.Control;
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(14, 12);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new Size(683, 347);
            dataGridViewReport.TabIndex = 0;
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(751, 72);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(212, 28);
            cmbReportType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Brown;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(751, 37);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 2;
            label1.Text = "Report Type";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(751, 199);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 3;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(751, 135);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Brown;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(751, 112);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 5;
            label2.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Brown;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(751, 176);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 6;
            label3.Text = "End Date";
            // 
            // btnExportReport
            // 
            btnExportReport.Location = new Point(751, 435);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(135, 29);
            btnExportReport.TabIndex = 7;
            btnExportReport.Text = "Export To Csv";
            btnExportReport.UseVisualStyleBackColor = true;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(828, 269);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(135, 29);
            btnGenerateReport.TabIndex = 8;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(489, 435);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // button1
            // 
            button1.Location = new Point(931, 435);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 10;
            button1.Text = "Export To Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(1116, 492);
            Controls.Add(button1);
            Controls.Add(btnBack);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnExportReport);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpStartDate);
            Controls.Add(dtpEndDate);
            Controls.Add(label1);
            Controls.Add(cmbReportType);
            Controls.Add(dataGridViewReport);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Report";
            Text = "Report Page";
            Load += Report_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReport;
        private ComboBox cmbReportType;
        private Label label1;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label2;
        private Label label3;
        private Button btnExportReport;
        private Button btnGenerateReport;
        private Button btnBack;
        private Button button1;
    }
}