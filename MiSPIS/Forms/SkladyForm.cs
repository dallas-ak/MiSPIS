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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiSPIS.Forms
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted,
    }

    public partial class SkladyForm : Form
    {

        DB db = new DB();

        int selectedRow;

        public SkladyForm()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("storehouse_id", "Код");
            dataGridView1.Columns.Add("storehouse_name", "Наименование");
            dataGridView1.Columns.Add("storehouse_type", "Тип склада");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from storehouse";
            MySqlCommand command = new MySqlCommand(queryString, db.getConnection());
            db.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();           
        }

        private void SkladyForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSkladForm addSkladForm = new AddSkladForm();
            addSkladForm.Show();
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void toolStripRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
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
                     dataGridView1.Rows[index].Cells[3].Value = RowState.Deleted;
                     return;
                  }
                dataGridView1.Rows[index].Cells[3].Value = RowState.Deleted;
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
                var rowState = (RowState)dataGridView1.Rows[index].Cells[3].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from storehouse where storehouse_id = {id}";
                    var command = new MySqlCommand(deleteQuery, db.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            db.closeConnection();
        }

    }
}
