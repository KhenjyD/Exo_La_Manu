using System;

namespace exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastName, firstName, age;

            Console.WriteLine("Quel est votre nom ?");
            lastName = Console.ReadLine();
            Console.WriteLine("Quel est votre prénom ?");
            firstName = Console.ReadLine();
            Console.WriteLine("Quel age avez vous ?");
            age = Console.ReadLine();

            Console.WriteLine("Fiche de renseignement:\n*Nom: " + lastName + "\n*Prénom: " + firstName + "\n*Age: " + age);
        }
    }
}
