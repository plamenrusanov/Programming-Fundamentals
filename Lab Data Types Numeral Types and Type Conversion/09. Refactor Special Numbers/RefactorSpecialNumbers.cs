﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                int num = i;
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                bool а = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {а}");

            }
        }
    }
}
