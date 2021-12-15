using System;

namespace exo6
{
    class Program
    {
        enum Week { Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche };
        static void Main(string[] args)
        {
            foreach(string day in Enum.GetNames(typeof(Week))){
                Console.WriteLine(day);
            }

            Console.WriteLine("\n" + (Week)4);
        }
    }
}
