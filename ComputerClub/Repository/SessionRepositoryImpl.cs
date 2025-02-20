using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Utils;

namespace ComputerClub.Repository
{
    public class SessionRepositoryImpl : ICRUDRepository<Session>
    {
        public void Create(Session entity)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "INSERT INTO sessions (client_id, computer_id, start_play, end_play) " +
                    "VALUES (@cliend_id, @computer_id, @start_play, @end_play)";

                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@cliend_id", entity.ClientId);
                    command.Parameters.AddWithValue("@computer_id", entity.ComputerId);
                    command.Parameters.AddWithValue("@start_play", entity.StartPlay);
                    command.Parameters.AddWithValue("@end_play", entity.EndPlay);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы создали сессию, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Создать сессию не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }

        public void Delete(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "DELETE FROM sessions WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы удалили сессию, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Удалить сессию не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }

        public List<Session> GetAll()
        {
            List<Session> sessions = new List<Session>();  

            using(SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT * FROM sessions";

                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            int clientId = Convert.ToInt32(reader["client_id"]);
                            int computerId = Convert.ToInt32(reader["computer_id"]);
                            DateTime startPlay = Convert.ToDateTime(reader["start_play"]);
                            DateTime endPlay = Convert.ToDateTime(reader["end_play"]);
                            sessions.Add(new Session(id, clientId, computerId, startPlay, endPlay));
                        }
                    }
                }
            }
            return sessions;
        }

        public Session GetById(int id)
        {
            using(SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                string sql = "SELECT * FROM sessions WHERE id = @id";

                using(SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("id", id);

                    using(SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            int clientId = Convert.ToInt32(reader["client_id"]);
                            int computerId = Convert.ToInt32(reader["computer_id"]);
                            DateTime startPlay = Convert.ToDateTime(reader["start_play"]);
                            DateTime endPlay = Convert.ToDateTime(reader["end_play"]);
                            return new Session(id, clientId, computerId, startPlay, endPlay);
                        }
                    }
                }
            }
            return null;
        }

        public void Update(int id, Session entity)
        {
            using(SQLiteConnection connection = new SQLiteConnection(ConnectionStringProvider.GetConnectionString()))
            {
                connection.Open();

                Session currentSession = GetById(id);

                if (currentSession != null)
                {
                    currentSession.ClientId = entity.ClientId;
                    currentSession.ComputerId = entity.ComputerId;
                    currentSession.StartPlay = entity.StartPlay;
                    currentSession.EndPlay = entity.EndPlay;
                }

                string sql = "UPDATE sessions SET client_id = @client_id, computer_id = @computer_id, " +
                    "start_play = @start_play, end_play = @end_play " +
                    "WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@client_id", entity.ClientId);
                    command.Parameters.AddWithValue("@computer_id", entity.ComputerId);
                    command.Parameters.AddWithValue("@start_play", entity.StartPlay);
                    command.Parameters.AddWithValue("@end_play", entity.EndPlay);
                    int rowsUpdate = command.ExecuteNonQuery();

                    if (rowsUpdate > 0)
                    {
                        MessageBox.Show($"Вы обновили сессию, строк обновлено {rowsUpdate}");
                    }
                    else
                    {
                        MessageBox.Show($"Обновить сессию не удалось :(, строк обновлено {rowsUpdate}", "ERROR");
                    }
                }
            }
        }
    }
}
