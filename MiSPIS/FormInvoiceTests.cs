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
            // ������� ������� ���� ������ ����� �����
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

            // ������������� �������� ��� ������������
            form.comboBoxSuppliers.SelectedValue = 1; // �������� ���������
            form.comboBoxWarehouses.SelectedValue = 1; // �������� �����
            form.comboBoxResponsiblePersons.SelectedValue = 1; // �������� �������������

            // ��������� ������ �����
            form.comboBoxProducts.SelectedValue = 1; // �������� ����� 1
            form.textBoxQuantity.Text = "10";
            form.textBoxPrice.Text = "2000";
            form.buttonAddToInvoice_Click(null, null);

            // ��������� ������ �����
            form.comboBoxProducts.SelectedValue = 2; // �������� ����� 2
            form.textBoxQuantity.Text = "5";
            form.textBoxPrice.Text = "3000";
            form.buttonAddToInvoice_Click(null, null);

            // ������� ���������
            form.buttonCreateInvoice_Click(null, null);

            // ��������� ��� ��������� ������
            form.LoadInvoices();

            // ���������, ��� ����������� ��������� ������������ � dataGridViewInvoices
            bool invoiceAdded = false;
            foreach (DataGridViewRow row in form.dataGridViewInvoices.Rows)
            {
                if (row.Cells["Supplier"].Value.ToString() == "��� ���� � ������" /* �������� �� ��������� �������� */ &&
                    row.Cells["Warehouse"].Value.ToString() == "�������� �����" /* �������� �� ��������� �������� */ &&
                    row.Cells["ResponsiblePerson"].Value.ToString() == "������ ���� ��������" /* �������� �� ��������� �������� */)
                {
                    invoiceAdded = true;
                    break;
                }
            }
            // ��������� ���������
            Assert.True(invoiceAdded, "������ ����������");
        }
    }
}