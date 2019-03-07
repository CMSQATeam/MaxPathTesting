using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.PrintNumber(0);
            Console.ReadKey();
        }

        void PrintNumber(int num)
        {
            Console.WriteLine(num);
            if (num < 100)
            {
                PrintNumber(num + 1);
            }
        }
    }
}
