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
    public partial class AddTypeSkladForm : Form
    {
        public AddTypeSkladForm()
        {
            InitializeComponent();
        }

        private void buttonAddType_Click(object sender, EventArgs e)
        {
            if (typeField.Text ==  "" || typeField.Text == " ")
            {
                MessageBox.Show("Введите наименование");
                return;
            }

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `storehouse_type` (`type_name`) VALUES (@type)", db.getConnection());

            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = typeField.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Тип склада успешно создан");
            else
                MessageBox.Show("Ошибка создания");

            db.closeConnection();
            this.Close();
            AddSkladForm addSkladForm = new AddSkladForm();
            addSkladForm.Show();
        }

    }
}
