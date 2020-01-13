using System;
using System.Linq;

namespace Opgave1._4
{
    class Program
    {
        private static void SetFirstCharToUpper(ref string input)
        {
            Console.WriteLine(input.First().ToString().ToUpper() + input.Substring(1));
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Indtast en streng. Første bogstav bliver derefter stort: ");
                string input = Console.ReadLine();
                if(input.Length > 0)
                {
                    SetFirstCharToUpper(ref input);
                }
                else
                {
                    Console.WriteLine("Strengen må ikke være tom!");
                }
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
