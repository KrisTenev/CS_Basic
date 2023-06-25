using System;

namespace _07_ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string archName = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());
            int hours = projectCount * 3;
            Console.WriteLine($"The architect {archName} will need {hours} hours to complete {projectCount} project/s.");
        }
    }
}
