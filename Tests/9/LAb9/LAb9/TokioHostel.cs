using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    internal class TokioHostel: Hostel
    {
        public TokioHostel(string title, int Price, int NumberOfRooms): base(title, Price, NumberOfRooms) { }
        
        public override void ShowInformation()
        {
            Console.WriteLine($"Тип - Токийский хостел\n Название - {title}\n Цена  - {Price}\n Количество номеров  - {NumberOfRooms}");
        }
    }
}
