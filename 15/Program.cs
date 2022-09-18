using System;

namespace _151515
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            int product;

            if ((a % 10 == 0 && b % 10 == 0 && c % 10 == 0) || (a % 10 == 0) || (b % 10 == 0) || (c % 10 == 0))
            {
                Console.WriteLine("Negative");
            }

            else
            {
                Console.WriteLine("Positive");
            }
        }
    }
}
