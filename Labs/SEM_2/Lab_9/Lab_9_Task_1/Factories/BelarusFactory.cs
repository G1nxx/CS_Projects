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
    internal class BelarusFactory : IEMS,IAutoLightExpress,ISamoTrans
    {
        public AutoLightExpress CreateAutoLightExpress(string name, int cost, ICar car)
        {
            return new BelarusAutoLightExpress(name, cost, car);
        }

        public EMS CreateEMS(string name, int cost, ICar car)
        {
            return new BelarusEMS(name, cost, car);
        }

        public SamoTrans CreateSamoTrans(string name, int cost, ICar car)
        {
            return new BelarusSamoTrans(name, cost, car);
        }
    }
}
