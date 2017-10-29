using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> data = new Dictionary<string, Student>();

            string inputDates = Console.ReadLine();
            while (inputDates != "end of dates")
            {
                string[] tokensData = inputDates.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokensData[0];
                DateTime[] d = tokensData.Skip(1).Select(e => DateTime.ParseExact(e, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToArray();
                if (!data.ContainsKey(name))
                {
                    data.Add(name, new Student());
                    data[name].Dates = new List<DateTime>();
                    data[name].Comments = new List<string>();
                }
                data[name].Dates.AddRange(d);
                inputDates = Console.ReadLine();
            }

            string inputComents = Console.ReadLine();
            while (inputComents != "end of comments")
            {
                string[] tokensComment = inputComents.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokensComment[0];
                string comment = tokensComment[1];
                if (data.ContainsKey(name))
                {
                    data[name].Comments.Add(comment);
                }

                inputComents = Console.ReadLine();
            }

            foreach (var item in data.OrderBy(i => i.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("Comments:");
                foreach (string comment in item.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (DateTime date in item.Value.Dates.OrderBy(d => d))
                {
                    Console.WriteLine("-- {0}",date.ToString("dd'/'MM'/'yyyy"));
                }
            }
        }
    }
    class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}
