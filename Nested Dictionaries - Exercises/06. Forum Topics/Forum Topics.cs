using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "filter")
            {
                string topic = input[0];
                List<string> tags = input[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!data.ContainsKey(topic))
                {
                    data.Add(topic, new List<string>());
                }
                foreach (string item in tags)
                {
                    if (!data[topic].Contains(item))
                    {
                        data[topic].Add(item);

                    }
                }
                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }
            string[] filterWords = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (KeyValuePair<string, List<string>> item in data)
            {
                string topic = item.Key;
                List<string> tags = item.Value;
                int count = 0;
                for (int i = 0; i < filterWords.Length; i++)
                {
                    if (tags.Contains(filterWords[i]))
                    {
                        count++;
                    }
                }
                if (count == filterWords.Length)
                {                 
                    Console.Write($"{topic} | ");
                    tags = tags.Select(n => string.Format($"#{n}")).ToList();                              
                    Console.WriteLine(string.Join(", ",tags));
                }
            }
        }
    }
}
