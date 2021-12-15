using System;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Quel age avez vous ?");
            age = int.Parse(Console.ReadLine());
            
            if(age >= 18)
            {
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeur.e.");
            }
            else
            {
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur.e.");
            }
        }
    }
}
