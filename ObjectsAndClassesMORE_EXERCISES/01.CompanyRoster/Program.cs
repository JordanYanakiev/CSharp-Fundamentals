using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int counter = 0;
            string name = null;
            float sallary = 0;
            string department = null;
            List<Employee> employeesList = new List<Employee>();

            for (int j = 0; j < numberOfInputs; j++) 
            {
                string[] inputStr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                name = inputStr[0];
                sallary = float.Parse(inputStr[1]);
                department = inputStr[2];
                
                Employee newEmployee = new Employee(name, sallary, department);
                employeesList.Add(newEmployee);
                counter++;
            }

        var someList = employeesList.GroupBy(employe => employe.Department).Select(g => new { Level = g.Key, Avg = g.Average(employe => employe.Salary) }).OrderByDescending(x => x.Avg).ToList();
            employeesList = employeesList.OrderByDescending(em => em.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {someList[0].Level}");
            for (int i = 0; i < employeesList.Count(); i++)
            {
                if (employeesList[i].Department == someList[0].Level)
                Console.WriteLine(employeesList[i]);
            }
        }
    }


    class Employee
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, float salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public override string ToString()
        {
            return $"{Name} {Salary:F2}";
        }

    }
}
