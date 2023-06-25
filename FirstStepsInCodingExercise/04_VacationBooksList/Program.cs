using System;

namespace _04_VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double hours = (bookPages / pagesPerHour)/days;

            Console.WriteLine(hours);
        }
    }
}
