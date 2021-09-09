using System;

namespace ConsoleMenuExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstMenu();
        }

        private static void Exit()
            => Environment.Exit(0);

        private static void FirstMenu()
        {
            while (true)
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
                        break;
                    case "2":
                        ThirdMenu();
                        break;
                    case "3":
                        Exit();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void SecondMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Второе меню:");
                Console.WriteLine("1) В главное меню");
                Console.WriteLine("2) В меню 3");
                Console.Write("\r\nВыберите действие: ");

                var answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        FirstMenu();
                        break;
                    case "2":
                        ThirdMenu();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ThirdMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Третье меню:");
                Console.WriteLine("1) В главное меню");
                Console.WriteLine("2) Выход");
                Console.Write("\r\nВыберите действие: ");

                var answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        FirstMenu();
                        break;
                    case "2":
                        Exit();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}