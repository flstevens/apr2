using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_12._12._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte b1 = 200;
            Console.WriteLine("Byte: {0}", b1);

            Console.WriteLine("max: {0}", Byte.MaxValue);
            Console.WriteLine("min: {0}", Byte.MinValue);

            long lng = 300;
            Console.WriteLine("Long: {0}", lng);

            lng = b1; //inplizite Typkonvertierung bzw. Typecasting
            Console.WriteLine("Long: {0}", lng);

            //b1 = lng;
            Console.WriteLine("Byte: {0}", b1);
            // Typkonvertierung
            //long (8 Bytes) kann logischerweise nicht
            //in einem Byte gespeichert werden.
            // b1 = lng;

            

            b1 = Convert.ToByte(lng); //explizit Typkonvertierung
            b1 = (byte)lng; //explizit
            Console.WriteLine("Byte: {0}", b1);









            Console.ReadLine();
        }
    }
}
