namespace MiSPIS
{
    partial class FormReportsManagers
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
            this.dataGridViewReportsManagers = new System.Windows.Forms.DataGridView();
            this.comboBoxResponsible = new System.Windows.Forms.ComboBox();
            this.ButtonGenerateManagersReport = new System.Windows.Forms.Button();
            this.labelTotalSalesAmount = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportsManagers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReportsManagers
            // 
            this.dataGridViewReportsManagers.AllowUserToAddRows = false;
            this.dataGridViewReportsManagers.AllowUserToDeleteRows = false;
            this.dataGridViewReportsManagers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReportsManagers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewReportsManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportsManagers.Location = new System.Drawing.Point(14, 68);
            this.dataGridViewReportsManagers.Name = "dataGridViewReportsManagers";
            this.dataGridViewReportsManagers.ReadOnly = true;
            this.dataGridViewReportsManagers.RowHeadersWidth = 51;
            this.dataGridViewReportsManagers.Size = new System.Drawing.Size(511, 329);
            this.dataGridViewReportsManagers.TabIndex = 0;
            // 
            // comboBoxResponsible
            // 
            this.comboBoxResponsible.FormattingEnabled = true;
            this.comboBoxResponsible.Location = new System.Drawing.Point(14, 41);
            this.comboBoxResponsible.Name = "comboBoxResponsible";
            this.comboBoxResponsible.Size = new System.Drawing.Size(249, 21);
            this.comboBoxResponsible.TabIndex = 2;
            // 
            // ButtonGenerateManagersReport
            // 
            this.ButtonGenerateManagersReport.Location = new System.Drawing.Point(275, 39);
            this.ButtonGenerateManagersReport.Name = "ButtonGenerateManagersReport";
            this.ButtonGenerateManagersReport.Size = new System.Drawing.Size(250, 23);
            this.ButtonGenerateManagersReport.TabIndex = 4;
            this.ButtonGenerateManagersReport.Text = "Сформировать отчет";
            this.ButtonGenerateManagersReport.UseVisualStyleBackColor = true;
            this.ButtonGenerateManagersReport.Click += new System.EventHandler(this.ButtonGenerateManagersReport_Click);
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
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(14, 12);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerStartDate.TabIndex = 1;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(167, 12);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerEndDate.TabIndex = 6;
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Location = new System.Drawing.Point(330, 12);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(195, 21);
            this.comboBoxPeriod.TabIndex = 7;
            this.comboBoxPeriod.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResponsible_SelectedIndexChanged);
            // 
            // FormReportsManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 422);
            this.Controls.Add(this.comboBoxPeriod);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.labelTotalSalesAmount);
            this.Controls.Add(this.ButtonGenerateManagersReport);
            this.Controls.Add(this.comboBoxResponsible);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.dataGridViewReportsManagers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormReportsManagers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportsManagers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReportsManagers;
        private System.Windows.Forms.ComboBox comboBoxResponsible;
        private System.Windows.Forms.Button ButtonGenerateManagersReport;
        private System.Windows.Forms.Label labelTotalSalesAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
    }
}