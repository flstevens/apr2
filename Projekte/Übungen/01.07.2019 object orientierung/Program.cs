using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2019_object_orientierung
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random( );
            int zufall = r.Next(1, 11);

            Person hugo = new Person();
            Person hans = new Person();
            Person p3 = new Person();

            hugo.setzeVorname("Hugo");
            hans.setzeVorname("Hans");

            hugo.setzeNachname("Stevens");
            hans.setzeNachname("Blödmann");

            hugo.gehe();
            hans.gehe();

            Auto Opel = new Auto();
            Opel.fahren();
        }
    }
}
