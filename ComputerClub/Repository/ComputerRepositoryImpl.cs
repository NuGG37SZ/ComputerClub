using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Utils;

namespace ComputerClub.Repository
{
    public class ComputerRepositoryImpl : IComputerRepository
    {
        public void Create(Computer entity)
        {
            using(SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "INSERT INTO computers (hall_id, is_busy) VALUES (@hall_id, @is_busy)";
                
                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@hall_id", entity.HallId);
                    command.Parameters.AddWithValue("@is_busy", entity.IsBusy);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы создали ПК, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Создать ПК не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }



        public void Delete(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "DELETE FROM computers WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы удалили ПК, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Удалить ПК не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }

        public List<int> FindAllIdByHallsId(int hallId)
        {
            List<int> ids = new List<int>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT computers.id AS id " +
                    "FROM computers " +
                    "INNER JOIN halls ON computers.hall_id = halls.id " +
                    "WHERE halls.id = @id";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", hallId);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            ids.Add(id);
                        }
                    }
                }
            }
            return ids;
        }

        public List<ComputerDisplay> FindComputerByBusyAndRoom(string text)
        {
            List<ComputerDisplay> computers = new List<ComputerDisplay>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString())) 
            {
                connection.Open();

                string sql = "SELECT computers.id AS id, halls.name AS name, " +
                    "halls.price_per_hour AS price_per_hour, computers.is_busy AS is_busy " +
                    "FROM computers " +
                    "INNER JOIN halls ON computers.hall_id = halls.id " +
                    "WHERE computers.id LIKE @num " +
                    "OR halls.name LIKE @text ";

                using(SQLiteCommand command = new SQLiteCommand(sql,connection))
                {
                    command.Parameters.AddWithValue("@text", $"%{text}%");
                    command.Parameters.AddWithValue("@num", text);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string hallName = Convert.ToString(reader["name"]);
                            int pricePerHour = Convert.ToInt32(reader["price_per_hour"]);
                            bool isBusy = Convert.ToBoolean(reader["is_busy"]);
                            computers.Add(new ComputerDisplay(id, hallName, pricePerHour, isBusy));
                        }
                    }
                }
            }
            return computers;
        }

        public List<Computer> GetAll()
        {
            List<Computer> computers = new List<Computer>();

            using(SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT * FROM computers";

                using(SQLiteCommand command = new SQLiteCommand(sql,connection))
                {
                   using(SQLiteDataReader reader = command.ExecuteReader())
                   {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            int hallId = Convert.ToInt32(reader["hall_id"]);
                            bool isBusy = Convert.ToBoolean(reader["is_busy"]);
                            computers.Add(new Computer(id, hallId, isBusy));
                        }
                   }
                }
            }
            return computers;
        }

        public Computer GetById(int id)
        {
            using(SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT * FROM computers WHERE id = @id";

                using(SQLiteCommand command = new SQLiteCommand(sql, connection)) 
                {
                    command.Parameters.AddWithValue("@id", id);
                    
                    using(SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int computerId = Convert.ToInt32(reader["id"]);
                            int hallId = Convert.ToInt32(reader["hall_id"]);
                            bool isBusy = Convert.ToBoolean(reader["is_busy"]);
                            return new Computer(computerId, hallId, isBusy);
                        }
                    }
                }
            }
            return null;
        }

        public void Update(int id, Computer entity)
        {
            using(SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                Computer currentComputer = GetById(id);

                if (currentComputer != null)
                {
                    currentComputer.HallId = entity.HallId;
                    currentComputer.IsBusy = entity.IsBusy;
                }

                string sql = "UPDATE computers SET hall_id = @hall_id, is_busy = @is_busy WHERE id = @id";

                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@hall_id", currentComputer.HallId);
                    command.Parameters.AddWithValue("@is_busy", currentComputer.IsBusy);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы обновили ПК, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Обновить ПК не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }
    }
}
