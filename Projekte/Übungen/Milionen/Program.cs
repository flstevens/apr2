using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fragen = new string[]
            {
                "Wann war die Französische Revolution?",
                "Wann begann der Erste Weltkrieg?",
                "Was bedeutet der Begriff \"Kalter Krieg\"",
                "Was steht zwischen Berg und Tal?",
                "Warum kann es nie zwei Tage hintereinander regnen?",
                "Was versteht man unter einem Aufgeklärten Absolutismus",
                "Was ist der Julianische Kalender?",
                "Was ist ein Merkmal einer Hochkultur?",
                "Was passiert bei der Mischung der Farben grün und rot?",
                "Wann wurde das Deutsche Kaiserreich gegründet?"
            };

            string[,] antworten = new string[,]
            {
                { "1970", "1789", "1770", "1920" },
                { "1614", "1789", "1914", "1922" },
                { "Konflikt zw. USA und UdSSR", "Krieg in Russland", "Krieg in Ukraine", "Krieg in Syrien" },
                { "Haus", "Brücke", "und", "Lift" },
                { "Wind dazwischen", "Nacht dazwischen", "Luft zu feucht", "Regenmenge unmöglich" },
                { "Absolutismus mit Reformen", "gesicherter König", "ein klassischer Monarch", "Absolutismus in reinster Form" },
                { "Mondkalender", "Maya-Kalender", "Jüdischer Kalender", "Sonnenkalender" },
                { "Arbeitseinteilung", "Enstehung einer Wüste", "Entstehung in Afrika", "Entstehung einer Demokratie" },
                { "gelb", "schwarz", "blau", "türkis" },
                { "1740", "1851", "1871", "1873" }
            };

            int[] loesungen = new int[]
            {
                2,
                3,
                1,
                3,
                2,
                1,
                4,
                1,
                1,
                3
            };

            int stufe = 0;
            bool spielAktiv = true;
            int joker = 1;

            Console.WriteLine("Willkommen bei WER WIRD MILLIONÄR!");

            while (spielAktiv && stufe < fragen.Length)
            {
                Console.WriteLine("Frage {0}: {1}", (stufe + 1), fragen[stufe]);

                /*
                Console.WriteLine(antworten[stufe, 1]);
                Console.WriteLine(antworten[stufe, 2]);
                Console.WriteLine(antworten[stufe, 3]);
                */

                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("{1}) {0}", antworten[stufe, i], (i + 1));
                }

                Console.WriteLine();
                if (joker > 0)
                {
                    Console.WriteLine("Joker-Anzahl 50:50: {0}", joker);
                    Console.WriteLine("j für Joker-Verwendung eingeben.");
                }

                Console.Write("Lösung: ");

                string antwort = Console.ReadLine();
                int antwortPerson = 0;

                if (antwort == "j")
                {
                    if (joker > 0)
                    {
                        joker--;

                        string[] falscheAntworten = new string[3];
                        string richtigeAntwort = "";
                        int counter = 0;

                        for (int i = 0; i < 4; i++)
                        {
                            // 2 ====> (i + 1)
                            if (loesungen[stufe] == (i + 1))
                            {
                                richtigeAntwort = (i + 1) + ") " + antworten[stufe, i];
                            }
                            else
                            {
                                falscheAntworten[counter] = (i + 1) + ") " + antworten[stufe, i];
                                counter++;
                            }

                        }

                        Random g = new Random();
                        int rn = g.Next(0, 3);

                        string[] na = new string[2];
                        na[0] = richtigeAntwort;
                        na[1] = falscheAntworten[rn];

                        Array.Sort(na);

                        Console.WriteLine(na[0]);
                        Console.WriteLine(na[1]);


                        Console.Write("Lösung: ");
                        antwortPerson = Convert.ToInt32(Console.ReadLine());


                    }
                    else
                    {
                        Console.WriteLine("Sie haben leider keinen Joker mehr!");

                        Console.Write("Lösung: ");
                        antwortPerson = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else
                {
                    antwortPerson = Convert.ToInt32(antwort);
                }

                if (antwortPerson == loesungen[stufe])
                {
                    Console.WriteLine("Super!");
                }
                else
                {
                    Console.WriteLine("Schade ...");
                    spielAktiv = false;
                }

                Console.WriteLine();


                stufe++;
            }

            if (spielAktiv && stufe == fragen.Length)
            {
                Console.WriteLine("Gratulation, Sie haben gewonnen!");
            }
            else
            {
                Console.WriteLine("Vielleicht gewinnen Sie beim nächsten Spiel!");
            }


            Console.ReadLine();
        }
    }
}
