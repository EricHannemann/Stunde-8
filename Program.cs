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
                        zahlA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Zahl b:");
                        zahlB = Convert.ToInt32(Console.ReadLine());

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
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Geben Sie b ein: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Geben Sie c ein: ");
                        int c = Convert.ToInt32(Console.ReadLine());


                        break;

                    case 4:

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
