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
    enum RowState_Prihod
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class PrihodForm : Form
    {
        DB db = new DB();
        DataTable dt = new DataTable();
        public PrihodForm()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("receipt_id", "Номер накладной");
            dataGridView1.Columns.Add("storehouse_name", "Склад");
            dataGridView1.Columns.Add("storehouse_type", "Тип склада");
            dataGridView1.Columns.Add("receipt_counterparty", "Поставщик");
            dataGridView1.Columns.Add("receipt_date", "Дата");
            dataGridView1.Columns.Add("receipt_mol", "МОЛ");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            
            dataGridView2.Columns.Add("sales_id", "Номер накладной");
            dataGridView2.Columns.Add("storehouse_name", "Склад");
            dataGridView2.Columns.Add("storehouse_type", "Тип склада");
            dataGridView2.Columns.Add("counterparty_short_name", "Поставщик");
            dataGridView2.Columns.Add("sales_data", "Дата");
            dataGridView2.Columns.Add("mol_last_name", "МОЛ");
            dataGridView2.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetString(5), RowState_MOL.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from receipt, storehouse, counterparty ";
            MySqlCommand command = new MySqlCommand(queryString, db.getConnection());
            db.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void PrihodForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

       /* private DataTable loadData()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            DataSet ds = new DataSet();

            string sql = "SELECT * FROM sales";
            command = new MySqlCommand(sql,db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            dt = ds.Tables[0];

            return dt;
        } */

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPrihodForm addPrihodForm = new AddPrihodForm();
            addPrihodForm.Show();
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
                dataGridView1.Rows[index].Cells[6].Value = RowState_Prihod.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState_Prihod.Deleted;
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
                var RowState = (RowState_Prihod)dataGridView1.Rows[index].Cells[6].Value;
                if (RowState == RowState_Prihod.Existed)
                    continue;
                if (RowState == RowState_Prihod.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from sales where sales_id = {id}";
                    var command = new MySqlCommand(deleteQuery, db.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            db.closeConnection();
        }
    }
}
