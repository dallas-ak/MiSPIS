using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace MiSPIS.Forms
{
    public partial class AddSkladForm : Form
    {
        public AddSkladForm()
        {
            InitializeComponent();
        }
        private void toolStripAddType_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTypeSkladForm addTypeSkladForm = new AddTypeSkladForm();
            addTypeSkladForm.Show();
        }
    private void AddSkladForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            try
            {
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM type", db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxTypeSklad.Items.Add(reader[0].ToString() + " - " + reader[1].ToString());
                }
                reader.Close();
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }                      
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (nameSklad.Text == "" || nameSklad.Text == " ")
            {
                MessageBox.Show("Введите название склада");
                return;
            }
            if (isSkladExists())
                return;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO storehouse (storehouse_name) VALUES (@storehouse_name)", db.getConnection());
            command.Parameters.Add("@storehouse_name", MySqlDbType.VarChar).Value = nameSklad.Text;
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {

            }
            else
                MessageBox.Show("Ошибка добавления склада");
            db.closeConnection();
            //заберем всю строку из combobox
            string selectedItemPut = comboBoxTypeSklad.SelectedItem.ToString();
            int index = comboBoxTypeSklad.FindString(selectedItemPut);
            //разобьем элементы обратно на массив, как они и были до записи в combobox
            string[] breakSelectedItem = selectedItemPut.Split('-');
            //считаем первый элемент с массива
            int put = Convert.ToInt32(breakSelectedItem[0].Trim());
            MySqlCommand command2 = new MySqlCommand("INSERT INTO storehouse_type (storehouse_id, type_id) VALUE (LAST_INSERT_ID(), " + put + ")", db.getConnection());
            db.OpenConnection();
            if (command2.ExecuteNonQuery() == 1)
                MessageBox.Show("Склад добавлен");
            else
                MessageBox.Show("Ошибка добавления типа склада");
            db.closeConnection();
            this.Hide();
            SkladyForm skladyForm = new SkladyForm();
            skladyForm.Show();
        }
        public Boolean isSkladExists()
        {
            DB db = new DB();
            DataTable tb = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT storehouse_name, type_name FROM storehouse, type WHERE storehouse_name = @storehouseName AND type_id = @type_id", db.getConnection());
            command.Parameters.Add("@storehouseName", MySqlDbType.VarChar).Value = nameSklad.Text;
            command.Parameters.Add("@type_id", MySqlDbType.VarChar).Value = comboBoxTypeSklad.Text;
            adapter.SelectCommand = command;
            adapter.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                MessageBox.Show("Такой склад уже существует");
                return true;
            }
            else
                return false;
        }
        private void toolStripDeleteType_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeSklad.SelectedItem == null)
            {
                MessageBox.Show("Для удаления выберите тип склада");
                return;
            }
            string selectedItemPut = comboBoxTypeSklad.SelectedItem.ToString();
            int index = comboBoxTypeSklad.FindString(selectedItemPut);
            //разобьем элементы обратно на массив, как они и были до записи в combobox
            string[] breakSelectedItem = selectedItemPut.Split('-');
            //считаем первый элемент с массива
            int put2 = Convert.ToInt32(breakSelectedItem[0].Trim());
            comboBoxTypeSklad.Items.Remove(comboBoxTypeSklad.SelectedItem);
            comboBoxTypeSklad.Text = string.Empty;
            DialogResult result = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DB db = new DB();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("DELETE FROM `type` WHERE `type`.`type_id` = @typeId ", db.getConnection());
                command.Parameters.Add("@typeId", MySqlDbType.VarChar).Value = put2;
                adapter.SelectCommand = command;
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Успешно удалено");
                else
                    MessageBox.Show("Ошибка удаления");
                db.closeConnection();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Ну ладно!", "Попробуем позже");
                AddSkladForm_Load(null, null);
                return;
            }

        }


    }  

}
