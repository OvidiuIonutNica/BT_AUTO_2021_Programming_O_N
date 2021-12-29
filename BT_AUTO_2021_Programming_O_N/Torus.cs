using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_O_N
{
    class Torus

    {
        //Torus V = π × r2 × 2 × π × R
        public static void VolumeTorus()
        {
            var r = 3;
            var R = 10;

            var vol = Math.PI * Math.Pow(r, 2) * 2 * Math.PI * R;

            Console.WriteLine("Volume of Torus = " + vol);
        }
    }
}
