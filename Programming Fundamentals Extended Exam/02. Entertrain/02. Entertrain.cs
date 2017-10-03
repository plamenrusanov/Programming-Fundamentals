using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Program
    {
        static List<int> train = new List<int>();
        static void Main(string[] args)
        {
            int locomotive = int.Parse(Console.ReadLine());
            string wagon = Console.ReadLine();
            
            while (wagon != "All ofboard!")
            {
                train.Add(int.Parse(wagon));
                int totalSum = train.Sum();
                if (totalSum > locomotive)
                {
                    Entertraining();
                }
                wagon = Console.ReadLine();
            }
            train.Reverse();
            train.Add(locomotive);
            Console.WriteLine(string.Join(" ",train));
        }

        private static void Entertraining()
        {
            double average = (int)train.Average();
            double minDiff = double.MaxValue;
            int index = -1;
            for (int i = 0; i < train.Count; i++)
            {
                double diff = Math.Abs(train[i] - average);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    index = i;
                }
            }
            train.RemoveAt(index);

        }
    }
}
