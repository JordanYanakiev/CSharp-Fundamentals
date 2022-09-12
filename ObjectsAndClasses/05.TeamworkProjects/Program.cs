using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<string> creators = new List<string>();
            List<string> teamMembers = new List<string>();
            List<Team> teams = new List<Team>();


            //Create teams
            for (int i = 0; i < numberOfTeams; i++)
            {
                creators = Console.ReadLine().Split("-").ToList();

                if (!teams.Any(teams => teams.Name.Contains(creators[1].Trim())) && !teams.Any(teams => teams.Creator.Contains(creators[0].Trim())))
                {
                    Team team01 = new Team();
                    team01.Name = creators[1];
                    team01.Creator = creators[0];
                    team01.Members = new List<string>();
                    //team01.Members.Add(creators[0]);
                    teams.Add(team01);
                    Console.WriteLine($"Team {creators[1].Trim()} has been created by {creators[0].Trim()}!");
                }
                else if (teams.Any(teams => teams.Creator.Contains(creators[0].Trim())))
                {
                    Console.WriteLine($"{creators[0].Trim()} cannot create another team!");
                    //i--;
                }
                else if (teams.Any(teams => teams.Name.Contains(creators[1].Trim())))
                {
                    Console.WriteLine($"Team {creators[1].Trim()} was already created!");
                }
            }

            //Add members
            teamMembers = Console.ReadLine().Split(new string[] { "->" }, StringSplitOptions.None).ToList();
            while (teamMembers[0] != "end of assignment")
            {

                if (!teams.Any(teams => teams.Name.Contains(teamMembers[1].Trim())))
                {
                    Console.WriteLine($"Team {teamMembers[1].Trim()} does not exist!");
                }

                if (!teams.Any(teams => teams.Creator == teamMembers[0]))
                {
                    if (teams.Any(teams => teams.Name.Contains(teamMembers[1].Trim()))
                        && (!teams.Any(teams => teams.Members.Contains(teamMembers[0].Trim()))) && (teams.Any(teams => teams.Creator != teamMembers[0].Trim())))
                    {
                        var currentTeam = teams.Find(team => team.Name == teamMembers[1].Trim());
                        currentTeam.Members.Add(teamMembers[0].Trim());
                    }
                    else if ((teams.Any(teams => teams.Creator == teamMembers[0].Trim())) || (teams.Any(teams => teams.Members.Contains(teamMembers[0].Trim())))
                       || (teams.Any(teams => teams.Creator == teamMembers[0].Trim())))
                    {
                        Console.WriteLine($"Member {teamMembers[0].Trim()} cannot join team {teamMembers[1].Trim()}!");
                    }
                }
                else if ((teams.Any(teams => teams.Creator == teamMembers[0].Trim())))
                {
                    Console.WriteLine($"Member {teamMembers[0].Trim()} cannot join team {teamMembers[1].Trim()}!");
                }


                teamMembers = Console.ReadLine().Split("->").ToList();
            }

            //Disband teams with only 1 member
            var completedTeams = teams.Where(x => x.Members.Count > 0);
            var disbandedTeams = teams.Where(x => x.Members.Count == 0);


            foreach (var team in completedTeams.OrderByDescending(x => x.Members.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.Creator);
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine("-- " + member);
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandedTeams.OrderByDescending(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }

        }
    }

    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }


}
