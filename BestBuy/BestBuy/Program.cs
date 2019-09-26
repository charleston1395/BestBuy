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
            Console.WriteLine($"{game.Name} costs {game.PriceWithTax(300)} with tax included. or {game.Price} without tax");
        }
    }
}
