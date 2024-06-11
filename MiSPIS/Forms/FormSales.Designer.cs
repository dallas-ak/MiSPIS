namespace MiSPIS
{
    partial class FormSales
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
            this.buttonShowStock = new System.Windows.Forms.Button();
            this.comboBoxResponsiblePersons = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.dataGridViewSales.Location = new System.Drawing.Point(320, 10);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.RowHeadersWidth = 51;
            this.dataGridViewSales.Size = new System.Drawing.Size(650, 150);
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
            this.dataGridViewSaleItems.Location = new System.Drawing.Point(320, 170);
            this.dataGridViewSaleItems.Name = "dataGridViewSaleItems";
            this.dataGridViewSaleItems.ReadOnly = true;
            this.dataGridViewSaleItems.RowHeadersWidth = 51;
            this.dataGridViewSaleItems.Size = new System.Drawing.Size(650, 150);
            this.dataGridViewSaleItems.TabIndex = 1;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxClients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(140, 35);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(170, 21);
            this.comboBoxClients.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Склад";
            // 
            // buttonCreateSale
            // 
            this.buttonCreateSale.Location = new System.Drawing.Point(10, 10);
            this.buttonCreateSale.Name = "buttonCreateSale";
            this.buttonCreateSale.Size = new System.Drawing.Size(120, 23);
            this.buttonCreateSale.TabIndex = 9;
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
            this.label3.TabIndex = 15;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Количество";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(140, 117);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(170, 20);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(140, 143);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(170, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Товар";
            // 
            // buttonAddToSale
            // 
            this.buttonAddToSale.Location = new System.Drawing.Point(320, 326);
            this.buttonAddToSale.Name = "buttonAddToSale";
            this.buttonAddToSale.Size = new System.Drawing.Size(125, 23);
            this.buttonAddToSale.TabIndex = 7;
            this.buttonAddToSale.Text = "Добавить товар";
            this.buttonAddToSale.UseVisualStyleBackColor = true;
            this.buttonAddToSale.Click += new System.EventHandler(this.buttonAddToSale_Click);
            // 
            // buttonDeleteSaleItem
            // 
            this.buttonDeleteSaleItem.Location = new System.Drawing.Point(450, 326);
            this.buttonDeleteSaleItem.Name = "buttonDeleteSaleItem";
            this.buttonDeleteSaleItem.Size = new System.Drawing.Size(125, 23);
            this.buttonDeleteSaleItem.TabIndex = 8;
            this.buttonDeleteSaleItem.Text = "Удалить товар";
            this.buttonDeleteSaleItem.UseVisualStyleBackColor = true;
            this.buttonDeleteSaleItem.Click += new System.EventHandler(this.buttonDeleteSaleItem_Click);
            // 
            // dateTimePickerSaleDate
            // 
            this.dateTimePickerSaleDate.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSaleDate.Location = new System.Drawing.Point(140, 10);
            this.dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            this.dateTimePickerSaleDate.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerSaleDate.TabIndex = 0;
            // 
            // comboBoxWarehouses
            // 
            this.comboBoxWarehouses.FormattingEnabled = true;
            this.comboBoxWarehouses.Location = new System.Drawing.Point(140, 63);
            this.comboBoxWarehouses.Name = "comboBoxWarehouses";
            this.comboBoxWarehouses.Size = new System.Drawing.Size(170, 21);
            this.comboBoxWarehouses.TabIndex = 14;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(140, 90);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(170, 21);
            this.comboBoxProducts.TabIndex = 15;
            // 
            // buttonShowStock
            // 
            this.buttonShowStock.Location = new System.Drawing.Point(845, 326);
            this.buttonShowStock.Name = "buttonShowStock";
            this.buttonShowStock.Size = new System.Drawing.Size(125, 23);
            this.buttonShowStock.TabIndex = 10;
            this.buttonShowStock.Text = "Показать остатки";
            this.buttonShowStock.UseVisualStyleBackColor = true;
            this.buttonShowStock.Click += new System.EventHandler(this.buttonShowStock_Click);
            // 
            // comboBoxResponsiblePersons
            // 
            this.comboBoxResponsiblePersons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxResponsiblePersons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxResponsiblePersons.Location = new System.Drawing.Point(140, 299);
            this.comboBoxResponsiblePersons.Name = "comboBoxResponsiblePersons";
            this.comboBoxResponsiblePersons.Size = new System.Drawing.Size(166, 21);
            this.comboBoxResponsiblePersons.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Менеджер";
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 353);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxResponsiblePersons);
            this.Controls.Add(this.buttonShowStock);
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
            this.Name = "FormSales";
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
        private System.Windows.Forms.Button buttonShowStock;
        private System.Windows.Forms.ComboBox comboBoxResponsiblePersons;
        private System.Windows.Forms.Label label6;
    }
}