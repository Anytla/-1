using System;

namespace _171717
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            if (fact == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    fact *= i;

                }
                Console.WriteLine(fact);
            }
        }
    }
}
