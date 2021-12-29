using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_O_N
{
    class Sphere
    {
        //Sphere  V = 4/3 πr³
        public static void VolumeSphere()
        {
            var r = 28;
            var vol = 4 / 3.0 * Math.PI * Math.Pow(r, 3);

            Console.WriteLine("Volume of Sphere = " + vol);
        }
    }
}
