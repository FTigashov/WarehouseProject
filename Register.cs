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
    public partial class Register : Form
    {

        Db db = new Db();
        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            pwdTextBox.PasswordChar = '*';
            showPic.Visible = false;
            loginTextBox.MaxLength = 50;
            pwdTextBox.MaxLength = 10;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = "";
            pwdTextBox.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void notShowPic_Click(object sender, EventArgs e)
        {
            pwdTextBox.UseSystemPasswordChar = true;
            notShowPic.Visible = false;
            showPic.Visible = true;
        }

        private void showPic_Click(object sender, EventArgs e)
        {
            pwdTextBox.UseSystemPasswordChar = false;
            notShowPic.Visible = true;
            showPic.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var loginUser = loginTextBox.Text;
            var pwdUser = pwdTextBox.Text;

            if (CheckUser() == true)
            {
                MessageBox.Show("Данный аккаунт уже существует!");
            }
            else {
                string query = $"INSERT INTO register (user_login, user_pwd) VALUES('{loginUser}', '{pwdUser}')";
                SqlCommand command = new SqlCommand(query, db.GetConnection());

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Пользователь успешно зарегистрирован!");
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Ошибка регистрации!");
                }
                db.closeConnection();
            }

        }

        private Boolean CheckUser() {
            var loginUser = loginTextBox.Text;
            var pwdUser = pwdTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string query = $"SELECT id, user_login FROM register WHERE user_login = '{loginUser}'";

            SqlCommand sqlCommand = new SqlCommand(query, db.GetConnection());
            adapter.SelectCommand = sqlCommand;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
