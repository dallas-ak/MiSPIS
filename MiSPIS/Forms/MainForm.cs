using MiSPIS.Forms;
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
            FormProducts materialyForm = new FormProducts();
            materialyForm.Show();
        }

        private void PostavschikiStripMenu_Click(object sender, EventArgs e)
        {
            PostavschikiForm postavschikiForm = new PostavschikiForm();
            postavschikiForm.Show();
        }

        private void MOLStripMenu_Click(object sender, EventArgs e)
        {
            MOLForm molForm = new MOLForm();
            molForm.Show();
        }

        private void OtchetyStripMenu_Click(object sender, EventArgs e)
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
    }
}




