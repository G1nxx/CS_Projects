using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Lab_9_Task_1.Companies;
using Lab_9_Task_1.Interfaces;

namespace Lab_9_Task_1.Factories
{
    internal class MinskFactory : ISamoTrans, IAutoLightExpress, IEMS
    {
        public AutoLightExpress CreateAutoLightExpress(string name, int cost, ICar car)
        {
            return new MinskAutoLightExpress(name, cost, car);
        }

        public EMS CreateEMS(string name, int cost, ICar car)
        {
            return new MinskEMS(name, cost, car);
        }

        public SamoTrans CreateSamoTrans(string name, int cost, ICar car)
        {
            return new MinskSamoTrans(name, cost, car);
        }
    }
}
