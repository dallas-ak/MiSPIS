namespace MiSPIS
{
    partial class FormReportsSales
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
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            this.dateTimePickerReportDate = new System.Windows.Forms.DateTimePicker();
            this.buttonGenerateSalesReport = new System.Windows.Forms.Button();
            this.labelTotalSalesAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.AllowUserToAddRows = false;
            this.dataGridViewReports.AllowUserToDeleteRows = false;
            this.dataGridViewReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Location = new System.Drawing.Point(14, 68);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.ReadOnly = true;
            this.dataGridViewReports.RowHeadersWidth = 51;
            this.dataGridViewReports.Size = new System.Drawing.Size(511, 329);
            this.dataGridViewReports.TabIndex = 0;
            // 
            // dateTimePickerReportDate
            // 
            this.dateTimePickerReportDate.Location = new System.Drawing.Point(13, 13);
            this.dateTimePickerReportDate.Name = "dateTimePickerReportDate";
            this.dateTimePickerReportDate.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerReportDate.TabIndex = 1;
            // 
            // buttonGenerateSalesReport
            // 
            this.buttonGenerateSalesReport.Location = new System.Drawing.Point(12, 39);
            this.buttonGenerateSalesReport.Name = "buttonGenerateSalesReport";
            this.buttonGenerateSalesReport.Size = new System.Drawing.Size(249, 23);
            this.buttonGenerateSalesReport.TabIndex = 3;
            this.buttonGenerateSalesReport.Text = "Сформировать отчет по продажам";
            this.buttonGenerateSalesReport.UseVisualStyleBackColor = true;
            this.buttonGenerateSalesReport.Click += new System.EventHandler(this.ButtonGenerateSalesReport_Click);
            // 
            // labelTotalSalesAmount
            // 
            this.labelTotalSalesAmount.AutoSize = true;
            this.labelTotalSalesAmount.Location = new System.Drawing.Point(250, 400);
            this.labelTotalSalesAmount.Name = "labelTotalSalesAmount";
            this.labelTotalSalesAmount.Size = new System.Drawing.Size(161, 15);
            this.labelTotalSalesAmount.TabIndex = 5;
            this.labelTotalSalesAmount.Text = "Общая сумма всех продаж";
            // 
            // FormReportsSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 422);
            this.Controls.Add(this.labelTotalSalesAmount);
            this.Controls.Add(this.buttonGenerateSalesReport);
            this.Controls.Add(this.dateTimePickerReportDate);
            this.Controls.Add(this.dataGridViewReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormReportsSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReports;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportDate;
        private System.Windows.Forms.Button buttonGenerateSalesReport;
        private System.Windows.Forms.Label labelTotalSalesAmount;
    }
}