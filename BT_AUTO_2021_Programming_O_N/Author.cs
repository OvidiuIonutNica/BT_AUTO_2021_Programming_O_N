using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming_O_N
{
    public class Author
    {
        public string name = "Ion smecherul";
        public string email = "ion.smecherul@gmail.com";

        public static void Autor(string name, string email)
        {
            Console.WriteLine("Autorul cartii este " + name + " si email-ul sau este " + email);
        }

        public static void getName()
        {
            string name = "ion smecherul";
            Console.WriteLine(name);
        }

        public static void getEmail()
        {
            string email = "ion.smecherul@gmail.com";
            Console.WriteLine(email);
        }
    }
}
