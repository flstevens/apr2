using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verschieden_Buchstaben
{
    class Program
    {
        static string RemoveSpaces(string satz)
        {
            int posleerzeichen = satz.IndexOf(" ");

            while (posleerzeichen > -1)
            {
                string firstPart = satz.Substring(0, posleerzeichen);
                string secondPart = satz.Substring(posleerzeichen + 1, satz.Length - (posleerzeichen + 1));

                satz = firstPart + secondPart;

                posleerzeichen = satz.IndexOf(" ");
            }

            return satz;
        }


        static void Main(string[] args)
        {
            Console.Write("Gebens sie einen Satz ein: ");
            string satz = "";
            satz = Console.ReadLine();

            string Zeichen = "";
            

            for (int i = 0; i < satz.Length; i++)
            {                              
                string bst = satz.Substring(i, 1);
                if (Zeichen.IndexOf(bst) == -1)
                {
                    Zeichen = Zeichen + bst;                    
                }
                Console.WriteLine(bst);                
            }
            

            Console.WriteLine(Zeichen);
            Console.WriteLine(Zeichen.Length);


            for (int i = 0; i < satz.Length; i++)
            {
                string bst = satz.Substring(i, 1);
                if (Zeichen.IndexOf(bst) == -1)
                {
                    Zeichen = Zeichen + bst;
                }
                Console.WriteLine(bst);
            }

            satz = RemoveSpaces(satz);
            Console.WriteLine(satz);

           
            Console.ReadLine();
        }
    }
}
