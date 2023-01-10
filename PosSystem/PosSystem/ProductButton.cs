using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem
{
    internal class ProductButton : Button
    {
        public ProductClass product;

        public ProductButton(ProductClass product)
        {
            this.product = product;
        }
    }
}
