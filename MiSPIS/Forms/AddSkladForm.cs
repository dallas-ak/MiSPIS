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
    }
}
