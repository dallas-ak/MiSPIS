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
                MySqlCommand command = new MySqlCommand("SELECT * FROM storehouse", db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxNameSklad.Items.Add(reader[1].ToString() + " (" + reader[2].ToString() + ")");              
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
            string s = articleMaterial.Text;
            if (s.Count() == 6)
            {
              articleMaterial.Clear();
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
            if (articleMaterial.Text == "" || articleMaterial.Text == " ")
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
            MySqlCommand command = new MySqlCommand("INSERT INTO `materials` (material_vendor_code, material_name, storehouse_name, storehouse_type_name) VALUES (@materialVendorCode, @materialName, `storehouse_name`, `storehouse_type_name`)", db.getConnection());
            command.Parameters.Add("@materialVendorCode", MySqlDbType.VarChar).Value = articleMaterial.Text;
            command.Parameters.Add("@materialName", MySqlDbType.VarChar).Value = nameMaterial.Text;

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Товар добавлен");
            else
                MessageBox.Show("Ошибка добавления");
            db.closeConnection();
            this.Hide();
            MaterialyForm materialyForm = new MaterialyForm();
            materialyForm.Show();
        }

        public Boolean isSkladExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `materials` WHERE `material_vendor_code` = @materialVendorCode", db.getConnection());
            command.Parameters.Add("@materialVendorCode", MySqlDbType.VarChar).Value = articleMaterial.Text;
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
