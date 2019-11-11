using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._04._2019_Zapfenrechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zapfenrechnen mit: ");
            int zahl = Convert.ToInt32(Console.ReadLine());

            long ergebnis = 0;
            int counter = 0;
            int multi = 0;
            long erg2 = zahl;

            while(counter < 9 )
            {
                counter++;
                multi++;
                ergebnis = erg2 * multi;
                Console.WriteLine("{0} * {1} = {2}", erg2, multi, ergebnis);
                erg2 = ergebnis;

            }
            while (counter < 9)
            {
               

            }

            Console.ReadLine();







        }
    }
}
