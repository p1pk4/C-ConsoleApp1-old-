using System;

namespace HomeWork2
{
    /*
    1.Написать метод, возвращающий минимальное из трёх чисел.

    2.Написать метод подсчета количества цифр числа.

    3.Написать метод проверки логина и пароля. Ограничить ввод пароля тремя попытками.
    */
    class Program
    {
        #region MinNumbers
        static void MinNumbers()
        {
            Console.WriteLine("Введите три числа:");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            if (numberOne < numberTwo && numberTwo < numberThree && numberOne < numberThree)
            {
                Console.WriteLine($"Минимальное число: {numberOne}");
            }
            else
            {
                if (numberTwo < numberThree)
                {
                    Console.WriteLine($"Минимальное число: {numberTwo}");
                }
                else
                {
                    Console.WriteLine($"Минимальное число: {numberThree}");
                }
            }
        }
        #endregion

        #region NumberOfDigits
        static void NumberOfDigits()
        {
            Console.WriteLine("Введите число");
            int NumberOfCounting = int.Parse(Console.ReadLine());
            int digitCount = (int)Math.Log10(NumberOfCounting) + 1;
            Console.WriteLine($"Цифр в числе {digitCount}");
        }
        #endregion
        
        #region Login and Password
        static void Login()
        {
                Console.WriteLine("Введите логин: ");
                string l = Console.ReadLine();
                int login = Convert.ToInt32(l);

                if (login == 333)
                {
                    Console.WriteLine("Введите пароль: ");
                    Password();
                }
                else if (login != 333)
                {
                    int countLogin = 3;     //Количество попыток
                    while (countLogin <= 4)
                    {
                        countLogin -= 1;
                        Console.WriteLine($"Неправильный логин, у вас осталось {countLogin} попытки");
                        Console.WriteLine("Повторите ввод: ");
                        Console.ReadLine();
                        if (countLogin == 0)
                        {
                            Console.WriteLine("Вы 3 раза ввели неправильный логин, попробуйте завтра");
                            break;
                        }
                    }
                }
        }
        static void Password()
        {
            string p = Console.ReadLine();
            int password = Convert.ToInt32(p);
            if (password == 123)
            {
                Console.WriteLine("Доступ разрешен!");
            }
            else if (password != 123)
            {
                int countPass = 3;  //Количество попыток
                while (countPass <= 4)
                {
                    countPass -= 1;
                    Console.WriteLine($"Неправильный пароль, у вас осталось {countPass} попытки!");
                    Console.WriteLine("Повторите ввод: ");
                    Console.ReadLine();
                    if (countPass == 1)
                    {
                        Console.WriteLine("Вы 3 раза ввели неправильный пароль, попробуйте завтра ");
                        break;
                    }
                }
            }
        }
        #endregion

        #region Tasks
        static void Task1()
        {
            Console.WriteLine("Вы выбрали задачу #1. Описание задачи внутри кода");
            MinNumbers();
        }
        static void Task2()
        {
            Console.WriteLine("Вы выбрали задачу #2. Описание задачи внутри кода");
            NumberOfDigits();
        }
        static void Task3()
        {
            Console.WriteLine("Вы выбрали задачу #3. Описание задачи внутри кода");
            Login();
        }
        #endregion

        static int Menu()
        {
            Console.WriteLine("1 - Task1");
            Console.WriteLine("2 - Task2");
            Console.WriteLine("3 - Task3");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void Main(string[] args)
        {
            int tasks = Menu();
            
            switch (tasks)
            {
                case 1:
                    {
                        Task1();
                        break;
                    }
                case 2:
                    {
                        Task2();
                        break;
                    }
                case 3:
                    {
                        Task3();
                        break;
                    }
                default:
                    Console.WriteLine("Неправильный номер.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
