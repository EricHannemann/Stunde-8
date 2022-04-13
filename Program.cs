using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stunde 8");

            // Menü:

            string wiederholen = "";
            int auswahl;
            do
            {
                Console.WriteLine("1- Summe von 1/a und 1/b berechnen.");
                Console.WriteLine("2- Grenzen");
                Console.WriteLine("3- Nullstellen einer quadratischer Funtion.");
                Console.WriteLine("4- Palyndrom.");
                Console.WriteLine("5- beenden.");

                auswahl = Convert.ToInt32(Console.ReadLine());
                switch (auswahl)
                {
                    case 1:
                        double zahlA;
                        double zahlB;
                        double ergebnis;

                        Console.WriteLine("Zahl a:");
                        zahlA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Zahl b:");
                        zahlB = Convert.ToDouble(Console.ReadLine());

                        double bruchA = 1 / zahlA;
                        double bruchB = 1 / zahlB;

                        ergebnis = bruchA + bruchB;
                        Console.WriteLine("Ergebnis: " + ergebnis);

                        break;

                    case 2:

                        Console.WriteLine("Geben Sie eine ganze Zahl ein:");
                        string eingabe = Console.ReadLine();
                        string ersatz = "--4--";

                        for (int i = 1; i <= Convert.ToInt32(eingabe); i++)
                        {
                            if (i % 4 == 0)
                            {
                                Console.WriteLine(ersatz);
                            }
                            else if(i.ToString().Contains('4'))
                            {
                                Console.WriteLine(ersatz);
                            }
                            else
                            {
                                Console.WriteLine(i);
                            }

                        }

                        break;

                    case 3:
                        Console.WriteLine("Geben Sie a ein: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Geben Sie b ein: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Geben Sie c ein: ");
                        double c = Convert.ToDouble(Console.ReadLine());

                        double nullstelle1;
                        double nullstelle2;
                        double delta = Math.Pow(b, 2) - (4 * a * c);
                        
                        if (delta < 0)
                        {
                            Console.WriteLine("Das Ergebnis ist eine komplexe Zahl.");
                        }

                        else
                        {
                            nullstelle1 = (-b + Math.Sqrt(delta)) / (2 * a);
                            nullstelle2 = (-b - Math.Sqrt(delta)) / (2 * a);
                            Console.WriteLine("Nullstele 1: " + nullstelle1);
                            Console.WriteLine("Nullstele 2: " + nullstelle2);
                        }


                        break;

                    case 4:

                        Console.WriteLine("Geben Sie eine Zeichenkette ein: ");
                        string zeichenkette = Console.ReadLine();
                        string zeichenketteRev = "";

                        for(int k = zeichenkette.Length; k > 0;) ////////////////

                        //for (int k = 0; k < zeichenkette.Length ; k++)
                        //{
                        //    Console.WriteLine(zeichenkette[k]);

                        //    if(zeichenkette[k] == zeichenkette[zeichenkette.Length - k])
                        //    {
                        //        Console.WriteLine("Palindrom");
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("nicht palindrom.");
                        //    }

                        //}

                        break;

                    default:

                        break;

                }

                Console.WriteLine("Neue auswahl? (j/n) ");
                wiederholen = Console.ReadLine();
            } while (wiederholen == "j" || wiederholen == "J");
        }
    }
}
