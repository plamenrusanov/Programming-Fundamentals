using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class BPM_Counter
    {
        static void Main(string[] args)
        {
            int beatPerMinute = int.Parse(Console.ReadLine());
            double beats = double.Parse(Console.ReadLine());

            double bars = Math.Round(beats / 4d,1);
            double minutes = beatPerMinute / beats;
            double secands = (beatPerMinute % beats) / beats;
            Console.WriteLine(beatPerMinute % beats);
            Console.WriteLine(secands);
        }
    }
}
