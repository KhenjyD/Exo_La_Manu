using System;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender;
            int age;

            Console.WriteLine("Quel est votre sexe ? (H = Homme, F = Femme)");
            gender = Console.ReadLine();
            Console.WriteLine("Quel est votre age ?");
            age = int.Parse(Console.ReadLine());

            if (age >= 18 && gender == "H")
            {
                Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
            }
            else if (age < 18 && gender == "H")
            {
                Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
            }
            else if (age >= 18 && gender == "F")
            {
                Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
            }
            else if (age < 18 && gender == "F")
            {
                Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
            }
        }
    }
}
