using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal total = 0m;
            for (int i = 0; i < n; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                int[] date = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
                int month = date[1];
                int year = date[2];
                long count = long.Parse(Console.ReadLine());
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        decimal orderPrice = 31 * count * price;
                        total += orderPrice;
                        Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        decimal orderPr = 30 * count * price;
                        total += orderPr;
                        Console.WriteLine($"The price for the coffee is: ${orderPr:f2}");
                        break;
                    case 2:
                        int days = 28;
                        if (year % 4 == 0)
                        {
                            days = 29;
                        }
                        decimal oPr = days * count * price;
                        total += oPr;
                        Console.WriteLine($"The price for the coffee is: ${oPr:f2}");
                        break;
                    default:

                        break;
                }
            }
            Console.WriteLine($"Total: ${total:f2}");        
        }
    }
}
