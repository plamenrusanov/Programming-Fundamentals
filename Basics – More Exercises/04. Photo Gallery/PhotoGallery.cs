using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            int taken = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int sizeBite = int.Parse(Console.ReadLine());
            int wedth = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());

            double size = 0.0;
            string sizeEnd = "";
            string orientation = "";

            if (sizeBite >= 1000000)
            {
                size = sizeBite / 1000000d;
                sizeEnd = "MB";
            }
            else if (sizeBite >= 1000)
            {
                size = sizeBite / 1000d;
                sizeEnd = "KB";
            }
            else
            {
                size = sizeBite;
                sizeEnd = "B";
            }
            if (wedth < heigth)
            {
                orientation = "portrait";
            }
            else if (wedth > heigth)
            {
                orientation = "landscape";
            }
            else if (wedth == heigth)
            {
                orientation = "square";
            }

            Console.WriteLine($"Name: DSC_{taken:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            Console.WriteLine($"Size: {size}{sizeEnd}");
            Console.WriteLine($"Resolution: {wedth}x{heigth} ({orientation})");
        }
    }
}
