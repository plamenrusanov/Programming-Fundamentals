using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List
    {
        static List<string> NewList = new List<string>();
        static List<int> firstNumList = new List<int>();
        
        static void Main(string[] args)
        {
            NewList.Sort(); // сортира във възходящ ред
            NewList.Remove("a"); // намира и премахва първото "а"
            NewList.RemoveAt(0); // премахва позицията която е показана в скобите
            //inputText[inputWord].Contains(blackListedWords[blackWord] // true or false , съдържа ли се второто в първото
            // NewList.Add(List[List.Count - 1]); or //  NewList.Add(List[0]);  

        }
        static void PrintList ()
        {
            Console.WriteLine(string.Join(", ", NewList));
            Console.WriteLine(string.Join("\r\n", NewList));

        }
        static void ReadList ()
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<int> firstNumList = Console.ReadLine().Split().Select(int.Parse).ToList();
        }
    }
}
