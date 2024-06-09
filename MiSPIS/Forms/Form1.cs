using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiSPIS
{
    public partial class Form1 : Form
    {
        private readonly IDataAccess dataAccess;
        public string LastErrorMessage { get; private set; }         

        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";
        MySqlDataAdapter adapter;
        DataTable productsTable, suppliersTable, invoicesTable, invoiceItemsTable, warehousesTable, responsiblePersonsTable;

        public Form1(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeDataGridViewColumns();
            LoadSuppliers();
            LoadWarehouses();
            LoadResponsiblePersons();
            LoadProducts();
            LoadInvoices();
        }
        private void InitializeDatabaseConnection()
        {
          //   string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MiSPIS"].ConnectionString;
             connection = new MySqlConnection(connectionString);
        }
        private void InitializeDataGridViewColumns()
        {
            // Initialize columns for dataGridViewInvoices
            dataGridViewInvoiceItems.AutoGenerateColumns = false;
            dataGridViewInvoices.Columns.Clear();

            DataGridViewTextBoxColumn invoiceIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Номер",
                Name = "InvoiceID",
                DataPropertyName = "InvoiceID",
                ReadOnly = true
            };
            DataGridViewTextBoxColumn invoiceDateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Дата",
                Name = "InvoiceDate",
                DataPropertyName = "InvoiceDate",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn supplierColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Поставщик",
                Name = "Supplier",
                DataPropertyName = "Supplier",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn warehouseColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Склад",
                Name = "Warehouse",
                DataPropertyName = "Warehouse",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn responsiblePersonColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "МОЛ",
                Name = "ResponsiblePerson",
                DataPropertyName = "ResponsiblePerson",
                ReadOnly = true
            };

            dataGridViewInvoices.Columns.AddRange(new DataGridViewColumn[]
            {
                invoiceIdColumn,
                invoiceDateColumn,
                supplierColumn,
                warehouseColumn,
                responsiblePersonColumn
            });

            // Initialize columns for dataGridViewInvoiceItems
            dataGridViewInvoiceItems.AutoGenerateColumns = false;
            dataGridViewInvoiceItems.Columns.Clear();

            DataGridViewTextBoxColumn productIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Номер",
                Name = "ProductID",
                DataPropertyName = "ProductID",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Наименование товара",
                Name = "ProductName",
                DataPropertyName = "ProductName",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Количество",
                Name = "Quantity",
                DataPropertyName = "Quantity"
            };

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Цена",
                Name = "Price",
                DataPropertyName = "Price"

            };

            DataGridViewTextBoxColumn totalColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Сумма",
                Name = "Total",
                DataPropertyName = "Total",
                ReadOnly = true
            };
            dataGridViewInvoiceItems.Columns.AddRange(new DataGridViewColumn[]
            {
                productIdColumn,
                productNameColumn,
                quantityColumn,
                priceColumn,
                totalColumn
            });
        }

        private void LoadSuppliers() 
        {
            string query = "SELECT SupplierID, SupplierName FROM Suppliers";
            adapter = new MySqlDataAdapter(query, connection);
            suppliersTable = new DataTable();
            adapter.Fill(suppliersTable);
            comboBoxSuppliers.DataSource = suppliersTable; 
            comboBoxSuppliers.DisplayMember = "SupplierName"; 
            comboBoxSuppliers.ValueMember = "SupplierID"; 
            comboBoxSuppliers.SelectedIndex = -1;
        }
        private void LoadWarehouses() 
        { 
            string query = "SELECT WarehouseID, WarehouseName FROM Warehouses"; 
            adapter = new MySqlDataAdapter(query, connection); 
            warehousesTable = new DataTable(); 
            adapter.Fill(warehousesTable); 
            comboBoxWarehouses.DataSource = warehousesTable; 
            comboBoxWarehouses.DisplayMember = "WarehouseName"; 
            comboBoxWarehouses.ValueMember = "WarehouseID"; 
            comboBoxWarehouses.SelectedIndex = -1; 
        }
        private void LoadResponsiblePersons() 
        { 
            string query = "SELECT PersonID, PersonName FROM ResponsiblePersons"; 
            adapter = new MySqlDataAdapter(query, connection); 
            responsiblePersonsTable = new DataTable(); 
            adapter.Fill(responsiblePersonsTable); 
            comboBoxResponsiblePersons.DataSource = responsiblePersonsTable; 
            comboBoxResponsiblePersons.DisplayMember = "PersonName"; 
            comboBoxResponsiblePersons.ValueMember = "PersonID"; 
            comboBoxResponsiblePersons.SelectedIndex = -1; 
        }
        private void LoadProducts()
        {
            string query = "SELECT ProductID, ProductName FROM Products";
            adapter = new MySqlDataAdapter(query, connection);
            productsTable = new DataTable();
            adapter.Fill(productsTable);
            comboBoxProducts.DataSource = productsTable;
            comboBoxProducts.DisplayMember = "ProductName";
            comboBoxProducts.ValueMember = "ProductID";
            comboBoxProducts.SelectedIndex = -1;
        }
        private void buttonAddToInvoice_Click(object sender, EventArgs e)
        {
            // Проверяем, что все поля заполнены
            if (string.IsNullOrWhiteSpace(comboBoxProducts.Text) ||
                string.IsNullOrWhiteSpace(textBoxQuantity.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrice.Text) )
  
            {
                MessageBox.Show("Добавьте данные о товаре");
                return;
            }

            // Получаем ProductID из выбранного продукта
            int productId = (int)comboBoxProducts.SelectedValue;

            // Получаем название продукта
            string productName = comboBoxProducts.Text;

            // Парсим количество
            if (!int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                MessageBox.Show("Проверьте количество товара");
                return;
            }

            // Парсим цену
            if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                MessageBox.Show("Проверьте цену товара");
                return;
            }

            // Проверяем, существует ли уже такая позиция товара в dataGridViewInvoiceItems
            bool itemExists = false;
            foreach (DataGridViewRow row in dataGridViewInvoiceItems.Rows)
            {
                if (row.Cells["ProductID"].Value != null && Convert.ToInt32(row.Cells["ProductID"].Value) == productId)
                {
                    // Если позиция товара уже существует, обновляем количество и выходим из цикла
                    int existingQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    row.Cells["Quantity"].Value = existingQuantity + quantity;

                    // Вычисляем новую сумму для этой позиции
                    decimal total = (existingQuantity + quantity) * price;
                    row.Cells["Total"].Value = total;

                    itemExists = true;
                    break;
                }
            }

            if (!itemExists)
            {
                // Если позиция товара не существует, добавляем новую строку
                decimal total = quantity * price;
                dataGridViewInvoiceItems.Rows.Add(productId, productName, quantity, price, total);
            }
        }
        private bool AreInvoiceItemsValid()
        {
            foreach (DataGridViewRow row in dataGridViewInvoiceItems.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Проверяем, что ячейка не пустая
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void buttonCreateInvoice_Click(object sender, EventArgs e)
        {
            //xUnit тест
            // Проверяем, что есть хотя бы одна строка в dataGridViewInvoiceItems
            if (dataGridViewInvoiceItems.Rows.Count == 0)
            {
                LastErrorMessage = "Проверка теста на добавление";
                MessageBox.Show(LastErrorMessage);
                return;
            }
            //xUnit тест


            // Проверяем, что есть хотя бы одна строка в dataGridViewInvoiceItems
            if (dataGridViewInvoiceItems.Rows.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы одну позицию в счет перед его созданием");
                return;
            }

            // Проверяем, что все позиции накладной заполнены
            if (!AreInvoiceItemsValid())
            {
                MessageBox.Show("Заполните все позиции накладной перед созданием");
                return;
            }

            connection.Open();
            string query = "INSERT INTO Invoices (InvoiceDate, SupplierID, WarehouseID, ResponsiblePerson) VALUES (@date, @supplier, @warehouse, @person)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@date", dateTimePickerInvoiceDate.Value);
            cmd.Parameters.AddWithValue("@supplier", comboBoxSuppliers.SelectedValue);  
            cmd.Parameters.AddWithValue("@warehouse",comboBoxWarehouses.SelectedValue); 
            cmd.Parameters.AddWithValue("@person",comboBoxResponsiblePersons.SelectedValue);
            cmd.ExecuteNonQuery();
            long invoiceId = cmd.LastInsertedId;

            foreach (DataGridViewRow row in dataGridViewInvoiceItems.Rows)
            {
                if (row.IsNewRow) continue;
                query = "INSERT INTO InvoiceItems (InvoiceID, ProductID, Quantity, Price, Total) VALUES (@invoiceId, @productId, @quantity, @price, @total)";
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@invoiceId", invoiceId);
                cmd.Parameters.AddWithValue("@productId", row.Cells["ProductID"].Value);
                cmd.Parameters.AddWithValue("@quantity", row.Cells["Quantity"].Value);
                cmd.Parameters.AddWithValue("@price", row.Cells["Price"].Value);
                cmd.Parameters.AddWithValue("@total", row.Cells["Total"].Value);

                cmd.ExecuteNonQuery();
            }
            connection.Close();
            LoadInvoices();
        }
        private void LoadInvoices()
        {
            string query = "SELECT InvoiceID, InvoiceDate, " +
                           "(SELECT SupplierName FROM Suppliers WHERE SupplierID = Invoices.SupplierID) AS Supplier, " +
                           "(SELECT WarehouseName FROM Warehouses WHERE WarehouseID = Invoices.WarehouseID) AS Warehouse, " +
                           "(SELECT PersonName FROM ResponsiblePersons WHERE PersonID = Invoices.ResponsiblePerson) AS ResponsiblePerson " +
                           "FROM Invoices";
            adapter = new MySqlDataAdapter(query, connection);
            invoicesTable = new DataTable();
            adapter.Fill(invoicesTable);

            dataGridViewInvoices.DataSource = invoicesTable;
        }
        private void dataGridViewInvoices_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                int invoiceId = (int)dataGridViewInvoices.SelectedRows[0].Cells["InvoiceID"].Value;
                LoadInvoiceItems(invoiceId);
            }
        }
        private void LoadInvoiceItems(int invoiceId)
        {
            string query = "SELECT ProductID, " +
                           "(SELECT ProductName FROM Products WHERE ProductID = InvoiceItems.ProductID) AS ProductName, " +
                           "Quantity, Price, Total " +
                           "FROM InvoiceItems WHERE InvoiceID = @invoiceId";
            adapter = new MySqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@invoiceId", invoiceId);
            invoiceItemsTable = new DataTable();
            adapter.Fill(invoiceItemsTable);

            // Очищаем строки dataGridViewInvoiceItems перед добавлением новых данных
            dataGridViewInvoiceItems.Rows.Clear();

            foreach (DataRow row in invoiceItemsTable.Rows)
            {
                dataGridViewInvoiceItems.Rows.Add(row["ProductID"], row["ProductName"], row["Quantity"], row["Price"], row["Total"]);
            }
        }

        private void buttonDeleteInvoiceItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewInvoiceItems.SelectedRows)
            {
                dataGridViewInvoiceItems.Rows.Remove(row);
            }
        }

    }
}