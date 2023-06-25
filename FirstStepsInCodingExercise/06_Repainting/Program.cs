using System;

namespace _06_Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razred = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double matirals = (nylon + 2) * 1.50 + paint * 1.1 * 14.50 + razred * 5.0 + 0.4;
            double work = hours * matirals * 0.3;
            
            Console.WriteLine(matirals + work);
        }
    }
}
