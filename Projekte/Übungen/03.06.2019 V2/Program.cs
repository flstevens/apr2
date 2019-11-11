using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._06._2019_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Max Muster";

            int pos = name.IndexOf("M");
            pos = name.LastIndexOf("M");

            Console.WriteLine("Pos : {0}", pos);

            name = "Max Muster";



            Console.ReadLine();
        }
    }
}
