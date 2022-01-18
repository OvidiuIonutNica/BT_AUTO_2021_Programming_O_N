using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_O_N
{
    public abstract class AbstractBuilding : IBuilding
    {
        public abstract int ComputingArea();

        public abstract int GetNumberOfFloors();

        public abstract int GetTotalNumberOfRooms();

        public abstract int TotalCapacity();


    }
}
