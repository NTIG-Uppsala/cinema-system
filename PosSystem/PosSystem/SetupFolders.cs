using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;
using static System.Net.Mime.MediaTypeNames;


namespace PosSystem
{
    public class SetupFolders
    {
        string baseFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem";
        string receiptFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\PosReceipts";

        private static List<string> tables = new List<string>()
        {
            "CREATE TABLE products (name text, price text, vat integer, product_id integer PRIMARY KEY AUTOINCREMENT, color text);",
            "INSERT INTO products (name, price, color) VALUES ('Popcorn', 50, 'yellow');",
            "INSERT INTO products (name, price, color) VALUES ('Läsk', 35, 'pink');",
            "INSERT INTO products (name, price, color) VALUES ('Ahlgrens Bilar', 25, '#AA918E');",
            "CREATE TABLE movies (name text, price text, vat integer,movie_id integer PRIMARY KEY AUTOINCREMENT, duration integer);",
            "INSERT INTO movies (name, price, duration) VALUES ('Shrek 1', 170, 90);",
            "INSERT INTO movies (name, price, duration) VALUES ('Shrek 2', 170, 105);",
            "INSERT INTO movies (name, price, duration) VALUES ('Shrek 3', 170, 93);",
            "CREATE TABLE reservation (seat_id integer, reservation_id integer PRIMARY KEY AUTOINCREMENT, screening_id integer, booking_id integer, FOREIGN KEY(screening_id) REFERENCES screening(screen_id), FOREIGN KEY(booking_id) REFERENCES bookings(booking_id), FOREIGN KEY(seat_id) REFERENCES seats(seat_id));",
            "CREATE TABLE screenings (movie_id integer, start_time text, screen_id integer PRIMARY KEY AUTOINCREMENT, salon_id integer, FOREIGN KEY(movie_id) REFERENCES movies(movie_id), FOREIGN KEY(salon_id) REFERENCES salon(salon_id));",
            "CREATE TABLE salon (salon_id integer PRIMARY KEY AUTOINCREMENT);",
            "INSERT INTO salon DEFAULT VALUES;",
            "INSERT INTO salon DEFAULT VALUES;",
            "INSERT INTO screenings (movie_id, start_time, salon_id) VALUES (1, '2023-01-01 13:37', 2);",
            "INSERT INTO screenings (movie_id, start_time, salon_id) VALUES (2, '2023-01-01 13:37', 1);",
            "INSERT INTO screenings (movie_id, start_time, salon_id) VALUES (3, '2023-01-01 19:00', 2);",
            "CREATE TABLE seats (seat_id integer PRIMARY KEY AUTOINCREMENT, number integer, row integer, salon_id integer, FOREIGN KEY(salon_id) REFERENCES salon(salon_id));",
            "CREATE TABLE bookings (booking_id integer PRIMARY KEY AUTOINCREMENT, customer_id integer, FOREIGN KEY(customer_id) REFERENCES customer(customer_id));",
            "CREATE TABLE customer (customer_id integer PRIMARY KEY AUTOINCREMENT, name text);"
        };

        public void createSalons()
        {
            // Salon 1, 2x3 seats
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    tables.Add($"INSERT INTO seats (number, row, salon_id) VALUES ({i}, {j}, 1);");
                }
            }

            // Salon 2, 3x4 seats
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    tables.Add($"INSERT INTO seats (number, row, salon_id) VALUES ({i}, {j}, 2);");
                }
            }
        }

        

        public SetupFolders()
        {
            Directory.CreateDirectory(baseFolder);
            Directory.CreateDirectory(receiptFolder);

            if (!File.Exists($@"{baseFolder}\movies.csv"))
            {
                List<string> products = new List<string>()
                {
                    "Filmnamn,Pris,Moms",
                    "Shrek 1,170,",
                    "Shrek 2,170,",
                    "Shrek 3,170,",
                };

                File.WriteAllLines($@"{baseFolder}\movies.csv", products);
            }


            var dbPath = $@"{baseFolder}\database.db";

            if (!File.Exists(dbPath))
            {
                createSalons();

                var db = new SqliteConnection($"Data Source={dbPath};");
                db.Open();

                using (DbCommand cmd = db.CreateCommand())
                {
                    foreach (string table in tables)
                    {
                        cmd.CommandText += table;
                    }
                    cmd.ExecuteReader();
                }
                db.Close();

            }
        }
    }
}
