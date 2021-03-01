using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Pause(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост в метрах. Например 1,69");
            double tall = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вес");
            double weight = Double.Parse(Console.ReadLine());
           
            Console.WriteLine();
            double imt = weight / (tall * tall);

            Console.WriteLine($"Индекс массы тела с ростом {tall} и весом {weight} равен {imt}");
            Pause("Press any key");
        }
    }
}
