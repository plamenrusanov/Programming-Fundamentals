using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
    class DecodeRadioFrequencies
    {
        static void Main(string[] args)
        {
            List<double> inputList = Console.ReadLine().Split('.',' ').Select(double.Parse).ToList();

            List<char> newInt = new List<char>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == 0)
                {
                    continue;
                }
                if (i % 2 == 0)
                {
                    char Left = (char)inputList[i];
                    newInt.Insert(i / 2, Left);
                }
                else
                {
                    char rigth = (char)inputList[i];
                    newInt.Insert(i /2 +1, rigth);
                }               
            }
            Console.WriteLine(string.Join("", newInt));
        }
    }
}
