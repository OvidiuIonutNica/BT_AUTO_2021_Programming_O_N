using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BT_AUTO_2021_Programming_O_N
{
    internal class Room
    {
        double roomArea;
        int roomCapacity;
        string[] roomAccessories;
        string roomType;
        

        public Room(double aRoomArea, int aRoomCapacity, string[] aRoomAccessories)
        {
            roomArea = aRoomArea;
            roomCapacity = aRoomCapacity;
            roomAccessories = aRoomAccessories.ToArray();
            roomType = GetRoomType();


        }

        public void SetRoomType()
        {
            Console.WriteLine("You can chose one of the following room types: A. MeetingRoom B. Kitchen C. WorkingSpace D. DepositSpace");
            roomType = Console.ReadLine();
            if (roomType == "A")
            {
                this.roomType = "MeetingRoom";
            }
            else if (roomType == "B")
            {
                this.roomType = "Kitchen";
            }
            else if (roomType == "C")
            {
                this.roomType = "WorkingSpace";
            }
            else if (roomType == "D")
            {
                this.roomType = "DepositSpace";
            }

        }

        public string [] SetRoomAccessories()
        {
            int roomAccessories = Int32.Parse(Console.ReadLine());
            int[] array = new int[roomAccessories];
            string[] accessoriesArray;
            return accessoriesArray;

        }
        public void SetRoomArea(double aRoomArea)
        {
            this.roomArea = aRoomArea;
        }

        public string GetRoomType()
        {
            return this.roomType;

        }

        public double GetArea()
        {
            return this.roomArea;
        }
    }
}
