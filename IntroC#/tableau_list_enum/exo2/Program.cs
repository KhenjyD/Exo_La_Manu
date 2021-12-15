using System;
using System.Collections.Generic;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> languages = new List<string>{ "HTML", "CSS", "Javascrit", "jQuerry", "PHP", "Bootstrap", "Java" };
            foreach(string lang in languages)
            {
                Console.WriteLine(lang);
            }
            Console.WriteLine("\n");
            Console.WriteLine(languages[3]);
            Console.WriteLine(languages[4]);

            languages.Remove("Bootstrap");
            languages[2] = "Javascript";
            languages.Add("C");

            Console.WriteLine("\n");
            foreach (string lang in languages)
            {
                Console.WriteLine(lang);
            }
        }
    }
}
