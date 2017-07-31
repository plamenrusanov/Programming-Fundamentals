using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.String_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = nums[0];
            int n = nums[1];
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();
            data = data.Where(d => d >= 65 && d <= 90).Skip(m).Take(n).ToList();
            string result = "";
            for (int i = 0; i < data.Count; i++)
            {
                result += (char)data[i];
            }
            Console.WriteLine(result);
        }
    }
}
