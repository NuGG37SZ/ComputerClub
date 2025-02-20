using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Utils;

namespace ComputerClub.Repository
{
    public class ClientRepositoryImpl : IClientRepository
    {

        public void Create(Client entity)
        {
            using(SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "INSERT INTO clients (login, discount, phone, balance) " +
                    "VALUES(@login, @discount, @phone, @balance)";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@login", entity.Login);
                    command.Parameters.AddWithValue("@discount", entity.Discount);
                    command.Parameters.AddWithValue("@phone", entity.Phone);
                    command.Parameters.AddWithValue("@balance", entity.Balance);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы создали клиента, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Создать клиента не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }

        public void Delete(int id)
        {
            using(SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "DELETE FROM clients WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы удалили клиента, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Удалить клиента не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }

        public List<Client> FindClientsByLoginOrPhone(string text)
        {
            List<Client> clientsList = new List<Client>();

            using(SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT * FROM clients " +
                    "WHERE login LIKE @text OR " +
                    "phone LIKE @text";

                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@text", $"%{text}%");

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string login = reader["login"].ToString();
                            double discount = Convert.ToDouble(reader["discount"]);
                            string phone = reader["phone"].ToString();
                            int balance = Convert.ToInt32(reader["balance"]);
                            clientsList.Add(new Client(id, login, discount, phone, balance));
                        }
                    }
                }
            }
            return clientsList;
        }

        public List<Client> GetAll()
        {
            List<Client> clientList = new List<Client>(); 

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT * FROM clients";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string login = reader["login"].ToString();
                            double discount = Convert.ToDouble(reader["discount"]);
                            string phone = reader["phone"].ToString();
                            int balance = Convert.ToInt32(reader["balance"]);
                            clientList.Add(new Client(id, login, discount, phone, balance));
                        }
                    }
                }
            }
            return clientList;
        }

        public Client GetById(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT * FROM clients WHERE id = @id";

                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string login = reader["login"].ToString();
                            double discount = Convert.ToDouble(reader["discount"]);
                            string phone = reader["phone"].ToString();
                            int balance = Convert.ToInt32(reader["balance"]);
                            return new Client(login, discount, phone, balance);
                        }
                    }
                }
            }
            return null;
        }

        public void Update(int id, Client entity)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                Client currentClient = GetById(id);

                if (currentClient != null)
                {
                    currentClient.Login = entity.Login;
                    currentClient.Discount = entity.Discount;
                    currentClient.Phone = entity.Phone;
                    currentClient.Balance = entity.Balance;
                }

                string sql = "UPDATE clients SET login = @login, discount = @discount, " +
                    "phone = @phone, balance = @balance " +
                    "WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@login", currentClient.Login);
                    command.Parameters.AddWithValue("@discount", currentClient.Discount);
                    command.Parameters.AddWithValue("@phone", currentClient.Phone);
                    command.Parameters.AddWithValue("@balance", currentClient.Balance);
                    command.Parameters.AddWithValue("@id", id);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы обновили клиента, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Обновить клиента не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }
    }
}
