using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiSPIS
{
    public partial class FormStock : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";
        private MySqlDataAdapter adapter;
        private DataTable warehousesTable, stockTable;

        public FormStock()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeDataGridViewColumns();
            LoadWarehouses();
        }


        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void InitializeDataGridViewColumns()
        {
            dataGridViewStock.AutoGenerateColumns = false;
            dataGridViewStock.Columns.Clear();

            DataGridViewTextBoxColumn warehouseColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Склад",
                Name = "WarehouseName",
                DataPropertyName = "WarehouseName",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn productColumn = new DataGridViewTextBoxColumn
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
            dataGridViewStock.Columns.AddRange(new DataGridViewColumn[]
            {
                warehouseColumn,
                productColumn,
                quantityColumn
            });
        }

        private void LoadWarehouses()
        {
            string query = "SELECT WarehouseID, WarehouseName FROM Warehouses";
            adapter = new MySqlDataAdapter(query, connection);
            warehousesTable = new DataTable();
            adapter.Fill(warehousesTable);

            // Добавляем "Все склады" в список
            DataRow allWarehousesRow = warehousesTable.NewRow();
            allWarehousesRow["WarehouseID"] = -1;
            allWarehousesRow["WarehouseName"] = "Все склады";
            warehousesTable.Rows.InsertAt(allWarehousesRow, 0);

            comboBoxWarehouses.DataSource = warehousesTable;
            comboBoxWarehouses.DisplayMember = "WarehouseName";
            comboBoxWarehouses.ValueMember = "WarehouseID";
            comboBoxWarehouses.SelectedIndex = 0;
        }

        private void buttonLoadStock_Click(object sender, EventArgs e)
        {
            LoadStock();
        }

        private void LoadStock()
        {
            int selectedWarehouseId = (int)comboBoxWarehouses.SelectedValue;
            string query;

            if (selectedWarehouseId == -1)
            {
                query = @"SELECT w.WarehouseName, p.ProductName, s.Quantity
                          FROM stock s
                          JOIN Warehouses w ON s.WarehouseID = w.WarehouseID
                          JOIN Products p ON s.ProductID = p.ProductID";
            }
            else
            {
                query = @"SELECT w.WarehouseName, p.ProductName, s.Quantity
                          FROM stock s
                          JOIN Warehouses w ON s.WarehouseID = w.WarehouseID
                          JOIN Products p ON s.ProductID = p.ProductID
                          WHERE s.WarehouseID = @warehouseID";
            }

            adapter = new MySqlDataAdapter(query, connection);

            if (selectedWarehouseId != -1)
            {
                adapter.SelectCommand.Parameters.AddWithValue("@warehouseID", selectedWarehouseId);
            }

            stockTable = new DataTable();
            adapter.Fill(stockTable);
            dataGridViewStock.DataSource = stockTable;
        }
    }
}