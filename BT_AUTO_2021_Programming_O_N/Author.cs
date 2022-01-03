using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming_O_N
{
    public class Author
    {
        public string Name = "Ion smecherul";
        public string Email = "ion.smecherul@gmail.com";

        public static void Autor(string name, string email)
        {
            Console.WriteLine("Autorul cartii este " + name + " si email-ul sau este " + email);
        }

        public static void GetName()
        {
            string name = "ion smecherul";
            Console.WriteLine(name);
        }

        public static void GetEmail()
        {
            string email = "ion.smecherul@gmail.com";
            Console.WriteLine(email);
        }
    }
}
