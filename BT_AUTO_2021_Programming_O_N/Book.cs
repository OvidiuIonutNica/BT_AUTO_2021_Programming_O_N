using System;
using System.Collections.Generic;
using System.Text;
using BT_AUTO_2021_PRogramming_O_N;

namespace BT_AUTO_2021_Programming_O_N
{
    public static class Book
    {
        //public string name = "Cartea Junglei";
        //public int year = 2010;
        //public double price = 20;

        public static void PrintBook(string name, int year, Author author, double price)
        {
            Console.WriteLine($"Numele cartii este: {name} Anul in care a fost publicata cartea: {year} Autorul cartii este: {author.Name} Pretul cartii: {price}");
        }

        public static void getName()
        {
            string name = "ion smecherul";
            Console.WriteLine(name);

        }

        public static void getPrice()
        {
            double price = 20;
            Console.WriteLine(price);

        }

        public static void getYear()
        {
            int year = 2010;
            Console.WriteLine(year);
           
        }

       


    }
}
