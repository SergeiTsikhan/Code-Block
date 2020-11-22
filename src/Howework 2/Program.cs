using System;

namespace Howework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1234.12M;
            var b = 0.0031M;
            Console.WriteLine(a + b);
            double x = 0.123;
            double y = 1234.0000011;
            Console.WriteLine(x + y);
            Console.WriteLine(a);
            Console.WriteLine(x);
            int z = 1;
            Console.WriteLine(z.GetHashCode());
            string aa = "12_3+";
            Console.WriteLine(aa.TrimStart('1','2','3','4').TrimEnd('+'));
            var ll = 'k';
            Console.WriteLine(ll.Equals('1'));

        }
    }
}
