using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnterrichtÜbung
{
    internal class Strom
    {
        public static void Start() 
        {
            int volt = 0; //erstellen von platzhaltern für die Einheiten
            int ampere = 0;


            bool isValid1 = false; // Bedingungen für die Loops
            bool isValid2 = false;


            while (!isValid1) //Loop läuft so lange bis isValid true ist
            {
                Console.Write("Gebe die Spannung U in Volt an: "); //Eingabeaufforderung
                string input1text = Console.ReadLine(); //Input wird in String übertragen

                if (int.TryParse(input1text, out volt)) //Versuch der Umwandlung in eine int 
                {
                    isValid1 = true; //Falls es funktioniert stopt der Loop
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe versuche es erneut"); //Falls es nicht funktioniert Fehlermeldung und der Loop springt wieder zur Eingabeaufforderung
                }
            }

            while (!isValid2)
            {
                Console.Write("Gebe Stromstärke I in Ampere an: ");
                string input2text = Console.ReadLine();

                if (int.TryParse(input2text, out ampere))
                {
                    isValid2 = true;            //Kopie des gleichen loops
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe versuche es erneut");
                }
            }

            int ohm = volt / ampere; //berechnung der Ohm
            int watt = volt * ampere; //Berechnung der Watt

            Console.WriteLine($"Der Stromwiederstand R in Ohm beträgt: {ohm}");
            Console.WriteLine($"Die elektrische Leistung P in Watt beträgt: {watt}");
        }

    }
}
