using System;

namespace L2
{
    class Program
    {
        static void Task1()
        {

        }

        static void Task2()
        {

        }

        static void Task3()
        {

        }

        static int Menu()
        {
            Console.WriteLine("1 - Task1");
            Console.WriteLine("1 - Task1");
            Console.WriteLine("1 - Task1");

            int m = int.Parse(Console.ReadLine());
            return m;
        }
        static void Main(string[] args)
        {
            int m = Menu();

            switch (m)
            {
                case 1:
                    Task1();
                    break;

                case 2:
                    Task2();
                    break;

                case 3:
                    Task3();
                    break;

                default:
                    Console.WriteLine("Wrong number");
                    break;
            }
        }
    }
}
