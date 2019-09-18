using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n0 = -100; //-128 до 127
            byte n1 = 128;  //0 до 255
            short n2 = -3540;  //32768 до 32767
            ushort n3 = 64876;  //0 до 65535
            uint n4 = 2147483148; //0 до 4294967295
            int n5 = -1141583228; //2147483468 до 2147483467
            long n6 = -1223372036854775808;  //-9223372036854775808 до 9223372036854775807

            Console.WriteLine($" {n0} \n {n1} \n {n2} \n {n3} \n {n4} \n {n5} \n {n6}");
        }
    }
}
