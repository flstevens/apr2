using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_19._12._2018
{
    class Program
    {
        static void Main(string[] args)

        { 
            string eingabe = "";
            int zahl1;
            int zahl2;
            int ergebnis;

            Console.Write("Zahl1: ");
            // eingabe = Console.ReadLine();
            zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zahl2: ");
            eingabe = Console.ReadLine();
            zahl2 = Convert.ToInt32(eingabe);
        
            ergebnis = zahl1 + zahl2;



            Console.WriteLine("Ergebnis: {0}", ergebnis);





            Console.ReadLine();
        


        }
    }
}
