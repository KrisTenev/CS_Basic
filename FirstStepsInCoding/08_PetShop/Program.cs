using System;

namespace _08_PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogBox = int.Parse(Console.ReadLine());
            int catBox = int.Parse(Console.ReadLine());
            double total = dogBox * 2.5 + catBox * 4;
            Console.WriteLine($"{total} lv.");
        }
    }
}
