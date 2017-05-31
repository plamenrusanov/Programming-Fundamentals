using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            decimal balance = decimal.Parse(Console.ReadLine());
            string game = string.Empty;
            decimal money = balance;

            do
            {
                game = Console.ReadLine().ToLower().Trim();
                switch (game)
                {
                    case "outfall 4":
                        if (money >= 39.99m)
                        {
                            money -= 39.99m;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "cs: og":
                        if (money >= 15.99m)
                        {
                            money -= 15.99m;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "zplinter zell":
                        if (money >= 19.99m)
                        {
                            money -= 19.99m;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "honored 2":
                        if (money >= 59.99m)
                        {
                            money -= 59.99m;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "roverwatch":
                        if (money >= 29.99m)
                        {
                            money -= 29.99m;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "roverwatch origins edition":
                        if (money >= 39.99m)
                        {
                            money -= 39.99m;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "game time": break;
                    default: Console.WriteLine("Not Found"); break;
                }
                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            } while (game != "game time");
            if (game == "game time")
            {
                Console.WriteLine("Total spent: ${0}. Remaining: ${1}", balance - money, money);
            }
        }
    }
}
