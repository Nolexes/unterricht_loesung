using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnterrichtÜbung
{
    internal class Lieferant
    {
        public static void Start()
        {
            double lp = 0;
            double lr = 0;


            bool isValid1 = false;
            bool isValid2 = false;


            while (!isValid1)
            {
                Console.Write("Gebe den Listenpreis ein: ");
                string input1text = Console.ReadLine();

                if (double.TryParse(input1text, out lp))
                {
                    isValid1 = true;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe versuche es erneut");
                }
            }

            while (!isValid2)
            {
                Console.Write("Gebe den Lieferantenrabatt ein: ");
                string input2text = Console.ReadLine();

                if (double.TryParse(input2text, out lr))
                {
                    isValid2 = true;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe versuche es erneut");
                }
            }

            double endwert = (lp / 100d) * (100d - lr);

            Console.WriteLine("Der Einkaufspreis beträgt: " +endwert);
        }
    }
}
