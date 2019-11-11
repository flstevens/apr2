using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._05._2019_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 4;
             
            switch (zahl)
            {
                case 1:
                    Console.WriteLine("Das ist eins");
                    break;
                case 2:
                    Console.WriteLine("Das ist zwei");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Das ist vier");
                    break;
                default:
                    Console.WriteLine("Das ist default");
                    break;

            }

            if (zahl == 1)
            {
                Console.WriteLine("Das ist eins");
            }
            else if (zahl == 2)
            {
                Console.WriteLine("Das ist zwei");
            }
            else if (zahl == 3 || zahl == 4)
            {
                Console.WriteLine("Das ist vier");
            }
            else
            {
                Console.WriteLine("Das ist default");
            }






            Console.ReadLine();

        }
    }
}
