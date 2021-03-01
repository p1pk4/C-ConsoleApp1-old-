using System;

namespace Obmen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число №1: ");
            double n1;
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Число №1 равно {n1}");

            Console.WriteLine("Введите число №2: ");
            double n2;
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Число №2 равно {n2}");

            Console.WriteLine();

            double temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine($"Число №1 после обмена: {n1}");
            Console.WriteLine($"Число №2 после обмена: {n2}");
            Console.ReadLine();
        }
    }
}
