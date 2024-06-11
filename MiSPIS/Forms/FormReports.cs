using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace MiSPIS
{
    public partial class FormReports : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";
        MySqlDataAdapter adapter;
        DataTable reportTable;

        public FormReports()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeControls();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void InitializeControls()
        {

            // Добавляем элементы управления на форм
            Controls.Add(dateTimePickerReportDate);

            Controls.Add(comboBoxResponsiblePersons);
            Controls.Add(buttonGenerateSalesReport);
            Controls.Add(buttonGenerateResponsibleReport);
            Controls.Add(dataGridViewReports);

            LoadResponsiblePersons(comboBoxResponsiblePersons);
        }

        private void LoadResponsiblePersons(ComboBox comboBox)
        {
            string query = "SELECT PersonID, PersonName FROM ResponsiblePersons";
            adapter = new MySqlDataAdapter(query, connection);
            DataTable responsiblePersonsTable = new DataTable();
            adapter.Fill(responsiblePersonsTable);
            comboBox.DataSource = responsiblePersonsTable;
            comboBox.DisplayMember = "PersonName";
            comboBox.ValueMember = "PersonID";
            comboBox.SelectedIndex = -1;
        }

        private void ButtonGenerateSalesReport_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = ((DateTimePicker)Controls["dateTimePickerReportDate"]).Value;
            GenerateSalesReport(selectedDate);
        }

        private void GenerateSalesReport(DateTime date)
        {
            string query = "SELECT Sales.SaleID AS 'ID Продажи', Sales.SaleDate AS 'Дата продажи', Clients.ClientName AS Клиент, Products.ProductName AS Товар, SalesItems.Quantity AS Количество, SalesItems.Total AS Сумма " +
                           "FROM Sales " +
                           "JOIN SalesItems ON Sales.SaleID = SalesItems.SaleID " +
                           "JOIN Clients ON Sales.ClientID = Clients.ClientID " +
                           "JOIN Products ON SalesItems.ProductID = Products.ProductID " +
                           "WHERE Sales.SaleDate = @date";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@date", date.Date);
            adapter = new MySqlDataAdapter(cmd);
            reportTable = new DataTable();
            adapter.Fill(reportTable);
            ((DataGridView)Controls["dataGridViewReports"]).DataSource = reportTable;
        }

        private void ButtonGenerateResponsibleReport_Click(object sender, EventArgs e)
        {
            int responsiblePersonID = Convert.ToInt32(((ComboBox)Controls["comboBoxResponsiblePersons"]).SelectedValue);
            GenerateResponsibleReport(responsiblePersonID);
        }

        private void GenerateResponsibleReport(int personID)
        {
            string query = @"SELECT 'Продажа' AS Тип, Sales.SaleDate AS Дата, Products.ProductName AS Товар, SalesItems.Quantity AS Количество, SalesItems.Total AS Сумма
                            FROM Sales
                            JOIN SalesItems ON Sales.SaleID = SalesItems.SaleID
                            JOIN Products ON SalesItems.ProductID = Products.ProductID
                            WHERE Sales.PersonID = @personID
                            UNION ALL
                            SELECT 'Покупка' AS Тип, Invoices.InvoiceDate AS Дата, Products.ProductName AS Товар, InvoiceItems.Quantity AS Количество, InvoiceItems.Total AS Сумма
                            FROM Invoices
                            JOIN InvoiceItems ON Invoices.InvoiceID = InvoiceItems.InvoiceID
                            JOIN Products ON InvoiceItems.ProductID = Products.ProductID
                            WHERE Invoices.PersonID = @personID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@personID", personID);
            adapter = new MySqlDataAdapter(cmd);
            reportTable = new DataTable();
            adapter.Fill(reportTable);
            ((DataGridView)Controls["dataGridViewReports"]).DataSource = reportTable;
        }
    }
}