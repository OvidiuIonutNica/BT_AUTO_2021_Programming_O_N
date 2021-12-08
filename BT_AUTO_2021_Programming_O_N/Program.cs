using System;

namespace BT_AUTO_2021_Programming_O_N
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_SIZE = 100;
            const double PI = 3.14;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Ana are mere si pere");
            Console.WriteLine("Ioana are struguri");

            int numberofStudents = 5;
            int count;
            int a, b;
            a = numberofStudents + 1;
            a = a + numberofStudents;
            short s = 5;
            ulong ul = 65;

            float numeberFloat = 5.6F;
            double numberDouble = 5.6;

            float f = (float)numberDouble;
            int numberInt = (int)f;
            long l = numberofStudents;


            Console.WriteLine(typeof(int).IsPrimitive);

            bool myBoolean = false;

            char ch = 'b';

            string myString = "Ana are mere si pere";
            string result = myString + " si struguri";
            Console.WriteLine(result);

            DateTime dataCurenta = new DateTime(2021, 12, 8);
            Console.WriteLine(dataCurenta);

            Console.WriteLine(numberDouble * a);
            Console.WriteLine(numeberFloat * a);
            Console.WriteLine(numberDouble * a);
            Console.WriteLine(numeberFloat / a);
            Console.WriteLine(5 / 6.0);
            Console.WriteLine(5 / (float)6);
            Console.WriteLine(5 % 6);
            Console.WriteLine(5 + 6);
            Console.WriteLine(5 - 6);

            int x = 2;
            x += 5; // x = x + 5

            //x++  <=> x = x + 1
            //++x <=> x = x + 1

            Console.WriteLine(x++);
            Console.WriteLine(++x);

            Console.WriteLine((x == a));
            Console.WriteLine((x < a));
            Console.WriteLine((!x < a));
            Console.WriteLine((x < a) ^ (x == a));
            Console.WriteLine((x < a) || (x == a));

        }
    }
}
