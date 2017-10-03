using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());
            long filter = numberOfPictures * filterTime;
            double filteredPictures = Math.Ceiling (numberOfPictures * (filterFactor / 100.0));
            double upload = filteredPictures * uploadTime;
            double resultSeconds = filter + upload;
            double seconds = resultSeconds % 60;
            double minutes = Math.Floor((resultSeconds / 60)) % 60;
            double hours = Math.Floor((resultSeconds / 3600)) % 24;
            double days = Math.Floor((resultSeconds / 3600)) / 24;
            Console.WriteLine($"{(int)days}:{(int)hours:d2}:{(int)minutes:d2}:{(int)seconds:d2}");
        }
    }
}
