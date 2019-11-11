using System;

namespace Beispiel_1
{
    class Program
    {
        static void Main(string[] args)
        {                        //1        2       3           4
            string[] wetter = { "Sonne", "Regen", "Wolken", "Sturm" };
            Random rand = new Random();
            int r = rand.Next(1, 4);
            
            switch(r)
            {
                case 1:
                    Console.WriteLine("Es ist Sonnig");

                    break;
                case 2:
                    Console.WriteLine("Wort: Regen ");
                    break;
                case 3:
                    Console.WriteLine("Es ist bewölkt");
                    break;
                case 4:
                    Console.WriteLine("Wort: Sturm");
                    break;
            }

        }
    }
}
