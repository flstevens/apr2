using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_07._01._2019
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string eingabe = "";
            double zahl1;
            double zahl2;
            double ergebnis;
            double differenz;
            double produkt;
            double modulo;
            double potenzwert;
            double wurzel;
            double quotient;

            Console.Write("Zahl1: ");
            zahl1 = Convert.ToDouble(Console.ReadLine());








            Console.Write("Zahl2: ");
            eingabe = Console.ReadLine();
            zahl2 = Convert.ToDouble(eingabe);

            ergebnis = zahl1 + zahl2;
            Console.WriteLine("Ergebnis: {0}", ergebnis);

            differenz = zahl1 - zahl2;
            Console.WriteLine("Differenz:{0}", differenz);

            produkt = zahl1 * zahl2;
            Console.WriteLine("Produkt: {0} ", produkt);
            
            //Zeigt Rest an
            modulo = zahl1 % zahl2;
            Console.WriteLine("Modulo: {0}", modulo);

            potenzwert = Math.Pow(zahl1, zahl2);
            Console.WriteLine("Potenzwert: {0}", potenzwert);

            wurzel = Math.Sqrt(zahl1);
            Console.WriteLine("Wurzel: {0}", wurzel);

            quotient = zahl1 / zahl2;
            Console.WriteLine("Quotient: {0}", quotient);

            Console.WriteLine("Er heist\"Max\");

            Console.ReadLine();

            


        }
    }
}
