using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._05._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] rechnungen = new string[,]
                {
                    {"6 + 4", "10" },
                    {"11 - 1", "10" },
                    { "20 - 10", "10" },
                    {"5 + 5", "10" },
                    {"7 - 3", "4" }
                };

            Console.WriteLine("Anzahl der Elemente: {0}", rechnungen.Length);
            Console.WriteLine("Anzahl der ersten Domension: {0}", rechnungen.GetLength(0));
            Console.WriteLine("Anzahl der zweiten Domension: {0}", rechnungen.GetLength(1));

            int korrekte = 0;
            for (int i = 0; i < rechnungen.GetLength(0); i++)
            {
                Console.Write("{0} = ", rechnungen[i, 0]);
                string eingabe = Console.ReadLine();

                if (eingabe == rechnungen[i, 1])
                {
                    Console.WriteLine("Supper");
                    korrekte++;
                }
                else
                {
                    Console.WriteLine("Leider Flasch");
                }

            }

            Console.WriteLine("Sie haben {0} von {1} Rechnungen richtig", korrekte, rechnungen.GetLength(0));
            if (korrekte == 5)
            {
                Console.WriteLine("Ohne Fehler Toll gemacht");
            }

            Console.ReadLine();
        } 
    }
}
