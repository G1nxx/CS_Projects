using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Task_1
{
    internal class Tariff
    {
        private const int maxValue = 1000;
        private const int minValue = 200;
        private int cost;
        public Tariff() { cost = minValue; }
        public Tariff(int value) 
        {
            if(value < minValue) cost = minValue;
            else if(value > maxValue) cost = maxValue;
            else cost = value;
        }

        public void SetCost(int cost)
        {
            this.cost = cost;
        }
        public int GetCost()
        {
            return this.cost;
        }


    }
}
