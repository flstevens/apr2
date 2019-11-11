using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zähler
{
    class Program
    {
        static void Countdoku()
        {


            Console.WriteLine("Geben sie ein zahl bis {0} ein", Int32.MaxValue);


            Console.Write("Hier eingeben:");
            string eingabe = Console.ReadLine(); 
            int Hallo = 0;
            int zahl = 0;


            Console.WriteLine("Eingabe: {0}", eingabe);


            Hallo = Convert.ToInt32(eingabe);

            while (zahl < Hallo)
            {
                ++zahl;
                Console.WriteLine("{0}", zahl);

            }
            Console.ReadLine();
            while (zahl > 0)
            {
                Console.WriteLine("{0}", zahl);
                --zahl;
            }


            Console.ReadLine();
        }


        static void Main(string[] args)
        {

            Console.Write("Wie oft ausführen:");
            string eingabe2 = Console.ReadLine();
            int Hallo2 = 0;
            int zahl1 = 0;
            
            Hallo2 = Convert.ToInt32(eingabe2);

            while(zahl1<Hallo2)
            {
                zahl1++;
                Countdoku();

            }
        }
    }
}
