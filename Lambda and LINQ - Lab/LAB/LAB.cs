using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    class Program
    {
        static List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        static List<dynamic> stringInt = new List<dynamic> { 1, "123", "Pesho", 0.2345 };
        static void SORT()
        {
            //var Orderdata = data.OrderByDescending(bank => bank.Value.Values.Sum());// сумира стойностите на вътрешния речник
            //students = students
            //    .OrderBy(s => s.Value)
            //    .ToDictionary(key => key.Key, value => value.Value);
            //foreach (KeyValuePair<string, int> kvp in students.OrderByDescending(s => s.Value).ThenByDescending(n => n.Key.Length))
            //{
            //    Console.WriteLine(kvp.Key + " => " + kvp.Value);
            //}
            //newNums = numbers
            //    .OrderByDescending(n => n)
            //    .ToList();
        }
        static void FILTER()
        {
            //newNums = numbers
            //    .Where(n => n % 2 == 0)
            //    .ToList();  //filter numbers
        }
        static void SEARCHING()
        {
            //int single = numbers.Single(n => n % 11 == 0); // if have more then one element EXEPTION !!!
            //bool IsFivePresent = numbers
            //    .Any(n => n == 5); // return bool true or false
            //    .All(n => n > 0); //check for// only positive numbers
        }
        static void TRANSFORM()
        {
            //stringNum = numbers
            //    .Select((n, i) => string.Format($"{n}. {i}"))
            //    .ToList(); //change numbers
            //str = str
            //    .Select(n => string.Format($"#{n}")) // obrabotva vseki string
            //    .ToList();
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>
            { ["pesho"] = 3, ["mimi"] = 6, ["gosho"] = 5, ["ivo"] = 3 };
           
          
            List<string> str = new List<string> { "pesho", "gosho", "penka" };
            List<string> stringNum = new List<string>();
            List<int> newNums = new List<int>();
            //numbers = numbers
            //    .Distinct() // save only unique elements
            //    .ToList();
            //int count = numbers              
            //    .Count(n => n > 3); // return how many numbers greater then 3
            //newNums = numbers
            //    .Where(n => n % 2 == 0)
            //    .Where(n => n >= 4)
            //    .Select(n => n + 2)
            //    .OrderByDescending(n => n)
            //    .Skip(1)
            //    .Take(200)
            //    .ToList();// filter elements
           
            //newNums = numbers
            //      .Skip(2)
            //      .ToList();
            //newNums = numbers
            //    .Take(1000)
            //    .ToList();
            //stringNum = numbers
        
            //int first = numbers.First(); // .first(n => n == 4) return first element == 4
            //int last = numbers.Last();            
            //int sumNumbers = numbers.Sum();
            //int minNumber = numbers.Min();
            //int maxNumber = numbers.Max();
      
            //numbers.Reverse();
            //double avarage = numbers.Average();
            //Console.WriteLine(string.Join(", ", newNums));
            //Console.WriteLine(avarage);
            //test();
            Concat();
        }
        static void test() // kak sa dostapni vatreshni dictionary
        {
            Dictionary<string, Dictionary<string, int>> test = new Dictionary<string, Dictionary<string, int>>
            {
                ["pesho"] = new Dictionary<string, int> { ["Math"] = 4 },
                ["mimi"] = new Dictionary<string, int> { ["Math"] = 6, ["Phisics"] = 6 },
                ["gosho"] = new Dictionary<string, int> { ["Math"] = 3, ["Phisics"] = 6 },
                ["tosho"] = new Dictionary<string, int> { ["Math"] = 2, ["Phisics"]= 2}
            };
            foreach (var student in test.OrderBy(s => s.Key).ThenBy(k => k.Value["Math"]))
            {
                Console.WriteLine(student.Key + " => " + student.Value["Math"]);
            }

        }
        static void Concat()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int[] otherNums = { 8, 9, 0 };
            int[] combined = nums.Concat(otherNums).ToArray();
            Console.WriteLine(string.Join(", ",combined));
        } //konkatenirane na masivi , listove
    }
}
