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
    enum RowState_Postavschiki
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted,
    }

    public partial class PostavschikiForm : Form
    {
        DB db = new DB();
        int selectedRow;

        public PostavschikiForm()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("seller_id", "Код");
            dataGridView1.Columns.Add("seller_type", "Вид поставщика");
            dataGridView1.Columns.Add("seller_INN", "ИНН");
            dataGridView1.Columns.Add("seller_KPP", "КПП");
            dataGridView1.Columns.Add("seller_full_name", "Полное наименование");
            dataGridView1.Columns.Add("seller_short_name", "Краткое наименование");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetString(4), record.GetString(5),  RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from sellers";
            MySqlCommand command = new MySqlCommand(queryString, db.getConnection());
            db.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void PostavschikiForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPostavschikiForm addPostavschikiForm = new AddPostavschikiForm();
            addPostavschikiForm.Show();
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
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
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
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from sellers where seller_id = {id}";
                    var command = new MySqlCommand(deleteQuery, db.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            db.closeConnection();
        }
    }
}
