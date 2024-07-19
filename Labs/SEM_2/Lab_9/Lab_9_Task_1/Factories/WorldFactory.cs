using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_9_Task_1.Companies;
using Lab_9_Task_1.Interfaces;

namespace Lab_9_Task_1.Factories
{
    internal class WorldFactory : ISamoTrans, IAutoLightExpress, IEMS
    {
        public AutoLightExpress CreateAutoLightExpress(string name, int cost, ICar car)
        {
            return new WorldAutoLightExpress(name, cost, car);
        }

        public EMS CreateEMS(string name, int cost, ICar car)
        {
            return new WorldEMS(name, cost, car);
        }

        public SamoTrans CreateSamoTrans(string name, int cost, ICar car)
        {
            return new WorldSamoTrans(name, cost, car);
        }
    }
}
