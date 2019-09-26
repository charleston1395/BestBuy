using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy
{
    class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double PriceWithTax(double price)

        {
            Price = price;
            return price * 1.1;
            
        }


    }
}
