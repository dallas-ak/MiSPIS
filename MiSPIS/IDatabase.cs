using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace MiSPIS.Tests
{
    public interface IDatabase
    {
        MySqlConnection GetConnection();
        void OpenConnection(MySqlConnection connection);
        void CloseConnection(MySqlConnection connection);
        int ExecuteNonQuery(MySqlCommand command);
        DataTable ExecuteQuery(MySqlCommand command);
    }
    public interface md5hash
    {
        string HashPassword(string password);
    }
    public class Authentication
    {
        private readonly IDatabase database;
        public Authentication(IDatabase database)
        {
            this.database = database;
        }
        public bool AuthenticateUser(string login, string password)
        {
            string hashedPassword = md5.hashPassword(password);
            using (var connection = database.GetConnection())
            {
                var command = new MySqlCommand("SELECT * FROM users WHERE login = @uL AND pass = @uP", connection);
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = hashedPassword;
                var table = database.ExecuteQuery(command);
                return table.Rows.Count > 0;
            }
        }
    }
    public class RegistrationService
    {
        private readonly IDatabase _database;
        public RegistrationService(IDatabase database)
        {
            _database = database;

        }
        public bool RegisterUser(string login, string password, string name, string surname, out string message)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                message = "Введите имя";
                return false;
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                message = "Введите фамилию";
                return false;
            }
            if (string.IsNullOrWhiteSpace(login))
            {
                message = "Введите имя пользователя";
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                message = "Введите пароль";
                return false;
            }
            if (IsUserExists(login))
            {
                message = "Такой пользователь уже зарегистрирован";
                return false;
            }
            string hashedPassword = md5.hashPassword(password);
            MySqlCommand command = new MySqlCommand("INSERT INTO users (login, pass, name, surname) VALUES (@login, @pass, @name, @surname)", _database.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = hashedPassword;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
            _database.OpenConnection(command.Connection);
            var result = _database.ExecuteNonQuery(command);
            if (result == 1)
            {
                message = "Успешная регистрация";
                return true;
            }
            else
            {
                message = "Ошибка регистрации";
                return false;
            }
        }
        public bool IsUserExists(string login)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL", _database.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            var table = _database.ExecuteQuery(command);

            return table.Rows.Count > 0;
        }
    }
    class md5
    {
        public static string hashPassword(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);
            StringBuilder sb = new StringBuilder();
            foreach (var a in hash)
                sb.Append(a.ToString("X2"));
            return Convert.ToString(sb);
        }
    }
}