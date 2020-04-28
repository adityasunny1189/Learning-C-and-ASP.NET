using System;

namespace PassingPara
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            getValue(out a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            passByRef(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void getValue(out int a, out int b) {
            a = 5;
            b = 10;
        }

        static void passByRef(ref int a, ref int b) {
            a++;
            b++;
        }
    }
}
