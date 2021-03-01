using System;

namespace Switch
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Вы выбрали задачу под номером 1");
        }
        static void Task2()
        {
            Console.WriteLine("Вы выбрали задачу под номером 2");
        }
        static int Menu()
        {
            Console.WriteLine("1 - Task1");
            Console.WriteLine("2 - Task1");
            int m = int.Parse(Console.ReadLine());
            return m;
        }
        static void Main(string[] args)
        {
            int f = Menu();

            switch(f) 
            {
                #region Case1
                case 1:
                    {
                        Task1();
                        break;
                    }
                #endregion
                case 2:
                    {
                        Task2();
                        break;
                    }
                default:
                    Console.WriteLine("Wrong number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
