using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static List<long> numbers;
        static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] token = command.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                switch (token[0])
                {
                    case "exchange":
                        int index = int.Parse(token[1]);
                        if (index >= 0 && index < numbers.Count)
                        {
                            Exchange(index);
#if DEBUG
                            Console.WriteLine("[{0}]", string.Join(", ", numbers));
#endif
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "max":
                        bool isOdd = IsOdd(token[1]);
                        long max = Max(isOdd);
                        if (max >= 0)
                        {
                            Console.WriteLine(max);
                        }
                         else
                        {                                                     
                            Console.WriteLine("No matches");
                        }                       
                        break;
                    case "min":
                        isOdd = IsOdd(token[1]);                       
                        long min = Min(isOdd);
                        if (min >= 0)
                        {
                            Console.WriteLine(min);
                        }
                         else
                        {                          
                            Console.WriteLine("No matches");                        
                        }                     
                        break;
                    case "first":
                        int count = int.Parse(token[1]);
                        if (count <= numbers.Count && count > 0)
                        {
                            isOdd = IsOdd(token[2]);
                            long[] first = First(count, isOdd);
                            Console.WriteLine("[{0}]", string.Join(", ", first));
                        }
                        else 
                        {
                            Console.WriteLine("Invalid count");                           
                        }                        
                        break;
                    case "last":
                        count = int.Parse(token[1]);
                        if (count <= numbers.Count && count > 0)
                        {
                            isOdd = IsOdd(token[2]);
                            long[] last = Last(count, isOdd);
                            Console.WriteLine("[{0}]", string.Join(", ", last));                           
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }                       
                        break;                
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        private static long[] Last(int count, bool isOdd)
        {
            if (isOdd)
            {
                long[] tempOdd = numbers.Where(n => n % 2 != 0).ToArray();
                tempOdd = tempOdd.Skip(tempOdd.Length - count).Take(count).ToArray();
                return tempOdd;
            }
            long[] tempEven = numbers.Where(n => n % 2 == 0).ToArray();
            tempEven = tempEven.Skip(tempEven.Length - count).Take(count).ToArray();
            return tempEven;
        }

        private static long[] First(int count, bool isOdd)
        {
            if (isOdd)
            {
                long[] tempOdd = numbers.Where(n => n % 2 != 0).Take(count).ToArray();
                return tempOdd;
            }
            long[] tempEven = numbers.Where(n => n % 2 == 0).Take(count).ToArray();
            return tempEven;
        }

        private static long Min(bool isOdd)
        {
            if (isOdd)
            {
                long min = -1;
                List<long> minOdd =  numbers.Where(n => n % 2 != 0).ToList();
                if (minOdd.Count > 0)
                {
                    min = minOdd.Min();
                }
                return numbers.LastIndexOf(min);
            }
            else
            {
                long min = -1;
                List<long> minEven = numbers.Where(n => n % 2 == 0).ToList();
                if (minEven.Count > 0)
                {
                    min = minEven.Min();
                }
                return numbers.LastIndexOf(min);
            }
            
           
        }

        private static long Max(bool isOdd)
        {
            if (isOdd)
            {
                long max = -1;
                List<long> maxOdd = numbers.Where(n => n % 2 != 0).ToList();
                if (maxOdd.Count > 0)
                {
                    max = maxOdd.Max();
                }
                return numbers.LastIndexOf(max);
            }
            else
            {
                long max = -1;
                List<long> maxEven = numbers.Where(n => n % 2 == 0).ToList();
                if (maxEven.Count > 0)
                {
                    max = maxEven.Max();
                }
                return numbers.LastIndexOf(max);
            }
        }

        private static bool IsOdd(string v)
        {
            if (v == "odd")
            {
                return true;
            }
            return false;
        }

        private static void Exchange(int index)
        {
            List<long> first = numbers.Take(index +1).ToList();
            List<long> second = numbers.Skip(index +1).Take(numbers.Count - (index +1)).ToList();
            numbers.Clear();
            numbers = numbers.Concat(second).ToList();
            numbers = numbers.Concat(first).ToList();
        }
    }
}
