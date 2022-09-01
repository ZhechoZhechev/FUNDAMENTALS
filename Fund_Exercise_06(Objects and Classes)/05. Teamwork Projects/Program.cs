using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());

            Project project = new Project();

            List<Project> projects = new List<Project>();

            for (int i = 1; i <= teamsCount; i++)
            {
                string[] creatorAndTeamName = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

                string creator = creatorAndTeamName[0];
                string teamName = creatorAndTeamName[1];

                bool IsTheTeamExisting = projects.Any(x => x.TeamName == teamName);
                bool IsCreatorUnique = projects.Any(y => y.Creator == creator);


                project = new Project()
                {
                    Creator = creator,
                    TeamName = teamName
                };
                if (IsTheTeamExisting)
                {
                    Console.WriteLine($"Team {project.TeamName} was already created!");
                }
                else if (IsCreatorUnique)
                {
                    Console.WriteLine($"{project.Creator} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    projects.Add(project);
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] commadns = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                
                string userToJoin = commadns[0];
                string teamToJoin = commadns[1];
                
                bool isTheTeamExisting = projects.Any(x => x.TeamName == teamToJoin);
                bool isUserInATeam = projects.Any(y => y.Members.Contains(userToJoin));

                if (!isTheTeamExisting)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (isUserInATeam)
                {
                    Console.WriteLine($"Member {userToJoin} cannot join team {teamToJoin}!");
                }
                else
                {
                    foreach (var proj in projects)
                    {
                        if (proj.TeamName == teamToJoin && userToJoin != proj.Creator)
                        {
                            proj.Members.Add(userToJoin);
                        }
                    }
                }
            }
            foreach (var pr in projects.OrderByDescending(m => m.Members.Count).ThenBy(t => t.TeamName).Where(m => m.Members.Count > 0))
            {
                pr.Members.Sort();
                Console.WriteLine($"{pr.TeamName}");
                Console.WriteLine($"- {pr.Creator}");
                Console.Write("-- ");
                Console.WriteLine(string.Join("\r\n-- ", pr.Members));
            }

            Console.WriteLine("Teams to disband:");
            foreach (var pr in projects.OrderBy(t => t.TeamName).Where(m => m.Members.Count < 1))
            {
                Console.WriteLine($"{pr.TeamName}");
            }
        }
    }

    class Project
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }

        public List<string> Members = new List<string>();

        public override string ToString()
        {
            return $"{TeamName} {Creator}";
        }
    }
}
