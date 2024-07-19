using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_Task_1
{
    internal class Hotel
    {
        private List<BasicRoom> basicRooms;

        public Hotel()
        {
            basicRooms = new List<BasicRoom>();
            for (int i = 0; i < 21; i++)
            {
                IDiscountStrategy strategy;
                if (i < 11)
                {
                    strategy = new NoDiscount();
                }
                else if (i < 16)
                {
                    strategy = new BasicDiscount();
                }
                else
                {
                    strategy = new HugeDiscount();
                }
                basicRooms.Add(new BasicRoom(i, 300 + 30 * i, strategy));
            }
        }

        public bool OrderRoom(int id)
        {
            if (id <= basicRooms.Count && id > 0)
            {
                basicRooms[id - 1].OrderRoom();
                return true;
            }
            else { return false; }
        }

        public double GetMoney()
        {
            double money = 0;
            for (int i = 0; i < basicRooms.Count; i++)
            {
                if (basicRooms[i].IsOrdered)
                {
                    money += basicRooms[i].Cost * (1 - basicRooms[i].Discount);
                }
            }
            return money;
        }
    }
}
