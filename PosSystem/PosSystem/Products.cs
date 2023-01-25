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
