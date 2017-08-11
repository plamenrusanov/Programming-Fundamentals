using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSON_Stringify
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> data = new Dictionary<string, Student>();
            string input = Console.ReadLine();
            while (input != "stringify")
            {
                string[] inputToken = input.Split(new string[] { " : "," ->"}, StringSplitOptions.RemoveEmptyEntries);
                string name = inputToken[0];
                string age = inputToken[1];
                string grades = "";
                if (inputToken.Length > 2)
                {
                    grades = inputToken[2];
                }
                if (!data.ContainsKey(name))
                {
                    data.Add(name, new Student(age, grades));
                }
                input = Console.ReadLine();
            }
            StringBuilder result = new StringBuilder();
            Console.Write("[");
            foreach (var item in data)
            {
                string name = item.Key;
                string age = item.Value.Age;
                List<string> grades = item.Value.Grade;      
                result = result.Append( $"{{name:\"{name}\",age:{age},grades:[{string.Join(", ", grades)}]}},");              
            }
            result.Remove(result.Length - 1, 1);
            Console.Write(result);
            Console.WriteLine("]");
        }
    }
    class Student
    {    
        public string Age { get; set; }
        public List<string> Grade { get; set; }
        public Student(string age, string grades)
        {
            Age = age ;
            Grade = grades.Split(new string[] { ", " ," "}, StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();
        }
    }
}
