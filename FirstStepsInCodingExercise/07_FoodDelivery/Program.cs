using System;

namespace _07_FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chiken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegi = int.Parse(Console.ReadLine());

            double menu = chiken * 10.35 + fish * 12.40 + vegi * 8.15;
            double desert = menu * 0.2;
                        
            Console.WriteLine(menu + desert + 2.50);
        }
    }
}
