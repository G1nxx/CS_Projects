using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    internal class PolishFactory : AbstractFactory
    {
        public override Hotel CreateHotel(string title, int Price, int numberOfFloors, bool HasPool)
        {
            var hotel = new PolishHotel(title, Price, numberOfFloors, HasPool);
            return hotel;
        }
        public override Hostel CreateHostel(string title, int Price, int NumberOfRooms)
        {
            var hostel = new PolishHostel(title, Price, NumberOfRooms);
            return hostel;
        }
        public override Farmstead CreateFarmstead(string title, int Price, double DistanceToCity)
        {
            var farmstead = new PolishFarmstead(title, Price, DistanceToCity);
            return farmstead;
        }
    }
}
