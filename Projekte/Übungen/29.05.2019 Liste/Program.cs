using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._05._2019_Liste
{
    class Program
    {
        static void printList(List<string> colors)
        {
            Console.WriteLine("Ausgabe der Liste");
            foreach (string c in colors)
            {
                Console.WriteLine("Name: {0}", c);
            }
        }

        static void Main(string[] args)
        {
            List<string> namen = new List<string>();
            string eingabe = "XD"; 

            
            while(eingabe != "")
            {
                Console.Write("Geben sie einen Namen ein: ");
                eingabe = Console.ReadLine();
                namen.Add(eingabe);
            }
            printList(namen);
            
               
            
            

            Console.ReadLine();
        }
    }
}
