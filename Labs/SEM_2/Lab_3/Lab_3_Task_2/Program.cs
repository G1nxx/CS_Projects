namespace Lab_3_Task_2
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
                        double a;
                        double b;
                        double z;

                        Console.WriteLine("Введите значение переменной a");
                        while (!(double.TryParse(Console.ReadLine(), out a))) { Console.WriteLine("Вы ввели некоректное значение. Повторите попытку."); }

                        Console.WriteLine("Введите значение переменной b");
                        while (!(double.TryParse(Console.ReadLine(), out b))) { Console.WriteLine("Вы ввели некоректное значение. Повторите попытку."); }

                        Console.WriteLine("Введите значение переменной z");
                        while (!(double.TryParse(Console.ReadLine(), out z))) { Console.WriteLine("Вы ввели некоректное значение. Повторите попытку."); }

                        Tuple<double, bool> tuple = Services.MyMath.GetValue(a, b, z);
                        Console.WriteLine("Значение y = " + tuple.Item1);
                        bool branchCheck = tuple.Item2;
                        if (branchCheck)
                        {
                            Console.WriteLine("Случай z >= a * b");
                        }
                        else
                        {
                            Console.WriteLine("Случай z <= a * b");
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
