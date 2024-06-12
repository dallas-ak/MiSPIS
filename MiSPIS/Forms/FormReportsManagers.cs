using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MiSPIS
{
    public partial class FormReportsManagers : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";
        private MySqlDataAdapter adapter;
        private DataTable responsibleTable;

        public FormReportsManagers()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadResponsibles();
            InitializeComboBoxPeriod();
            InitializeEventHandlers();
            HideEndDatePicker();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void LoadResponsibles()
        {
            string query = "SELECT PersonID, PersonName FROM responsiblepersons"; // Предположим, что у вас есть таблица ответственных
            MySqlCommand cmd = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(cmd);
            responsibleTable = new DataTable();
            adapter.Fill(responsibleTable);

            DataRow allRow = responsibleTable.NewRow();
            allRow["PersonID"] = -1;
            allRow["PersonName"] = "Все";
            responsibleTable.Rows.InsertAt(allRow, 0);

            comboBoxResponsible.DataSource = responsibleTable;
            comboBoxResponsible.DisplayMember = "PersonName";
            comboBoxResponsible.ValueMember = "PersonID";
        }

        private void InitializeComboBoxPeriod()
        {
            comboBoxPeriod.Items.AddRange(new string[] { "День", "Месяц", "Квартал", "Год", "Произвольный период" });
            comboBoxPeriod.SelectedIndex = 0; // Устанавливаем начальное значение
        }

        private void InitializeEventHandlers()
        {
            comboBoxResponsible.SelectedIndexChanged += ComboBoxResponsible_SelectedIndexChanged;
            comboBoxPeriod.SelectedIndexChanged += ComboBoxPeriod_SelectedIndexChanged;
            ButtonGenerateManagersReport.Click += ButtonGenerateManagersReport_Click;
        }

        private void ComboBoxResponsible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxResponsible.SelectedItem != null)
            {
                comboBoxPeriod.Enabled = true;
            }
            else
            {
                comboBoxPeriod.Enabled = false;
            }
        }

        private void ComboBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPeriod.SelectedItem.ToString() == "Произвольный период")
            {
                dateTimePickerStartDate.Visible = true;
                dateTimePickerEndDate.Visible = true;
            }
            else
            {
                dateTimePickerStartDate.Visible = true;
                dateTimePickerEndDate.Visible = false;
                DateTime startDate = GetStartDate(comboBoxPeriod.SelectedItem.ToString());
                dateTimePickerStartDate.Value = startDate;
            }
        }

        private void ButtonGenerateManagersReport_Click(object sender, EventArgs e)
        {
            if (comboBoxResponsible.SelectedItem == null)
            {
                MessageBox.Show("Выберите ответственное лицо.");
                return;
            }

            int personID = (int)comboBoxResponsible.SelectedValue;
            string period = comboBoxPeriod.SelectedItem.ToString();

            if (period == "Произвольный период")
            {
                DateTime startDate = dateTimePickerStartDate.Value;
                DateTime endDate = dateTimePickerEndDate.Value;
                GenerateSalesReport(personID, startDate, endDate);
            }
            else
            {
                DateTime startDate = GetStartDate(period);
                DateTime endDate = GetEndDate(startDate, period);
                GenerateSalesReport(personID, startDate, endDate);
            }
        }

        private void GenerateSalesReport(int personID, DateTime startDate, DateTime endDate)
        {
            string query = "SELECT Sales.SaleID AS 'ID Продажи', Sales.SaleDate AS 'Дата продажи', Clients.ClientName AS Клиент, Products.ProductName AS Товар, SalesItems.Quantity AS Количество, SalesItems.Total AS Сумма " +
                           "FROM Sales " +
                           "JOIN SalesItems ON Sales.SaleID = SalesItems.SaleID " +
                           "JOIN Clients ON Sales.ClientID = Clients.ClientID " +
                           "JOIN Products ON SalesItems.ProductID = Products.ProductID " +
                           "WHERE Sales.SaleDate BETWEEN @startDate AND @endDate";

            if (personID != -1)
            {
                query += " AND Sales.PersonID = @personID";
            }

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@startDate", startDate.Date);
            cmd.Parameters.AddWithValue("@endDate", endDate.Date);
            if (personID != -1)
            {
                cmd.Parameters.AddWithValue("@personID", personID);
            }

            adapter = new MySqlDataAdapter(cmd);
            DataTable reportTable = new DataTable();
            adapter.Fill(reportTable);
            dataGridViewReportsManagers.DataSource = reportTable;

            // Вычисление общей суммы всех продаж
            decimal totalSalesAmount = reportTable.AsEnumerable().Sum(row => row.Field<decimal>("Сумма"));

            // Вывод общей суммы всех продаж в Label
            labelTotalSalesAmount.Text = $"Общая сумма всех продаж: {totalSalesAmount:C}"; // :C для форматирования как валюты
        }

        private void HideEndDatePicker()
        {
            dateTimePickerEndDate.Visible = false;  
        }

        private DateTime GetStartDate(string period)
        {
            DateTime startDate = DateTime.Today;
            switch (period)
            {
                case "Месяц":
                    startDate = new DateTime(startDate.Year, startDate.Month, 1);
                    break;
                case "Квартал":
                    int quarter = (startDate.Month - 1) / 3 + 1;
                    startDate = new DateTime(startDate.Year, 3 * quarter - 2, 1);
                    break;
                case "Год":
                    startDate = new DateTime(startDate.Year, 1, 1);
                    break;
            }
            return startDate;
        }

        private DateTime GetEndDate(DateTime startDate, string period)
        {
            switch (period)
            {
                case "Месяц":
                    return startDate.AddMonths(1).AddDays(-1);
                case "Квартал":
                    return startDate.AddMonths(3).AddDays(-1);
                case "Год":
                    return startDate.AddYears(1).AddDays(-1);
                default:
                    return startDate;
            }
        }
    }
}