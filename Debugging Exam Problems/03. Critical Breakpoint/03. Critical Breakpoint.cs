using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Critical_Breakpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<int, Lines>();
            string input = Console.ReadLine();
            int countLines = 0;
            while (input != "Break it.")
            {
                int[] tokens = input.Split(' ').Select(int.Parse).ToArray();
                countLines++;
                data.Add(countLines, new Lines(tokens));

                input = Console.ReadLine();
            }
            List<int> breakpoints = new List<int>();
            for (int i = 1; i <= data.Count; i++)
            {
                for (int cnt = i + 1; cnt <= data.Count; cnt++)
                {
                    if (data[i].Ratio == data[cnt].Ratio)
                    {
                        breakpoints.Add(data[i].Ratio);
                        breakpoints.Add(data[cnt].Ratio);
                    }
                }
            }
            if (breakpoints.Count == 0)
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }
            else
            {
                foreach (var item in data)
                {
                    Console.WriteLine("Line: [{0}, {1}, {2}, {3}]",
                        item.Value.X1, item.Value.Y1,
                        item.Value.X2, item.Value.Y2);
                }
                double max = breakpoints.Max();
                double result =  (int)(Math.Pow(max,countLines)) % countLines;
                Console.WriteLine($"Critical Breakpoint: {result}");
            }

#if DEBUG
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}. ({item.Value.X1} - {item.Value.Y1}) <-> ({item.Value.X2} - {item.Value.Y2}) => {item.Value.Ratio}");
            }
#endif
        }
    }
    class Lines
    { 
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int Ratio { get; set; }

        public Lines(int[] tokens)
        {
            this.X1 = tokens[0];
            this.Y1 = tokens[1];
            this.X2 = tokens[2];
            this.Y2 = tokens[3];
            this.Ratio =Math.Abs((X2 + Y2) - (X1 + Y1));
        }
    }

}
