using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._04._2019
{
    class Program
    {        
        static void Main(string[] args)
        {
        Console.Write("Geben sie eine Zahl ein: ");
        
        int Zahl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ihre eingabe: {0}", eingabe);

            int counter = 0;
            while(counter < 5 )
            {
                eingabe = eingabe + 2;
                counter++;
            }


            Console.WriteLine("Ihre Zahl: ", eingabe);


            Console.ReadLine();
        }
    }
}
