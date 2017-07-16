using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Average_Student_Grades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (!grades.ContainsKey(name))
                    grades[name] = new List<double>();

                grades[name].Add(grade);
            }
            foreach (var pair in grades)
            {
                string name = pair.Key;
                List<double> studentGrades = pair.Value;

                double average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                    Console.Write($"{grade:f2} ");

                Console.WriteLine($"(avg: {average:f2})");
            }

        }
    }
}
