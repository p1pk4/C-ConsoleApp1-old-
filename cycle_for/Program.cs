using System;

namespace cycle_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0, g = 100; i < 100 && g > 50; i++, g--)
            {
                Console.WriteLine(i+ " " +g);
            }
            Console.ReadLine();
        }
    }
}
