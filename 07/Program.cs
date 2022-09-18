using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] AS;
            int count;
            string s;


            Console.Write("count = ");
            count = Int32.Parse(Console.ReadLine());


            AS = new string[count];


            Console.WriteLine("Enter text:");
            for (int i = 0; i < AS.Length; i++)
            {
                Console.WriteLine();
                AS[i] = Console.ReadLine();
            }

        }
    }
}
