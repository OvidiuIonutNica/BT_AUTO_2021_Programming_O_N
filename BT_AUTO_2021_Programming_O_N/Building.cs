using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_O_N
{
    public class Building : AbstractBuilding
    {
        public int floors, rooms;
        int MAX_CAPACITY = 300;
         public Building(int aFloors, int aRooms)
        {
            floors = aFloors;
            rooms = aRooms;
        }

        public override int ComputingArea()
        {
            //int length, width;
            // double area;
            return 0;
        }

        public override int GetNumberOfFloors()
        {
            return this.floors;
        }

        public override int GetTotalNumberOfRooms()
        {
            return this.rooms;
        }

        public override int TotalCapacity()
        {
            return 0;
        }
    }
}
