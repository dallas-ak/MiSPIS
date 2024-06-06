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
    enum RowState_MOL
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MOLForm : Form
    {
        DB db = new DB();

        public MOLForm()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("mol_id", "Код");
            dataGridView1.Columns.Add("mol_last_name", "Фамилия");
            dataGridView1.Columns.Add("mol_first_name", "Имя");
            dataGridView1.Columns.Add("mol_father_name", "Отчество");
            dataGridView1.Columns.Add("mol_job_title", "Должность");         
            dataGridView1.Columns.Add("mol_subdivision", "Подразделение");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState_MOL.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from mol";
            MySqlCommand command = new MySqlCommand(queryString, db.getConnection());
            db.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void MOLForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMOLForm addMOLForm = new AddMOLForm();
            addMOLForm.Show();
        }
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void toolStripRefresh_Click(object sender, EventArgs e)
        {

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
                dataGridView1.Rows[index].Cells[6].Value = RowState_MOL.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState_MOL.Deleted;
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
                var RowState = (RowState_MOL)dataGridView1.Rows[index].Cells[6].Value;
                if (RowState == RowState_MOL.Existed)
                    continue;
                if (RowState == RowState_MOL.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from mol where mol_id = {id}";
                    var command = new MySqlCommand(deleteQuery, db.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            db.closeConnection();
        }
    }
}
