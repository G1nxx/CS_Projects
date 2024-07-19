namespace Lab_2_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 zapros = 1;

            Boolean first = true;

            while (zapros == 1)
            {

                Console.WriteLine("Выберете:");
                if (first)
                {
                    Console.WriteLine("1) Начать");
                    first = false;
                }
                else
                {
                    Console.WriteLine("1) Продолжить");
                }
                Console.WriteLine("2) Закончить");

                while (!Int32.TryParse(Console.ReadLine(), out zapros) || (zapros != 1 && zapros != 2)) { Console.WriteLine("Введите значение ещё раз"); }
                switch (zapros)
                {
                    case 1:
                        Double xCoordinate,
                               yCoordinate;

                        Console.WriteLine("Введите значение координаты x");
                        while (!Double.TryParse(Console.ReadLine(), out xCoordinate)) { Console.WriteLine("Введите значение ещё раз"); }

                        Console.WriteLine("Введите значение коордираты y");
                        while (!Double.TryParse(Console.ReadLine(), out yCoordinate)) { Console.WriteLine("Введите значение ещё раз"); }

                        if ((Math.Pow(xCoordinate, 2) + Math.Pow(yCoordinate, 2) < 81) && xCoordinate > 0) { Console.WriteLine("Да, лежит внутри"); }
                        else if (((Math.Pow(xCoordinate, 2) + Math.Pow(yCoordinate, 2) == 81) && xCoordinate >= 0) || (xCoordinate == 0 && (Math.Abs(yCoordinate) <= 3))) { Console.WriteLine("Лежит на границе"); }
                        else if ((Math.Pow(xCoordinate, 2) + Math.Pow(yCoordinate, 2) >  81) || xCoordinate < 0) { Console.WriteLine("Нет, лежит снаружи"); }

                        break;
                    case 2:

                        Console.WriteLine("Завершение работы");

                        break;
                }
            }
        }
    }
}
