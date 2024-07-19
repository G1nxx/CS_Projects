namespace Lab_3_Task_3
{
    internal class Program
    {
        static void Main(string[] argsm)
        {
            int menuChecker = 1;

            bool firstCheck = true;

            while (menuChecker == 1)
            {

                Console.WriteLine("Выберете:");
                if (firstCheck)
                {
                    Console.WriteLine("1) Начать");
                    firstCheck = false;
                }
                else
                {
                    Console.WriteLine("1) Продолжить");
                }
                Console.WriteLine("2) Закончить");

                while (!Int32.TryParse(Console.ReadLine(), out menuChecker) || (menuChecker != 1 && menuChecker != 2)) { Console.WriteLine("Введите значение ещё раз"); }
                switch (menuChecker)
                {
                    case 1:

                        int choosingFunction;
                        Console.WriteLine("Выберете:");
                        Console.WriteLine("1) Узнать день недели");
                        Console.WriteLine("2) Узнать разницу в днях с сегодняшним днём");

                        while (!Int32.TryParse(Console.ReadLine(), out choosingFunction) || (choosingFunction != 1 && choosingFunction != 2)) { Console.WriteLine("Введите значение ещё раз"); }
                        DateOnly date;
                        switch (choosingFunction)
                        {
                            case 1:
                                Console.WriteLine("Введите дату анализа дня недели");
                                while (!(DateOnly.TryParse(Console.ReadLine(), out date))) { Console.WriteLine("Вы ввели некоректное значение. Повторите попытку."); }
                                Console.WriteLine("В этот день был " + DateService.GetDay(date));
                                break;
                            case 2:
                                Console.WriteLine("Введите дату для нахождения разницы с сегодняшним днём в днях");
                                while (!(DateOnly.TryParse(Console.ReadLine(), out date))) { Console.WriteLine("Вы ввели некоректное значение. Повторите попытку."); }
                                int difference = DateService.GetDaySpan(date);
                                if (difference < 0)
                                {
                                    difference = -difference;
                                    Console.Write("Данный день будет {0} ", difference);
                                    DateService.PrintDays(difference);
                                    Console.WriteLine(" назад");
                                }
                                else if (difference > 0)
                                {
                                    Console.Write("Данный день будет через {0} ", difference);
                                    DateService.PrintDays(difference);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.Write("Вы ввели сегодняшний день");
                                }
                                break;
                        }
                        break;
                    case 2:

                        Console.WriteLine("Завершение работы");

                        break;
                }
            }
        }
    }
}
