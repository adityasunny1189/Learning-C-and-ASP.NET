using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var grade = new List<int>() {20, 22, 21, 24, 25};
            int finalGrade = 0;
            grade.Add(20);
            foreach(var number in grade) {
                finalGrade += number;
            }
            Console.WriteLine($"Final grade total is: {finalGrade}");
            double avgGrade = finalGrade / grade.Count;
            Console.WriteLine($"Avg grade is: {avgGrade}");
            
            int x = 23;
            int y = 45;
            int ans = x + y;
            int result = 0;
            int[] arr = new int[] {2, 3, 4};
            foreach(int num in arr) {
                result += num;
            }
            Console.WriteLine(result);
            Console.WriteLine($"The sum of {x} and {y} is: {ans}");
            if(args.Length > 0) {
                Console.WriteLine("Hello " + args[0] + "!");
            } else {
                Console.WriteLine("Hello");
            }
        }
    }
}
