using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;

            Console.WriteLine("Ведiть порядковий номер дня");
            day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедiлок");
                    break;
                case 2:
                    Console.WriteLine("Вiвторок");
                    break;
                case 3:
                    Console.WriteLine("Середа");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("П'ятница");
                    break;
                case 6:
                    Console.WriteLine("Субота");
                    break;
                case 7:
                    Console.WriteLine("Недiля");
                    break;
                default:
                    Console.WriteLine("Not valid");
                    break;
            }
        }
    }
}
