using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Task_1
{
    abstract internal class Sport
    {
        public Sport() 
        {
            Console.WriteLine("Sport Begins");
        }
        abstract public void DoSport();
        public void Information()
        {
            Console.WriteLine("This Is Sport");
        }
    }
}
