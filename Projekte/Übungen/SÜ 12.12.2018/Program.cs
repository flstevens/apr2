using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SÜ_12._12._2018
{
    class Program
    {
        string[] fragen = new string[]
            {
                "Wann war die Französische Revolution?",
                "Wann begann der Erste Weltkrieg?",
                "Was bedeutet der Begriff \"Kalter Krieg\"",
            };

        string[,] antworten = new string[,]
        {
                {"1970", "1789", "1770", "1928" },
                {"1614", "1789", "1914", "1922" },
                {"Konflikt zw. USA und UdSSR", "Krieg in Russland", "Krieg in Ukraine", "Krieg in Syrien" };
    }

    int[] loesungen = new int[]
    {
                2,
                3,
                1,
    };

    int stufe = 0;
    bool spielAktiv = true;

    Console.WriteLine("Willkommen bei WER WIRD MILLIONÄR!");    

        while (spielAktiv && stufe<fragen.Length)
        {
                              Console.WriteLine("Frage {0}: {1}", (stufe + 1), fragen[stufe]);
        
        }

       
        }   
    }
}
