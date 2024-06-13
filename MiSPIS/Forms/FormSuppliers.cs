using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiSPIS
{
    public partial class FormSuppliers : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";
        public FormSuppliers()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadSuppliers();
        }
        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }
        private void LoadSuppliers()
        {
            string query = "SELECT SupplierID, SupplierName FROM Suppliers";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                DataTable SuppliersTable = new DataTable();
                adapter.Fill(SuppliersTable);
                dataGridViewSuppliers.DataSource = SuppliersTable;

                // Set column headers in Russian
                dataGridViewSuppliers.Columns.Clear();
                dataGridViewSuppliers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SupplierID",
                    HeaderText = "ID склада",
                    Name = "SupplierID",
                    ReadOnly = true
                });
                dataGridViewSuppliers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SupplierName",
                    HeaderText = "Название склада",
                    Name = "SupplierName",
                    ReadOnly = true
                });
            }
        }
        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            string SupplierName = textBoxSupplierName.Text;
            if (string.IsNullOrWhiteSpace(SupplierName))
            {
                MessageBox.Show("Пожалуйста, введите имя склада");
                return;
            }
            string query = "INSERT INTO Suppliers (SupplierName) VALUES (@SupplierName)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SupplierName", SupplierName);
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

            LoadSuppliers();
            textBoxSupplierName.Clear();
        }
        private void buttonDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите склад для удаления");
                return;
            }
            if (MessageBox.Show("Вы уверены, что хотите удалить этот склад?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectedSupplierID = Convert.ToInt32(dataGridViewSuppliers.SelectedRows[0].Cells["SupplierID"].Value);

                string query = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SupplierID", selectedSupplierID);
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

                LoadSuppliers();
            }
        }
    }
}