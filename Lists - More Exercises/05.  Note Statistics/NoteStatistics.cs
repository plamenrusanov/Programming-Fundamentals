using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Note_Statistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {
            List<double> DoubleList = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<string> StringList = new List<string>();
            double naturalSum = 0;
            double sharpSum = 0;
            for (int cnt = 0; cnt < DoubleList.Count; cnt++)
            {
                if (DoubleList[cnt] == 261.63)
                {
                    StringList.Add("C");
                    naturalSum += 261.63;
                }
                else if (DoubleList[cnt] == 277.18)
                {
                    StringList.Add("C#");
                    sharpSum += 277.18;
                }
                else if (DoubleList[cnt] == 293.66)
                {
                    StringList.Add("D");
                    naturalSum += 293.66;
                }
                else if (DoubleList[cnt] == 311.13)
                {
                    StringList.Add("D#");
                    sharpSum += 311.13;
                }
                else if (DoubleList[cnt] == 329.63)
                {
                    StringList.Add("E");
                    naturalSum += 329.63;
                }
                else if (DoubleList[cnt] == 349.23)
                {
                    StringList.Add("F");
                    naturalSum += 349.23;
                }
                else if(DoubleList[cnt] == 369.99)
                {
                    StringList.Add("F#");
                    sharpSum += 369.99;
                }
                else if (DoubleList[cnt] == 392.00)
                {
                    StringList.Add("G");
                    naturalSum += 392.00;
                }
                else if (DoubleList[cnt] == 415.30)
                {
                    StringList.Add("G#");
                    sharpSum += 415.30;
                }
                else if (DoubleList[cnt] == 440.00)
                {
                    StringList.Add("A");
                    naturalSum += 440;
                }
                else if (DoubleList[cnt] == 466.16)
                {
                    StringList.Add("A#");
                    sharpSum += 466.16;
                }
                else if (DoubleList[cnt] == 493.88)
                {
                    StringList.Add("B");
                    naturalSum += 493.88;
                }
            }
            List<string> Natur = new List<string>();
            List<string> sharp = new List<string>();
            Console.WriteLine("Notes: "+string.Join(" ",StringList));
            for (int i = 0; i < StringList.Count; i++)
            {
                if (StringList[i].Contains("#"))
                {
                    sharp.Add(StringList[i]);
                }
                else
                {
                    Natur.Add(StringList[i]);
                }
            }
            Console.WriteLine("Naturals: "+string.Join(", ",Natur));
            Console.WriteLine("Sharps: "+string.Join(", ",sharp));
            Console.WriteLine($"Naturals sum: {naturalSum}");
            Console.WriteLine($"Sharps sum: {sharpSum}");
        }
    }
}
