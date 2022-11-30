using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem
{
    public class ProductClass
    {
        public string Name = "";
        public decimal Price = 0m;

        public ProductClass(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
