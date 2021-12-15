using System;

namespace exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            string month;

            Console.WriteLine("Chosissez un mois:");
            month = Console.ReadLine();

            switch (month)
            {
                case "novembre":
                    Console.WriteLine("La saison du mois saisi est l'HIVER.");
                    break;
                case "decembre":
                    Console.WriteLine("La saison du mois saisi est l'HIVER.");
                    break;
                case "janvier":
                    Console.WriteLine("La saison du mois saisi est l'HIVER.");
                    break;
                case "fevrier":
                    Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
                    break;
                case "mars":
                    Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
                    break;
                case "avril":
                    Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
                    break;
                case "mai":
                    Console.WriteLine("La saison du mois saisi est l'ETE.");
                    break;
                case "juin":
                    Console.WriteLine("La saison du mois saisi est l'ETE.");
                    break;
                case "juillet":
                    Console.WriteLine("La saison du mois saisi est l'ETE.");
                    break;
                case "aout":
                    Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
                    break;
                case "septembre":
                    Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
                    break;
                case "octobre":
                    Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
                    break;
                default:
                    Console.WriteLine("Ce n'est pas un mois.");
                    break;
            }
        }
    }
}
