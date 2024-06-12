using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Linq;

namespace MiSPIS
{
    public partial class FormReportsSales : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";
        MySqlDataAdapter adapter;
        DataTable reportTable;

        public FormReportsSales()
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
            Controls.Add(buttonGenerateSalesReport);
            Controls.Add(dataGridViewReports);
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

            // Вычисление общей суммы всех продаж
            decimal totalSalesAmount = reportTable.AsEnumerable().Sum(row => row.Field<decimal>("Сумма"));

            // Вывод общей суммы всех продаж в Label
            labelTotalSalesAmount.Text = $"Общая сумма всех продаж: {totalSalesAmount:C}"; // :C для форматирования как валюты
        }
    }
}