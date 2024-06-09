using System.Windows.Forms;

namespace MiSPIS
{
    partial class Form1
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
            this.dataGridViewInvoiceItems = new System.Windows.Forms.DataGridView();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAddToInvoice = new System.Windows.Forms.Button();
            this.buttonCreateInvoice = new System.Windows.Forms.Button();
            this.comboBoxSuppliers = new System.Windows.Forms.ComboBox();
            this.comboBoxWarehouses = new System.Windows.Forms.ComboBox();
            this.comboBoxResponsiblePersons = new System.Windows.Forms.ComboBox();
            this.dateTimePickerInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.buttonDeleteInvoiceItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInvoiceItems
            // 
            this.dataGridViewInvoiceItems.AllowUserToAddRows = false;
            this.dataGridViewInvoiceItems.AllowUserToDeleteRows = false;
            this.dataGridViewInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoiceItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewInvoiceItems.ColumnHeadersHeight = 29;
            this.dataGridViewInvoiceItems.Location = new System.Drawing.Point(427, 209);
            this.dataGridViewInvoiceItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewInvoiceItems.Name = "dataGridViewInvoiceItems";
            this.dataGridViewInvoiceItems.ReadOnly = true;
            this.dataGridViewInvoiceItems.RowHeadersWidth = 51;
            this.dataGridViewInvoiceItems.Size = new System.Drawing.Size(867, 185);
            this.dataGridViewInvoiceItems.TabIndex = 0;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProducts.Location = new System.Drawing.Point(187, 111);
            this.comboBoxProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(225, 24);
            this.comboBoxProducts.TabIndex = 4;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(187, 144);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(225, 22);
            this.textBoxQuantity.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(185, 176);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(225, 22);
            this.textBoxPrice.TabIndex = 6;
            // 
            // buttonAddToInvoice
            // 
            this.buttonAddToInvoice.Location = new System.Drawing.Point(427, 400);
            this.buttonAddToInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddToInvoice.Name = "buttonAddToInvoice";
            this.buttonAddToInvoice.Size = new System.Drawing.Size(167, 28);
            this.buttonAddToInvoice.TabIndex = 8;
            this.buttonAddToInvoice.Text = "Добавить товар";
            this.buttonAddToInvoice.UseVisualStyleBackColor = true;
            this.buttonAddToInvoice.Click += new System.EventHandler(this.buttonAddToInvoice_Click);
            // 
            // buttonCreateInvoice
            // 
            this.buttonCreateInvoice.Location = new System.Drawing.Point(13, 12);
            this.buttonCreateInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateInvoice.Name = "buttonCreateInvoice";
            this.buttonCreateInvoice.Size = new System.Drawing.Size(160, 28);
            this.buttonCreateInvoice.TabIndex = 17;
            this.buttonCreateInvoice.Text = "Записать";
            this.buttonCreateInvoice.Click += new System.EventHandler(this.buttonCreateInvoice_Click);
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(187, 43);
            this.comboBoxSuppliers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.Size = new System.Drawing.Size(225, 24);
            this.comboBoxSuppliers.TabIndex = 1;
            // 
            // comboBoxWarehouses
            // 
            this.comboBoxWarehouses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxWarehouses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxWarehouses.Location = new System.Drawing.Point(187, 78);
            this.comboBoxWarehouses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxWarehouses.Name = "comboBoxWarehouses";
            this.comboBoxWarehouses.Size = new System.Drawing.Size(225, 24);
            this.comboBoxWarehouses.TabIndex = 3;
            // 
            // comboBoxResponsiblePersons
            // 
            this.comboBoxResponsiblePersons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxResponsiblePersons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxResponsiblePersons.Location = new System.Drawing.Point(185, 368);
            this.comboBoxResponsiblePersons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxResponsiblePersons.Name = "comboBoxResponsiblePersons";
            this.comboBoxResponsiblePersons.Size = new System.Drawing.Size(220, 24);
            this.comboBoxResponsiblePersons.TabIndex = 7;
            // 
            // dateTimePickerInvoiceDate
            // 
            this.dateTimePickerInvoiceDate.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInvoiceDate.Location = new System.Drawing.Point(187, 12);
            this.dateTimePickerInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            this.dateTimePickerInvoiceDate.Size = new System.Drawing.Size(225, 22);
            this.dateTimePickerInvoiceDate.TabIndex = 0;
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.AllowUserToAddRows = false;
            this.dataGridViewInvoices.AllowUserToDeleteRows = false;
            this.dataGridViewInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewInvoices.ColumnHeadersHeight = 29;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(427, 12);
            this.dataGridViewInvoices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.ReadOnly = true;
            this.dataGridViewInvoices.RowHeadersWidth = 51;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(867, 185);
            this.dataGridViewInvoices.TabIndex = 9;
            this.dataGridViewInvoices.SelectionChanged += new System.EventHandler(this.dataGridViewInvoices_SelectionChanged);
            // 
            // buttonDeleteInvoiceItem
            // 
            this.buttonDeleteInvoiceItem.Location = new System.Drawing.Point(600, 400);
            this.buttonDeleteInvoiceItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteInvoiceItem.Name = "buttonDeleteInvoiceItem";
            this.buttonDeleteInvoiceItem.Size = new System.Drawing.Size(167, 28);
            this.buttonDeleteInvoiceItem.TabIndex = 9;
            this.buttonDeleteInvoiceItem.Text = "Удалить товар";
            this.buttonDeleteInvoiceItem.UseVisualStyleBackColor = true;
            this.buttonDeleteInvoiceItem.Click += new System.EventHandler(this.buttonDeleteInvoiceItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Поставщик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Склад";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "МОЛ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 434);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSuppliers);
            this.Controls.Add(this.dateTimePickerInvoiceDate);
            this.Controls.Add(this.dataGridViewInvoices);
            this.Controls.Add(this.dataGridViewInvoiceItems);
            this.Controls.Add(this.buttonAddToInvoice);
            this.Controls.Add(this.buttonCreateInvoice);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonDeleteInvoiceItem);
            this.Controls.Add(this.comboBoxWarehouses);
            this.Controls.Add(this.comboBoxResponsiblePersons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поступление товаров";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvoiceItems;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAddToInvoice;
        private System.Windows.Forms.Button buttonCreateInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.Button buttonDeleteInvoiceItem;
        private System.Windows.Forms.ComboBox comboBoxSuppliers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoiceDate;
        private System.Windows.Forms.ComboBox comboBoxWarehouses;
        private System.Windows.Forms.ComboBox comboBoxResponsiblePersons;
        private Label label5;
        private Label label6;
    }
}