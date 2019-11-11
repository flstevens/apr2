using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netto_Brutto_Rechner_16._01._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe = "";
            double netto;
            double prozent;
            double ergebnis;

            Console.Write("netto: ");
             //eingabe = Console.ReadLine();
            netto = Convert.ToDouble(Console.ReadLine());

            Console.Write("prozent: ");
            eingabe = Console.ReadLine();
            prozent = Convert.ToDouble(eingabe);

            ergebnis = netto + netto / 100 * prozent;

            


            Console.WriteLine("Ergebnis: {0}", ergebnis);





            Console.ReadLine();




        }
    }
}
