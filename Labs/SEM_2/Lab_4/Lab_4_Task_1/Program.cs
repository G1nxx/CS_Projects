using System.Dynamic;
using System.Security.Cryptography;

namespace Lab_4_Task_1
{
    internal class Program
    {
        private static void Main()
        {
            int menuChecker;

            Console.WriteLine("Выберете:");

            Console.WriteLine("1) Начать");

            Console.WriteLine("2) Закончить");

            while (!int.TryParse(Console.ReadLine(), out menuChecker) || (menuChecker != 1 && menuChecker != 2))
            {
                Console.WriteLine("Введите значение ещё раз");
            }

            while (menuChecker != 3)
            {
                var hotel = Hotel.GetInstance();
                switch (menuChecker)
                {
                    case 1:
                        int choosingFunction;
                        Console.WriteLine("Выберете:");
                        Console.WriteLine("1) Узнать название гостиницы");
                        Console.WriteLine("2) Узнать максимальное колличество мест");
                        Console.WriteLine("3) Узнать колличество занятых мест");
                        Console.WriteLine("4) Заселить несколько человек");
                        Console.WriteLine("5) Узнать нынешний тариф ");
                        Console.WriteLine("6) Задать тариф");
                        Console.WriteLine("7) Увиличить тариф");
                        Console.WriteLine("8) Уменьшить тариф");
                        Console.WriteLine("9) Узнать прибыль за день");
                        Console.WriteLine("10) Завершить работу");

                        while (!int.TryParse(Console.ReadLine(), out choosingFunction) ||
                               (choosingFunction < 1 || choosingFunction > 10))
                        {
                            Console.WriteLine("Введите значение ещё раз");
                        }

                        switch (choosingFunction)
                        {
                            case 1:
                                Console.WriteLine("Имя отеля:");
                                Console.WriteLine(hotel.GetName());
                                break;
                            case 2:
                                Console.WriteLine("Максимальное колличество мест:");
                                Console.WriteLine(hotel.GetMaxNumberOfPlaces());
                                break;
                            case 3:
                                Console.WriteLine("Колличество мест, занятых на данный момент:");
                                Console.WriteLine(hotel.GetNumberOfBusyPlaces());
                                break;
                            case 4:
                                int people;
                                Console.WriteLine("Введите колличество заселяемых");
                                while (!int.TryParse(Console.ReadLine(), out people))
                                {
                                    Console.WriteLine("Введите значение ещё раз");
                                }

                                Console.WriteLine(hotel.Populate(people)
                                    ? "Заселение прошло успешно!"
                                    : "Нет достатчного колличества мест");
                                break;
                            case 5:
                                Console.WriteLine("Нынешний тариф:");
                                Console.WriteLine(hotel.GetTariff());
                                break;
                            case 6:
                                int newTariff;
                                Console.WriteLine("Введите новый тариф");
                                while (!int.TryParse(Console.ReadLine(), out newTariff))
                                {
                                    Console.WriteLine("Введите значение ещё раз");
                                }

                                hotel.SetTariff(newTariff);
                                break;
                            case 7:
                                Console.WriteLine("Тариф был увеличен на 10");
                                hotel.IncreaseTariff();
                                break;
                            case 8:
                                Console.WriteLine("Тариф был уменьшен на 10");
                                hotel.DiminishTariff();
                                break;
                            case 9:
                                Console.WriteLine("Прибыль в день с текущим колличеством жильцов и нынешним тарифом:");
                                Console.WriteLine(hotel.GetRevenue());
                                break;
                            case 10:
                                menuChecker = 2;
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Завершение работы");
                        menuChecker = 3;
                        break;
                }
            }
        }
    }
}