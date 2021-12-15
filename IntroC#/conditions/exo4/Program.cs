using System;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string login = "login", password = "password";
            string tryLogin, tryPassword;

            Console.WriteLine("Entrez identifiant:");
            tryLogin = Console.ReadLine();
            Console.WriteLine("Entrez mot de passe:");
            tryPassword = Console.ReadLine();

            switch ((tryLogin,tryPassword))
            {
                case (login, password):
                    Console.WriteLine("Bienvenue à la Manu.");
                    break;
                default:
                    Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
                    break;
            }
            
        }
    }
}
