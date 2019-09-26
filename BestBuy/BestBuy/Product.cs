using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy
{
    class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double PriceWithTax()

        {
            Price = 300;
            _ = Price * 1.1;
            
            Name = ("Xbox one");
            Console.WriteLine("The price of the Xbox one is 300 with tax the cost is 330");
            return Price;
        }


    }
}
