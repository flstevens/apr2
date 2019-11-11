using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._05._2019_Wortketten
{
    class Program
    {
        static void Main(string[] args)
        {
            string zeichenkette = "Hallo Welt";

            // Umwandeln in Kleinbuchstaben
            Console.WriteLine("Kleinbuchstaben: {0}", zeichenkette.ToLower());

            // Keine Veränderung der Zeichenkette
            Console.WriteLine(zeichenkette);

            zeichenkette = zeichenkette.ToLower();

            // erster Buchstabe
            string b1 = zeichenkette.Substring(0, 1);
            Console.WriteLine("B1: {0}", b1);
            int länge = zeichenkette.Length;
            string lB = zeichenkette.Substring(länge - 1, 1);
            Console.WriteLine("lB: {0}", lB);

            


            Console.ReadLine();
        }
    }
}
