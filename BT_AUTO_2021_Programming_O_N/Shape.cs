using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
  public  class Shape
    {
        ConsoleColor color;
        public virtual void Draw()
        {
            Console.WriteLine("we are drawind a shape! ");

        }
        public void Erase()
        {
            Console.WriteLine("We are erasing the shape!");
        }
        public ConsoleColor GetColor()
        {
            return color;
        }
        public void SetColor(ConsoleColor color)
        {
            this.color = color;

        }
        public override string ToString()
        {
            return "this is a gerenic shape !!";
        }
    }

}


//Square.cs

