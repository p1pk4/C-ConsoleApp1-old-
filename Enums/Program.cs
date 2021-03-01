using System;

namespace Enums
{
    class Program
    {
        enum Days
        {
            Monday = 10,
            Tuesday = 6, 
            Wednesday = 123, 
            Thursday = 444, 
            Friday = 0, 
            Saturday = 9, 
            Sunday
        }
        static Days CurrentDay()
        {
            return Days.Friday;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }
}
