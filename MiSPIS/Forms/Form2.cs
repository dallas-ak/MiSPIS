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
        DataTable productsTable, clientsTable, salesTable, saleItemsTable, warehousesTable;

        public Form2(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeDataGridViewColumns();
            LoadClients();
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
                HeaderText = "Номер продажи",
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
                HeaderText = "Номер товара",
                Name = "ProductID",
                DataPropertyName = "ProductID",
                ReadOnly = true
            };
            DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Название товара",
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

        private void LoadProducts()
        {
            string query = "SELECT ProductID, ProductName FROM Products";
            adapter = new MySqlDataAdapter(query, connection);
            productsTable = new DataTable();
            adapter.Fill(productsTable);
            comboBoxWarehouses.DataSource = productsTable;
            comboBoxWarehouses.DisplayMember = "ProductName";
            comboBoxWarehouses.ValueMember = "ProductID";
            comboBoxWarehouses.SelectedIndex = -1;
        }
        private void LoadWarehouses()
        {
            string query = "SELECT WarehouseID, WarehouseName FROM Warehouses";
            adapter = new MySqlDataAdapter(query, connection);
            warehousesTable = new DataTable();
            adapter.Fill(warehousesTable);
            comboBoxcomboBoxProducts.DataSource = warehousesTable;
            comboBoxcomboBoxProducts.DisplayMember = "WarehouseName";
            comboBoxcomboBoxProducts.ValueMember = "WarehouseID";
            comboBoxcomboBoxProducts.SelectedIndex = -1;
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
                           "(SELECT ProductName FROM Products WHERE ProductID = SaleItems.ProductID) AS ProductName, " +
                           "Quantity, Price, Total " +
                           "FROM SaleItems WHERE SaleID = @saleId";
            adapter = new MySqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@saleId", saleId);
            saleItemsTable = new DataTable();
            adapter.Fill(saleItemsTable);

            // Очищаем строки dataGridViewSaleItems перед добавлением новых данных
            dataGridViewSaleItems.Rows.Clear();

            foreach (DataRow row in saleItemsTable.Rows)
            {
                dataGridViewSaleItems.Rows.Add(row["ProductID"], row["ProductName"], row["Quantity"], row["Price"], row["Total"]);
            }
        }

        private void buttonAddToSale_Click(object sender, EventArgs e)
        {
            // Проверяем, что все поля заполнены
            if (string.IsNullOrWhiteSpace(comboBoxWarehouses.Text)
                || string.IsNullOrWhiteSpace(textBoxQuantity.Text)
                || string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show("Добавьте данные о товаре");
                return;
            }

            // Получаем ProductID из выбранного продукта
            int productId = (int)comboBoxWarehouses.SelectedValue;

            // Получаем название продукта
            string productName = comboBoxWarehouses.Text;

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
            // Ваш код для создания новой продажи
        }
    }
}