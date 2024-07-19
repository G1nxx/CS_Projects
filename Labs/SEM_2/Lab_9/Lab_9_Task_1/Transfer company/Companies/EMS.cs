using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_9_Task_1.Interfaces;

namespace Lab_9_Task_1.Companies
{
    abstract internal class EMS : TransferCompany
    {
        public void Careful()
        {
            Console.WriteLine("Аккуратная доставка");
        }
        protected EMS(string name, int cost, ICar car)
        {
            Name = name;
            Cost = cost;
            car.SetCar(this);
        }
        public override void GetInfo()
        {
            Console.WriteLine("Я EMS");
        }
    }
}
