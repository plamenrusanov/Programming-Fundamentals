using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Debugging_Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double signDiff = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                double newPrice = double.Parse(Console.ReadLine());
                double diff = Diff(lastPrice, newPrice);
                // bool isSignDiff = IsDiff(diff, signDiff);
                string message = GetMessage(newPrice, lastPrice, diff, signDiff);  //bool isSignDiff
                Console.WriteLine(message);

                lastPrice = newPrice;
            }
        }
        private static string GetMessage(double newPrice, double lastPrice, double dif, double signDiff) // bool isSignDiff
        {
            string message = string.Empty;
            if (dif == 0)
            {
                message = string.Format("NO CHANGE: {0}", newPrice);
            }
            else if (signDiff > Math.Abs(dif))
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, newPrice, dif * 100);
            }
            else if (dif >= signDiff)
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, newPrice, dif * 100);
            }
            else if (dif <= signDiff)
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, newPrice, dif * 100);
            return message;
        }
        //private static bool IsDiff(double diff, double signDiff)
        //{
        //    if (Math.Abs(signDiff) >= diff)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        private static double Diff(double lastPrice, double newPrice)
        {
            double diff = ((newPrice - lastPrice) / lastPrice);
            return diff;
        }
    }

}
    

