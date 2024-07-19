using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    abstract internal class Hotel: PlaceOfResidence
    {
        public IPool ipool { get; set; }
        public bool HasPool { get; set; }
        public string FormOfPool;
        protected int numberOfFloors;

        public void CreatePool()
        {
            HasPool = true;
            ipool.MakePool(this);
        }

        public int NumberOfFloors
        {
            get
            {
                return numberOfFloors;
            }
            set
            {
                if (value > 0)
                {
                    numberOfFloors = value;
                }
                else
                {
                    throw new Exception("Количество этажей не может быть меньше 1");
                }
            }
        }


    }
}
