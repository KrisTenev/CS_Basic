using System;

namespace _03_DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double grp = double.Parse(Console.ReadLine());

            double totamSum = sum + period * ((sum * grp / 100) / 12);
            
            Console.WriteLine(totamSum);
        }
    }
}
