using System;

namespace _08_BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double shooes = tax * 0.6;
            double kit = shooes * 0.8;
            double ball = kit / 4;
            double aux = ball / 5;
            
            Console.WriteLine(tax+shooes+kit+ball+aux);
        }
    }
}
