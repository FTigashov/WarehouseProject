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
    public partial class AddForm : Form
    {

        Db db = new Db();
        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void addForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void typeField_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var type = typeField.Text;
            var count = countField.Text;
            var sup = supplierField.Text;
            int cost;

            if (type != "" && count != "" && sup != "" && costField.Text != "")
            {
                if (int.TryParse(costField.Text, out cost))
                {
                    var query = $"INSERT INTO supply (product_type, count, supplier, cost) VALUES ('{type}', '{count}', '{sup}', '{cost}')";

                    var command = new SqlCommand(query, db.GetConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Новая запись успешно добавлена!");
                    this.Close();
                }
                else {
                    MessageBox.Show("Ошибка добавления записи! Проверьте корректность введенных данных.");
                }

                db.closeConnection();
            }
            else {
                MessageBox.Show("Необходимо заполнить все поля!");
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
