using System;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Entrez un entier 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez un entier 2: ");
            b = int.Parse(Console.ReadLine());

            a += 33;
            b++;

            int res = a / b;

            Console.WriteLine("le resultat est " + res);
        }
    }
}
