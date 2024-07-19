namespace Lab_3_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
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
                        int x;
                        Console.WriteLine("Введите значение переменной x");

                        while (!(int.TryParse(Console.ReadLine(), out x))) { Console.WriteLine("Вы ввели некоректное значение. Повторите попытку."); }
                        Diminisher.TryDiminish(x);

                        Console.WriteLine("Текущее значение = " + x);
                        Console.WriteLine("Обработаное значение = " + Diminisher.TryDiminish(x));

                        break;
                    case 2:

                        Console.WriteLine("Завершение работы");

                        break;
                }
            }
        }
    }
}
