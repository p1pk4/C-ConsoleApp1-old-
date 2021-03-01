using System;

namespace cycle_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(++i);
            }
            Console.ReadLine();
        }
    }
}
