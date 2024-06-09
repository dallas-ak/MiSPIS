using System.Data;

namespace MiSPIS
// MyApp/IDataAccess.cs
public interface IDataAccess
{
    DataTable GetProducts();
    DataTable GetWarehouses();
    DataTable GetResponsiblePersons();
    DataTable GetClients(); // Добавлено для получения клиентов
    void AddSale(Sale sale); // Добавлено для добавления продажи
    void AddSaleItem(SaleItem item); // Добавлено для добавления позиции продажи
} //  void AddInvoiceItem(InvoiceItem item);
}
}