using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, decimal>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputToken = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string bank = inputToken[0];
                string acount = inputToken[1];
                decimal balance = decimal.Parse(inputToken[2]);

                if (!data.ContainsKey(bank))
                {
                    data.Add(bank, new Dictionary<string, decimal>());
                }
                if (!data[bank].ContainsKey(acount))
                {
                    data[bank].Add(acount, 0m);
                }
                data[bank][acount] += balance;
                input = Console.ReadLine();
            }
            var Orderdata = data.OrderByDescending(bank => bank.Value.Values.Sum()) // сумира стойностите на вътрешния речник
               .ThenByDescending(bankdata => bankdata.Value.Values.Max()) ; 
            foreach (var item in Orderdata)
            {
                string bank = item.Key;
                Dictionary<string, decimal> acountsdata = item.Value;
                foreach (var kvp in acountsdata.OrderByDescending(k => k.Value))
                {
                    string acount = kvp.Key;
                    decimal balance = kvp.Value;
                    Console.WriteLine($"{acount} -> {balance} ({bank})");
                }
            }
        }
    }
}
