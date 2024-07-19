using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    abstract internal class Hostel : PlaceOfResidence
    {
        protected int numberOfRooms;

        protected Hostel(string title, int Price, int NumberOfRooms)
        {
            this.title = title;
            this.Price = Price;
            this.NumberOfRooms = NumberOfRooms;
        }
        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set
            {
                if (value > 0) numberOfRooms = value;
                else throw new ArgumentException("Не может быть меньше 1 номера");
            }
            
        }
    }
}
