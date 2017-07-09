using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Increasing_Crisis
{
    class IncreasingCrisis
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> List = new List<int>();
            int SaveInput = 0;
            int count = List.Count;
            for (int i = 0; i < n; i++)
            {
                List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
                for (int index = 0; index < input.Count; index++)
                {
                    if (index != 0 && input[index] < input[index -1])
                    {
                        List.RemoveAll(x => x > SaveInput);
                        break;
                    }
                    for (int cnt = List.Count; cnt >= 0; cnt--)
                    {
                        if (List.Count == 0)
                        {
                            List.Add(input[index]);
                            SaveInput = input[index];
                            count++;
                            break;
                        }
                        else if (input[index] >= List[cnt -1] )
                        {
                            List.Insert(cnt , input[index]);
                            SaveInput = input[index];
                            count++;
                            break;
                        }                     
                    }
                }
            }
            Console.WriteLine(string.Join(" ", List));
        }
    }
}
