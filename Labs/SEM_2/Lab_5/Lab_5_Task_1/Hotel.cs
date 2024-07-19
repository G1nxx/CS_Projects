using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Task_1
{
    internal class Hotel
    {
        private List<Room> rooms;
        public Hotel()
        {
            rooms = new List<Room>();
            for (int i = 0; i < 21; i++)
            {
                rooms.Add(new Room(i + 1, IsOrdered.free, 400));
            }
        }

        public bool CheckIntoTheHotel(int iD, string name)
        {
            if (rooms.Count < iD) { return false; }
            if (this.rooms[iD - 1].GetIsOrdered() == IsOrdered.ordered) { return false; }
            this.rooms[iD - 1].CheckIntoRoom();
            this.rooms[iD - 1].SetGuestName(name);
            return true;
        }

        public int GetCountOfRooms() { return rooms.Count; }
        public int GetCountOfOrderedRooms()
        {
            int countOfOrdered = 0;
            foreach (Room room in rooms)
            {
                if (room.GetIsOrdered() == IsOrdered.ordered) { countOfOrdered++; }

            }
            return countOfOrdered;
        }
    }
}
