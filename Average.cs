using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnterrichtÜbung
{
    internal class Average
    {

        public static void Start()
        {
            double[] eingabewerte = new double[4];
            for (int i = 0; i < eingabewerte.Length; i++)
            {
                bool isValid = false;

                while (!isValid)
                {
                    Console.WriteLine($"Geben Sie den {i + 1}. Wert ein: ");
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out eingabewerte[i]))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe versuchen sie es erneut: ");
                    }
                }
            }

            double sum = 0;

            for (int i = 0; i < eingabewerte.Length;i++)
            {
                sum += eingabewerte[i];
            }

            double average = sum / eingabewerte.Length;

            Console.WriteLine("Der Durchschnitt ist: " + average);

        }
    }
}
