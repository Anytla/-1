﻿using System;

namespace _321
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.Write("MAX = ");

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }

            if (b > a && b > c)
            {
                Console.WriteLine(b);
            }

            else
            {
                Console.WriteLine(c);
            }
        }
    }
}