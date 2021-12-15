using System;
using System.Collections.Generic;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 8, 2, 7, 4, 7, 3 };
            int res = 0;
            string calcul = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                res += numbers[i];

                if(i == numbers.Count-1)
                {
                    calcul += numbers[i]; 
                } 
                else
                {
                    calcul += numbers[i] + " + ";
                }  
            }

            Console.WriteLine(calcul + " = " + res);
        }
    }
}
