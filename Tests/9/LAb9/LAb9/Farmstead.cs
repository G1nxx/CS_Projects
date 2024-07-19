using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    abstract internal class Farmstead: PlaceOfResidence
    {
        protected double distanceToCity;

        protected Farmstead(string title, int Price, double DistanceToCity)
        {
            this.title = title;
            this.Price = Price;
            this.DistanceToCity = DistanceToCity;
        }
        public double DistanceToCity
        {
            get { return distanceToCity; }
            set
            {
                if (value > 0) distanceToCity = value;
                else throw new Exception("Агроусадьба в городе??");
            }
        }
    }
}
