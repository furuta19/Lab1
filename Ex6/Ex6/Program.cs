using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, h, Area;

            Console.WriteLine("Ведiть а");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ведiть b");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Ведiть h");
            h = float.Parse(Console.ReadLine());

            Area = ((a + b) / 2) * h;
            Console.WriteLine($"Площа  {Area}");
        }
    }
}
