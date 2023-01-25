using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem
{
    public class Products
    {
        private static string dbLocation = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\database.db";

        public List<ProductClass> productList;
        public List<TicketProduct> movieList;
        public List<string[]> screenings; 

        string connectionString;
        public Products()
        {
            connectionString = new SqliteConnectionStringBuilder()
            {
                Mode = SqliteOpenMode.ReadWriteCreate,
                DataSource = dbLocation
            }.ToString();

            productList = GetProducts();
            movieList = GetMovies();
            screenings = getScreenings();
        }

        public List<string[]> getScreenings()
        {
            var list = new List<string[]>();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                var find_movies = connection.CreateCommand();
                Int64 maxMovieId;

                command.CommandText = "SELECT * FROM screenings;";
                find_movies.CommandText = "SELECT MAX(movie_id) FROM screenings;";

                using (var reader = find_movies.ExecuteReader())
                {
                    reader.Read();
                    maxMovieId = reader.GetInt64(0);
                }

                for (int i = 0; i < maxMovieId; i++)
                {
                    list.Add(new string[4]);
                }

                using (var reader = command.ExecuteReader())
                {
                    using (DataTable datatable = new())
                    {
                        datatable.Load(reader);
                        foreach (DataRow row in datatable.Rows)
                        {
                            string movie_id = Convert.ToString(row["movie_id"]);
                            string start_time = (string)row["start_time"];
                            string screen_id = Convert.ToString(row["screen_id"]);
                            string salon_id = Convert.ToString(row["salon_id"]);


                            list[int.Parse(movie_id) - 1] = new string[] { movie_id, start_time, screen_id, salon_id };
                        }
                    }
                }

                connection.Close();
            }
            return list;
        }

        public List<ProductClass> GetProducts()
        {
            List<ProductClass> OutputList = new();
            // SELECT * FROM Products;
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM products;";

                using (var reader = command.ExecuteReader())
                {
                    using (DataTable datatable = new())
                    {
                        datatable.Load(reader);
                        foreach (DataRow row in datatable.Rows)
                        {
                            decimal price = Convert.ToDecimal(row["price"]);
                            string name = (string)row["name"];
                            string color = (string)row["color"];
                            Int64 product_id = (Int64)row["product_id"];
                            Int64 vat = 12;
                            // Overwrites vat if vat value in db is not null
                            if (row["vat"].GetType() != typeof(DBNull))
                            {
                                vat = (Int64)row["vat"];
                            }
                                
                            ProductClass product = new ProductClass(name, price, product_id, color, vat);
                            OutputList.Add(product);
                        }
                    }
                }
                connection.Close();
            }
            return OutputList;
        }

        public List<TicketProduct> GetMovies()
        {
            List<TicketProduct> OutputList = new();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM movies;";

                using (var reader = command.ExecuteReader())
                {
                    using (DataTable datatable = new())
                    {
                        datatable.Load(reader);
                        foreach (DataRow row in datatable.Rows)
                        {
                            decimal price = Convert.ToDecimal(row["price"]);
                            string name = (string)row["name"];

                            Int64 movie_id = (Int64)row["movie_id"];
                            Int64 vat = 25;
                            // Overwrites vat if vat value in db is not null
                            if (row["vat"].GetType() != typeof(DBNull))
                            {
                                vat = (Int64)row["vat"];
                            }

                            TicketProduct product = new TicketProduct(name, price, movie_id, vat);
                            OutputList.Add(product);
                        }
                    }
                }
                connection.Close();
            }
            return OutputList;
        }
    }
}
