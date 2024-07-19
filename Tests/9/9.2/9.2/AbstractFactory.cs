using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    abstract internal class AbstractFactory
    {
        public abstract Hotel CreateHotel(string title, int Price, int numberOfFloors, bool HasPool);
        public abstract Hostel CreateHostel(string title, int Price, int NumberOfRooms);
        public abstract Farmstead CreateFarmstead(string title, int Price, double DistanceToCity);

    }
}
