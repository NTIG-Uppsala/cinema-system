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
        readonly string baseFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem";
        readonly string receiptFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\PosReceipts";

        private static List<string> tables = new List<string>()
        {
            "CREATE TABLE products (name text NOT NULL, price text NOT NULL, vat integer DEFAULT 12, product_id integer PRIMARY KEY AUTOINCREMENT, color text);",
            "CREATE TABLE movies (name text NOT NULL, price text NOT NULL, vat integer DEFAULT 25, movie_id integer PRIMARY KEY AUTOINCREMENT, duration integer);",
            "CREATE TABLE reservations (seat_id integer NOT NULL, reservation_id integer PRIMARY KEY AUTOINCREMENT, screening_id integer NOT NULL, booking_id integer NOT NULL, FOREIGN KEY(screening_id) REFERENCES screenings(screen_id), FOREIGN KEY(booking_id) REFERENCES bookings(booking_id), FOREIGN KEY(seat_id) REFERENCES seats(seat_id));",
            "CREATE TABLE screenings (movie_id integer NOT NULL, start_time text NOT NULL, screen_id integer PRIMARY KEY AUTOINCREMENT, salon_id integer NOT NULL, FOREIGN KEY(movie_id) REFERENCES movies(movie_id), FOREIGN KEY(salon_id) REFERENCES salons(salon_id));",
            "CREATE TABLE salons (salon_id integer PRIMARY KEY AUTOINCREMENT);",
            "CREATE TABLE seats (seat_id integer PRIMARY KEY AUTOINCREMENT, number integer NOT NULL, row integer NOT NULL, salon_id integer NOT NULL, FOREIGN KEY(salon_id) REFERENCES salons(salon_id));",
            "CREATE TABLE bookings (booking_id integer PRIMARY KEY AUTOINCREMENT, customer_id integer, FOREIGN KEY(customer_id) REFERENCES customers(customer_id));",
            "CREATE TABLE customers (customer_id integer PRIMARY KEY AUTOINCREMENT, name text);"
        };

        public void sampleSeats()
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
        
        public void sampleProducts()
        {
            tables.Add("INSERT INTO products (name, price, color) VALUES ('Popcorn', 50, 'yellow');");
            tables.Add("INSERT INTO products (name, price, color) VALUES ('Läsk', 35, 'pink');");
            tables.Add("INSERT INTO products (name, price, color) VALUES ('Ahlgrens Bilar', 25, '#AA918E');");
        }

        public void sampleSalons()
        {
            for (int i = 1; i <= 2; i++)
            {
                tables.Add("INSERT INTO salons DEFAULT VALUES;");
            }
        }
        
        public void sampleScreenings()
        {
            tables.Add("INSERT INTO screenings (movie_id, start_time, salon_id) VALUES (1, '2023-01-01 13:37', 2);");
            tables.Add("INSERT INTO screenings (movie_id, start_time, salon_id) VALUES (2, '2023-01-01 13:37', 1);");
            tables.Add("INSERT INTO screenings (movie_id, start_time, salon_id) VALUES (3, '2023-01-01 19:00', 2);");
        }
        
        public void sampleMovies()
        {
            tables.Add("INSERT INTO movies (name, price, duration) VALUES ('Shrek 1', 170, 90);");
            tables.Add("INSERT INTO movies (name, price, duration) VALUES ('Shrek 2', 170, 105);");
            tables.Add("INSERT INTO movies (name, price, duration) VALUES ('Shrek 3', 170, 93);");
        }

        public void sampleBooking1()
        {
            tables.Add("INSERT INTO customers (name) VALUES ('Sven Svensson');");
            tables.Add("INSERT INTO bookings (customer_id) VALUES (1);");
            tables.Add("INSERT INTO reservations (seat_id, booking_id, screening_id) VALUES (7, 1, 1);");
            tables.Add("INSERT INTO reservations (seat_id, booking_id, screening_id) VALUES (9, 1, 1);");
        }

        public void sampleBooking2()
        {
            tables.Add("INSERT INTO customers (name) VALUES ('Karl Johansson');");
            tables.Add("INSERT INTO bookings (customer_id) VALUES (2);");
            tables.Add("INSERT INTO reservations (seat_id, booking_id, screening_id) VALUES (4, 2, 2);");
            tables.Add("INSERT INTO reservations (seat_id, booking_id, screening_id) VALUES (5, 2, 2);");
            tables.Add("INSERT INTO reservations (seat_id, booking_id, screening_id) VALUES (6, 2, 2);");
        }

        public void sampleBooking3()
        {
            tables.Add("INSERT INTO customers (name) VALUES ('Linda Berg');");
            tables.Add("INSERT INTO bookings (customer_id) VALUES (3);");
            tables.Add("INSERT INTO reservations (seat_id, booking_id, screening_id) VALUES (13, 3, 3);");
            tables.Add("INSERT INTO reservations (seat_id, booking_id, screening_id) VALUES (1, 3, 2);");
        }

        public void sampleBooking4()
        {
            tables.Add("INSERT INTO bookings (customer_id) VALUES (1);");
            tables.Add("INSERT INTO reservations (seat_id, booking_id, screening_id) VALUES (9, 4, 3);");
        }

        public SetupFolders()
        {
            Directory.CreateDirectory(baseFolder);
            Directory.CreateDirectory(receiptFolder);

            var dbPath = $@"{baseFolder}\database.db";

            if (!File.Exists(dbPath))
            {
                sampleProducts();
                sampleMovies();
                sampleSalons();
                sampleScreenings();
                sampleSeats();
                sampleBooking1();
                sampleBooking2();
                sampleBooking3();
                sampleBooking4();

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
