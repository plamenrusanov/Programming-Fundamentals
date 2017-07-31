using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstRectArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondRectArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle firstRectangle = new Rectangle
            {
                Top = firstRectArgs[1],
                Left = firstRectArgs[0],
                Width = firstRectArgs[2],
                Height = firstRectArgs[3]
            };
            Rectangle secondRectangle = new Rectangle
            {
                Top = secondRectArgs[1],
                Left = secondRectArgs[0],
                Width = secondRectArgs[2],
                Height = secondRectArgs[3]
            };
            if (firstRectangle.IsInside(secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }
            public int Rigth
            {
                get
                {
                    return Left + Width;
                }
            }
            int CalcArea()
            {
                return Width * Height;
            }
            public bool IsInside (Rectangle r)
            {
                return Left >= r.Left && Top >= r.Top && Bottom <= r.Bottom && Rigth <= r.Rigth;
            }
        }
    }
}

