using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_9_Task_1.Companies;
using Lab_9_Task_1.Interfaces;

namespace Lab_9_Task_1
{
    internal class WorldEMS : EMS
    {
        public WorldEMS(string name, int cost, ICar car) : base(name, cost, car) { }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Я доставляю товары по Миру");
        }
    }
}
