﻿using System;
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
            double[] eingabewerte = new double[4]; //Zum erstellen eines leeren Arrays aus Doubles mit 4 Platzhaltern
            for (int i = 0; i < eingabewerte.Length; i++) // Der Loop läuft so Lange bis jede Stelle des Arrays einmal durchgegangen wurde
            {
                bool isValid = false; //Wird benutzt um die Eingabe so lange zu wiederholen bis eine gültige Zahl ist

                while (!isValid)
                {
                    Console.WriteLine($"Geben Sie den {i + 1}. Wert ein: "); // Eingabeaufforderung
                    string input = Console.ReadLine(); //Input wird erstmal als String ausgelesen
                    if (double.TryParse(input, out eingabewerte[i])) // und hier als Loopbedingung in die Stelle i des Arrays eingetragen falls möglich
                    {
                        isValid = true; // um den Loop zu stoppen bei gültiger Eingabe
                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe versuchen sie es erneut: "); //Falls keine gültige Eingabe erfolg geben wir dies aus und Starten nochmal die Abfrage
                    }
                }
            }

            double average = eingabewerte.Sum() / eingabewerte.Length; // Rechnung um die Summe aller Zahlen im Array durch die Anzahl der Zahlen im Array zu teilen

            Console.WriteLine("Der Durchschnitt ist: " + average);

        }
    }
}
