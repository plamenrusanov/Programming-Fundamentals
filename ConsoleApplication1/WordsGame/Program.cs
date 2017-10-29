using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5.Aray_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = "к а т а к р и".Split();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                
                sb.Append(input[i]);
                for (int j = 0; j < input.Length; j++)
                {
                    sb.Append(input[j]);
                    for (int k = 0; k < input.Length; k++)
                    {
                        sb.Append(input[k]);
                        for (int l = 0; l < input.Length; l++)
                        {
                            sb.Append(input[l]);
                            for (int q = 0; q < input.Length; q++)
                            {
                                sb.Append(input[q]);
                                for (int w = 0; w < input.Length; w++)
                                {
                                    sb.Append(input[w]);
                                    for (int e = 0; e < input.Length; e++)
                                    {
                                        sb.Append(input[e]);
                                        Console.WriteLine(input[i]);
                                    }
                                    sb = sb.Clear();
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}