using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08.Commits
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();
            Regex urlPattern = new Regex( @"^https:\/\/github\.com\/(?<user>[A-Za-z0-9-]+)\/(?<repo>[A-Za-z-_]+)\/commit\/(?<hash>[A-Fa-f0-9]{40}),(?<message>[^\n]+),(?<additions>[0-9]+),(?<deletions>[0-9]+)$");
            string input = Console.ReadLine();
            while (input != "git push")
            {
                
                if (urlPattern.IsMatch(input))
                {
                    Match m = urlPattern.Match(input);
                    string user = m.Groups["user"].Value;
                    string repo = m.Groups["repo"].Value;
                    string hash = m.Groups["hash"].Value;
                    string message = m.Groups["message"].Value;
                    int additions = int.Parse(m.Groups["additions"].Value);
                    int deletions = int.Parse(m.Groups["deletions"].Value);

                    if (!data.ContainsKey(user))
                    {
                        data.Add(user, new SortedDictionary<string, List<Commit>>());
                    }
                    if (!data[user].ContainsKey(repo))
                    {
                        data[user].Add(repo, new List<Commit>());
                    }
                    data[user][repo].Add(new Commit(hash, message, additions, deletions));
                }               
                input = Console.ReadLine();
            }

            foreach (var item in data)
            {
                string user = item.Key;
                var repos = item.Value;
                Console.WriteLine($"{user}:");
                foreach (var rep in repos)
                {
                    string repo = rep.Key;
                    Console.WriteLine($"  {repo}:");
                    var com = rep.Value;
                    int addition = 0;
                    int deletion = 0;
                    foreach (var comit in com)
                    {
                        string hash = comit.Hash;
                        string message = comit.Message;
                        int additions = comit.Additions;
                        int deletions = comit.Deletions;
                        addition += additions;
                        deletion += deletions;
                        Console.WriteLine($"    commit {hash}: {message} ({additions} additions, {deletions} deletions)");
                    }
                    Console.WriteLine($"    Total: {addition} additions, {deletion} deletions");
                }
            }

        }
    }
    class Commit
    {
        public string Hash { get; set; }
        public string Message { get; set; }
        public int Additions { get; set; }
        public int Deletions { get; set; }

        public Commit(string hash, string message, int additions, int delitions)
        {
            this.Hash = hash;
            this.Message = message;
            this.Additions = additions;
            this.Deletions = delitions;
        }
               

    }
}
