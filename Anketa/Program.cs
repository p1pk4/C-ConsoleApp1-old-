using System;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилию: ");
            string sname = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст: ");
            string age = Console.ReadLine();
            Console.WriteLine("Введите Ваш рост: ");
            string tall = Console.ReadLine();
            Console.WriteLine("Введите Ваш вес: ");
            string weight = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Склеивание: \nИмя " + name + ". Фамилия " + sname + ". Возраст " + age + ". Рост " + tall + ". Вес " + weight + ".");
            Console.WriteLine("\nФорматирование: \nИмя {0}. Фамилия {1}. Возраст {2}. Рост {3}. Вес {4}.", name, sname, age, tall, weight);
            Console.WriteLine($"\nИнтерполяция: \nИмя {name}. Фамилия {sname}. Возраст {age}. Рост {tall}. Вес {weight}.");
        }
    }
}
