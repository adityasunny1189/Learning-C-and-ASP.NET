﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            // var grade = new List<int>() {20, 22, 21, 24, 25};
            // int finalGrade = 0;
            // grade.Add(20);
            // foreach(var number in grade) {
            //     finalGrade += number;
            // }
            // Console.WriteLine($"Final grade total is: {finalGrade}");
            // double avgGrade = finalGrade / grade.Count;
            // Console.WriteLine($"Avg grade is: {avgGrade}");
            
            // int x = 23;
            // int y = 45;
            // int ans = x + y;
            // int result = 0;
            // int[] arr = new int[] {2, 3, 4};
            // foreach(int num in arr) {
            //     result += num;
            // }
            // Console.WriteLine(result);
            // Console.WriteLine($"The sum of {x} and {y} is: {ans}");
            // if(args.Length > 0) {
            //     Console.WriteLine("Hello " + args[0] + "!");
            // } else {
            //     Console.WriteLine("Hello");
            // }

            // Console.WriteLine("Enter the Number: ");
            // string input = Console.ReadLine();
            // Console.WriteLine($"The Entered no is: {input}");
            // int num = Convert.ToInt32(input);
            // num *= 2;
            // Console.WriteLine($"The New Result is: {num}");

            // int result = 0;
            // for (int i = 0; i < 20; i++)
            // {
            //     if(i % 3 == 0) {
            //         result += i;
            //     }
            // }
            // Console.WriteLine(result);

            //Calculator
            int no1 = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());
            char choice = Convert.ToChar(Console.ReadLine());
            int res = 0;
            switch(choice) {
                case '+': res = no1 + no2; break;
                case '-': res = no1 - no2; break;
                case '*': res = no1 * no2; break;
                case '/': res = no1 / no2; break;
            }
            Console.WriteLine($"The Final Result is: {res}");
        }
    }
}
