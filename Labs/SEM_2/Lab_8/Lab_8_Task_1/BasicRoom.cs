using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_Task_1
{
    internal class BasicRoom
    {
        private int id;
        private int cost;
        private bool isOrdered;
        private double discount;

        public int ID { get { return id; } }
        public int Cost { get { return cost; } set { cost = value; } }
        public bool IsOrdered { get { return isOrdered; } set { isOrdered = value; } }
        public double Discount { get { return discount; } set { discount = value; } }

        public BasicRoom(int id, int cost, IDiscountStrategy discount)
        {
            this.id = id;
            this.cost = cost;
            this.isOrdered = false;
            this.discount = discount.ApplyDiscount();
        }

        public void OrderRoom()
        {
            isOrdered = true;
        }
    }
}
