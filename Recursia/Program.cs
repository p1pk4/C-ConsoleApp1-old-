using System;

namespace Recursia
{
    class Program
    {
        static void Count(int i)
        {
            Console.WriteLine(i);
            Count(i + 1);
        }
        static void Main(string[] args)
        {
            Count(-10);
            Console.ReadKey();
        }
    }
}
