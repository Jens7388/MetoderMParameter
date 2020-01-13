using System;
using System.Linq;

namespace Opgave1
{
    class Program
    {
        private static int CalcSum(params int[] numbers)
        {
            return numbers.Sum();
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Hvor mange tal ønsker du at indtaste?: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int numberAmount);
                int[] numberArray = new int[numberAmount];
                for(int i = 0; i < numberAmount; i++)
                {
                    Console.Write($"Indtast {i + 1}. tal: ");
                    input = Console.ReadLine();
                    int.TryParse(input, out numberArray[i]);
                }
                for(int i = 0; i < numberArray.Length; i++)
                {
                    CalcSum(numberArray);
                }
                Console.WriteLine($"Tallenes sum er: {CalcSum(numberArray)}");
                Console.ReadLine();
                Console.Clear();
            }             
        }
    }
}
