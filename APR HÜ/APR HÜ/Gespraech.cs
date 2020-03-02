using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_HÜ
{
    class Gespraech
    {
        string Inhalt;
        

        public Gespraech(string inhalt)
        {
            this.Inhalt = inhalt;
        }

        public DateTime Begin { get; set; }

        public DateTime End { get; set; }

        public int Minuten { get; set; }


        public int Minute()
        {
            TimeSpan min = End.Subtract(Begin);
            var erg = min.TotalMinutes;
            Minuten = Convert.ToInt32(erg);
            return Minuten;
        }



    }
}
