using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sü_27._5._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lösung;
            lösung = new int[3] { 4, 5, 6 };

            Console.WriteLine("Geben sie die Lösung ein");
            Console.WriteLine("2 + 2: ");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
             
            if(eingabe == lösung[0])
            {
                counter++;
            }

            Console.WriteLine("3 + 2: ");
            eingabe = Convert.ToInt32(Console.ReadLine());

            if (eingabe == lösung[1])
            {
                counter++;
            }

            Console.WriteLine("3 + 3: ");
            eingabe = Convert.ToInt32(Console.ReadLine());

            if (eingabe == lösung[2])
            {
                counter++;
            }

            Console.WriteLine("Sie haben {0} aufgaben richtig", counter);

            Console.ReadLine();
        }
    }
}
