using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Optimized_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> data = new List<BankAccount>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                data.Add(new BankAccount(input));
                input = Console.ReadLine();
            }
            foreach (var item in data.OrderByDescending(o => o.Balance).ThenBy(d => d.Bank.Length))
            {
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Bank})");
            }

        }
    }
    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
       
        public BankAccount(string input)
        {
            string[] inputToken = input.Split(new string[] { " | "},StringSplitOptions.RemoveEmptyEntries).ToArray();
            this.Name = inputToken[1];
            this.Bank = inputToken[0];
            this.Balance = decimal.Parse(inputToken[2]);
        }

    }
}
