﻿using System;
using System.Windows.Forms;

namespace MiSPIS
{
    public partial class MainForm : Form
    {
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
        private void buttonInvoices_Click(object sender, EventArgs e)
        {
            FormInvoices formInvoices = new FormInvoices();
            formInvoices.Show();
        }
        private void buttonSales_Click(object sender, EventArgs e)
        {
            FormSales formSales = new FormSales();
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
        private void StripMenuReportsSales_Click(object sender, EventArgs e)
        {
            FormReportsSales formReportsSales = new FormReportsSales();
            formReportsSales.Show();
        }
        private void StripMenuReportsManagers_Click(object sender, EventArgs e)
        {
            FormReportsManagers formReportsManagers = new FormReportsManagers();        
            formReportsManagers.Show();
        }
    }
}




