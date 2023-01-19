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
        public string Color = "";
        public Int64 product_id = 0;

        // VAT = moms and is 12% for food and 25% for most other products
        public Int64 Vat = 0;

        public ProductClass(string name, decimal price, Int64 product_id ,string color, Int64 vat = 12)
        {
            this.Name = name;
            this.Price = price;
            this.product_id = product_id;
            this.Color = color;
            this.Vat = vat;
        }
    }
}
