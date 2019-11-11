using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._2._2019_V3
{
    class Program
    {
        static void flächeQuadrat()
        {
            Console.Write("Seite: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double fläche = Math.Pow(a, 2);
            Console.WriteLine("Fläche: {0}", fläche);
        }

        static void hilfe()
        {
            Console.WriteLine("Bitte geben sie 1 oder 2 ein.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("| Wählen Sie aus           |");
            Console.WriteLine("| 1) Fläche eines Quadrats |");
            Console.WriteLine("+--------------------------+");
            Console.WriteLine();

            Console.Write("Auswahl1: ");
            int auswahl = Convert.ToInt32(Console.ReadLine());

            if (auswahl == 1)
            {
                flächeQuadrat();
            }
            else {
                hilfe();
                   }








            Console.ReadLine();
        }
    }
}
