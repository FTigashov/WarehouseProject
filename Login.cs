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
    public partial class Login : Form
    {
        Db db = new Db();

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            

        }

        private void Login_Load(object sender, EventArgs e)
        {
            pwdTextBox.PasswordChar = '*';
            showPic.Visible = false;
            loginTextBox.MaxLength = 50;
            pwdTextBox.MaxLength = 10;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginUser = loginTextBox.Text;
            var pwdUser = pwdTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id, user_login, user_pwd FROM register WHERE user_login = '{loginUser}' AND user_pwd = '{pwdUser}'";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Авторизация успешна!");
                loginTextBox.Text = "";
                pwdTextBox.Text = "";
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else {
                MessageBox.Show("Данный аккаунт не существует!");
                loginTextBox.Text = "";
                pwdTextBox.Text = "";
            }
        }

        private void pwdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void notShowPic_Click(object sender, EventArgs e)
        {
            pwdTextBox.UseSystemPasswordChar = true;
            notShowPic.Visible = false;
            showPic.Visible = true;
        }

        private void showPic_Click_1(object sender, EventArgs e)
        {
            pwdTextBox.UseSystemPasswordChar = false;
            notShowPic.Visible = true;
            showPic.Visible = false;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = "";
            pwdTextBox.Text = "";
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
