using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shoot_List_Elements
{
    class Program
    {
        static List<int> NewList = new List<int>();
        static int lastShot = 0;
        static void Main(string[] args)
        {
            var input = "";
            do
            {
                input = Console.ReadLine();
                if (input == "bang")
                {
                    if (NewList.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastShot}");
                        return;
                    }
                    for (int i = 0; i < NewList.Count; i++)
                    {
                        double average = Average();                    
                        if (NewList[i] <= average)
                        {
                            lastShot = NewList[i];
                            NewList.RemoveAt(i);
                            Console.WriteLine($"shot {lastShot}");
                            break;
                        }
                    }
                    Decrement();
                }
                else if (input == "stop")
                {
                    break;
                }
                else
                {
                    NewList.Insert(0, int.Parse(input));
                }
            } while (true);
            PrintResilt();        
        }
        static void Decrement()
        {
            for (int i = 0; i < NewList.Count; i++)
            {
                NewList[i]--;
            }
        }      
        static double Average()
        {
            double sum = 0;
            for (int i = 0; i < NewList.Count; i++)
            {
                sum += NewList[i];
            }
            return sum / NewList.Count;
        }       
        static void PrintResilt()
        {
           
            if (NewList.Count == 0 )
            {
                Console.WriteLine($"you shot them all. last one was {lastShot}");
            }
            else
            {
                Console.WriteLine("survivors: "+string.Join(" ",NewList));
            }

        }
    }
}
