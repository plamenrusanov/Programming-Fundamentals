using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace _02.Command_Interpreter
{
    class Program
    {
        static List<string> data = new List<string>();
        static void Main(string[] args)
        {
            data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
           
            while (input != "end")
            {
                string[] inputTokens = input.Split(' ');
                if (inputTokens[0] == "reverse")
                {             
                    int from = int.Parse(inputTokens[2]);
                    int count = int.Parse(inputTokens[4]);
                    if (data.Count >= (from + count) && from >= 0 && count >= 0)
                    {
                        data.Reverse(from, count);
                        //Console.WriteLine("[" + string.Join(", ", data) + "]");
                       
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }                  
                }
                else if (inputTokens[0] == "sort")
                {
                   
                    int from = int.Parse(inputTokens[2]);
                    int count = int.Parse(inputTokens[4]);
                    if (data.Count >= (from + count) && from >= 0 && count >= 0)
                    {
                        Sort(from, count);
                       // Console.WriteLine("[" + string.Join(", ", data) + "]");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }                
                }
                else if (inputTokens[0] == "rollLeft")
                {
                    long times = long.Parse(inputTokens[1])% data.Count;
                    if (times >= 0 )
                    {
                        for (long i = 0; i < times; i++)
                        {
                            string temp = data[0];
                            data.RemoveAt(0);
                            data.Add(temp);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                  
                  // Console.WriteLine("[" + string.Join(", ", data) + "]");
                }
                else if (inputTokens[0] == "rollRight")
                {
                  
                    long times = long.Parse(inputTokens[1]) % data.Count;
                    if (times >= 0)
                    {
                        for (long i = 0; i < times; i++)
                        {

                            string temp = data[data.Count - 1];
                            data.RemoveAt(data.Count - 1);
                            data.Insert(0, temp);

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                   
                  //  Console.WriteLine("[" + string.Join(", ", data) + "]");
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }


                input = Console.ReadLine();
            }
            Console.WriteLine("["+string.Join(", ",data)+"]");
         
        }

        private static void Sort(int from, int count)
        {
            
            List<string> begining = data.Take(from).ToList();
            List<string> temp = data.Skip(from).Take(count).ToList();
            temp.Sort();
            List<string> last = data.Skip(from + count).Take(data.Count - (from + count)).ToList();
            data.Clear();
            data = data.Concat(begining).ToList();        
            data = data.Concat(temp).ToList();
            data = data.Concat(last).ToList();
        }
    }
}
