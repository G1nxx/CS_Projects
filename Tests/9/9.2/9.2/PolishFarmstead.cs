using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    internal class PolishFarmstead : Farmstead
    {
        public PolishFarmstead(string title, int Price, double DistanceToCity):base(title, Price, DistanceToCity) { }

        public override void ShowInformation()
        {
            Console.WriteLine($"Тип - Польская  агроусадьба\nНазвание - {title}\nЦена  - {Price}\nРасстояние до города  - {DistanceToCity}");
        }
    }
}
