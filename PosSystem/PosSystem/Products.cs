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
        private static string productsLocation = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\database.db";
        private static string csvLocationMovies = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\movies.csv";

        public List<ProductClass> moviesList = File.ReadAllLines(csvLocationMovies)
                                                    .Skip(1)
                                                    .Select(v => ParseCsv(v))
                                                    .ToList();
        string connectionString;
        public Products()
        {
            connectionString = new SqliteConnectionStringBuilder()
            {
                Mode = SqliteOpenMode.ReadWriteCreate,
                DataSource = productsLocation
            }.ToString();
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
                            ProductClass product = new ProductClass(name, price, product_id, color);
                            OutputList.Add(product);
                        }
                    }
                }
                connection.Close();
            }
            return OutputList;
        }

 
         
        
        public static ProductClass ParseCsv(string csvLine)
        {

            string[] values = csvLine.Split(",");

            try
            {
                ProductClass product = new(values[0], decimal.Parse(values[1]), 0, values[2], int.Parse(values[3]));
                return product;
            }
            catch
            {
                ProductClass product = new(values[0], decimal.Parse(values[1]), 0, values[2]);
                return product;
            }
        }

    }
}
