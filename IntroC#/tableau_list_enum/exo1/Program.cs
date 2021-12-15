using System;

namespace exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"};
            Console.WriteLine("Indice 1: " + days[1]);
            Console.WriteLine("Indice 4: " + days[4]);

            Console.WriteLine("1er élément: " + days[0]);
            Console.WriteLine("4e élément: " + days[3]);


            for(int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        }
    }
}
