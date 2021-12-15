using System;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string add;

            Console.WriteLine("Entrez un nombre à additionner");
            add = Console.ReadLine();

            while(add != "non")
            {
                result += int.Parse(add);
                Console.WriteLine("Entrez une valeur à ajouter: (tapez 'non' pour arreter)");
                add = Console.ReadLine();
            }

            Console.WriteLine("le resultat est " + result);
        }
    }
}
