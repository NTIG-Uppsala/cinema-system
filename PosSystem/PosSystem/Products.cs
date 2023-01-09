using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem
{
    public class Products
    {
        private static string csvLocation = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\products.csv";

        public List<ProductClass> productList = File.ReadAllLines(csvLocation)
                                                    .Skip(1)
                                                    .Select(v => ParseCsv(v))
                                                    .ToList();

        public static ProductClass ParseCsv(string csvLine)
        {
            string[] values = csvLine.Split(",");

            ProductClass product = new(values[0], decimal.Parse(values[1]), int.Parse(values[2]));

            return product;
        }
    }
}
