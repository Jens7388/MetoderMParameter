using Microsoft.CodeAnalysis;
using System;

namespace Opgave1._3
{
    class Program
    {
        private static void PrintWelcome(string optional = "da")
        {
            if(optional == "eng")
            {
                Console.WriteLine("Hello world!");
            }
            else if(optional == "da")
            {
                Console.WriteLine("Hej verden!");
            }
            else if(optional == "fra")
            {
                Console.WriteLine("Bonjour le monde!");
            }
            else if(optional == "deu")
            {
                Console.WriteLine("Hallo welt!");
            }
            else if(optional == "ita")
            {
                Console.WriteLine("Ciao mondo!");
            }
            else
            {
                Console.WriteLine("Ugyldigt sprog! Prøv igen.");
            }
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Vælg et af følgende sprog:");
                Console.WriteLine("ENG");
                Console.WriteLine("DA");
                Console.WriteLine("FRA");
                Console.WriteLine("DEU");
                Console.WriteLine("ITA");
                string input = Console.ReadLine().ToLower();
                PrintWelcome(input);
                Console.ReadLine();
                Console.Clear();
            }          
        }
    }
}
