using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiSPIS
{
    public partial class Form2 : Form
    {
        private readonly IDataAccess dataAccess;
        public string LastErrorMessage { get; private set; }

        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";
        MySqlDataAdapter adapter;
        DataTable clientsTable, warehousesTable, productsTable, salesTable, salesItemsTable;

        public Form2(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeDataGridViewColumns();
            LoadClients();
            LoadWarehouses();
            LoadProducts();
            LoadSales();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void InitializeDataGridViewColumns()
        {
            // Инициализация столбцов для dataGridViewSales
            dataGridViewSales.AutoGenerateColumns = false;
            dataGridViewSales.Columns.Clear();

            DataGridViewTextBoxColumn saleIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Номер",
                Name = "SaleID",
                DataPropertyName = "SaleID",
                ReadOnly = true
            };
            DataGridViewTextBoxColumn transactionIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Номер транзакции",
                Name = "TransactionID",
                DataPropertyName = "TransactionID",
                ReadOnly = true
            };
            DataGridViewTextBoxColumn saleDateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Дата продажи",
                Name = "SaleDate",
                DataPropertyName = "SaleDate",
                ReadOnly = true
            };
            DataGridViewTextBoxColumn clientColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Клиент",
                Name = "Client",
                DataPropertyName = "Client",
                ReadOnly = true
            };

            dataGridViewSales.Columns.AddRange(new DataGridViewColumn[]
            {
                saleIdColumn,
                transactionIdColumn,
                saleDateColumn,
                clientColumn
            });

            // Инициализация столбцов для dataGridViewSaleItems
            dataGridViewSaleItems.AutoGenerateColumns = false;
            dataGridViewSaleItems.Columns.Clear();

            DataGridViewTextBoxColumn productIdColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Номер",
                Name = "ProductID",
                DataPropertyName = "ProductID",
                ReadOnly = true
            };
            DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Товар",
                Name = "ProductName",
                DataPropertyName = "ProductName",
                ReadOnly = true
            };
            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Количество",
                Name = "Quantity",
                DataPropertyName = "Quantity",
                ReadOnly = true
            };
            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Цена",
                Name = "Price",
                DataPropertyName = "Price",
                ReadOnly = true
            };
            DataGridViewTextBoxColumn totalColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Сумма",
                Name = "Total",
                DataPropertyName = "Total",
                ReadOnly = true
            };

            dataGridViewSaleItems.Columns.AddRange(new DataGridViewColumn[]
            {
                productIdColumn,
                productNameColumn,
                quantityColumn,
                priceColumn,
                totalColumn
            });
        }

        private void LoadClients()
        {
            string query = "SELECT ClientID, ClientName FROM Clients";
            adapter = new MySqlDataAdapter(query, connection);
            clientsTable = new DataTable();
            adapter.Fill(clientsTable);
            comboBoxClients.DataSource = clientsTable;
            comboBoxClients.DisplayMember = "ClientName";
            comboBoxClients.ValueMember = "ClientID";
            comboBoxClients.SelectedIndex = -1;
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
        private void LoadSales()
        {
            string query = "SELECT SaleID, TransactionID, SaleDate, " +
                           "(SELECT ClientName FROM Clients WHERE ClientID = Sales.ClientID) AS Client " +
                           "FROM Sales";
            adapter = new MySqlDataAdapter(query, connection);
            salesTable = new DataTable();
            adapter.Fill(salesTable);

            dataGridViewSales.DataSource = salesTable; 
        }

        private void buttonAddToSale_Click(object sender, EventArgs e)
        {
            // Проверяем, что все поля заполнены
            if (string.IsNullOrWhiteSpace(comboBoxProducts.Text)
                || string.IsNullOrWhiteSpace(textBoxQuantity.Text)
                || string.IsNullOrWhiteSpace(textBoxPrice.Text))
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

            // Проверяем, существует ли уже такая позиция товара в dataGridViewSaleItems
            bool itemExists = false;
            foreach (DataGridViewRow row in dataGridViewSaleItems.Rows)
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
                dataGridViewSaleItems.Rows.Add(productId, productName, quantity, price, total);
            }
        }

        private void buttonCreateSale_Click(object sender, EventArgs e)
        {
            // Проверяем, что есть хотя бы одна строка в dataGridViewSaleItems
            if (dataGridViewSaleItems.Rows.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы одну позицию в продажу перед ее созданием");
                return;
            }

            // Проверяем, что все позиции продажи заполнены
            if (!AreSaleItemsValid())
            {
                MessageBox.Show("Заполните все позиции продажи перед созданием");
                return;
            }

            connection.Open();

            // Генерация уникального идентификатора транзакции
            string transactionId = GenerateTransactionId();

            // Вставка продажи
            string query = "INSERT INTO Sales (SaleDate, ClientID, TransactionID) VALUES (@date, @client, @transactionId)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@date", dateTimePickerSaleDate.Value);
            cmd.Parameters.AddWithValue("@client", comboBoxClients.SelectedValue);
            cmd.Parameters.AddWithValue("@transactionId", transactionId);
            cmd.ExecuteNonQuery();
            long saleId = cmd.LastInsertedId;

            // Вставка позиций продажи
            foreach (DataGridViewRow row in dataGridViewSaleItems.Rows)
            {
                if (row.IsNewRow) continue;
                query = "INSERT INTO SalesItems (SaleID, ProductID, Quantity, Price, Total) VALUES (@saleId, @productId, @quantity, @price, @total)";
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@saleId", saleId);
                cmd.Parameters.AddWithValue("@productId", row.Cells["ProductID"].Value);
                cmd.Parameters.AddWithValue("@quantity", row.Cells["Quantity"].Value);
                cmd.Parameters.AddWithValue("@price", row.Cells["Price"].Value);
                cmd.Parameters.AddWithValue("@total", row.Cells["Total"].Value);
                cmd.ExecuteNonQuery();
            }
            connection.Close();
            LoadSales();
        }

        private bool AreSaleItemsValid()
        {
            foreach (DataGridViewRow row in dataGridViewSaleItems.Rows)
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

        private string GenerateTransactionId()
        {
            Random random = new Random();
            return random.Next(100000000, 999999999).ToString();
        }


        private void dataGridViewSales_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSales.SelectedRows.Count > 0)
            {
                int saleId = (int)dataGridViewSales.SelectedRows[0].Cells["SaleID"].Value;
                LoadSaleItems(saleId);
            }
        }

        private void LoadSaleItems(int saleId)
        {
            string query = "SELECT ProductID, " +
                           "(SELECT ProductName FROM Products WHERE ProductID = SalesItems.ProductID) AS ProductName, " +
                           "Quantity, Price, Total " +
                           "FROM SalesItems WHERE SaleID = @saleId";
            adapter = new MySqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@saleId", saleId);
            salesItemsTable = new DataTable();
            adapter.Fill(salesItemsTable);

            // Очищаем строки dataGridViewSaleItems перед добавлением новых данных
            dataGridViewSaleItems.Rows.Clear();

            foreach (DataRow row in salesItemsTable.Rows)
            {
                dataGridViewSaleItems.Rows.Add(row["ProductID"], row["ProductName"], row["Quantity"], row["Price"], row["Total"]);
            }
        }

        private void buttonDeleteSaleItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewSaleItems.SelectedRows)
            {
                dataGridViewSaleItems.Rows.Remove(row);
            }
        }

    }
}