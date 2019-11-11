using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sü_4.Feb._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int personen = 0;
            double kosten = 0;
            string we = "";

            Console.WriteLine("Handelt es sich um ein Wochende? ");
            we = Console.ReadLine();

            Console.WriteLine("Wie viele Personene ");
            personen = Convert.ToInt32(Console.ReadLine());

            kosten = 35 * personen;

            if ( we == "we")
            {
                kosten = (35 + 2) * personen;
            }

            Console.WriteLine("Betrag: {0}", kosten);



            Console.ReadLine();
        }
    }
}
