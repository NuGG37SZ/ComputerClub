using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Utils;

namespace ComputerClub.Repository
{
    public class UserRepositoryImpl : IUserRepository
    {
        public void Create(User user)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "INSERT INTO users (login, password, role) VALUES(@login, @password, @role)";

                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@login", user.Login);
                    command.Parameters.AddWithValue("@password", Hash.HashFunction(user.Password));
                    command.Parameters.AddWithValue("@role", user.Role);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show("Вы успешно создали пользователя!");
                    } 
                    else
                    {
                        MessageBox.Show("Произошла ошибка :с пользователь не создан!", "ERROR");
                    }
                }
            }
        }

        public void Delete(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "DELETE FROM users WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show("Вы успешно удалили пользователя!");
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка :с пользователь не удален!", "ERROR");
                    }
                }
            }
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT * FROM users";

                using(SQLiteCommand command = new SQLiteCommand(sql,connection))
                {
                    using(SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string login = reader["login"].ToString();
                            string password = reader["password"].ToString();
                            string role = reader["role"].ToString();
                            users.Add(new User(id, login, password, role));
                        }
                    }
                }
            }
            return users;
        }

        public User GetUserByLogin(string login)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
                {
                    connection.Open();

                    string sql = "SELECT * FROM users WHERE login = @login";

                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string password = reader["password"].ToString();
                                string role = reader["role"].ToString();
                                return new User(id, login, password, role);
                            }
                        }
                    }
                }
                return new User();
            }
            catch (Exception)
            {
                MessageBox.Show("Логин должен быть уникальным!");
                return new User();
            }
        }
    }
}
