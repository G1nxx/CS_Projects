using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    abstract internal class PlaceOfResidence
    {
        public string title {  get; set; }

        public void ShowMessage()
        {
            Console.WriteLine("Во мне можно жить");
        }
        public abstract void ShowInformation();

        int price;

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Цена не может быть отриательной");
                }
            }
        }
    }
}
