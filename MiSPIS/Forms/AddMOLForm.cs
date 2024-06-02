using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiSPIS.Forms
{
    public partial class AddMOLForm : Form
    {
        public AddMOLForm()
        {
            InitializeComponent();
        }

        private void addMOLForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            db.OpenConnection();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `job_title`", db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxJobTitle.Items.Add(reader["job_title_name"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            try
            {
               
                MySqlCommand command = new MySqlCommand("SELECT * FROM `subdivision`", db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxSubdivision.Items.Add(reader["subdivision_name"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            db.closeConnection();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (comboBoxJobTitle.Text == "" || comboBoxJobTitle.Text == " ")
            {
                MessageBox.Show("Выберите должность");
                return;
            }

            if (comboBoxSubdivision.Text == "" || comboBoxSubdivision.Text == " ")
            {
                MessageBox.Show("Введите подразделение");
                return;
            }

            if (lastName.Text == "" || lastName.Text == " ")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (firstName.Text == "" || firstName.Text == " ")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (isMOLExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `mol` (`mol_first_name`, `mol_last_name`, `mol_father_name`, `mol_subdivision`, `mol_job_title`) " +
                "VALUES (@molFirstName, @molLastName, @molFatherName, @molSubdivision, @molJobTitle)", db.getConnection());
            command.Parameters.Add("@molFirstName", MySqlDbType.VarChar).Value = firstName.Text;
            command.Parameters.Add("@molLastName", MySqlDbType.VarChar).Value = lastName.Text;
            command.Parameters.Add("@molFatherName", MySqlDbType.VarChar).Value = fatherName.Text;
            command.Parameters.Add("@molSubdivision", MySqlDbType.VarChar).Value = comboBoxSubdivision.Text;
            command.Parameters.Add("@molJobTitle", MySqlDbType.VarChar).Value = comboBoxJobTitle.Text;
            ;
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("МОЛ добавлено");
            else
                MessageBox.Show("Ошибка добавления");
            db.closeConnection();
            this.Hide();
            MOLForm mOLForm= new MOLForm();
            mOLForm.Show();
        }

        public Boolean isMOLExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `mol` WHERE `mol_first_name` = @molFirstName AND `mol_last_name` = @molLastName AND `mol_father_name` = @molFatherName", db.getConnection());
            command.Parameters.Add("@molFirstName", MySqlDbType.VarChar).Value = firstName.Text;
            command.Parameters.Add("@molLastName", MySqlDbType.VarChar).Value = lastName.Text;
            command.Parameters.Add("@molFatherName", MySqlDbType.VarChar).Value = fatherName.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такое материально-ответственное лицо уже существует");
                return true;
            }
            else
                return false;
        }


    }
}
