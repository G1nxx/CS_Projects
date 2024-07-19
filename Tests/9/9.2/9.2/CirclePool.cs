using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    internal class CirclePool: IPool
    {
        public void MakePool(Hotel hotel)
        {
            hotel.FormOfPool = "Круг";
        }

    }
}
