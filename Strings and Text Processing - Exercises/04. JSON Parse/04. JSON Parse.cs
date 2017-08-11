using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JSON_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Student>();
            string input = Console.ReadLine();
            string[] inputStudents = input.Split(new string[] { "name:\"" ,"[{","}]","},{"}
                                       , StringSplitOptions.RemoveEmptyEntries);
            List<string> tokens = new List<string>();
            for (int i = 0; i < inputStudents.Length; i++)
            {
                tokens = inputStudents[i].Split(new string[] { "\",age:", ",grades:","[","]"}
                          , StringSplitOptions.RemoveEmptyEntries).ToList();       
                string name = tokens[0];              
                string age = tokens[1];
                string grades = "None";
                if (tokens.Count > 2)
                {
                    grades = tokens[2];
                }
                data.Add(name, new Student(age, grades));
            }
            foreach (var item in data)
            {
                string name = item.Key;
                string age = item.Value.Age;
                List<string> grades = item.Value.Grade;
                Console.WriteLine($"{name} : {age} -> {string.Join(", ",grades)}");
            }
        }
    }
    class Student
    {
        public string Age { get; set; }
        public List<string> Grade { get; set; }
        public Student(string age, string grades)
        {
            Age = age;
            Grade = grades.Split(new string[] { ",", " "},
                StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();
        }
    }
}
