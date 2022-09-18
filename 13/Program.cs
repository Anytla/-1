using System;

namespace _212121
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result;

            if ((n % (9) == 0) && (n % 11 == 0) && (n % 13 == 0))
            {
                Console.WriteLine(true);
            }

            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
