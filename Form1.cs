using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WarehouseProject
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {
        Db db = new Db();

        int selectedRow;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGrid);
        }

        private void CreateColumns()
        {
            dataGrid.Columns.Add("id", "ID");
            dataGrid.Columns.Add("product_type", "Тип продукции");
            dataGrid.Columns.Add("count", "Количество");
            dataGrid.Columns.Add("supplier", "Поставщик");
            dataGrid.Columns.Add("cost", "Стоимость");
            dataGrid.Columns.Add("isNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dataGrid, IDataRecord record) {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            string query = $"SELECT * FROM supply";

            SqlCommand command = new SqlCommand(query, db.GetConnection());

            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                ReadSingleRow(dataGrid, reader);
            }
            reader.Close();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0) {
                DataGridViewRow row = dataGrid.Rows[selectedRow];

                idField.Text = row.Cells[0].Value.ToString();
                typeField.Text = row.Cells[1].Value.ToString();
                countField.Text = row.Cells[2].Value.ToString();
                supplierField.Text = row.Cells[3].Value.ToString();
                costField.Text = row.Cells[4].Value.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            idField.Text = "";
            typeField.Text = "";
            countField.Text = "";
            supplierField.Text = "";
            costField.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGrid);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        public void deleteRow()
        {
            int index = dataGrid.CurrentCell.RowIndex;

            dataGrid.Rows[index].Visible = false;

            if (dataGrid.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGrid.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            dataGrid.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void Update()
        {
            db.openConnection();

            for (int index = 0; index < dataGrid.Rows.Count; index++) {
                var rowState = (RowState)dataGrid.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed) {
                    continue;
                }

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGrid.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM supply WHERE id = '{id}'";
                    ClearFields();

                    var command = new SqlCommand(deleteQuery, db.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified) {
                    var id = dataGrid.Rows[index].Cells[0].Value.ToString();
                    var type = dataGrid.Rows[index].Cells[1].Value.ToString();
                    var count = dataGrid.Rows[index].Cells[2].Value.ToString();
                    var sup = dataGrid.Rows[index].Cells[3].Value.ToString();
                    var cost = dataGrid.Rows[index].Cells[4].Value.ToString();

                    var changedQuery = $"UPDATE supply SET product_type = '{type}', count = '{count}', supplier = '{sup}', cost = '{cost}' WHERE id = '{id}'";
                    ClearFields();                   

                    var command = new SqlCommand(changedQuery, db.GetConnection());
                    command.ExecuteNonQuery();
                }
            }

            db.closeConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void ClearFields() {
            idField.Text = "";
            typeField.Text = "";
            countField.Text = "";
            supplierField.Text = "";
            costField.Text = "";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void Change() {
            var selectedRowIndex = dataGrid.CurrentCell.RowIndex;

            var id = idField.Text;
            var type = typeField.Text;
            var count = countField.Text;
            var sup = supplierField.Text;
            int cost;

            if (dataGrid.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(costField.Text, out cost)) {
                    dataGrid.Rows[selectedRowIndex].SetValues(id, type, count, sup, cost);
                    dataGrid.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Стоимость должна иметь цифровой формат!");
                }
            }

        }
    }

}
