using System;

namespace _12
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int area;

            area = ((a + b) / 2) * h;

            Console.WriteLine(area);

        }
    }
}
