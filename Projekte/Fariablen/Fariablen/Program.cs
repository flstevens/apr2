using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fariablen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable für den Vornamen
            string vorname = "Florian";
            Console.WriteLine("Vorname: " + vorname);

            /*
             * Der Beginn is an der Position 0 und das 
             * Ende ist an der Position n - 1 
             */
            Console.WriteLine("Vorname: {0}", vorname);

            string nachname = "Stevens";
            Console.WriteLine("Vorname: {0} - Nachname: {1}",
            vorname, nachname);
            //Schule wird deklariert
            //Klasse wird deklariert und initialisiert
            string schule, klasse = "1C";

            nachname = "Meier";

            Console.WriteLine("Nachname: {0}.", nachname);

            //Console.WriteLine("Schule: {0}.", schule);

            Console.Write("Name: ");
            string eingabe = Console.ReadLine();
            Console.WriteLine("Sie sind: {0}", eingabe);
       












            Console.ReadLine();
        }

    }
}
