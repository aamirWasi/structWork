using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(23,4);
            rect1.Area();
        }
        struct Rectangle
        {
            public double length;
            public double width;
            public Rectangle(double l,double w)
            {
                length = l;
                width = w;
            }
            public void Area()
            {
                double sum =  length * width;
                Console.WriteLine("Area of Rectangle is {0}",sum);
            }
        }
    }
}
