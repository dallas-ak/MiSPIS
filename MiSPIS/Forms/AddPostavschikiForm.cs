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

namespace MiSPIS.Forms
{
    public partial class AddPostavschikiForm : Form
    {
        public AddPostavschikiForm()
        {
            InitializeComponent();
        }

        private void AddPostavschikiForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            try
            {
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `counterparty_type`", db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxTypePostavschiki.Items.Add(reader["counterparty_type_name"].ToString());
                }
                reader.Close();
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void INN_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = INN.Text;
            if (s.Count() == 12)
            {
                INN.Clear();
            }
            if (Char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void KPP_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = KPP.Text;
            if (s.Count() == 9)
            {
                KPP.Clear();
            }
            if (Char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (comboBoxTypePostavschiki.Text == "" || comboBoxTypePostavschiki.Text == " ")
            {
                MessageBox.Show("Выберите вид контрагента");
                return;
            }

            if (ShortName.Text == "" || ShortName.Text == " ")
            {
                MessageBox.Show("Введите Краткое наименование");
                return;
            }

            if (FullName.Text == "" || FullName.Text == " ")
            {
                MessageBox.Show("Введите Полное наименование");
                return;
            }

            if (isSkladExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `counterparty` (`seller_type`, `seller_INN`, `seller_KPP`, `seller_full_name`, `seller_short_name`) VALUES (@sellerType, @sellerINN, @sellerKPP, @sellerFullName, @sellerShortName)", db.getConnection());
            command.Parameters.Add("@sellerType", MySqlDbType.VarChar).Value = comboBoxTypePostavschiki.Text;
            command.Parameters.Add("@sellerINN", MySqlDbType.VarChar).Value = INN.Text;
            command.Parameters.Add("@sellerKPP", MySqlDbType.VarChar).Value = KPP.Text;
            command.Parameters.Add("@sellerFullName", MySqlDbType.VarChar).Value = FullName.Text;
            command.Parameters.Add("@sellerShortName", MySqlDbType.VarChar).Value = ShortName.Text;
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Контрагент добавлен");
            else
                MessageBox.Show("Ошибка добавления");
            db.closeConnection();
            this.Hide();
            PostavschikiForm postavschikiForm = new PostavschikiForm();
            postavschikiForm.Show();
        }

        public Boolean isSkladExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `counterparty` WHERE `seller_INN`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой контрагент уже существует");
                return true;
            }
            else
                return false;
        }




    }
}
