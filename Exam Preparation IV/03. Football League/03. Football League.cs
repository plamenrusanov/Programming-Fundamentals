using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string escapedKey = Regex.Escape(key);    
            string p = @"{\d}";
            string pattern = Regex.Replace(@"(?<={0})(?<teamA>[a-zA-Z]*)(?={0}).*(?<={0})(?<teamB>[a-zA-Z]*)(?={0})[^ ]+ (?<scoreA>[\d]+):(?<scoreB>[\d]+)",p,escapedKey);
            string input = Console.ReadLine();
            var stand = new Dictionary<string, long>();
            var scored = new Dictionary<string, long>();
            while (input != "final")
            {
                Match game = Regex.Match(input, pattern);
                string teamA = game.Groups["teamA"].Value;
                teamA = Reverse(teamA);
                string teamB = game.Groups["teamB"].Value;
                teamB = Reverse(teamB);
                long scoreA = long.Parse(game.Groups["scoreA"].Value);
                long scoreB = long.Parse(game.Groups["scoreB"].Value);

                if (scoreA > scoreB)
                {
                    if (!stand.ContainsKey(teamA))
                    {
                        stand.Add(teamA, 0);
                    }
                    stand[teamA] += 3;
                    if (!stand.ContainsKey(teamB))
                    {
                        stand.Add(teamB, 0);
                    }
                }
                else if (scoreB > scoreA)
                {
                    if (!stand.ContainsKey(teamB))
                    {
                        stand.Add(teamB, 0);
                    }
                    stand[teamB] += 3;
                    if (!stand.ContainsKey(teamA))
                    {
                        stand.Add(teamA, 0);
                    }
                }
                else if (scoreA == scoreB)
                {
                    if (!stand.ContainsKey(teamA))
                    {
                        stand.Add(teamA, 0);
                    }
                    stand[teamA] += 1;
                    if (!stand.ContainsKey(teamB))
                    {
                        stand.Add(teamB, 0);
                    }
                    stand[teamB] += 1;
                }
                if (!scored.ContainsKey(teamA))
                {
                    scored.Add(teamA, 0);
                }
                scored[teamA] += scoreA;
                if (!scored.ContainsKey(teamB))
                {
                    scored.Add(teamB, 0);
                }
                scored[teamB] += scoreB;


                input = Console.ReadLine();
            }
   
            int count = 1;
            Console.WriteLine("League standings:");
            foreach (var item in stand.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{count}. {item.Key} {item.Value}");
                count++;
            }
            Console.WriteLine("Top 3 scored goals:");
            scored = scored.OrderByDescending(s => s.Value).ThenBy(s => s.Key).Take(3).ToDictionary(s => s.Key,s => s.Value);
          
            foreach (var item in scored)
            {
                Console.WriteLine($"- {item.Key} -> {item.Value}");
            }


        }

        private static string Reverse(string team)
        {
            char[] temp = team.ToUpper().ToCharArray();
            temp = temp.Reverse().ToArray();
            return string.Format(string.Join("", temp));
        }
    }
}
