using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiSPIS
{
    public partial class MainForm : Form
    {
        private IDataAccess dataAccess;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitStripMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StripMenuWarehouses_Click(object sender, EventArgs e)
        {
            FormWarehouses formWarehouses = new FormWarehouses();
            formWarehouses.Show();
        }

        private void StripMenuProducts_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.Show();
        }


        private void StripMenuSuppliers_Click(object sender, EventArgs e)
        {
            FormSuppliers formSuppliers = new FormSuppliers();
            formSuppliers.Show();
        }

        private void StripMenuResponsiblePersons_Click(object sender, EventArgs e)
        {
            FormResponsiblePersons formResponsiblePersons = new FormResponsiblePersons();
            formResponsiblePersons.Show();
        }

        private void StripMenuReports_Click(object sender, EventArgs e)
        {
            FormReports formReports = new FormReports();
            formReports.Show();
        }

        private void buttonPrihod_Click(object sender, EventArgs e)
        {
            FormInvoices formInvoices = new FormInvoices(dataAccess);
            formInvoices.Show();
        }

        private void buttonRashod_Click(object sender, EventArgs e)
        {
            FormSales formSales = new FormSales(dataAccess);
            formSales.Show();
        }

        private void buttonOstatki_Click(object sender, EventArgs e)
        {
            FormStock formStock = new FormStock();
            formStock.Show();
        }

        private void StripMenuClients_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients();
            formClients.Show();
        }
    }
}




