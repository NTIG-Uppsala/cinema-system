﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;


namespace PosSystem
{
    public class SetupFolders
    {
        string baseFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem";
        string receiptFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\PosReceipts";

        public SetupFolders()
        {
            Directory.CreateDirectory(baseFolder);
            Directory.CreateDirectory(receiptFolder);

            if (!File.Exists($@"{baseFolder}\products.csv"))
            {
                List<string> products = new List<string>()
                {
                    "Produktnamn,Pris,Färg,Moms",
                    "Popcorn Liten,25,Red,",
                    "Popcorn Mellan,35,Red,",
                    "Popcorn Stor,50,Red,",
                    "Läsk Liten,20,Red,",
                    "Läsk Mellan,25,Red,",
                    "Läsk Stor,35,Red,",
                };

                File.WriteAllLines($@"{baseFolder}\products.csv", products);
            }

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
                string query = "CREATE TABLE bookings(booking_id int NOT NULL UNIQUE, PRIMARY KEY (booking_id))";

                var db = new SqliteConnection($"Data Source={dbPath};");
                db.Open();

                using (DbCommand cmd = db.CreateCommand())
                {
                    cmd.CommandText += query;
                    cmd.ExecuteReader();
                }
                db.Close();

            }
        }
    }
}
