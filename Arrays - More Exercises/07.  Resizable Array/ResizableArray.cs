using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Resizable_Array
{
    class ResizableArray
    {
        static int[] Arr = new int[2];

        static int currentIndex = 0;
        
         static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ');
            
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "push":
                        Arr[currentIndex] = int.Parse(command[1]);
                        currentIndex++;
                        if (currentIndex >= Arr.Length)
                        {
                            GrowArray();
                        }
                        break;
                    case "removeAt":
                        int index = int.Parse(command[1]);
                        ShiftArray(Arr,index);
                        currentIndex--;
                        break;
                    case "pop":
                        Arr[currentIndex] = 0;
                        currentIndex--;
                        break;
                    case "clear":
                        ClearArray(Arr);
                        currentIndex = 0;
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine().Split(' ');
            }
            PrintArray(Arr);
        }
        static void PrintArray(int[]Arr)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                Console.Write(Arr[i]+" ");
            }
            Console.WriteLine();
        }
        static void GrowArray()
        {
            int[] Array = new int[Arr.Length * 2];
            for (int cnt = 0; cnt < currentIndex; cnt++)
            {
                Array[cnt] = Arr[cnt];
            }
            Arr = Array;
        }
        static void ShiftArray(int[]Arr,int index)
        {
            for (int cnt = index +1 ; cnt < Arr.Length; cnt++)
            {
                Arr[cnt - 1] = Arr[cnt];
            }
        }
        static void ClearArray(int[]Arr)
        {
            currentIndex = 0;
        }
    }
}
