using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiSPIS
{
    public partial class FormProducts : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";

        public FormProducts()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadProducts();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void LoadProducts()
        {
            string query = "SELECT ProductID, ProductName FROM Products";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                DataTable ProductsTable = new DataTable();
                adapter.Fill(ProductsTable);
                dataGridViewProducts.DataSource = ProductsTable;

                // Set column headers in Russian
                dataGridViewProducts.Columns.Clear();

                dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ProductID",
                    HeaderText = "ID товара",
                    Name = "ProductID",
                    ReadOnly = true
                });
                dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ProductName",
                    HeaderText = "Наименование товара",
                    Name = "ProductName",
                    ReadOnly = true
                });
            }
        }
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string ProductName = textBoxProductName.Text;
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                MessageBox.Show("Пожалуйста, введите название товара");
                return;
            }

            string query = "INSERT INTO Products (ProductName) VALUES (@ProductName)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductName", ProductName);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Товар успешно добавлен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении товара: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            LoadProducts();
            textBoxProductName.Clear();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите товар для удаления");
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectedProductID = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value);

                string query = "DELETE FROM Products WHERE ProductID = @ProductID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", selectedProductID);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Товар успешно удален");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении товара: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                LoadProducts();
            }
        }
    }
}