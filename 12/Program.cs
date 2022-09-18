using System;

namespace _12121222
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result;

            if ((n > 20) && (n % (10) == 1))
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
