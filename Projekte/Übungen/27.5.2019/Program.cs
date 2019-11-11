using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._5._2019
{
    class Program
    {
        static void printList(List<string> colors)
        {
            Console.WriteLine("Ausgabe der Liste");
            foreach ( string c in colors)
            {
                Console.WriteLine("Farbe: {0}", c);
            }
        }

        static void Main(string[] args)
        {
            string[] color = new string[] { "rot", "gelb", "grün", "rosa" };

            // Fehler weil außerhalb des Arrays
            // color [4] = "weiß";

            List<string> colors = new List<string>();

            //Elemente hinzufügen
            colors.Add("rosa");
            colors.Add("blau");


            for (int i = 0; i < colors.Count; i++)
            {
                Console.WriteLine("Farbe: {0}", colors[i]);
            }

            colors.RemoveAt(0);

            printList(colors);

            colors.Add("lila");

            printList(colors);

            colors[0] = "grün";

            printList(colors);

            Console.WriteLine("Ausgabe des Elemts and der Position 0");
            Console.WriteLine(colors.ElementAt(0));
            Console.WriteLine(colors[0]);

            // Farben hinzufügen
            colors.Add("schwarz");
            colors.Add("grau");
            colors.Add("weiß");
            colors.Add("braun");

            printList(colors);

            Console.WriteLine("Anzahl der Elemente: {0}", colors.Count);

            int position = colors.IndexOf("grau");
            Console.WriteLine("Fund: {0}", position);

            Console.ReadLine();
        }
    }
}
