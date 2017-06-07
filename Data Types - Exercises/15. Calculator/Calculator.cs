using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char Operator = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (Operator)
            {
                case '+':
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
                    break;
                case '-':
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;
                case '*':
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;
                case '/':
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    break;
                default:
                    break;
            }
        }
    }
}
