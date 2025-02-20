using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Utils;

namespace ComputerClub.Repository
{
    public class HallRepositoryImpl : IHallRepository
    {
        public void Create(Hall entity)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "INSERT INTO halls (name, price_per_hour, max_count_computers) " +
                    "VALUES (@name, @price_per_hour, @max_count_computers)";

                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", entity.Name);
                    command.Parameters.AddWithValue("@price_per_hour", entity.PricePerHour);
                    command.Parameters.AddWithValue("@max_count_computers", entity.MaxCountComputers);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы создали зал, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Создать зал не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }

        public void Delete(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "DELETE FROM halls WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы удалили зал, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Удалить зал не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }

        public int FindCountComputerById(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT COUNT(*) " +
                    "FROM computers " +
                    "INNER JOIN halls ON computers.hall_id = halls.id " +
                    "WHERE halls.id = @id";

                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue ("@id", id);
                    object count = command.ExecuteScalar();
                    return Convert.ToInt32(count);
                }
            }
        }

        public int FindHallIdByName(string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT id FROM halls WHERE name = @name";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", name);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            return id;
                        }
                    }
                }
            }
            return 0;
        }

        public int FindMaxCountComputerById(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT max_count_computers FROM halls WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int count = Convert.ToInt32(reader["max_count_computers"]);
                            return count;
                        }
                    }
                }
            }
            return 0;
        }

        public List<Hall> GetAll()
        {
            List<Hall> halls = new List<Hall>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT * FROM halls";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string name = reader["name"].ToString();
                            int pricePerHour = Convert.ToInt32(reader["price_per_hour"]);
                            int maxCountComputers = Convert.ToInt32(reader["max_count_computers"]);
                            halls.Add(new Hall(id, name, pricePerHour, maxCountComputers));
                        }
                    }
                }
            }
            return halls;
        }

        public Hall GetById(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT * FROM halls WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int hallId = Convert.ToInt32(reader["id"]);
                            string name = reader["name"].ToString();
                            int pricePerHour = Convert.ToInt32(reader["price_per_hour"]);
                            int maxCountComputers = Convert.ToInt32(reader["max_count_computers"]);
                            return new Hall(hallId, name, pricePerHour, maxCountComputers);
                        }
                    }
                }
            }
            return null;
        }

        public void Update(int id, Hall entity)
        {
            using(SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                Hall currentHall = GetById(id);

                if (currentHall != null) 
                {
                    currentHall.Name = entity.Name;
                    currentHall.PricePerHour = entity.PricePerHour;
                    currentHall.MaxCountComputers = entity.MaxCountComputers;
                }

                string sql = "UPDATE halls " +
                    "SET name = @name, price_per_hour = @price_per_hour, " +
                    "max_count_computers = @max_count_computers " +
                    "WHERE id = @id";

                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", currentHall.Name);
                    command.Parameters.AddWithValue("@price_per_hour", currentHall.PricePerHour);
                    command.Parameters.AddWithValue("@max_count_computers", currentHall.MaxCountComputers);
                    command.Parameters.AddWithValue("@id", id);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы обновили зал, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Обновить зал не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }
    }
}
