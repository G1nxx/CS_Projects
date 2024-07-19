using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_9_Task_1.Companies;

namespace Lab_9_Task_1.Interfaces
{
    internal interface ISamoTrans
    {
        public SamoTrans CreateSamoTrans(string name, int cost, ICar car);
    }
}
