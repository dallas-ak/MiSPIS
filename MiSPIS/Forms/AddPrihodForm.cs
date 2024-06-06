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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiSPIS
{
    enum RowState_AddPrihod
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class AddPrihodForm : Form
    {
        DB db = new DB();

        public AddPrihodForm()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("receipt_id", "ID"); 
            dataGridView1.Columns.Add("receipt_date", "Дата");
            dataGridView1.Columns.Add("receipt_material", "Товар");
            dataGridView1.Columns.Add("receipt_count", "Количество");
            dataGridView1.Columns.Add("receipt_price", "Цена");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetDateTime(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4), RowState_AddPrihod.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from receipt, materials";
            MySqlCommand command = new MySqlCommand(queryString, db.getConnection());
            db.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void AddPrihodForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            try
            {
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `counterparty`", db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxPostavschik.Items.Add(reader["counterparty_short_name"].ToString());
                }
                reader.Close();
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            try
            {
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `materials`", db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxMaterial.Items.Add(reader["material_name"].ToString());
                }
                reader.Close();
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            try
            {
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `materials`", db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxStorehouse.Items.Add(reader["material_storehouse"].ToString());
                }
                reader.Close();
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            try
            {
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `mol`", db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxMOL.Items.Add(reader["mol_last_name"].ToString());
                }
                reader.Close();
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxPostavschik.Text == "" || comboBoxPostavschik.Text == " ")
            {
                MessageBox.Show("Выберите поставщика");
                return;
            }
            if (comboBoxMaterial.Text == "" || comboBoxMaterial.Text == " ")
            {
                MessageBox.Show("Выберите товар");
                return;
            }
            if (textBoxCount.Text == "" || textBoxCount.Text == " ")
            {
                MessageBox.Show("Введите количество");
                return;
            }
            if (textBoxPrice.Text == "" || textBoxPrice.Text == " ")
            {
                MessageBox.Show("Введите цену");
                return;
            }
            if (comboBoxStorehouse.Text == "" || comboBoxStorehouse.Text == " ")
            {
                MessageBox.Show("Выберите склад");
                return;
            }
            if (comboBoxMOL.Text == "" || comboBoxMOL.Text == " ")
            {
                MessageBox.Show("Выберите поставщика");
                return;
            }
            if (isPrihodExists())
                return;
            DateTime receiptDate = DateTime.Parse(dateTimePicker1.Text);
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `receipt` (`receipt_date`, `receipt_material`, `receipt_count`, `receipt_price`) " +
                "VALUES (@receiptDate, @receiptMaterial, @receiptCount, @receiptPrice)", db.getConnection());
            command.Parameters.Add("@receiptDate", MySqlDbType.Datetime).Value = receiptDate;
            command.Parameters.Add("@receiptMaterial", MySqlDbType.VarChar).Value = comboBoxMaterial.Text;
            command.Parameters.Add("@receiptCount", MySqlDbType.VarChar).Value = textBoxCount.Text;
            command.Parameters.Add("@receiptPrice", MySqlDbType.VarChar).Value = textBoxPrice.Text;
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Товар добавлен");
            else
                MessageBox.Show("Ошибка добавления");
            db.closeConnection();
        }

        public Boolean isPrihodExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `receipt` WHERE `receipt_material` = @receiptMaterial", db.getConnection());
            command.Parameters.Add("@receiptMaterial", MySqlDbType.VarChar).Value = comboBoxMaterial.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такоq товар уже существует");
                return true;
            }
            else
                return false;
        }
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void DeleteRow()
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState_AddPrihod.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState_AddPrihod.Deleted;
        }
        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
        private void Update()
        {
            db.OpenConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var RowState = (RowState_AddPrihod)dataGridView1.Rows[index].Cells[5].Value;
                if (RowState == RowState_AddPrihod.Existed)
                    continue;
                if (RowState == RowState_AddPrihod.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from receipt where receipt_id = {id}";
                    var command = new MySqlCommand(deleteQuery, db.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            db.closeConnection();
        }

    }
}
