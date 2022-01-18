using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_O_N
{
    public interface IBuilding
    {

        //This method calculate the building's area Area = L* l
        int ComputingArea();

        int GetNumberOfFloors();

        int GetTotalNumberOfRooms();

        int TotalCapacity();

    }
}
