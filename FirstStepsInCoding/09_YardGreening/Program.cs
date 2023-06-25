using System;

namespace _09_YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yardArea = double.Parse(Console.ReadLine());
            double price = yardArea * 7.61;
            double totalPrice = price * 0.82;
            double discount = price - price * (1 - 0.18);

            Console.WriteLine($"The final price is: {totalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
