using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_28._10._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int sitze = 4;
            Console.WriteLine("Das Auto hat {0} sitze!", sitze);


            //Florian Stevens   
            Console.WriteLine("Geben sie ihr alter ein: ");
            int alter = Convert.ToInt32(Console.ReadLine());

            string hallo = "Hallo";
            for (int i = 0; i < hallo.Length; i++)
            {
                hallo.Substring(0, i);
            }

            List<string> h = new List<string>();
            h.Add("Fenster");
            h.Add("Tür");

        }
        class Smartphone
        {
            public int Preis = 100;

            public string Klingel()
            {
                Console.WriteLine("Das Hadny Klingelt");
            }
        }

    }
}
