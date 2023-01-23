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

        private static readonly string[] tables =
        {
            "CREATE TABLE products (name text, price text, vat integer, product_id integer PRIMARY KEY AUTOINCREMENT, color text);",
            "INSERT INTO products (name, price, color) VALUES ('Popcorn', 50, 'yellow');",
            "INSERT INTO products (name, price, color) VALUES ('Läsk', 35, 'pink');",
            "INSERT INTO products (name, price, color) VALUES ('Ahlgrens Bilar', 25, '#AA918E');",
            "CREATE TABLE movies (name text, price text, vat integer,movie_id integer PRIMARY KEY AUTOINCREMENT, duration integer);",
            "CREATE TABLE reservation (seat_id integer, reservation_id integer PRIMARY KEY AUTOINCREMENT, screening_id integer, booking_id integer, FOREIGN KEY(screening_id) REFERENCES screening(screen_id), FOREIGN KEY(booking_id) REFERENCES bookings(booking_id), FOREIGN KEY(seat_id) REFERENCES seats(seat_id));",
            "CREATE TABLE screenings (movie_id integer, start_time text, screen_id integer PRIMARY KEY AUTOINCREMENT, salon_id integer, FOREIGN KEY(movie_id) REFERENCES movies(movie_id), FOREIGN KEY(salon_id) REFERENCES salon(salon_id));",
            "CREATE TABLE salon (salon_id integer PRIMARY KEY AUTOINCREMENT);",
            "CREATE TABLE seats (seat_id integer PRIMARY KEY AUTOINCREMENT, number integer, row integer, salon_id integer, FOREIGN KEY(salon_id) REFERENCES salon(salon_id));",
            "CREATE TABLE bookings (booking_id integer PRIMARY KEY AUTOINCREMENT, customer_id integer, FOREIGN KEY(customer_id) REFERENCES customer(customer_id));",
            "CREATE TABLE customer (customer_id integer PRIMARY KEY AUTOINCREMENT, name text);"
        };

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
