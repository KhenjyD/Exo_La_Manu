using System;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randNumber = rnd.Next(1, 50);
            int answer;
            int tried = 0;
            Console.WriteLine("Devinez le nombre: (entre 1 et 50)");
            answer = int.Parse(Console.ReadLine());
            tried++;

            while(answer != randNumber)
            {
                if(answer < randNumber)
                {
                    Console.WriteLine("C'est plus grand");
                }
                else
                {
                    Console.WriteLine("C'est plus petit");
                }
                tried++;
                answer = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vous avez trouvez le nombre en " + tried + " essais !");
        }
    }
}
