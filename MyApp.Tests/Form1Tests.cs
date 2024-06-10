using System;
using System.Data;
using System.Windows.Forms;
using MiSPIS;
using Moq;
using Xunit;



namespace MyApp.Tests
{
    public class Form1
    {
        private Form1 form;
        private Mock<IDataAccess> dataAccessMock;

        public Form1Tests()
        {
            // Создаем Mock для IDataAccess (это ваш интерфейс для доступа к базе данных)
            dataAccessMock = new Mock<IDataAccess>();

            // Создаем экземпляр Form1 с Mock IDataAccess
            form = new Form1(dataAccessMock.Object);

            // Инициализируем компоненты формы
            form.InitializeComponent();
        }

        [Fact]
        public void ButtonAddToInvoice_Click_ShouldAddItemToInvoice()
        {
            // Установка начальных условий
            form.comboBoxProducts.SelectedValue = 1;
            form.comboBoxProducts.Text = "Product1";
            form.textBoxQuantity.Text = "5";
            form.textBoxPrice.Text = "10.00";

            // Вызов метода
            form.buttonAddToInvoice_Click(null, EventArgs.Empty);

            // Проверка результата
            Assert.Equal(1, form.dataGridViewInvoiceItems.Rows.Count);
            Assert.Equal(1, form.dataGridViewInvoiceItems.Rows[0].Cells["ProductID"].Value);
            Assert.Equal("Product1", form.dataGridViewInvoiceItems.Rows[0].Cells["ProductName"].Value);
            Assert.Equal(5, form.dataGridViewInvoiceItems.Rows[0].Cells["Quantity"].Value);
            Assert.Equal(10.00m, form.dataGridViewInvoiceItems.Rows[0].Cells["Price"].Value);
            Assert.Equal(50.00m, form.dataGridViewInvoiceItems.Rows[0].Cells["Total"].Value);
        }

        [Fact]
        public void ButtonCreateInvoice_Click_ShouldNotCreateInvoiceIfNoItems()
        {
            // Вызов метода
            form.buttonCreateInvoice_Click(null, EventArgs.Empty);

            // Проверка результата (сообщение об ошибке)
            Assert.Equal("Please add at least one item to the invoice before creating it.",
                form.LastErrorMessage);
        }

        // Вы можете добавить больше тестов здесь
    }

    internal interface IDataAccess
    {
    }
}