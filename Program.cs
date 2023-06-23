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
                Console.Write(
                    $"Первое меню: " +
                    $"\n 1 - В меню 2" +
                    $"\n 2 - В меню 3" +
                    $"\n 3 - Выход" +
                    $"\nВыберите действие: ");

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
                Console.Write(
                    $"Второе меню: " +
                    $"\n 1 - В главное меню" +      
                    $"\n 2 - В меню 3" +
                    $"\nВыберите действие: ");      

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
                Console.Write(
                    $"Третье меню: " +
                    $"\n 1 - В главное меню" +
                    $"\n 2 - Выход" +
                    $"\nВыберите действие: ");

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