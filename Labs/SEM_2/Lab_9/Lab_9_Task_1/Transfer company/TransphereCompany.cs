using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Task_1
{
    abstract internal class TransferCompany
    {
        private string name;

        private int cost;

        private string typeOfCar;

        public string TypeOfCar { get { return typeOfCar; } set { typeOfCar = value; } }

        public int Cost
        {
            get { return cost; }

            set
            {
                if (value < 10) { cost = 10; }
                else { cost = value; }
            }
        }

        public string Name { get { return name; } set {  name = value; } }

        public void ShowMessage()
        {
            Console.WriteLine("Я компания по перевозке товаров");
        }

        public abstract void GetInfo();
    }
}
