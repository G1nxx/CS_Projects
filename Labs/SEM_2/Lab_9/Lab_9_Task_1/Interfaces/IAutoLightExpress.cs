using Lab_9_Task_1.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Task_1.Interfaces
{
    internal interface IAutoLightExpress
    {
        public AutoLightExpress CreateAutoLightExpress(string name, int cost, ICar car);
    }
}
