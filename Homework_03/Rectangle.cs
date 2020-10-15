using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03
{
    class Rectangle
    {
        public double Height { get; private set; }
        public double Width { get; private set; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public Rectangle()
        {
            Height = 0;
            Width = 0;
        }
        public double GetArea()
        {
            return Height * Width;
        }

        public void Print()
        {
            Console.WriteLine($"Height: {Height}, Width: {Width}");
        }

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                    Console.Write("# ");

                Console.WriteLine();
            }
        }
    }
}
