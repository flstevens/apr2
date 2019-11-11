using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechenkönig
{
    class Program
    {
        static void Main(string[] args)
        {
            bool spielAktiv = true;
            int Punkte = 0;

            Console.WriteLine("Wilkommen beim Spiel");
            Console.WriteLine("Drücken sie Enter um zu Starten");
            Console.ReadLine();

            while (spielAktiv == true)
            {
                Random g = new Random();

                int zahl1 = g.Next(1, 101);
                int zahl2 = g.Next(1, 101);

                int summe = zahl1 + zahl2;


                Console.Write("{0} + {1} = ", zahl1, zahl2);

                string eingabe = Console.ReadLine();

                if (eingabe == "")
                {
                    Console.WriteLine("Das Spiel ist aus");
                    spielAktiv = false;
                }
                else
                {
                    int ergebnis = Convert.ToInt32(eingabe);

                    if (ergebnis == summe)
                    {
                        Punkte++;
                        Console.WriteLine("Supper!");
                        
                    }
                    else
                    {
                        Console.WriteLine("Falsch!");
                        spielAktiv = false;
                    }
                }




                Console.WriteLine("Ihr Punktestand {0}", Punkte);
            }

            Console.ReadLine();
        }
    }
}
