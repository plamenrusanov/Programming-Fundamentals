using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Base
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> emplAge = new Dictionary<string, int>();
            Dictionary<string, double> emplSalary = new Dictionary<string, double>();
            Dictionary<string, string> emplPosition = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (!"filter".Equals(input[0]))
            {
                string key = input[0];
                string value = input[1];

                int age;
                double salary;
                if (int.TryParse(value, out age))
                {
                    emplAge[key] = age;
                }
                else if (double.TryParse(value, out salary))
                {
                    emplSalary[key] = salary;
                }
                else
                {
                    emplPosition[key] = value;
                }
                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string condition = Console.ReadLine().ToLower();
            if (condition == "position")
            {
                foreach (KeyValuePair<string, string> item in emplPosition)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (condition == "age")
            {
                foreach (KeyValuePair<string, int> item in emplAge)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Age: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (KeyValuePair<string, double> item in emplSalary)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Salary: {item.Value:0.00}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
