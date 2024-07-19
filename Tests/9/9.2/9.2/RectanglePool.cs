using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    internal class RectanglePool : IPool
    {
        public void MakePool(Hotel hotel)
        {
            hotel.FormOfPool = "Прямоугольник";
        }
    }
}
