using Lab_9_Task_1.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Task_1.Interfaces
{
    internal interface IEMS
    {
        public EMS CreateEMS(string name, int cost, ICar car);
    }
}
