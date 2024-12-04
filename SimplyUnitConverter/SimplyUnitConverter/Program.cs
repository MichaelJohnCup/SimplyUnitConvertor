// See https://aka.ms/new-console-template for more information
using System;
class SimplyUnitConvertor
{
    static void Main(String[] args)
    {
        while (true)
        {
            Console.WriteLine("Vyber jednotky pro konverzi");
            Console.WriteLine("1 - Km na Míle");
            Console.WriteLine("2 - Palce na Centimetry");
            Console.WriteLine("3 - Stopy na Centimery");
            Console.WriteLine("4 - Kilogramy na libry");
            String input = Console.ReadLine();

            // User input validate/if

            if (input == "1")
            {
                KMnaMiles();
            }
            else if (input == "2")
            {
                PalceNaCm();
            }
            else if (input == "3")
            {
                StopyNaCm();
            }
            else if (input == "4")
            {
                KgNaLibry();
            }
            else
            {
                Console.WriteLine("Vyber možnost 1 az 4!");
            }
        }
    }
    static void KMnaMiles()
    {
        Console.WriteLine("Vlož počet km: ");
        {
            double km = double.Parse(Console.ReadLine());
            double miles = km * 1.609;
            Console.WriteLine("Výsledek je " + miles +" míle.");
        }
    }
    static void PalceNaCm()
    {
        Console.WriteLine("Vlož počet palců: ");
        {
            double inch = double.Parse(Console.ReadLine());
            double cm = inch * 2.54;
            Console.WriteLine("Výsledek je " + cm + " cm.");
        }
    }
    static void StopyNaCm()
    {
        Console.WriteLine("Vlož počet stop: ");
        {
            double ft = double.Parse(Console.ReadLine());
            double cmft = ft * 30.48;
            Console.WriteLine("Výsledek je " + cmft + " cm.");
        }
    }
    static void KgNaLibry()
    {
        Console.WriteLine("Vlož počet kg: ");
        {
            double kg = double.Parse(Console.ReadLine());
            double pounds = kg * 1.45359237;
            Console.WriteLine("Výsledek je " + pounds + " liber.");
        }
    }
}





