using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    internal class TokioFactory: AbstractFactory
    {
        public override Hotel CreateHotel(string title, int Price, int numberOfFloors, bool HasPool)
        {
            var hotel = new TokioHotel(title, Price, numberOfFloors, HasPool);
            return hotel;
        }
        public override Hostel CreateHostel(string title, int Price, int NumberOfRooms)
        {
            var hostel = new TokioHostel(title, Price, NumberOfRooms);
            return hostel;
        }
        public override Farmstead CreateFarmstead(string title, int Price, double DistanceToCity)
        {
            var farmstead = new TokioFarmstead(title, Price, DistanceToCity);
            return farmstead;
        }
    }
}
