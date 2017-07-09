using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Exam_Shopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> shop = new Dictionary<string, int>();


            string[] stok = Console.ReadLine().Split().ToArray();

            while (!"shopping".Equals(stok[0]))
            {
                string key = stok[1];
                int value = int.Parse(stok[2]);

                if (!shop.ContainsKey(key))
                {
                    shop[key] = value;
                }
                else
                {
                    shop[key] += value;
                }
                stok = Console.ReadLine().Split().ToArray();
            }
            stok = Console.ReadLine().Split().ToArray();

            while (!"exam".Equals(stok[0]))
            {
                string key = stok[1];
                int value = int.Parse(stok[2]);

                if (shop.ContainsKey(key))
                {
                    shop[key] -= value;
                }
                else if (!shop.ContainsKey(key))
                {
                    Console.WriteLine($"{key} doesn't exist");
                }
                    stok = Console.ReadLine().Split().ToArray();
            }

            foreach (KeyValuePair<string, int> item in shop)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }





        }
    }
}
