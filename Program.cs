using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_HÜ
{
    class Program
    {
        static void Main(string[] args)
        {
            Gespraech g1 = new Gespraech("Besprechung der HÜ");

            g1.Begin = DateTime.Parse("2020-02-26 14:01");
            g1.End = DateTime.Parse("2020-02-26 14:05");
            g1.Minute();

            Gespraech g2 = new Gespraech("Besprechung des aktuellen Projektes");
            g2.Begin = DateTime.Parse("2020-02-26 14:11");
            g2.End = DateTime.Parse("2020-02-26 15:00");
            g2.Minute();


            int dauer = g1.Minuten + g2.Minuten;
            Console.WriteLine("Dauer der Gespräche: {0}", dauer);

        }
    }
}
