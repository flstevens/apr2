using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_9._01._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Das is\bst\n \bMax");

            int a = 5;
            int b = 10;

            bool erg = (a == b);
            Console.WriteLine("a == b => {0}", erg);

            erg = a != b;
            Console.WriteLine("a != b => {0}", erg);

            erg = a > b;
            Console.WriteLine("a > b => {0}", erg);

            erg = a < b;
            Console.WriteLine("a < b => {0}", erg);

            erg = a >= b;
            Console.WriteLine("a >= b => {0}", erg);

            erg = a <= b;
            Console.WriteLine("a <= b => {0}", erg);

            string ort = "Rauris";
            erg = ort == "Rauris";
            Console.WriteLine("ort == \"Rauris\" => {0}", erg);

            int c = 3;
            string schule = "HAK";

            // && beteutet AND
            bool erg1 = (c == 5) && (schule == "HAK");
            Console.WriteLine("Ergebnis: {0}", erg1);

            // || bedeutet OR
            erg1 = (c == 5) || (schule == "HAK");
            Console.WriteLine("Ergebnis: {0}", erg1);

            erg1 = true || false || true && false || true;
            Console.WriteLine("Ergebnis: {0}", erg1);

            erg1 = false && true && false;
            Console.WriteLine("Ergebnis: {0}", erg1);

            erg1 = false && true || false;
            Console.WriteLine("Ergebnis: {0}", erg1);

            erg1 = true && true && false || true;
            Console.WriteLine("Ergebnis: {0}", erg1);

            erg1 = true || (true && false || true);
            Console.WriteLine("Ergebnis: {0}", erg1);


















            Console.ReadLine();






        }
    }
}
