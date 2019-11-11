using System;

namespace Beispiel_2
{
    class Program
    {
        static void Main(string[] args)
        {
           int zahl = 543;

           
            for (int i = 0; i < 3; i++)
            {
                string z = Convert.ToString(zahl);
                z = z.Substring(i,1);
                
                if (z > 8)
                {

                }
            }
               
                

            
        }
    }
}
