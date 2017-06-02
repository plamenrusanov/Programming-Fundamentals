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

            double bars = Math.Round(beats / 4d, 1);
            int minutes = (int)(beats / beatPerMinute);
            double coeficient = (beatPerMinute / 60d);
            int sec = (int)(beats / coeficient) % 60;


            Console.WriteLine($"{bars} bars - {minutes}m {sec}s");
        }
    }
}
