using System;

namespace BT_AUTO_2021_Programming_O_N
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_SIZE = 100;
            const double PI = 3.14;
            const int MAX_NUMBER = 5;

            /*           Console.WriteLine("Hello World!");
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

                       x++  <=> x = x + 1
                       ++x <=> x = x + 1

                       Console.WriteLine(x++);
                       Console.WriteLine(++x);

                       Console.WriteLine((x == a));
                       Console.WriteLine((x < a));
                       Console.WriteLine(!(x < a));
                       Console.WriteLine((x < a) ^ (x == a));
                       Console.WriteLine((x < a) || (x == a));
            */
            int number = 100;
            Console.WriteLine("number tested is" + number);
            /*
                       //conditiile if + else
                        if (number >= 0)
                             {
                            Console.WriteLine("number is positive");
                               }
                        else
                        {
                            Console.WriteLine("number is negative");
                        }

                        if (number % 2 == 0)
                        {
                            Console.WriteLine("Even number!");
                        }
                        else {
                            Console.WriteLine("Odd number!");

                        }

                        if (number <= 40 && number >= 0)
                        {
                            if (number <= 20)
                            {
                                Console.WriteLine("Student failed!");
                            }


                            else
                            {
                                Console.WriteLine("Student passed!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Grade is invalid!");
                        }

                        //one line if / else
                        String message = (number % 2 == 0) ? "Even" : "Odd";
                        Console.WriteLine(message); //conditia de la String poate inlocui o conditie if 


                        if (number == 1)
                        {
                            Console.WriteLine("Monday");
                        }
                        if (number == 2)
                        {
                            Console.WriteLine("Tuesday");
                        }
                        if (number == 3)
                        {
                            Console.WriteLine("Wednesday");
                        }
                        if (number == 4)
                        {
                            Console.WriteLine("Thursday");
                        }
                        if (number == 5)
                        {
                            Console.WriteLine("Friday");
                        }
                        if (number == 6)
                        {
                            Console.WriteLine("Saturday");
                        }
                        if (number == 7)
                        {
                            Console.WriteLine("Sunday");
                        }
                        if (number < 1 || number > 7)
                        {
                            Console.WriteLine("Sorry is not a valid day");
                       }
            */
            //Switch
            /*
                        switch (number)
                        {
                            case 1:
                                {
                                    Console.WriteLine("M");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Tuesday");
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Wednesday");
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Thursday");
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Friday");
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine("Saturday");
                                    break;
                                }
                            case 7:
                                {
                                    Console.WriteLine("Saturday");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Sorry is not a valid day");
                                    break;
                                }

                        }
            */
            int counter = 0;
            //while
            /*

                        while (counter <= MAX_NUMBER)
                        {
                            Console.WriteLine("Curent number is: " + counter);
                            counter++;
                        }
            */
            //do-while
            /*
                        counter = 0;
                        do
                        {
                            Console.WriteLine("Curent number is: " + counter);
                            counter++;
                        }
                        while (counter <= MAX_NUMBER);
             */
            //FOR = while
            /*
                        for(counter = 0; counter <= MAX_NUMBER; counter ++)
                        {
                           // Console.WriteLine("Curentnumber is:" + counter); )
                            Console.WriteLine("Curent number is: {0}", counter); 
                        }
            */
            //Foreach
            /*
                    foreach(string argument in args)
                        {
                            Console.WriteLine("The argument is: {0}", argument);
                        }
            */
            //continue and break - vezi curs exemplu

            //Class activity
            
            /*         
                     if(year % 4 == 0)
                     {
                         if (year % 100 == 0 && year % 400 != 0)
                         {
                             febDays = 29;
                         }
                         if (year % 100 !=0)
                         {
                             febDays = 29;
                         }

                     }
                     */
            foreach (string yr in args)
            {
                int febDays = 28, year = int.Parse(yr);
               
                if (year < 1900 || year > 2016)
            {
                Console.WriteLine("Year is out of valid bounds (1900-2016");
            }
            if ((year % 4 == 0 && year % 100 == 0 && year % 400 != 0) || (year % 4 == 0 && year % 100 == 0 && year % 100 != 0))
            {
                febDays = 29;

            }
                Console.WriteLine("February has 28 days", febDays);
            }
        
            

        }
    }
}
