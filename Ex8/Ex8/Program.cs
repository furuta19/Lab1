using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double number, nDigit;
            int n;

            Console.WriteLine("Ведiть число");
            number = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведiть порядковий номер цифри числа");
            n = int.Parse(Console.ReadLine());

            nDigit = ((number / Math.Pow(10, n - 1)) % 10.0d);
            Console.Write($"Результат - {Math.Truncate(nDigit)}");
        }
    }
}
