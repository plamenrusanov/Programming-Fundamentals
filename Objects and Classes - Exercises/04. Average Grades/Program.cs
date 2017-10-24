using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                students.Add(new Student(input));               
            }
            students = students.Where(s => s.Average >= 5).ToList();
            foreach (var item in students.OrderBy(s => s.Name).ThenByDescending(s => s.Average))
            {
                string name = item.Name;
                double average = item.Average;
                Console.WriteLine($"{name} -> {average:f2}");                           
            }           
        }
        public class Student
        {
            public string Name { get; set; }
            public List<double> Grade { get; set; }
            public double Average { get; set; }
            public Student(string[] input)
            {
                Name = input[0];
                Grade = input.Skip(1).Take(input.Length - 1).Select(double.Parse).ToList();            
                Average = Grade.Average();
            }
        }
    }
   
}
