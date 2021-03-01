using System;

/*
 Задача: Контроль домофона и лифта.

    Блок 1:
    Человек вводит пароль от домофона, если ввёл правильно, то дверь в подъезд открывается,
    иначе его прогоняет консъержка.

    Блок 2:
    Человек заходит в лифт и указывает свой вес и возраст. 
    Если вес больше 69 то он может ехать только на этажи 1-5, иначе на минусовые и 1-10.
    Если возраст возраст меньше 50, то ему советуют подрасти.
 */

namespace Task1Ava
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы подошли к подъезду и видите домофон, на некоторых цифрах есть потёртости");
            Console.WriteLine("Введите код: ");

            string a = Console.ReadLine();  //Ввод пароля от домофона
            int password = Convert.ToInt32(a);

            bool enter = false; //Вошёл человек в подъезд или нет

            if (password == 123)
            {
                Console.WriteLine("Дверь домофона открылась");
                enter = true;   //Человека пустили в подъезд
                //Элеватор запихнуть сюда возможно
            }
            else if (password != 123)
            {
                int count = 3;  //Количество попыток
                while (count <= 4)
                {
                    count -= 1;
                    Console.WriteLine($"Неправильный код, у вас осталось {count} попытки!");
                    Console.WriteLine("Повторите ввод: ");
                    Console.ReadLine();
                    if (count == 1)
                    {
                        Console.WriteLine("Консъержка увидела что кто-то ломится в дверь и прогнала вас");
                        break;
                    }
                }
            }
            if (enter == true)
            {
                Elevator();
            }
            Pause();
        }
        static void Elevator()
        {
            bool basement = false;  //Доступность кнопок лифта на минусовые этажи

            Console.WriteLine("Вы зашли в лифт");
            Console.WriteLine("Из динамиков доносится женский голос...");

            Console.WriteLine("Введите ваш возраст");
            string b = Console.ReadLine();    //Возраст человека
            int age = Convert.ToInt32(b);

            Console.WriteLine("Введите ваш вес");
            string с = Console.ReadLine(); //Вес человека
            int weight = Convert.ToInt32(с);

            Console.WriteLine($"Женский голос произносит: Отлично, ваш вес {weight}, а возраст {age}, ну ясно..");
            //Console.WriteLine("Женский голос задаёт вопрос: На какой этаж отправитесь?");
            //string floor = Console.ReadLine();
            //int g = Convert.ToInt32(floor);
            if (age >= 50 && weight <= 69)    //Возраст человека больше или равно 50 И вес меньше 69
            {
                basement = true; //Доступен подвал
                Console.WriteLine("Вы можете поехать на минусовые этажи и на этажи от 1 до 10");
                string h = Console.ReadLine();  //Выбор этажа
                int takeFloorWithBasment = Convert.ToInt32(h);
                Console.WriteLine($"Вы прибыли на этаж {takeFloorWithBasment}, добро пожаловать в Umbrella +_+!");
            }
            else if (age >= 50 && weight > 69)  //Возраст человека 50 или больше И вес больше 69 
            {
                Console.WriteLine("Вы можете поехать только вверх, на этажи 1-5");
                string f = Console.ReadLine();  //Выбор этажа
                int takeFloor = Convert.ToInt32(f);
                Console.WriteLine($"Вы прибыли на этаж {takeFloor}, добро пожаловать!");
            }
            else if (age < 50)
            {
                Console.WriteLine("Ты еще слишком мал для поездок на лифте, подрасти!");
            }
            Pause();
        }

        static void Pause()
        {
            Console.ReadLine();
        }
    }
}