using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.Write("Geben sie eine Zahl ein: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
           

            int multi = 0;
        
            while (counter < 10)              
            {
                multi++;
                int ergebnis = zahl * multi;
                counter++;
                
                Console.WriteLine("{0} * {1}: {2}", zahl, multi ,ergebnis);
            }

            Console.ReadLine();
        }

    }
}
