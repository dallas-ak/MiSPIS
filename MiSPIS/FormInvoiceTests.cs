using System;
using System.Data;
using System.Windows.Forms;
using MiSPIS;
using MySql.Data.MySqlClient;
using Xunit;
using MiSPIS;

namespace MiSPIS.Tests
{
    public class FormInvoiceTests : IDisposable
    {
        private readonly string connectionString = "server=localhost;port=3306;username=root;password=root;database=MiSPIS;";
        private MySqlConnection connection;

        public FormInvoiceTests()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void Dispose()
        {
            // Никакой очистки базы данных после теста
        }

        [Fact]
        public void AddInvoiceTest()
        {
            var form = new FormInvoices();
            form.InitializeDatabaseConnection();
            form.LoadSuppliers();
            form.LoadWarehouses();
            form.LoadResponsiblePersons();
            form.LoadProducts();

            // Устанавливаем значения для тестирования
            form.comboBoxSuppliers.SelectedValue = 1; // Тестовый поставщик
            form.comboBoxWarehouses.SelectedValue = 1; // Тестовый склад
            form.comboBoxResponsiblePersons.SelectedValue = 1; // Тестовый ответственный

            // Добавляем первый товар
            form.comboBoxProducts.SelectedValue = 1; // Тестовый товар 1
            form.textBoxQuantity.Text = "10";
            form.textBoxPrice.Text = "2000";
            form.buttonAddToInvoice_Click(null, null);

            // Добавляем второй товар
            form.comboBoxProducts.SelectedValue = 2; // Тестовый товар 2
            form.textBoxQuantity.Text = "5";
            form.textBoxPrice.Text = "3000";
            form.buttonAddToInvoice_Click(null, null);

            // Создаем накладную
            form.buttonCreateInvoice_Click(null, null);

            // Загружаем все накладные заново
            form.LoadInvoices();

            // Проверяем, что добавленная накладная присутствует в dataGridViewInvoices
            bool invoiceAdded = false;
            foreach (DataGridViewRow row in form.dataGridViewInvoices.Rows)
            {
                if (row.Cells["Supplier"].Value.ToString() == "ООО Рога и Копыта" /* заменить на ожидаемое значение */ &&
                    row.Cells["Warehouse"].Value.ToString() == "Основной склад" /* заменить на ожидаемое значение */ &&
                    row.Cells["ResponsiblePerson"].Value.ToString() == "Иванов Иван Иванович" /* заменить на ожидаемое значение */)
                {
                    invoiceAdded = true;
                    break;
                }
            }
            // Проверяем результат
            Assert.True(invoiceAdded, "Ошибка добавления");
        }
    }
}