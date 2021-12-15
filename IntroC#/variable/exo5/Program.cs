using System;

namespace exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, date;
          
            Console.WriteLine("Quel est votre nom ?");
            lastName = Console.ReadLine();
            Console.WriteLine("Quel est votre prénom ?");
            firstName = Console.ReadLine();
            date = DateTime.Now.ToShortDateString();

            Console.WriteLine("Bonjour " + lastName + " " + firstName + ", nous sommes le " + date + ", comment allez-vous ?");
        }
    }
}
