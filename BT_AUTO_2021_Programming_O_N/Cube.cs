using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_O_N
{
    class Cube
    {
        //Cube = V = L³
        public static void VolumeCube()
        {
            var L = 50;
            var vol = Math.Pow(L, 3);

            Console.WriteLine("Volume of Cube = " + vol);
        }
    }
}
