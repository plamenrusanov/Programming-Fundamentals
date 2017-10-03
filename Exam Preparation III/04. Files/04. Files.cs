using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {          
            List<File> a = new List<File>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                string main = input[0];
                string road = "";
                string file = "";
                ulong size = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (j > 0 && j < input.Length - 1)
                    {
                        road += input[j];
                    }
                    else if (j == input.Length - 1)
                    {
                        string[] token = input[input.Length - 1].Split(new char[] { ';' }, StringSplitOptions.None);
                        file = token[0];
                        size = ulong.Parse(token[1]);
                    }
                }
                foreach (File item in a)
                {
                    if (item.Main == main && item.Road == road && item.FileName == file)
                    {
                        item.Size = size;                       
                    }
                    else
                    {
                        a.Add(new File(main, road, file, size));
                    }
                }
                bool isWrite = parceis
                int count = a.Count;
                if (count == 0)
                {
                    
                    isWrite = true;
                }                   
                for (int cnt = 0; cnt < count; cnt++)
                {
                    if (a[cnt].Main == main && a[cnt].Road == road && a[cnt].FileName == file)
                    {
                        
                        a[cnt].Size = size;
                        isWrite = true;
                    }                                 
                }
                if (!isWrite)
                {
                    a.Add(new File(main, road, file, size));
                }
            }
            string[] filter = Console.ReadLine().Split();
            string filterEx = filter[0];
            string filtermain = filter[2];
            bool isFind = false;
            
            foreach (File item in a.OrderByDescending(s => s.Size).ThenBy(s => s.FileName))
            {
                if (item.FileName.Contains(filterEx) && item.Main == filtermain)
                {
                    Console.WriteLine($"{item.FileName} - {item.Size} KB");
                    isFind = true;
                }
            }
            if (!isFind)
            {
                Console.WriteLine("No");
            }
        }
    }
    class File
    {
        public string Main { get; set; }
        public string Road { get; set; }
        public string FileName { get; set; }
        public ulong Size { get; set; }
        public File(string main, string road, string file, ulong size)
        {
            Main = main;
            Road = road;
            FileName = file;
            Size = size;
        }

    }
}
