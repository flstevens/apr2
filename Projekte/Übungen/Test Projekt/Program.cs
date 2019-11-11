using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe;

            Console.WriteLine("Wilkommen drücken sie die ENTER Taste um zu starten");
            Console.ReadLine();

            Console.WriteLine("Sie stehen for einer Straße und sie wollen auf die andere Seite");
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("|1 einfach rüber gehen                  |");
            Console.WriteLine("|2 zuerst nach links und rechts schauen |");
            Console.WriteLine("|3 Aufgeben                             |");
            Console.WriteLine("+---------------------------------------+");

            Console.Write("eingabe: ");
            eingabe = Console.ReadLine();

            if (eingabe == "1")
            {
                Console.WriteLine("Sie wurden von einem Auto überfahren");
                Console.ReadLine();
            }
            else
            {
                if (eingabe == "2")
                {
                    Console.WriteLine("Sie bemerkten ein Auto und warteten bis es vorbeigefahren war und ginge au die andere seite");
                }
                





                    Console.ReadLine();
                }
            }
        }
    }
}
