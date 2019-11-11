using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._2._2019_V2
{
    class Program
    {
        static void a()
        {
            Console.WriteLine("Name");
            string name = Console.ReadLine();
                         
            Console.WriteLine("geschlecht");
            string geschlecht = Console.ReadLine();

            string ausgabe = ((geschlecht == "w") ? "Frau " : "Herr ") + name;

            Console.WriteLine("Ausgabe: {0}", ausgabe);
        
        
           
        }


        static void Main(string[] args)
        {
            a();
          



            Console.ReadLine();
        }
    }
}
