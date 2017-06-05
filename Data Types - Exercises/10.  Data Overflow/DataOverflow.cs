using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Data_Overflow
{
    class DataOverflow
    {
        static void Main(string[] args)
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());

            ulong bigNumber = Math.Max(firstNumber, secondNumber);
            ulong smallNumber = Math.Min(firstNumber, secondNumber);
            string bigerNum = string.Empty;
            string smallNum = string.Empty;
            ulong smallNumType = 0;

            if (bigNumber >= byte.MinValue && bigNumber <= byte.MaxValue)
            {
                bigerNum = "byte";
            }
            else if (bigNumber >= ushort.MinValue && bigNumber <= ushort.MaxValue)
            {
                bigerNum = "ushort";
            }
            else if (bigNumber >= uint.MinValue && bigNumber <= uint.MaxValue)
            {
                bigerNum = "uint";
            }
            else
            {
                bigerNum = "ulong";
            }

            if (smallNumber >= byte.MinValue && smallNumber <= byte.MaxValue)
            {
                smallNum = "byte";
                smallNumType = byte.MaxValue;
            }
            else if (smallNumber >= ushort.MinValue && smallNumber <= ushort.MaxValue)
            {
                smallNum = "ushort";
                smallNumType = ushort.MaxValue;
            }
            else if (smallNumber >= uint.MinValue && smallNumber <= uint.MaxValue)
            {
                smallNum = "uint";
                smallNumType = uint.MaxValue;
            }
            else
            {
                smallNum = "ulong";
                smallNumType = ulong.MaxValue;
            }
            Console.WriteLine($"bigger type: {bigerNum}");
            Console.WriteLine($"smaller type: {smallNum}");
            Console.WriteLine($"{bigNumber} can overflow {smallNum} {Math.Round((double)bigNumber / smallNumType)} times");
        }
    }
}
