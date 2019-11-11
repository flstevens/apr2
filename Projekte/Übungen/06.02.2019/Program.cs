using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02._2019
{
    class Program
    {
        static void Eingabe()
        {
            Console.WriteLine("Wie ist ihr Name");
            string eingabe = Console.ReadLine();
            Console.WriteLine("Name: {0}", eingabe);
        }

        static void Log(string nachricht)
        {
            Console.WriteLine("* {0}", nachricht);
        }


        static void Ausgabe()
        {
            Console.WriteLine("Das ist meine Ausgabe");
        }


        static void Main(string[] args)
        {
            #region einfache Veriablen
            string firstname1 = "Max";
            string firstname2 = "Herbert";
            #endregion

            //Arrays
            string[] firstname = new string[3];

            firstname[0] = "Max";
            firstname[1] = "Herbert";
            firstname[2] = "Friedrich";

            // Referenz zum Aray
            Array.Resize(ref firstname, 4);

            firstname[3] = "Julia";

            Console.WriteLine("Erstes Element: {0}", firstname[0]);

            int[] zahlen = new int[] { 1, 2, 3 };

            int summe = zahlen[2] + zahlen[1];

            Console.WriteLine("Anzahl der Plätze: {0}", zahlen.Length);

            Console.WriteLine("Summe: {0}", summe);



            Program.Ausgabe();
            Ausgabe();


            Eingabe();
            Eingabe();
            Eingabe();
            Eingabe();

            Log("Maximilian schreibt");
            Log("Hugo spielt");
            Log("Es shneit");
            Log("LOL");

            Console.ReadLine();























































































































































            Console.ReadLine();
        }
    }
}
