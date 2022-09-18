using System;

namespace _1234
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double nDigit = double.Parse(Console.ReadLine());

            nDigit = (number / 10 ^ (n - 1)) * mod(10);

            Console.WriteLine(nDigit);
        }
    }
}
