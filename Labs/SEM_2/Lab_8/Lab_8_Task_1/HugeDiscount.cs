using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_Task_1
{
    internal class HugeDiscount : IDiscountStrategy
    {
        public double ApplyDiscount()
        {
            return 0.30;
        }
    }
}
