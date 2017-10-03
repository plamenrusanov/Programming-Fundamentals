using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder bilder = new StringBuilder();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 50000; i++)
            {
                bilder.Append("a");
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            sw.Reset();
            sw.Start();
            string text = "";
            for (int i = 0; i < 50000; i++)
            {
                text += "a";
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Lab.strinBilder();




            string first = "123abcd";
            bool isDigit = first.All(char.IsDigit);
            bool isLetterOrDigit = first.All(char.IsLetterOrDigit);
            bool isLetter = first.All(char.IsLetter);
            bool isne = first.All(char.IsNumber);
            bool isAnyDigit = first.Any(char.IsDigit);
            Console.WriteLine(isDigit);
            Console.WriteLine(isLetterOrDigit);
            Console.WriteLine(isLetter);
            Console.WriteLine(isne);
            Console.WriteLine(isAnyDigit);
           

        }
    }
    class Lab
    {
        static public void strinBilder()
        {
            StringBuilder bild = new StringBuilder();
            bild.Append("Hello");
            bild[0] = 'B';
            Console.WriteLine(bild);
            StringBuilder bilder = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                bilder.Append('a');
                Console.WriteLine("capacity: " + bilder.Capacity);
                Console.WriteLine("length: " + bilder.Length);
                Console.WriteLine("maxCapacity: " + bilder.MaxCapacity);
              

            }
        }
      
    }
}
