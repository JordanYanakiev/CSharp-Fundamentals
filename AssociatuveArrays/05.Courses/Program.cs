using System;
using System.Collections.Generic;

namespace _05.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(" : ");
            string mainCommand = commands[0];
            string studentName = commands[1];
            List<string> studentsInCourse = new List<string>();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();


            while (mainCommand != "end")
            {
                mainCommand = commands[0];
                studentName = commands[1];

                if (!courses.ContainsKey(mainCommand))
                {
                    courses.Add(mainCommand, new List<string>());
                }

                courses[mainCommand].Add(studentName);

                commands = Console.ReadLine().Split(" : ");
                mainCommand = commands[0];
            }



            //Print Courses and Students
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                for (int i = 0; i < course.Value.Count; i++)
                {
                    Console.WriteLine($"-- {course.Value[i]}");
                }
            }
        }
    }

}
