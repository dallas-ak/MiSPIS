using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiSPIS
{
    public partial class FormResponsiblePersons : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";

        public FormResponsiblePersons()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadResponsiblePersons();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void LoadResponsiblePersons()
        {
            string query = "SELECT PersonID, PersonName FROM ResponsiblePersons";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                DataTable ResponsiblePersonsTable = new DataTable();
                adapter.Fill(ResponsiblePersonsTable);
                dataGridViewResponsiblePersons.DataSource = ResponsiblePersonsTable;

                // Set column headers in Russian
                dataGridViewResponsiblePersons.Columns.Clear();

                dataGridViewResponsiblePersons.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "PersonID",
                    HeaderText = "ID МОЛ",
                    Name = "PersonID",
                    ReadOnly = true
                });
                dataGridViewResponsiblePersons.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "PersonName",
                    HeaderText = "ФИО",
                    Name = "PersonName",
                    ReadOnly = true
                });
            }
        }
        private void buttonAddResponsiblePerson_Click(object sender, EventArgs e)
        {
            string ResponsiblePersonName = textBoxResponsiblePersonName.Text;
            if (string.IsNullOrWhiteSpace(ResponsiblePersonName))
            {
                MessageBox.Show("Пожалуйста, введите ФИО");
                return;
            }

            string query = "INSERT INTO ResponsiblePersons (PersonName) VALUES (@PersonName)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonName", ResponsiblePersonName);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("МОЛ успешно добавлено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении МОЛ: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            LoadResponsiblePersons();
            textBoxResponsiblePersonName.Clear();
        }

        private void buttonDeleteResponsiblePerson_Click(object sender, EventArgs e)
        {
            if (dataGridViewResponsiblePersons.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите МОЛ");
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить МОЛ?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectedResponsiblePersonID = Convert.ToInt32(dataGridViewResponsiblePersons.SelectedRows[0].Cells["PersonID"].Value);

                string query = "DELETE FROM ResponsiblePersons WHERE PersonID = @PersonID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", selectedResponsiblePersonID);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("МОЛ успешно удалено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении МОЛ: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

                LoadResponsiblePersons();
            }
        }
    }
}