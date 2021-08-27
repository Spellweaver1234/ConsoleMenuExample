using System;

namespace ConsoleMenuExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Главное меню:");
            Console.WriteLine("1) В меню 2");
            Console.WriteLine("2) В меню 3");
            Console.WriteLine("3) Выход");
            Console.Write("\r\nВыберите действие: ");

            var answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    SecondMenu();
                    return true;
                case "2":
                    ThirdMenu();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void SecondMenu()
        {
            Console.Clear();
            Console.WriteLine("Второе меню:");
            Console.WriteLine("4) В меню 4");
            Console.WriteLine("5) В меню 5");
            Console.WriteLine("0) В главное меню");
            Console.Write("\r\nВыберите действие: ");

            var answer = Console.ReadLine();

            switch (answer)
            {
                case "4":
                    FourthMenu();
                    break;
                case "5":
                    FifthMenu();
                    break;
                case "0":
                    MainMenu();
                    break;
                default:
                    SecondMenu();
                    break;
            }
        }

        private static void FifthMenu()
        {
            Console.Clear();
            Console.WriteLine("Пятое меню:");
        }

        private static void FourthMenu()
        {
            Console.Clear();
            Console.WriteLine("Четвёртое меню:");
        }

        private static void ThirdMenu()
        {
            Console.Clear();
            Console.WriteLine("Третье меню:");
            Console.WriteLine("1) Выполнить действие");
            Console.WriteLine("2) В главное меню");
            Console.Write("\r\nВыберите действие: ");

            var answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    DoAction();
                    break;
                case "2":
                    MainMenu();
                    break;
                default:
                    ThirdMenu();
                    break;
            }
        }

        private static void DoAction()
        {
            Console.Clear();
            Console.WriteLine("Действие выполнено!");
        }
    }
}