using System;
using System.Collections.Generic;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int res = 1;
            string calcul = "";
            string toAdd;

            Console.WriteLine("Ajouter des nombres à muliplier:");
            toAdd = Console.ReadLine();

            while(toAdd != "stop")
            {
                numbers.Add(int.Parse(toAdd));
                Console.WriteLine("Continuer: (tapez 'stop' pour arreter)");
                toAdd = Console.ReadLine();
            }

            for(int i = 0; i < numbers.Count; i++)
            {
                res *= numbers[i];

                if(i == numbers.Count - 1)
                {
                    calcul += numbers[i];
                }
                else
                {
                    calcul += numbers[i] + " * ";
                }
            }

            Console.WriteLine(calcul + " = " + res);
        }        
    }
}
