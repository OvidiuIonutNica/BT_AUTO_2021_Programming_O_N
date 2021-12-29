using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_O_N
{
    class Cylinder
    {
        //Cylinder V= π(r*r)h
        public static void VolumeCylinder()
        {
            var r = 3;
            var h = 10;

            var vol = Math.PI * Math.Pow(r, 2) * h;

            Console.WriteLine("Volume of Cilinder = " + vol);
        }
    }
}
