using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class RotateArrayOfString
    {
        static void Main(string[] args)
        {
            //string[] arr = Console.ReadLine()
            //    .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            //      ---> razdelq ot interval , i premahva praznite poleta !!!
            //for (int cnt = 0; cnt < arr.Length; cnt++)
            //{
            //    Console.WriteLine(arr[cnt]);
            //}
            string[] arr = Console.ReadLine().Split(' ');
            string[] resultArr = new string[arr.Length];

            for (int cnt = 0; cnt < arr.Length ; cnt++)
            {
                resultArr[(cnt +1  ) % arr.Length] = arr[cnt];
            }
            //resultArr[0] = arr[arr.Length - 1];

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
