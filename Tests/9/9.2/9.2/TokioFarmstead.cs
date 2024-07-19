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
            Console.WriteLine($"Тип - Токийская агроусадьба\nНазвание - {title}\nЦена  - {Price}\nРасстояние до города  - {DistanceToCity}");
        }
    }
}
