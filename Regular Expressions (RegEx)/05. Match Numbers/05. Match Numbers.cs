﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string strNumbers = Console.ReadLine();

            MatchCollection mat = Regex.Matches(strNumbers, pattern);

            foreach (Match m in mat)
            {
                Console.Write(m.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
