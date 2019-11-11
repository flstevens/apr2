using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3._2019_Arrays
{
    class Program
    {
        static void printArray(int[] z)
        {
            for (int i = 0; i < z.Length; i++)
            {
                int zahl = z[i];
                Console.WriteLine("zahl: {0}", zahl);
            }

        }

        static void Main(string[] args)

        {
            int[] zahlen = new int[5];
            zahlen[0] = 10;
            zahlen[1] = 12;
            zahlen[2] = 13;
            zahlen[3] = 15;
            zahlen[4] = 7;

            //schneller
            //int[] z = new int[] { 10, 12, 13, 15, 7 };

            Console.WriteLine("Erstes Element: {0}", zahlen[0]);

            //Schleifen zur Ausgabe des Arrays
            foreach (int zahl in zahlen)
            {
                Console.WriteLine("Zahl: {0}", zahl);
            }
            /*
             for(A1; A2; A3)

             A1: wird beim eintritt der schleife ausgefürht
             A2: wird vir jedem Durchgang ausgeführt
             A3: wird nach jedem durchgang ausgefürht
            */
            for (int i = 0; i < zahlen.Length ;i++)
            {
                int zahl = zahlen[i];
                Console.WriteLine("zahl: {0}", zahl);
            }

            // Array sortierten
            Array.Sort(zahlen);

            Console.WriteLine("Sortiert");
            printArray(zahlen);

            Array.Reverse(zahlen);

            Console.WriteLine("Rüchwärts Sortiert");
            printArray(zahlen);

            
            // erstes Element verändern
            zahlen.SetValue(3, 0);
            printArray(zahlen);

            Array.Clear(zahlen, 3, 2);
            printArray(zahlen);

            // kopieren
            int[] zahlen2 = new int[3];
            Array.Copy(zahlen, zahlen2, 3);
            Console.WriteLine("Zahlen:");
            printArray(zahlen);
            Console.WriteLine("Zahlen2:");
            printArray(zahlen2);

            zahlen2.SetValue(33, 1);
            Console.WriteLine("Nach der Veränderung");
            printArray(zahlen);
            printArray(zahlen2);

            int[] zahlen3 = new int[3];
            zahlen3 = zahlen;
            zahlen3[1] = 44;
            Console.WriteLine("Zahlen-Array");
            printArray(zahlen);
            Console.WriteLine("Zahlen3-Array");
            printArray(zahlen3);


            /*
            string firstname = "Flo";
            string firstname1 = firstname;

            Console.WriteLine("firstname: {0}, firtsname1: {0}", firstname, firstname1);

            firstname1 = "Stevens";
            Console.WriteLine("firstname: {0}, firtsname1: {0}", firstname, firstname1);
            */






            Console.ReadLine();
        }    
    }
}
