namespace MiSPIS
{
    partial class Form2
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
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.dataGridViewSaleItems = new System.Windows.Forms.DataGridView();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWarehouses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateSale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxcomboBoxProducts = new System.Windows.Forms.ComboBox();
            this.buttonAddToSale = new System.Windows.Forms.Button();
            this.buttonDeleteInvoiceItem = new System.Windows.Forms.Button();
            this.dateTimePickerInvoiceDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(320, 10);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.RowHeadersWidth = 51;
            this.dataGridViewSales.Size = new System.Drawing.Size(650, 150);
            this.dataGridViewSales.TabIndex = 0;
            // 
            // dataGridViewSaleItems
            // 
            this.dataGridViewSaleItems.AllowUserToAddRows = false;
            this.dataGridViewSaleItems.AllowUserToDeleteRows = false;
            this.dataGridViewSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleItems.Location = new System.Drawing.Point(320, 170);
            this.dataGridViewSaleItems.Name = "dataGridViewSaleItems";
            this.dataGridViewSaleItems.ReadOnly = true;
            this.dataGridViewSaleItems.RowHeadersWidth = 51;
            this.dataGridViewSaleItems.Size = new System.Drawing.Size(650, 150);
            this.dataGridViewSaleItems.TabIndex = 1;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(140, 35);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(170, 21);
            this.comboBoxClients.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Клиент";
            // 
            // comboBoxWarehouses
            // 
            this.comboBoxWarehouses.FormattingEnabled = true;
            this.comboBoxWarehouses.Location = new System.Drawing.Point(140, 63);
            this.comboBoxWarehouses.Name = "comboBoxWarehouses";
            this.comboBoxWarehouses.Size = new System.Drawing.Size(170, 21);
            this.comboBoxWarehouses.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Склад";
            // 
            // buttonCreateSale
            // 
            this.buttonCreateSale.Location = new System.Drawing.Point(10, 10);
            this.buttonCreateSale.Name = "buttonCreateSale";
            this.buttonCreateSale.Size = new System.Drawing.Size(120, 23);
            this.buttonCreateSale.TabIndex = 7;
            this.buttonCreateSale.Text = "Записать";
            this.buttonCreateSale.UseVisualStyleBackColor = true;
            this.buttonCreateSale.Click += new System.EventHandler(this.buttonCreateSale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Количество";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(140, 117);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(170, 20);
            this.textBoxQuantity.TabIndex = 17;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(140, 143);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(170, 20);
            this.textBoxPrice.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Товар";
            // 
            // comboBoxcomboBoxProducts
            // 
            this.comboBoxcomboBoxProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxcomboBoxProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxcomboBoxProducts.Location = new System.Drawing.Point(140, 90);
            this.comboBoxcomboBoxProducts.Name = "comboBoxcomboBoxProducts";
            this.comboBoxcomboBoxProducts.Size = new System.Drawing.Size(170, 21);
            this.comboBoxcomboBoxProducts.TabIndex = 22;
            // 
            // buttonAddToSale
            // 
            this.buttonAddToSale.Location = new System.Drawing.Point(320, 326);
            this.buttonAddToSale.Name = "buttonAddToSale";
            this.buttonAddToSale.Size = new System.Drawing.Size(125, 23);
            this.buttonAddToSale.TabIndex = 25;
            this.buttonAddToSale.Text = "Добавить товар";
            this.buttonAddToSale.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteInvoiceItem
            // 
            this.buttonDeleteInvoiceItem.Location = new System.Drawing.Point(450, 326);
            this.buttonDeleteInvoiceItem.Name = "buttonDeleteInvoiceItem";
            this.buttonDeleteInvoiceItem.Size = new System.Drawing.Size(125, 23);
            this.buttonDeleteInvoiceItem.TabIndex = 26;
            this.buttonDeleteInvoiceItem.Text = "Удалить товар";
            this.buttonDeleteInvoiceItem.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerInvoiceDate
            // 
            this.dateTimePickerInvoiceDate.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInvoiceDate.Location = new System.Drawing.Point(140, 10);
            this.dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            this.dateTimePickerInvoiceDate.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerInvoiceDate.TabIndex = 27;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 353);
            this.Controls.Add(this.dateTimePickerInvoiceDate);
            this.Controls.Add(this.buttonAddToSale);
            this.Controls.Add(this.buttonDeleteInvoiceItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxcomboBoxProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonCreateSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxWarehouses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.dataGridViewSaleItems);
            this.Controls.Add(this.dataGridViewSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.DataGridView dataGridViewSaleItems;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWarehouses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreateSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxcomboBoxProducts;
        private System.Windows.Forms.Button buttonAddToSale;
        private System.Windows.Forms.Button buttonDeleteInvoiceItem;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoiceDate;
    }
}