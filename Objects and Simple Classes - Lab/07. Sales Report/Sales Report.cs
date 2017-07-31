using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                Sale sale = ReadSale(Console.ReadLine());
                sales.Add(sale);
            }
            List<string> towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t).ToList();

            foreach (string town in towns)
            {
                double currentSum = sales.Where(s => s.Town == town).Select(s => s.Price * s.Quantity).Sum();
                Console.WriteLine($"{town} -> {currentSum:f2}");
            }
        }

        private static Sale ReadSale(string input)
        {
            string[] inputToken = input.Split(' ');
            string town = inputToken[0];
            string product = inputToken[1];
            double price = double.Parse(inputToken[2]);
            double qty = double.Parse(inputToken[3]);
            return new Sale
            {
                Town = town,
                Product = product,
                Price = price,
                Quantity = qty
            };

        }

        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public double Price { get; set; }
            public double Quantity { get; set; }
        }
    }
}
