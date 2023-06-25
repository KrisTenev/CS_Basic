using System;

namespace _05_SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double total = (pens * 5.80 + markers * 7.20 + cleaner * 1.20) * (1 - discount / 100.0);

            Console.WriteLine(total);
        }
    }
}
