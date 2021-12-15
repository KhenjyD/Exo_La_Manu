using System;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 2, c = 3;
            Console.WriteLine("var a = " + a + "\nvar b = " + b +"\nvar c = " + c);
            int res = (a + b) * c;
            Console.WriteLine("resultat (a + b) * c = " + res);
        }
    }
}
