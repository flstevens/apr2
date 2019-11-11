using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._2._2019
{
    class Program
    {
        static void print(string url)
        {
            Console.WriteLine("{0}: {1}", DateTime.Now.ToString(), url);
        }

        static void Main(string[] args)
        {
            print("www.orf.at");
            print("www.gmx.at");
            print("sport.orf.at");


            Console.ReadLine();
        }
    }
}
