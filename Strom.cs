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
            int volt = 0;
            int ampere = 0;


            bool isValid1 = false;
            bool isValid2 = false;


            while (!isValid1)
            {
                Console.Write("Gebe die Spannung U in Volt an: ");
                string input1text = Console.ReadLine();

                if (int.TryParse(input1text, out volt))
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
                Console.Write("Gebe Stromstärke I in Ampere an: ");
                string input2text = Console.ReadLine();

                if (int.TryParse(input2text, out ampere))
                {
                    isValid2 = true;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe versuche es erneut");
                }
            }

            int ohm = volt / ampere;
            int watt = volt * ampere;

            Console.WriteLine($"Der Stromwiederstand R in Ohm beträgt: {ohm}");
            Console.WriteLine($"Die elektrische Leistung P in Watt beträgt: {watt}");
        }

    }
}
