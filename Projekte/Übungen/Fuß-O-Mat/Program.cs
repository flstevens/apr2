using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuß_O_Mat
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Hallo, ich bin der Fuß-O-Mat hier sind ihre auswahlmäglichkeiten");

            Console.WriteLine("+----------+");
            Console.WriteLine("| Hund     |");
            Console.WriteLine("| Katze    |");
            Console.WriteLine("| Huhn     |");
            Console.WriteLine("| Lauf Ente|");
            Console.WriteLine("| Elefant  |");
            Console.WriteLine("| Esel     |");
            Console.WriteLine("| Falke    |");
            Console.WriteLine("+----------+");
            int anzahl = 0;


            Console.Write("Tier1: ");        
            string Tier1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Eingabe Gespeichert Vorgang wird ausgeführt");

            Console.ReadLine();


            if (Tier1 == "Hund")
            {
                anzahl = anzahl + 4;
            }

            if (Tier1 == "")
            {
                Console.WriteLine("Error Eingabe nicht Kompatibel");
            }

            if (Tier1 == "Katze")
            {
                anzahl = anzahl + 4;
            }

            if (Tier1 == "Huhn")
            {
                anzahl = anzahl + 2;
            }

            if (Tier1 == "Lauf Ente")
            {
                anzahl = anzahl + 2;
            }

            if (Tier1 == "Elefant")
            {
                anzahl = anzahl + 4;
            }

            if (Tier1 == "Esel")
            {
                anzahl = anzahl + 4;
            }

            if (Tier1 == "Falke")
            {
                anzahl = anzahl + 2;
            }

            Console.WriteLine("Geben sie ein Zweites tier ein");


            Console.Write("Tier2: ");
            string Tier2 = Convert.ToString(Console.ReadLine());

            if (Tier2 == "Hund")

            {
                anzahl = anzahl + 4;
            }

            if (Tier2 == "")
            {
                Console.WriteLine("Error Eingabe nicht Kompatibel");
            }

            if (Tier2 == "Katze")
            {
                anzahl = anzahl + 4;
            }

            if (Tier2 == "Huhn")
            {
                anzahl = anzahl + 2;
            }

            if (Tier2 == "Lauf Ente")
            {
                anzahl = anzahl + 2;
            
            }

            if (Tier2 == "Elefant")
            {
                anzahl = anzahl + 4;
            }

            if (Tier2 == "Esel")
            {
                anzahl = anzahl + 4;
            }

            if (Tier2 == "Falke")
            {
                anzahl = anzahl + 2;
            }

            Console.WriteLine("Dies ist ihr ergebnis");

            Console.WriteLine("Ergebnis: {0}", anzahl);        



            Console.ReadLine();
        }
    }
}
