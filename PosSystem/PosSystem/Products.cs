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
        private static string csvLocationProducts = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\products.csv";
        private static string csvLocationMovies = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\movies.csv";

        public List<ProductClass> productList = File.ReadAllLines(csvLocationProducts)
                                                    .Skip(1)
                                                    .Select(v => ParseCsv(v))
                                                    .ToList();

        public List<ProductClass> moviesList = File.ReadAllLines(csvLocationMovies)
                                                    .Skip(1)
                                                    .Select(v => ParseCsv(v))
                                                    .ToList();

        public static ProductClass ParseCsv(string csvLine)
        {

            string[] values = csvLine.Split(",");

            try
            {
                ProductClass product = new(values[0], decimal.Parse(values[1]), int.Parse(values[2]));
                return product;
            }
            catch
            {
                ProductClass product = new(values[0], decimal.Parse(values[1]));
                return product;
            }
        }

    }
}
