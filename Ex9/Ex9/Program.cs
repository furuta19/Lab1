using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Ведіть число");
            number = int.Parse(Console.ReadLine());
            if (number % 9 == 0 || number % 11 == 0 || number % 13 == 0)
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }
        }
    }
}
