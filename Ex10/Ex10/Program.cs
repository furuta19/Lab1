using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max = 0;

            Console.WriteLine("Ведiть a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведiть b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведiть c");
            c = int.Parse(Console.ReadLine());

            if (max < a)
                max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;

            Console.Write($"Max - {max}");
        }
    }
}
