using System;

namespace Class_and_OOPs
{
    public class Student {
        public string name;
        public int age;
        public int semester;
        public int cgpa;

        public Student(string name, int age, int sem, int cgpa) {
            this.name = name;
            this.age = age;
            this.semester = sem;
            this.cgpa = cgpa;
        }

        public void print() {
            Console.WriteLine($"Name : {this.name} Age: {this.age} Semester: {this.semester} CGPA: {this.cgpa}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var S1 = new Student("Aditya", 19, 4, 8);
            var S2 = new Student("Amit", 20, 4, 9);
            S1.print();
            S2.print();
        }
    }
}
