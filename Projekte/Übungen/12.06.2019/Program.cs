using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._06._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Max Muster";
            int pos = name.IndexOf(" ");
            Console.WriteLine(pos);
            Console.ReadLine();
            string firstname = name.Substring(0, pos);
            string surname = name.Substring(pos + 1, name.Length - pos - 1);
            Console.WriteLine(surname);

            // Benutzername: 1. Buchstabe des Vornamens
            // Nachname
            // alles klein geschrieben zB mmuster, ...
            firstname = firstname.ToLower();
            surname = surname.ToLower();

            firstname = firstname.Substring(0, 1);

            string benutzer = firstname + surname;

            Console.WriteLine("Benutzername: {0}", benutzer);

            string wort = "Hallo";

            for (int i = 0; i < wort.Length; i++)
            {
                string bst = wort.Substring(i, 1);
                Console.WriteLine(bst);
            }

            string satz = "Das ist ein Demo-Satz";

            int ade = 0;

            for (int  i = 0;  i < satz.Length;  i++)
            {
                string bst = satz.Substring(i, 1);
                if (bst.ToLower() == "e")
                {
                    ade++;
                }

            }

            Console.WriteLine("Anzahl der E: {0}", ade);
           
            







            Console.ReadLine();
        }
    }
}
