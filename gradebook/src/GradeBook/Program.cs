using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 23;
            int y = 45;
            int ans = x + y;
            Console.WriteLine($"The sum of {x} and {y} is: {ans}");
            if(args.Length > 0) {
                Console.WriteLine("Hello " + args[0] + "!");
            } else {
                Console.WriteLine("Hello");
            }
        }
    }
}
