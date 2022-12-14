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

        // VAT = moms and is 12% for food and 25% for most other products
        public int Vat = 0;

        public ProductClass(string name, decimal price, int vat = 12)
        {
            this.Name = name;
            this.Price = price;
            this.Vat = vat;
        }
    }
}
