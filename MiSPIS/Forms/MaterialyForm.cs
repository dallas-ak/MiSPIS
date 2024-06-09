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
    enum RowState_Materialy
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MaterialyForm : Form
    {
        DB db = new DB();
        public MaterialyForm()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("materials.material_id", "Код");
            dataGridView1.Columns.Add("material_vendor_code", "Артикул");
            dataGridView1.Columns.Add("material_name", "Наименование товара");
            dataGridView1.Columns.Add("storehouse.storehouse_name", "Склад");
            dataGridView1.Columns.Add("type.type_name", "Тип склада");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState_Materialy.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT materials.material_id, material_vendor_code, material_name, storehouse.storehouse_name, type.type_name " +
                $"FROM materials, storehouse_type " +
                $"LEFT JOIN storehouse ON (storehouse.storehouse_id = storehouse_type.storehouse_id) " +
                $"LEFT JOIN type ON (type.type_id = storehouse_type.type_id)";
            MySqlCommand command = new MySqlCommand(queryString, db.getConnection());
            db.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void MaterialyForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMaterialyForm addMaterialyForm = new AddMaterialyForm();
            addMaterialyForm.Show();
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
                dataGridView1.Rows[index].Cells[5].Value = RowState_Materialy.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState_Materialy.Deleted;
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
                var rowState = (RowState_Materialy)dataGridView1.Rows[index].Cells[5].Value;
                if (rowState == RowState_Materialy.Existed)
                    continue;
                if (rowState == RowState_Materialy.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM materials where material_id = {id}";
                    var command = new MySqlCommand(deleteQuery, db.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            db.closeConnection();
        }
    }
}
