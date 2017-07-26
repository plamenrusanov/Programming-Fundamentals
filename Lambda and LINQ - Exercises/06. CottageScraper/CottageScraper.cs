using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CottageScraper
{
    class CottageScraper
    {
        static void Main(string[] args)
        {

            //        List<KeyValuePair<string, int>> data = new List<KeyValuePair<string, int>>();

            //        string input = Console.ReadLine().ToLower();
            //        double avarage = 0.0;
            //        while (input != "chop chop")
            //        {
            //            string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            //            string treeType = tokens[0];
            //            int height = int.Parse(tokens[1]);

            //            data.Add(new KeyValuePair<string, int>(treeType, height));



            //            input = Console.ReadLine().ToLower();
            //        }
            //        string treeWanted = Console.ReadLine().ToLower();
            //        int minHeight = int.Parse(Console.ReadLine());

            //        avarage = Math.Round(data.Average(r => r.Value), 2);
            //        Console.WriteLine($"Price per meter: ${avarage:f2}");

            //        var usedLogs =
            //            data
            //            .Where(k => k.Key == treeWanted)
            //            .Where(r => r.Value >= minHeight);

            //        double usedLogsPrice = Math.Round(usedLogs.Sum(r => r.Value * avarage), 2);
            //        Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");

            //        double unusedLogsPrice = 0.0;

            //        foreach (var item in data)
            //        {
            //            if (item.Key != treeWanted || item.Value < minHeight)
            //            {
            //                unusedLogsPrice = Math.Round((unusedLogsPrice + item.Value), 2);
            //            }
            //        }
            //        unusedLogsPrice = Math.Round((unusedLogsPrice * avarage * 0.25), 2);
            //        Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");

            //        double totalPrice = Math.Round((usedLogsPrice + unusedLogsPrice), 2);
            //        Console.WriteLine($"CottageScraper subtotal: ${totalPrice:f2}");
            //    }
            //}

            List<KeyValuePair<string, int>> data = new List<KeyValuePair<string, int>>();
            string input = Console.ReadLine().ToLower();

            while (input != "chop chop")
            {
                string[] inputToken = input.Split(new string[] {" -> "},
                    StringSplitOptions.RemoveEmptyEntries).ToArray();
                string woodType = inputToken[0];
                int length = int.Parse(inputToken[1]);
                data.Add(new KeyValuePair<string, int>(woodType, length));
                input = Console.ReadLine().ToLower();
            }
            string needWood = Console.ReadLine();
            int minLegth = int.Parse(Console.ReadLine());
            double average = Math.Round(data.Average(v => v.Value), 2);
            Console.WriteLine($"Price per meter: ${average}");
            var usedwoods = data.Where(key => key.Key == needWood).Where(x => x.Value >= minLegth);
            double usedMeters =Math.Round(usedwoods.Sum(x => x.Value * average),2);
            //double usPrice = Math.Round(usedMeters * average,2);
            Console.WriteLine($"Used logs price: ${usedMeters}");
            var unUsedWoods = data.Where(key => key.Key != needWood).Where(x => x.Value < minLegth);
            double unUsedMeters = Math.Round(unUsedWoods.Sum(x => x.Value * average * 0.25),2);
           // double unPrice = Math.Round(unUsedMeters * average * 0.25, 2);
            Console.WriteLine($"Unused logs price: ${unUsedMeters}");
            Console.WriteLine($"CottageScraper subtotal: ${Math.Round(usedMeters + unUsedMeters, 2)}");









        }
    }
}
