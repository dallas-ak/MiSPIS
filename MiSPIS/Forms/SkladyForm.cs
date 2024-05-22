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

namespace MiSPIS.Forms
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        Modifiednew,
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
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name", "Наименование");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.Modifiednew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from sklady";
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

    }
}
