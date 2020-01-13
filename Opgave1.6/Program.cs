using System;

namespace Opgave1._6
{
    class Program
    {
        private static bool ContainsZeros(int[] array, out int zeros)
        {
            zeros = 0;           
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == 0)
                {
                    zeros++;
                }               
            }
            if(zeros > 0)
            {
                Console.WriteLine($"Der er {zeros} 0'er i din talstreng");
                return true; 
            }
            else
            {
                Console.WriteLine("Der er ingen 0'er i din talstreng");
                return false;
            }
        }

        private static void Main()
        {
            while(true)
            {
                Console.Write("Indtast en streng af tal: ");
                string input = Console.ReadLine();
                if(input.Length > 0)
                {
                    int[] numbers = new int[input.Length];
                    for(int i = 0; i < input.Length; i++)
                    {
                        int.TryParse(input.Substring(i, 1), out numbers[i]);
                    }
                    ContainsZeros(numbers, out int zeros);
                }
                else
                {
                    Console.WriteLine("Du skal skrive mindst et tal!");
                }
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
