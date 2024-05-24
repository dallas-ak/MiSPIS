using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `storehouse_type`", db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxTypeSklad.Items.Add(reader["type_name"].ToString());
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
                MessageBox.Show("Введите название склада ");
                return;
            }

            if (isSkladExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `storehouse` (`storehouse_name`, `storehouse_type`) VALUES (@nameSklad, @typeSklad)", db.getConnection());
            command.Parameters.Add("@nameSklad", MySqlDbType.VarChar).Value = nameSklad.Text;                
            command.Parameters.Add("@typeSklad", MySqlDbType.VarChar).Value = comboBoxTypeSklad.Text;
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Склад добавлен");            
            else
                MessageBox.Show("Ошибка добавления");
            db.closeConnection();
            this.Hide();
            SkladyForm skladyForm = new SkladyForm();
            skladyForm.Show();
        }

        public Boolean isSkladExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `storehouse` WHERE `storehouse_name`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой склад уже существует");
                return true;
            }
            else
                return false;
        }

    }
}
