using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem
{
    public class Seat
    {
        private static string dbLocation = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\database.db";

        public List<Int64> seat_ids = new();
        public List<Int64> numbers = new();
        public List<Int64> rows = new();
        public List<Int64> salon_ids = new();

        public string connectionString;

        public Seat()
        {
            connectionString = new SqliteConnectionStringBuilder()
            {
                Mode = SqliteOpenMode.ReadWriteCreate,
                DataSource = dbLocation
            }.ToString();
            
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = "SELECT * FROM seats;";

                using (var reader = command.ExecuteReader())
                {
                    using (DataTable datatable = new())
                    {
                        datatable.Load(reader);
                        foreach (DataRow row in datatable.Rows)
                        {
                            seat_ids.Add((Int64)row["seat_id"]);
                            numbers.Add((Int64)row["number"]);
                            rows.Add((Int64)row["row"]);
                            salon_ids.Add((Int64)row["salon_id"]);
                        }
                    }
                }

                connection.Close();
            }
        }

        public List<List<Int64>> RowAndNumberFromSalon(Int64 saloon)
        {
            {
                var list = new List<List<Int64>>();
                using var connection = new SqliteConnection(connectionString);
                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = $"SELECT * FROM seats WHERE salon_id = {saloon};";

                using (var reader = command.ExecuteReader())
                {
                    using (DataTable datatable = new())
                    {
                        datatable.Load(reader);
                        foreach (DataRow row in datatable.Rows)
                        {
                            list[0].Add((Int64)row["row"]);
                            list[1].Add((Int64)row["row"]);
                        }
                    }
                }

                connection.Close();

                return list;
            }
        }

        public List<Int64> ReturnFreeSeatIds()
        {
            List<Int64> freeSeats = new();
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM seats INNER JOIN screenings ON seats.salon_id = screenings.salon_id WHERE seats.seat_id NOT IN (SELECT seat_id FROM reservations WHERE reservations.screening_id = 2) AND screenings.screen_id = 2;";

            using (var reader = command.ExecuteReader())
            {
                using (DataTable datatable = new())
                {
                    datatable.Load(reader);
                    foreach (DataRow row in datatable.Rows)
                    {
                        freeSeats.Add((Int64)row["seat_id"]);
                    }
                }
            }

            connection.Close();

            return freeSeats;
        }
    }
}
