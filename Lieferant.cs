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
            double lp = 0; //platzhalter für den listenpreis
            double lr = 0; // platzhalter für den lieferrabatt


            bool isValid1 = false; //bedingungen für die beiden loops
            bool isValid2 = false; 


            while (!isValid1)
            {
                Console.Write("Gebe den Listenpreis ein: "); //Eingabeaufforderung
                string input1text = Console.ReadLine(); //Auslesen der Eingabe

                if (double.TryParse(input1text, out lp)) //Hier wird Versucht den Input als Double zu konvertieren falls möglich stoppt der Loop falls springen wir zurück zur Eingabeaufforderung
                {
                    isValid1 = true; //Stopt den loop
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe versuche es erneut"); //Falls Eingabe ungültig ist
                }
            }

            while (!isValid2)
            {
                Console.Write("Gebe den Lieferantenrabatt ein: ");
                string input2text = Console.ReadLine();

                if (double.TryParse(input2text, out lr))        //Genau das Gleiche wie oben nochmal in loop form
                {
                    isValid2 = true;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe versuche es erneut");
                }
            }

            double endwert = (lp / 100d) * (100d - lr); // Rechnung des Ausgabewertes (Listenpreis/100) * (100-lieferrabatt in prozent)

            Console.WriteLine("Der Einkaufspreis beträgt: " +endwert);
        }
    }
}
