using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum IsOrdered
{
    free,
    ordered
}

namespace Lab_5_Task_1
{
    internal class Room
    {
        private int iD;
        private IsOrdered isOrdered;
        private Tariff tariff;
        private string guestName;
        public Room(int iD, IsOrdered isOrdered, int tariff)
        {
            this.tariff = new Tariff(tariff);
            this.iD = iD;
            this.isOrdered = isOrdered;
            guestName = "Empty";
        }
        public int GetID() { return this.iD; }
        private void SetIsOrdered(IsOrdered isOrdered) { this.isOrdered = isOrdered; }
        public IsOrdered GetIsOrdered() { return this.isOrdered; }
        public void SetTariff(int tariff) { this.tariff.SetCost(tariff); }
        public int GetTariff() { return this.tariff.GetCost(); }
        public void SetGuestName(string name) { this.guestName = name; }
        public string GetGuestName() { return this.guestName; }

        public void CheckIntoRoom() { this.SetIsOrdered(IsOrdered.ordered); }
    }
}
