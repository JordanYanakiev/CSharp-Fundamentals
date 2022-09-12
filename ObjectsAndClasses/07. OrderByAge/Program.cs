using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split();
            List<Person> persons = new List<Person>();

            while (inputString[0] != "End")
            {
                string name = inputString[0];
                string id = inputString[1];
                int age = int.Parse(inputString[2]);

                Person person = new Person(name, id, age);
                persons.Add(person);
                inputString = Console.ReadLine().Split();
            }

            persons.OrderBy(person => person.Age).ToList().ForEach(person => Console.WriteLine(person));


        }
    }


    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public override string ToString() => ($"{Name} with ID: {ID} is {Age} years old.");
    }

}
