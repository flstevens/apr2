using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._06._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> zahlen = new List<int>();

            zahlen.Add(5);
            zahlen.Add(2);
            zahlen.Add(6);
            zahlen.Add(9);
            zahlen.Add(11);
            string eingabe = Console.ReadLine();
            int summe = 0;
            string wörter = eingabe;

            foreach (int zahl in zahlen)
            {
                summe += zahl;
            }

            Console.WriteLine("Summe : {0}", summe);

            int[,] z = new int[20, 30];
            Random g = new Random();

            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    z[i, j] = g.Next(1, 100);
                }
            }

            // Wörterkette
            Console.Write("Wort: ");
             eingabe = Console.ReadLine();
            string wörter = eingabe

            while (eingabe != "")
            {
                string letzterBuchstabe = wörter.Substring(wörter.Length - 1);

                Console.Write("Nächster Name: ");
                string eingabeTemp = Console.ReadLine();

                if(eingabeTemp != "")
                {
                    string ersterBuchstabe = eingabeTemp.Substring(0, 1);

                    if (letzterBuchstabe.ToLower() == ersterBuchstabe.ToLower())
                    {
                        Console.WriteLine("Korrekt");
                        wörter += "" + eingabeTemp;
                    }
                    else
                    {
                        Console.WriteLine("Faslch");
                    }
                }
                else
                {
                    eingabe = "";
                }
            }

            Console.ReadLine();
        }
    }
}
