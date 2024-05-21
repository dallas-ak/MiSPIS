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

namespace MiSPIS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text; // Получили введенный логин
            String passUser = passwordField.Text; // Получили введенный пароль

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection()); // Выбор всех записей, у которых логин и пароль совпадает с введенным логином и паролем из БД
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser; // меняем заглушку на переменную логина
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser; // меняем заглушку на переменную пароля

            adapter.SelectCommand = command; // выбрали и выполнили команду
            adapter.Fill(table); // заносим полученные данные в table

            if (table.Rows.Count > 0) // проверка сколько записей соответсвует введому логину и паролю
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
                MessageBox.Show("No");
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {       
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        Point lastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

