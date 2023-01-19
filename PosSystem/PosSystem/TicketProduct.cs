using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem
{
    public class TicketProduct : ProductClass
    {
        public TicketProduct(string name, decimal price, Int64 product_id, string color, int vat = 25) : base(name, price, product_id, color, vat)
        {
            Debug.WriteLine(name);
        }
    }
}
