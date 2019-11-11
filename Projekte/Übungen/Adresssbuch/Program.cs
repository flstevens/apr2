using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresssbuch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] telefonbuch = new string[,]
            {
                { "Hubert", "0664/1234" },
                { "Harrald", "0664/1234" },
                { "Rettung", "144" },
                { "Feuerwehr", "122" },
                { "Polizei", "133" },
            };

            for (int i = 0; i < telefonbuch.GetLength(0); i++)
            {
                Console.WriteLine("Name: {0} - Nr: {1}", telefonbuch[i,0], telefonbuch[i, 1]);
            }

            string eingabe = "-";
            while (eingabe != "")
            {
                Console.Write("Suche: ");
                eingabe = Console.ReadLine();

                bool fund = false;

                for (int i = 0; i < telefonbuch.GetLength(0) && !fund; i++)
                {
                    if (telefonbuch[i, 0].ToLower().IndexOf(eingabe.ToLower()) > -1 && eingabe != "")
                    {
                        Console.WriteLine("Telefonnummer von {0}: {1}", telefonbuch[i,0],telefonbuch[i, 1]);
                        fund = true;
                    }
                }

                if (!fund && eingabe.Length > 0)
                {
                    Console.WriteLine("Eintrag wurde nicht gefunden");
                }

            }

            string eingabe1 = "";

            do
            {
                Console.Write("Suche2: ");
                eingabe1 = Console.ReadLine();


            } while (eingabe1 != "");

    

            


            Console.ReadLine();
        }
    }
}
