using System;

namespace Opgave1._2
{
    class Program
    {
        private static string Concatenate(params string[] strings)
        {
            string stringOfStrings = "";
            for(int i = 0; i < strings.Length; i++)
            {
                stringOfStrings += strings[i] + " ";
            }
            return stringOfStrings;
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Hvor mange stregne ønsker du at skrive?");
                string input = Console.ReadLine();
                int.TryParse(input, out int stringCount);
                if(stringCount > 0)
                {
                    string[] stringArray = new string[stringCount];
                    for(int i = 0; i < stringCount; i++)
                    {
                        Console.Write($"Indtast {i + 1}. streng: ");
                        stringArray[i] = Console.ReadLine();
                    }
                    Console.WriteLine($"Samlet streng: {Concatenate(stringArray)}");
                }
                else
                {
                    Console.WriteLine("Du skal indtaste mindst 1 streng!");
                }
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
