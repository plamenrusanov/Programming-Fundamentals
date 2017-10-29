using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> data = new Dictionary<string, Team>();
            int countOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] creatorTeams = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string creator = creatorTeams[0];
                string team = creatorTeams[1];
                if (!data.ContainsKey(team))
                {
                    if (!IsCreatorContens(data, creator))
                    {
                        data.Add(team, new Team());
                        data[team].TeamName = team;
                        data[team].Creator = creator;
                        data[team].Members = new List<string>();
                        Console.WriteLine($"Team {team} has been created by {creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }                   
                }
                else
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
            }


            string inputMembers = Console.ReadLine();
            while (inputMembers != "end of assignment")
            {
                string[] memberTeam = inputMembers.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string member = memberTeam[0];
                string team = memberTeam[1];
                if (data.ContainsKey(team))
                {
                    if (!IsCreatorContens(data, member))
                    {
                        if (!data.Any(d => d.Value.Members.Contains(member)))
                        {
                            data[team].Members.Add(member);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Member {member} cannot join team {team}!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                inputMembers = Console.ReadLine();
            }
            var result = data.Where(d => d.Value.Members.Count != 0);
            var disband = data.Where(d => d.Value.Members.Count == 0);
            foreach (var item in result.OrderByDescending(i => i.Value.Members.Count).ThenBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"- {item.Value.Creator}");
                foreach (string member in item.Value.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in disband.OrderBy(i => i.Key))
            {
                Console.WriteLine($"{item.Value.TeamName}");
            }
        }

        private static bool IsCreatorContens(Dictionary<string, Team> data, string creator)
        {
            bool isContens = false;
            foreach (var item in data)
            {
                if (item.Value.Creator.Equals(creator))
                {
                    isContens = true;
                }
            }
            return isContens;
        }
    }
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public string Creator { get; set; }
    }
}
