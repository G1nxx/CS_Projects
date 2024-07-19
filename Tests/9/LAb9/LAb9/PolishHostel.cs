using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
	internal class PolishHostel: Hostel
	{
        public PolishHostel(string title, int Price, int NumberOfRooms) : base(title, Price, NumberOfRooms) { }

        public override void ShowInformation()
		{
            Console.WriteLine($"Тип - Польский хостел\n Название - {title}\n Цена  - {Price}\n Количество номеров  - {NumberOfRooms}");
        }
    }
}
