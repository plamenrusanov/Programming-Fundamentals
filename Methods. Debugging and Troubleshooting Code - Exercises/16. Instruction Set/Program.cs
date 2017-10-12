using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Instruction_Set
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputTokens = input.Split(' ');

                long result = 0;
                switch (inputTokens[0].ToUpper())
                {
                    case "INC":
                        {
                            long operandOne = int.Parse(inputTokens[1]);
                            result = operandOne + 1;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = int.Parse(inputTokens[1]);
                            result = operandOne - 1;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = int.Parse(inputTokens[1]);
                            long operandTwo = int.Parse(inputTokens[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = int.Parse(inputTokens[1]);
                            long operandTwo = int.Parse(inputTokens[2]);
                            result = (operandOne * operandTwo);
                            break;
                        }
                }

                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
