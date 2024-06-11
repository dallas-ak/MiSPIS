using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiSPIS
{
    public partial class FormClients : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";

        public FormClients()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadClients();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void LoadClients()
        {
            string query = "SELECT ClientID, ClientName FROM Clients";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                DataTable ClientsTable = new DataTable();
                adapter.Fill(ClientsTable);
                dataGridViewClients.DataSource = ClientsTable;

                // Set column headers in Russian
                dataGridViewClients.Columns.Clear();

                dataGridViewClients.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ClientID",
                    HeaderText = "ID клиента",
                    Name = "ClientID",
                    ReadOnly = true
                });
                dataGridViewClients.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ClientName",
                    HeaderText = "Название клиента",
                    Name = "ClientName",
                    ReadOnly = true
                });
            }
        }
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            string ClientName = textBoxClientName.Text;
            if (string.IsNullOrWhiteSpace(ClientName))
            {
                MessageBox.Show("Пожалуйста, введите имя клиента");
                return;
            }

            string query = "INSERT INTO Clients (ClientName) VALUES (@ClientName)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ClientName", ClientName);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("клиент успешно добавлен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении клиента: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            LoadClients();
            textBoxClientName.Clear();
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите клиент для удаления");
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить этот клиент?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectedClientID = Convert.ToInt32(dataGridViewClients.SelectedRows[0].Cells["ClientID"].Value);

                string query = "DELETE FROM Clients WHERE ClientID = @ClientID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientID", selectedClientID);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("клиент успешно удален");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении клиента: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                LoadClients();
            }
        }
    }
}