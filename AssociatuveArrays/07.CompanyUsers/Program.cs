using System;
using System.Collections.Generic;

namespace _07.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStringArr = Console.ReadLine().Split(" -> ");
            string companyName = inputStringArr[0];
            string id = inputStringArr[1];
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();

            while (companyName != "End")
            {
                id = inputStringArr[1];

                if (!companyEmployees.ContainsKey(companyName))
                {
                    companyEmployees.Add(companyName, new List<string>());
                }
                if (!companyEmployees[companyName].Contains(id))
                {
                    companyEmployees[companyName].Add(id);
                }

                inputStringArr = Console.ReadLine().Split(" -> ");
                companyName = inputStringArr[0];
            }


            foreach (var company in companyEmployees)
            {
                Console.WriteLine(company.Key);

                for (int i = 0; i < company.Value.Count; i++)
                {
                    Console.WriteLine($"-- {company.Value[i]}");
                }
            }

        }
    }
}
