using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_O_N
{
    class Cylinder
    {
        public static void VC()
        {
            var r = 6;
            var h = 20;

            var vol = Math.PI * Math.Pow(r, 2) * h;

            Console.WriteLine("Volume of cilinder {vol} ");
        }
    }
}
