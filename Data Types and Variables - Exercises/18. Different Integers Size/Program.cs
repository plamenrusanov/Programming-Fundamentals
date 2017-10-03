using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> integers = new List<string>();
            string input = Console.ReadLine();
            
            bool isFit = false;
            try
            {
                sbyte num = sbyte.Parse(input);
                integers.Add("* sbyte");
                isFit = true;
            }
            catch (Exception)
            {

               // throw;
            }
            try
            {
                byte num = byte.Parse(input);
                integers.Add("* byte");
                isFit = true;
            }
            catch (Exception)
            {

                //throw;
            }
            try
            {
                short num = short.Parse(input);
                integers.Add("* short");
                isFit = true;
            }
            catch (Exception)
            {

                //throw;
            }
            try
            {
                ushort num = ushort.Parse(input);
                integers.Add("* ushort");
                isFit = true;
            }
            catch (Exception)
            {

               // throw;
            }
            try
            {
                int num = int.Parse(input);
                integers.Add("* int");
                isFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                uint num = uint.Parse(input);
                integers.Add("* uint");
                isFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                long num = long.Parse(input);
                integers.Add("* long");
                isFit = true;
            }
            catch (Exception)
            {

            }
            if (!isFit)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{input} can fit in:");
                Console.WriteLine(string.Join("\n",integers));
            }
           
        }

    }
}    

