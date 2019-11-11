using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokepro
{
    class Program
    {
        


        static void Main(string[] args)
        {
           
                int hpwild = 10;
            int hpdu = 10;
            string eingabe = "";
            int tackle = 2;
            int schlitzer = 4;

            Console.WriteLine("Ein Wildes Pokemon erscheint");
            Console.WriteLine("Du setzt dein Pokemon ein");
            Console.WriteLine();

            while (hpwild > 0 && eingabe != "f"
                )
                {
            

            Console.WriteLine("Was willst du tun?");
            Console.Write("Angriff(a) oder Flucht(f): ");
            eingabe = Console.ReadLine();

            
                //Angriff oder Flucht                         
                switch (eingabe)
                {


                        //Angriff
                        case "a":
                        Console.WriteLine("Welche Attacke soll dein Pokemon einsetzen?");
                        Console.Write("Tackle(1)  Schlitzer(2):");


                        //Atacken
                        
                        eingabe = Console.ReadLine();
                        
                        if (eingabe == "1")
                        {
                            Console.WriteLine("Dein Pokemon setzt Tackle ein und macht dem Wilden Pokemon {0} Schaden", tackle);
                            hpwild = hpwild - tackle;
                            Console.WriteLine("Der Gegner hat noch {0} Lebenspunkte un dein Pokemon noch {1}", hpwild, hpdu);

                        }


                        else
                        {
                            Console.WriteLine("Dein Pokemon setzt Schlitzer ein und macht dem Wilden Pokemon {0} Schaden", schlitzer);
                            hpwild = hpwild - schlitzer;
                    
                            Console.WriteLine("Der Gegner hat noch {0} Lebenspunkte un dein Pokemon noch {1}", hpwild, hpdu);
                            

                        }

                        break;

                        //Flucht
                        case "f":
                        Console.WriteLine("Du bist entkommen");
                        Console.ReadLine();
                                                
                        break;

                }
                                               
            }

            if (hpwild == 0)
            {
                Console.WriteLine("Du hast das Wildepokemon besiegt");
                Console.ReadLine();
            }

        }
    }
}
