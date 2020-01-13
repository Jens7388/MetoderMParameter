using System;

namespace Opgave1._1
{
    class Program
    {
        private static string Concatenate(params char[] chars)
        {
            string charString = "";
            for(int i = 0; i < chars.Length; i++)
            {
                charString += chars[i].ToString();
            }
            return charString;
        }

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Hvor mange karakterer skal din streng indeholde?");
                string input = Console.ReadLine();
                int.TryParse(input, out int charCount);
                if(charCount > 0)
                {
                    char[] charArray = new char[charCount];
                    for(int i = 0; i < charCount; i++)
                    {
                        Console.Write($"Indtast {i + 1}. karakter: ");
                        input = Console.ReadLine();
                        char.TryParse(input, out charArray[i]);
                    }
                    Console.WriteLine($"Hele din streng:\n{Concatenate(charArray)}");
                }
                else
                {
                    Console.WriteLine("Du skal have mindst 1 karakter!");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
