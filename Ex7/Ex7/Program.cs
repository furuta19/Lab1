using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, lastDigit;

            Console.WriteLine("Ведiть n");
            n = int.Parse(Console.ReadLine());

            lastDigit = n % 10;
            Console.Write($"lastDigit \n{lastDigit}");
        }
    }
}
