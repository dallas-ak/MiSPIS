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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateSale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddToSale = new System.Windows.Forms.Button();
            this.buttonDeleteSaleItem = new System.Windows.Forms.Button();
            this.dateTimePickerSaleDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxWarehouses = new System.Windows.Forms.ComboBox();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToDeleteRows = false;
            this.dataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSales.ColumnHeadersHeight = 29;
            this.dataGridViewSales.Location = new System.Drawing.Point(427, 12);
            this.dataGridViewSales.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.RowHeadersWidth = 51;
            this.dataGridViewSales.Size = new System.Drawing.Size(867, 185);
            this.dataGridViewSales.TabIndex = 0;
            this.dataGridViewSales.SelectionChanged += new System.EventHandler(this.dataGridViewSales_SelectionChanged);
            // 
            // dataGridViewSaleItems
            // 
            this.dataGridViewSaleItems.AllowUserToAddRows = false;
            this.dataGridViewSaleItems.AllowUserToDeleteRows = false;
            this.dataGridViewSaleItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSaleItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewSaleItems.ColumnHeadersHeight = 29;
            this.dataGridViewSaleItems.Location = new System.Drawing.Point(427, 209);
            this.dataGridViewSaleItems.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSaleItems.Name = "dataGridViewSaleItems";
            this.dataGridViewSaleItems.ReadOnly = true;
            this.dataGridViewSaleItems.RowHeadersWidth = 51;
            this.dataGridViewSaleItems.Size = new System.Drawing.Size(867, 185);
            this.dataGridViewSaleItems.TabIndex = 1;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxClients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(187, 43);
            this.comboBoxClients.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(225, 24);
            this.comboBoxClients.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Склад";
            // 
            // buttonCreateSale
            // 
            this.buttonCreateSale.Location = new System.Drawing.Point(13, 12);
            this.buttonCreateSale.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateSale.Name = "buttonCreateSale";
            this.buttonCreateSale.Size = new System.Drawing.Size(160, 28);
            this.buttonCreateSale.TabIndex = 8;
            this.buttonCreateSale.Text = "Записать";
            this.buttonCreateSale.UseVisualStyleBackColor = true;
            this.buttonCreateSale.Click += new System.EventHandler(this.buttonCreateSale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(187, 144);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(225, 20);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(187, 176);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(225, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Товар";
            // 
            // buttonAddToSale
            // 
            this.buttonAddToSale.Location = new System.Drawing.Point(427, 401);
            this.buttonAddToSale.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddToSale.Name = "buttonAddToSale";
            this.buttonAddToSale.Size = new System.Drawing.Size(167, 28);
            this.buttonAddToSale.TabIndex = 6;
            this.buttonAddToSale.Text = "Добавить товар";
            this.buttonAddToSale.UseVisualStyleBackColor = true;
            this.buttonAddToSale.Click += new System.EventHandler(this.buttonAddToSale_Click);
            // 
            // buttonDeleteSaleItem
            // 
            this.buttonDeleteSaleItem.Location = new System.Drawing.Point(600, 401);
            this.buttonDeleteSaleItem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteSaleItem.Name = "buttonDeleteSaleItem";
            this.buttonDeleteSaleItem.Size = new System.Drawing.Size(167, 28);
            this.buttonDeleteSaleItem.TabIndex = 7;
            this.buttonDeleteSaleItem.Text = "Удалить товар";
            this.buttonDeleteSaleItem.UseVisualStyleBackColor = true;
            this.buttonDeleteSaleItem.Click += new System.EventHandler(this.buttonDeleteSaleItem_Click);
            // 
            // dateTimePickerSaleDate
            // 
            this.dateTimePickerSaleDate.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSaleDate.Location = new System.Drawing.Point(187, 12);
            this.dateTimePickerSaleDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            this.dateTimePickerSaleDate.Size = new System.Drawing.Size(225, 20);
            this.dateTimePickerSaleDate.TabIndex = 0;
            // 
            // comboBoxWarehouses
            // 
            this.comboBoxWarehouses.FormattingEnabled = true;
            this.comboBoxWarehouses.Location = new System.Drawing.Point(187, 78);
            this.comboBoxWarehouses.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxWarehouses.Name = "comboBoxWarehouses";
            this.comboBoxWarehouses.Size = new System.Drawing.Size(225, 24);
            this.comboBoxWarehouses.TabIndex = 14;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(187, 111);
            this.comboBoxProducts.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(225, 24);
            this.comboBoxProducts.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 434);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.comboBoxWarehouses);
            this.Controls.Add(this.dateTimePickerSaleDate);
            this.Controls.Add(this.buttonAddToSale);
            this.Controls.Add(this.buttonDeleteSaleItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonCreateSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.dataGridViewSaleItems);
            this.Controls.Add(this.dataGridViewSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реализация";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreateSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddToSale;
        private System.Windows.Forms.Button buttonDeleteSaleItem;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaleDate;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.ComboBox comboBoxWarehouses;
    }
}