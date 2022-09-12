using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            string student = null;
            double grade = 0;
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            Dictionary<string, double> sortedStudents = new Dictionary<string, double>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                student = Console.ReadLine();
                grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<double>());
                }

                students[student].Add(grade);

            }


            //Get average scores

            foreach (var studente in students)
            {
                double average = studente.Value.Average();

                if (average >= 4.5)
                {
                    sortedStudents.Add(studente.Key, average);
                }
            }


            foreach (var sortedStudent in sortedStudents)
            {
                Console.WriteLine($"{sortedStudent.Key} -> {sortedStudent.Value:F2}");
            }



        }
    }
}
