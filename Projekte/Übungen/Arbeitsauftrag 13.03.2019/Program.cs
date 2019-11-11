using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitsauftrag_13._03._2019
{
    class Program
    {

        static void printArray(string[] Planeten)
        {
            Console.WriteLine("1. Planet: {0}", Planeten);
            Console.WriteLine("2. Planet: {1}", Planeten);
            Console.WriteLine("3. Planet: {2}", Planeten);
            Console.WriteLine("4. Planet: {3}", Planeten);
            Console.WriteLine("5. Planet: {4}", Planeten);
            Console.WriteLine("6. Planet: {5}", Planeten);
            Console.WriteLine("7. Planet: {6}", Planeten);
            Console.WriteLine("8. Planet: {7}", Planeten);
            Console.WriteLine("9. Planet: {8}", Planeten);
        }

        static void Main(string[] args)
        {
            string[] Planeten = new string[9];
            Planeten[0] = "Merkur";
            Planeten[1] = "Venus";
            Planeten[2] = "Erde";
            Planeten[3] = "Mars";
            Planeten[4] = "Jupiter";
            Planeten[5] = "Satur";
            Planeten[6] = "Uranus";
            Planeten[7] = "Neptune";
            Planeten[8] = "Pluto";
        
            Console.WriteLine("Nicht sortierte Planeten");

            printArray(Planeten);

            Console.WriteLine("Alphabetisch sortierte Planeten");

            Array.Sort(Planeten);

            printArray(Planeten);








            Console.ReadLine();
        }
    }
}
