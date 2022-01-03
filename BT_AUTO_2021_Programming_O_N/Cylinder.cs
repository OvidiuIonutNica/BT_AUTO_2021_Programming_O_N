using BT_AUTO_2021_PRogramming;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_O_N
{
    class Cylinder : Shape
    {
        //Cylinder V= π(r*r)h
        double r;
        private double h;

        public Cylinder(double r)
        {
            this.r = r;
        }

        public Cylinder()
        {
            this.r = 0;
        }

        public void SetRadius(double r)
        {
            this.r = r;
        }

        public double GetVolume()
        {
            return Math.PI * Math.Pow(r, 2) * h;
        }

        public void PrintCylinder()
        {
            Console.WriteLine("Volume of Cilinder = " + r, GetVolume());
        }
        public override string ToString()
        {
            return "This is a Cylinder with volume " + r;
        }
        //public static void VolumeCylinder()  aceasta metoda functioneaza 
        //{
        //    var r = 3;
        //    var h = 10;

        //    var vol = Math.PI * Math.Pow(r, 2) * h;

        //    Console.WriteLine("Volume of Cilinder = " + vol);
        //}
    }
}
