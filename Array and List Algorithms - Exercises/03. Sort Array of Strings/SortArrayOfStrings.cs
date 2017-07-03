using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    class SortArrayOfStrings
    {
        static List<string> inputString;
        static List<string> newString;
        static void Main(string[] args)
        {
            inputString = Console.ReadLine().Split().ToList();
            newString = Console.ReadLine().Split().ToList();
            inputString.Sort();
            inputString.Reverse();
            inputString.LastIndexOf("st");
            inputString.InsertRange(0, newString);
            Console.WriteLine(string.Join(" ", inputString));

        }    
    }
}
