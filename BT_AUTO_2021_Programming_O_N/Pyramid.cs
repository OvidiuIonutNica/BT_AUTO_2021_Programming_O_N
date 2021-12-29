using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_O_N
{
    class Pyramid
    {
        //Pyramid V= (1/3)*(A*A)*h
        public static void VolumePyramid()
        {
            var A_length = 2;
            var A_width = 5;
            var A = A_length * A_width; //prima metoda
            var h = 50;

            var vol = 1 / 3.0 * A * h; //prima metoda
            var vol2 = 1 / 3.0 * (A_length * A_width) * h; // a doua metoda

            Console.WriteLine("Volume of Pyramid with first method = " + vol);
            Console.WriteLine("Volume of Pyramid with second method = " + vol2);

        }
    }
}
