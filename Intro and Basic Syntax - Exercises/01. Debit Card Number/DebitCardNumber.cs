﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Debit_Card_Number
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber:d4} {secondNumber:d4} {thirdNumber:d4} {fourNumber:d4}");

        }
    }
}
