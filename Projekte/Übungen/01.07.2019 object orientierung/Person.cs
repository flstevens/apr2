using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2019_object_orientierung
{
    class Person
    {
        string vorname;
        string nachname;

        public void setzeVorname(string vname)
        {
            vorname = vname;
        }

        public void setzeNachname(string nachname)
        {
            this.nachname = nachname;
        }

        public void gehe ()
        {
            Console.WriteLine("{0} {1}:Ich gehe.....", vorname, nachname);
        }
    }
}
