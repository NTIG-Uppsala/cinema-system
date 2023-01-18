using System;
using System.Collections.Generic;
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
        private static string products = "SELECT * FROM products;";

        public List<ProductClass> moviesList = File.ReadAllLines(csvLocationMovies)
                                                    .Skip(1)
                                                    .Select(v => ParseCsv(v))
                                                    .ToList();

        // string productValues = ("SELECT name, price, color FROM products")

        public List<ProductClass> productlist = new List<ProductClass>();

        /*
         
        for (int i = 0; i < rows.Count; i++) {
            ProductClass product = new ProductClass();    
            product.name = "(string)productValues[i]["name"]";
            product.price = "(Int64)productValues[i]["price"]";
            product.color = "(string)productValues[i]["color"]";
            product.add(productlist);
        }
         
         
         */


        //Från databasen skapa x mängd producter med klassen Procductclass och lägg den nyskapta klassen i en  list
        public static ProductClass ParseCsv(string csvLine)
        {

            string[] values = csvLine.Split(",");

            try
            {
                ProductClass product = new(values[0], decimal.Parse(values[1]), values[2], int.Parse(values[3]));
                return product;
            }
            catch
            {
                ProductClass product = new(values[0], decimal.Parse(values[1]), values[2]);
                return product;
            }
        }

    }
}
