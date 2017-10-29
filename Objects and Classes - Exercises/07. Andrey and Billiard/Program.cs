using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        static Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] product = Console.ReadLine().Split(new char[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string productName = product[0];
                decimal productPrice = decimal.Parse(product[1]);

                if (!shop.ContainsKey(productName))
                {
                    shop.Add(productName, productPrice);
                }
                else
                {
                    shop[productName] = productPrice;
                }
            }

            string client = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();
            decimal totalAmount = 0m;
            while (!client.Equals("end of clients"))
            {
                string[] clientTokens = client.Split(new char[] { '-', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string clientName = clientTokens[0];
                string brProduct = clientTokens[1];
                    if (shop.ContainsKey(brProduct))
                    {
                        int quantity = int.Parse(clientTokens[2]);
                        totalAmount += shop[brProduct] * quantity;
                        if (!result.ContainsKey(clientName))
                        {
                            result.Add(clientName, new Dictionary<string, int>());
                        }
                        if (!result[clientName].ContainsKey(brProduct))
                        {
                            result[clientName].Add(brProduct, quantity);
                        }
                        else
                        {
                            result[clientName][brProduct] += quantity;
                        }
                    }            
                client = Console.ReadLine();
            }
            PrintResult(result, totalAmount);

        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int>> result, decimal totalAmount)
        {
            foreach (var item in result.OrderBy(i => i.Key))
            {
                Console.WriteLine(item.Key);
                decimal bill = 0;
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"-- {kvp.Key} - {kvp.Value}");
                    bill += shop[kvp.Key] * kvp.Value;
                }
                Console.WriteLine($"Bill: {bill:f2}");
            }
            Console.WriteLine($"Total bill: {totalAmount:f2}");
        }
    }
}
