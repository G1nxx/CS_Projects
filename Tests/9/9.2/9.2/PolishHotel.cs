using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    internal class PolishHotel : Hotel
    {
        public PolishHotel(string title, int Price, int numberOfFloors, bool HasPool)
        {
            this.title = title;
            this.Price = Price;
            this.NumberOfFloors = numberOfFloors;
            this.HasPool = HasPool;
        }
        public override void ShowInformation()
        {
            Console.WriteLine($"Тип - Польский отель\nНазвание - {title}\nЦена  - {Price}\nКоличество этажей  - {numberOfFloors}\n{(HasPool ? "Бассейн есть" : "Бассейнена  нет")}\nФорма бассейна - {FormOfPool}");
        }
    }
}
