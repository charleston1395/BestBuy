using System;

namespace BestBuy
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Product();
            game.Name = "Xbox One";
            game.Price = 300;
            Console.WriteLine("Product Name: " + game.Name + "Price" + game.Price + " After Tax: " + game.PriceWithTax());
        }
    }
}
