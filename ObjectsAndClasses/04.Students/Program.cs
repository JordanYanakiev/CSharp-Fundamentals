using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfsudents = int.Parse(Console.ReadLine());
            int counter = 0;
            List<Student> studentsList = new List<Student>();

            while (counter < numberOfsudents)
            {
                List<string> studentInput = Console.ReadLine().Split(" ").ToList();
                var student = new Student(studentInput[0], studentInput[1], float.Parse(studentInput[2]));
                studentsList.Add(student);
                counter++;
            }

            studentsList = studentsList.OrderByDescending(currStudent => currStudent.Grade).ToList();

            studentsList.ForEach(student => Console.WriteLine(student));

        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public Student(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
