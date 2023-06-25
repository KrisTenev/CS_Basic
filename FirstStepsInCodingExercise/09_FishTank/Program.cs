using System;

namespace _09_FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double fill = double.Parse(Console.ReadLine());

            double waterVolume = l * w * h * (1 - fill / 100.0) * 0.001;
            
            Console.WriteLine(waterVolume);
        }
    }
}
