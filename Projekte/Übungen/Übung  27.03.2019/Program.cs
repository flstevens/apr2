using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung__27._03._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int zähler = 0;
            
            //Schleife wird ausgefürht bis der Ausdruck faslch wird

            while(zähler < 5)
            {
                Console.WriteLine("Das ist ein Test");
                zähler++;
            }

            Console.WriteLine("Zähler: {0}", zähler);

            for(int z = 0; z < 5; z++)
            {
                Console.WriteLine("Das ist ein Test");
            }

            //z ist nur zwischen den Geschwungenen Klammern verfügbar

            Console.WriteLine("Zähler: {0}", zähler++);
            Console.WriteLine("Zähler: {0}", zähler++);
            Console.WriteLine("Zähler: {0}", ++zähler);
            Console.WriteLine("Zähler: {0}", ++zähler);
            // analog bei --

            string ausgabe = "";

            while (ausgabe != "xxxxx")
            {
                ausgabe = ausgabe + "x";
                Console.WriteLine(ausgabe);

            }

            int quadrat = 0;
            int ergebnis = 0;
            Console.Write("Hier eingeben:");
            string eingabe = Console.ReadLine(); ;
            int Hallo = 0;

            
            Console.WriteLine("Eingabe: {0}", eingabe);
            
            Hallo = Convert.ToInt32(eingabe);

            while (quadrat < Hallo)
            {
                ++quadrat;
                ergebnis = quadrat * quadrat;
                Console.WriteLine("{0} * {1} = {2}", quadrat, quadrat, ergebnis);
            }

            Console.ReadLine();
        }
    }
}
