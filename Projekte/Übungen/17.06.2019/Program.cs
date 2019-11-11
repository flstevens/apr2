using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._06._2019
{
    class Program
    {
        static void Ausgabe(int pos)
        {
            Console.WriteLine("Position: {0}", pos);
        }

        static int Suche(string zeichenkette, string buchstabe)
        {
            int ergebnis = -1;

            for (int i = 0; i < zeichenkette.Length && ergebnis == -1; i++)
            {
                string bst = zeichenkette.Substring(i, 1);
                // Console.WriteLine(bst);
                if (bst == buchstabe)
                {
                    ergebnis = i;
                }

            }





            return ergebnis;
        }


        static void Main(string[] args)
        {
            // indexOf
            string zk = "Das ist ein Test";
            int pos = zk.IndexOf("i");
            Ausgabe(pos);

            pos = zk.IndexOf("T");
            Ausgabe(pos);

            pos = zk.IndexOf("x");
            Ausgabe(pos);

            pos = Suche(zk, "D");
            Ausgabe(pos);

            Console.ReadLine();
        }
    }
}
