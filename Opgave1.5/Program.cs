using System;

namespace Opgave1._5
{
    class Program
    {
        private static void AddVat(ref double amount)
        {
            amount *= 1.25;
            Console.WriteLine($"Dit beløb inklusiv moms: {amount}");
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Indtast et beløb: ");
                string input = Console.ReadLine();
                double.TryParse(input, out double amount);
                if(amount > 0)
                {
                    AddVat(ref amount);
                }
                else
                {
                    Console.WriteLine("Beløbet skal være større end 0!");
                }
                Console.ReadLine();
                Console.Clear();
            }         
        }
    }
}
