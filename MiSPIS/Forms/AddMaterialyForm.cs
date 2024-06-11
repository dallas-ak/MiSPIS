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
    public partial class AddMaterialyForm : Form
    {
        public AddMaterialyForm()
        {
            InitializeComponent();
        }
        private void AddMaterialyForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            try
            {
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT storehouse_type_id, storehouse.storehouse_name, type.type_name FROM storehouse_type LEFT JOIN storehouse ON  (storehouse.storehouse_id = storehouse_type.storehouse_id) LEFT JOIN type ON (type.type_id = storehouse_type.type_id)", db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxNameSklad.Items.Add(reader[0].ToString() + " - " + reader[1].ToString() + " (" + reader[2].ToString() + ")");              
                }
                reader.Close();
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void articleMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = vendorCode.Text;
            if (s.Count() == 6)
            {
              vendorCode.Clear();
            }
            if (Char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                e.Handled = true;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (vendorCode.Text == "" || vendorCode.Text == " ")
            {
                MessageBox.Show("Введите акртикул ");
                return;
            }

            if (nameMaterial.Text == "" || nameMaterial.Text == " ")
            {
                MessageBox.Show("Введите наименование товара");
                return;
            }

            if (isSkladExists())
                return;

            DB db = new DB();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `materials` (material_vendor_code, material_name) VALUES (@vendorCode, @materialName)", db.getConnection());
            command.Parameters.Add("@vendorCode", MySqlDbType.VarChar).Value = vendorCode.Text;
            command.Parameters.Add("@materialName", MySqlDbType.VarChar).Value = nameMaterial.Text;
            if (command.ExecuteNonQuery() == 1)
            {

            }
            else
                MessageBox.Show("Ошибка добавления артикула или наименования");
            db.closeConnection();
            //заберем всю строку из combobox
            string selectedItemPut = comboBoxNameSklad.SelectedItem.ToString();
            int index = comboBoxNameSklad.FindString(selectedItemPut);
            //разобьем элементы обратно на массив, как они и были до записи в combobox
            string[] breakSelectedItem = selectedItemPut.Split('-');
            //считаем первый элемент с массива
            int put = Convert.ToInt32(breakSelectedItem[0].Trim());
            db.OpenConnection();
            MySqlCommand command2 = new MySqlCommand("INSERT INTO materials_storehouse_type (material_id, storehouse_type_id) VALUE (LAST_INSERT_ID(), " + put + ")", db.getConnection());
            if (command2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Товар добавлен");
            }
            else
                MessageBox.Show("Ошибка добавления");
            db.closeConnection();
            this.Hide();
            FormProducts materialyForm = new FormProducts();
            materialyForm.Show();
        }
        public Boolean isSkladExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `materials` WHERE `material_vendor_code` = @materialVendorCode", db.getConnection());
            command.Parameters.Add("@materialVendorCode", MySqlDbType.VarChar).Value = vendorCode.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой товар уже существует");
                return true;
            }
            else
                return false;
        }




    }
}
