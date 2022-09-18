using System;

namespace _123
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double lastDigit;

            lastDigit = n % (10);

            Console.WriteLine(lastDigit);

        }
    }
}
