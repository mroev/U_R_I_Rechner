using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Program
    {
        static void Main()
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 3 ein:");
                Console.WriteLine("1 = Strom berechnen");
                Console.WriteLine("2 = Spannung berechnen");
                Console.WriteLine("3 = Widerstand berechnen");
                Console.WriteLine("4 = Beenden");
                Console.Write("Ihre Eingabe: ");

                int zahl = int.Parse(Console.ReadLine());
                double u;
                double r;
                double i;

                switch (zahl)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Sie haben Strom berechnen gewählt");
                        Console.Write("Widerstand eingeben: ");
                        string widerstandEingabe1 = Console.ReadLine();
                        if (double.TryParse(widerstandEingabe1, out r))
                        {
                            Console.Write("Spannung eingeben: ");
                            string spannungEingabe1 = Console.ReadLine();
                            if (double.TryParse(spannungEingabe1, out u))
                            {
                                Console.WriteLine("Der Strom beträgt: " + u / r + " Ampere");
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe für die Spannung.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe für den Widerstand.");
                        }

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Sie haben Spannung berechnen gewählt");
                        Console.Write("Widerstand eingeben: ");
                        string widerstandEingabe2 = Console.ReadLine();
                        if (double.TryParse(widerstandEingabe2, out r))
                        {
                            Console.Write("Strom eingeben: ");
                            string stromEingabe2 = Console.ReadLine();
                            if (double.TryParse(stromEingabe2, out i))
                            {
                                Console.WriteLine("Die Spannung beträgt: " + i * r + " Volt");
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe für den Strom.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe für den Widerstand.");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Sie haben Widerstand berechnen gewählt");
                        Console.Write("Spannung eingeben: ");
                        string spannungEingabe3 = Console.ReadLine();
                        if (double.TryParse(spannungEingabe3, out u))
                        {
                            Console.Write("Strom eingeben: ");
                            string stromEingabe3 = Console.ReadLine();
                            if (double.TryParse(stromEingabe3, out i))
                            {
                                Console.WriteLine("Der Widerstand beträgt: " + u / i + " Ohm");
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe für den Strom.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe für die Spannung.");
                        }
                        break;
                    case 4:
                        continueProgram = false;
                        Environment.Exit(0);
                        Console.WriteLine("Beliebige Taste drücken zum beenden");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Die Zahl sollte zwischen 1 und 4 liegen.");
                        break;
                }

                Console.WriteLine();
                Console.Write("Möchten Sie eine weitere Berechnung durchführen? (y/n): ");
                string continueInput = Console.ReadLine();
                if (continueInput.ToLower() != "y")
                {
                    continueProgram = false;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}