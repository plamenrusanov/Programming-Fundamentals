using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            List<string> blackListedWords = Console.ReadLine().Split().ToList();
            List<string> inputText = new List<string>();
            List<string> PrintResult = new List<string>();
            do
            {
                bool IsEqualWords = false;
                string input = Console.ReadLine();
                inputText = input.Split().ToList();
                if (inputText[0] == "end")
                {
                    break;
                }
                for (int blackWord = 0; blackWord < blackListedWords.Capacity; blackWord++)
                {
                    for (int inputWord = 0; inputWord < inputText.Capacity; inputWord++)
                    {
                        if (inputText[inputWord].Contains(blackListedWords[blackWord]))
                        {
                            IsEqualWords = true;
                        }
                    }
                }
                if (!IsEqualWords)
                {
                    PrintResult.Add(input);
                }
            } while (true);
            PrintResult.Sort();
            Console.WriteLine(string.Join("\r\n",PrintResult));
        }
    }
}
