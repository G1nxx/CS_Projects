using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_3
{
    internal class DateService
    {

        public static string GetDay(DateOnly date)
        {
            return date.DayOfWeek.ToString();
        }

        public static int GetDaySpan(DateOnly date)
        {
            DateOnly dateToday = DateOnly.FromDateTime(DateTime.Now);

            int dayDifference = date.DayNumber - dateToday.DayNumber;

            return dayDifference;
        }
        public static void PrintDays(int numberOfDays)
        {
            if ((numberOfDays % 100 >= 10 && numberOfDays % 100 <= 20) || numberOfDays % 10 == 0 || (numberOfDays % 10 >= 5 && numberOfDays % 10 <= 9))
            {
                Console.Write("дней");
            }
            else
            {
                if (numberOfDays % 10 == 1)
                {
                    Console.Write("день");
                }
                else
                {
                    if (numberOfDays % 10 == 2 || numberOfDays % 10 == 3 || numberOfDays % 10 == 4)
                    {
                        Console.Write("дня");
                    }
                }
            }
        }
    }
}
