using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming_O_N
{
   public class StructExample
    {
       public struct MyStruct
        {
            int number;
            string testString;

            public void Assign(int number, string testString)
            {
                this.number = number;
                this.testString = testString;
            }

            public int ComputeSum()
            {
                int sum = 0;
                for (int i = 0; i < number; i++)
                {
                    sum += i;
                }
                return sum;
            }
        }


    }
}
