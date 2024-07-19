using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    internal class TokioFarmstead : Farmstead
    {
        public TokioFarmstead(string title, int Price, double DistanceToCity) : base(title, Price, DistanceToCity) { }

        public override void ShowInformation()
        {
            Console.WriteLine($"Тип - Токийская агроусадьба\n Название - {title}\n Цена  - {Price}\n Расстояние до города  - {DistanceToCity}");
        }
    }
}
