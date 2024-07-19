namespace Lab_2_Task_1
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
                if (first) { 
                    Console.WriteLine("1) Начать"); 
                    first = false;
                }
                else {
                    Console.WriteLine("1) Продолжить");
                }
                Console.WriteLine("2) Закончить");

                while (!Int32.TryParse(Console.ReadLine(), out zapros) || (zapros != 1 && zapros != 2)) { Console.WriteLine("Введите значение ещё раз"); }
                switch (zapros)
                {
                    case 1:

                        Int32 M,
                              N;

                        Console.WriteLine("Введите значение M");
                        while (!Int32.TryParse(Console.ReadLine(), out M)) { Console.WriteLine("Введите значение ещё раз"); }
                        Console.WriteLine("Введите значение N");
                        while (!Int32.TryParse(Console.ReadLine(), out N) || N == 0) { Console.WriteLine("Введите значение ещё раз"); }

                        Int32 ostatok = M % N;
                        Int32 chastnoe = M / N;

                        if (ostatok != 0) { Console.WriteLine("M на N не делится на цело"); }
                        else { Console.WriteLine("Частное = " + chastnoe); }

                        break;
                    case 2:

                        Console.WriteLine("Завершение работы");

                        break;
                }
            }
        }
    }
}
