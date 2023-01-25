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
        public TicketProduct(string name, decimal price, Int64 movie_id, Int64 vat = 25) : base(name, price, movie_id, "white", vat)
        {
            Debug.WriteLine(name);
        }
    }
}
