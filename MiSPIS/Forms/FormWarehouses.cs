using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiSPIS
{
    public partial class FormWarehouses : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";

        public FormWarehouses()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadWarehouses();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void LoadWarehouses()
        {
            string query = "SELECT WarehouseID, WarehouseName FROM Warehouses";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                DataTable warehousesTable = new DataTable();
                adapter.Fill(warehousesTable);
                dataGridViewWarehouses.DataSource = warehousesTable;

                // Set column headers in Russian
                dataGridViewWarehouses.Columns.Clear();

                dataGridViewWarehouses.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "WarehouseID",
                    HeaderText = "ID склада",
                    Name = "WarehouseID",
                    ReadOnly = true
                });
                dataGridViewWarehouses.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "WarehouseName",
                    HeaderText = "Название склада",
                    Name = "WarehouseName",
                    ReadOnly = true
                });
            }
        }
        private void buttonAddWarehouse_Click(object sender, EventArgs e)
        {
            string warehouseName = textBoxWarehouseName.Text;
            if (string.IsNullOrWhiteSpace(warehouseName))
            {
                MessageBox.Show("Пожалуйста, введите имя склада");
                return;
            }

            string query = "INSERT INTO Warehouses (WarehouseName) VALUES (@warehouseName)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@warehouseName", warehouseName);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Склад успешно добавлен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении склада: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            LoadWarehouses();
            textBoxWarehouseName.Clear();
        }

        private void buttonDeleteWarehouse_Click(object sender, EventArgs e)
        {
            if (dataGridViewWarehouses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите склад для удаления");
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить этот склад?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectedWarehouseID = Convert.ToInt32(dataGridViewWarehouses.SelectedRows[0].Cells["WarehouseID"].Value);

                string query = "DELETE FROM Warehouses WHERE WarehouseID = @warehouseID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@warehouseID", selectedWarehouseID);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Склад успешно удален");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении склада: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                LoadWarehouses();
            }
        }
    }
}